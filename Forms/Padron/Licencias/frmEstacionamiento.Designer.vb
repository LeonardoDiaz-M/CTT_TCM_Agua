<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstacionamiento
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("id_colonia")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nom_colonia")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_tip_con")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descricion")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLicencias1 = New TCMAdmin.dsLicencias()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl_lic_municipalesTableAdapter = New TCMAdmin.dsLicenciasTableAdapters.tbl_lic_municipalesTableAdapter()
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
        Me.txtLongitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtLatitud = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneNumeroCajones = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtClavecatastral = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucoTipoContribuyente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoStatus = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblStatus = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDimension = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFechaIniOp = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblIniciRecargo = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCveCat = New Infragistics.Win.Misc.UltraLabel()
        Me.lblContribuyente = New Infragistics.Win.Misc.UltraLabel()
        Me.lblTipoLic = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoLic = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTipoLicencia = New System.Windows.Forms.ComboBox()
        Me.mskUltMes = New System.Windows.Forms.ComboBox()
        Me.grpUltimoPago = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.dtpFechaPago = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoRecibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNumRecibo = New Infragistics.Win.Misc.UltraLabel()
        Me.uneUltAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.lblUltAño = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltMes = New Infragistics.Win.Misc.UltraLabel()
        Me.btnMapa = New System.Windows.Forms.ToolStripButton()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
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
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneNumeroCajones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClavecatastral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUltimoPago.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.btnImage, Me.btnMapa, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1084, 43)
        Me.BindingNavigator1.TabIndex = 0
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
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.IconoUndo
        Me.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(28, 40)
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
        Me.btnGuardar.ToolTipText = "Guardar"
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
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.DimGray
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripLabel1.Text = "           "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Tbl_lic_municipalesTableAdapter
        '
        Me.Tbl_lic_municipalesTableAdapter.ClearBeforeFill = True
        '
        'grpPAE
        '
        Me.grpPAE.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.grpPAE.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpPAE.Enabled = False
        Me.grpPAE.ExpandedSize = New System.Drawing.Size(638, 150)
        Me.grpPAE.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPAE.Location = New System.Drawing.Point(0, 467)
        Me.grpPAE.Name = "grpPAE"
        Me.grpPAE.Size = New System.Drawing.Size(638, 150)
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
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(634, 127)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'chkNotificado
        '
        Me.chkNotificado.AutoSize = True
        Me.chkNotificado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "notificado", True))
        Me.chkNotificado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotificado.Location = New System.Drawing.Point(54, 6)
        Me.chkNotificado.Name = "chkNotificado"
        Me.chkNotificado.Size = New System.Drawing.Size(88, 18)
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
        Me.panNotificado.Location = New System.Drawing.Point(101, 2)
        Me.panNotificado.Name = "panNotificado"
        Me.panNotificado.Size = New System.Drawing.Size(469, 57)
        Me.panNotificado.TabIndex = 3
        '
        'txtNoActos
        '
        Me.txtNoActos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "num_actos", True))
        Me.txtNoActos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActos.Location = New System.Drawing.Point(362, 30)
        Me.txtNoActos.MaskInput = "999"
        Me.txtNoActos.Name = "txtNoActos"
        Me.txtNoActos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNoActos.Size = New System.Drawing.Size(51, 23)
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
        Me.ucoPae.Location = New System.Drawing.Point(100, 3)
        Me.ucoPae.MaxDropDownItems = 30
        Me.ucoPae.Name = "ucoPae"
        Me.ucoPae.NullText = "Seleccione..."
        Me.ucoPae.Size = New System.Drawing.Size(161, 24)
        Me.ucoPae.TabIndex = 0
        Me.ucoPae.ValueMember = "cve_tip_con"
        '
        'lblPae
        '
        Me.lblPae.AutoSize = True
        Me.lblPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(50, 6)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(40, 16)
        Me.lblPae.TabIndex = 99
        Me.lblPae.Text = "Etapa:"
        Me.lblPae.UseAppStyling = False
        '
        'lblFechaPae
        '
        Me.lblFechaPae.AutoSize = True
        Me.lblFechaPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPae.Location = New System.Drawing.Point(284, 7)
        Me.lblFechaPae.Name = "lblFechaPae"
        Me.lblFechaPae.Size = New System.Drawing.Size(68, 16)
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
        Me.txtNoOficioPae.Location = New System.Drawing.Point(100, 30)
        Me.txtNoOficioPae.MaxLength = 30
        Me.txtNoOficioPae.Name = "txtNoOficioPae"
        Me.txtNoOficioPae.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOficioPae.Size = New System.Drawing.Size(161, 23)
        Me.txtNoOficioPae.TabIndex = 1
        '
        'txtFecPAE
        '
        Me.txtFecPAE.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_noti", True))
        Me.txtFecPAE.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFecPAE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecPAE.Location = New System.Drawing.Point(362, 4)
        Me.txtFecPAE.Name = "txtFecPAE"
        Me.txtFecPAE.Size = New System.Drawing.Size(100, 23)
        Me.txtFecPAE.TabIndex = 2
        Me.txtFecPAE.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblNoPAe
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.lblNoPAe.Appearance = Appearance4
        Me.lblNoPAe.AutoSize = True
        Me.lblNoPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPAe.Location = New System.Drawing.Point(3, 33)
        Me.lblNoPAe.Name = "lblNoPAe"
        Me.lblNoPAe.Size = New System.Drawing.Size(87, 16)
        Me.lblNoPAe.TabIndex = 47
        Me.lblNoPAe.Text = "Oficio Número:"
        Me.lblNoPAe.UseAppStyling = False
        '
        'lblNoActosPAe
        '
        Me.lblNoActosPAe.AutoSize = True
        Me.lblNoActosPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoActosPAe.Location = New System.Drawing.Point(275, 34)
        Me.lblNoActosPAe.Name = "lblNoActosPAe"
        Me.lblNoActosPAe.Size = New System.Drawing.Size(77, 16)
        Me.lblNoActosPAe.TabIndex = 48
        Me.lblNoActosPAe.Text = "No. de actos:"
        Me.lblNoActosPAe.UseAppStyling = False
        '
        'grpPropietario
        '
        Me.grpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPropietario.Enabled = False
        Me.grpPropietario.ExpandedSize = New System.Drawing.Size(1084, 220)
        Me.grpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropietario.Location = New System.Drawing.Point(0, 247)
        Me.grpPropietario.Name = "grpPropietario"
        Me.grpPropietario.Size = New System.Drawing.Size(1084, 220)
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
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1080, 197)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(677, 145)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorreo.Size = New System.Drawing.Size(45, 16)
        Me.lblCorreo.TabIndex = 189
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
        Me.txtemail.Location = New System.Drawing.Point(728, 141)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtemail.Size = New System.Drawing.Size(295, 23)
        Me.txtemail.TabIndex = 174
        '
        'txtCurp
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.Name = "Tahoma"
        Appearance6.FontData.SizeInPoints = 9.0!
        Me.txtCurp.Appearance = Appearance6
        Me.txtCurp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCurp.InputMask = ">????######??????AA"
        Me.txtCurp.Location = New System.Drawing.Point(878, 33)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.NonAutoSizeHeight = 22
        Me.txtCurp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCurp.Size = New System.Drawing.Size(145, 22)
        Me.txtCurp.TabIndex = 165
        Me.txtCurp.UseAppStyling = False
        '
        'lblCurp
        '
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurp.Location = New System.Drawing.Point(830, 36)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurp.Size = New System.Drawing.Size(39, 16)
        Me.lblCurp.TabIndex = 188
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
        Me.txtRfc.Location = New System.Drawing.Point(878, 6)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRfc.Size = New System.Drawing.Size(145, 23)
        Me.txtRfc.TabIndex = 163
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
        Me.txtTel.Location = New System.Drawing.Point(913, 112)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NonAutoSizeHeight = 22
        Me.txtTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTel.Size = New System.Drawing.Size(110, 22)
        Me.txtTel.TabIndex = 172
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(851, 116)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(56, 16)
        Me.lblTelefono.TabIndex = 187
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
        Me.txtCalle.Location = New System.Drawing.Point(201, 60)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalle.Size = New System.Drawing.Size(434, 23)
        Me.txtCalle.TabIndex = 166
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(156, 63)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(35, 16)
        Me.UltraLabel3.TabIndex = 186
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
        Me.txtCP.Location = New System.Drawing.Point(728, 87)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.NonAutoSizeHeight = 22
        Me.txtCP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCP.Size = New System.Drawing.Size(83, 22)
        Me.txtCP.TabIndex = 170
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
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 435
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ucoColonia.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoColonia.DisplayMember = "nom_colonia"
        Me.ucoColonia.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoColonia.Location = New System.Drawing.Point(201, 114)
        Me.ucoColonia.MaxDropDownItems = 30
        Me.ucoColonia.Name = "ucoColonia"
        Me.ucoColonia.NullText = "Seleccione..."
        Me.ucoColonia.Size = New System.Drawing.Size(434, 24)
        Me.ucoColonia.TabIndex = 171
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
        Me.txtNoInt.Location = New System.Drawing.Point(913, 60)
        Me.txtNoInt.MaxLength = 5
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoInt.Size = New System.Drawing.Size(110, 23)
        Me.txtNoInt.TabIndex = 168
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
        Me.txtNoExt.Location = New System.Drawing.Point(728, 60)
        Me.txtNoExt.MaxLength = 5
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoExt.Size = New System.Drawing.Size(83, 23)
        Me.txtNoExt.TabIndex = 167
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(691, 90)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(31, 16)
        Me.lblCP.TabIndex = 185
        Me.lblCP.Text = "C.P.:"
        Me.lblCP.UseAppStyling = False
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(103, 171)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(88, 16)
        Me.lblObs.TabIndex = 184
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.UseAppStyling = False
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.Location = New System.Drawing.Point(114, 144)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(77, 16)
        Me.lblResponsable.TabIndex = 183
        Me.lblResponsable.Text = "Responsable:"
        Me.lblResponsable.UseAppStyling = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(827, 9)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(42, 16)
        Me.lblRFC.TabIndex = 182
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
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Width = 435
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12})
        Me.ucoLocalidad.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucoLocalidad.DisplayLayout.Override.NullText = "Seleccione..."
        Me.ucoLocalidad.DisplayMember = "nombre"
        Me.ucoLocalidad.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoLocalidad.Location = New System.Drawing.Point(201, 87)
        Me.ucoLocalidad.MaxDropDownItems = 30
        Me.ucoLocalidad.Name = "ucoLocalidad"
        Me.ucoLocalidad.NullText = "Seleccione..."
        Me.ucoLocalidad.Size = New System.Drawing.Size(434, 24)
        Me.ucoLocalidad.TabIndex = 169
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
        Me.txtObservaciones.Location = New System.Drawing.Point(201, 169)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservaciones.Size = New System.Drawing.Size(822, 23)
        Me.txtObservaciones.TabIndex = 175
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
        Me.txtResponsable.Location = New System.Drawing.Point(201, 141)
        Me.txtResponsable.MaxLength = 120
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(434, 23)
        Me.txtResponsable.TabIndex = 173
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
        Me.txtDomicilio.Location = New System.Drawing.Point(201, 33)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(610, 23)
        Me.txtDomicilio.TabIndex = 164
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
        Me.txtNombre.Location = New System.Drawing.Point(201, 6)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(610, 23)
        Me.txtNombre.TabIndex = 162
        '
        'lblNoInterior
        '
        Me.lblNoInterior.AutoSize = True
        Me.lblNoInterior.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoInterior.Location = New System.Drawing.Point(831, 63)
        Me.lblNoInterior.Name = "lblNoInterior"
        Me.lblNoInterior.Size = New System.Drawing.Size(76, 16)
        Me.lblNoInterior.TabIndex = 181
        Me.lblNoInterior.Text = "No. Interior :"
        Me.lblNoInterior.UseAppStyling = False
        '
        'lblNombre
        '
        Appearance19.TextHAlignAsString = "Center"
        Me.lblNombre.Appearance = Appearance19
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(56, 9)
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
        Me.lblDomicilio.Location = New System.Drawing.Point(99, 36)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(92, 16)
        Me.lblDomicilio.TabIndex = 177
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(131, 90)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(60, 16)
        Me.lblLocalidad.TabIndex = 178
        Me.lblLocalidad.Text = "Localidad:"
        Me.lblLocalidad.UseAppStyling = False
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(142, 118)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(49, 16)
        Me.lblColonia.TabIndex = 179
        Me.lblColonia.Text = "Colonia:"
        Me.lblColonia.UseAppStyling = False
        '
        'lblNoExt
        '
        Me.lblNoExt.AutoSize = True
        Me.lblNoExt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoExt.Location = New System.Drawing.Point(648, 63)
        Me.lblNoExt.Name = "lblNoExt"
        Me.lblNoExt.Size = New System.Drawing.Size(74, 16)
        Me.lblNoExt.TabIndex = 180
        Me.lblNoExt.Text = "No. Exterior:"
        Me.lblNoExt.UseAppStyling = False
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.Enabled = False
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1084, 204)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1084, 204)
        Me.grpDatosCuenta.TabIndex = 1
        Me.grpDatosCuenta.TabStop = False
        Me.grpDatosCuenta.Text = "Cuenta"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLongitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtLatitud)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneNumeroCajones)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtClavecatastral)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoTipoContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblDimension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFechaIniOp)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblIniciRecargo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCveCat)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblTipoLic)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCuenta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNoLic)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cmbTipoLicencia)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1080, 181)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'txtLongitud
        '
        Me.txtLongitud.AlwaysInEditMode = True
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.BackColor2 = System.Drawing.Color.White
        Me.txtLongitud.Appearance = Appearance20
        Me.txtLongitud.BackColor = System.Drawing.Color.White
        Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitud.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Longitud", True))
        Me.txtLongitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLongitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitud.Location = New System.Drawing.Point(834, 150)
        Me.txtLongitud.MaxLength = 25
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLongitud.Size = New System.Drawing.Size(189, 23)
        Me.txtLongitud.TabIndex = 118
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(770, 154)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel4.TabIndex = 119
        Me.UltraLabel4.Text = "Longitud:"
        Me.UltraLabel4.UseAppStyling = False
        '
        'txtLatitud
        '
        Me.txtLatitud.AlwaysInEditMode = True
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.White
        Me.txtLatitud.Appearance = Appearance21
        Me.txtLatitud.BackColor = System.Drawing.Color.White
        Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLatitud.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Latitud", True))
        Me.txtLatitud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLatitud.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitud.Location = New System.Drawing.Point(545, 150)
        Me.txtLatitud.MaxLength = 25
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatitud.Size = New System.Drawing.Size(189, 23)
        Me.txtLatitud.TabIndex = 116
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(492, 154)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(46, 16)
        Me.UltraLabel2.TabIndex = 117
        Me.UltraLabel2.Text = "Latitud:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'uneNumeroCajones
        '
        Me.uneNumeroCajones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "dimension", True))
        Me.uneNumeroCajones.Location = New System.Drawing.Point(201, 150)
        Me.uneNumeroCajones.MinValue = 0
        Me.uneNumeroCajones.Name = "uneNumeroCajones"
        Me.uneNumeroCajones.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneNumeroCajones.Size = New System.Drawing.Size(100, 24)
        Me.uneNumeroCajones.TabIndex = 5
        '
        'txtClavecatastral
        '
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.BackColor2 = System.Drawing.Color.White
        Me.txtClavecatastral.Appearance = Appearance22
        Me.txtClavecatastral.BackColor = System.Drawing.Color.White
        Me.txtClavecatastral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClavecatastral.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_catastral", True))
        Me.txtClavecatastral.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtClavecatastral.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClavecatastral.Location = New System.Drawing.Point(201, 34)
        Me.txtClavecatastral.MaxLength = 16
        Me.txtClavecatastral.Name = "txtClavecatastral"
        Me.txtClavecatastral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClavecatastral.Size = New System.Drawing.Size(204, 29)
        Me.txtClavecatastral.TabIndex = 0
        Me.txtClavecatastral.UseAppStyling = False
        '
        'ucoTipoContribuyente
        '
        Appearance23.FontData.BoldAsString = "True"
        Appearance23.FontData.Name = "Tahoma"
        Appearance23.FontData.SizeInPoints = 9.0!
        Me.ucoTipoContribuyente.Appearance = Appearance23
        Me.ucoTipoContribuyente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoTipoContribuyente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoTipoContribuyente.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_tip_con", True))
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 435
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8})
        Me.ucoTipoContribuyente.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucoTipoContribuyente.DisplayMember = "Descricion"
        Me.ucoTipoContribuyente.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoTipoContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoContribuyente.Location = New System.Drawing.Point(201, 68)
        Me.ucoTipoContribuyente.MaxDropDownItems = 30
        Me.ucoTipoContribuyente.Name = "ucoTipoContribuyente"
        Me.ucoTipoContribuyente.NullText = "Seleccione..."
        Me.ucoTipoContribuyente.Size = New System.Drawing.Size(435, 24)
        Me.ucoTipoContribuyente.TabIndex = 1
        Me.ucoTipoContribuyente.ValueMember = "cve_tip_con"
        '
        'ucoStatus
        '
        Appearance24.FontData.BoldAsString = "True"
        Appearance24.FontData.Name = "Tahoma"
        Appearance24.FontData.SizeInPoints = 9.0!
        Me.ucoStatus.Appearance = Appearance24
        Me.ucoStatus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoStatus.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoStatus.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "status", True))
        UltraGridBand5.ColHeadersVisible = False
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 435
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoStatus.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucoStatus.DisplayMember = "descripcion"
        Me.ucoStatus.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoStatus.Location = New System.Drawing.Point(201, 96)
        Me.ucoStatus.MaxDropDownItems = 30
        Me.ucoStatus.Name = "ucoStatus"
        Me.ucoStatus.NullText = "Seleccione..."
        Me.ucoStatus.Size = New System.Drawing.Size(435, 24)
        Me.ucoStatus.TabIndex = 2
        Me.ucoStatus.ValueMember = "cve_status"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(148, 100)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 16)
        Me.lblStatus.TabIndex = 89
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.UseAppStyling = False
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimension.Location = New System.Drawing.Point(98, 154)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(92, 16)
        Me.lblDimension.TabIndex = 70
        Me.lblDimension.Text = "No. de Cajones:"
        '
        'txtFechaIniOp
        '
        Me.txtFechaIniOp.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFechaIniOp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIniOp.Location = New System.Drawing.Point(923, 68)
        Me.txtFechaIniOp.Name = "txtFechaIniOp"
        Me.txtFechaIniOp.Size = New System.Drawing.Size(100, 23)
        Me.txtFechaIniOp.TabIndex = 4
        Me.txtFechaIniOp.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblIniciRecargo
        '
        Me.lblIniciRecargo.AutoSize = True
        Me.lblIniciRecargo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciRecargo.Location = New System.Drawing.Point(779, 72)
        Me.lblIniciRecargo.Name = "lblIniciRecargo"
        Me.lblIniciRecargo.Size = New System.Drawing.Size(133, 16)
        Me.lblIniciRecargo.TabIndex = 68
        Me.lblIniciRecargo.Text = "Fecha Inicio Operación:"
        Me.lblIniciRecargo.UseAppStyling = False
        '
        'lblCveCat
        '
        Me.lblCveCat.AutoSize = True
        Me.lblCveCat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCveCat.Location = New System.Drawing.Point(101, 42)
        Me.lblCveCat.Name = "lblCveCat"
        Me.lblCveCat.Size = New System.Drawing.Size(90, 16)
        Me.lblCveCat.TabIndex = 54
        Me.lblCveCat.Text = "Clave Catastral:"
        Me.lblCveCat.UseAppStyling = False
        '
        'lblContribuyente
        '
        Me.lblContribuyente.AutoSize = True
        Me.lblContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContribuyente.Location = New System.Drawing.Point(106, 72)
        Me.lblContribuyente.Name = "lblContribuyente"
        Me.lblContribuyente.Size = New System.Drawing.Size(85, 16)
        Me.lblContribuyente.TabIndex = 56
        Me.lblContribuyente.Text = "Contribuyente:"
        Me.lblContribuyente.UseAppStyling = False
        '
        'lblTipoLic
        '
        Me.lblTipoLic.AutoSize = True
        Me.lblTipoLic.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoLic.Location = New System.Drawing.Point(94, 123)
        Me.lblTipoLic.Name = "lblTipoLic"
        Me.lblTipoLic.Size = New System.Drawing.Size(97, 16)
        Me.lblTipoLic.TabIndex = 57
        Me.lblTipoLic.Text = "Tipo de Licencia:"
        Me.lblTipoLic.UseAppStyling = False
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(99, 10)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(92, 16)
        Me.lblCuenta.TabIndex = 59
        Me.lblCuenta.Text = "No. de Licencia:"
        Me.lblCuenta.UseAppStyling = False
        '
        'txtNoLic
        '
        Me.txtNoLic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_licencia", True))
        Me.txtNoLic.Enabled = False
        Me.txtNoLic.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLic.Location = New System.Drawing.Point(201, 4)
        Me.txtNoLic.Mask = "LL-000000"
        Me.txtNoLic.Name = "txtNoLic"
        Me.txtNoLic.ReadOnly = True
        Me.txtNoLic.Size = New System.Drawing.Size(133, 26)
        Me.txtNoLic.TabIndex = 55
        '
        'cmbTipoLicencia
        '
        Me.cmbTipoLicencia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "tip_der", True))
        Me.cmbTipoLicencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoLicencia.FormattingEnabled = True
        Me.cmbTipoLicencia.Location = New System.Drawing.Point(201, 124)
        Me.cmbTipoLicencia.Name = "cmbTipoLicencia"
        Me.cmbTipoLicencia.Size = New System.Drawing.Size(822, 22)
        Me.cmbTipoLicencia.TabIndex = 3
        '
        'mskUltMes
        '
        Me.mskUltMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_mes_pago", True))
        Me.mskUltMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mskUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskUltMes.FormattingEnabled = True
        Me.mskUltMes.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12"})
        Me.mskUltMes.Location = New System.Drawing.Point(285, 4)
        Me.mskUltMes.Name = "mskUltMes"
        Me.mskUltMes.Size = New System.Drawing.Size(100, 22)
        Me.mskUltMes.TabIndex = 1
        '
        'grpUltimoPago
        '
        Me.grpUltimoPago.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grpUltimoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUltimoPago.Enabled = False
        Me.grpUltimoPago.ExpandedSize = New System.Drawing.Size(446, 150)
        Me.grpUltimoPago.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpUltimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimoPago.Location = New System.Drawing.Point(638, 467)
        Me.grpUltimoPago.Name = "grpUltimoPago"
        Me.grpUltimoPago.Size = New System.Drawing.Size(446, 150)
        Me.grpUltimoPago.TabIndex = 4
        Me.grpUltimoPago.TabStop = False
        Me.grpUltimoPago.Text = "Último Pago"
        Me.grpUltimoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.dtpFechaPago)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtNoRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblNumRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltAnio)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltAño)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltMes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.mskUltMes)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(2, 21)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(442, 127)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_pago", True))
        Me.dtpFechaPago.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.dtpFechaPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Location = New System.Drawing.Point(90, 31)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(110, 23)
        Me.dtpFechaPago.TabIndex = 93
        Me.dtpFechaPago.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(43, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(41, 16)
        Me.UltraLabel1.TabIndex = 95
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
        Me.txtNoRecibo.Location = New System.Drawing.Point(90, 4)
        Me.txtNoRecibo.MaxLength = 8
        Me.txtNoRecibo.Multiline = True
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRecibo.Size = New System.Drawing.Size(110, 23)
        Me.txtNoRecibo.TabIndex = 92
        '
        'lblNumRecibo
        '
        Me.lblNumRecibo.AutoSize = True
        Me.lblNumRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRecibo.Location = New System.Drawing.Point(16, 7)
        Me.lblNumRecibo.Name = "lblNumRecibo"
        Me.lblNumRecibo.Size = New System.Drawing.Size(68, 16)
        Me.lblNumRecibo.TabIndex = 94
        Me.lblNumRecibo.Text = "No. Recibo:"
        Me.lblNumRecibo.UseAppStyling = False
        '
        'uneUltAnio
        '
        Me.uneUltAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_año_pago", True))
        Me.uneUltAnio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneUltAnio.Location = New System.Drawing.Point(285, 31)
        Me.uneUltAnio.MaxValue = 2050
        Me.uneUltAnio.MinValue = 0
        Me.uneUltAnio.Name = "uneUltAnio"
        Me.uneUltAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnio.Size = New System.Drawing.Size(100, 23)
        Me.uneUltAnio.TabIndex = 2
        '
        'lblUltAño
        '
        Me.lblUltAño.AutoSize = True
        Me.lblUltAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltAño.Location = New System.Drawing.Point(223, 35)
        Me.lblUltAño.Name = "lblUltAño"
        Me.lblUltAño.Size = New System.Drawing.Size(53, 16)
        Me.lblUltAño.TabIndex = 77
        Me.lblUltAño.Text = "Últ. Año:"
        Me.lblUltAño.UseAppStyling = False
        '
        'lblUltMes
        '
        Me.lblUltMes.AutoSize = True
        Me.lblUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltMes.Location = New System.Drawing.Point(223, 8)
        Me.lblUltMes.Name = "lblUltMes"
        Me.lblUltMes.Size = New System.Drawing.Size(53, 16)
        Me.lblUltMes.TabIndex = 76
        Me.lblUltMes.Text = "Últ. Mes:"
        Me.lblUltMes.UseAppStyling = False
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
        'frmEstacionamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1084, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpUltimoPago)
        Me.Controls.Add(Me.grpPAE)
        Me.Controls.Add(Me.grpPropietario)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Name = "frmEstacionamiento"
        Me.Text = "Contribuyentes sujetos al pago del derecho sobre estacionamientos publicos"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
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
        CType(Me.txtLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLatitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneNumeroCajones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClavecatastral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUltimoPago.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DsLicencias1 As dsLicencias
    Friend WithEvents btnBack As ToolStripButton
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
    Private WithEvents lblDimension As Infragistics.Win.Misc.UltraLabel
    Private WithEvents txtFechaIniOp As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents lblIniciRecargo As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblCveCat As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblContribuyente As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblTipoLic As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoLic As MaskedTextBox
    Friend WithEvents cmbTipoLicencia As ComboBox
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents mskUltMes As ComboBox
    Private WithEvents lblStatus As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucoStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucoTipoContribuyente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents grpUltimoPago As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents lblUltAño As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltMes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtClavecatastral As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents uneUltAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneNumeroCajones As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents btnImage As ToolStripButton
    Friend WithEvents lblCorreo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtemail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCurp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblCurp As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRfc As Infragistics.Win.UltraWinEditors.UltraTextEditor
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
    Friend WithEvents dtpFechaPago As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoRecibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNumRecibo As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnMapa As ToolStripButton
End Class
