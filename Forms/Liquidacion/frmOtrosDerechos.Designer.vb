<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtrosDerechos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPagar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.grpPropietario = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblTotal = New Infragistics.Win.Misc.UltraLabel()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dtpFechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.chknotif = New System.Windows.Forms.CheckBox()
        Me.uneDato2 = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneDato1 = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtObservaciones = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblObs = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRfc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblDato2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRFC = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbTipoServ = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblTipoSer = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDato1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFecha = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPropietario.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.uneDato2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneDato1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoServ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.ToolStripSeparator1, Me.btnPagar, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(828, 43)
        Me.BindingNavigator1.TabIndex = 4
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'btnPagar
        '
        Me.btnPagar.Enabled = False
        Me.btnPagar.Image = Global.TCMAdmin.My.Resources.Resources.reginter
        Me.btnPagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(117, 40)
        Me.btnPagar.Text = "Realizar Pago"
        Me.btnPagar.ToolTipText = "Realizar Pago"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel2.Text = "           "
        '
        'grpPropietario
        '
        Me.grpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPropietario.ExpandedSize = New System.Drawing.Size(828, 272)
        Me.grpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropietario.Location = New System.Drawing.Point(0, 43)
        Me.grpPropietario.Name = "grpPropietario"
        Me.grpPropietario.Size = New System.Drawing.Size(828, 272)
        Me.grpPropietario.TabIndex = 5
        Me.grpPropietario.TabStop = False
        Me.grpPropietario.Text = "Propietario"
        Me.grpPropietario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTotal)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.btnRegistrar)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.dtpFechaVenc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chknotif)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneDato2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneDato1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtObservaciones)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblObs)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtRfc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDato2)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblRFC)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cmbTipoServ)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTipoSer)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDato1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblFecha)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(824, 249)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'lblTotal
        '
        Appearance10.ForeColor = System.Drawing.Color.Gray
        Appearance10.TextHAlignAsString = "Center"
        Me.lblTotal.Appearance = Appearance10
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(44, 217)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(368, 28)
        Me.lblTotal.TabIndex = 195
        Me.lblTotal.Text = "TOTAL A PAGAR:"
        Me.lblTotal.UseAppStyling = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Navy
        Me.btnRegistrar.Location = New System.Drawing.Point(708, 217)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(106, 26)
        Me.btnRegistrar.TabIndex = 14
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'dtpFechaVenc
        '
        Me.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenc.Location = New System.Drawing.Point(684, 73)
        Me.dtpFechaVenc.Name = "dtpFechaVenc"
        Me.dtpFechaVenc.Size = New System.Drawing.Size(129, 22)
        Me.dtpFechaVenc.TabIndex = 194
        '
        'chknotif
        '
        Me.chknotif.AutoSize = True
        Me.chknotif.Location = New System.Drawing.Point(189, 166)
        Me.chknotif.Name = "chknotif"
        Me.chknotif.Size = New System.Drawing.Size(97, 20)
        Me.chknotif.TabIndex = 193
        Me.chknotif.Text = "Notificado"
        Me.chknotif.UseVisualStyleBackColor = True
        '
        'uneDato2
        '
        Me.uneDato2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDato2.Location = New System.Drawing.Point(433, 132)
        Me.uneDato2.MinValue = 0
        Me.uneDato2.Name = "uneDato2"
        Me.uneDato2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneDato2.Size = New System.Drawing.Size(100, 25)
        Me.uneDato2.TabIndex = 192
        Me.uneDato2.UseAppStyling = False
        '
        'uneDato1
        '
        Me.uneDato1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDato1.Location = New System.Drawing.Point(189, 132)
        Me.uneDato1.MinValue = 0
        Me.uneDato1.Name = "uneDato1"
        Me.uneDato1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneDato1.Size = New System.Drawing.Size(100, 25)
        Me.uneDato1.TabIndex = 191
        Me.uneDato1.UseAppStyling = False
        '
        'txtObservaciones
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.txtObservaciones.Appearance = Appearance2
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(189, 103)
        Me.txtObservaciones.MaxLength = 120
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservaciones.Size = New System.Drawing.Size(624, 23)
        Me.txtObservaciones.TabIndex = 189
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(91, 107)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(88, 16)
        Me.lblObs.TabIndex = 190
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.UseAppStyling = False
        '
        'txtRfc
        '
        Me.txtRfc.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtRfc.Appearance = Appearance3
        Me.txtRfc.BackColor = System.Drawing.Color.White
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRfc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(668, 15)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRfc.Size = New System.Drawing.Size(145, 23)
        Me.txtRfc.TabIndex = 1
        '
        'lblDato2
        '
        Appearance11.TextHAlignAsString = "Right"
        Appearance11.TextVAlignAsString = "Middle"
        Me.lblDato2.Appearance = Appearance11
        Me.lblDato2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDato2.Location = New System.Drawing.Point(295, 135)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(132, 22)
        Me.lblDato2.TabIndex = 184
        Me.lblDato2.Text = "Dato2"
        Me.lblDato2.UseAppStyling = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(620, 19)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(42, 16)
        Me.lblRFC.TabIndex = 182
        Me.lblRFC.Text = "R.F.C.:"
        Me.lblRFC.UseAppStyling = False
        '
        'cmbTipoServ
        '
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.Name = "Tahoma"
        Appearance5.FontData.SizeInPoints = 9.0!
        Me.cmbTipoServ.Appearance = Appearance5
        Me.cmbTipoServ.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbTipoServ.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn5.Header.Editor = Nothing
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Editor = Nothing
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 435
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
        Me.cmbTipoServ.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cmbTipoServ.DisplayLayout.Override.NullText = "Seleccione..."
        Me.cmbTipoServ.DisplayMember = "nombre"
        Me.cmbTipoServ.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.cmbTipoServ.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoServ.Location = New System.Drawing.Point(189, 73)
        Me.cmbTipoServ.MaxDropDownItems = 30
        Me.cmbTipoServ.Name = "cmbTipoServ"
        Me.cmbTipoServ.NullText = "Seleccione..."
        Me.cmbTipoServ.Size = New System.Drawing.Size(344, 24)
        Me.cmbTipoServ.TabIndex = 7
        Me.cmbTipoServ.ValueMember = "clave"
        '
        'txtDomicilio
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.txtDomicilio.Appearance = Appearance6
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(189, 44)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(624, 23)
        Me.txtDomicilio.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance7
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(189, 15)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(424, 23)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Appearance12.TextHAlignAsString = "Center"
        Me.lblNombre.Appearance = Appearance12
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(44, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(135, 16)
        Me.lblNombre.TabIndex = 176
        Me.lblNombre.Text = "Nombre ó Razón Social:"
        Me.lblNombre.UseAppStyling = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(119, 48)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(59, 16)
        Me.lblDomicilio.TabIndex = 177
        Me.lblDomicilio.Text = "Dirección:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'lblTipoSer
        '
        Me.lblTipoSer.AutoSize = True
        Me.lblTipoSer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoSer.Location = New System.Drawing.Point(83, 73)
        Me.lblTipoSer.Name = "lblTipoSer"
        Me.lblTipoSer.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoSer.TabIndex = 178
        Me.lblTipoSer.Text = "Tipo de Servicio:"
        Me.lblTipoSer.UseAppStyling = False
        '
        'lblDato1
        '
        Appearance13.TextHAlignAsString = "Right"
        Appearance13.TextVAlignAsString = "Middle"
        Me.lblDato1.Appearance = Appearance13
        Me.lblDato1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDato1.Location = New System.Drawing.Point(44, 138)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(134, 16)
        Me.lblDato1.TabIndex = 179
        Me.lblDato1.Text = "Dato1:"
        Me.lblDato1.UseAppStyling = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(549, 79)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(129, 16)
        Me.lblFecha.TabIndex = 180
        Me.lblFecha.Text = "Fecha de Vencimiento:"
        Me.lblFecha.UseAppStyling = False
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(828, 374)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 315)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(828, 374)
        Me.UltraExpandableGroupBox1.TabIndex = 6
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
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(824, 351)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.grdDataMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 351)
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
        Me.grdDataMain.Size = New System.Drawing.Size(824, 351)
        Me.grdDataMain.TabIndex = 11
        Me.grdDataMain.Text = "Datos"
        Me.grdDataMain.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'frmOtrosDerechos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.grpPropietario)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmOtrosDerechos"
        Me.Text = "Otros Derechos"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPropietario.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.uneDato2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneDato1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoServ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents grpPropietario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtObservaciones As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblObs As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRfc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblDato2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRFC As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbTipoServ As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblTipoSer As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDato1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFecha As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Panel1 As Panel
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uneDato2 As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneDato1 As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents chknotif As CheckBox
    Friend WithEvents dtpFechaVenc As DateTimePicker
    Friend WithEvents btnPagar As ToolStripButton
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblTotal As Infragistics.Win.Misc.UltraLabel
End Class
