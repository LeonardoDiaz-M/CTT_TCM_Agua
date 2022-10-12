Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmWebRoles
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cxn As New cxnData
            Dim cxn2 As New cxnData
            Dim dsSubMenus As New DataSet("Menus")
            Dim parentColumns As DataColumn()
            Dim childColumns As DataColumn()
            TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
            load_Permiso()
            If id = 0 Then
                dsSubMenus = cxn.Select_SQL("Select cast(0 as bit) as [Check], 
                                                idMenu as id, 
                                                ltrim(rtrim(upper(MenuName))) as Menu,
                                                MenuDescription as Nombre 
                                        from tb_WEBMenus 
                                        where Status=1 and idMenuParent=0", dsSubMenus, "rt")
                dsSubMenus = cxn2.Select_SQL("Select  cast(0 as bit) as [Check],
                                                  idMenuParent  as Parent,
                                                  idMenu as IdSubMenu,
                                                  MenuName,
                                                  MenuDescription as [Nombre SUBMENU]		
                                          from tb_WEBMenus sb
                                          where status=1  and idMenuParent>0", dsSubMenus, "sb")
            Else
                Me.Tb_WEBRolTableAdapter1.Fill(Me.DsSeguridad1.tb_WEBRol)
                Me.BindingSource1.Position = Me.BindingSource1.Find("idWebRol", id)
                dsSubMenus = cxn.Select_SQL("Select distinct cast(iif(sum(case when p.idMenu is null then 0 else 1 end)>0,1,0) as bit) as [Check],
                                                rt.idMenu as Id,
	                                            ltrim(rtrim(upper(rt.MenuName))) as Menu,
                                                rt.MenuDescription  as Nombre 
                                        from tb_WEBMenus rt
                                            left join tb_WEBMenus sb on sb.idMenuParent = rt.idMenu 
                                            left join tb_WEBProfiles p on p.idMenu = sb.idMenu and p.idWebRol=" & id & "
                                        where rt.Status=1  and rt.idMenuParent=0
                                        group by rt.idMenu, rt.MenuName,rt.MenuDescription ", dsSubMenus, "rt")
                dsSubMenus = cxn2.Select_SQL("Select cast(iif(p.idMenu is null,0,1) as bit) as [Check],
		                                        sb.idMenuParent as Parent,
                                                sb.idMenu as idSubMenu,
		                                        MenuName, 
                                                MenuDescription as [Nombre SUBMENU]		
                                        from tb_WEBMenus sb                                                
	                                        left join tb_WEBProfiles p on p.idMenu = sb.idMenu and idWebRol =" & id & "
                                        where sb.status=1 and sb.idMenuParent>0", dsSubMenus, "sb")
            End If

            parentColumns = New DataColumn() {dsSubMenus.Tables("rt").Columns("id")}
            childColumns = New DataColumn() {dsSubMenus.Tables("sb").Columns("Parent")}

            Dim dsRelation As DataRelation = New DataRelation("Menus", parentColumns, childColumns, True)
            dsSubMenus.Relations.Add(dsRelation)
            Me.grdDataMain.DataSource = dsSubMenus

            Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).CellClickAction = CellClickAction.EditAndSelectText
            Me.grdDataMain.DisplayLayout.Bands(1).Columns(0).CellClickAction = CellClickAction.EditAndSelectText
            Me.grdDataMain.DisplayLayout.Bands(1).Columns(4).CellClickAction = CellClickAction.EditAndSelectText

            Me.grdDataMain.DisplayLayout.Bands(1).Columns(1).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(1).Columns(2).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Override.RowAppearance.BackColor = Color.DimGray
            Me.grdDataMain.DisplayLayout.Bands(0).Override.RowAppearance.ForeColor = Color.White
            Me.grdDataMain.DisplayLayout.Bands(1).Override.RowAlternateAppearance.BackColor = Color.WhiteSmoke
            Me.grdDataMain.DisplayLayout.Bands(1).Override.RowAppearance.ForeColor = Color.Black
            Me.grdDataMain.DisplayLayout.Bands(1).Override.HeaderAppearance.BackColor2 = Color.Blue

            Me.grdDataMain.DisplayLayout.Bands(1).HeaderVisible = True
            Me.grdDataMain.DisplayLayout.Bands(1).Header.Caption = "SUB-MENUS"
            Me.grdDataMain.DisplayLayout.Bands(1).Header.Appearance.BackColor = Color.Silver
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Rol sin Menus asociados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpDatosRol.Enabled = IIf(id = "0", True, False)
        Me.grpTree.Enabled = IIf(id = "0", True, False)

        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If id = "0" Then
                cxn.Select_SQL("select count(*) from tb_WEBRol where WebRolName='" & Me.txtRol.Text.Trim & "'")
                If cxn.arrayValores(0) <> 0 Then
                    cMensajes.DisplayMessage(Me, "El Rol ya existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtRol.SelectAll()
                    Me.txtRol.Focus()
                    Return 0
                End If
            End If


            If Me.txtRol.Text.Trim.Length > 0 Then
                If Me.txtRolDesc.Text.Trim.Trim.Length > 0 Then
                    Dim countnodes As Int16 = 0
                    For Each row In Me.grdDataMain.Rows
                        If row.Cells(0).Value = True Then
                            countnodes += 1
                        End If
                    Next row
                    If countnodes > 0 Then
                        ban = True
                    Else
                        cMensajes.DisplayMessage(Me, "Debe Seleccionar al menos un menu!!.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.grdDataMain.Focus()
                    End If

                Else
                    cMensajes.DisplayMessage(Me, "El campo Descripción es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtRolDesc.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo Rol es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtRol.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                cxn.Select_SQL("select idWebRol from tb_WEBRol where WebRolName='" & Me.txtRol.Text.Trim & "'")
                If id <> "0" And Editar Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Tb_WEBRolTableAdapter1.Update(Me.DsSeguridad1.tb_WEBRol)
                    cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Insertar Then
                    Tb_WEBRolTableAdapter1.Insert(Me.txtRol.Text.Trim.ToUpperInvariant, Me.txtRolDesc.Text.Trim.ToUpperInvariant, IIf(Me.chkActive.Checked, 0, 1))
                    Me.Tb_WEBRolTableAdapter1.Update(Me.DsSeguridad1.tb_WEBRol)
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                Dim idrol As String = ""
                cxn.Select_SQL("select idWebRol from tb_WEBRol where WebRolName='" & Me.txtRol.Text.Trim & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    id = cxn.arrayValores(0)
                    ActualizaRolMenus()
                Else
                    cMensajes.DisplayMessage(Me, "No existe el Rol...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmRol_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tb_WEBRolTableAdapter1.Update(Me.DsSeguridad1.tb_WEBRol)
                cMensajes.DisplayMessage(Me, "Datos eliminados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub ActualizaRolMenus()
        cxn.Select_SQL("delete from tb_WEBProfiles where idWebRol=" & id)
        For Each row In Me.grdDataMain.Rows
            If row.Band.Key = "rt" Then
                For Each rowch In row.ChildBands(0).Rows
                    If rowch.Cells(0).Value = True Then
                        cxn.Select_SQL("insert into tb_WEBProfiles values ('" & id & "','" & rowch.Cells(2).Value & "')")
                    End If
                Next
            End If
        Next row
    End Sub
    Private Sub grdDataMain_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdDataMain.AfterCellUpdate
        Try
            Dim rowActive As UltraGridRow = e.Cell.Row
            If e.Cell.Row.HasChild Then
                For Each rowch In e.Cell.Row.ChildBands(0).Rows
                    rowch.Cells(0).Value = e.Cell.Value
                    rowch.Update()
                Next
            End If
            rowActive.Update()
        Catch ex As Exception

        End Try
        'Me.grdDataMain.PerformAction(UltraGridAction.ExitEditMode)
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grpDatosRol.Enabled = True
            Me.grpTree.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class