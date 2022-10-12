Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Padron_Imagenes
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Dim IdFoto As String = ""

    Private Sub Padron_Imagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load_Permiso()
    End Sub
    Private Sub load_Permiso()
        'Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = Borrar
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnNuevo.Visible = Insertar

        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        Else
        End If
    End Sub
    Public Overloads Sub Show(ByVal ClavePadron As String, ByVal TipoPadron As String, ByVal parent As IWin32Window)
        Try

            lblClavePadron.Text = ClavePadron.Trim
            lblTipoPadron.Text = TipoPadron.Trim
            Carga_Imagenes(ClavePadron, TipoPadron)
            Me.ShowDialog()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Existe un error:" & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub Carga_Imagenes(ByVal ClavePadron As String, ByVal TipoPadron As String)
        Dim cxn1 As New cxnData
        Dim dt As DataTable
        dt = cxn1.Get_SQL_Datatable("select *  from images where clavepadron='" & ClavePadron & "' AND TipoPadron='" & TipoPadron & "'")
        griImagenes.DataSource = dt
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cxn As New cxnData
        Using connection As New SqlConnection(cxn.SqlPubsConnString)
            connection.Open()
            Try
                Dim stream As FileStream = New FileStream(txtexaminar.Text, FileMode.Open, FileAccess.Read)
                Dim br As BinaryReader = New BinaryReader(stream)
                Dim fi As FileInfo = New FileInfo(txtexaminar.Text)
                Dim binData() As Byte = New Byte((stream.Length) - 1) {}
                Dim Guid As New System.Guid
                Dim Valnewid As String
                Dim sql As String
                'Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                'Lee el bloque de bytes del flujo y escribe los datos en un bufer dado.
                stream.Read(binData, 0, Convert.ToInt32(stream.Length))
                'Se muetra la imagen obtenida desde el flujo de datos
                picImagen.Image = Image.FromStream(stream)
                'consulto identificar unico
                sql = "select NEWID()"
                Dim cmd As SqlCommand = New SqlCommand(sql, connection)
                cmd.ExecuteNonQuery()
                Valnewid = cmd.ExecuteScalar.ToString
                'inserto imagen y datos tabla
                sql = "INSERT INTO IMAGES (Id,TipoPadron,ClavePadron,IMAGEFILE,Descripcion) VALUES(@Id,@TipoPadron,@ClavePadron,@ImageFile,@Descripcion)"
                Dim command As SqlCommand = New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("ID", Valnewid)
                command.Parameters.AddWithValue("TipoPadron", lblTipoPadron.Text)
                command.Parameters.AddWithValue("ClavePadron", lblClavePadron.Text)
                command.Parameters.AddWithValue("ImageFile", binData)
                command.Parameters.AddWithValue("Descripcion", UTEDescripcion.Text)
                command.ExecuteNonQuery()
                Carga_Imagenes(lblClavePadron.Text, lblTipoPadron.Text)
                btnGuardar.Visible = False
                btnElimina.Visible = False
                UTEDescripcion.ReadOnly = True
                cMensajes.DisplayMessage(Me, "Imagen agregada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Finally
                connection.Close()
                Me.Cursor = Cursors.Default
            End Try
        End Using
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ofdArchivos.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;"
        Dim dres1 As DialogResult = ofdArchivos.ShowDialog
        If (dres1 = DialogResult.Abort) Then
            Return
        End If

        If (dres1 = DialogResult.Cancel) Then
            Return
        End If
        txtexaminar.Text = ofdArchivos.FileName
        btnGuardar.Visible = True
        btnElimina.Visible = False
        UTEDescripcion.ReadOnly = False
        picImagen.Image = Image.FromFile(ofdArchivos.FileName)
    End Sub

    Private Sub griImagenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles griImagenes.CellDoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim binario() As Byte
        IdFoto = griImagenes.Rows(e.RowIndex).Cells("id").Value.ToString
        binario = griImagenes.Rows(e.RowIndex).Cells("ImageFile").Value
        picImagen.Image = Image.FromStream(New MemoryStream(binario))
        UTEDescripcion.Text = griImagenes.Rows(e.RowIndex).Cells("Descripcion").Value.ToString
        btnGuardar.Visible = False
        btnElimina.Visible = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            Dim Sql As String = ""
            Using connection As New SqlConnection(cxn.SqlPubsConnString)
                connection.Open()
                Try
                    If MsgBox("¿Está seguro de borrar la imagen seleccionada?", vbYesNo, "Confirmación") = vbYes Then
                        Sql = "DELETE IMAGES WHERE ID='" & IdFoto.ToString & "'"
                        Dim cmd As SqlCommand = New SqlCommand(Sql, connection)
                        cmd.ExecuteNonQuery()
                        Carga_Imagenes(lblClavePadron.Text, lblTipoPadron.Text)
                        picImagen.Image = Nothing
                        btnElimina.Visible = False
                        cMensajes.DisplayMessage(Me, "Imagen borrada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    End If
                Catch ex As Exception
                    cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Finally
                    connection.Close()
                    Me.Cursor = Cursors.Default
                End Try
            End Using
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

End Class