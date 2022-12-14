Public Class frmMenuRoot
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmMenuRoot_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblCurrentMenu.Text = "Menu: " & id.ToString
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.txtDesc.Enabled = False
        Me.chkStatus.Enabled = False

        If Editar And id <> "0" Then  'Actualizar Registro
            Me.txtClave.Enabled = False
            Me.txtDesc.Enabled = True
            Me.btnGuardar.Visible = True
            chkStatus.Visible = True
            chkStatus.Enabled = True
            Me.txtClave.Text = id.ToString
            load_datos()
        ElseIf Insertar And id = "0" Then 'Agregar Registro
            Me.txtClave.Enabled = True
            Me.Text = "Nuevo Menú"
            Me.lblCurrentMenu.Text = "Nuevo Menú"
            Me.txtDesc.Enabled = True
            Me.lblCve.Text = "Clave del Menú: "
            Me.btnGuardar.Visible = True
            Me.chkStatus.Visible = True
            chkStatus.Enabled = True
        End If
    End Sub
    Private Sub load_datos()
        cxn.Select_SQL("select MenuNam,Description,Status from tbMainMenu where MenuNam='" & id & "'")
        Me.txtClave.Text = cxn.arrayValores(0)
        Me.txtDesc.Text = cxn.arrayValores(1).ToUpperInvariant
        Me.chkStatus.Checked = IIf(cxn.arrayValores(2) = "1", True, False)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtClave.Text.Trim.Length > 0 Then
                If Me.txtDesc.Text.Trim.Length >= 3 Then
                    ban = True
                Else
                    cMensajes.DisplayMessage(Me, "El campo Título del menú es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtDesc.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo CLAVE del menú es requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtClave.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                cxn.Select_SQL("select * from tbMainMenu where MenuNam='" & id & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.Validate()
                    If Me.cxn.Select_SQL("update tbMainMenu set Description='" & Me.txtDesc.Text.Trim & "'," &
                                         "Status=" & IIf(Me.chkStatus.Checked, 1, 0) &
                                         " where MenuNam='" & id & "'") Then
                        cxn.Select_SQL("update tbMainSubMenus set Status=" & IIf(Me.chkStatus.Checked, "1", "0") & " where Parent='" & id & "'")

                        cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    If Me.cxn.Select_SQL("insert into tbMainMenu (MenuNam, Description, Status) values ('" &
                                         Me.txtClave.Text.Trim.ToUpperInvariant & "',
                                         '" & Me.txtDesc.Text.Trim & "','" &
                                         IIf(Me.chkStatus.Checked, 1, 0) & "')") Then
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If
                Me.Close()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub


End Class