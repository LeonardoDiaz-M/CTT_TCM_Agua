<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAguaGralCuenta
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grpTipoUsuario = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grpTipoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grpTipoUsuario, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(43, 62)
        Me.txtCuenta.Mask = "########"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(173, 26)
        Me.txtCuenta.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(43, 94)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grpTipoUsuario
        '
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.BorderColor2 = System.Drawing.Color.Silver
        Appearance1.BorderColor3DBase = System.Drawing.Color.Silver
        Me.grpTipoUsuario.Appearance = Appearance1
        Me.grpTipoUsuario.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Me.grpTipoUsuario.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.grpTipoUsuario.Controls.Add(Me.Label1)
        Me.grpTipoUsuario.Controls.Add(Me.btnCancela)
        Me.grpTipoUsuario.Controls.Add(Me.btnBuscar)
        Me.grpTipoUsuario.Controls.Add(Me.txtCuenta)
        Me.grpTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoUsuario.Location = New System.Drawing.Point(267, 151)
        Me.grpTipoUsuario.Name = "grpTipoUsuario"
        Me.grpTipoUsuario.Size = New System.Drawing.Size(266, 147)
        Me.grpTipoUsuario.TabIndex = 18
        Me.grpTipoUsuario.Text = "Número de Cuenta"
        Me.grpTipoUsuario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnCancela
        '
        Me.btnCancela.Location = New System.Drawing.Point(136, 94)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(80, 23)
        Me.btnCancela.TabIndex = 3
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Digite Cuenta:"
        '
        'frmAguaGralCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmAguaGralCuenta"
        Me.Text = "Captura de Número de Cuenta"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grpTipoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoUsuario.ResumeLayout(False)
        Me.grpTipoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtCuenta As MaskedTextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents grpTipoUsuario As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnCancela As Button
    Friend WithEvents Label1 As Label
End Class
