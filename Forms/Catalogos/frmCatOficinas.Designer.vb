<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatOficinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatOficinas))
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OficinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New TCMAdmin.dsCatalogos()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.grpOficinas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.optTipoSalario = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtResponsableFormasValoradas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombreAreaContador = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtContador = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombreAreaResponsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtResponsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtDireccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtComun = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OficinasTableAdapter = New TCMAdmin.dsCatalogosTableAdapters.oficinasTableAdapter()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.OficinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOficinas.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.optTipoSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponsableFormasValoradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreAreaContador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreAreaResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNCurrent
        '
        Me.btnNCurrent.AccessibleName = "Posición"
        Me.btnNCurrent.AutoSize = False
        Me.btnNCurrent.Name = "btnNCurrent"
        Me.btnNCurrent.Size = New System.Drawing.Size(50, 23)
        Me.btnNCurrent.Text = "0"
        Me.btnNCurrent.ToolTipText = "Posición actual"
        '
        'btnNTotal
        '
        Me.btnNTotal.Name = "btnNTotal"
        Me.btnNTotal.Size = New System.Drawing.Size(35, 34)
        Me.btnNTotal.Text = "of {0}"
        Me.btnNTotal.ToolTipText = "Número total de elementos"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.OficinasBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu, Me.ToolStripLabel1, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1140, 37)
        Me.BindingNavigator1.TabIndex = 29
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'OficinasBindingSource
        '
        Me.OficinasBindingSource.DataMember = "oficinas"
        Me.OficinasBindingSource.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'grpOficinas
        '
        Me.grpOficinas.Controls.Add(Me.grParImpPred)
        Me.grpOficinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOficinas.Enabled = False
        Me.grpOficinas.ExpandedSize = New System.Drawing.Size(1140, 337)
        Me.grpOficinas.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpOficinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOficinas.Location = New System.Drawing.Point(0, 37)
        Me.grpOficinas.Name = "grpOficinas"
        Me.grpOficinas.Size = New System.Drawing.Size(1140, 337)
        Me.grpOficinas.TabIndex = 31
        Me.grpOficinas.Text = "Oficinas Detalle"
        Me.grpOficinas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.optTipoSalario)
        Me.grParImpPred.Controls.Add(Me.UltraLabel12)
        Me.grParImpPred.Controls.Add(Me.UltraLabel11)
        Me.grParImpPred.Controls.Add(Me.txtResponsableFormasValoradas)
        Me.grParImpPred.Controls.Add(Me.UltraLabel9)
        Me.grParImpPred.Controls.Add(Me.txtNombreAreaContador)
        Me.grParImpPred.Controls.Add(Me.txtContador)
        Me.grParImpPred.Controls.Add(Me.UltraLabel10)
        Me.grParImpPred.Controls.Add(Me.UltraLabel8)
        Me.grParImpPred.Controls.Add(Me.txtNombreAreaResponsable)
        Me.grParImpPred.Controls.Add(Me.txtResponsable)
        Me.grParImpPred.Controls.Add(Me.txtDireccion)
        Me.grParImpPred.Controls.Add(Me.txtComun)
        Me.grParImpPred.Controls.Add(Me.UltraLabel2)
        Me.grParImpPred.Controls.Add(Me.UltraLabel3)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Controls.Add(Me.lblCuenta)
        Me.grParImpPred.Controls.Add(Me.txtNombre)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 21)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(1136, 314)
        Me.grParImpPred.TabIndex = 0
        '
        'optTipoSalario
        '
        Me.optTipoSalario.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OficinasBindingSource, "tip_sal", True))
        Me.optTipoSalario.ItemOrigin = New System.Drawing.Point(10, 5)
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Zona A"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Zona C"
        Me.optTipoSalario.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optTipoSalario.Location = New System.Drawing.Point(271, 256)
        Me.optTipoSalario.Name = "optTipoSalario"
        Me.optTipoSalario.Size = New System.Drawing.Size(300, 32)
        Me.optTipoSalario.TabIndex = 156
        '
        'UltraLabel12
        '
        Appearance45.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance45
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(90, 264)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel12.TabIndex = 155
        Me.UltraLabel12.Text = "Tipo Salario:"
        Me.UltraLabel12.UseAppStyling = False
        '
        'UltraLabel11
        '
        Appearance46.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance46
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(90, 232)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel11.TabIndex = 154
        Me.UltraLabel11.Text = "Responsable Formas Valoradas:"
        Me.UltraLabel11.UseAppStyling = False
        '
        'txtResponsableFormasValoradas
        '
        Me.txtResponsableFormasValoradas.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtResponsableFormasValoradas.Appearance = Appearance3
        Me.txtResponsableFormasValoradas.BackColor = System.Drawing.Color.White
        Me.txtResponsableFormasValoradas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsableFormasValoradas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "rsp_formas_val", True))
        Me.txtResponsableFormasValoradas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtResponsableFormasValoradas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsableFormasValoradas.Location = New System.Drawing.Point(282, 229)
        Me.txtResponsableFormasValoradas.MaxLength = 60
        Me.txtResponsableFormasValoradas.Multiline = True
        Me.txtResponsableFormasValoradas.Name = "txtResponsableFormasValoradas"
        Me.txtResponsableFormasValoradas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsableFormasValoradas.Size = New System.Drawing.Size(368, 23)
        Me.txtResponsableFormasValoradas.TabIndex = 7
        '
        'UltraLabel9
        '
        Appearance47.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance47
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(90, 204)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel9.TabIndex = 152
        Me.UltraLabel9.Text = "Nombre Area Contador:"
        Me.UltraLabel9.UseAppStyling = False
        '
        'txtNombreAreaContador
        '
        Me.txtNombreAreaContador.AlwaysInEditMode = True
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.txtNombreAreaContador.Appearance = Appearance5
        Me.txtNombreAreaContador.BackColor = System.Drawing.Color.White
        Me.txtNombreAreaContador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreAreaContador.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "nom_area_cnt", True))
        Me.txtNombreAreaContador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombreAreaContador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAreaContador.Location = New System.Drawing.Point(282, 201)
        Me.txtNombreAreaContador.MaxLength = 45
        Me.txtNombreAreaContador.Multiline = True
        Me.txtNombreAreaContador.Name = "txtNombreAreaContador"
        Me.txtNombreAreaContador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreAreaContador.Size = New System.Drawing.Size(368, 23)
        Me.txtNombreAreaContador.TabIndex = 6
        '
        'txtContador
        '
        Me.txtContador.AlwaysInEditMode = True
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.txtContador.Appearance = Appearance6
        Me.txtContador.BackColor = System.Drawing.Color.White
        Me.txtContador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContador.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "contador", True))
        Me.txtContador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtContador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.Location = New System.Drawing.Point(282, 173)
        Me.txtContador.MaxLength = 60
        Me.txtContador.Multiline = True
        Me.txtContador.Name = "txtContador"
        Me.txtContador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContador.Size = New System.Drawing.Size(368, 23)
        Me.txtContador.TabIndex = 5
        '
        'UltraLabel10
        '
        Appearance48.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance48
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(90, 176)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel10.TabIndex = 149
        Me.UltraLabel10.Text = "Contador:"
        Me.UltraLabel10.UseAppStyling = False
        '
        'UltraLabel8
        '
        Appearance49.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance49
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(90, 148)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel8.TabIndex = 148
        Me.UltraLabel8.Text = "Nombre Area Responsable:"
        Me.UltraLabel8.UseAppStyling = False
        '
        'txtNombreAreaResponsable
        '
        Me.txtNombreAreaResponsable.AlwaysInEditMode = True
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtNombreAreaResponsable.Appearance = Appearance9
        Me.txtNombreAreaResponsable.BackColor = System.Drawing.Color.White
        Me.txtNombreAreaResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreAreaResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "responsable", True))
        Me.txtNombreAreaResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombreAreaResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAreaResponsable.Location = New System.Drawing.Point(282, 145)
        Me.txtNombreAreaResponsable.MaxLength = 45
        Me.txtNombreAreaResponsable.Multiline = True
        Me.txtNombreAreaResponsable.Name = "txtNombreAreaResponsable"
        Me.txtNombreAreaResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombreAreaResponsable.Size = New System.Drawing.Size(368, 23)
        Me.txtNombreAreaResponsable.TabIndex = 4
        '
        'txtResponsable
        '
        Me.txtResponsable.AlwaysInEditMode = True
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.txtResponsable.Appearance = Appearance10
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "responsable", True))
        Me.txtResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(282, 117)
        Me.txtResponsable.MaxLength = 60
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(368, 23)
        Me.txtResponsable.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.AlwaysInEditMode = True
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.txtDireccion.Appearance = Appearance11
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "direccion", True))
        Me.txtDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(282, 89)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDireccion.Size = New System.Drawing.Size(368, 23)
        Me.txtDireccion.TabIndex = 2
        '
        'txtComun
        '
        Me.txtComun.AlwaysInEditMode = True
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.txtComun.Appearance = Appearance12
        Me.txtComun.BackColor = System.Drawing.Color.White
        Me.txtComun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComun.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "comun", True))
        Me.txtComun.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtComun.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComun.Location = New System.Drawing.Point(282, 32)
        Me.txtComun.MaxLength = 4
        Me.txtComun.Multiline = True
        Me.txtComun.Name = "txtComun"
        Me.txtComun.Size = New System.Drawing.Size(108, 23)
        Me.txtComun.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance50.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance50
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(90, 120)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel2.TabIndex = 139
        Me.UltraLabel2.Text = "Responsable:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'UltraLabel3
        '
        Appearance51.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance51
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(90, 92)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel3.TabIndex = 138
        Me.UltraLabel3.Text = "Dirección:"
        Me.UltraLabel3.UseAppStyling = False
        '
        'UltraLabel1
        '
        Appearance52.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance52
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(90, 64)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel1.TabIndex = 137
        Me.UltraLabel1.Text = "Nombre:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'lblCuenta
        '
        Appearance53.TextHAlignAsString = "Right"
        Me.lblCuenta.Appearance = Appearance53
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(206, 34)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(63, 16)
        Me.lblCuenta.TabIndex = 136
        Me.lblCuenta.Text = "Id. oficina:"
        Me.lblCuenta.UseAppStyling = False
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance17
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficinasBindingSource, "nombre", True))
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(282, 61)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(368, 23)
        Me.txtNombre.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OficinasTableAdapter
        '
        Me.OficinasTableAdapter.ClearBeforeFill = True
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
        'frmCatOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1140, 374)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpOficinas)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Name = "frmCatOficinas"
        Me.Text = "Catálogo: Oficinas"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.OficinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOficinas.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.optTipoSalario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponsableFormasValoradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreAreaContador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreAreaResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents grpOficinas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtResponsableFormasValoradas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombreAreaContador As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtContador As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombreAreaResponsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtResponsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDireccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtComun As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents OficinasBindingSource As BindingSource
    Friend WithEvents OficinasTableAdapter As dsCatalogosTableAdapters.oficinasTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents optTipoSalario As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
