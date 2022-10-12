Public Class frmWebMenu
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = True
    Public Borrar As Boolean = False
    Public Editar As Boolean = True
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private tipo As String = "Main"
    Private Sub frmWebMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dsSubMenus = cxn.Select_SQL("select ltrim(rtrim(upper(idMenu))) as Menu, MenuDescription as [Nombre del Menu], 
                                            cast(Status as Bit) as Activo,'' Link
                                    from tb_WEBMenus 
                                    where idMenuParent=0", dsSubMenus, "tb_WEBMenus")
        dsSubMenus = cxn2.Select_SQL("select ltrim(rtrim(upper(idMenuParent))) Parent,MenuName,MenuDescription as [Nombre SUB-Menu],
                                             isnull([Order],99) Posicion, cast(Status as Bit) as Activo, 
                                             replace(reverse(substring(reverse(URLNavigate),1, charindex('/',reverse(URLNAvigate))-1)),'.aspx','') as Link
                                      from tb_WEBMenus as  tbWebSubMenu
                                      where idMenuParent>0
                                      order by idMenuParent,[Order] ", dsSubMenus, "tbWebSubMenu")

        parentColumns = New DataColumn() {dsSubMenus.Tables("tb_WEBMenus").Columns("Menu")}
        childColumns = New DataColumn() {dsSubMenus.Tables("tbWebSubMenu").Columns("Parent")}

        Dim dsRelation As DataRelation = New DataRelation("Menus", parentColumns, childColumns, True)

        dsSubMenus.Relations.Add(dsRelation)
        Me.grdDataMain.DataSource = dsSubMenus
        Me.grdDataMain.DisplayLayout.Bands(1).Columns(0).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(1).HeaderVisible = True
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Caption = "SUB-MENUS"
        Me.grdDataMain.DisplayLayout.Bands(1).Header.Appearance.BackColor = Color.Silver
    End Sub
    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        If e.Row.Cells(0).Band.Index = 1 Then
            tipo = "SubMenu"
            Me.btnNuevoSub.Enabled = False
        Else
            tipo = "Main"
            Me.btnNuevoSub.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmWebMenu_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdDataMain_AfterRowActivate(sender As Object, e As EventArgs) Handles grdDataMain.AfterRowActivate
        If Me.grdDataMain.ActiveRow.Cells(0).Band.Index = 1 Then
            tipo = "SubMenu"
            Me.btnNuevoSub.Enabled = False
        Else
            tipo = "Main"
            Me.btnNuevoSub.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If tipo = "Main" Then
            Dim Mn As New frmWebRootMenu
            Mn.id = "0"
            Mn.Insertar = Insertar
            Mn.Editar = Editar
            Mn.Borrar = Borrar
            DialogForm1(Mn, Me)
        End If
        Me.frmWebMenu_Load(Nothing, Nothing)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tipo = "Main" Then
            Dim Mn As New frmWebRootMenu
            Mn.id = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim
            Mn.Insertar = Insertar
            Mn.Editar = Editar
            Mn.Borrar = Borrar
            DialogForm1(Mn, Me)
        Else
            Dim Sb As New frmWebSubMenu
            Sb.id = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            Sb.Insertar = Insertar
            Sb.Editar = Editar
            Sb.Borrar = Borrar
            Sb.ParentMenu = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim
            DialogForm1(Sb, Me)
        End If
        Me.frmWebMenu_Load(Nothing, Nothing)
    End Sub

    Private Sub btnNuevoSub_Click(sender As Object, e As EventArgs) Handles btnNuevoSub.Click
        If tipo = "Main" Then
            Dim Sb As New frmWebSubMenu
            Sb.id = "0"
            Sb.Insertar = Insertar
            Sb.Editar = Editar
            Sb.Borrar = Borrar
            Sb.ParentMenu = Me.grdDataMain.ActiveRow.Cells(1).Text.Trim
            DialogForm1(Sb, Me)
            'Sb.ShowDialog(Me)
        End If
        Me.frmWebMenu_Load(Nothing, Nothing)
    End Sub
End Class