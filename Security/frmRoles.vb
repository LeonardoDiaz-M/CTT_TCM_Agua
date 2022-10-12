Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmRoles
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cxn As New cxnData
        Dim cxn2 As New cxnData
        Dim dsSubMenus As New DataSet("Menus")
        Dim parentColumns As DataColumn()
        Dim childColumns As DataColumn()
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        load_Permiso()
        If id = 0 Then
            dsSubMenus = cxn.Select_SQL("Select cast(0 as bit) as [Check], ltrim(rtrimt(upper(MenuNam))),Description as Nombre from tbMainMenu where Status=1", dsSubMenus, "tbMainMenu")
            dsSubMenus = cxn2.Select_SQL("Select cast(0 as bit) as [Check],ltrim(rtrim(upper(Parent))),SubMenu,Description as [Nombre SUBMENU],
                                            cast(0 as bit) as Lectura,cast(0 as bit) as Nuevo,cast(0 as bit) as Eliminar,
                                            cast(0 as bit) as Actualizar 
                                            from tbMainSubMenus sb
                                            where status=1", dsSubMenus, "tbMainSubMenus")
        Else
            Me.Tbl_RolTableAdapter.Fill(Me.DsAgua.tbl_Rol)
            Me.BindingSource1.Position = Me.BindingSource1.Find("idRol", id)
            dsSubMenus = cxn.Select_SQL("Select distinct cast(iif(sum(case when p.idMenu is null then 0 else 1 end)>0,1,0) as bit) as [Check], 
                                           ltrim(rtrim(upper(MenuNam))) as MenuNam,mm.Description as Nombre 
                                        from tbMainMenu mm
                                            left join tbMainSubMenus sb on sb.Parent = mm.MenuNam
                                            left join tbl_Profile p on p.idMenu = sb.SubMenu and idRol=" & id & "
                                        where mm.Status=1
                                        group by MenuNam,mm.Description", dsSubMenus, "tbMainMenu")
            dsSubMenus = cxn2.Select_SQL("Select cast(iif(p.idMenu is null,0,1) as bit) as [Check],
                                            ltrim(rtrim(upper(Parent))) as Parent,SubMenu,
                                            Description as [Nombre SUBMENU],
                                            p.ReadOpt as Lectura, p.AddOpt as Nuevo,p.DelOpt as Eliminar,p.UpdOpt as Actualizar 
                                            from tbMainSubMenus sb                                                
                                                left join tbl_Profile p on p.idMenu = sb.SubMenu and idRol=" & id & "
                                            where sb.status=1 ", dsSubMenus, "tbMainSubMenus")
        End If

        parentColumns = New DataColumn() {dsSubMenus.Tables("tbMainMenu").Columns("MenuNam")}
        childColumns = New DataColumn() {dsSubMenus.Tables("tbMainSubMenus").Columns("Parent")}

        Dim dsRelation As DataRelation = New DataRelation("Menus", parentColumns, childColumns, True)
        dsSubMenus.Relations.Add(dsRelation)
        Me.grdDataMain.DataSource = dsSubMenus

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(0).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(4).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(5).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(6).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(7).CellClickAction = CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(1).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(0).Override.RowAppearance.BackColor = Color.DimGray
        Me.grdDataMain.DisplayLayout.Bands(0).Override.RowAppearance.ForeColor = Color.White
        Me.grdDataMain.DisplayLayout.Bands(1).Override.RowAlternateAppearance.BackColor = Color.WhiteSmoke
        Me.grdDataMain.DisplayLayout.Bands(1).Override.RowAppearance.ForeColor = Color.Black
        Me.grdDataMain.DisplayLayout.Bands(1).Override.HeaderAppearance.BackColor2 = Color.Blue

        Me.grdDataMain.DisplayLayout.Bands(1).HeaderVisible = True
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Caption = "SUB-MENUS"
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Appearance.BackColor = Color.Silver
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
                cxn.Select_SQL("select count(*) from tbl_rol where RolName='" & Me.txtRol.Text.Trim & "'")
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
                cxn.Select_SQL("select idRol from tbl_Rol where RolName='" & Me.txtRol.Text.Trim & "'")
                If id <> "0" And Editar Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                    cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Insertar Then
                    Tbl_RolTableAdapter.Insert(Me.txtRol.Text.Trim.ToUpperInvariant, Me.txtRolDesc.Text.Trim.ToUpperInvariant, IIf(Me.chkActive.Checked, 0, 1))
                    Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                Dim idrol As String = ""
                cxn.Select_SQL("select idRol from tbl_Rol where RolName='" & Me.txtRol.Text.Trim & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    idrol = cxn.arrayValores(0)
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
                Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                cMensajes.DisplayMessage(Me, "Datos eliminados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub ActualizaRolMenus()
        cxn.Select_SQL("delete from tbl_Profile where idRol=" & id)
        For Each row In Me.grdDataMain.Rows
            If row.Band.Key = "tbMainMenu" Then
                For Each rowch In row.ChildBands(0).Rows
                    If rowch.Cells(0).Value = True Then
                        cxn.Select_SQL("insert into tbl_Profile values ('" & id & "','" & rowch.Cells(2).Value & "',
                                                                '" & rowch.Cells(4).Value & "',
                                                                '" & rowch.Cells(5).Value & "',
                                                                '" & rowch.Cells(6).Value & "',
                                                                '" & rowch.Cells(7).Value & "')")
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
            ElseIf e.Cell.Band.Index = 1 And e.Cell.Column.Index = 0 Then
                rowActive.Cells(4).Value = e.Cell.Value
                rowActive.Cells(5).Value = e.Cell.Value
                rowActive.Cells(6).Value = e.Cell.Value
                rowActive.Cells(7).Value = e.Cell.Value
            ElseIf rowActive.Cells(4).Value = False And
                    rowActive.Cells(5).Value = False And
                    rowActive.Cells(6).Value = False And
                    rowActive.Cells(7).Value = False Then
                rowActive.Cells(0).Value = False
            ElseIf rowActive.Cells(4).Value = True And
                    rowActive.Cells(5).Value = True And
                    rowActive.Cells(6).Value = True And
                    rowActive.Cells(7).Value = True Then
                rowActive.Cells(0).Value = True
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