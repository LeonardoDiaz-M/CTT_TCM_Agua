<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiqAgua
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
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPagar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.optFormaPago = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotal = New Infragistics.Win.Misc.UltraLabel()
        Me.ugrpPropietario = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtUltLect = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblUltLect = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPeriodo = New Infragistics.Win.Misc.UltraLabel()
        Me.uneUltMes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneUltAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblUltAño = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltMes = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DsPagos1 = New TCMAdmin.dsPagos()
        Me.Datos_mpioTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.datos_mpioTableAdapter()
        Me.Tab_det_liquidacionesTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.tab_det_liquidacionesTableAdapter()
        Me.Tab_liquidacionesTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.tab_liquidacionesTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.optFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugrpPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugrpPropietario.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.txtUltLect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnBack, Me.ToolStripSeparator4, Me.btnImprimir, Me.ToolStripSeparator2, Me.btnPagar, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.lblCurrentMenu, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1106, 43)
        Me.BindingNavigator1.TabIndex = 1
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
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.TCMAdmin.My.Resources.Resources.Print
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 40)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'btnPagar
        '
        Me.btnPagar.Image = Global.TCMAdmin.My.Resources.Resources.reginter
        Me.btnPagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(117, 40)
        Me.btnPagar.Text = "Realizar Pago"
        Me.btnPagar.ToolTipText = "Realizar Pago"
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
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(118, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel1.Text = "           "
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1106, 79)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1106, 79)
        Me.grpDatosCuenta.TabIndex = 2
        Me.grpDatosCuenta.TabStop = False
        Me.grpDatosCuenta.Text = "Búsqueda"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnBusca)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.optFormaPago)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCuenta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCuenta)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1102, 56)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'btnBusca
        '
        Me.btnBusca.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusca.ForeColor = System.Drawing.Color.Navy
        Me.btnBusca.Location = New System.Drawing.Point(475, 13)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(106, 26)
        Me.btnBusca.TabIndex = 13
        Me.btnBusca.Text = "&Buscar"
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'optFormaPago
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.Name = "Tahoma"
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.optFormaPago.Appearance = Appearance1
        Me.optFormaPago.BackColor = System.Drawing.Color.White
        Me.optFormaPago.BackColorInternal = System.Drawing.Color.White
        Me.optFormaPago.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 8.0!
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance2.TextVAlignAsString = "Middle"
        Me.optFormaPago.ItemAppearance = Appearance2
        ValueListItem11.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem11.DataValue = "2"
        ValueListItem11.DisplayText = "Por Período"
        ValueListItem12.DataValue = "1"
        ValueListItem12.DisplayText = "Anual"
        Me.optFormaPago.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem11, ValueListItem12})
        Me.optFormaPago.ItemSpacingHorizontal = 10
        Me.optFormaPago.Location = New System.Drawing.Point(321, 17)
        Me.optFormaPago.MinColumnWidth = 80
        Me.optFormaPago.Name = "optFormaPago"
        Me.optFormaPago.Size = New System.Drawing.Size(148, 22)
        Me.optFormaPago.TabIndex = 12
        '
        'lblCuenta
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.lblCuenta.Appearance = Appearance3
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(10, 19)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(126, 16)
        Me.lblCuenta.TabIndex = 11
        Me.lblCuenta.Text = "Número de Cuenta:"
        Me.lblCuenta.UseAppStyling = False
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(142, 13)
        Me.txtCuenta.Mask = "########"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(173, 26)
        Me.txtCuenta.TabIndex = 0
        '
        'lblTotal
        '
        Appearance4.ForeColor = System.Drawing.Color.Gray
        Appearance4.TextHAlignAsString = "Center"
        Me.lblTotal.Appearance = Appearance4
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(397, 66)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(368, 28)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "TOTAL A PAGAR:"
        Me.lblTotal.UseAppStyling = False
        '
        'ugrpPropietario
        '
        Me.ugrpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.ugrpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugrpPropietario.Enabled = False
        Me.ugrpPropietario.ExpandedSize = New System.Drawing.Size(1106, 127)
        Me.ugrpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.ugrpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugrpPropietario.Location = New System.Drawing.Point(0, 122)
        Me.ugrpPropietario.Name = "ugrpPropietario"
        Me.ugrpPropietario.Size = New System.Drawing.Size(1106, 127)
        Me.ugrpPropietario.TabIndex = 3
        Me.ugrpPropietario.TabStop = False
        Me.ugrpPropietario.Text = "Datos del Propietario"
        Me.ugrpPropietario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtUltLect)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblUltLect)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblPeriodo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTotal)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneUltMes)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneUltAnio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblUltAño)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblUltMes)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1102, 104)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'txtUltLect
        '
        Appearance5.TextHAlignAsString = "Left"
        Me.txtUltLect.Appearance = Appearance5
        Me.txtUltLect.Location = New System.Drawing.Point(846, 61)
        Me.txtUltLect.MaxValue = 2050
        Me.txtUltLect.MinValue = 0
        Me.txtUltLect.Name = "txtUltLect"
        Me.txtUltLect.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUltLect.ReadOnly = True
        Me.txtUltLect.Size = New System.Drawing.Size(82, 24)
        Me.txtUltLect.TabIndex = 188
        '
        'lblUltLect
        '
        Me.lblUltLect.AutoSize = True
        Me.lblUltLect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltLect.Location = New System.Drawing.Point(771, 66)
        Me.lblUltLect.Name = "lblUltLect"
        Me.lblUltLect.Size = New System.Drawing.Size(72, 16)
        Me.lblUltLect.TabIndex = 189
        Me.lblUltLect.Text = "Últ. Lectura:"
        Me.lblUltLect.UseAppStyling = False
        '
        'lblPeriodo
        '
        Appearance6.ForeColor = System.Drawing.Color.Gray
        Appearance6.TextHAlignAsString = "Center"
        Me.lblPeriodo.Appearance = Appearance6
        Me.lblPeriodo.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(10, 66)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(381, 28)
        Me.lblPeriodo.TabIndex = 187
        Me.lblPeriodo.Text = "TOTAL A PAGAR:"
        Me.lblPeriodo.UseAppStyling = False
        '
        'uneUltMes
        '
        Appearance7.TextHAlignAsString = "Left"
        Me.uneUltMes.Appearance = Appearance7
        Me.uneUltMes.Location = New System.Drawing.Point(846, 35)
        Me.uneUltMes.MaxValue = 2050
        Me.uneUltMes.MinValue = 0
        Me.uneUltMes.Name = "uneUltMes"
        Me.uneUltMes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltMes.ReadOnly = True
        Me.uneUltMes.Size = New System.Drawing.Size(82, 24)
        Me.uneUltMes.TabIndex = 186
        '
        'uneUltAnio
        '
        Appearance8.TextHAlignAsString = "Left"
        Me.uneUltAnio.Appearance = Appearance8
        Me.uneUltAnio.Location = New System.Drawing.Point(846, 8)
        Me.uneUltAnio.MaxValue = 2050
        Me.uneUltAnio.MinValue = 0
        Me.uneUltAnio.Name = "uneUltAnio"
        Me.uneUltAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnio.ReadOnly = True
        Me.uneUltAnio.Size = New System.Drawing.Size(82, 24)
        Me.uneUltAnio.TabIndex = 183
        '
        'lblUltAño
        '
        Me.lblUltAño.AutoSize = True
        Me.lblUltAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltAño.Location = New System.Drawing.Point(771, 13)
        Me.lblUltAño.Name = "lblUltAño"
        Me.lblUltAño.Size = New System.Drawing.Size(69, 16)
        Me.lblUltAño.TabIndex = 185
        Me.lblUltAño.Text = "Último Año:"
        Me.lblUltAño.UseAppStyling = False
        '
        'lblUltMes
        '
        Me.lblUltMes.AutoSize = True
        Me.lblUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltMes.Location = New System.Drawing.Point(771, 40)
        Me.lblUltMes.Name = "lblUltMes"
        Me.lblUltMes.Size = New System.Drawing.Size(69, 16)
        Me.lblUltMes.TabIndex = 184
        Me.lblUltMes.Text = "Último Mes:"
        Me.lblUltMes.UseAppStyling = False
        '
        'txtDomicilio
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtDomicilio.Appearance = Appearance9
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(155, 37)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(610, 23)
        Me.txtDomicilio.TabIndex = 179
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance10
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(155, 10)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(610, 23)
        Me.txtNombre.TabIndex = 178
        '
        'lblNombre
        '
        Appearance11.TextHAlignAsString = "Center"
        Me.lblNombre.Appearance = Appearance11
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(10, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(135, 16)
        Me.lblNombre.TabIndex = 180
        Me.lblNombre.Text = "Nombre ó Razón Social:"
        Me.lblNombre.UseAppStyling = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(53, 40)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(92, 16)
        Me.lblDomicilio.TabIndex = 181
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1106, 374)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 249)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1106, 374)
        Me.UltraExpandableGroupBox1.TabIndex = 4
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Listado de Cuentas "
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Panel1)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1102, 351)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.grdDataMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 351)
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
        Me.grdDataMain.Size = New System.Drawing.Size(1102, 351)
        Me.grdDataMain.TabIndex = 11
        Me.grdDataMain.Text = "Datos"
        Me.grdDataMain.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'DsPagos1
        '
        Me.DsPagos1.DataSetName = "dsPagos"
        Me.DsPagos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Datos_mpioTableAdapter1
        '
        Me.Datos_mpioTableAdapter1.ClearBeforeFill = True
        '
        'Tab_det_liquidacionesTableAdapter1
        '
        Me.Tab_det_liquidacionesTableAdapter1.ClearBeforeFill = True
        '
        'Tab_liquidacionesTableAdapter1
        '
        Me.Tab_liquidacionesTableAdapter1.ClearBeforeFill = True
        '
        'frmLiqAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1106, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.ugrpPropietario)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmLiqAgua"
        Me.Text = "Liquidación de Agua"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.optFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugrpPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugrpPropietario.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.txtUltLect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnBusca As Button
    Friend WithEvents optFormaPago As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCuenta As MaskedTextBox
    Friend WithEvents btnPagar As ToolStripButton
    Friend WithEvents ugrpPropietario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents txtDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneUltMes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneUltAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblUltAño As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltMes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPeriodo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DsPagos1 As dsPagos
    Friend WithEvents Datos_mpioTableAdapter1 As dsPagosTableAdapters.datos_mpioTableAdapter
    Friend WithEvents Tab_det_liquidacionesTableAdapter1 As dsPagosTableAdapters.tab_det_liquidacionesTableAdapter
    Friend WithEvents Tab_liquidacionesTableAdapter1 As dsPagosTableAdapters.tab_liquidacionesTableAdapter
    Friend WithEvents txtUltLect As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblUltLect As Infragistics.Win.Misc.UltraLabel
End Class
