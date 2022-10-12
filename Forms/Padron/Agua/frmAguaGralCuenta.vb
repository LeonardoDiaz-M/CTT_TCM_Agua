Public Class frmAguaGralCuenta
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cxn As New cxnData
        If cxn.Select_SQL("select num_cuenta from arc_agua where num_cuenta='" & Me.txtCuenta.Text & "'") Then
            If cxn.arrayValores(0) IsNot Nothing Then
                Dim frmAgua As New frmarcAguaDatos
                frmAgua.id = Me.txtCuenta.Text
                frmAgua.myparent = Me.myparent
                frmAgua.FormBorderStyle = FormBorderStyle.None
                frmAgua.Dock = DockStyle.Fill
                frmAgua.MdiParent = Me.MdiParent
                frmAgua.TopMost = True
                frmAgua.Show()
            Else
                cMensajes.DisplayMessage(Me, "Cuenta erronéa, verifique...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Me.txtCuenta.Text = ""
    End Sub
End Class