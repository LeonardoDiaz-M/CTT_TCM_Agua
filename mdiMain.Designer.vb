<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, New System.Guid("4d5229e5-7a63-468f-bee6-f9be53c1cbba"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("be2b7db8-0ea5-4f9f-85fe-b7acc4a7ad26"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("4d5229e5-7a63-468f-bee6-f9be53c1cbba"), -1)
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedTop, New System.Guid("6444de30-9c9f-47f6-ac21-7f5f88040963"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("fefa16ba-804f-4a1e-89eb-244983ded5a4"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("6444de30-9c9f-47f6-ac21-7f5f88040963"), -1)
        Dim DockableControlPane3 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("59bb060a-b456-41c3-9aab-b5d60cabac7a"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("6444de30-9c9f-47f6-ac21-7f5f88040963"), -1)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.expPrincipal = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtUsuario = New System.Windows.Forms.ToolStripTextBox()
        Me.txtPuesto = New System.Windows.Forms.ToolStripTextBox()
        Me.txtNombreOficina = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CommandBar = New System.Windows.Forms.ToolStrip()
        Me.lblBusca = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscaFiltro = New System.Windows.Forms.ToolStripButton()
        Me.btnClean = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.Excel = New System.Windows.Forms.ToolStripButton()
        Me.btnRegistroConsumo = New System.Windows.Forms.ToolStripButton()
        Me.btnRegistroPorCuenta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblParent = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblMenu = New System.Windows.Forms.ToolStripLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ugdDocumentexporter = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.udmPrincipal = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._mdiMainAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me._mdiMainUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._mdiMainUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._mdiMainUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._mdiMainUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me.tabPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugeExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow3 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea3 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow2 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtMenu = New System.Windows.Forms.ToolStripTextBox()
        Me.btnMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRecs = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTime = New System.Windows.Forms.ToolStripLabel()
        CType(Me.expPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.CommandBar.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udmPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow3.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.WindowDockingArea3.SuspendLayout()
        Me.DockableWindow2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'expPrincipal
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Left"
        Me.expPrincipal.Appearance = Appearance1
        Me.expPrincipal.AutoScrollStyle = Infragistics.Win.UltraWinExplorerBar.AutoScrollStyle.BringActiveControlIntoView
        Me.expPrincipal.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.expPrincipal.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Appearance2.BackColor = System.Drawing.Color.Gray
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.expPrincipal.ItemSettings.AppearancesSmall.ActiveAppearance = Appearance2
        Me.expPrincipal.Location = New System.Drawing.Point(0, 26)
        Me.expPrincipal.Name = "expPrincipal"
        Me.expPrincipal.ShowDefaultContextMenu = False
        Me.expPrincipal.Size = New System.Drawing.Size(311, 556)
        Me.expPrincipal.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Listbar
        Me.expPrincipal.TabIndex = 26
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtUsuario, Me.txtPuesto, Me.txtNombreOficina, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 40)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(300, 40)
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.Color.White
        Me.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPuesto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.ReadOnly = True
        Me.txtPuesto.Size = New System.Drawing.Size(300, 40)
        '
        'txtNombreOficina
        '
        Me.txtNombreOficina.BackColor = System.Drawing.Color.White
        Me.txtNombreOficina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreOficina.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreOficina.Name = "txtNombreOficina"
        Me.txtNombreOficina.ReadOnly = True
        Me.txtNombreOficina.Size = New System.Drawing.Size(300, 16)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.TCMAdmin.My.Resources.Resources.Desbloquear
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.Text = "Cambiar Password"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCMAdmin.My.Resources.Resources.IconSalir
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "Salir"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommandBar
        '
        Me.CommandBar.BackColor = System.Drawing.Color.White
        Me.CommandBar.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.CommandBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblBusca, Me.txtFilter, Me.btnBuscaFiltro, Me.btnClean, Me.ToolStripSeparator9, Me.btnNuevo, Me.btnAbrir, Me.ToolStripSeparator10, Me.Excel, Me.btnRegistroConsumo, Me.btnRegistroPorCuenta, Me.ToolStripSeparator11, Me.lblParent, Me.ToolStripSeparator12, Me.lblMenu})
        Me.CommandBar.Location = New System.Drawing.Point(0, 0)
        Me.CommandBar.Name = "CommandBar"
        Me.CommandBar.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CommandBar.Size = New System.Drawing.Size(1106, 37)
        Me.CommandBar.TabIndex = 21
        Me.CommandBar.Text = "CommandBar"
        Me.CommandBar.Visible = False
        '
        'lblBusca
        '
        Me.lblBusca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusca.Name = "lblBusca"
        Me.lblBusca.Size = New System.Drawing.Size(47, 34)
        Me.lblBusca.Text = "Buscar:"
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 37)
        '
        'btnBuscaFiltro
        '
        Me.btnBuscaFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscaFiltro.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Search_Lupa
        Me.btnBuscaFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscaFiltro.Name = "btnBuscaFiltro"
        Me.btnBuscaFiltro.Size = New System.Drawing.Size(40, 34)
        Me.btnBuscaFiltro.Text = "ToolStripButton1"
        Me.btnBuscaFiltro.ToolTipText = "Buscar registro"
        '
        'btnClean
        '
        Me.btnClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClean.Image = Global.TCMAdmin.My.Resources.Resources.Quitar
        Me.btnClean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(40, 34)
        Me.btnClean.Text = "Limpia Filtros"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 37)
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 34)
        Me.btnNuevo.Text = "Agregar Registro"
        '
        'btnAbrir
        '
        Me.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbrir.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Folder_Search
        Me.btnAbrir.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(40, 34)
        Me.btnAbrir.Text = "&Abrir Registro"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 37)
        '
        'Excel
        '
        Me.Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Excel.Image = Global.TCMAdmin.My.Resources.Resources.Icon_File_Excel
        Me.Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(40, 34)
        Me.Excel.Text = "Exportar a Excel"
        '
        'btnRegistroConsumo
        '
        Me.btnRegistroConsumo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRegistroConsumo.Image = Global.TCMAdmin.My.Resources.Resources.Lecturas
        Me.btnRegistroConsumo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegistroConsumo.Name = "btnRegistroConsumo"
        Me.btnRegistroConsumo.Size = New System.Drawing.Size(40, 34)
        Me.btnRegistroConsumo.Text = "ToolStripButton1"
        Me.btnRegistroConsumo.ToolTipText = "Registro de consumo por ruta"
        '
        'btnRegistroPorCuenta
        '
        Me.btnRegistroPorCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRegistroPorCuenta.Image = Global.TCMAdmin.My.Resources.Resources.LecturasCuenta
        Me.btnRegistroPorCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegistroPorCuenta.Name = "btnRegistroPorCuenta"
        Me.btnRegistroPorCuenta.Size = New System.Drawing.Size(40, 34)
        Me.btnRegistroPorCuenta.Text = "ToolStripButton1"
        Me.btnRegistroPorCuenta.ToolTipText = "Registro consumo por cuenta"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 37)
        '
        'lblParent
        '
        Me.lblParent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.ForeColor = System.Drawing.Color.Black
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(181, 34)
        Me.lblParent.Text = "                                                          "
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 37)
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Blue
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(44, 34)
        Me.lblMenu.Text = " Menu:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grdDataMain)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 25)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(708, 459)
        '
        'grdDataMain
        '
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance3.TextHAlignAsString = "Center"
        Me.grdDataMain.DisplayLayout.CaptionAppearance = Appearance3
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty
        Me.grdDataMain.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.Empty
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance7.TextHAlignAsString = "Center"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance8
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(0, 0)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(708, 459)
        Me.grdDataMain.TabIndex = 9
        Me.grdDataMain.Text = "Datos"
        '
        'Timer1
        '
        '
        'udmPrincipal
        '
        Me.udmPrincipal.CaptionStyle = Infragistics.Win.UltraWinDock.CaptionStyle.Office2003
        DockAreaPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.VerticalSplit
        DockAreaPane1.DockedBefore = New System.Guid("6444de30-9c9f-47f6-ac21-7f5f88040963")
        DockableControlPane1.Control = Me.expPrincipal
        DockableControlPane1.FlyoutSize = New System.Drawing.Size(277, -1)
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(263, 0, 175, 230)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockableControlPane1.Text = "Menú Principal"
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Settings.AllowResize = Infragistics.Win.DefaultableBoolean.[True]
        DockAreaPane1.Size = New System.Drawing.Size(311, 909)
        DockAreaPane2.DefaultPaneSettings.AllowClose = Infragistics.Win.DefaultableBoolean.[False]
        DockAreaPane2.DefaultPaneSettings.ShowCaption = Infragistics.Win.DefaultableBoolean.[False]
        DockableControlPane2.Control = Me.ToolStrip1
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 1043, 25)
        DockableControlPane2.Settings.AllowResize = Infragistics.Win.DefaultableBoolean.[False]
        DockableControlPane2.Size = New System.Drawing.Size(100, 88)
        DockableControlPane2.Text = "ToolStrip1"
        DockableControlPane3.Control = Me.CommandBar
        DockableControlPane3.OriginalControlBounds = New System.Drawing.Rectangle(0, 0, 963, 31)
        DockableControlPane3.Settings.AllowClose = Infragistics.Win.DefaultableBoolean.[False]
        DockableControlPane3.Settings.AllowResize = Infragistics.Win.DefaultableBoolean.[False]
        DockableControlPane3.Size = New System.Drawing.Size(100, 99)
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2, DockableControlPane3})
        DockAreaPane2.Settings.AllowResize = Infragistics.Win.DefaultableBoolean.[False]
        DockAreaPane2.Size = New System.Drawing.Size(1027, 90)
        Me.udmPrincipal.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1, DockAreaPane2})
        Me.udmPrincipal.HostControl = Me
        Me.udmPrincipal.LayoutStyle = Infragistics.Win.UltraWinDock.DockAreaLayoutStyle.FillContainer
        Me.udmPrincipal.ShowCloseButton = False
        Me.udmPrincipal.ShowDisabledButtons = False
        Me.udmPrincipal.ShowMenuButton = Infragistics.Win.DefaultableBoolean.[False]
        Me.udmPrincipal.ShowMinimizeButton = True
        Me.udmPrincipal.ShowPinButton = False
        Me.udmPrincipal.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.VisualStudio2005
        '
        '_mdiMainAutoHideControl
        '
        Me._mdiMainAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._mdiMainAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._mdiMainAutoHideControl.Name = "_mdiMainAutoHideControl"
        Me._mdiMainAutoHideControl.Owner = Me.udmPrincipal
        Me._mdiMainAutoHideControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._mdiMainAutoHideControl.Size = New System.Drawing.Size(282, 742)
        Me._mdiMainAutoHideControl.TabIndex = 13
        '
        '_mdiMainUnpinnedTabAreaRight
        '
        Me._mdiMainUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._mdiMainUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._mdiMainUnpinnedTabAreaRight.Location = New System.Drawing.Point(1028, 0)
        Me._mdiMainUnpinnedTabAreaRight.Name = "_mdiMainUnpinnedTabAreaRight"
        Me._mdiMainUnpinnedTabAreaRight.Owner = Me.udmPrincipal
        Me._mdiMainUnpinnedTabAreaRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._mdiMainUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 582)
        Me._mdiMainUnpinnedTabAreaRight.TabIndex = 10
        '
        '_mdiMainUnpinnedTabAreaBottom
        '
        Me._mdiMainUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._mdiMainUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._mdiMainUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 582)
        Me._mdiMainUnpinnedTabAreaBottom.Name = "_mdiMainUnpinnedTabAreaBottom"
        Me._mdiMainUnpinnedTabAreaBottom.Owner = Me.udmPrincipal
        Me._mdiMainUnpinnedTabAreaBottom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._mdiMainUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1028, 0)
        Me._mdiMainUnpinnedTabAreaBottom.TabIndex = 12
        '
        '_mdiMainUnpinnedTabAreaTop
        '
        Me._mdiMainUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._mdiMainUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._mdiMainUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._mdiMainUnpinnedTabAreaTop.Name = "_mdiMainUnpinnedTabAreaTop"
        Me._mdiMainUnpinnedTabAreaTop.Owner = Me.udmPrincipal
        Me._mdiMainUnpinnedTabAreaTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._mdiMainUnpinnedTabAreaTop.Size = New System.Drawing.Size(1028, 0)
        Me._mdiMainUnpinnedTabAreaTop.TabIndex = 11
        '
        '_mdiMainUnpinnedTabAreaLeft
        '
        Me._mdiMainUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._mdiMainUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._mdiMainUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._mdiMainUnpinnedTabAreaLeft.Name = "_mdiMainUnpinnedTabAreaLeft"
        Me._mdiMainUnpinnedTabAreaLeft.Owner = Me.udmPrincipal
        Me._mdiMainUnpinnedTabAreaLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._mdiMainUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 582)
        Me._mdiMainUnpinnedTabAreaLeft.TabIndex = 9
        '
        'tabPrincipal
        '
        Me.tabPrincipal.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None
        Me.tabPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabPrincipal.Controls.Add(Me.UltraTabPageControl1)
        Me.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPrincipal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPrincipal.Location = New System.Drawing.Point(316, 95)
        Me.tabPrincipal.Name = "tabPrincipal"
        Appearance9.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance9.BackColor2 = System.Drawing.Color.LightCoral
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Container
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassTop37
        Appearance9.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Appearance9.BorderColor = System.Drawing.Color.Black
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.SizeInPoints = 10.0!
        Me.tabPrincipal.SelectedTabAppearance = Appearance9
        Me.tabPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabPrincipal.Size = New System.Drawing.Size(712, 487)
        Me.tabPrincipal.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageSelected
        Me.tabPrincipal.TabIndex = 31
        Me.tabPrincipal.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Búsqueda de Datos"
        Me.tabPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.tabPrincipal.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        Me.tabPrincipal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        Me.tabPrincipal.Visible = False
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(708, 459)
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow3)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 0)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.udmPrincipal
        Me.WindowDockingArea1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea1.Size = New System.Drawing.Size(316, 582)
        Me.WindowDockingArea1.TabIndex = 27
        '
        'DockableWindow3
        '
        Me.DockableWindow3.Controls.Add(Me.expPrincipal)
        Me.DockableWindow3.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow3.Name = "DockableWindow3"
        Me.DockableWindow3.Owner = Me.udmPrincipal
        Me.DockableWindow3.Size = New System.Drawing.Size(311, 582)
        Me.DockableWindow3.TabIndex = 35
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.ToolStrip1)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.udmPrincipal
        Me.DockableWindow1.Size = New System.Drawing.Size(712, 40)
        Me.DockableWindow1.TabIndex = 36
        '
        'WindowDockingArea3
        '
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow2)
        Me.WindowDockingArea3.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea3.Dock = System.Windows.Forms.DockStyle.Top
        Me.WindowDockingArea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea3.Location = New System.Drawing.Point(316, 0)
        Me.WindowDockingArea3.Name = "WindowDockingArea3"
        Me.WindowDockingArea3.Owner = Me.udmPrincipal
        Me.WindowDockingArea3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WindowDockingArea3.Size = New System.Drawing.Size(712, 95)
        Me.WindowDockingArea3.TabIndex = 29
        '
        'DockableWindow2
        '
        Me.DockableWindow2.Controls.Add(Me.CommandBar)
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 45)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Owner = Me.udmPrincipal
        Me.DockableWindow2.Size = New System.Drawing.Size(712, 45)
        Me.DockableWindow2.TabIndex = 37
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AllowItemReorder = True
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripLabel1, Me.txtMenu, Me.btnMenu, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.lblRecs, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.lblTime})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 582)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip2.Size = New System.Drawing.Size(1028, 27)
        Me.ToolStrip2.TabIndex = 33
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.TCMAdmin.My.Resources.Resources.back
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton3.Text = "Esconder Menu"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 24)
        Me.ToolStripLabel1.Text = "Menu:"
        '
        'txtMenu
        '
        Me.txtMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(100, 27)
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.ForeColor = System.Drawing.Color.Blue
        Me.btnMenu.Image = Global.TCMAdmin.My.Resources.Resources.bulletchico
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMenu.Size = New System.Drawing.Size(81, 24)
        Me.btnMenu.Text = "Ir a Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel2.Size = New System.Drawing.Size(310, 24)
        Me.ToolStripLabel2.Text = "                                                                                 " &
    "                    "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'lblRecs
        '
        Me.lblRecs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecs.Name = "lblRecs"
        Me.lblRecs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRecs.Size = New System.Drawing.Size(62, 24)
        Me.lblRecs.Text = "Registros:"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel3.Size = New System.Drawing.Size(310, 24)
        Me.ToolStripLabel3.Text = "                                                                                 " &
    "                    "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(35, 24)
        Me.lblTime.Text = "Time"
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me._mdiMainAutoHideControl)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me._mdiMainUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._mdiMainUnpinnedTabAreaTop)
        Me.Controls.Add(Me._mdiMainUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._mdiMainUnpinnedTabAreaRight)
        Me.Controls.Add(Me.WindowDockingArea3)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mdiMain"
        Me.Text = "Sistema Tributario y Catastral Municipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.expPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CommandBar.ResumeLayout(False)
        Me.CommandBar.PerformLayout()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udmPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow3.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.DockableWindow1.PerformLayout()
        Me.WindowDockingArea3.ResumeLayout(False)
        Me.DockableWindow2.ResumeLayout(False)
        Me.DockableWindow2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CommandBar As ToolStrip
    Friend WithEvents lblBusca As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripTextBox
    Friend WithEvents btnBuscaFiltro As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnAbrir As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents Excel As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents lblParent As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents lblMenu As ToolStripLabel
    Friend WithEvents ugdDocumentexporter As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents udmPrincipal As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _mdiMainAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _mdiMainUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _mdiMainUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _mdiMainUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _mdiMainUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents expPrincipal As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Private WithEvents tabPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Private WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Private WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnRegistroConsumo As ToolStripButton
    Friend WithEvents btnRegistroPorCuenta As ToolStripButton
    Friend WithEvents ugeExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents txtUsuario As ToolStripTextBox
    Friend WithEvents txtPuesto As ToolStripTextBox
    Friend WithEvents txtNombreOficina As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents WindowDockingArea3 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow2 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents DockableWindow3 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents btnClean As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents txtMenu As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblRecs As ToolStripLabel
    Friend WithEvents lblTime As ToolStripLabel
    Friend WithEvents btnMenu As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
