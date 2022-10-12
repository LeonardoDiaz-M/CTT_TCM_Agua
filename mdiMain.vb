Imports System.ComponentModel
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class mdiMain
    Private childmodal As Boolean = False
    Private mnu1 As New clsMainMenu
    Private tabs1 As New clsMenuLoadQuery
    Private current_menu As String = ""
    Private cxn As New cxnData
    Private ServerTime As DateTime
    Private LastAction As DateTime
    Private MnuNoRecs As Boolean = False
    Private banBlock As Boolean = False
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lgn As New frmLogin
        DialogForm1(lgn, Me)
        Me.Cursor = Cursors.WaitCursor
        If CurrentUsrName <> "" Then
            Dim Usr As New clsUser
            Usr.UserName = CurrentUsrName
            If Usr.Obtiene_Oficina Then
                txtUsuario.Text = "USUARIO: " & Usr.Nombre
                txtPuesto.Text = "PUESTO: " & Usr.Puesto
                txtNombreOficina.Text = "OFICINA: " & Usr.Oficina
                mnu1.MainBar = Me.expPrincipal
                Infragistics.Win.AppStyling.StyleManager.Load("Metro.isl")
                Dim loaded As Boolean
                loaded = mnu1.load_MainMenu(False)
                Me.Timer1.Enabled = True
                cxn.Select_SQL("select dbo.getdateMx()")
                ServerTime = cxn.arrayValores(0)
                Me.lblTime.Text = ServerTime
                LastAction = ServerTime
                Me.Timer1.Interval = 1000
                Me.Timer1.Start()
                If Not loaded Then
                    cMensajes.DisplayMessage(Me, "Error al cargar el menú - " & mnu1.errmsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                cMensajes.DisplayMessage(Me, Usr.UsrErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            End
        End If
        CambiaTextoDeFiltros()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub load_menu_grid(menu As String)
        CloseActiveForms()
        Me.current_menu = menu
        cxn.Select_SQL("select Description,dockform from tbMainSubMenus sb inner join tbMainMenuTabs tb on tb.Menu=sb.SubMenu where SubMenu='" & menu & "'")
        Me.lblMenu.Text = vbTab & menu & "-" & cxn.arrayValores(0).ToUpperInvariant
        childmodal = IIf(cxn.arrayValores(1) = "1", False, True)
        Me.IsMdiContainer = childmodal
        Me.Refresh()

        Dim usr As New clsUser
        usr.UserName = CurrentUsrName
        If menu.Trim <> "" Then
            'Obtenmos el tipo de accesoque tiene el usuario
            If usr.obtiene_Permisos_Menu(menu) Then
                Me.btnAbrir.Enabled = usr.ReadOpt
                Me.btnNuevo.Enabled = usr.AddOpt
            End If

            btnRegistroConsumo.Visible = False
            btnRegistroPorCuenta.Visible = False

            Try
                'remueve tabs activas
                Dim i As Integer = Me.tabPrincipal.Tabs.Count - 1
                While Me.tabPrincipal.Tabs.Count > 1
                    If i > 0 Then
                        Me.tabPrincipal.Tabs.Remove(tabPrincipal.Tabs(i))
                    End If
                    i = i - 1
                End While

                'borra datos del grid
                Me.grdDataMain.DataSource = Nothing
                Me.CommandBar.Visible = True
                Me.grdDataMain.Enabled = True
                'Agregamos los tabs 

                If tabs1.add_tabs(current_menu, Me.tabPrincipal, Me.grdDataMain, Me.txtFilter.Text) And tabs1.errmsg = "" Then
                    cxn.Select_SQL("select FormName from tbMainMenuTabs where idTab='" & tabPrincipal.Tabs(0).Key & "'")
                    If cxn.arrayValores(0) = "frmarcAguaDatos" Then
                        btnRegistroConsumo.Visible = True
                        btnRegistroPorCuenta.Visible = True
                    End If
                End If
                cxn.Select_SQL("select FormName,query from tbMainMenuTabs where Menu='" & menu & "' and status=1 ")
                Dim frm As String = IIf(cxn.arrayValores(0).Trim.Length > 0, cxn.arrayValores(0), "")
                Dim qry As String = IIf(cxn.arrayValores(1).Trim.Length > 0, cxn.arrayValores(1), "")
                If Me.grdDataMain.Rows.Count = 0 Then
                    'Si se tiene que abrir la forma directamente, y no tiene datos en grid
                    If frm <> "" And Qry = "" Then
                        Me.CommandBar.Enabled = False
                        childmodal = False
                        Me.tabPrincipal.Visible = False
                        Display_Form("0", current_menu, Me)
                    ElseIf frm <> "" And Qry <> "" Then
                        'Cuando se tiene el query y la forma pero el query no retorna datos
                        Me.btnAbrir.Enabled = False
                        Me.btnNuevo.Enabled = True
                    ElseIf frm = "" And Qry <> "" Then
                        Me.btnAbrir.Enabled = False
                        Me.btnNuevo.Enabled = False
                    End If
                    tabPrincipal.Tabs(0).Text = "&Búsqueda"
                    cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdDataMain)
                Else
                    CommandBar.Enabled = True
                    Me.tabPrincipal.Visible = True
                End If

            Catch ex As Exception
                cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub
    Private Sub CloseActiveForms()
        Try
            Me.tabPrincipal.Visible = True
            Me.CommandBar.Visible = True
            For Each f As Form In My.Application.OpenForms
                If f.Name.ToLower <> "mdimain" Then
                    Try
                        Me.BeginInvoke(New Action(Sub() f.Close()))
                    Catch ex As Exception
                    End Try
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Display_Form(key As String, Menu As String, mdiMainParent As Form, Optional IdTab As String = "-1")
        Try
            'Me.tabPrincipal.Visible = Not childmodal
            Me.Cursor = Cursors.WaitCursor
            tabs1.LoadForms(key, Menu, Me, IdTab)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Me.CommandBar.Enabled = False
            Display_Form("0", current_menu, Me, tabPrincipal.Tabs(0).Key)
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            Me.CommandBar.Enabled = False
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, current_menu, Me, Me.tabPrincipal.Tabs(0).Key)
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBuscaFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscaFiltro.Click
        Try
            Dim i As Integer = Me.tabPrincipal.Tabs.Count - 1
            While Me.tabPrincipal.Tabs.Count > 1
                If i > 0 Then
                    Me.tabPrincipal.Tabs.Remove(tabPrincipal.Tabs(i))
                End If
                i = i - 1
            End While
            If Not tabs1.add_tabs(current_menu, Me.tabPrincipal, Me.grdDataMain, Me.txtFilter.Text) Then
                'cMensajes.DisplayMessage(Me, tabs1.errmsg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.CommandBar.Enabled = False
            End If
            If Me.grdDataMain.Rows.Count = 0 Then
                tabPrincipal.Tabs(0).Text = "&Búsqueda"
                cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdDataMain)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscaFiltro_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As SelectedTabChangedEventArgs) Handles tabPrincipal.SelectedTabChanged
        Try
            Me.tabs1.Load_Tab_data(Me.tabPrincipal, Me.grdDataMain.ActiveRow.Cells(0).Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.tabPrincipal.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)
            Else
                gridexcel = Me.grdDataMain
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            cMensajes.DisplayMessage(Me, "Datos exportados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    End With
                Else
                    cMensajes.DisplayMessage(Me, "No existen registros a exportar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                cMensajes.DisplayMessage(Me, "No existen registros a exportar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub grdDataMain_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdDataMain.ClickCell
        'si el padron actual es agua potable, establecemos rutina para mostrar u ocultar boton consumo agua por cuenta
        If e.Cell.IsDataCell Then
            cxn.Select_SQL("select FormName from tbMainMenuTabs where Menu='" & current_menu & "'")
            If cxn.arrayValores(0) = "frmaguaRegistroConsumo" Or
                                cxn.arrayValores(0) = "frmAguaLecturasPorCuenta" Then
                Dim Servicio As String
                Servicio = grdDataMain.ActiveRow.Cells("Servicio").Value
                btnRegistroConsumo.Visible = False
                btnRegistroPorCuenta.Visible = False
                If Servicio.ToUpperInvariant = "MEDIDO" Then
                    btnRegistroConsumo.Visible = True
                    ' ElseIf Servicio.ToUpperInvariant = "CUOTA FIJA" Then
                    btnRegistroPorCuenta.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        Try
            Me.CommandBar.Enabled = False
            If Me.grdDataMain.Rows.Count > 0 Then
                Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, current_menu, Me)
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub mdiMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
                CloseActiveForms()
                End
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub btnRegistroConsumo_Click(sender As Object, e As EventArgs) Handles btnRegistroConsumo.Click
        Try
            CloseActiveForms()
            tabPrincipal.Visible = True
            Me.CommandBar.Enabled = False
            cxn.Select_SQL("select idTab from tbMainMenuTabs where FormName='frmaguaRegistroConsumo' and menu='" & current_menu & "'")
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, current_menu, Me, cxn.arrayValores(0))
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnRegistroPorCuenta_Click(sender As Object, e As EventArgs) Handles btnRegistroPorCuenta.Click
        Try
            CloseActiveForms()
            tabPrincipal.Visible = True
            Me.CommandBar.Enabled = False
            cxn.Select_SQL("select idTab from tbMainMenuTabs where FormName='frmAguaLecturasPorCuenta' and menu='" & current_menu & "'")
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, current_menu, Me, cxn.arrayValores(0))
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub expPrincipal_DoubleClick(sender As Object, e As EventArgs) Handles expPrincipal.DoubleClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Key As String = Me.expPrincipal.ActiveItem.Key
            CloseActiveForms()
            Me.current_menu = Key
            tabPrincipal.Visible = True
            'dependiendo de la opcion del barra explorer cargamos el grid con el CODIGO de la forma seleccionada ejem IMP056
            load_menu_grid(Key)
            lblParent.Text = Me.expPrincipal.SelectedGroup.Text
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ServerTime = DateAdd(DateInterval.Second, 1, ServerTime)
        Me.lblTime.Text = ServerTime
        Me.lblRecs.Text = "Registros: " & Me.grdDataMain.Rows.Count.ToString
    End Sub
    Private Sub CommandBar_EnabledChanged(sender As Object, e As EventArgs) Handles CommandBar.EnabledChanged
        If Me.CommandBar.Enabled Then
            btnBuscaFiltro_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim cambiapsw As New frmPassword
        cambiapsw.myparent = "main"
        DialogForm1(cambiapsw, Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        mdiMain_Closing(Nothing, Nothing)
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Me.txtFilter.Text = ""
        btnBuscaFiltro_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim found As Boolean = False
        Me.txtMenu.BackColor = Color.WhiteSmoke
        For grp As Int16 = 0 To Me.expPrincipal.Groups.Count - 1
            For mnu As Int16 = 0 To Me.expPrincipal.Groups(grp).Items.Count - 1
                If Me.expPrincipal.Groups(grp).Items(mnu).Key.ToUpperInvariant = Me.txtMenu.Text.ToUpperInvariant Then
                    Me.expPrincipal.Groups(grp).Selected = True
                    Me.expPrincipal.Groups(grp).Active = True
                    Me.expPrincipal.Groups(grp).Items(mnu).Active = True
                    expPrincipal_DoubleClick(Nothing, Nothing)
                    Me.txtMenu.Text = ""
                    found = True
                End If
            Next
        Next
        If Not found Then
            Me.txtMenu.BackColor = Color.Salmon
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim areas As Infragistics.Win.UltraWinDock.DockAreasCollection = udmPrincipal.DockAreas
        areas(0).Closed = IIf(areas(0).Closed, False, True)
    End Sub
    Private Sub txtMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMenu.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripButton3_Click(Nothing, Nothing)
        End If
    End Sub
End Class
