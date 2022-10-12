Public Class frmLogin
    Private usr As New clsUser

    <Obsolete>
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        CurrentUsrName = Me.UsernameTextBox.Text.Trim
        usr.UserName = Me.UsernameTextBox.Text.Trim
        usr.Password = Me.PasswordTextBox.Text.Trim
        If usr.LoginUser Then
            If Not usr.checa_Password Then
                frmPassword.myparent = "login"
                frmPassword.ShowDialog(Me)
                End
            End If
            Dim ban As Boolean = usr.registraEquipo()
            Dim cxn As New cxnData
            cxn.Select_SQL("update Users_Profiles set UltimoAcceso=dbo.getdateMx() where proUserId='" & CurrentUsrName & "'")
            If usr.ValidaEquipo Then
                If Not usr.ValidaUbicacionUsuario Then
                    cMensajes.DisplayMessage(Me, usr.UsrErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    'End
                End If
            End If
            Me.Close()
        Else
            Me.lblError.Visible = True
            Me.lblError.Text = usr.UsrErrorMessage
            CurrentUsrName = ""
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        CurrentUsrName = ""
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblError.Visible = False
        CurrentUsrName = ""
    End Sub
End Class
