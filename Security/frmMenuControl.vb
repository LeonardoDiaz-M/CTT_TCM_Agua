Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmMenuControl
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = True
    Public Borrar As Boolean = False
    Public Editar As Boolean = True
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private tipo As String = "Main"
    Private Sub frmMenuControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.lblCurrentMenu.Text = Me.Text
        Load_MenuData()
    End Sub
    Private Sub Load_MenuData()
        Dim cxn As New cxnData
        Dim cxn2 As New cxnData

        Dim dsSubMenus As New DataSet("Menus")
        Dim parentColumns As DataColumn()
        Dim childColumns As DataColumn()
        Me.grdDataMain.DataSource = Nothing
        dsSubMenus = cxn.Select_SQL("select ltrim(rtrim(upper(MenuNam))) as Menu, Description as [Nombre del Menu], cast(Status as Bit) as Activo 
                                     from tbMainMenu	", dsSubMenus, "tbMainMenu")
        dsSubMenus = cxn2.Select_SQL("select ltrim(rtrim(upper(Parent))) Parent,SubMenu,Description as [Nombre SUB-Menu],isnull(PosMnu,99) Posicion, 
                                      cast(Status as Bit) as Activo 
                                      from tbMainSubMenus order by Parent,PosMnu ", dsSubMenus, "tbMainSubMenus")

        parentColumns = New DataColumn() {dsSubMenus.Tables("tbMainMenu").Columns("Menu")}
        childColumns = New DataColumn() {dsSubMenus.Tables("tbMainSubMenus").Columns("Parent")}

        Dim dsRelation As DataRelation = New DataRelation("Menus", parentColumns, childColumns, True)

        dsSubMenus.Relations.Add(dsRelation)
        Me.grdDataMain.DataSource = dsSubMenus
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(0).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(1).HeaderVisible = True
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Caption = "SUB-MENUS"
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Appearance.BackColor = Color.Silver
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMenuControl_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs)
        Try
            If tipo = "Main" Then
                Dim Mn As New frmMenuRoot
                Mn.ShowDialog(Me)
            Else
                Dim Sb As New frmSubMenu
                Sb.ShowDialog(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        If e.Row.Cells(0).Band.Index = 1 Then
            tipo = "SubMenu"
            Dim cxn3 As New cxnData
            cxn3.Get_SQL_DataGrid("SELECT idTab,Menu,TabName,Query,FormName,TabOrder,DockForm,cast(Status as bit) as Status FROM tbMainMenuTabs  where Menu='" & Me.grdDataMain.ActiveRow.Cells(1).Text.Trim & "'", Me.grdTabs)
            Me.BindingNavigator2.Enabled = True
            Me.lblSubMenu.Text = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim & "-" & Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            Me.btnNuevoSub.Enabled = False
            Me.grdTabs.DisplayLayout.Bands(0).Columns(0).Hidden = True
            Me.grdTabs.DisplayLayout.Bands(0).Columns(1).Hidden = True
        Else
            tipo = "Main"
            Me.BindingNavigator2.Enabled = False
            Me.lblSubMenu.Text = ""
            Me.btnNuevoSub.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If tipo = "Main" Then
            Dim Mn As New frmMenuRoot
            Mn.id = "0"
            Mn.Insertar = Insertar
            Mn.Editar = Editar
            Mn.Borrar = Borrar
            DialogForm1(Mn, Me)
        End If
        frmMenuControl_Load(Nothing, Nothing)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tipo = "Main" Then
            Dim Mn As New frmMenuRoot
            Mn.id = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim
            Mn.Insertar = Insertar
            Mn.Editar = Editar
            Mn.Borrar = Borrar
            DialogForm1(Mn, Me)
        Else
            Dim Sb As New frmSubMenu
            Sb.id = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            Sb.Insertar = Insertar
            Sb.Editar = Editar
            Sb.Borrar = Borrar
            Sb.ParentMenu = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim
            DialogForm1(Sb, Me)
        End If
        frmMenuControl_Load(Nothing, Nothing)
    End Sub

    Private Sub btnNuevoSub_Click(sender As Object, e As EventArgs) Handles btnNuevoSub.Click
        If tipo = "Main" Then
            Dim Sb As New frmSubMenu
            Sb.id = "0"
            Sb.Insertar = Insertar
            Sb.Editar = Editar
            Sb.Borrar = Borrar
            Sb.ParentMenu = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            DialogForm1(Sb, Me)
            'Sb.ShowDialog(Me)
        End If
        frmMenuControl_Load(Nothing, Nothing)
    End Sub

    Private Sub grdDataMain_AfterRowActivate(sender As Object, e As EventArgs) Handles grdDataMain.AfterRowActivate
        If Me.grdDataMain.ActiveRow.Cells(0).Band.Index = 1 Then
            tipo = "SubMenu"
            Dim cxn3 As New cxnData
            cxn3.Get_SQL_DataGrid("SELECT idTab,Menu,TabName,Query,FormName,TabOrder,DockForm,cast(Status as bit) as Status 
                                   FROM tbMainMenuTabs  where Menu='" & Me.grdDataMain.ActiveRow.Cells(1).Text.Trim & "'", Me.grdTabs)
            Me.BindingNavigator2.Enabled = True
            Me.lblSubMenu.Text = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim & "-" & Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            Me.btnNuevoSub.Enabled = False
            Me.grdTabs.DisplayLayout.Bands(0).Columns(0).Hidden = True
            Me.grdTabs.DisplayLayout.Bands(0).Columns(1).Hidden = True
        Else
            tipo = "Main"
            Me.BindingNavigator2.Enabled = False
            Me.lblSubMenu.Text = ""
            Me.btnNuevoSub.Enabled = True
        End If
    End Sub

    Private Sub btnNuevoTab_Click(sender As Object, e As EventArgs) Handles btnNuevoTab.Click
        Dim sb As New frmMenuTabs
        sb.id = "0"
        Sb.Insertar = Insertar
        Sb.Editar = Editar
        Sb.Borrar = Borrar
        sb.SubMnu = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
        DialogForm1(sb, Me)
        grdDataMain_AfterRowActivate(Nothing, Nothing)
    End Sub

    Private Sub btnEditaTab_Click(sender As Object, e As EventArgs) Handles btnEditaTab.Click
        Dim sb As New frmMenuTabs
        sb.id = Me.grdTabs.ActiveRow.Cells(0).Text.Trim
        sb.Insertar = Insertar
        sb.Editar = Editar
        sb.Borrar = Borrar
        sb.SubMnu = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
        DialogForm1(sb, Me)
        grdDataMain_AfterRowActivate(Nothing, Nothing)
    End Sub

End Class