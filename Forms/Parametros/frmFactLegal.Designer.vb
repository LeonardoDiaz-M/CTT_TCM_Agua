<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactLegal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactLegal))
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ParametrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros = New TCMAdmin.dsParametros()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.grpParBasico = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneId = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneMes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneFactFedInp = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactFedProrroga = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactFedMora = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneFactActualiza = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactEstProrroga = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactEstMora = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.RecargosTableAdapter = New TCMAdmin.dsParametrosTableAdapters.recargosTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ParametrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpParBasico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParBasico.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.uneId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.uneFactFedInp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactFedProrroga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactFedMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uneFactActualiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactEstProrroga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactEstMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.ParametrBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(934, 37)
        Me.BindingNavigator1.TabIndex = 22
        Me.BindingNavigator1.Text = "BindingNavigator2"
        '
        'ParametrBindingSource
        '
        Me.ParametrBindingSource.DataMember = "recargos"
        Me.ParametrBindingSource.DataSource = Me.DsParametros
        '
        'DsParametros
        '
        Me.DsParametros.DataSetName = "dsParametros"
        Me.DsParametros.EnforceConstraints = False
        Me.DsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel2.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 34)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel1.Text = "           "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
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
        'grpParBasico
        '
        Me.grpParBasico.Controls.Add(Me.grParImpPred)
        Me.grpParBasico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpParBasico.Enabled = False
        Me.grpParBasico.ExpandedSize = New System.Drawing.Size(934, 279)
        Me.grpParBasico.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpParBasico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParBasico.Location = New System.Drawing.Point(0, 37)
        Me.grpParBasico.Name = "grpParBasico"
        Me.grpParBasico.Size = New System.Drawing.Size(934, 279)
        Me.grpParBasico.TabIndex = 29
        Me.grpParBasico.Text = "Factores"
        Me.grpParBasico.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.uneId)
        Me.grParImpPred.Controls.Add(Me.uneMes)
        Me.grParImpPred.Controls.Add(Me.uneAnio)
        Me.grParImpPred.Controls.Add(Me.UltraLabel7)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Controls.Add(Me.UltraGroupBox3)
        Me.grParImpPred.Controls.Add(Me.UltraGroupBox1)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 21)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(930, 256)
        Me.grParImpPred.TabIndex = 0
        '
        'uneId
        '
        Me.uneId.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneId.Location = New System.Drawing.Point(719, 10)
        Me.uneId.MaxValue = 3000
        Me.uneId.MinValue = 1.0R
        Me.uneId.Name = "uneId"
        Me.uneId.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneId.Size = New System.Drawing.Size(48, 25)
        Me.uneId.TabIndex = 64
        Me.uneId.Visible = False
        '
        'uneMes
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Me.uneMes.Appearance = Appearance7
        Me.uneMes.BackColor = System.Drawing.Color.White
        Me.uneMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "num_mes", True))
        Me.uneMes.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneMes.Location = New System.Drawing.Point(411, 41)
        Me.uneMes.MaxValue = 9999
        Me.uneMes.MinValue = 0
        Me.uneMes.Name = "uneMes"
        Me.uneMes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneMes.ReadOnly = True
        Me.uneMes.Size = New System.Drawing.Size(94, 25)
        Me.uneMes.TabIndex = 1
        Me.uneMes.UseAppStyling = False
        '
        'uneAnio
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Me.uneAnio.Appearance = Appearance8
        Me.uneAnio.BackColor = System.Drawing.Color.White
        Me.uneAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "ej_fiscal", True))
        Me.uneAnio.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneAnio.Location = New System.Drawing.Point(411, 13)
        Me.uneAnio.MaxValue = 3000
        Me.uneAnio.MinValue = 0
        Me.uneAnio.Name = "uneAnio"
        Me.uneAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneAnio.ReadOnly = True
        Me.uneAnio.Size = New System.Drawing.Size(94, 25)
        Me.uneAnio.TabIndex = 0
        Me.uneAnio.UseAppStyling = False
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(373, 44)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(32, 18)
        Me.UltraLabel7.TabIndex = 61
        Me.UltraLabel7.Text = "Mes"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(304, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(101, 18)
        Me.UltraLabel1.TabIndex = 60
        Me.UltraLabel1.Text = "Ejercicio fiscal"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.uneFactFedInp)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox3.Controls.Add(Me.uneFactFedProrroga)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Controls.Add(Me.uneFactFedMora)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(447, 93)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(320, 122)
        Me.UltraGroupBox3.TabIndex = 59
        Me.UltraGroupBox3.Text = "Factores Federales"
        '
        'uneFactFedInp
        '
        Me.uneFactFedInp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "inp", True))
        Me.uneFactFedInp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactFedInp.Location = New System.Drawing.Point(197, 85)
        Me.uneFactFedInp.MaskInput = "nnnn.nnnn"
        Me.uneFactFedInp.MinValue = 0
        Me.uneFactFedInp.Name = "uneFactFedInp"
        Me.uneFactFedInp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactFedInp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactFedInp.Size = New System.Drawing.Size(76, 25)
        Me.uneFactFedInp.TabIndex = 2
        Me.uneFactFedInp.UseAppStyling = False
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(161, 88)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(30, 18)
        Me.UltraLabel4.TabIndex = 56
        Me.UltraLabel4.Text = "INP"
        '
        'uneFactFedProrroga
        '
        Me.uneFactFedProrroga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "pror_fed", True))
        Me.uneFactFedProrroga.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactFedProrroga.Location = New System.Drawing.Point(197, 56)
        Me.uneFactFedProrroga.MinValue = 0
        Me.uneFactFedProrroga.Name = "uneFactFedProrroga"
        Me.uneFactFedProrroga.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactFedProrroga.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactFedProrroga.Size = New System.Drawing.Size(76, 25)
        Me.uneFactFedProrroga.TabIndex = 1
        Me.uneFactFedProrroga.UseAppStyling = False
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(127, 59)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 18)
        Me.UltraLabel5.TabIndex = 54
        Me.UltraLabel5.Text = "Prórroga"
        '
        'uneFactFedMora
        '
        Me.uneFactFedMora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "mora_fed", True))
        Me.uneFactFedMora.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactFedMora.Location = New System.Drawing.Point(197, 27)
        Me.uneFactFedMora.MinValue = 0
        Me.uneFactFedMora.Name = "uneFactFedMora"
        Me.uneFactFedMora.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactFedMora.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactFedMora.Size = New System.Drawing.Size(76, 25)
        Me.uneFactFedMora.TabIndex = 0
        Me.uneFactFedMora.UseAppStyling = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(152, 30)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(39, 18)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Mora"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uneFactActualiza)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.uneFactEstProrroga)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.uneFactEstMora)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(84, 93)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(320, 122)
        Me.UltraGroupBox1.TabIndex = 57
        Me.UltraGroupBox1.Text = "Factores Estatales"
        '
        'uneFactActualiza
        '
        Me.uneFactActualiza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "fact_edo", True))
        Me.uneFactActualiza.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactActualiza.Location = New System.Drawing.Point(197, 85)
        Me.uneFactActualiza.MaskInput = "nnnn.nnnn"
        Me.uneFactActualiza.MinValue = 0
        Me.uneFactActualiza.Name = "uneFactActualiza"
        Me.uneFactActualiza.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactActualiza.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactActualiza.Size = New System.Drawing.Size(76, 25)
        Me.uneFactActualiza.TabIndex = 2
        Me.uneFactActualiza.UseAppStyling = False
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(97, 88)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(94, 18)
        Me.UltraLabel3.TabIndex = 56
        Me.UltraLabel3.Text = "Actualización"
        '
        'uneFactEstProrroga
        '
        Me.uneFactEstProrroga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "pror_edo", True))
        Me.uneFactEstProrroga.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactEstProrroga.Location = New System.Drawing.Point(197, 56)
        Me.uneFactEstProrroga.MinValue = 0
        Me.uneFactEstProrroga.Name = "uneFactEstProrroga"
        Me.uneFactEstProrroga.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactEstProrroga.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactEstProrroga.Size = New System.Drawing.Size(76, 25)
        Me.uneFactEstProrroga.TabIndex = 1
        Me.uneFactEstProrroga.UseAppStyling = False
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(127, 59)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 18)
        Me.UltraLabel2.TabIndex = 54
        Me.UltraLabel2.Text = "Prórroga"
        '
        'uneFactEstMora
        '
        Me.uneFactEstMora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrBindingSource, "mora_edo", True))
        Me.uneFactEstMora.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactEstMora.Location = New System.Drawing.Point(197, 27)
        Me.uneFactEstMora.MinValue = 0
        Me.uneFactEstMora.Name = "uneFactEstMora"
        Me.uneFactEstMora.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactEstMora.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactEstMora.Size = New System.Drawing.Size(76, 25)
        Me.uneFactEstMora.TabIndex = 0
        Me.uneFactEstMora.UseAppStyling = False
        '
        'UltraLabel14
        '
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(152, 30)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(39, 18)
        Me.UltraLabel14.TabIndex = 11
        Me.UltraLabel14.Text = "Mora"
        '
        'RecargosTableAdapter
        '
        Me.RecargosTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmFactLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpParBasico)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmFactLegal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factores para cálculo de accesorios legales"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ParametrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpParBasico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParBasico.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.uneId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.uneFactFedInp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactFedProrroga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactFedMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uneFactActualiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactEstProrroga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactEstMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
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
    Friend WithEvents grpParBasico As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uneFactFedInp As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactFedProrroga As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactFedMora As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uneFactActualiza As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactEstProrroga As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactEstMora As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneId As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneMes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents ParametrBindingSource As BindingSource
    Friend WithEvents RecargosTableAdapter As dsParametrosTableAdapters.recargosTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
