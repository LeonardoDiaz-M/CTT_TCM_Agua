<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPredial
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_tip_con")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descricion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPredial))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtRfc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ArcpredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DasPredial = New TCMAdmin.DasPredial()
        Me.lblObservaciones = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRFC = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCorreo = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCurp = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ucoTipoContribuyente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtemail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservaciones = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtUbicacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtPropietario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUbicacion = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCurp = New Infragistics.Win.Misc.UltraLabel()
        Me.lblContribuyente = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.grpUltimoPago = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ucoUltMes = New System.Windows.Forms.ComboBox()
        Me.lblUltAño = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltANual = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltMes = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUlltPeriodo = New Infragistics.Win.Misc.UltraLabel()
        Me.uneUltAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoRecibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uneUltPeriodo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneUltAnual = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.grpPAE = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkNotificado = New System.Windows.Forms.CheckBox()
        Me.panNotificado = New System.Windows.Forms.Panel()
        Me.txtNoActos = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ucoPae = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblPae = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFechaPae = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoOficioPae = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFecPAE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblNoPAe = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNoActosPAe = New Infragistics.Win.Misc.UltraLabel()
        Me.grpPropietario = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtLongitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtLatitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblSupCons = New Infragistics.Win.Misc.UltraLabel()
        Me.lblSupTerr = New Infragistics.Win.Misc.UltraLabel()
        Me.lblStatus = New Infragistics.Win.Misc.UltraLabel()
        Me.uneSupConstruccion = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSupTerreno = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ucoStatus = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoTipoPredio = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtcveCatastral = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblTipPredio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCveCat = New Infragistics.Win.Misc.UltraLabel()
        Me.Arc_predialTableAdapter = New TCMAdmin.DasPredialTableAdapters.arc_predialTableAdapter()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcpredialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DasPredial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUltimoPago.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPAE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPAE.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.panNotificado.SuspendLayout()
        CType(Me.txtNoActos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoPae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOficioPae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecPAE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPropietario.SuspendLayout()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSupConstruccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSupTerreno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoTipoPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcveCatastral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtRfc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblObservaciones)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblRFC)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCorreo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ucoTipoContribuyente)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtemail)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtObservaciones)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtUbicacion)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtPropietario)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblUbicacion)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblContribuyente)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorProvider1.SetIconAlignment(Me.UltraExpandableGroupBoxPanel2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1451, 302)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'txtRfc
        '
        Me.txtRfc.AlwaysInEditMode = True
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.txtRfc.Appearance = Appearance6
        Me.txtRfc.BackColor = System.Drawing.Color.White
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "rfc", True))
        Me.txtRfc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRfc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(1095, 86)
        Me.txtRfc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRfc.Size = New System.Drawing.Size(220, 27)
        Me.txtRfc.TabIndex = 4
        '
        'ArcpredialBindingSource
        '
        Me.ArcpredialBindingSource.DataMember = "arc_predial"
        Me.ArcpredialBindingSource.DataSource = Me.DasPredial
        '
        'DasPredial
        '
        Me.DasPredial.DataSetName = "dasPredial"
        Me.DasPredial.EnforceConstraints = False
        Me.DasPredial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(117, 222)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblObservaciones.Size = New System.Drawing.Size(147, 25)
        Me.lblObservaciones.TabIndex = 99
        Me.lblObservaciones.Text = "Observaciones:"
        Me.lblObservaciones.UseAppStyling = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(1032, 90)
        Me.lblRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRFC.Size = New System.Drawing.Size(69, 25)
        Me.lblRFC.TabIndex = 99
        Me.lblRFC.Text = "R.F.C.:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(175, 55)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorreo.Size = New System.Drawing.Size(75, 25)
        Me.lblCorreo.TabIndex = 99
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.UseAppStyling = False
        '
        'txtCurp
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.Name = "Tahoma"
        Appearance7.FontData.SizeInPoints = 9.0!
        Me.txtCurp.Appearance = Appearance7
        Me.txtCurp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "curp", True))
        Me.txtCurp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCurp.InputMask = ">????######??????AA"
        Me.txtCurp.Location = New System.Drawing.Point(1095, 54)
        Me.txtCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.NonAutoSizeHeight = 22
        Me.txtCurp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCurp.Size = New System.Drawing.Size(220, 26)
        Me.txtCurp.TabIndex = 2
        Me.txtCurp.UseAppStyling = False
        '
        'ucoTipoContribuyente
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.Name = "Tahoma"
        Appearance8.FontData.SizeInPoints = 9.0!
        Me.ucoTipoContribuyente.Appearance = Appearance8
        Me.ucoTipoContribuyente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoTipoContribuyente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoTipoContribuyente.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ArcpredialBindingSource, "cve_tip_con", True))
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 330
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoTipoContribuyente.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoTipoContribuyente.DisplayMember = "Descricion"
        Me.ucoTipoContribuyente.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoTipoContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoContribuyente.Location = New System.Drawing.Point(253, 87)
        Me.ucoTipoContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoTipoContribuyente.MaxDropDownItems = 30
        Me.ucoTipoContribuyente.Name = "ucoTipoContribuyente"
        Me.ucoTipoContribuyente.NullText = "Seleccione..."
        Me.ucoTipoContribuyente.Size = New System.Drawing.Size(440, 28)
        Me.ucoTipoContribuyente.TabIndex = 3
        Me.ucoTipoContribuyente.ValueMember = "cve_tip_con"
        '
        'txtemail
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtemail.Appearance = Appearance9
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "correoe", True))
        Me.txtemail.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(253, 53)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.MaxLength = 30
        Me.txtemail.Name = "txtemail"
        Me.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtemail.Size = New System.Drawing.Size(440, 27)
        Me.txtemail.TabIndex = 1
        Me.txtemail.UseAppStyling = False
        '
        'txtObservaciones
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.txtObservaciones.Appearance = Appearance10
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "aclaracion", True))
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(253, 222)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservaciones.Size = New System.Drawing.Size(1061, 57)
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.UseAppStyling = False
        '
        'txtDomicilio
        '
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.txtDomicilio.Appearance = Appearance11
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "domicilio_fiscal", True))
        Me.txtDomicilio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(253, 159)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.MaxLength = 150
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(1061, 57)
        Me.txtDomicilio.TabIndex = 6
        Me.txtDomicilio.UseAppStyling = False
        '
        'txtUbicacion
        '
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.txtUbicacion.Appearance = Appearance12
        Me.txtUbicacion.BackColor = System.Drawing.Color.White
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "ubicacion", True))
        Me.txtUbicacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtUbicacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(253, 124)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUbicacion.MaxLength = 50
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUbicacion.Size = New System.Drawing.Size(1061, 27)
        Me.txtUbicacion.TabIndex = 5
        Me.txtUbicacion.UseAppStyling = False
        '
        'txtPropietario
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.txtPropietario.Appearance = Appearance13
        Me.txtPropietario.BackColor = System.Drawing.Color.White
        Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropietario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "propietario", True))
        Me.txtPropietario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtPropietario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.Location = New System.Drawing.Point(253, 18)
        Me.txtPropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPropietario.MaxLength = 120
        Me.txtPropietario.Multiline = True
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPropietario.Size = New System.Drawing.Size(1061, 28)
        Me.txtPropietario.TabIndex = 0
        Me.txtPropietario.UseAppStyling = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(144, 21)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNombre.Size = New System.Drawing.Size(112, 25)
        Me.lblNombre.TabIndex = 99
        Me.lblNombre.Text = "Propietario:"
        Me.lblNombre.UseAppStyling = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(112, 162)
        Me.lblDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDomicilio.Size = New System.Drawing.Size(153, 25)
        Me.lblDomicilio.TabIndex = 99
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(153, 128)
        Me.lblUbicacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUbicacion.Size = New System.Drawing.Size(101, 25)
        Me.lblUbicacion.TabIndex = 99
        Me.lblUbicacion.Text = "Ubicación:"
        Me.lblUbicacion.UseAppStyling = False
        '
        'lblCurp
        '
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurp.Location = New System.Drawing.Point(1036, 59)
        Me.lblCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurp.Size = New System.Drawing.Size(64, 25)
        Me.lblCurp.TabIndex = 99
        Me.lblCurp.Text = "CURP:"
        '
        'lblContribuyente
        '
        Me.lblContribuyente.AutoSize = True
        Me.lblContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContribuyente.Location = New System.Drawing.Point(121, 91)
        Me.lblContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblContribuyente.Name = "lblContribuyente"
        Me.lblContribuyente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblContribuyente.Size = New System.Drawing.Size(141, 25)
        Me.lblContribuyente.TabIndex = 99
        Me.lblContribuyente.Text = "Contribuyente:"
        Me.lblContribuyente.UseAppStyling = False
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.ArcpredialBindingSource
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnImage, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1455, 43)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 40)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(29, 40)
        Me.btnUndo.Text = "ToolStripButton1"
        Me.btnUndo.ToolTipText = "Deshacer cambios"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar Datos"
        Me.btnGuardar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.ToolTipText = "Editar"
        '
        'btnImage
        '
        Me.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImage.Image = CType(resources.GetObject("btnImage.Image"), System.Drawing.Image)
        Me.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(40, 40)
        Me.btnImage.Text = "ToolStripButton1"
        Me.btnImage.ToolTipText = "Ver imágenes"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Search
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.Text = "Ver Mapa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 40)
        Me.ToolStripLabel2.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(141, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'grpUltimoPago
        '
        Me.grpUltimoPago.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grpUltimoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUltimoPago.Enabled = False
        Me.grpUltimoPago.ExpandedSize = New System.Drawing.Size(695, 240)
        Me.grpUltimoPago.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpUltimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimoPago.Location = New System.Drawing.Point(760, 537)
        Me.grpUltimoPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUltimoPago.Name = "grpUltimoPago"
        Me.grpUltimoPago.Size = New System.Drawing.Size(695, 240)
        Me.grpUltimoPago.TabIndex = 9
        Me.grpUltimoPago.TabStop = False
        Me.grpUltimoPago.Text = "Último Pago"
        Me.grpUltimoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.ucoUltMes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltAño)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltANual)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltMes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUlltPeriodo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltAnio)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtNoRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltPeriodo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltAnual)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(691, 213)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'ucoUltMes
        '
        Me.ucoUltMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "ult_mes_pag", True))
        Me.ucoUltMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ucoUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoUltMes.FormattingEnabled = True
        Me.ucoUltMes.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12"})
        Me.ucoUltMes.Location = New System.Drawing.Point(453, 42)
        Me.ucoUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoUltMes.Name = "ucoUltMes"
        Me.ucoUltMes.Size = New System.Drawing.Size(100, 26)
        Me.ucoUltMes.TabIndex = 4
        '
        'lblUltAño
        '
        Me.lblUltAño.AutoSize = True
        Me.lblUltAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltAño.Location = New System.Drawing.Point(379, 11)
        Me.lblUltAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltAño.Name = "lblUltAño"
        Me.lblUltAño.Size = New System.Drawing.Size(88, 25)
        Me.lblUltAño.TabIndex = 99
        Me.lblUltAño.Text = "Últ. Año:"
        Me.lblUltAño.UseAppStyling = False
        '
        'lblUltANual
        '
        Me.lblUltANual.AutoSize = True
        Me.lblUltANual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltANual.Location = New System.Drawing.Point(92, 82)
        Me.lblUltANual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltANual.Name = "lblUltANual"
        Me.lblUltANual.Size = New System.Drawing.Size(167, 25)
        Me.lblUltANual.TabIndex = 99
        Me.lblUltANual.Text = "Últ. monto anual:"
        Me.lblUltANual.UseAppStyling = False
        '
        'lblUltMes
        '
        Me.lblUltMes.AutoSize = True
        Me.lblUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltMes.Location = New System.Drawing.Point(379, 47)
        Me.lblUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltMes.Name = "lblUltMes"
        Me.lblUltMes.Size = New System.Drawing.Size(88, 25)
        Me.lblUltMes.TabIndex = 99
        Me.lblUltMes.Text = "Últ. Mes:"
        Me.lblUltMes.UseAppStyling = False
        '
        'lblUlltPeriodo
        '
        Me.lblUlltPeriodo.AutoSize = True
        Me.lblUlltPeriodo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUlltPeriodo.Location = New System.Drawing.Point(77, 47)
        Me.lblUlltPeriodo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUlltPeriodo.Name = "lblUlltPeriodo"
        Me.lblUlltPeriodo.Size = New System.Drawing.Size(185, 25)
        Me.lblUlltPeriodo.TabIndex = 99
        Me.lblUlltPeriodo.Text = "Últ. monto periodo:"
        Me.lblUlltPeriodo.UseAppStyling = False
        '
        'uneUltAnio
        '
        Me.uneUltAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "ult_año_pag", True))
        Me.uneUltAnio.Location = New System.Drawing.Point(453, 7)
        Me.uneUltAnio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltAnio.MaxValue = 2050
        Me.uneUltAnio.MinValue = 0
        Me.uneUltAnio.Name = "uneUltAnio"
        Me.uneUltAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnio.Size = New System.Drawing.Size(101, 28)
        Me.uneUltAnio.TabIndex = 3
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(135, 11)
        Me.UltraLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(112, 25)
        Me.UltraLabel4.TabIndex = 99
        Me.UltraLabel4.Text = "No. Recibo:"
        Me.UltraLabel4.UseAppStyling = False
        '
        'txtNoRecibo
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtNoRecibo.Appearance = Appearance1
        Me.txtNoRecibo.BackColor = System.Drawing.Color.White
        Me.txtNoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoRecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "folio_recibo", True))
        Me.txtNoRecibo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRecibo.Location = New System.Drawing.Point(232, 7)
        Me.txtNoRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoRecibo.MaxLength = 8
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRecibo.Size = New System.Drawing.Size(135, 27)
        Me.txtNoRecibo.TabIndex = 0
        Me.txtNoRecibo.UseAppStyling = False
        '
        'uneUltPeriodo
        '
        Me.uneUltPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "monto_ant", True))
        Me.uneUltPeriodo.Location = New System.Drawing.Point(232, 42)
        Me.uneUltPeriodo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltPeriodo.MinValue = 0
        Me.uneUltPeriodo.Name = "uneUltPeriodo"
        Me.uneUltPeriodo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneUltPeriodo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltPeriodo.Size = New System.Drawing.Size(135, 28)
        Me.uneUltPeriodo.TabIndex = 1
        '
        'uneUltAnual
        '
        Me.uneUltAnual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "monto_ult_pago", True))
        Me.uneUltAnual.Location = New System.Drawing.Point(232, 78)
        Me.uneUltAnual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltAnual.MinValue = 0
        Me.uneUltAnual.Name = "uneUltAnual"
        Me.uneUltAnual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneUltAnual.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnual.Size = New System.Drawing.Size(135, 28)
        Me.uneUltAnual.TabIndex = 2
        '
        'grpPAE
        '
        Me.grpPAE.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.grpPAE.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpPAE.Enabled = False
        Me.grpPAE.ExpandedSize = New System.Drawing.Size(760, 240)
        Me.grpPAE.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPAE.Location = New System.Drawing.Point(0, 537)
        Me.grpPAE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPAE.Name = "grpPAE"
        Me.grpPAE.Size = New System.Drawing.Size(760, 240)
        Me.grpPAE.TabIndex = 8
        Me.grpPAE.TabStop = False
        Me.grpPAE.Text = "PAE"
        Me.grpPAE.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.chkNotificado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.panNotificado)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(756, 213)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'chkNotificado
        '
        Me.chkNotificado.AutoSize = True
        Me.chkNotificado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ArcpredialBindingSource, "notificado", True))
        Me.chkNotificado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotificado.Location = New System.Drawing.Point(56, 11)
        Me.chkNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNotificado.Name = "chkNotificado"
        Me.chkNotificado.Size = New System.Drawing.Size(103, 22)
        Me.chkNotificado.TabIndex = 4
        Me.chkNotificado.Text = "Notificado: "
        Me.chkNotificado.UseVisualStyleBackColor = True
        '
        'panNotificado
        '
        Me.panNotificado.Controls.Add(Me.txtNoActos)
        Me.panNotificado.Controls.Add(Me.ucoPae)
        Me.panNotificado.Controls.Add(Me.lblPae)
        Me.panNotificado.Controls.Add(Me.lblFechaPae)
        Me.panNotificado.Controls.Add(Me.txtNoOficioPae)
        Me.panNotificado.Controls.Add(Me.txtFecPAE)
        Me.panNotificado.Controls.Add(Me.lblNoPAe)
        Me.panNotificado.Controls.Add(Me.lblNoActosPAe)
        Me.panNotificado.Enabled = False
        Me.panNotificado.Location = New System.Drawing.Point(119, 4)
        Me.panNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panNotificado.Name = "panNotificado"
        Me.panNotificado.Size = New System.Drawing.Size(625, 70)
        Me.panNotificado.TabIndex = 5
        '
        'txtNoActos
        '
        Me.txtNoActos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "num_actos", True))
        Me.txtNoActos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActos.Location = New System.Drawing.Point(483, 37)
        Me.txtNoActos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoActos.MaskInput = "999"
        Me.txtNoActos.Name = "txtNoActos"
        Me.txtNoActos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNoActos.Size = New System.Drawing.Size(68, 27)
        Me.txtNoActos.TabIndex = 3
        '
        'ucoPae
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.Name = "Tahoma"
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.ucoPae.Appearance = Appearance2
        Me.ucoPae.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoPae.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoPae.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ArcpredialBindingSource, "pae", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 161
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ucoPae.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoPae.DisplayMember = "Descricion"
        Me.ucoPae.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoPae.Location = New System.Drawing.Point(133, 4)
        Me.ucoPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoPae.MaxDropDownItems = 30
        Me.ucoPae.Name = "ucoPae"
        Me.ucoPae.NullText = "Seleccione..."
        Me.ucoPae.Size = New System.Drawing.Size(215, 28)
        Me.ucoPae.TabIndex = 0
        Me.ucoPae.ValueMember = "cve_tip_con"
        '
        'lblPae
        '
        Me.lblPae.AutoSize = True
        Me.lblPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(67, 7)
        Me.lblPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(67, 25)
        Me.lblPae.TabIndex = 99
        Me.lblPae.Text = "Etapa:"
        Me.lblPae.UseAppStyling = False
        '
        'lblFechaPae
        '
        Me.lblFechaPae.AutoSize = True
        Me.lblFechaPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPae.Location = New System.Drawing.Point(379, 9)
        Me.lblFechaPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaPae.Name = "lblFechaPae"
        Me.lblFechaPae.Size = New System.Drawing.Size(113, 25)
        Me.lblFechaPae.TabIndex = 99
        Me.lblFechaPae.Text = "Fecha acto:"
        Me.lblFechaPae.UseAppStyling = False
        '
        'txtNoOficioPae
        '
        Me.txtNoOficioPae.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtNoOficioPae.Appearance = Appearance3
        Me.txtNoOficioPae.BackColor = System.Drawing.Color.White
        Me.txtNoOficioPae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoOficioPae.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "num_noti", True))
        Me.txtNoOficioPae.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoOficioPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOficioPae.Location = New System.Drawing.Point(133, 37)
        Me.txtNoOficioPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoOficioPae.MaxLength = 20
        Me.txtNoOficioPae.Name = "txtNoOficioPae"
        Me.txtNoOficioPae.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOficioPae.Size = New System.Drawing.Size(215, 27)
        Me.txtNoOficioPae.TabIndex = 1
        '
        'txtFecPAE
        '
        Me.txtFecPAE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "fecha_noti", True))
        Me.txtFecPAE.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFecPAE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecPAE.Location = New System.Drawing.Point(483, 5)
        Me.txtFecPAE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecPAE.Name = "txtFecPAE"
        Me.txtFecPAE.Size = New System.Drawing.Size(133, 27)
        Me.txtFecPAE.TabIndex = 2
        Me.txtFecPAE.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblNoPAe
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.lblNoPAe.Appearance = Appearance4
        Me.lblNoPAe.AutoSize = True
        Me.lblNoPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPAe.Location = New System.Drawing.Point(4, 41)
        Me.lblNoPAe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoPAe.Name = "lblNoPAe"
        Me.lblNoPAe.Size = New System.Drawing.Size(144, 25)
        Me.lblNoPAe.TabIndex = 47
        Me.lblNoPAe.Text = "Oficio Número:"
        Me.lblNoPAe.UseAppStyling = False
        '
        'lblNoActosPAe
        '
        Me.lblNoActosPAe.AutoSize = True
        Me.lblNoActosPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoActosPAe.Location = New System.Drawing.Point(367, 42)
        Me.lblNoActosPAe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoActosPAe.Name = "lblNoActosPAe"
        Me.lblNoActosPAe.Size = New System.Drawing.Size(128, 25)
        Me.lblNoActosPAe.TabIndex = 48
        Me.lblNoActosPAe.Text = "No. de actos:"
        Me.lblNoActosPAe.UseAppStyling = False
        '
        'grpPropietario
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Me.grpPropietario.Appearance = Appearance5
        Me.grpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPropietario.Enabled = False
        Me.grpPropietario.ExpandedSize = New System.Drawing.Size(1455, 329)
        Me.grpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropietario.Location = New System.Drawing.Point(0, 208)
        Me.grpPropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPropietario.Name = "grpPropietario"
        Me.grpPropietario.Size = New System.Drawing.Size(1455, 329)
        Me.grpPropietario.TabIndex = 7
        Me.grpPropietario.TabStop = False
        Me.grpPropietario.Text = "Datos del Propietario"
        Me.grpPropietario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.Enabled = False
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1455, 165)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1455, 165)
        Me.grpDatosCuenta.TabIndex = 6
        Me.grpDatosCuenta.TabStop = False
        Me.grpDatosCuenta.Text = "Cuenta"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLongitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLatitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblSupCons)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblSupTerr)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSupConstruccion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneSupTerreno)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoTipoPredio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtcveCatastral)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblTipPredio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCveCat)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1451, 138)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'txtLongitud
        '
        Me.txtLongitud.AlwaysInEditMode = True
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.txtLongitud.Appearance = Appearance14
        Me.txtLongitud.BackColor = System.Drawing.Color.White
        Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitud.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "Longitud", True))
        Me.txtLongitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLongitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitud.Location = New System.Drawing.Point(1152, 96)
        Me.txtLongitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLongitud.MaxLength = 50
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLongitud.Size = New System.Drawing.Size(163, 27)
        Me.txtLongitud.TabIndex = 6
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(1065, 101)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(93, 25)
        Me.UltraLabel1.TabIndex = 123
        Me.UltraLabel1.Text = "Longitud:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtLatitud
        '
        Me.txtLatitud.AlwaysInEditMode = True
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColor2 = System.Drawing.Color.White
        Me.txtLatitud.Appearance = Appearance15
        Me.txtLatitud.BackColor = System.Drawing.Color.White
        Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLatitud.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "Latitud", True))
        Me.txtLatitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLatitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitud.Location = New System.Drawing.Point(1152, 62)
        Me.txtLatitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLatitud.MaxLength = 50
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatitud.Size = New System.Drawing.Size(163, 27)
        Me.txtLatitud.TabIndex = 5
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(1081, 66)
        Me.UltraLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(77, 25)
        Me.UltraLabel2.TabIndex = 121
        Me.UltraLabel2.Text = "Latitud:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'lblSupCons
        '
        Me.lblSupCons.AutoSize = True
        Me.lblSupCons.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupCons.Location = New System.Drawing.Point(709, 102)
        Me.lblSupCons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSupCons.Name = "lblSupCons"
        Me.lblSupCons.Size = New System.Drawing.Size(227, 25)
        Me.lblSupCons.TabIndex = 99
        Me.lblSupCons.Text = "Superficie Construcción:"
        Me.lblSupCons.UseAppStyling = False
        '
        'lblSupTerr
        '
        Me.lblSupTerr.AutoSize = True
        Me.lblSupTerr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupTerr.Location = New System.Drawing.Point(751, 64)
        Me.lblSupTerr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSupTerr.Name = "lblSupTerr"
        Me.lblSupTerr.Size = New System.Drawing.Size(181, 25)
        Me.lblSupTerr.TabIndex = 99
        Me.lblSupTerr.Text = "Superficie Terreno:"
        Me.lblSupTerr.UseAppStyling = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(177, 64)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 25)
        Me.lblStatus.TabIndex = 99
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.UseAppStyling = False
        '
        'uneSupConstruccion
        '
        Me.uneSupConstruccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "sconsprop", True))
        Me.uneSupConstruccion.Location = New System.Drawing.Point(917, 96)
        Me.uneSupConstruccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneSupConstruccion.MinValue = 0
        Me.uneSupConstruccion.Name = "uneSupConstruccion"
        Me.uneSupConstruccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSupConstruccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSupConstruccion.ReadOnly = True
        Me.uneSupConstruccion.Size = New System.Drawing.Size(133, 28)
        Me.uneSupConstruccion.TabIndex = 4
        '
        'uneSupTerreno
        '
        Me.uneSupTerreno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "sterrprop", True))
        Me.uneSupTerreno.Location = New System.Drawing.Point(917, 59)
        Me.uneSupTerreno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneSupTerreno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.uneSupTerreno.Name = "uneSupTerreno"
        Me.uneSupTerreno.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneSupTerreno.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSupTerreno.ReadOnly = True
        Me.uneSupTerreno.Size = New System.Drawing.Size(133, 28)
        Me.uneSupTerreno.TabIndex = 3
        '
        'ucoStatus
        '
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.Name = "Tahoma"
        Appearance16.FontData.SizeInPoints = 9.0!
        Me.ucoStatus.Appearance = Appearance16
        Me.ucoStatus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoStatus.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoStatus.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ArcpredialBindingSource, "status", True))
        UltraGridBand3.ColHeadersVisible = False
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 330
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
        Me.ucoStatus.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucoStatus.DisplayMember = "descripcion"
        Me.ucoStatus.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoStatus.Location = New System.Drawing.Point(253, 59)
        Me.ucoStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoStatus.MaxDropDownItems = 30
        Me.ucoStatus.Name = "ucoStatus"
        Me.ucoStatus.NullText = "Seleccione..."
        Me.ucoStatus.Size = New System.Drawing.Size(440, 28)
        Me.ucoStatus.TabIndex = 1
        Me.ucoStatus.ValueMember = "cve_status"
        '
        'ucoTipoPredio
        '
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.FontData.Name = "Tahoma"
        Appearance17.FontData.SizeInPoints = 9.0!
        Me.ucoTipoPredio.Appearance = Appearance17
        Me.ucoTipoPredio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoTipoPredio.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoTipoPredio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ArcpredialBindingSource, "tipo_predio", True))
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 330
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8})
        Me.ucoTipoPredio.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucoTipoPredio.DisplayMember = "Descripcion"
        Me.ucoTipoPredio.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoTipoPredio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoPredio.Location = New System.Drawing.Point(253, 96)
        Me.ucoTipoPredio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoTipoPredio.MaxDropDownItems = 30
        Me.ucoTipoPredio.Name = "ucoTipoPredio"
        Me.ucoTipoPredio.NullText = "Seleccione..."
        Me.ucoTipoPredio.Size = New System.Drawing.Size(440, 28)
        Me.ucoTipoPredio.TabIndex = 2
        Me.ucoTipoPredio.ValueMember = "tipo_predio"
        '
        'txtcveCatastral
        '
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.BackColor2 = System.Drawing.Color.White
        Me.txtcveCatastral.Appearance = Appearance18
        Me.txtcveCatastral.BackColor = System.Drawing.Color.White
        Me.txtcveCatastral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcveCatastral.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcpredialBindingSource, "cve_catastral", True))
        Me.txtcveCatastral.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtcveCatastral.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcveCatastral.Location = New System.Drawing.Point(253, 12)
        Me.txtcveCatastral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcveCatastral.MaxLength = 16
        Me.txtcveCatastral.Name = "txtcveCatastral"
        Me.txtcveCatastral.ReadOnly = True
        Me.txtcveCatastral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcveCatastral.Size = New System.Drawing.Size(272, 34)
        Me.txtcveCatastral.TabIndex = 0
        Me.txtcveCatastral.UseAppStyling = False
        '
        'lblTipPredio
        '
        Me.lblTipPredio.AutoSize = True
        Me.lblTipPredio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipPredio.Location = New System.Drawing.Point(117, 102)
        Me.lblTipPredio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTipPredio.Name = "lblTipPredio"
        Me.lblTipPredio.Size = New System.Drawing.Size(145, 25)
        Me.lblTipPredio.TabIndex = 99
        Me.lblTipPredio.Text = "Tipo de Predio:"
        Me.lblTipPredio.UseAppStyling = False
        '
        'lblCveCat
        '
        Me.lblCveCat.AutoSize = True
        Me.lblCveCat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCveCat.Location = New System.Drawing.Point(115, 20)
        Me.lblCveCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCveCat.Name = "lblCveCat"
        Me.lblCveCat.Size = New System.Drawing.Size(149, 25)
        Me.lblCveCat.TabIndex = 99
        Me.lblCveCat.Text = "Clave Catastral:"
        Me.lblCveCat.UseAppStyling = False
        '
        'Arc_predialTableAdapter
        '
        Me.Arc_predialTableAdapter.ClearBeforeFill = True
        '
        'frmPredial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1455, 777)
        Me.Controls.Add(Me.grpUltimoPago)
        Me.Controls.Add(Me.grpPAE)
        Me.Controls.Add(Me.grpPropietario)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPredial"
        Me.Text = "Padrón Predial"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcpredialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DasPredial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUltimoPago.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPAE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPAE.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        Me.panNotificado.ResumeLayout(False)
        Me.panNotificado.PerformLayout()
        CType(Me.txtNoActos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoPae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOficioPae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecPAE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPropietario.ResumeLayout(False)
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSupConstruccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSupTerreno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoTipoPredio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcveCatastral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents DasPredial As dasPredial
    Friend WithEvents ArcpredialBindingSource As BindingSource
    Friend WithEvents Arc_predialTableAdapter As dasPredialTableAdapters.arc_predialTableAdapter
    Friend WithEvents grpUltimoPago As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ucoUltMes As ComboBox
    Friend WithEvents lblUltAño As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltANual As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltMes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUlltPeriodo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneUltAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoRecibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uneUltPeriodo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneUltAnual As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents grpPAE As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chkNotificado As CheckBox
    Friend WithEvents panNotificado As Panel
    Friend WithEvents txtNoActos As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ucoPae As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFechaPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoOficioPae As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFecPAE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblNoPAe As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNoActosPAe As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpPropietario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtRfc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblObservaciones As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRFC As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCorreo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCurp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ucoTipoContribuyente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtemail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtObservaciones As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtUbicacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPropietario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUbicacion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCurp As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblContribuyente As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtLongitud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtLatitud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblSupCons As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblSupTerr As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblStatus As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneSupConstruccion As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneSupTerreno As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ucoStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucoTipoPredio As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtcveCatastral As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblTipPredio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCveCat As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnImage As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class