Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmCatRutas
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public myparent As Form = Nothing
    Private Sub frmCatTipoinmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.RutasTableAdapter.Fill(Me.DsAgua.rutas)
        If id <> "0" Then
            Me.BindingSource1.Position = Me.BindingSource1.Find("id_ruta", id)
            txtDescripcion.SelectAll()
        End If
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpDatos.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtDescripcion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtDescripcion, "Error")
                cMensajes.DisplayMessage(Me, "El campo descripcion es requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ban = True
                Me.txtDescripcion.Focus()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        BindingSource1.CancelEdit()
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If Editar And id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.RutasTableAdapter.Update(Me.DsAgua.rutas)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Insertar And id = "0" Then
                    RutasTableAdapter.Insert(txtDescripcion.Text.Trim)
                    Me.RutasTableAdapter.Update(Me.DsAgua.rutas)
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                Dim cxn As New cxnData
                cxn.Select_SQL("select id_ruta from tbl_Rol where id_ruta='" & Me.txtClave.Text.Trim & "'")
                If cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
                    id = cxn.arrayValores(0)
                    frmCatTipoinmueble_Load(Nothing, Nothing)
                Else
                    cMensajes.DisplayMessage(Me, "No existe la ruta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grpDatos.Enabled = True
        End If
    End Sub
End Class