<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAguaRegistroConsumo_Alta
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.lblPeriodo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtanio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLecturaActual = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLecturaAnterior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.uneConsumo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.unePeriodo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Tbl_consumo_aguaTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_consumo_aguaTableAdapter()
        CType(Me.txtanio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLecturaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLecturaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.uneConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unePeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(3, 129)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(56, 16)
        Me.lblPeriodo.TabIndex = 87
        Me.lblPeriodo.Text = "Bimestre:"
        Me.lblPeriodo.UseAppStyling = False
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(28, 92)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 16)
        Me.UltraLabel1.TabIndex = 88
        Me.UltraLabel1.Text = "Año:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtanio
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.txtanio.Appearance = Appearance1
        Me.txtanio.BackColor = System.Drawing.Color.White
        Me.txtanio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanio.Location = New System.Drawing.Point(64, 86)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtanio.Size = New System.Drawing.Size(69, 25)
        Me.txtanio.TabIndex = 85
        Me.txtanio.UseAppStyling = False
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(246, 129)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(59, 16)
        Me.UltraLabel7.TabIndex = 100
        Me.UltraLabel7.Text = "Consumo:"
        Me.UltraLabel7.UseAppStyling = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(219, 92)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel6.TabIndex = 99
        Me.UltraLabel6.Text = "Lectura actual:"
        Me.UltraLabel6.UseAppStyling = False
        '
        'uneLecturaActual
        '
        Me.uneLecturaActual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLecturaActual.Location = New System.Drawing.Point(311, 86)
        Me.uneLecturaActual.MinValue = 0
        Me.uneLecturaActual.Name = "uneLecturaActual"
        Me.uneLecturaActual.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLecturaActual.Size = New System.Drawing.Size(100, 25)
        Me.uneLecturaActual.TabIndex = 95
        Me.uneLecturaActual.UseAppStyling = False
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(209, 59)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel5.TabIndex = 98
        Me.UltraLabel5.Text = "Lectura anterior:"
        Me.UltraLabel5.UseAppStyling = False
        '
        'uneLecturaAnterior
        '
        Me.uneLecturaAnterior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLecturaAnterior.Location = New System.Drawing.Point(311, 53)
        Me.uneLecturaAnterior.MinValue = 0
        Me.uneLecturaAnterior.Name = "uneLecturaAnterior"
        Me.uneLecturaAnterior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLecturaAnterior.Size = New System.Drawing.Size(100, 25)
        Me.uneLecturaAnterior.TabIndex = 94
        Me.uneLecturaAnterior.UseAppStyling = False
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(12, 59)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(47, 16)
        Me.UltraLabel9.TabIndex = 104
        Me.UltraLabel9.Text = "Cuenta:"
        Me.UltraLabel9.UseAppStyling = False
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.AlwaysInEditMode = True
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.TextVAlignAsString = "Middle"
        Me.txtNumeroCuenta.Appearance = Appearance2
        Me.txtNumeroCuenta.BackColor = System.Drawing.Color.White
        Me.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNumeroCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(64, 57)
        Me.txtNumeroCuenta.MaxLength = 120
        Me.txtNumeroCuenta.Multiline = True
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(118, 23)
        Me.txtNumeroCuenta.TabIndex = 105
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(435, 43)
        Me.BindingNavigator1.TabIndex = 106
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
        Me.btnGuardar.ToolTipText = "Guardar "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel1.Text = "                       "
        '
        'uneConsumo
        '
        Me.uneConsumo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneConsumo.Location = New System.Drawing.Point(311, 123)
        Me.uneConsumo.MinValue = 0
        Me.uneConsumo.Name = "uneConsumo"
        Me.uneConsumo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneConsumo.Size = New System.Drawing.Size(100, 25)
        Me.uneConsumo.TabIndex = 107
        Me.uneConsumo.UseAppStyling = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'unePeriodo
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.TextHAlignAsString = "Center"
        Me.unePeriodo.Appearance = Appearance3
        Me.unePeriodo.BackColor = System.Drawing.Color.White
        Me.unePeriodo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unePeriodo.Location = New System.Drawing.Point(64, 123)
        Me.unePeriodo.MaxValue = 12
        Me.unePeriodo.MinValue = 0
        Me.unePeriodo.Name = "unePeriodo"
        Me.unePeriodo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.unePeriodo.Size = New System.Drawing.Size(61, 25)
        Me.unePeriodo.TabIndex = 108
        Me.unePeriodo.UseAppStyling = False
        '
        'Tbl_consumo_aguaTableAdapter
        '
        Me.Tbl_consumo_aguaTableAdapter.ClearBeforeFill = True
        '
        'frmAguaRegistroConsumo_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.unePeriodo)
        Me.Controls.Add(Me.uneConsumo)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.uneLecturaActual)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.uneLecturaAnterior)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txtanio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAguaRegistroConsumo_Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Consumo Alta"
        CType(Me.txtanio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLecturaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLecturaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.uneConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unePeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeriodo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtanio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLecturaActual As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLecturaAnterior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Tbl_consumo_aguaTableAdapter As dsAguaTableAdapters.tbl_consumo_aguaTableAdapter
    Friend WithEvents uneConsumo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents unePeriodo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
