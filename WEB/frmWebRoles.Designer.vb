<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWebRoles
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
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridad1 = New TCMAdmin.dsSeguridad()
        Me.grpDatosRol = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.lblClave = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRolDesc = New System.Windows.Forms.TextBox()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.grpTree = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Tb_WEBRolTableAdapter1 = New TCMAdmin.dsSeguridadTableAdapters.tb_WEBRolTableAdapter()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRol.SuspendLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTree.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grdDataMain.Size = New System.Drawing.Size(1041, 498)
        Me.grdDataMain.TabIndex = 10
        Me.grdDataMain.Text = "Datos"
        Me.grdDataMain.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tb_WEBRol"
        Me.BindingSource1.DataSource = Me.DsSeguridad1
        '
        'DsSeguridad1
        '
        Me.DsSeguridad1.DataSetName = "dsSeguridad"
        Me.DsSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpDatosRol
        '
        Me.grpDatosRol.Controls.Add(Me.chkActive)
        Me.grpDatosRol.Controls.Add(Me.txtRol)
        Me.grpDatosRol.Controls.Add(Me.lblClave)
        Me.grpDatosRol.Controls.Add(Me.txtRolDesc)
        Me.grpDatosRol.Controls.Add(Me.lblNombre)
        Me.grpDatosRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatosRol.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatosRol.Location = New System.Drawing.Point(0, 0)
        Me.grpDatosRol.Name = "grpDatosRol"
        Me.grpDatosRol.Size = New System.Drawing.Size(1045, 90)
        Me.grpDatosRol.TabIndex = 14
        Me.grpDatosRol.Text = "Datos"
        Me.grpDatosRol.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "Status", True))
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "Status", True))
        Me.chkActive.Location = New System.Drawing.Point(454, 31)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(70, 20)
        Me.chkActive.TabIndex = 7
        Me.chkActive.Text = "Activo"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtRol
        '
        Me.txtRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "WebRolName", True))
        Me.txtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(114, 31)
        Me.txtRol.MaxLength = 10
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(180, 22)
        Me.txtRol.TabIndex = 6
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(78, 34)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(30, 17)
        Me.lblClave.TabIndex = 4
        Me.lblClave.Text = "Rol:"
        '
        'txtRolDesc
        '
        Me.txtRolDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRolDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Description", True))
        Me.txtRolDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolDesc.Location = New System.Drawing.Point(114, 59)
        Me.txtRolDesc.MaxLength = 50
        Me.txtRolDesc.Name = "txtRolDesc"
        Me.txtRolDesc.Size = New System.Drawing.Size(444, 22)
        Me.txtRolDesc.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(26, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Descripción:"
        '
        'grpTree
        '
        Me.grpTree.Controls.Add(Me.grdDataMain)
        Me.grpTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpTree.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpTree.Location = New System.Drawing.Point(0, 0)
        Me.grpTree.Name = "grpTree"
        Me.grpTree.Size = New System.Drawing.Size(1045, 521)
        Me.grpTree.TabIndex = 15
        Me.grpTree.Text = "Seleccione los menus"
        Me.grpTree.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1045, 43)
        Me.BindingNavigator1.TabIndex = 17
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
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.Text = "ToolStripButton1"
        Me.btnEditar.ToolTipText = "Editar"
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(40, 40)
        Me.btnElimina.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel1.Text = "                       "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1045, 615)
        Me.SplitContainer1.SplitterDistance = 90
        Me.SplitContainer1.TabIndex = 18
        '
        'Tb_WEBRolTableAdapter1
        '
        Me.Tb_WEBRolTableAdapter1.ClearBeforeFill = True
        '
        'frmWebRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmWebRoles"
        Me.Text = "Roles y Menus del Sistema"
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRol.ResumeLayout(False)
        Me.grpDatosRol.PerformLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTree.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents grpDatosRol As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents lblClave As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRolDesc As TextBox
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpTree As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents DsSeguridad1 As dsSeguridad
    Friend WithEvents Tb_WEBRolTableAdapter1 As dsSeguridadTableAdapters.tb_WEBRolTableAdapter
End Class
