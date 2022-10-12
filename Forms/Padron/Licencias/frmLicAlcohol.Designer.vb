<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLicAlcohol
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("id_colonia")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nom_colonia")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLicencias1 = New TCMAdmin.dsLicencias()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnImage = New System.Windows.Forms.ToolStripButton()
        Me.btnMapa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblCorreo = New Infragistics.Win.Misc.UltraLabel()
        Me.txtemail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCurp = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblCurp = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRfc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTel = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblTelefono = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ucoColonia = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtNoInt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNoExt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblCP = New Infragistics.Win.Misc.UltraLabel()
        Me.lblObs = New Infragistics.Win.Misc.UltraLabel()
        Me.lblResponsable = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRFC = New Infragistics.Win.Misc.UltraLabel()
        Me.ucoLocalidad = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtObservaciones = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtResponsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNoInterior = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblLocalidad = New Infragistics.Win.Misc.UltraLabel()
        Me.lblColonia = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNoExt = New Infragistics.Win.Misc.UltraLabel()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ucoTipoContribuyente = New System.Windows.Forms.ComboBox()
        Me.gruHorario = New Infragistics.Win.Misc.UltraGroupBox()
        Me.mskDomFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.mskDomStart = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.mskSabFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.mskSabIni = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.mskLVFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblLVTxt = New System.Windows.Forms.Label()
        Me.lblSabtxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskLVIni = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtLongitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtLatitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbTipoAnuncio = New System.Windows.Forms.ComboBox()
        Me.lblTipoAnuncio = New Infragistics.Win.Misc.UltraLabel()
        Me.uneDimension = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtActividad = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFechaIniOp = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblIniciRecargo = New Infragistics.Win.Misc.UltraLabel()
        Me.txtClavecatastral = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucoStatus = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblGiro = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDimension = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCveCat = New Infragistics.Win.Misc.UltraLabel()
        Me.lblContribuyente = New Infragistics.Win.Misc.UltraLabel()
        Me.lblStatus = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.lblActividad = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoLic = New System.Windows.Forms.MaskedTextBox()
        Me.cmbGiro = New System.Windows.Forms.ComboBox()
        Me.grpUltimoPago = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneUltMes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneUltAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.dtpFechaPago = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoRecibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNumRecibo = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltAño = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltMes = New Infragistics.Win.Misc.UltraLabel()
        Me.Tbl_lic_municipalesTableAdapter = New TCMAdmin.dsLicenciasTableAdapters.tbl_lic_municipalesTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoColonia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.gruHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruHorario.SuspendLayout()
        CType(Me.mskDomFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskDomStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskSabFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskSabIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskLVFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskLVIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneDimension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClavecatastral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUltimoPago.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.btnImage, Me.btnMapa, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1445, 43)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbl_lic_municipales"
        Me.BindingSource1.DataSource = Me.DsLicencias1
        '
        'DsLicencias1
        '
        Me.DsLicencias1.DataSetName = "dsLicencias"
        Me.DsLicencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.IconoUndo
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
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar "
        Me.btnGuardar.Visible = False
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
        Me.btnEditar.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(40, 40)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.Visible = False
        '
        'btnImage
        '
        Me.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImage.Image = Global.TCMAdmin.My.Resources.Resources.IconImage
        Me.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(40, 40)
        Me.btnImage.Text = "ToolStripButton1"
        Me.btnImage.ToolTipText = "Ver imágenes"
        '
        'btnMapa
        '
        Me.btnMapa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMapa.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Search
        Me.btnMapa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMapa.Name = "btnMapa"
        Me.btnMapa.Size = New System.Drawing.Size(40, 40)
        Me.btnMapa.Text = "Ver Mapa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grpPAE
        '
        Me.grpPAE.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.grpPAE.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpPAE.Enabled = False
        Me.grpPAE.ExpandedSize = New System.Drawing.Size(836, 133)
        Me.grpPAE.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPAE.Location = New System.Drawing.Point(0, 607)
        Me.grpPAE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPAE.Name = "grpPAE"
        Me.grpPAE.Size = New System.Drawing.Size(836, 133)
        Me.grpPAE.TabIndex = 3
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
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(832, 106)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'chkNotificado
        '
        Me.chkNotificado.AutoSize = True
        Me.chkNotificado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "notificado", True))
        Me.chkNotificado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotificado.Location = New System.Drawing.Point(57, 6)
        Me.chkNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNotificado.Name = "chkNotificado"
        Me.chkNotificado.Size = New System.Drawing.Size(103, 22)
        Me.chkNotificado.TabIndex = 2
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
        Me.panNotificado.Location = New System.Drawing.Point(120, 1)
        Me.panNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panNotificado.Name = "panNotificado"
        Me.panNotificado.Size = New System.Drawing.Size(625, 70)
        Me.panNotificado.TabIndex = 3
        '
        'txtNoActos
        '
        Me.txtNoActos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "num_actos", True))
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
        Me.ucoPae.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "pae", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 161
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
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
        Me.txtNoOficioPae.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "num_noti", True))
        Me.txtNoOficioPae.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoOficioPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOficioPae.Location = New System.Drawing.Point(133, 37)
        Me.txtNoOficioPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoOficioPae.MaxLength = 30
        Me.txtNoOficioPae.Name = "txtNoOficioPae"
        Me.txtNoOficioPae.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOficioPae.Size = New System.Drawing.Size(215, 27)
        Me.txtNoOficioPae.TabIndex = 1
        '
        'txtFecPAE
        '
        Me.txtFecPAE.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_noti", True))
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
        Me.grpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPropietario.Enabled = False
        Me.grpPropietario.ExpandedSize = New System.Drawing.Size(1445, 271)
        Me.grpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropietario.Location = New System.Drawing.Point(0, 336)
        Me.grpPropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPropietario.Name = "grpPropietario"
        Me.grpPropietario.Size = New System.Drawing.Size(1445, 271)
        Me.grpPropietario.TabIndex = 2
        Me.grpPropietario.TabStop = False
        Me.grpPropietario.Text = "Datos del Propietario"
        Me.grpPropietario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCorreo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtemail)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtRfc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtTel)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTelefono)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCalle)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCP)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ucoColonia)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNoInt)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNoExt)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCP)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblObs)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblResponsable)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblRFC)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ucoLocalidad)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtObservaciones)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtResponsable)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNoInterior)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblLocalidad)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblColonia)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNoExt)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1441, 244)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(888, 177)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorreo.Size = New System.Drawing.Size(75, 25)
        Me.lblCorreo.TabIndex = 133
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.UseAppStyling = False
        '
        'txtemail
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.txtemail.Appearance = Appearance5
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "correoe", True))
        Me.txtemail.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(956, 172)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtemail.Size = New System.Drawing.Size(393, 27)
        Me.txtemail.TabIndex = 12
        '
        'txtCurp
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.Name = "Tahoma"
        Appearance6.FontData.SizeInPoints = 9.0!
        Me.txtCurp.Appearance = Appearance6
        Me.txtCurp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCurp.InputMask = ">????######??????AA"
        Me.txtCurp.Location = New System.Drawing.Point(1156, 39)
        Me.txtCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.NonAutoSizeHeight = 22
        Me.txtCurp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCurp.Size = New System.Drawing.Size(193, 26)
        Me.txtCurp.TabIndex = 3
        Me.txtCurp.UseAppStyling = False
        '
        'lblCurp
        '
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurp.Location = New System.Drawing.Point(1092, 43)
        Me.lblCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurp.Size = New System.Drawing.Size(64, 25)
        Me.lblCurp.TabIndex = 127
        Me.lblCurp.Text = "CURP:"
        '
        'txtRfc
        '
        Me.txtRfc.AlwaysInEditMode = True
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.txtRfc.Appearance = Appearance7
        Me.txtRfc.BackColor = System.Drawing.Color.White
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "rfc", True))
        Me.txtRfc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRfc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(1156, 6)
        Me.txtRfc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRfc.Size = New System.Drawing.Size(193, 27)
        Me.txtRfc.TabIndex = 1
        '
        'txtTel
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.Name = "Tahoma"
        Appearance8.FontData.SizeInPoints = 9.0!
        Me.txtTel.Appearance = Appearance8
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "telefono", True))
        Me.txtTel.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTel.InputMask = ">########aa"
        Me.txtTel.Location = New System.Drawing.Point(1203, 137)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NonAutoSizeHeight = 22
        Me.txtTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTel.Size = New System.Drawing.Size(147, 26)
        Me.txtTel.TabIndex = 10
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(1120, 142)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(93, 25)
        Me.lblTelefono.TabIndex = 125
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.UseAppStyling = False
        '
        'txtCalle
        '
        Me.txtCalle.AlwaysInEditMode = True
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtCalle.Appearance = Appearance9
        Me.txtCalle.BackColor = System.Drawing.Color.White
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "calle", True))
        Me.txtCalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(253, 73)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalle.Size = New System.Drawing.Size(579, 27)
        Me.txtCalle.TabIndex = 4
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(193, 76)
        Me.UltraLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 25)
        Me.UltraLabel3.TabIndex = 123
        Me.UltraLabel3.Text = "Calle:"
        Me.UltraLabel3.UseAppStyling = False
        '
        'txtCP
        '
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.FontData.Name = "Tahoma"
        Appearance10.FontData.SizeInPoints = 9.0!
        Me.txtCP.Appearance = Appearance10
        Me.txtCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cod_postal", True))
        Me.txtCP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCP.InputMask = "#####"
        Me.txtCP.Location = New System.Drawing.Point(956, 106)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.NonAutoSizeHeight = 22
        Me.txtCP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCP.Size = New System.Drawing.Size(111, 26)
        Me.txtCP.TabIndex = 8
        '
        'ucoColonia
        '
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.Name = "Tahoma"
        Appearance11.FontData.SizeInPoints = 9.0!
        Me.ucoColonia.Appearance = Appearance11
        Me.ucoColonia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoColonia.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoColonia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_col", True))
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Width = 435
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12})
        Me.ucoColonia.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoColonia.DisplayMember = "nom_colonia"
        Me.ucoColonia.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoColonia.Location = New System.Drawing.Point(253, 139)
        Me.ucoColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoColonia.MaxDropDownItems = 30
        Me.ucoColonia.Name = "ucoColonia"
        Me.ucoColonia.NullText = "Seleccione..."
        Me.ucoColonia.Size = New System.Drawing.Size(579, 28)
        Me.ucoColonia.TabIndex = 9
        Me.ucoColonia.ValueMember = "id_colonia"
        '
        'txtNoInt
        '
        Me.txtNoInt.AlwaysInEditMode = True
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.txtNoInt.Appearance = Appearance12
        Me.txtNoInt.BackColor = System.Drawing.Color.White
        Me.txtNoInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "no_int", True))
        Me.txtNoInt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoInt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInt.Location = New System.Drawing.Point(1203, 73)
        Me.txtNoInt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoInt.MaxLength = 5
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoInt.Size = New System.Drawing.Size(147, 27)
        Me.txtNoInt.TabIndex = 6
        '
        'txtNoExt
        '
        Me.txtNoExt.AlwaysInEditMode = True
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.txtNoExt.Appearance = Appearance13
        Me.txtNoExt.BackColor = System.Drawing.Color.White
        Me.txtNoExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "no_ext", True))
        Me.txtNoExt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoExt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoExt.Location = New System.Drawing.Point(956, 73)
        Me.txtNoExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoExt.MaxLength = 5
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoExt.Size = New System.Drawing.Size(111, 27)
        Me.txtNoExt.TabIndex = 5
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(907, 110)
        Me.lblCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(51, 25)
        Me.lblCP.TabIndex = 118
        Me.lblCP.Text = "C.P.:"
        Me.lblCP.UseAppStyling = False
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(123, 209)
        Me.lblObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(147, 25)
        Me.lblObs.TabIndex = 117
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.UseAppStyling = False
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.Location = New System.Drawing.Point(137, 176)
        Me.lblResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(128, 25)
        Me.lblResponsable.TabIndex = 116
        Me.lblResponsable.Text = "Responsable:"
        Me.lblResponsable.UseAppStyling = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(1088, 10)
        Me.lblRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(69, 25)
        Me.lblRFC.TabIndex = 115
        Me.lblRFC.Text = "R.F.C.:"
        Me.lblRFC.UseAppStyling = False
        '
        'ucoLocalidad
        '
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.Name = "Tahoma"
        Appearance14.FontData.SizeInPoints = 9.0!
        Me.ucoLocalidad.Appearance = Appearance14
        Me.ucoLocalidad.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoLocalidad.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_loc", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        UltraGridBand3.ColHeadersVisible = False
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Width = 435
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14})
        Me.ucoLocalidad.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucoLocalidad.DisplayLayout.Override.NullText = "Seleccione..."
        Me.ucoLocalidad.DisplayMember = "nombre"
        Me.ucoLocalidad.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoLocalidad.Location = New System.Drawing.Point(253, 106)
        Me.ucoLocalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoLocalidad.MaxDropDownItems = 30
        Me.ucoLocalidad.Name = "ucoLocalidad"
        Me.ucoLocalidad.NullText = "Seleccione..."
        Me.ucoLocalidad.Size = New System.Drawing.Size(579, 28)
        Me.ucoLocalidad.TabIndex = 7
        Me.ucoLocalidad.ValueMember = "clave"
        '
        'txtObservaciones
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColor2 = System.Drawing.Color.White
        Me.txtObservaciones.Appearance = Appearance15
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "observacion", True))
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(253, 207)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservaciones.Size = New System.Drawing.Size(1096, 27)
        Me.txtObservaciones.TabIndex = 13
        '
        'txtResponsable
        '
        Me.txtResponsable.AlwaysInEditMode = True
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.txtResponsable.Appearance = Appearance16
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "responsable", True))
        Me.txtResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(253, 172)
        Me.txtResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResponsable.MaxLength = 120
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(579, 28)
        Me.txtResponsable.TabIndex = 11
        '
        'txtDomicilio
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.White
        Me.txtDomicilio.Appearance = Appearance17
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "domicilio_fiscal", True))
        Me.txtDomicilio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(253, 39)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(813, 27)
        Me.txtDomicilio.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance18
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "nombre", True))
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(253, 6)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(813, 28)
        Me.txtNombre.TabIndex = 0
        '
        'lblNoInterior
        '
        Me.lblNoInterior.AutoSize = True
        Me.lblNoInterior.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoInterior.Location = New System.Drawing.Point(1093, 76)
        Me.lblNoInterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoInterior.Name = "lblNoInterior"
        Me.lblNoInterior.Size = New System.Drawing.Size(127, 25)
        Me.lblNoInterior.TabIndex = 108
        Me.lblNoInterior.Text = "No. Interior :"
        Me.lblNoInterior.UseAppStyling = False
        '
        'lblNombre
        '
        Appearance19.TextHAlignAsString = "Center"
        Me.lblNombre.Appearance = Appearance19
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(60, 10)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(225, 25)
        Me.lblNombre.TabIndex = 103
        Me.lblNombre.Text = "Nombre ó Razón Social:"
        Me.lblNombre.UseAppStyling = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(117, 43)
        Me.lblDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(153, 25)
        Me.lblDomicilio.TabIndex = 104
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(160, 110)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(100, 25)
        Me.lblLocalidad.TabIndex = 105
        Me.lblLocalidad.Text = "Localidad:"
        Me.lblLocalidad.UseAppStyling = False
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(175, 144)
        Me.lblColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(81, 25)
        Me.lblColonia.TabIndex = 106
        Me.lblColonia.Text = "Colonia:"
        Me.lblColonia.UseAppStyling = False
        '
        'lblNoExt
        '
        Me.lblNoExt.AutoSize = True
        Me.lblNoExt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoExt.Location = New System.Drawing.Point(849, 76)
        Me.lblNoExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoExt.Name = "lblNoExt"
        Me.lblNoExt.Size = New System.Drawing.Size(123, 25)
        Me.lblNoExt.TabIndex = 107
        Me.lblNoExt.Text = "No. Exterior:"
        Me.lblNoExt.UseAppStyling = False
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.Enabled = False
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1445, 293)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1445, 293)
        Me.grpDatosCuenta.TabIndex = 0
        Me.grpDatosCuenta.Text = "Cuenta"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoTipoContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.gruHorario)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLongitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLatitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cmbTipoAnuncio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblTipoAnuncio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneDimension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtActividad)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFechaIniOp)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblIniciRecargo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtClavecatastral)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblGiro)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblDimension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCveCat)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCuenta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblActividad)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNoLic)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cmbGiro)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1441, 266)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'ucoTipoContribuyente
        '
        Me.ucoTipoContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoContribuyente.FormattingEnabled = True
        Me.ucoTipoContribuyente.Location = New System.Drawing.Point(253, 64)
        Me.ucoTipoContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoTipoContribuyente.Name = "ucoTipoContribuyente"
        Me.ucoTipoContribuyente.Size = New System.Drawing.Size(579, 26)
        Me.ucoTipoContribuyente.TabIndex = 121
        '
        'gruHorario
        '
        Me.gruHorario.Controls.Add(Me.mskDomFin)
        Me.gruHorario.Controls.Add(Me.mskDomStart)
        Me.gruHorario.Controls.Add(Me.mskSabFin)
        Me.gruHorario.Controls.Add(Me.mskSabIni)
        Me.gruHorario.Controls.Add(Me.mskLVFin)
        Me.gruHorario.Controls.Add(Me.lblLVTxt)
        Me.gruHorario.Controls.Add(Me.lblSabtxt)
        Me.gruHorario.Controls.Add(Me.Label1)
        Me.gruHorario.Controls.Add(Me.mskLVIni)
        Me.gruHorario.Location = New System.Drawing.Point(921, 38)
        Me.gruHorario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gruHorario.Name = "gruHorario"
        Me.gruHorario.Size = New System.Drawing.Size(428, 123)
        Me.gruHorario.TabIndex = 120
        Me.gruHorario.Text = "Horario de funcionamiento"
        '
        'mskDomFin
        '
        Appearance20.FontData.SizeInPoints = 8.0!
        Me.mskDomFin.Appearance = Appearance20
        Me.mskDomFin.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.CurrentTime
        Me.mskDomFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_fin_domingo", True))
        Me.mskDomFin.DateTime = New Date(2016, 11, 27, 0, 0, 0, 0)
        Me.mskDomFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskDomFin.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskDomFin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDomFin.Location = New System.Drawing.Point(292, 87)
        Me.mskDomFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskDomFin.MaskInput = "{time}"
        Me.mskDomFin.Name = "mskDomFin"
        Me.mskDomFin.Size = New System.Drawing.Size(117, 25)
        Me.mskDomFin.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskDomFin.TabIndex = 13
        Me.mskDomFin.Value = New Date(2016, 11, 27, 0, 0, 0, 0)
        '
        'mskDomStart
        '
        Appearance21.FontData.SizeInPoints = 8.0!
        Me.mskDomStart.Appearance = Appearance21
        Me.mskDomStart.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.CurrentTime
        Me.mskDomStart.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_ini_domingo", True))
        Me.mskDomStart.DateTime = New Date(2016, 11, 27, 0, 0, 0, 0)
        Me.mskDomStart.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskDomStart.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskDomStart.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDomStart.Location = New System.Drawing.Point(157, 87)
        Me.mskDomStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskDomStart.MaskInput = "{time}"
        Me.mskDomStart.Name = "mskDomStart"
        Me.mskDomStart.Size = New System.Drawing.Size(127, 25)
        Me.mskDomStart.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskDomStart.TabIndex = 12
        Me.mskDomStart.Value = New Date(2016, 11, 27, 0, 0, 0, 0)
        '
        'mskSabFin
        '
        Appearance22.FontData.SizeInPoints = 8.0!
        Me.mskSabFin.Appearance = Appearance22
        Me.mskSabFin.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.CurrentTime
        Me.mskSabFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_fin_sabado", True))
        Me.mskSabFin.DateTime = New Date(2016, 11, 27, 0, 0, 0, 0)
        Me.mskSabFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskSabFin.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskSabFin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSabFin.Location = New System.Drawing.Point(292, 57)
        Me.mskSabFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskSabFin.MaskInput = "{time}"
        Me.mskSabFin.Name = "mskSabFin"
        Me.mskSabFin.Size = New System.Drawing.Size(117, 25)
        Me.mskSabFin.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskSabFin.TabIndex = 11
        Me.mskSabFin.Value = New Date(2016, 11, 27, 0, 0, 0, 0)
        '
        'mskSabIni
        '
        Appearance23.FontData.SizeInPoints = 8.0!
        Me.mskSabIni.Appearance = Appearance23
        Me.mskSabIni.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.CurrentTime
        Me.mskSabIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_ini_sabado", True))
        Me.mskSabIni.DateTime = New Date(2016, 11, 27, 0, 0, 0, 0)
        Me.mskSabIni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskSabIni.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskSabIni.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSabIni.Location = New System.Drawing.Point(157, 57)
        Me.mskSabIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskSabIni.MaskInput = "{time}"
        Me.mskSabIni.Name = "mskSabIni"
        Me.mskSabIni.Size = New System.Drawing.Size(127, 25)
        Me.mskSabIni.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskSabIni.TabIndex = 10
        Me.mskSabIni.Value = New Date(2016, 11, 27, 0, 0, 0, 0)
        '
        'mskLVFin
        '
        Appearance24.FontData.SizeInPoints = 8.0!
        Me.mskLVFin.Appearance = Appearance24
        Me.mskLVFin.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.CurrentTime
        Me.mskLVFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_fin_semana", True))
        Me.mskLVFin.DateTime = New Date(2016, 11, 27, 0, 0, 0, 0)
        Me.mskLVFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskLVFin.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskLVFin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskLVFin.Location = New System.Drawing.Point(292, 26)
        Me.mskLVFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskLVFin.MaskInput = "{time}"
        Me.mskLVFin.Name = "mskLVFin"
        Me.mskLVFin.Size = New System.Drawing.Size(117, 25)
        Me.mskLVFin.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskLVFin.TabIndex = 9
        Me.mskLVFin.Value = New Date(2016, 11, 27, 0, 0, 0, 0)
        '
        'lblLVTxt
        '
        Me.lblLVTxt.BackColor = System.Drawing.Color.Silver
        Me.lblLVTxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLVTxt.Location = New System.Drawing.Point(24, 28)
        Me.lblLVTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVTxt.Name = "lblLVTxt"
        Me.lblLVTxt.Size = New System.Drawing.Size(127, 22)
        Me.lblLVTxt.TabIndex = 78
        Me.lblLVTxt.Text = "Lunes a Viernes"
        Me.lblLVTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSabtxt
        '
        Me.lblSabtxt.BackColor = System.Drawing.Color.Silver
        Me.lblSabtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSabtxt.Location = New System.Drawing.Point(24, 59)
        Me.lblSabtxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSabtxt.Name = "lblSabtxt"
        Me.lblSabtxt.Size = New System.Drawing.Size(127, 22)
        Me.lblSabtxt.TabIndex = 79
        Me.lblSabtxt.Text = "Sábado:"
        Me.lblSabtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Domingo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskLVIni
        '
        Appearance25.FontData.SizeInPoints = 8.0!
        Me.mskLVIni.Appearance = Appearance25
        Me.mskLVIni.AutoFillTime = Infragistics.Win.UltraWinMaskedEdit.AutoFillTime.Midnight
        Me.mskLVIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "hr_ini_semana", True))
        Me.mskLVIni.DateTime = New Date(2019, 2, 22, 0, 0, 0, 0)
        Me.mskLVIni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.mskLVIni.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.mskLVIni.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskLVIni.Location = New System.Drawing.Point(157, 27)
        Me.mskLVIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskLVIni.MaskInput = "{time}"
        Me.mskLVIni.Name = "mskLVIni"
        Me.mskLVIni.Size = New System.Drawing.Size(127, 23)
        Me.mskLVIni.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.mskLVIni.TabIndex = 8
        Me.mskLVIni.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.mskLVIni.Value = New Date(2019, 2, 22, 0, 0, 0, 0)
        '
        'txtLongitud
        '
        Me.txtLongitud.AlwaysInEditMode = True
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.BackColor2 = System.Drawing.Color.White
        Me.txtLongitud.Appearance = Appearance26
        Me.txtLongitud.BackColor = System.Drawing.Color.White
        Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLongitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitud.Location = New System.Drawing.Point(1097, 229)
        Me.txtLongitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLongitud.MaxLength = 25
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLongitud.Size = New System.Drawing.Size(252, 27)
        Me.txtLongitud.TabIndex = 118
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(1013, 234)
        Me.UltraLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(93, 25)
        Me.UltraLabel4.TabIndex = 119
        Me.UltraLabel4.Text = "Longitud:"
        Me.UltraLabel4.UseAppStyling = False
        '
        'txtLatitud
        '
        Me.txtLatitud.AlwaysInEditMode = True
        Appearance27.BackColor = System.Drawing.Color.White
        Appearance27.BackColor2 = System.Drawing.Color.White
        Me.txtLatitud.Appearance = Appearance27
        Me.txtLatitud.BackColor = System.Drawing.Color.White
        Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLatitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLatitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitud.Location = New System.Drawing.Point(712, 229)
        Me.txtLatitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLatitud.MaxLength = 25
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatitud.Size = New System.Drawing.Size(252, 27)
        Me.txtLatitud.TabIndex = 116
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(641, 234)
        Me.UltraLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(77, 25)
        Me.UltraLabel2.TabIndex = 117
        Me.UltraLabel2.Text = "Latitud:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'cmbTipoAnuncio
        '
        Me.cmbTipoAnuncio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "tipo_anuncio", True))
        Me.cmbTipoAnuncio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoAnuncio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAnuncio.FormattingEnabled = True
        Me.cmbTipoAnuncio.Location = New System.Drawing.Point(253, 197)
        Me.cmbTipoAnuncio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipoAnuncio.Name = "cmbTipoAnuncio"
        Me.cmbTipoAnuncio.Size = New System.Drawing.Size(1095, 26)
        Me.cmbTipoAnuncio.TabIndex = 6
        '
        'lblTipoAnuncio
        '
        Appearance28.TextHAlignAsString = "Right"
        Me.lblTipoAnuncio.Appearance = Appearance28
        Me.lblTipoAnuncio.AutoSize = True
        Me.lblTipoAnuncio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAnuncio.Location = New System.Drawing.Point(111, 194)
        Me.lblTipoAnuncio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTipoAnuncio.Name = "lblTipoAnuncio"
        Me.lblTipoAnuncio.Size = New System.Drawing.Size(161, 25)
        Me.lblTipoAnuncio.TabIndex = 104
        Me.lblTipoAnuncio.Text = "Tipo de Anuncio:"
        Me.lblTipoAnuncio.UseAppStyling = False
        '
        'uneDimension
        '
        Me.uneDimension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "dimension", True))
        Me.uneDimension.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDimension.Location = New System.Drawing.Point(253, 229)
        Me.uneDimension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneDimension.MinValue = 0R
        Me.uneDimension.Name = "uneDimension"
        Me.uneDimension.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneDimension.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneDimension.Size = New System.Drawing.Size(177, 29)
        Me.uneDimension.TabIndex = 4
        '
        'txtActividad
        '
        Me.txtActividad.AlwaysInEditMode = True
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.BackColor2 = System.Drawing.Color.White
        Me.txtActividad.Appearance = Appearance29
        Me.txtActividad.BackColor = System.Drawing.Color.White
        Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActividad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "giro", True))
        Me.txtActividad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtActividad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad.Location = New System.Drawing.Point(253, 132)
        Me.txtActividad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtActividad.MaxLength = 25
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtActividad.Size = New System.Drawing.Size(579, 27)
        Me.txtActividad.TabIndex = 3
        '
        'txtFechaIniOp
        '
        Me.txtFechaIniOp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_ini_oper", True))
        Me.txtFechaIniOp.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFechaIniOp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIniOp.Location = New System.Drawing.Point(1216, 6)
        Me.txtFechaIniOp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaIniOp.Name = "txtFechaIniOp"
        Me.txtFechaIniOp.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaIniOp.TabIndex = 5
        Me.txtFechaIniOp.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblIniciRecargo
        '
        Me.lblIniciRecargo.AutoSize = True
        Me.lblIniciRecargo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciRecargo.Location = New System.Drawing.Point(1029, 11)
        Me.lblIniciRecargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblIniciRecargo.Name = "lblIniciRecargo"
        Me.lblIniciRecargo.Size = New System.Drawing.Size(223, 25)
        Me.lblIniciRecargo.TabIndex = 100
        Me.lblIniciRecargo.Text = "Fecha Inicio Operación:"
        Me.lblIniciRecargo.UseAppStyling = False
        '
        'txtClavecatastral
        '
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.BackColor2 = System.Drawing.Color.White
        Me.txtClavecatastral.Appearance = Appearance30
        Me.txtClavecatastral.BackColor = System.Drawing.Color.White
        Me.txtClavecatastral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavecatastral.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_catastral", True))
        Me.txtClavecatastral.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtClavecatastral.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClavecatastral.Location = New System.Drawing.Point(567, 23)
        Me.txtClavecatastral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClavecatastral.MaxLength = 16
        Me.txtClavecatastral.Name = "txtClavecatastral"
        Me.txtClavecatastral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClavecatastral.Size = New System.Drawing.Size(267, 32)
        Me.txtClavecatastral.TabIndex = 0
        Me.txtClavecatastral.UseAppStyling = False
        '
        'ucoStatus
        '
        Appearance31.FontData.BoldAsString = "True"
        Appearance31.FontData.Name = "Tahoma"
        Appearance31.FontData.SizeInPoints = 9.0!
        Me.ucoStatus.Appearance = Appearance31
        Me.ucoStatus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoStatus.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 435
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16})
        Me.ucoStatus.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucoStatus.DisplayMember = "descripcion"
        Me.ucoStatus.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoStatus.Location = New System.Drawing.Point(253, 98)
        Me.ucoStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoStatus.MaxDropDownItems = 30
        Me.ucoStatus.Name = "ucoStatus"
        Me.ucoStatus.NullText = "Seleccione..."
        Me.ucoStatus.Size = New System.Drawing.Size(579, 28)
        Me.ucoStatus.TabIndex = 2
        Me.ucoStatus.ValueMember = "cve_status"
        '
        'lblGiro
        '
        Me.lblGiro.AutoSize = True
        Me.lblGiro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiro.Location = New System.Drawing.Point(199, 162)
        Me.lblGiro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(52, 25)
        Me.lblGiro.TabIndex = 93
        Me.lblGiro.Text = "Giro:"
        Me.lblGiro.UseAppStyling = False
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimension.Location = New System.Drawing.Point(152, 228)
        Me.lblDimension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(109, 25)
        Me.lblDimension.TabIndex = 70
        Me.lblDimension.Text = "Dimensión:"
        Me.lblDimension.UseAppStyling = False
        '
        'lblCveCat
        '
        Me.lblCveCat.AutoSize = True
        Me.lblCveCat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCveCat.Location = New System.Drawing.Point(437, 30)
        Me.lblCveCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCveCat.Name = "lblCveCat"
        Me.lblCveCat.Size = New System.Drawing.Size(149, 25)
        Me.lblCveCat.TabIndex = 54
        Me.lblCveCat.Text = "Clave Catastral:"
        Me.lblCveCat.UseAppStyling = False
        '
        'lblContribuyente
        '
        Me.lblContribuyente.AutoSize = True
        Me.lblContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContribuyente.Location = New System.Drawing.Point(127, 64)
        Me.lblContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblContribuyente.Name = "lblContribuyente"
        Me.lblContribuyente.Size = New System.Drawing.Size(141, 25)
        Me.lblContribuyente.TabIndex = 56
        Me.lblContribuyente.Text = "Contribuyente:"
        Me.lblContribuyente.UseAppStyling = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(183, 95)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 25)
        Me.lblStatus.TabIndex = 57
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.UseAppStyling = False
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(117, 27)
        Me.lblCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(153, 25)
        Me.lblCuenta.TabIndex = 59
        Me.lblCuenta.Text = "No. de Licencia:"
        Me.lblCuenta.UseAppStyling = False
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividad.Location = New System.Drawing.Point(163, 129)
        Me.lblActividad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(96, 25)
        Me.lblActividad.TabIndex = 61
        Me.lblActividad.Text = "Actividad:"
        Me.lblActividad.UseAppStyling = False
        '
        'txtNoLic
        '
        Me.txtNoLic.BackColor = System.Drawing.SystemColors.Control
        Me.txtNoLic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_licencia", True))
        Me.txtNoLic.Enabled = False
        Me.txtNoLic.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLic.Location = New System.Drawing.Point(253, 23)
        Me.txtNoLic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoLic.Mask = "LL-000000"
        Me.txtNoLic.Name = "txtNoLic"
        Me.txtNoLic.ReadOnly = True
        Me.txtNoLic.Size = New System.Drawing.Size(145, 30)
        Me.txtNoLic.TabIndex = 1
        '
        'cmbGiro
        '
        Me.cmbGiro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "tip_der", True))
        Me.cmbGiro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGiro.FormattingEnabled = True
        Me.cmbGiro.Location = New System.Drawing.Point(253, 165)
        Me.cmbGiro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGiro.Name = "cmbGiro"
        Me.cmbGiro.Size = New System.Drawing.Size(1095, 26)
        Me.cmbGiro.TabIndex = 7
        '
        'grpUltimoPago
        '
        Me.grpUltimoPago.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grpUltimoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUltimoPago.Enabled = False
        Me.grpUltimoPago.ExpandedSize = New System.Drawing.Size(609, 133)
        Me.grpUltimoPago.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpUltimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimoPago.Location = New System.Drawing.Point(836, 607)
        Me.grpUltimoPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUltimoPago.Name = "grpUltimoPago"
        Me.grpUltimoPago.Size = New System.Drawing.Size(609, 133)
        Me.grpUltimoPago.TabIndex = 4
        Me.grpUltimoPago.TabStop = False
        Me.grpUltimoPago.Text = "Último Pago"
        Me.grpUltimoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltMes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltAnio)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.dtpFechaPago)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtNoRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblNumRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltAño)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltMes)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(605, 106)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'uneUltMes
        '
        Me.uneUltMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_mes_pago", True))
        Me.uneUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneUltMes.Location = New System.Drawing.Point(380, 5)
        Me.uneUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltMes.MaxValue = 12
        Me.uneUltMes.MinValue = 1
        Me.uneUltMes.Name = "uneUltMes"
        Me.uneUltMes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltMes.ReadOnly = True
        Me.uneUltMes.Size = New System.Drawing.Size(133, 27)
        Me.uneUltMes.TabIndex = 2
        Me.uneUltMes.Value = 12
        '
        'uneUltAnio
        '
        Me.uneUltAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_año_pago", True))
        Me.uneUltAnio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneUltAnio.Location = New System.Drawing.Point(380, 38)
        Me.uneUltAnio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltAnio.MaxValue = 2050
        Me.uneUltAnio.MinValue = 0
        Me.uneUltAnio.Name = "uneUltAnio"
        Me.uneUltAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnio.Size = New System.Drawing.Size(133, 27)
        Me.uneUltAnio.TabIndex = 3
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_pago", True))
        Me.dtpFechaPago.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.dtpFechaPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Location = New System.Drawing.Point(120, 41)
        Me.dtpFechaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(147, 27)
        Me.dtpFechaPago.TabIndex = 1
        Me.dtpFechaPago.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(57, 43)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 25)
        Me.UltraLabel1.TabIndex = 91
        Me.UltraLabel1.Text = "Fecha:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.AlwaysInEditMode = True
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtNoRecibo.Appearance = Appearance1
        Me.txtNoRecibo.BackColor = System.Drawing.Color.White
        Me.txtNoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoRecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "folio_recibo", True))
        Me.txtNoRecibo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRecibo.Location = New System.Drawing.Point(120, 7)
        Me.txtNoRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoRecibo.MaxLength = 10
        Me.txtNoRecibo.Multiline = True
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRecibo.Size = New System.Drawing.Size(147, 28)
        Me.txtNoRecibo.TabIndex = 0
        '
        'lblNumRecibo
        '
        Me.lblNumRecibo.AutoSize = True
        Me.lblNumRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRecibo.Location = New System.Drawing.Point(21, 11)
        Me.lblNumRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNumRecibo.Name = "lblNumRecibo"
        Me.lblNumRecibo.Size = New System.Drawing.Size(112, 25)
        Me.lblNumRecibo.TabIndex = 89
        Me.lblNumRecibo.Text = "No. Recibo:"
        Me.lblNumRecibo.UseAppStyling = False
        '
        'lblUltAño
        '
        Me.lblUltAño.AutoSize = True
        Me.lblUltAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltAño.Location = New System.Drawing.Point(300, 43)
        Me.lblUltAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltAño.Name = "lblUltAño"
        Me.lblUltAño.Size = New System.Drawing.Size(88, 25)
        Me.lblUltAño.TabIndex = 77
        Me.lblUltAño.Text = "Últ. Año:"
        Me.lblUltAño.UseAppStyling = False
        '
        'lblUltMes
        '
        Me.lblUltMes.AutoSize = True
        Me.lblUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltMes.Location = New System.Drawing.Point(301, 7)
        Me.lblUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltMes.Name = "lblUltMes"
        Me.lblUltMes.Size = New System.Drawing.Size(88, 25)
        Me.lblUltMes.TabIndex = 76
        Me.lblUltMes.Text = "Últ. Mes:"
        Me.lblUltMes.UseAppStyling = False
        '
        'Tbl_lic_municipalesTableAdapter
        '
        Me.Tbl_lic_municipalesTableAdapter.ClearBeforeFill = True
        '
        'frmLicAlcohol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1445, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpUltimoPago)
        Me.Controls.Add(Me.grpPAE)
        Me.Controls.Add(Me.grpPropietario)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLicAlcohol"
        Me.Text = "Licencias para la venta de bebidas alcóholicas y comercio"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoColonia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.gruHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruHorario.ResumeLayout(False)
        Me.gruHorario.PerformLayout()
        CType(Me.mskDomFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskDomStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskSabFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskSabIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskLVFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskLVIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneDimension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActividad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClavecatastral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUltimoPago.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DsLicencias1 As dsLicencias
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Tbl_lic_municipalesTableAdapter As dsLicenciasTableAdapters.tbl_lic_municipalesTableAdapter
    Friend WithEvents grpPAE As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grpPropietario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Private WithEvents mskLVIni As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSabtxt As Label
    Friend WithEvents lblLVTxt As Label
    Private WithEvents lblDimension As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblCveCat As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblContribuyente As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblStatus As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblActividad As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoLic As MaskedTextBox
    Friend WithEvents cmbGiro As ComboBox
    Private WithEvents mskLVFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents mskSabIni As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents mskSabFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents mskDomStart As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents mskDomFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Private WithEvents lblGiro As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucoStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtClavecatastral As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTel As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblTelefono As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ucoColonia As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtNoInt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNoExt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblCP As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblObs As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblResponsable As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRFC As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucoLocalidad As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtObservaciones As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtResponsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNoInterior As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblLocalidad As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblColonia As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNoExt As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpUltimoPago As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents lblUltAño As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltMes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaPago As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoRecibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNumRecibo As Infragistics.Win.Misc.UltraLabel
    Private WithEvents txtFechaIniOp As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents lblIniciRecargo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents uneUltMes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneUltAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtActividad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uneDimension As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtRfc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCurp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblCurp As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCorreo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtemail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnImage As ToolStripButton
    Friend WithEvents cmbTipoAnuncio As ComboBox
    Friend WithEvents lblTipoAnuncio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtLongitud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtLatitud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents gruHorario As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ucoTipoContribuyente As ComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnMapa As ToolStripButton
End Class
