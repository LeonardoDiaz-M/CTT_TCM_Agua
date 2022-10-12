<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchGoogle
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
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.tsbRegistraNavegador = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtLatitud = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtLongitud = New System.Windows.Forms.ToolStripTextBox()
        Me.webGoogle = New System.Windows.Forms.WebBrowser()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.CountItem = Nothing
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.tsbRegistraNavegador, Me.btnBuscar, Me.ToolStripLabel2, Me.ToolStripLabel1, Me.txtLatitud, Me.ToolStripLabel3, Me.txtLongitud})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(1007, 37)
        Me.BindingNavigator2.TabIndex = 7
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        'tsbRegistraNavegador
        '
        Me.tsbRegistraNavegador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegistraNavegador.Image = Global.TCMAdmin.My.Resources.Resources.reginter
        Me.tsbRegistraNavegador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegistraNavegador.Name = "tsbRegistraNavegador"
        Me.tsbRegistraNavegador.Size = New System.Drawing.Size(34, 34)
        Me.tsbRegistraNavegador.Text = "ToolStripButton1"
        Me.tsbRegistraNavegador.ToolTipText = "Registra navegador"
        '
        'btnBuscar
        '
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = Global.TCMAdmin.My.Resources.Resources.find
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(34, 34)
        Me.btnBuscar.Text = "ToolStripButton1"
        Me.btnBuscar.ToolTipText = "Buscar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(500, 34)
        Me.ToolStripLabel2.Text = "                       "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 34)
        Me.ToolStripLabel1.Text = "Latitud"
        Me.ToolStripLabel1.Visible = False
        '
        'txtLatitud
        '
        Me.txtLatitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.Size = New System.Drawing.Size(100, 37)
        Me.txtLatitud.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(55, 34)
        Me.ToolStripLabel3.Text = "Longitud"
        Me.ToolStripLabel3.Visible = False
        '
        'txtLongitud
        '
        Me.txtLongitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(100, 37)
        Me.txtLongitud.Visible = False
        '
        'webGoogle
        '
        Me.webGoogle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webGoogle.Location = New System.Drawing.Point(0, 37)
        Me.webGoogle.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webGoogle.Name = "webGoogle"
        Me.webGoogle.Size = New System.Drawing.Size(1007, 519)
        Me.webGoogle.TabIndex = 9
        Me.webGoogle.Url = New System.Uri("https://www.google.com.mx/maps", System.UriKind.Absolute)
        '
        'frmSearchGoogle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 556)
        Me.Controls.Add(Me.webGoogle)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.Name = "frmSearchGoogle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Google"
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents webGoogle As WebBrowser
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtLatitud As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtLongitud As ToolStripTextBox
    Friend WithEvents tsbRegistraNavegador As ToolStripButton
End Class
