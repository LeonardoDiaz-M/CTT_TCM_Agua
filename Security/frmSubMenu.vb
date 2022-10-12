Public Class frmSubMenu
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Public ParentMenu As String = ""
    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Permiso()
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.txtDesc.Enabled = False
        Me.txtClave.Enabled = False

        cxn.fLlenaDropDownUltra(Me.cmbMenuParent, "Select MenuNam, MenuNam +'-'+description as Description from tbMainMenu Where Status=1 order by Description")

        Me.Text = "Detalle del SUB Menú: " & id.ToString
        If Editar And id <> "0" Then  'Actualizar Registro
            Me.txtDesc.Enabled = True
            Me.btnGuardar.Visible = True
            chkStatus.Visible = True
            Me.chkStatus.Enabled = True
            Me.txtClave.Text = id.ToString
            load_datos()
        ElseIf Insertar And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo SUB Menú"
            Me.txtDesc.Enabled = True
            Me.lblCve.Text = "Clave del SUB Menú: "
            Me.btnGuardar.Visible = True
            Me.chkStatus.Checked = True
            Me.txtClave.Enabled = True
        End If
        Me.lblCurrentMenu.Text = Me.Text
    End Sub
    Private Sub load_datos()
        Try
            Dim cxn2 As New cxnData
            cxn2.Select_SQL("select description,parent,iconname,Status,isModal,posMnu,iconname from tbMainSubMenus where SubMenu='" & id & "'")
            Me.txtClave.Text = id.ToUpperInvariant
            Me.txtDesc.Text = cxn2.arrayValores(0).ToUpperInvariant
            Me.cmbMenuParent.Value = cxn2.arrayValores(1).ToUpperInvariant
            Me.chkStatus.Checked = IIf(cxn2.arrayValores(3) = "1", True, False)
            Me.numPos.Value = IIf(cxn2.arrayValores(5) > "0", cxn2.arrayValores(5), "99")
            Me.txtIcono.Text = IIf(cxn2.arrayValores(6) <> "", cxn2.arrayValores(6), "")
            Me.lblCurrentMenu.Text = Me.lblRoot.Text & " - Sub Menú: " & id.ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtClave.Text.Trim.Length > 3 Then
                If Me.txtDesc.Text.Trim.Length >= 5 Then
                    ban = True
                Else
                    cMensajes.DisplayMessage(Me, "El campo Descripción del menú es requerido y debe contener al menos 5 caracteres.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtClave.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo Título del menú es requerido y debe contener al menos 3 caracteres.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtClave.Focus()
            End If

        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                cxn.Select_SQL("select * from tbMainSubMenus where SubMenu='" & id & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.Validate()
                    If Me.cxn.Select_SQL("update tbMainSubMenus set 
                                                Parent='" & Me.cmbMenuParent.Value.Trim & "',
                                                Description='" & Me.txtDesc.Text.Trim & "',
                                                IconName=" & IIf(Me.txtIcono.Text.Trim <> "", "'" & Me.txtIcono.Text.Trim & "'", "null") & ",
                                                PosMnu=" & Me.numPos.Value.ToString & ",
                                                Status=" & IIf(Me.chkStatus.Checked, "1", "0") & "" &
                                         "where SubMenu='" & id & "'") Then
                        cxn.Select_SQL("update tbMainMenuTabs set Status=" & IIf(Me.chkStatus.Checked, "1", "0") & " where SubMenu='" & id & "'")
                        cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    If Me.cxn.Select_SQL("insert into tbMainSubMenus (SubMenu,Parent,Description, Status,PosMnu,IconName,DelOpt,UpdOpt,IsModal) values ('" &
                                         Me.txtClave.Text.Trim & "','" & Me.cmbMenuParent.Value.Trim & "'," &
                                         "'" & Me.txtDesc.Text.Trim & "'," &
                                         IIf(Me.chkStatus.Checked, 1, 0) & "," &
                                         "" & Me.numPos.Value.ToString & "," &
                                          IIf(Me.txtIcono.Text.Trim <> "", "'" & Me.txtIcono.Text.Trim & "'", "null") &
                                         ",null," &
                                         "null," &
                                         "null)"
                                         ) Then
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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