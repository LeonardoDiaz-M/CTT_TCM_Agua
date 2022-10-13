<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebRootMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblCve = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.numPos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(546, 43)
        Me.BindingNavigator1.TabIndex = 25
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(456, 55)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(56, 17)
        Me.chkStatus.TabIndex = 24
        Me.chkStatus.Text = "&Activo"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(127, 89)
        Me.txtDesc.MaxLength = 50
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(385, 20)
        Me.txtDesc.TabIndex = 23
        Me.txtDesc.WordWrap = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(2, 89)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(118, 16)
        Me.lblDesc.TabIndex = 22
        Me.lblDesc.Text = "Título del menú:"
        '
        'lblCve
        '
        Me.lblCve.AutoSize = True
        Me.lblCve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCve.Location = New System.Drawing.Point(2, 56)
        Me.lblCve.Name = "lblCve"
        Me.lblCve.Size = New System.Drawing.Size(119, 16)
        Me.lblCve.TabIndex = 21
        Me.lblCve.Text = "Clave del menú:"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(127, 55)
        Me.txtClave.MaxLength = 50
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(154, 20)
        Me.txtClave.TabIndex = 26
        Me.txtClave.WordWrap = False
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
        Me.btnGuardar.Text = "ToolStripButton2"
        '
        'numPos
        '
        Me.numPos.Location = New System.Drawing.Point(382, 55)
        Me.numPos.Name = "numPos"
        Me.numPos.Size = New System.Drawing.Size(40, 20)
        Me.numPos.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Pos:"
        '
        'frmWebRootMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 122)
        Me.Controls.Add(Me.numPos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.chkStatus)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblCve)
        Me.Controls.Add(Me.txtClave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmWebRootMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion Menu WEB"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.numPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblCve As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents numPos As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
