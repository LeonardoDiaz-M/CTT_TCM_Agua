Public Class frmPassword
    Private usr As New clsUser
    Private cxn As New cxnData
    Public myparent As String = Nothing
    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usr.UserName = CurrentUsrName
        Me.txtUser.Text = CurrentUsrName
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
    End Sub

    Private Sub tsb_Guardar_Click(sender As Object, e As EventArgs) Handles tsb_Guardar.Click

        If Me.txtContraseña.Text.Trim <> "" Then
            usr.Password = Me.txtContraseña.Text.Trim
            If Not usr.LoginUser() Then
                cMensajes.DisplayMessage(Me, usr.UsrErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Else
            cMensajes.DisplayMessage(Me, "La contraseña no debe estar vacía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If Me.txtContraseñaNueva.Text.Trim <> "" Then
            If Me.txtConfirmaContraseñaNueva.Text.Trim <> "" Then
                If StrComp(Me.txtConfirmaContraseñaNueva.Text.Trim, Me.txtContraseñaNueva.Text.Trim, CompareMethod.Binary) = 0 Then
                    usr.Password = Me.txtConfirmaContraseñaNueva.Text.Trim
                    usr.Actualiza_Password()
                    Me.Close()
                Else
                    cMensajes.DisplayMessage(Me, "Las Contraseña y la confirmación no coinciden...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtContraseñaNueva.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "La Confirmación de la contraseña, no debe estar vacía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtConfirmaContraseñaNueva.Focus()
            End If
        Else
            cMensajes.DisplayMessage(Me, "La contraseña no debe estar vacía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.txtContraseña.Focus()
        End If

    End Sub

    Private Sub tsb_Salir_Click(sender As Object, e As EventArgs) Handles tsb_Salir.Click
        If myparent = "main" Then
            Me.Close()
        Else
            End
        End If
    End Sub
End Class