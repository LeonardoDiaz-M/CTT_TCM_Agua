Public Class Pae_DetalleCalculo_DerechosAgua
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private Sub Pae_DetalleCalculo_DerechosAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ViePaeDetalleCalculoDerechoAguaTableAdapter.Fill(Me.DsPae.viePaeDetalleCalculoDerechoAgua)
    End Sub

    Private Sub btnExportaExcel_Click(sender As Object, e As EventArgs) Handles btnExportaExcel.Click
        Dim sfd As New SaveFileDialog

        If griDetalle.Rows.Count > 0 Then
            With sfd
                .Title = "Ingresa el nombre del archivo a exportar"
                .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    Me.Cursor = Cursors.WaitCursor
                    ugeExporter.Export(griDetalle, .FileName)
                    Me.Cursor = Cursors.Default
                    MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                End If
            End With
        Else
            MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
End Class