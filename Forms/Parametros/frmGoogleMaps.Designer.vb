<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleMaps
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
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.lblClavePadron = New System.Windows.Forms.ToolStripLabel()
        Me.lblTipoPadron = New System.Windows.Forms.ToolStripLabel()
        Me.lblCampo = New System.Windows.Forms.ToolStripLabel()
        Me.lblNombreContribuyente = New System.Windows.Forms.ToolStripLabel()
        Me.lblUbicacion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtLatitud = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtLongitud = New System.Windows.Forms.ToolStripTextBox()
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.panControl = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.trackZoom = New Infragistics.Win.UltraWinEditors.UltraTrackBar()
        Me.btnRelieve = New Infragistics.Win.Misc.UltraButton()
        Me.btnNormal = New Infragistics.Win.Misc.UltraButton()
        Me.btnSatelite = New Infragistics.Win.Misc.UltraButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.panControl.ClientArea.SuspendLayout()
        Me.panControl.SuspendLayout()
        CType(Me.trackZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.CountItem = Nothing
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.lblClavePadron, Me.lblTipoPadron, Me.lblCampo, Me.lblNombreContribuyente, Me.lblUbicacion, Me.ToolStripLabel1, Me.ToolStripLabel2, Me.txtLatitud, Me.ToolStripLabel3, Me.txtLongitud})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(1579, 37)
        Me.BindingNavigator2.TabIndex = 8
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
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(34, 34)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Actualiza coordenadas"
        '
        'lblClavePadron
        '
        Me.lblClavePadron.Name = "lblClavePadron"
        Me.lblClavePadron.Size = New System.Drawing.Size(17, 34)
        Me.lblClavePadron.Text = "0"
        Me.lblClavePadron.Visible = False
        '
        'lblTipoPadron
        '
        Me.lblTipoPadron.Name = "lblTipoPadron"
        Me.lblTipoPadron.Size = New System.Drawing.Size(17, 34)
        Me.lblTipoPadron.Text = "0"
        Me.lblTipoPadron.Visible = False
        '
        'lblCampo
        '
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(17, 34)
        Me.lblCampo.Text = "0"
        Me.lblCampo.Visible = False
        '
        'lblNombreContribuyente
        '
        Me.lblNombreContribuyente.Name = "lblNombreContribuyente"
        Me.lblNombreContribuyente.Size = New System.Drawing.Size(17, 34)
        Me.lblNombreContribuyente.Text = "0"
        Me.lblNombreContribuyente.Visible = False
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(17, 34)
        Me.lblUbicacion.Text = "0"
        Me.lblUbicacion.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(357, 34)
        Me.ToolStripLabel1.Text = "                                                                                 " &
    "      "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(55, 34)
        Me.ToolStripLabel2.Text = "Latitud"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLatitud
        '
        Me.txtLatitud.BackColor = System.Drawing.Color.White
        Me.txtLatitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.ReadOnly = True
        Me.txtLatitud.Size = New System.Drawing.Size(172, 37)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(68, 34)
        Me.ToolStripLabel3.Text = "Longitud"
        '
        'txtLongitud
        '
        Me.txtLongitud.BackColor = System.Drawing.Color.White
        Me.txtLongitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.ReadOnly = True
        Me.txtLongitud.Size = New System.Drawing.Size(172, 37)
        '
        'GMapControl1
        '
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = True
        Me.GMapControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GMapControl1.GrayScaleMode = False
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemmory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(0, 37)
        Me.GMapControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GMapControl1.MarkersEnabled = True
        Me.GMapControl1.MaxZoom = 18
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomEnabled = True
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = False
        Me.GMapControl1.PolygonsEnabled = True
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = True
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapControl1.ShowTileGridLines = False
        Me.GMapControl1.Size = New System.Drawing.Size(1579, 653)
        Me.GMapControl1.TabIndex = 9
        Me.GMapControl1.Zoom = 13.0R
        '
        'panControl
        '
        '
        'panControl.ClientArea
        '
        Me.panControl.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.panControl.ClientArea.Controls.Add(Me.trackZoom)
        Me.panControl.ClientArea.Controls.Add(Me.btnRelieve)
        Me.panControl.ClientArea.Controls.Add(Me.btnNormal)
        Me.panControl.ClientArea.Controls.Add(Me.btnSatelite)
        Me.panControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panControl.Location = New System.Drawing.Point(0, 631)
        Me.panControl.Margin = New System.Windows.Forms.Padding(4)
        Me.panControl.Name = "panControl"
        Me.panControl.Size = New System.Drawing.Size(1579, 59)
        Me.panControl.TabIndex = 10
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(497, 16)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(75, 28)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Zoom"
        '
        'trackZoom
        '
        Me.trackZoom.Location = New System.Drawing.Point(580, 9)
        Me.trackZoom.Margin = New System.Windows.Forms.Padding(4)
        Me.trackZoom.MaxValue = 25
        Me.trackZoom.Name = "trackZoom"
        Me.trackZoom.Size = New System.Drawing.Size(549, 29)
        Me.trackZoom.TabIndex = 3
        '
        'btnRelieve
        '
        Me.btnRelieve.Location = New System.Drawing.Point(316, 16)
        Me.btnRelieve.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRelieve.Name = "btnRelieve"
        Me.btnRelieve.Size = New System.Drawing.Size(100, 28)
        Me.btnRelieve.TabIndex = 2
        Me.btnRelieve.Text = "Relieve"
        '
        'btnNormal
        '
        Me.btnNormal.Location = New System.Drawing.Point(179, 16)
        Me.btnNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(100, 28)
        Me.btnNormal.TabIndex = 1
        Me.btnNormal.Text = "Normal"
        '
        'btnSatelite
        '
        Me.btnSatelite.Location = New System.Drawing.Point(41, 16)
        Me.btnSatelite.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSatelite.Name = "btnSatelite"
        Me.btnSatelite.Size = New System.Drawing.Size(100, 28)
        Me.btnSatelite.TabIndex = 0
        Me.btnSatelite.Text = "Satélite"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmGoogleMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 690)
        Me.Controls.Add(Me.panControl)
        Me.Controls.Add(Me.GMapControl1)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGoogleMaps"
        Me.Text = "Ubicación Geográfica"
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.panControl.ClientArea.ResumeLayout(False)
        Me.panControl.ClientArea.PerformLayout()
        Me.panControl.ResumeLayout(False)
        CType(Me.trackZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents panControl As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents trackZoom As Infragistics.Win.UltraWinEditors.UltraTrackBar
    Friend WithEvents btnRelieve As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNormal As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSatelite As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblClavePadron As ToolStripLabel
    Friend WithEvents lblTipoPadron As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtLatitud As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtLongitud As ToolStripTextBox
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents lblCampo As ToolStripLabel
    Friend WithEvents lblNombreContribuyente As ToolStripLabel
    Friend WithEvents lblUbicacion As ToolStripLabel
End Class
