<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratFiscDifer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratFiscDifer))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_cuenta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("texto")
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros1 = New TCMAdmin.dsParametros()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.lblEjFiscal = New System.Windows.Forms.Label()
        Me.grpdata = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ucoCuenta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPae = New Infragistics.Win.Misc.UltraLabel()
        Me.txtTipoServicio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNumeroOficio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.grpCuotas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.dtpFechaVencimiento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneSubGastosEjecucion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSubMultas = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSubRecargos = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSubActualizacion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtformula = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMensajePantalla = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMensajeRecibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uneSubImpuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.optTipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Arc_subTableAdapter = New TCMAdmin.dsParametrosTableAdapters.arc_subTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdata.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.ucoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroOficio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCuotas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSubGastosEjecucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSubMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSubRecargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSubActualizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtformula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensajePantalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensajeRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSubImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnEditar, Me.btnGuardar, Me.btnEliminar, Me.ToolStripLabel2, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(934, 37)
        Me.BindingNavigator1.TabIndex = 3
        Me.BindingNavigator1.Text = "BindingNavigator2"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "arc_sub"
        Me.BindingSource1.DataSource = Me.DsParametros1
        '
        'DsParametros1
        '
        Me.DsParametros1.DataSetName = "dsParametros"
        Me.DsParametros1.EnforceConstraints = False
        Me.DsParametros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNTotal
        '
        Me.btnNTotal.Name = "btnNTotal"
        Me.btnNTotal.Size = New System.Drawing.Size(35, 34)
        Me.btnNTotal.Text = "of {0}"
        Me.btnNTotal.ToolTipText = "Número total de elementos"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 34)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Undo
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(34, 34)
        Me.btnUndo.Text = "ToolStripButton1"
        Me.btnUndo.ToolTipText = "Deshacer cambios"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(34, 34)
        Me.btnEditar.Text = "ToolStripButton1"
        Me.btnEditar.ToolTipText = "Editar registro"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(34, 34)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar registro"
        Me.btnGuardar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeftAutoMirrorImage = True
        Me.btnEliminar.Size = New System.Drawing.Size(34, 34)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar registro"
        Me.btnEliminar.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(500, 34)
        Me.ToolStripLabel2.Text = "                       "
        '
        'btnNPrimero
        '
        Me.btnNPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNPrimero.Image = CType(resources.GetObject("btnNPrimero.Image"), System.Drawing.Image)
        Me.btnNPrimero.Name = "btnNPrimero"
        Me.btnNPrimero.RightToLeftAutoMirrorImage = True
        Me.btnNPrimero.Size = New System.Drawing.Size(34, 34)
        Me.btnNPrimero.Text = "Mover primero"
        '
        'btnNPrevio
        '
        Me.btnNPrevio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNPrevio.Image = CType(resources.GetObject("btnNPrevio.Image"), System.Drawing.Image)
        Me.btnNPrevio.Name = "btnNPrevio"
        Me.btnNPrevio.RightToLeftAutoMirrorImage = True
        Me.btnNPrevio.Size = New System.Drawing.Size(34, 34)
        Me.btnNPrevio.Text = "Mover anterior"
        '
        'btnNCurrent
        '
        Me.btnNCurrent.AccessibleName = "Posición"
        Me.btnNCurrent.AutoSize = False
        Me.btnNCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNCurrent.Name = "btnNCurrent"
        Me.btnNCurrent.Size = New System.Drawing.Size(50, 23)
        Me.btnNCurrent.Text = "0"
        Me.btnNCurrent.ToolTipText = "Posición actual"
        '
        'btnNSiguiente
        '
        Me.btnNSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNSiguiente.Image = CType(resources.GetObject("btnNSiguiente.Image"), System.Drawing.Image)
        Me.btnNSiguiente.Name = "btnNSiguiente"
        Me.btnNSiguiente.RightToLeftAutoMirrorImage = True
        Me.btnNSiguiente.Size = New System.Drawing.Size(34, 34)
        Me.btnNSiguiente.Text = "Mover siguiente"
        '
        'btnNUltimo
        '
        Me.btnNUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNUltimo.Image = CType(resources.GetObject("btnNUltimo.Image"), System.Drawing.Image)
        Me.btnNUltimo.Name = "btnNUltimo"
        Me.btnNUltimo.RightToLeftAutoMirrorImage = True
        Me.btnNUltimo.Size = New System.Drawing.Size(34, 34)
        Me.btnNUltimo.Text = "Mover último"
        '
        'lblEjFiscal
        '
        Me.lblEjFiscal.BackColor = System.Drawing.Color.White
        Me.lblEjFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEjFiscal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEjFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjFiscal.Location = New System.Drawing.Point(0, 37)
        Me.lblEjFiscal.Name = "lblEjFiscal"
        Me.lblEjFiscal.Size = New System.Drawing.Size(934, 43)
        Me.lblEjFiscal.TabIndex = 2
        Me.lblEjFiscal.Text = "Tratamientos Fiscales Diferenciales     "
        Me.lblEjFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpdata
        '
        Me.grpdata.Controls.Add(Me.grParImpPred)
        Me.grpdata.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpdata.Enabled = False
        Me.grpdata.ExpandedSize = New System.Drawing.Size(934, 149)
        Me.grpdata.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdata.Location = New System.Drawing.Point(0, 80)
        Me.grpdata.Name = "grpdata"
        Me.grpdata.Size = New System.Drawing.Size(934, 149)
        Me.grpdata.TabIndex = 0
        Me.grpdata.Text = "Datos Generales"
        Me.grpdata.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.ucoCuenta)
        Me.grParImpPred.Controls.Add(Me.txtDescripcion)
        Me.grParImpPred.Controls.Add(Me.UltraLabel6)
        Me.grParImpPred.Controls.Add(Me.lblPae)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 21)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(930, 126)
        Me.grParImpPred.TabIndex = 0
        '
        'ucoCuenta
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.Name = "Tahoma"
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.ucoCuenta.Appearance = Appearance1
        Me.ucoCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoCuenta.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_cuenta", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 800
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoCuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoCuenta.DisplayMember = "Descricion"
        Me.ucoCuenta.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoCuenta.Location = New System.Drawing.Point(178, 77)
        Me.ucoCuenta.MaxDropDownItems = 30
        Me.ucoCuenta.Name = "ucoCuenta"
        Me.ucoCuenta.NullText = "Seleccione..."
        Me.ucoCuenta.Size = New System.Drawing.Size(716, 24)
        Me.ucoCuenta.TabIndex = 1
        Me.ucoCuenta.ValueMember = "cve_tip_con"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "descripcion", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(178, 22)
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(716, 47)
        Me.txtDescripcion.TabIndex = 0
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(74, 77)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(98, 18)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Clave Cuenta:"
        Me.UltraLabel6.UseAppStyling = False
        '
        'lblPae
        '
        Me.lblPae.AutoSize = True
        Me.lblPae.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(84, 22)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(88, 18)
        Me.lblPae.TabIndex = 9
        Me.lblPae.Text = "Descripción:"
        Me.lblPae.UseAppStyling = False
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.AlwaysInEditMode = True
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.txtTipoServicio.Appearance = Appearance2
        Me.txtTipoServicio.BackColor = System.Drawing.Color.White
        Me.txtTipoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoServicio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "tip_ser", True))
        Me.txtTipoServicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtTipoServicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoServicio.Location = New System.Drawing.Point(178, 23)
        Me.txtTipoServicio.MaxLength = 8
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoServicio.Size = New System.Drawing.Size(110, 23)
        Me.txtTipoServicio.TabIndex = 0
        '
        'txtNumeroOficio
        '
        Me.txtNumeroOficio.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtNumeroOficio.Appearance = Appearance3
        Me.txtNumeroOficio.BackColor = System.Drawing.Color.White
        Me.txtNumeroOficio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOficio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "num_oficio", True))
        Me.txtNumeroOficio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNumeroOficio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroOficio.Location = New System.Drawing.Point(178, 51)
        Me.txtNumeroOficio.MaxLength = 20
        Me.txtNumeroOficio.Name = "txtNumeroOficio"
        Me.txtNumeroOficio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroOficio.Size = New System.Drawing.Size(110, 23)
        Me.txtNumeroOficio.TabIndex = 1
        '
        'UltraLabel11
        '
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(16, 81)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(156, 18)
        Me.UltraLabel11.TabIndex = 18
        Me.UltraLabel11.Text = "Fecha de vencimiento:"
        Me.UltraLabel11.UseAppStyling = False
        '
        'UltraLabel12
        '
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(48, 54)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(124, 18)
        Me.UltraLabel12.TabIndex = 17
        Me.UltraLabel12.Text = "Número de oficio:"
        Me.UltraLabel12.UseAppStyling = False
        '
        'UltraLabel13
        '
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(57, 26)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(115, 18)
        Me.UltraLabel13.TabIndex = 16
        Me.UltraLabel13.Text = "Tipo de servicio:"
        Me.UltraLabel13.UseAppStyling = False
        '
        'UltraLabel10
        '
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(47, 139)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(125, 18)
        Me.UltraLabel10.TabIndex = 15
        Me.UltraLabel10.Text = "Mensaje pantalla:"
        Me.UltraLabel10.UseAppStyling = False
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(61, 112)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(111, 18)
        Me.UltraLabel9.TabIndex = 14
        Me.UltraLabel9.Text = "Mensaje recibo:"
        Me.UltraLabel9.UseAppStyling = False
        '
        'grpCuotas
        '
        Me.grpCuotas.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpCuotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCuotas.Enabled = False
        Me.grpCuotas.ExpandedSize = New System.Drawing.Size(934, 392)
        Me.grpCuotas.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCuotas.Location = New System.Drawing.Point(0, 229)
        Me.grpCuotas.Name = "grpCuotas"
        Me.grpCuotas.Size = New System.Drawing.Size(934, 392)
        Me.grpCuotas.TabIndex = 1
        Me.grpCuotas.Text = "Cuotas y Calculos"
        Me.grpCuotas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.dtpFechaVencimiento)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel16)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSubGastosEjecucion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSubMultas)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSubRecargos)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSubActualizacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtTipoServicio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNumeroOficio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtformula)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtMensajePantalla)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtMensajeRecibo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSubImpuesto)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.optTipo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel11)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(930, 369)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fec_venc", True))
        Me.dtpFechaVencimiento.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.dtpFechaVencimiento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(178, 78)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(110, 23)
        Me.dtpFechaVencimiento.TabIndex = 2
        Me.dtpFechaVencimiento.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'UltraLabel16
        '
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(678, 141)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(87, 18)
        Me.UltraLabel16.TabIndex = 155
        Me.UltraLabel16.Text = "Gastos Ejec:"
        Me.UltraLabel16.UseAppStyling = False
        '
        'UltraLabel17
        '
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(710, 114)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(55, 18)
        Me.UltraLabel17.TabIndex = 154
        Me.UltraLabel17.Text = "Multas:"
        Me.UltraLabel17.UseAppStyling = False
        '
        'uneSubGastosEjecucion
        '
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneSubGastosEjecucion.Appearance = Appearance4
        Me.uneSubGastosEjecucion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_gastos", True))
        Me.uneSubGastosEjecucion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSubGastosEjecucion.Location = New System.Drawing.Point(774, 138)
        Me.uneSubGastosEjecucion.MinValue = 0
        Me.uneSubGastosEjecucion.Name = "uneSubGastosEjecucion"
        Me.uneSubGastosEjecucion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSubGastosEjecucion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSubGastosEjecucion.Size = New System.Drawing.Size(120, 25)
        Me.uneSubGastosEjecucion.TabIndex = 11
        '
        'uneSubMultas
        '
        Appearance5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneSubMultas.Appearance = Appearance5
        Me.uneSubMultas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_mult", True))
        Me.uneSubMultas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSubMultas.Location = New System.Drawing.Point(774, 110)
        Me.uneSubMultas.MinValue = 0
        Me.uneSubMultas.Name = "uneSubMultas"
        Me.uneSubMultas.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSubMultas.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSubMultas.Size = New System.Drawing.Size(120, 25)
        Me.uneSubMultas.TabIndex = 10
        '
        'uneSubRecargos
        '
        Appearance6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneSubRecargos.Appearance = Appearance6
        Me.uneSubRecargos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_rec", True))
        Me.uneSubRecargos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSubRecargos.Location = New System.Drawing.Point(774, 82)
        Me.uneSubRecargos.MinValue = 0
        Me.uneSubRecargos.Name = "uneSubRecargos"
        Me.uneSubRecargos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSubRecargos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSubRecargos.Size = New System.Drawing.Size(120, 25)
        Me.uneSubRecargos.TabIndex = 9
        '
        'uneSubActualizacion
        '
        Appearance7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneSubActualizacion.Appearance = Appearance7
        Me.uneSubActualizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_act", True))
        Me.uneSubActualizacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSubActualizacion.Location = New System.Drawing.Point(774, 54)
        Me.uneSubActualizacion.MinValue = 0
        Me.uneSubActualizacion.Name = "uneSubActualizacion"
        Me.uneSubActualizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSubActualizacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSubActualizacion.Size = New System.Drawing.Size(120, 25)
        Me.uneSubActualizacion.TabIndex = 8
        '
        'txtformula
        '
        Me.txtformula.AlwaysInEditMode = True
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.White
        Me.txtformula.Appearance = Appearance8
        Me.txtformula.BackColor = System.Drawing.Color.White
        Me.txtformula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtformula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "condicion", True))
        Me.txtformula.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtformula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtformula.Location = New System.Drawing.Point(178, 218)
        Me.txtformula.MaxLength = 160
        Me.txtformula.Multiline = True
        Me.txtformula.Name = "txtformula"
        Me.txtformula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtformula.Size = New System.Drawing.Size(716, 83)
        Me.txtformula.TabIndex = 6
        '
        'txtMensajePantalla
        '
        Me.txtMensajePantalla.AlwaysInEditMode = True
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtMensajePantalla.Appearance = Appearance9
        Me.txtMensajePantalla.BackColor = System.Drawing.Color.White
        Me.txtMensajePantalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensajePantalla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "msj_pantalla", True))
        Me.txtMensajePantalla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtMensajePantalla.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensajePantalla.Location = New System.Drawing.Point(178, 139)
        Me.txtMensajePantalla.MaxLength = 40
        Me.txtMensajePantalla.Name = "txtMensajePantalla"
        Me.txtMensajePantalla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensajePantalla.Size = New System.Drawing.Size(446, 23)
        Me.txtMensajePantalla.TabIndex = 4
        '
        'txtMensajeRecibo
        '
        Me.txtMensajeRecibo.AlwaysInEditMode = True
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.txtMensajeRecibo.Appearance = Appearance10
        Me.txtMensajeRecibo.BackColor = System.Drawing.Color.White
        Me.txtMensajeRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensajeRecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "msj_impreso", True))
        Me.txtMensajeRecibo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtMensajeRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensajeRecibo.Location = New System.Drawing.Point(178, 110)
        Me.txtMensajeRecibo.MaxLength = 40
        Me.txtMensajeRecibo.Name = "txtMensajeRecibo"
        Me.txtMensajeRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensajeRecibo.Size = New System.Drawing.Size(446, 23)
        Me.txtMensajeRecibo.TabIndex = 3
        '
        'uneSubImpuesto
        '
        Appearance11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneSubImpuesto.Appearance = Appearance11
        Me.uneSubImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_imp", True))
        Me.uneSubImpuesto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSubImpuesto.Location = New System.Drawing.Point(774, 26)
        Me.uneSubImpuesto.MinValue = 0
        Me.uneSubImpuesto.Name = "uneSubImpuesto"
        Me.uneSubImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSubImpuesto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSubImpuesto.Size = New System.Drawing.Size(120, 25)
        Me.uneSubImpuesto.TabIndex = 7
        '
        'UltraLabel15
        '
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(34, 219)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(138, 18)
        Me.UltraLabel15.TabIndex = 65
        Me.UltraLabel15.Text = "Fórmula de Cálculo:"
        Me.UltraLabel15.UseAppStyling = False
        '
        'optTipo
        '
        Appearance12.FontData.BoldAsString = "True"
        Me.optTipo.Appearance = Appearance12
        Me.optTipo.BackColor = System.Drawing.Color.White
        Me.optTipo.BackColorInternal = System.Drawing.Color.White
        Me.optTipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick
        Me.optTipo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "tipo", True))
        Appearance13.FontData.BoldAsString = "True"
        Me.optTipo.ItemAppearance = Appearance13
        Appearance14.FontData.BoldAsString = "False"
        ValueListItem1.Appearance = Appearance14
        ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem1.DataValue = "G"
        ValueListItem1.DisplayText = "General"
        Appearance15.FontData.BoldAsString = "False"
        ValueListItem2.Appearance = Appearance15
        ValueListItem2.DataValue = "P"
        ValueListItem2.DisplayText = "Parcial"
        Appearance16.FontData.BoldAsString = "False"
        ValueListItem3.Appearance = Appearance16
        ValueListItem3.DataValue = "U"
        ValueListItem3.DisplayText = "Único"
        Me.optTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.optTipo.ItemSpacingHorizontal = 20
        Me.optTipo.Location = New System.Drawing.Point(178, 176)
        Me.optTipo.Name = "optTipo"
        Me.optTipo.Size = New System.Drawing.Size(274, 22)
        Me.optTipo.TabIndex = 5
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(693, 86)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(72, 18)
        Me.UltraLabel4.TabIndex = 16
        Me.UltraLabel4.Text = "Recargos:"
        Me.UltraLabel4.UseAppStyling = False
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(666, 58)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(99, 18)
        Me.UltraLabel3.TabIndex = 15
        Me.UltraLabel3.Text = "Actualización:"
        Me.UltraLabel3.UseAppStyling = False
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(695, 29)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(70, 18)
        Me.UltraLabel2.TabIndex = 14
        Me.UltraLabel2.Text = "Impuesto"
        Me.UltraLabel2.UseAppStyling = False
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(133, 176)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(39, 18)
        Me.UltraLabel1.TabIndex = 13
        Me.UltraLabel1.Text = "Tipo:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'Arc_subTableAdapter
        '
        Me.Arc_subTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmTratFiscDifer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpCuotas)
        Me.Controls.Add(Me.grpdata)
        Me.Controls.Add(Me.lblEjFiscal)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Name = "frmTratFiscDifer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de tratamientos fiscales diferenciales"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdata.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.ucoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroOficio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCuotas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.dtpFechaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSubGastosEjecucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSubMultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSubRecargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSubActualizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtformula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensajePantalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensajeRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSubImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents lblEjFiscal As Label
    Friend WithEvents grpdata As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtTipoServicio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumeroOficio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucoCuenta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpCuotas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtformula As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensajePantalla As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensajeRecibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uneSubImpuesto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optTipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneSubGastosEjecucion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneSubMultas As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneSubRecargos As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneSubActualizacion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents DsParametros1 As dsParametros
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Arc_subTableAdapter As dsParametrosTableAdapters.arc_subTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dtpFechaVencimiento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
