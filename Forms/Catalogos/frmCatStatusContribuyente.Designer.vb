<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatStatusContribuyente
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatStatusContribuyente))
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.TblstatuscontribuyenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New TCMAdmin.dsCatalogos()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkDetenerCobro = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.uexDatos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Tbl_status_contribuyenteTableAdapter = New TCMAdmin.dsCatalogosTableAdapters.tbl_status_contribuyenteTableAdapter()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstatuscontribuyenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uexDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uexDatos.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.AlwaysInEditMode = True
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtId.Appearance = Appearance1
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstatuscontribuyenteBindingSource, "cve_status", True))
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(242, 51)
        Me.txtId.MaxLength = 2
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtId.Size = New System.Drawing.Size(108, 23)
        Me.txtId.TabIndex = 142
        '
        'TblstatuscontribuyenteBindingSource
        '
        Me.TblstatuscontribuyenteBindingSource.DataMember = "tbl_status_contribuyente"
        Me.TblstatuscontribuyenteBindingSource.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraLabel1
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(134, 83)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 16)
        Me.UltraLabel1.TabIndex = 145
        Me.UltraLabel1.Text = "Nombre:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'lblCuenta
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.lblCuenta.Appearance = Appearance3
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(134, 53)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(100, 16)
        Me.lblCuenta.TabIndex = 144
        Me.lblCuenta.Text = "Id:"
        Me.lblCuenta.UseAppStyling = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AlwaysInEditMode = True
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.txtDescripcion.Appearance = Appearance4
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblstatuscontribuyenteBindingSource, "descripcion", True))
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(242, 80)
        Me.txtDescripcion.MaxLength = 35
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 23)
        Me.txtDescripcion.TabIndex = 143
        '
        'chkDetenerCobro
        '
        Me.chkDetenerCobro.AutoSize = True
        Me.chkDetenerCobro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDetenerCobro.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblstatuscontribuyenteBindingSource, "detener_cobro", True))
        Me.chkDetenerCobro.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetenerCobro.Location = New System.Drawing.Point(141, 112)
        Me.chkDetenerCobro.Name = "chkDetenerCobro"
        Me.chkDetenerCobro.Size = New System.Drawing.Size(115, 18)
        Me.chkDetenerCobro.TabIndex = 146
        Me.chkDetenerCobro.Text = "Detener Cobro: "
        Me.chkDetenerCobro.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'uexDatos
        '
        Me.uexDatos.Controls.Add(Me.txtDescripcion)
        Me.uexDatos.Controls.Add(Me.chkDetenerCobro)
        Me.uexDatos.Controls.Add(Me.lblCuenta)
        Me.uexDatos.Controls.Add(Me.txtId)
        Me.uexDatos.Controls.Add(Me.UltraLabel1)
        Me.uexDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uexDatos.Enabled = False
        Me.uexDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uexDatos.Location = New System.Drawing.Point(0, 37)
        Me.uexDatos.Name = "uexDatos"
        Me.uexDatos.Size = New System.Drawing.Size(884, 178)
        Me.uexDatos.TabIndex = 147
        Me.uexDatos.Text = "Datos Cuenta"
        Me.uexDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Tbl_status_contribuyenteTableAdapter
        '
        Me.Tbl_status_contribuyenteTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        Me.BindingNavigator1.BindingSource = Me.TblstatuscontribuyenteBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.lblCurrentMenu, Me.ToolStripLabel2, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(884, 37)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 34)
        Me.btnBack.Text = "ToolStripButton1"
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
        Me.btnGuardar.ToolTipText = "Guardar Datos"
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
        Me.btnEditar.ToolTipText = "Editar"
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(34, 34)
        Me.btnElimina.Text = "Eliminar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel1.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 34)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel2.Text = "           "
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
        'frmCatStatusContribuyente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.uexDatos)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmCatStatusContribuyente"
        Me.Text = "Catálogo: Status Contribuyente"
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstatuscontribuyenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uexDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uexDatos.ResumeLayout(False)
        Me.uexDatos.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkDetenerCobro As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents uexDatos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents TblstatuscontribuyenteBindingSource As BindingSource
    Friend WithEvents Tbl_status_contribuyenteTableAdapter As dsCatalogosTableAdapters.tbl_status_contribuyenteTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
