<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWebSubMenu
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblCve = New System.Windows.Forms.Label()
        Me.lblRoot = New System.Windows.Forms.Label()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.cmbMenuParent = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numPos = New System.Windows.Forms.NumericUpDown()
        Me.ucmLinks = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIcono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.cmbMenuParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucmLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkStatus.Location = New System.Drawing.Point(573, 49)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(70, 20)
        Me.chkStatus.TabIndex = 15
        Me.chkStatus.Text = "&Activo"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(167, 78)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(380, 20)
        Me.txtDesc.TabIndex = 14
        Me.txtDesc.WordWrap = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(12, 82)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(149, 16)
        Me.lblDesc.TabIndex = 13
        Me.lblDesc.Text = "Título del Sub menú:"
        '
        'lblCve
        '
        Me.lblCve.AutoSize = True
        Me.lblCve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCve.Location = New System.Drawing.Point(11, 49)
        Me.lblCve.Name = "lblCve"
        Me.lblCve.Size = New System.Drawing.Size(150, 16)
        Me.lblCve.TabIndex = 12
        Me.lblCve.Text = "Clave del Sub menú:"
        '
        'lblRoot
        '
        Me.lblRoot.AutoSize = True
        Me.lblRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoot.Location = New System.Drawing.Point(66, 111)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.Size = New System.Drawing.Size(95, 16)
        Me.lblRoot.TabIndex = 17
        Me.lblRoot.Text = "Menú Padre:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(680, 43)
        Me.BindingNavigator1.TabIndex = 29
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
        Me.btnGuardar.Text = "ToolStripButton2"
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
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(167, 49)
        Me.txtClave.MaxLength = 100
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(380, 20)
        Me.txtClave.TabIndex = 30
        Me.txtClave.WordWrap = False
        '
        'cmbMenuParent
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.Name = "Tahoma"
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.cmbMenuParent.Appearance = Appearance1
        Me.cmbMenuParent.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbMenuParent.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cmbMenuParent.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 378
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cmbMenuParent.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cmbMenuParent.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.cmbMenuParent.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.CellsOnly
        Me.cmbMenuParent.DisplayMember = "descripcion"
        Me.cmbMenuParent.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.cmbMenuParent.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmbMenuParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMenuParent.Location = New System.Drawing.Point(167, 111)
        Me.cmbMenuParent.MaxDropDownItems = 30
        Me.cmbMenuParent.Name = "cmbMenuParent"
        Me.cmbMenuParent.NullText = "Seleccione..."
        Me.cmbMenuParent.Size = New System.Drawing.Size(380, 24)
        Me.cmbMenuParent.TabIndex = 31
        Me.cmbMenuParent.ValueMember = "cve_status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(570, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Pos:"
        '
        'numPos
        '
        Me.numPos.Location = New System.Drawing.Point(615, 82)
        Me.numPos.Name = "numPos"
        Me.numPos.Size = New System.Drawing.Size(40, 20)
        Me.numPos.TabIndex = 33
        '
        'ucmLinks
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.Name = "Tahoma"
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.ucmLinks.Appearance = Appearance2
        Me.ucmLinks.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucmLinks.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucmLinks.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 378
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18})
        Me.ucmLinks.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucmLinks.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.ucmLinks.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.CellsOnly
        Me.ucmLinks.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucmLinks.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucmLinks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucmLinks.Location = New System.Drawing.Point(167, 145)
        Me.ucmLinks.MaxDropDownItems = 10
        Me.ucmLinks.Name = "ucmLinks"
        Me.ucmLinks.NullText = "Seleccione..."
        Me.ucmLinks.Size = New System.Drawing.Size(380, 24)
        Me.ucmLinks.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Link:"
        '
        'txtIcono
        '
        Me.txtIcono.Location = New System.Drawing.Point(167, 184)
        Me.txtIcono.MaxLength = 100
        Me.txtIcono.Name = "txtIcono"
        Me.txtIcono.Size = New System.Drawing.Size(380, 20)
        Me.txtIcono.TabIndex = 35
        Me.txtIcono.Visible = False
        Me.txtIcono.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Icono:"
        Me.Label2.Visible = False
        '
        'frmWebSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 225)
        Me.Controls.Add(Me.ucmLinks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIcono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numPos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMenuParent)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.lblRoot)
        Me.Controls.Add(Me.chkStatus)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblCve)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWebSubMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración del Sub Menu"
        Me.TopMost = True
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.cmbMenuParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucmLinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblCve As Label
    Friend WithEvents lblRoot As Label
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents txtClave As TextBox
    Friend WithEvents cmbMenuParent As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label1 As Label
    Friend WithEvents numPos As NumericUpDown
    Friend WithEvents ucmLinks As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIcono As TextBox
    Friend WithEvents Label2 As Label
End Class
