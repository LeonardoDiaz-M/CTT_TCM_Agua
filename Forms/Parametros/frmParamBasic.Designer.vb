<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParamBasic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParamBasic))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ParametrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros = New TCMAdmin.dsParametros()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.panParametros = New Infragistics.Win.Misc.UltraPanel()
        Me.uneAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.grpGral = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.gpogpos = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneGrupoMunSalarios = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneConsumoMinimoAgua = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactorDrenaje = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneGruDesUrbano = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneGruCobroAgua = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneGruLicVtaAlcohol = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.grpLicMun = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneDiaIniRecarg = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneMesIniRecarg = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.grpimppred = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneFactorPredial = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneMaxIncremAnual = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.grpParBasico = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneRecContMor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneRecContEsp = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneFactorMultas = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSalarioMinimoA = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneSalarioMinimoC = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPae = New Infragistics.Win.Misc.UltraLabel()
        Me.lblEjFiscal = New System.Windows.Forms.Label()
        Me.ParametrTableAdapter = New TCMAdmin.dsParametrosTableAdapters.parametrTableAdapter()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ParametrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panParametros.ClientArea.SuspendLayout()
        Me.panParametros.SuspendLayout()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpGral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGral.SuspendLayout()
        Me.gpogpos.SuspendLayout()
        CType(Me.uneGrupoMunSalarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneConsumoMinimoAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactorDrenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneGruDesUrbano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneGruCobroAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneGruLicVtaAlcohol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLicMun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLicMun.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.uneDiaIniRecarg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneMesIniRecarg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpimppred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpimppred.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.uneFactorPredial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneMaxIncremAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpParBasico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParBasico.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.uneRecContMor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneRecContEsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactorMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSalarioMinimoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneSalarioMinimoC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnNCurrent
        '
        Me.btnNCurrent.AccessibleName = "Posición"
        Me.btnNCurrent.AutoSize = False
        Me.btnNCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNCurrent.Name = "btnNCurrent"
        Me.btnNCurrent.Size = New System.Drawing.Size(65, 27)
        Me.btnNCurrent.Text = "0"
        Me.btnNCurrent.ToolTipText = "Posición actual"
        '
        'btnNTotal
        '
        Me.btnNTotal.Name = "btnNTotal"
        Me.btnNTotal.Size = New System.Drawing.Size(48, 34)
        Me.btnNTotal.Text = "de {0}"
        Me.btnNTotal.ToolTipText = "Número total de elementos"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.ParametrBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.lblCurrentMenu, Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1245, 37)
        Me.BindingNavigator1.TabIndex = 21
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ParametrBindingSource
        '
        Me.ParametrBindingSource.DataMember = "parametr"
        Me.ParametrBindingSource.DataSource = Me.DsParametros
        '
        'DsParametros
        '
        Me.DsParametros.DataSetName = "dsParametros"
        Me.DsParametros.EnforceConstraints = False
        Me.DsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(34, 34)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.ToolTipText = "Eliminar registro"
        Me.btnElimina.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 34)
        Me.ToolStripLabel2.Text = "           "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(141, 34)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 34)
        Me.ToolStripLabel1.Text = "           "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        'panParametros
        '
        '
        'panParametros.ClientArea
        '
        Me.panParametros.ClientArea.Controls.Add(Me.uneAnio)
        Me.panParametros.ClientArea.Controls.Add(Me.grpGral)
        Me.panParametros.ClientArea.Controls.Add(Me.grpLicMun)
        Me.panParametros.ClientArea.Controls.Add(Me.grpimppred)
        Me.panParametros.ClientArea.Controls.Add(Me.grpParBasico)
        Me.panParametros.ClientArea.Controls.Add(Me.lblEjFiscal)
        Me.panParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panParametros.Enabled = False
        Me.panParametros.Location = New System.Drawing.Point(0, 37)
        Me.panParametros.Margin = New System.Windows.Forms.Padding(4)
        Me.panParametros.Name = "panParametros"
        Me.panParametros.Size = New System.Drawing.Size(1245, 653)
        Me.panParametros.TabIndex = 22
        '
        'uneAnio
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.uneAnio.Appearance = Appearance1
        Me.uneAnio.BackColor = System.Drawing.Color.White
        Me.uneAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "ejerfis", True))
        Me.uneAnio.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneAnio.Location = New System.Drawing.Point(712, 7)
        Me.uneAnio.Margin = New System.Windows.Forms.Padding(4)
        Me.uneAnio.MaxValue = 999999
        Me.uneAnio.MinValue = 1
        Me.uneAnio.Name = "uneAnio"
        Me.uneAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneAnio.ReadOnly = True
        Me.uneAnio.Size = New System.Drawing.Size(125, 36)
        Me.uneAnio.TabIndex = 32
        Me.uneAnio.UseAppStyling = False
        '
        'grpGral
        '
        Me.grpGral.Controls.Add(Me.gpogpos)
        Me.grpGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpGral.ExpandedSize = New System.Drawing.Size(1245, 161)
        Me.grpGral.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGral.Location = New System.Drawing.Point(0, 492)
        Me.grpGral.Margin = New System.Windows.Forms.Padding(4)
        Me.grpGral.Name = "grpGral"
        Me.grpGral.Size = New System.Drawing.Size(1245, 161)
        Me.grpGral.TabIndex = 31
        Me.grpGral.Text = "Parámetros de Generales del Municipio"
        Me.grpGral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'gpogpos
        '
        Me.gpogpos.Controls.Add(Me.uneGrupoMunSalarios)
        Me.gpogpos.Controls.Add(Me.UltraLabel10)
        Me.gpogpos.Controls.Add(Me.uneConsumoMinimoAgua)
        Me.gpogpos.Controls.Add(Me.UltraLabel9)
        Me.gpogpos.Controls.Add(Me.uneFactorDrenaje)
        Me.gpogpos.Controls.Add(Me.uneGruDesUrbano)
        Me.gpogpos.Controls.Add(Me.uneGruCobroAgua)
        Me.gpogpos.Controls.Add(Me.uneGruLicVtaAlcohol)
        Me.gpogpos.Controls.Add(Me.UltraLabel8)
        Me.gpogpos.Controls.Add(Me.UltraLabel7)
        Me.gpogpos.Controls.Add(Me.UltraLabel6)
        Me.gpogpos.Controls.Add(Me.UltraLabel5)
        Me.gpogpos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpogpos.Location = New System.Drawing.Point(2, 25)
        Me.gpogpos.Margin = New System.Windows.Forms.Padding(4)
        Me.gpogpos.Name = "gpogpos"
        Me.gpogpos.Size = New System.Drawing.Size(1241, 134)
        Me.gpogpos.TabIndex = 0
        '
        'uneGrupoMunSalarios
        '
        Me.uneGrupoMunSalarios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "gpo_mun_des_urb", True))
        Me.uneGrupoMunSalarios.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneGrupoMunSalarios.Location = New System.Drawing.Point(445, 85)
        Me.uneGrupoMunSalarios.Margin = New System.Windows.Forms.Padding(4)
        Me.uneGrupoMunSalarios.MaxValue = 31.0R
        Me.uneGrupoMunSalarios.MinValue = 1.0R
        Me.uneGrupoMunSalarios.Name = "uneGrupoMunSalarios"
        Me.uneGrupoMunSalarios.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneGrupoMunSalarios.Size = New System.Drawing.Size(101, 29)
        Me.uneGrupoMunSalarios.TabIndex = 20
        Me.uneGrupoMunSalarios.UseAppStyling = False
        '
        'UltraLabel10
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance2
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(23, 89)
        Me.UltraLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel10.TabIndex = 21
        Me.UltraLabel10.Text = "Grupo Municipios Salarios:"
        '
        'uneConsumoMinimoAgua
        '
        Me.uneConsumoMinimoAgua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "gpo_mun_agua", True))
        Me.uneConsumoMinimoAgua.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneConsumoMinimoAgua.Location = New System.Drawing.Point(1032, 85)
        Me.uneConsumoMinimoAgua.Margin = New System.Windows.Forms.Padding(4)
        Me.uneConsumoMinimoAgua.MaxValue = 99999
        Me.uneConsumoMinimoAgua.MinValue = 0
        Me.uneConsumoMinimoAgua.Name = "uneConsumoMinimoAgua"
        Me.uneConsumoMinimoAgua.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneConsumoMinimoAgua.Size = New System.Drawing.Size(101, 29)
        Me.uneConsumoMinimoAgua.TabIndex = 18
        Me.uneConsumoMinimoAgua.UseAppStyling = False
        '
        'UltraLabel9
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance3
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(607, 89)
        Me.UltraLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel9.TabIndex = 19
        Me.UltraLabel9.Text = "Consumo mínimo de agua:"
        '
        'uneFactorDrenaje
        '
        Me.uneFactorDrenaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "fact_drenaje", True))
        Me.uneFactorDrenaje.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactorDrenaje.Location = New System.Drawing.Point(1032, 49)
        Me.uneFactorDrenaje.Margin = New System.Windows.Forms.Padding(4)
        Me.uneFactorDrenaje.MinValue = 0
        Me.uneFactorDrenaje.Name = "uneFactorDrenaje"
        Me.uneFactorDrenaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactorDrenaje.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactorDrenaje.Size = New System.Drawing.Size(101, 29)
        Me.uneFactorDrenaje.TabIndex = 3
        Me.uneFactorDrenaje.UseAppStyling = False
        '
        'uneGruDesUrbano
        '
        Me.uneGruDesUrbano.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "gpo_mun_des_urb", True))
        Me.uneGruDesUrbano.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneGruDesUrbano.Location = New System.Drawing.Point(445, 49)
        Me.uneGruDesUrbano.Margin = New System.Windows.Forms.Padding(4)
        Me.uneGruDesUrbano.MaxValue = 31.0R
        Me.uneGruDesUrbano.MinValue = 1.0R
        Me.uneGruDesUrbano.Name = "uneGruDesUrbano"
        Me.uneGruDesUrbano.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneGruDesUrbano.Size = New System.Drawing.Size(101, 29)
        Me.uneGruDesUrbano.TabIndex = 1
        Me.uneGruDesUrbano.UseAppStyling = False
        '
        'uneGruCobroAgua
        '
        Me.uneGruCobroAgua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "gpo_mun_agua", True))
        Me.uneGruCobroAgua.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneGruCobroAgua.Location = New System.Drawing.Point(445, 12)
        Me.uneGruCobroAgua.Margin = New System.Windows.Forms.Padding(4)
        Me.uneGruCobroAgua.MaxValue = 31.0R
        Me.uneGruCobroAgua.MinValue = 1.0R
        Me.uneGruCobroAgua.Name = "uneGruCobroAgua"
        Me.uneGruCobroAgua.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneGruCobroAgua.Size = New System.Drawing.Size(101, 29)
        Me.uneGruCobroAgua.TabIndex = 0
        Me.uneGruCobroAgua.UseAppStyling = False
        '
        'uneGruLicVtaAlcohol
        '
        Me.uneGruLicVtaAlcohol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "gpo_mun_lic_alc", True))
        Me.uneGruLicVtaAlcohol.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneGruLicVtaAlcohol.Location = New System.Drawing.Point(1032, 12)
        Me.uneGruLicVtaAlcohol.Margin = New System.Windows.Forms.Padding(4)
        Me.uneGruLicVtaAlcohol.MaxValue = 31.0R
        Me.uneGruLicVtaAlcohol.MinValue = 1.0R
        Me.uneGruLicVtaAlcohol.Name = "uneGruLicVtaAlcohol"
        Me.uneGruLicVtaAlcohol.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneGruLicVtaAlcohol.Size = New System.Drawing.Size(101, 29)
        Me.uneGruLicVtaAlcohol.TabIndex = 2
        Me.uneGruLicVtaAlcohol.UseAppStyling = False
        '
        'UltraLabel8
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance4
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(607, 54)
        Me.UltraLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel8.TabIndex = 17
        Me.UltraLabel8.Text = "Factor para drenaje:"
        '
        'UltraLabel7
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance5
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(607, 16)
        Me.UltraLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel7.TabIndex = 16
        Me.UltraLabel7.Text = "Grupo para licencias para venta de alcoholes:"
        '
        'UltraLabel6
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance6
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(23, 52)
        Me.UltraLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Grupo para desarrollo urbano:"
        '
        'UltraLabel5
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance7
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(23, 16)
        Me.UltraLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel5.TabIndex = 14
        Me.UltraLabel5.Text = "Grupo para cobro de agua:"
        '
        'grpLicMun
        '
        Me.grpLicMun.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpLicMun.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpLicMun.ExpandedSize = New System.Drawing.Size(1245, 100)
        Me.grpLicMun.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpLicMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLicMun.Location = New System.Drawing.Point(0, 392)
        Me.grpLicMun.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLicMun.Name = "grpLicMun"
        Me.grpLicMun.Size = New System.Drawing.Size(1245, 100)
        Me.grpLicMun.TabIndex = 30
        Me.grpLicMun.Text = "Parámetros de Licencias Municipales"
        Me.grpLicMun.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneDiaIniRecarg)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.uneMesIniRecarg)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1241, 73)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'uneDiaIniRecarg
        '
        Me.uneDiaIniRecarg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "dia_venc_lic", True))
        Me.uneDiaIniRecarg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDiaIniRecarg.Location = New System.Drawing.Point(1032, 18)
        Me.uneDiaIniRecarg.Margin = New System.Windows.Forms.Padding(4)
        Me.uneDiaIniRecarg.MaxValue = 31
        Me.uneDiaIniRecarg.MinValue = 1
        Me.uneDiaIniRecarg.Name = "uneDiaIniRecarg"
        Me.uneDiaIniRecarg.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneDiaIniRecarg.Size = New System.Drawing.Size(101, 29)
        Me.uneDiaIniRecarg.TabIndex = 1
        Me.uneDiaIniRecarg.UseAppStyling = False
        '
        'uneMesIniRecarg
        '
        Me.uneMesIniRecarg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "mes_venc_lic", True))
        Me.uneMesIniRecarg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneMesIniRecarg.Location = New System.Drawing.Point(445, 18)
        Me.uneMesIniRecarg.Margin = New System.Windows.Forms.Padding(4)
        Me.uneMesIniRecarg.MaxValue = 12
        Me.uneMesIniRecarg.MinValue = 1
        Me.uneMesIniRecarg.Name = "uneMesIniRecarg"
        Me.uneMesIniRecarg.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneMesIniRecarg.Size = New System.Drawing.Size(101, 29)
        Me.uneMesIniRecarg.TabIndex = 0
        Me.uneMesIniRecarg.UseAppStyling = False
        '
        'UltraLabel4
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(607, 23)
        Me.UltraLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel4.TabIndex = 14
        Me.UltraLabel4.Text = "Día de inicio de recargos:"
        '
        'UltraLabel3
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance9
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(23, 23)
        Me.UltraLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel3.TabIndex = 13
        Me.UltraLabel3.Text = "Mes de inicio de recargos:"
        '
        'grpimppred
        '
        Me.grpimppred.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpimppred.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpimppred.ExpandedSize = New System.Drawing.Size(1245, 126)
        Me.grpimppred.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpimppred.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpimppred.Location = New System.Drawing.Point(0, 266)
        Me.grpimppred.Margin = New System.Windows.Forms.Padding(4)
        Me.grpimppred.Name = "grpimppred"
        Me.grpimppred.Size = New System.Drawing.Size(1245, 126)
        Me.grpimppred.TabIndex = 29
        Me.grpimppred.Text = "Parámetros Generales del Impuesto Predial"
        Me.grpimppred.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneFactorPredial)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneMaxIncremAnual)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1241, 99)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'uneFactorPredial
        '
        Me.uneFactorPredial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "fact_predial", True))
        Me.uneFactorPredial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactorPredial.Location = New System.Drawing.Point(445, 25)
        Me.uneFactorPredial.Margin = New System.Windows.Forms.Padding(4)
        Me.uneFactorPredial.MinValue = 0
        Me.uneFactorPredial.Name = "uneFactorPredial"
        Me.uneFactorPredial.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactorPredial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactorPredial.Size = New System.Drawing.Size(101, 29)
        Me.uneFactorPredial.TabIndex = 0
        Me.uneFactorPredial.UseAppStyling = False
        '
        'uneMaxIncremAnual
        '
        Me.uneMaxIncremAnual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "max_inc_anual", True))
        Me.uneMaxIncremAnual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneMaxIncremAnual.Location = New System.Drawing.Point(1032, 25)
        Me.uneMaxIncremAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.uneMaxIncremAnual.MinValue = 0
        Me.uneMaxIncremAnual.Name = "uneMaxIncremAnual"
        Me.uneMaxIncremAnual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneMaxIncremAnual.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneMaxIncremAnual.Size = New System.Drawing.Size(101, 29)
        Me.uneMaxIncremAnual.TabIndex = 1
        Me.uneMaxIncremAnual.UseAppStyling = False
        '
        'UltraLabel2
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(607, 32)
        Me.UltraLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel2.TabIndex = 13
        Me.UltraLabel2.Text = "Máximo incremento anual:"
        '
        'UltraLabel1
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(23, 31)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Factor de cobro en predios rústicos:"
        '
        'grpParBasico
        '
        Me.grpParBasico.Controls.Add(Me.grParImpPred)
        Me.grpParBasico.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpParBasico.ExpandedSize = New System.Drawing.Size(1245, 213)
        Me.grpParBasico.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpParBasico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParBasico.Location = New System.Drawing.Point(0, 53)
        Me.grpParBasico.Margin = New System.Windows.Forms.Padding(4)
        Me.grpParBasico.Name = "grpParBasico"
        Me.grpParBasico.Size = New System.Drawing.Size(1245, 213)
        Me.grpParBasico.TabIndex = 28
        Me.grpParBasico.Text = "Parámetros Básicos"
        Me.grpParBasico.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.uneRecContMor)
        Me.grParImpPred.Controls.Add(Me.uneRecContEsp)
        Me.grParImpPred.Controls.Add(Me.uneFactorMultas)
        Me.grParImpPred.Controls.Add(Me.uneSalarioMinimoA)
        Me.grParImpPred.Controls.Add(Me.uneSalarioMinimoC)
        Me.grParImpPred.Controls.Add(Me.UltraLabel16)
        Me.grParImpPred.Controls.Add(Me.UltraLabel15)
        Me.grParImpPred.Controls.Add(Me.UltraLabel14)
        Me.grParImpPred.Controls.Add(Me.UltraLabel13)
        Me.grParImpPred.Controls.Add(Me.lblPae)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 25)
        Me.grParImpPred.Margin = New System.Windows.Forms.Padding(4)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(1241, 186)
        Me.grParImpPred.TabIndex = 0
        '
        'uneRecContMor
        '
        Me.uneRecContMor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "rec_max_req", True))
        Me.uneRecContMor.Location = New System.Drawing.Point(1032, 111)
        Me.uneRecContMor.Margin = New System.Windows.Forms.Padding(4)
        Me.uneRecContMor.MinValue = 0
        Me.uneRecContMor.Name = "uneRecContMor"
        Me.uneRecContMor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneRecContMor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneRecContMor.Size = New System.Drawing.Size(101, 28)
        Me.uneRecContMor.TabIndex = 4
        Me.uneRecContMor.UseAppStyling = False
        '
        'uneRecContEsp
        '
        Me.uneRecContEsp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "rec_max_esp", True))
        Me.uneRecContEsp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneRecContEsp.Location = New System.Drawing.Point(1032, 78)
        Me.uneRecContEsp.Margin = New System.Windows.Forms.Padding(4)
        Me.uneRecContEsp.MinValue = 0
        Me.uneRecContEsp.Name = "uneRecContEsp"
        Me.uneRecContEsp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneRecContEsp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneRecContEsp.Size = New System.Drawing.Size(101, 29)
        Me.uneRecContEsp.TabIndex = 3
        Me.uneRecContEsp.UseAppStyling = False
        '
        'uneFactorMultas
        '
        Appearance12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneFactorMultas.Appearance = Appearance12
        Me.uneFactorMultas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "factor_multas", True))
        Me.uneFactorMultas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactorMultas.Location = New System.Drawing.Point(1032, 44)
        Me.uneFactorMultas.Margin = New System.Windows.Forms.Padding(4)
        Me.uneFactorMultas.MinValue = 0
        Me.uneFactorMultas.Name = "uneFactorMultas"
        Me.uneFactorMultas.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactorMultas.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactorMultas.Size = New System.Drawing.Size(101, 29)
        Me.uneFactorMultas.TabIndex = 2
        Me.uneFactorMultas.UseAppStyling = False
        '
        'uneSalarioMinimoA
        '
        Me.uneSalarioMinimoA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "sal_zona_a", True))
        Me.uneSalarioMinimoA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSalarioMinimoA.Location = New System.Drawing.Point(445, 86)
        Me.uneSalarioMinimoA.Margin = New System.Windows.Forms.Padding(4)
        Me.uneSalarioMinimoA.MinValue = 0
        Me.uneSalarioMinimoA.Name = "uneSalarioMinimoA"
        Me.uneSalarioMinimoA.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.uneSalarioMinimoA.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSalarioMinimoA.Size = New System.Drawing.Size(133, 29)
        Me.uneSalarioMinimoA.TabIndex = 1
        Me.uneSalarioMinimoA.UseAppStyling = False
        Me.uneSalarioMinimoA.Visible = False
        '
        'uneSalarioMinimoC
        '
        Me.uneSalarioMinimoC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "sal_zona_c", True))
        Me.uneSalarioMinimoC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneSalarioMinimoC.Location = New System.Drawing.Point(445, 48)
        Me.uneSalarioMinimoC.Margin = New System.Windows.Forms.Padding(4)
        Me.uneSalarioMinimoC.MinValue = 0
        Me.uneSalarioMinimoC.Name = "uneSalarioMinimoC"
        Me.uneSalarioMinimoC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.uneSalarioMinimoC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneSalarioMinimoC.Size = New System.Drawing.Size(133, 29)
        Me.uneSalarioMinimoC.TabIndex = 0
        Me.uneSalarioMinimoC.UseAppStyling = False
        '
        'UltraLabel16
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel16.Appearance = Appearance13
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(607, 111)
        Me.UltraLabel16.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel16.TabIndex = 13
        Me.UltraLabel16.Text = "Recargos para contribuyentes morosos:"
        '
        'UltraLabel15
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel15.Appearance = Appearance14
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(607, 80)
        Me.UltraLabel15.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel15.TabIndex = 12
        Me.UltraLabel15.Text = "Recargos para contribuyetes espontáneos:"
        '
        'UltraLabel14
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance15
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(607, 49)
        Me.UltraLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel14.TabIndex = 11
        Me.UltraLabel14.Text = "Multas para contribuyentes requeridos:"
        '
        'UltraLabel13
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance16
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(23, 90)
        Me.UltraLabel13.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(413, 22)
        Me.UltraLabel13.TabIndex = 10
        Me.UltraLabel13.Text = "Salario mínimo zona ""A"""
        Me.UltraLabel13.Visible = False
        '
        'lblPae
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.lblPae.Appearance = Appearance17
        Me.lblPae.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(23, 52)
        Me.lblPae.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(413, 22)
        Me.lblPae.TabIndex = 9
        Me.lblPae.Text = "Unidad de Medida y Actualización"
        '
        'lblEjFiscal
        '
        Me.lblEjFiscal.BackColor = System.Drawing.Color.White
        Me.lblEjFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEjFiscal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEjFiscal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjFiscal.Location = New System.Drawing.Point(0, 0)
        Me.lblEjFiscal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEjFiscal.Name = "lblEjFiscal"
        Me.lblEjFiscal.Size = New System.Drawing.Size(1245, 53)
        Me.lblEjFiscal.TabIndex = 27
        Me.lblEjFiscal.Text = "Ejercicio Fiscal:     "
        Me.lblEjFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ParametrTableAdapter
        '
        Me.ParametrTableAdapter.ClearBeforeFill = True
        '
        'frmParamBasic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.panParametros)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmParamBasic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros Básicos y Factores para Cálculos  de Accesorios Legales"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ParametrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panParametros.ClientArea.ResumeLayout(False)
        Me.panParametros.ClientArea.PerformLayout()
        Me.panParametros.ResumeLayout(False)
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpGral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGral.ResumeLayout(False)
        Me.gpogpos.ResumeLayout(False)
        Me.gpogpos.PerformLayout()
        CType(Me.uneGrupoMunSalarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneConsumoMinimoAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactorDrenaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneGruDesUrbano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneGruCobroAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneGruLicVtaAlcohol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLicMun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLicMun.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.uneDiaIniRecarg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneMesIniRecarg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpimppred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpimppred.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.uneFactorPredial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneMaxIncremAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpParBasico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParBasico.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.uneRecContMor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneRecContEsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactorMultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSalarioMinimoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneSalarioMinimoC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ParametrTableAdapter As dsParametrosTableAdapters.parametrTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents panParametros As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents grpGral As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents gpogpos As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpLicMun As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpimppred As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpParBasico As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblEjFiscal As Label
    Friend WithEvents uneSalarioMinimoA As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ParametrBindingSource As BindingSource
    Friend WithEvents uneSalarioMinimoC As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneRecContMor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneRecContEsp As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneFactorMultas As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneDiaIniRecarg As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneMesIniRecarg As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneMaxIncremAnual As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneFactorDrenaje As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneGruDesUrbano As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneGruCobroAgua As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneGruLicVtaAlcohol As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneFactorPredial As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneConsumoMinimoAgua As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneGrupoMunSalarios As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
