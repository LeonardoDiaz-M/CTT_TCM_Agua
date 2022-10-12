<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroPorCuenta
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
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblConsumo = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRegistro = New Infragistics.Win.Misc.UltraLabel()
        Me.mskLectura = New System.Windows.Forms.MaskedTextBox()
        Me.lblLectura = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.optTipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.lblRuta = New Infragistics.Win.Misc.UltraLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProcesa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ugeExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1091, 374)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 146)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1091, 374)
        Me.UltraExpandableGroupBox1.TabIndex = 7
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Movimientos de los ultimos 2 años"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Panel1)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1087, 351)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.grdDataMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 351)
        Me.Panel1.TabIndex = 12
        '
        'grdDataMain
        '
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.grdDataMain.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.grdDataMain.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(0, 0)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(1087, 351)
        Me.grdDataMain.TabIndex = 12
        Me.grdDataMain.Text = "Datos"
        Me.grdDataMain.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1091, 103)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1091, 103)
        Me.grpDatosCuenta.TabIndex = 6
        Me.grpDatosCuenta.TabStop = False
        Me.grpDatosCuenta.Text = "Búsqueda"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblConsumo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblRegistro)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.mskLectura)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblLectura)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCuenta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.optTipo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnBusca)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblRuta)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1087, 80)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'lblConsumo
        '
        Appearance1.ForeColor = System.Drawing.Color.Gray
        Appearance1.TextHAlignAsString = "Left"
        Me.lblConsumo.Appearance = Appearance1
        Me.lblConsumo.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsumo.Location = New System.Drawing.Point(449, 45)
        Me.lblConsumo.Name = "lblConsumo"
        Me.lblConsumo.Size = New System.Drawing.Size(429, 28)
        Me.lblConsumo.TabIndex = 617
        Me.lblConsumo.Text = "Consumo:"
        Me.lblConsumo.UseAppStyling = False
        '
        'lblRegistro
        '
        Appearance2.ForeColor = System.Drawing.Color.Gray
        Appearance2.TextHAlignAsString = "Left"
        Me.lblRegistro.Appearance = Appearance2
        Me.lblRegistro.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.Location = New System.Drawing.Point(10, 45)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(433, 28)
        Me.lblRegistro.TabIndex = 616
        Me.lblRegistro.Text = "A registar:"
        Me.lblRegistro.UseAppStyling = False
        '
        'mskLectura
        '
        Me.mskLectura.BackColor = System.Drawing.Color.White
        Me.mskLectura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskLectura.Location = New System.Drawing.Point(668, 13)
        Me.mskLectura.Mask = "99999999999"
        Me.mskLectura.Name = "mskLectura"
        Me.mskLectura.Size = New System.Drawing.Size(98, 26)
        Me.mskLectura.TabIndex = 615
        Me.mskLectura.ValidatingType = GetType(Integer)
        '
        'lblLectura
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.lblLectura.Appearance = Appearance3
        Me.lblLectura.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLectura.Location = New System.Drawing.Point(600, 18)
        Me.lblLectura.Name = "lblLectura"
        Me.lblLectura.Size = New System.Drawing.Size(62, 21)
        Me.lblLectura.TabIndex = 614
        Me.lblLectura.Text = "Lectura:"
        Me.lblLectura.UseAppStyling = False
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(142, 13)
        Me.txtCuenta.Mask = "########"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(98, 26)
        Me.txtCuenta.TabIndex = 613
        '
        'optTipo
        '
        Me.optTipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Appearance4.FontData.BoldAsString = "False"
        ValueListItem3.Appearance = Appearance4
        ValueListItem3.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem3.DataValue = "1"
        ValueListItem3.DisplayText = "Por Lectura:"
        Appearance5.FontData.BoldAsString = "False"
        ValueListItem1.Appearance = Appearance5
        ValueListItem1.DataValue = "3"
        ValueListItem1.DisplayText = "Por Promedio"
        Appearance6.FontData.BoldAsString = "False"
        ValueListItem2.Appearance = Appearance6
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Por Consumo Mínimo"
        Me.optTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem1, ValueListItem2})
        Me.optTipo.Location = New System.Drawing.Point(257, 18)
        Me.optTipo.Name = "optTipo"
        Me.optTipo.Size = New System.Drawing.Size(358, 20)
        Me.optTipo.TabIndex = 612
        '
        'btnBusca
        '
        Me.btnBusca.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusca.ForeColor = System.Drawing.Color.Navy
        Me.btnBusca.Location = New System.Drawing.Point(772, 13)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(106, 26)
        Me.btnBusca.TabIndex = 13
        Me.btnBusca.Text = "&Calcular"
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'lblRuta
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.lblRuta.Appearance = Appearance7
        Me.lblRuta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuta.Location = New System.Drawing.Point(10, 19)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(126, 16)
        Me.lblRuta.TabIndex = 11
        Me.lblRuta.Text = "Número de Cuenta:"
        Me.lblRuta.UseAppStyling = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnBack, Me.ToolStripSeparator4, Me.btnExcel, Me.ToolStripSeparator2, Me.btnProcesa, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1091, 43)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 43)
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.TCMAdmin.My.Resources.Resources.Icon_File_Excel
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(91, 40)
        Me.btnExcel.Text = "&Exportar"
        Me.btnExcel.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'btnProcesa
        '
        Me.btnProcesa.Image = Global.TCMAdmin.My.Resources.Resources.modalwin
        Me.btnProcesa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesa.Name = "btnProcesa"
        Me.btnProcesa.Size = New System.Drawing.Size(152, 40)
        Me.btnProcesa.Text = "Procesar Consumos"
        Me.btnProcesa.ToolTipText = "Procesar Consumo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel2.Text = "           "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel1.Text = "           "
        '
        'frmRegistroPorCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1091, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmRegistroPorCuenta"
        Me.Text = "Registro de Consumo por CUENTA"
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnBusca As Button
    Friend WithEvents lblRuta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnProcesa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents optTipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ugeExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents txtCuenta As MaskedTextBox
    Friend WithEvents mskLectura As MaskedTextBox
    Friend WithEvents lblLectura As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRegistro As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblConsumo As Infragistics.Win.Misc.UltraLabel
End Class
