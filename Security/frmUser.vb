Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmUser
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Private newrow As Object
    Public myParent As Form = Nothing
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblCurrentMenu.Text = Me.Text
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.DownFirst)
        Me.Users_ProfilesTableAdapter.Fill(Me.DsSeguridad.Users_Profiles)
        cxn.Get_SQL_Combobox("SELECT * from tbl_rol where status=1", Me.cmbRol, "RolName", "idRol")
        cxn.Get_SQL_Combobox("SELECT * from tb_WEBRol where status=1", Me.cmbRolWEB, "WebRolName", "idWebRol")
        cxn.fLlenaDropDownUltra(Me.ucoPuesto, "Select pueId,pueDescripcion from puestos")
        cxn.fLlenaDropDownUltra(ucoOficina, "Select comun, nombre from Oficinas")
        If id <> "0" Then
            Me.BindingSource1.Position = Me.BindingSource1.Find("id", id)
        End If

        load_Permiso()
    End Sub
    Private Sub load_Permiso()

        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpDatos.Enabled = IIf(id = "0", Insertar, False)
        Me.grpSistema.Enabled = IIf(id = "0", Insertar, False)
        Me.btnActiva.Visible = False
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            Me.chkActive.Checked = True
            Me.txtFechaCreacion.Text = Now
            Me.btnReset.Visible = False
        Else
            cxn.Select_SQL("Select proFechaBaja from Users_Profiles where id=" & id)
            If cxn.arrayValores(0) IsNot Nothing And cxn.arrayValores(0) <> "" And cxn.err = "" Then
                Me.grpDatos.Enabled = False
                Me.grpSistema.Enabled = False
                Me.btnActiva.Visible = True
                Me.btnEditar.Visible = False
                Me.btnElimina.Visible = False
                Me.btnGuardar.Visible = False
            End If
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try

            If Me.txtUserId.Text.Trim.Length > 0 Then
                If Me.txtMaterno.Text.Trim.Length > 0 And Me.txtPaterno.Text.Trim.Length > 0 And Me.txtNombre.Text.Trim.Length > 0 Then
                    If Me.ucoOficina.SelectedRow.Index >= 0 And Me.ucoPuesto.SelectedRow.Index >= 0 Then
                        If Me.cmbRol.SelectedIndex > 0 Then
                            ban = True
                            If Me.chkWEB.Checked Then
                                If Me.cmbRolWEB.SelectedIndex > 0 Then
                                    ban = True
                                Else
                                    ban = False
                                    cMensajes.DisplayMessage(Me, "El Campo ROL WEB es requerido...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.cmbRolWEB.Focus()
                                End If
                            End If
                        Else
                            cMensajes.DisplayMessage(Me, "El Campo ROL es requerido...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Me.cmbRol.Focus()
                        End If
                    Else
                        cMensajes.DisplayMessage(Me, "Los campos Nombre, Paterno y Materno son  requeridos ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        If ucoOficina.SelectedRow.Index = 0 Then
                            Me.ucoOficina.Focus()
                        Else
                            Me.ucoPuesto.Focus()
                        End If
                    End If
                Else
                    cMensajes.DisplayMessage(Me, "Los campos Nombre, Paterno y Materno son  requeridos ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtNombre.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo UserId es requerido ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtUserId.Focus()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "valida_datos: " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Desactivar el Usuario?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                cxn.Select_SQL("select dbo.getdateMx()")
                Me.BindingSource1.Current("UltimaModificacion") = cxn.arrayValores(0)
                Me.BindingSource1.Current("proFechaBaja") = cxn.arrayValores(0)
                Me.BindingSource1.Current("proActivo") = 0
                Me.BindingSource1.EndEdit()
                Me.Users_ProfilesTableAdapter.Update(Me.DsSeguridad.Users_Profiles)
                cMensajes.DisplayMessage(Me, "Usuario Eliminado... ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                frmUser_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Elimina " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                Me.cxn.Select_SQL("select dbo.getdateMx()")
                If id <> "0" And Editar Then
                    Me.Validate()
                    Me.BindingSource1.Current("UltimaModificacion") = cxn.arrayValores(0)
                    Me.BindingSource1.Current("proActivo") = IIf(Me.chkActive.Checked, 1, 0)
                    Me.BindingSource1.Current("proValidaUbicacion") = IIf(Me.chkAddress.Checked, 1, 0)
                    Me.BindingSource1.EndEdit()
                    Me.Users_ProfilesTableAdapter.Update(Me.DsSeguridad.Users_Profiles)
                    cMensajes.DisplayMessage(Me, "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Dim userKey As Guid = Guid.NewGuid()
                    Users_ProfilesTableAdapter.Insert(Me.txtUserId.Text.Trim.ToUpperInvariant,
                                                       Me.txtNombre.Text.Trim.ToUpperInvariant,
                                                       Me.txtPaterno.Text.Trim.ToUpperInvariant,
                                                       Me.txtMaterno.Text.Trim.ToUpperInvariant,
                                                       Me.ucoPuesto.Value, Me.ucoOficina.Value,
                                                       Me.txtTelefono.Text.Trim,
                                                       IIf(Me.chkActive.Checked, True, False),
                                                       cxn.arrayValores(0), 'Fecha Alta
                                                       Nothing, Nothing, IIf(Me.chkAddress.Checked, True, False),
                                                       Me.txtNumeroCaja.Text.Trim, userKey,
                                                       Nothing, Me.cmbRol.SelectedValue,
                                                       Me.txtEmail.Text.Trim, Nothing, cxn.arrayValores(0),
                                                       IIf(Me.chkWEB.Checked, True, False),
                                                       IIf(Me.chkWEB.Checked, Me.cmbRol.SelectedValue, Nothing)
                                                       )
                    Me.Users_ProfilesTableAdapter.Update(Me.DsSeguridad.Users_Profiles)
                    cxn.Select_SQL("update Users_Profiles set Password=HASHBYTES('SHA2_512', 
                                    proUserId+CAST(UsrKey AS NVARCHAR(36))) where proUserId='" & Me.txtUserId.Text.Trim & "'")
                    cMensajes.DisplayMessage(Me, "Usuario registrado ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
                frmUser_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Guardar " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grpDatos.Enabled = True
            Me.grpSistema.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnActiva_Click(sender As Object, e As EventArgs) Handles btnActiva.Click
        Try
            If MsgBox("¿Seguro de ACTIVAR el Usuario?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                cxn.Select_SQL("select dbo.getdateMx()")
                Me.BindingSource1.Current("UltimaModificacion") = cxn.arrayValores(0)
                Me.BindingSource1.Current("proFechaBaja") = DBNull.Value
                Me.BindingSource1.EndEdit()
                Me.Users_ProfilesTableAdapter.Update(Me.DsSeguridad.Users_Profiles)
                cMensajes.DisplayMessage(Me, "Usuario ACTIVADO... ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                frmUser_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Elimina " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub BindingSource1_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles BindingSource1.BindingComplete
        If id <> "0" Then
            If Me.txtBaja.Text.Trim <> "" Or Me.txtBaja.Text.Trim IsNot Nothing Then
                Me.grpDatos.Enabled = False
                Me.grpSistema.Enabled = False
                Me.btnActiva.Visible = True
                Me.btnEditar.Visible = False
                Me.btnElimina.Visible = False
                Me.btnGuardar.Visible = False
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            If MsgBox("¿Seguro de RESETEAR PASSWORD del Usuario?", vbYesNo, "Confirmación") = vbYes Then
                cxn.Select_SQL("update Users_Profiles set UltimoAcceso=null, 
                                    Password=HASHBYTES('SHA2_512',
                                    proUserId+CAST(UsrKey AS NVARCHAR(36))) 
                                where proUserId='" & Me.txtUserId.Text.Trim & "'")
                cMensajes.DisplayMessage(Me, "Password Cambiado... ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                frmUser_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Elimina " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub chkWEB_CheckedChanged(sender As Object, e As EventArgs) Handles chkWEB.CheckedChanged
        Me.cmbRolWEB.Enabled = Me.chkWEB.Checked
    End Sub
End Class