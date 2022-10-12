<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmaPago
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.lblTot = New Infragistics.Win.Misc.UltraLabel()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lbCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPeriodos = New Infragistics.Win.Misc.UltraLabel()
        Me.DsPagos1 = New TCMAdmin.dsPagos()
        Me.Datos_mpioTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.datos_mpioTableAdapter()
        Me.Tab_det_liquidacionesTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.tab_det_liquidacionesTableAdapter()
        Me.Tab_liquidacionesTableAdapter1 = New TCMAdmin.dsPagosTableAdapters.tab_liquidacionesTableAdapter()
        Me.cmbSatCta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.DsPagos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSatCta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTot
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.lblTot.Appearance = Appearance1
        Me.lblTot.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Location = New System.Drawing.Point(45, 59)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(376, 55)
        Me.lblTot.TabIndex = 15
        Me.lblTot.Text = "TOTAL A PAGAR:"
        Me.lblTot.UseAppStyling = False
        '
        'btnPago
        '
        Me.btnPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.White
        Me.btnPago.Location = New System.Drawing.Point(45, 203)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(178, 41)
        Me.btnPago.TabIndex = 16
        Me.btnPago.Text = "Realizar PAGO"
        Me.btnPago.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(243, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(178, 41)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lbCuenta
        '
        Appearance2.ForeColor = System.Drawing.Color.Gray
        Appearance2.TextHAlignAsString = "Left"
        Me.lbCuenta.Appearance = Appearance2
        Me.lbCuenta.AutoSize = True
        Me.lbCuenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbCuenta.Location = New System.Drawing.Point(43, 3)
        Me.lbCuenta.Name = "lbCuenta"
        Me.lbCuenta.Size = New System.Drawing.Size(70, 22)
        Me.lbCuenta.TabIndex = 18
        Me.lbCuenta.Text = "Cuenta:"
        Me.lbCuenta.UseAppStyling = False
        '
        'lblPeriodos
        '
        Appearance3.ForeColor = System.Drawing.Color.Gray
        Appearance3.TextHAlignAsString = "Left"
        Me.lblPeriodos.Appearance = Appearance3
        Me.lblPeriodos.AutoSize = True
        Me.lblPeriodos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPeriodos.Location = New System.Drawing.Point(43, 31)
        Me.lblPeriodos.Name = "lblPeriodos"
        Me.lblPeriodos.Size = New System.Drawing.Size(78, 22)
        Me.lblPeriodos.TabIndex = 19
        Me.lblPeriodos.Text = "Periodos"
        Me.lblPeriodos.UseAppStyling = False
        '
        'DsPagos1
        '
        Me.DsPagos1.DataSetName = "dsPagos"
        Me.DsPagos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Datos_mpioTableAdapter1
        '
        Me.Datos_mpioTableAdapter1.ClearBeforeFill = True
        '
        'Tab_det_liquidacionesTableAdapter1
        '
        Me.Tab_det_liquidacionesTableAdapter1.ClearBeforeFill = True
        '
        'Tab_liquidacionesTableAdapter1
        '
        Me.Tab_liquidacionesTableAdapter1.ClearBeforeFill = True
        '
        'cmbSatCta
        '
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.Name = "Tahoma"
        Appearance4.FontData.SizeInPoints = 9.0!
        Me.cmbSatCta.Appearance = Appearance4
        Me.cmbSatCta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cmbSatCta.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cmbSatCta.BorderStyle = Infragistics.Win.UIElementBorderStyle.Inset
        Me.cmbSatCta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn17.Header.Editor = Nothing
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 600
        UltraGridColumn18.Header.Editor = Nothing
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 859
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18})
        Me.cmbSatCta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cmbSatCta.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.cmbSatCta.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Me.cmbSatCta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.cmbSatCta.DisplayMember = "descripcion"
        Me.cmbSatCta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005
        Me.cmbSatCta.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize
        Me.cmbSatCta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSatCta.Location = New System.Drawing.Point(45, 154)
        Me.cmbSatCta.MaxDropDownItems = 30
        Me.cmbSatCta.Name = "cmbSatCta"
        Me.cmbSatCta.NullText = "Seleccione..."
        Me.cmbSatCta.Size = New System.Drawing.Size(376, 24)
        Me.cmbSatCta.TabIndex = 610
        '
        'UltraLabel1
        '
        Appearance5.ForeColor = System.Drawing.Color.Gray
        Appearance5.TextHAlignAsString = "Left"
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel1.Location = New System.Drawing.Point(45, 126)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(228, 22)
        Me.UltraLabel1.TabIndex = 611
        Me.UltraLabel1.Text = "Seleccione Forma de Pago:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'frmConfirmaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cmbSatCta)
        Me.Controls.Add(Me.lblPeriodos)
        Me.Controls.Add(Me.lbCuenta)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.lblTot)
        Me.Name = "frmConfirmaPago"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación de pago"
        CType(Me.DsPagos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSatCta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTot As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnPago As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lbCuenta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPeriodos As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsPagos1 As dsPagos
    Friend WithEvents Datos_mpioTableAdapter1 As dsPagosTableAdapters.datos_mpioTableAdapter
    Friend WithEvents Tab_det_liquidacionesTableAdapter1 As dsPagosTableAdapters.tab_det_liquidacionesTableAdapter
    Friend WithEvents Tab_liquidacionesTableAdapter1 As dsPagosTableAdapters.tab_liquidacionesTableAdapter
    Friend WithEvents cmbSatCta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
