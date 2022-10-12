<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
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
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevoSub = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.grpTree = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdTabs = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnNuevoTab = New System.Windows.Forms.ToolStripButton()
        Me.btnEditaTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblSubMenu = New System.Windows.Forms.ToolStripLabel()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTree.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grdTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnNuevo, Me.btnNuevoSub, Me.btnEditar, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1146, 43)
        Me.BindingNavigator1.TabIndex = 18
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 40)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.Text = "ToolStripButton2"
        '
        'btnNuevoSub
        '
        Me.btnNuevoSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevoSub.Image = Global.TCMAdmin.My.Resources.Resources.IconReports
        Me.btnNuevoSub.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoSub.Name = "btnNuevoSub"
        Me.btnNuevoSub.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevoSub.Text = "Nuevo SubMenu"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.Text = "Editar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel2.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'grpTree
        '
        Me.grpTree.Controls.Add(Me.grdDataMain)
        Me.grpTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpTree.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpTree.Location = New System.Drawing.Point(0, 0)
        Me.grpTree.Name = "grpTree"
        Me.grpTree.Size = New System.Drawing.Size(1146, 321)
        Me.grpTree.TabIndex = 19
        Me.grpTree.Text = "Menu en Sistema"
        Me.grpTree.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grdDataMain
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.grdDataMain.DisplayLayout.Appearance = Appearance1
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance2.TextHAlignAsString = "Center"
        Me.grdDataMain.DisplayLayout.CaptionAppearance = Appearance2
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty
        Me.grdDataMain.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.Empty
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance6.TextHAlignAsString = "Center"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdDataMain.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.DisableFilteredOutRows
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance7
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(2, 21)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(1142, 298)
        Me.grdDataMain.TabIndex = 10
        Me.grdDataMain.Text = "Datos"
        Me.grdDataMain.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpTree)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1146, 592)
        Me.SplitContainer1.SplitterDistance = 321
        Me.SplitContainer1.TabIndex = 20
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.grdTabs)
        Me.UltraGroupBox1.Controls.Add(Me.BindingNavigator2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UltraGroupBox1.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1146, 267)
        Me.UltraGroupBox1.TabIndex = 20
        Me.UltraGroupBox1.Text = "Tabs del Menu"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grdTabs
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Me.grdTabs.DisplayLayout.Appearance = Appearance8
        Me.grdTabs.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance9.TextHAlignAsString = "Center"
        Me.grdTabs.DisplayLayout.CaptionAppearance = Appearance9
        Me.grdTabs.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdTabs.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty
        Me.grdTabs.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.Empty
        Me.grdTabs.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdTabs.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.grdTabs.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTabs.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.grdTabs.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTabs.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.grdTabs.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdTabs.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdTabs.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
        Me.grdTabs.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdTabs.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdTabs.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdTabs.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdTabs.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdTabs.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdTabs.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdTabs.DisplayLayout.Override.CellPadding = 0
        Me.grdTabs.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Me.grdTabs.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden
        Me.grdTabs.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdTabs.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grdTabs.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grdTabs.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance13.TextHAlignAsString = "Center"
        Me.grdTabs.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.grdTabs.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdTabs.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.DisableFilteredOutRows
        Me.grdTabs.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdTabs.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdTabs.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdTabs.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdTabs.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.grdTabs.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdTabs.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdTabs.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdTabs.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTabs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTabs.Location = New System.Drawing.Point(2, 64)
        Me.grdTabs.Name = "grdTabs"
        Me.grdTabs.Size = New System.Drawing.Size(1142, 201)
        Me.grdTabs.TabIndex = 20
        Me.grdTabs.Text = "Datos"
        Me.grdTabs.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BackColor = System.Drawing.Color.White
        Me.BindingNavigator2.CountItem = Nothing
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoTab, Me.btnEditaTab, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.lblSubMenu})
        Me.BindingNavigator2.Location = New System.Drawing.Point(2, 21)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(1142, 43)
        Me.BindingNavigator2.TabIndex = 19
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'btnNuevoTab
        '
        Me.btnNuevoTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevoTab.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.btnNuevoTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoTab.Name = "btnNuevoTab"
        Me.btnNuevoTab.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevoTab.Text = "ToolStripButton2"
        '
        'btnEditaTab
        '
        Me.btnEditaTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditaTab.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditaTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditaTab.Name = "btnEditaTab"
        Me.btnEditaTab.Size = New System.Drawing.Size(40, 40)
        Me.btnEditaTab.Text = "Editar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel1.Text = "           "
        '
        'lblSubMenu
        '
        Me.lblSubMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubMenu.Name = "lblSubMenu"
        Me.lblSubMenu.Size = New System.Drawing.Size(119, 40)
        Me.lblSubMenu.Text = "ToolStripLabel2"
        '
        'frmMenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 635)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmMenuControl"
        Me.Text = "Configuración de Menús"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTree.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.grdTabs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents grpTree As Infragistics.Win.Misc.UltraGroupBox
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnNuevo As ToolStripButton
    Private WithEvents grdTabs As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents btnNuevoTab As ToolStripButton
    Friend WithEvents btnEditaTab As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblSubMenu As ToolStripLabel
    Friend WithEvents btnNuevoSub As ToolStripButton
End Class
