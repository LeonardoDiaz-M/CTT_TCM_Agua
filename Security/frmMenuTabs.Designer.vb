<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuTabs
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpDatosRol = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ddlForm = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chkModal = New System.Windows.Forms.CheckBox()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.numPos = New System.Windows.Forms.NumericUpDown()
        Me.txtQuery = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTabName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpTree = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdTabs = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRol.SuspendLayout()
        CType(Me.ddlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTree.SuspendLayout()
        CType(Me.grdTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1393, 43)
        Me.BindingNavigator1.TabIndex = 19
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 40)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 40)
        Me.ToolStripLabel1.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(141, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpDatosRol)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpTree)
        Me.SplitContainer1.Size = New System.Drawing.Size(1393, 767)
        Me.SplitContainer1.SplitterDistance = 341
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 20
        '
        'grpDatosRol
        '
        Me.grpDatosRol.Controls.Add(Me.ddlForm)
        Me.grpDatosRol.Controls.Add(Me.chkModal)
        Me.grpDatosRol.Controls.Add(Me.btnSQL)
        Me.grpDatosRol.Controls.Add(Me.numPos)
        Me.grpDatosRol.Controls.Add(Me.txtQuery)
        Me.grpDatosRol.Controls.Add(Me.Label5)
        Me.grpDatosRol.Controls.Add(Me.chkActivo)
        Me.grpDatosRol.Controls.Add(Me.Label4)
        Me.grpDatosRol.Controls.Add(Me.txtTabName)
        Me.grpDatosRol.Controls.Add(Me.Label2)
        Me.grpDatosRol.Controls.Add(Me.Label3)
        Me.grpDatosRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatosRol.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatosRol.Location = New System.Drawing.Point(0, 0)
        Me.grpDatosRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatosRol.Name = "grpDatosRol"
        Me.grpDatosRol.Size = New System.Drawing.Size(1393, 341)
        Me.grpDatosRol.TabIndex = 14
        Me.grpDatosRol.Text = "Datos de la Pestaña"
        Me.grpDatosRol.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ddlForm
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.Name = "Tahoma"
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.ddlForm.Appearance = Appearance1
        Me.ddlForm.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None
        Me.ddlForm.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ddlForm.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 600
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 859
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18})
        Me.ddlForm.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ddlForm.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ddlForm.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Me.ddlForm.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.ddlForm.DisplayMember = "descripcion"
        Me.ddlForm.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005
        Me.ddlForm.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize
        Me.ddlForm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlForm.Location = New System.Drawing.Point(113, 76)
        Me.ddlForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ddlForm.MaxDropDownItems = 30
        Me.ddlForm.Name = "ddlForm"
        Me.ddlForm.NullText = "Seleccione..."
        Me.ddlForm.Size = New System.Drawing.Size(861, 28)
        Me.ddlForm.TabIndex = 609
        '
        'chkModal
        '
        Me.chkModal.AutoSize = True
        Me.chkModal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkModal.Location = New System.Drawing.Point(739, 46)
        Me.chkModal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModal.Name = "chkModal"
        Me.chkModal.Size = New System.Drawing.Size(84, 21)
        Me.chkModal.TabIndex = 608
        Me.chkModal.Text = "&Docked"
        Me.chkModal.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSQL.FlatAppearance.BorderSize = 3
        Me.btnSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSQL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSQL.Location = New System.Drawing.Point(1196, 66)
        Me.btnSQL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(168, 50)
        Me.btnSQL.TabIndex = 607
        Me.btnSQL.Text = "Probar SQL"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'numPos
        '
        Me.numPos.Location = New System.Drawing.Point(921, 43)
        Me.numPos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numPos.Name = "numPos"
        Me.numPos.Size = New System.Drawing.Size(53, 26)
        Me.numPos.TabIndex = 606
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(95, 124)
        Me.txtQuery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(1269, 178)
        Me.txtQuery.TabIndex = 603
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 602
        Me.Label5.Text = "Query:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(628, 47)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 600
        Me.chkActivo.Text = "&Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 599
        Me.Label4.Text = "Forma:"
        '
        'txtTabName
        '
        Me.txtTabName.Location = New System.Drawing.Point(156, 42)
        Me.txtTabName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTabName.MaxLength = 50
        Me.txtTabName.Name = "txtTabName"
        Me.txtTabName.Size = New System.Drawing.Size(449, 26)
        Me.txtTabName.TabIndex = 598
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 597
        Me.Label2.Text = "Tab Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(841, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 596
        Me.Label3.Text = "Orden:"
        '
        'grpTree
        '
        Me.grpTree.Controls.Add(Me.grdTabs)
        Me.grpTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpTree.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpTree.Location = New System.Drawing.Point(0, 0)
        Me.grpTree.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTree.Name = "grpTree"
        Me.grpTree.Size = New System.Drawing.Size(1393, 421)
        Me.grpTree.TabIndex = 15
        Me.grpTree.Text = "Resultado del Query"
        Me.grpTree.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grdTabs
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Me.grdTabs.DisplayLayout.Appearance = Appearance2
        Me.grdTabs.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Appearance3.TextHAlignAsString = "Center"
        Me.grdTabs.DisplayLayout.CaptionAppearance = Appearance3
        Me.grdTabs.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdTabs.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty
        Me.grdTabs.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.Empty
        Me.grdTabs.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdTabs.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.grdTabs.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTabs.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.grdTabs.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTabs.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
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
        Appearance7.TextHAlignAsString = "Center"
        Me.grdTabs.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.grdTabs.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdTabs.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.DisableFilteredOutRows
        Me.grdTabs.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdTabs.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdTabs.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdTabs.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdTabs.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdTabs.DisplayLayout.Override.TemplateAddRowAppearance = Appearance8
        Me.grdTabs.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdTabs.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdTabs.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdTabs.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTabs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTabs.Location = New System.Drawing.Point(2, 25)
        Me.grdTabs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdTabs.Name = "grdTabs"
        Me.grdTabs.Size = New System.Drawing.Size(1389, 394)
        Me.grdTabs.TabIndex = 21
        Me.grdTabs.Text = "Datos"
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'frmMenuTabs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1393, 810)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenuTabs"
        Me.Text = "Configuracion de Tabs"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRol.ResumeLayout(False)
        Me.grpDatosRol.PerformLayout()
        CType(Me.ddlForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTree.ResumeLayout(False)
        CType(Me.grdTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpDatosRol As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkModal As CheckBox
    Friend WithEvents btnSQL As Button
    Friend WithEvents numPos As NumericUpDown
    Friend WithEvents txtQuery As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTabName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpTree As Infragistics.Win.Misc.UltraGroupBox
    Private WithEvents grdTabs As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ddlForm As Infragistics.Win.UltraWinGrid.UltraCombo
End Class
