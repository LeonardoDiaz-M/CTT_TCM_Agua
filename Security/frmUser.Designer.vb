<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueId", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueDescripcion", 1)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comun")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnActiva = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpDatos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtBaja = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ucoPuesto = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoOficina = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.lblUser = New Infragistics.Win.Misc.UltraLabel()
        Me.grpSistema = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkAddress = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtNumeroCaja = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUltimoAcceso = New System.Windows.Forms.TextBox()
        Me.lblRol = New Infragistics.Win.Misc.UltraLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.grpWEB = New System.Windows.Forms.GroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbRolWEB = New System.Windows.Forms.ComboBox()
        Me.chkWEB = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridad = New TCMAdmin.dsSeguridad()
        Me.Users_ProfilesTableAdapter = New TCMAdmin.dsSeguridadTableAdapters.Users_ProfilesTableAdapter()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        CType(Me.ucoPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoOficina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSistema.SuspendLayout()
        Me.grpWEB.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.btnEditar, Me.btnActiva, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(887, 43)
        Me.BindingNavigator1.TabIndex = 582
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
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar"
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
        '
        'btnActiva
        '
        Me.btnActiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActiva.Image = Global.TCMAdmin.My.Resources.Resources.Desbloquear
        Me.btnActiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActiva.Name = "btnActiva"
        Me.btnActiva.Size = New System.Drawing.Size(40, 40)
        Me.btnActiva.Text = "ToolStripButton2"
        Me.btnActiva.ToolTipText = "Activar Usuario"
        Me.btnActiva.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(40, 40)
        Me.btnElimina.Text = "Eliminar"
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
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpDatos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpSistema)
        Me.SplitContainer1.Size = New System.Drawing.Size(887, 303)
        Me.SplitContainer1.SplitterDistance = 483
        Me.SplitContainer1.TabIndex = 583
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtBaja)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.txtFechaCreacion)
        Me.grpDatos.Controls.Add(Me.Label14)
        Me.grpDatos.Controls.Add(Me.txtTelefono)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.txtEmail)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.txtPaterno)
        Me.grpDatos.Controls.Add(Me.txtMaterno)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.ucoPuesto)
        Me.grpDatos.Controls.Add(Me.ucoOficina)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Controls.Add(Me.txtUserId)
        Me.grpDatos.Controls.Add(Me.lblUser)
        Me.grpDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatos.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatos.Location = New System.Drawing.Point(0, 0)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(483, 303)
        Me.grpDatos.TabIndex = 580
        Me.grpDatos.Text = "Datos Generales"
        Me.grpDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtBaja
        '
        Me.txtBaja.BackColor = System.Drawing.Color.White
        Me.txtBaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proFechaBaja", True))
        Me.txtBaja.Enabled = False
        Me.txtBaja.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaja.Location = New System.Drawing.Point(84, 264)
        Me.txtBaja.MaxLength = 50
        Me.txtBaja.Name = "txtBaja"
        Me.txtBaja.ReadOnly = True
        Me.txtBaja.Size = New System.Drawing.Size(177, 15)
        Me.txtBaja.TabIndex = 625
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 626
        Me.Label7.Text = "Baja"
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.BackColor = System.Drawing.Color.White
        Me.txtFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaCreacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proFechaAlta", True))
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.Location = New System.Drawing.Point(84, 236)
        Me.txtFechaCreacion.MaxLength = 50
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.ReadOnly = True
        Me.txtFechaCreacion.Size = New System.Drawing.Size(177, 15)
        Me.txtFechaCreacion.TabIndex = 622
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 14)
        Me.Label14.TabIndex = 624
        Me.Label14.Text = "Creado"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proTelefono", True))
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(84, 170)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(151, 22)
        Me.txtTelefono.TabIndex = 607
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 615
        Me.Label6.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 610
        Me.Label1.Text = "Nombres (s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 611
        Me.Label2.Text = "Paterno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 617
        Me.Label8.Text = "email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(84, 202)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(187, 22)
        Me.txtEmail.TabIndex = 598
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 612
        Me.Label3.Text = "Materno"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proNombres", True))
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(84, 56)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 22)
        Me.txtNombre.TabIndex = 602
        '
        'txtPaterno
        '
        Me.txtPaterno.BackColor = System.Drawing.Color.White
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proApellidoPaterno", True))
        Me.txtPaterno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaterno.Location = New System.Drawing.Point(84, 84)
        Me.txtPaterno.MaxLength = 30
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(151, 22)
        Me.txtPaterno.TabIndex = 603
        '
        'txtMaterno
        '
        Me.txtMaterno.BackColor = System.Drawing.Color.White
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proApellidoMaterno", True))
        Me.txtMaterno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterno.Location = New System.Drawing.Point(311, 84)
        Me.txtMaterno.MaxLength = 30
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(151, 22)
        Me.txtMaterno.TabIndex = 604
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 613
        Me.Label4.Text = "Puesto"
        '
        'ucoPuesto
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.FontData.BoldAsString = "True"
        Me.ucoPuesto.Appearance = Appearance1
        Me.ucoPuesto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoPuesto.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoPuesto.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "proIdPuesto", True))
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.ucoPuesto.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.Header.Caption = "ID"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Puesto"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 378
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ucoPuesto.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoPuesto.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoPuesto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoPuesto.Location = New System.Drawing.Point(84, 111)
        Me.ucoPuesto.MaxDropDownItems = 30
        Me.ucoPuesto.Name = "ucoPuesto"
        Me.ucoPuesto.NullText = "Seleccione..."
        Me.ucoPuesto.Size = New System.Drawing.Size(378, 24)
        Me.ucoPuesto.TabIndex = 605
        '
        'ucoOficina
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.FontData.BoldAsString = "True"
        Me.ucoOficina.Appearance = Appearance3
        Me.ucoOficina.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoOficina.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoOficina.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "proIdOficina", True))
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.ucoOficina.DisplayLayout.Appearance = Appearance4
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 378
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoOficina.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoOficina.DisplayMember = "nombre"
        Me.ucoOficina.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoOficina.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoOficina.Location = New System.Drawing.Point(84, 141)
        Me.ucoOficina.MaxDropDownItems = 30
        Me.ucoOficina.Name = "ucoOficina"
        Me.ucoOficina.NullText = "Seleccione..."
        Me.ucoOficina.Size = New System.Drawing.Size(378, 24)
        Me.ucoOficina.TabIndex = 606
        Me.ucoOficina.ValueMember = "comun"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 614
        Me.Label5.Text = "Oficina"
        '
        'txtUserId
        '
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proUserId", True))
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(84, 28)
        Me.txtUserId.MaxLength = 10
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(151, 22)
        Me.txtUserId.TabIndex = 6
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(9, 34)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(53, 17)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User Id:"
        '
        'grpSistema
        '
        Me.grpSistema.Controls.Add(Me.grpWEB)
        Me.grpSistema.Controls.Add(Me.chkAddress)
        Me.grpSistema.Controls.Add(Me.btnReset)
        Me.grpSistema.Controls.Add(Me.txtNumeroCaja)
        Me.grpSistema.Controls.Add(Me.Label18)
        Me.grpSistema.Controls.Add(Me.txtUltimoAcceso)
        Me.grpSistema.Controls.Add(Me.lblRol)
        Me.grpSistema.Controls.Add(Me.Label13)
        Me.grpSistema.Controls.Add(Me.cmbRol)
        Me.grpSistema.Controls.Add(Me.chkActive)
        Me.grpSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpSistema.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpSistema.Location = New System.Drawing.Point(0, 0)
        Me.grpSistema.Name = "grpSistema"
        Me.grpSistema.Size = New System.Drawing.Size(400, 303)
        Me.grpSistema.TabIndex = 581
        Me.grpSistema.Text = "Acceso al Sistema"
        Me.grpSistema.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkAddress
        '
        Me.chkAddress.AutoSize = True
        Me.chkAddress.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "proValidaUbicacion", True))
        Me.chkAddress.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "proValidaUbicacion", True))
        Me.chkAddress.Location = New System.Drawing.Point(222, 128)
        Me.chkAddress.Name = "chkAddress"
        Me.chkAddress.Size = New System.Drawing.Size(151, 20)
        Me.chkAddress.TabIndex = 627
        Me.chkAddress.Text = "Validar Ubicación"
        Me.chkAddress.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.ForeColor = System.Drawing.Color.Blue
        Me.btnReset.Location = New System.Drawing.Point(119, 155)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(173, 23)
        Me.btnReset.TabIndex = 626
        Me.btnReset.Text = "Password Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtNumeroCaja
        '
        Me.txtNumeroCaja.BackColor = System.Drawing.Color.White
        Me.txtNumeroCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "proNumeroCaja", True))
        Me.txtNumeroCaja.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCaja.Location = New System.Drawing.Point(119, 36)
        Me.txtNumeroCaja.MaxLength = 12
        Me.txtNumeroCaja.Name = "txtNumeroCaja"
        Me.txtNumeroCaja.Size = New System.Drawing.Size(69, 22)
        Me.txtNumeroCaja.TabIndex = 608
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 14)
        Me.Label18.TabIndex = 621
        Me.Label18.Text = "Número de Caja"
        '
        'txtUltimoAcceso
        '
        Me.txtUltimoAcceso.BackColor = System.Drawing.Color.White
        Me.txtUltimoAcceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUltimoAcceso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "UltimoAcceso", True))
        Me.txtUltimoAcceso.Enabled = False
        Me.txtUltimoAcceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoAcceso.Location = New System.Drawing.Point(119, 100)
        Me.txtUltimoAcceso.MaxLength = 50
        Me.txtUltimoAcceso.Name = "txtUltimoAcceso"
        Me.txtUltimoAcceso.ReadOnly = True
        Me.txtUltimoAcceso.Size = New System.Drawing.Size(245, 15)
        Me.txtUltimoAcceso.TabIndex = 623
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(81, 71)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(29, 17)
        Me.lblRol.TabIndex = 8
        Me.lblRol.Text = "Rol:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 14)
        Me.Label13.TabIndex = 625
        Me.Label13.Text = "Último Acceso"
        '
        'cmbRol
        '
        Me.cmbRol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "idRol", True))
        Me.cmbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(119, 67)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(262, 21)
        Me.cmbRol.TabIndex = 51
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "proActivo", True))
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "proActivo", True))
        Me.chkActive.Location = New System.Drawing.Point(119, 128)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(70, 20)
        Me.chkActive.TabIndex = 7
        Me.chkActive.Text = "Activo"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'grpWEB
        '
        Me.grpWEB.Controls.Add(Me.chkWEB)
        Me.grpWEB.Controls.Add(Me.UltraLabel1)
        Me.grpWEB.Controls.Add(Me.cmbRolWEB)
        Me.grpWEB.Location = New System.Drawing.Point(20, 184)
        Me.grpWEB.Name = "grpWEB"
        Me.grpWEB.Size = New System.Drawing.Size(361, 108)
        Me.grpWEB.TabIndex = 628
        Me.grpWEB.TabStop = False
        Me.grpWEB.Text = "Portal WEB"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 66)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 17)
        Me.UltraLabel1.TabIndex = 629
        Me.UltraLabel1.Text = "Rol WEB:"
        '
        'cmbRolWEB
        '
        Me.cmbRolWEB.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "idWebRol", True))
        Me.cmbRolWEB.Enabled = False
        Me.cmbRolWEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRolWEB.FormattingEnabled = True
        Me.cmbRolWEB.Location = New System.Drawing.Point(70, 65)
        Me.cmbRolWEB.Name = "cmbRolWEB"
        Me.cmbRolWEB.Size = New System.Drawing.Size(262, 21)
        Me.cmbRolWEB.TabIndex = 630
        '
        'chkWEB
        '
        Me.chkWEB.AutoSize = True
        Me.chkWEB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "webAccess", True))
        Me.chkWEB.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "webAccess", True))
        Me.chkWEB.Location = New System.Drawing.Point(70, 21)
        Me.chkWEB.Name = "chkWEB"
        Me.chkWEB.Size = New System.Drawing.Size(117, 20)
        Me.chkWEB.TabIndex = 629
        Me.chkWEB.Text = "Acceso WEB"
        Me.chkWEB.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Users_Profiles"
        Me.BindingSource1.DataSource = Me.DsSeguridad
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Users_ProfilesTableAdapter
        '
        Me.Users_ProfilesTableAdapter.ClearBeforeFill = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(887, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUser"
        Me.Text = "Usuario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grpDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.ucoPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoOficina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSistema.ResumeLayout(False)
        Me.grpSistema.PerformLayout()
        Me.grpWEB.ResumeLayout(False)
        Me.grpWEB.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DsSeguridad As dsSeguridad
    Friend WithEvents Users_ProfilesTableAdapter As dsSeguridadTableAdapters.Users_ProfilesTableAdapter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpDatos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtBaja As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ucoPuesto As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucoOficina As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents lblUser As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpSistema As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtNumeroCaja As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtUltimoAcceso As TextBox
    Friend WithEvents lblRol As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents btnActiva As ToolStripButton
    Friend WithEvents btnReset As Button
    Friend WithEvents chkAddress As CheckBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents grpWEB As GroupBox
    Friend WithEvents chkWEB As CheckBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbRolWEB As ComboBox
End Class
