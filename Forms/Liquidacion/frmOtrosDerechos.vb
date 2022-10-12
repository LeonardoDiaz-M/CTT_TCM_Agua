Imports System.ComponentModel
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmOtrosDerechos
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = True
    Public Borrar As Boolean = False
    Public Editar As Boolean = True
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private tipo As String = "Main"
    Private Total As Decimal = 0
    Private SelectedRow As Integer = 0
    Private NumCuenta As String = ""
    Private NumLiq As Integer = 0
    Private NumRec As Integer = 0

    Private Sub frmOtrosDerechos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Select Case Cuenta
        '    Case "0201"
        '        Me.lblTitulo.Text = "OTROS DERECHOS DE AGUA POTABLE Y DRENAJE"
        '    Case "0211"
        '        Me.lblTitulo.Text = "OTROS DERECHOS DE LICENCIAS DE COMERCIO"
        '    Case "021601"
        '        Me.lblTitulo.Text = "CATASTRO MUNICIPAL"
        'End Select        
        cxn.fLlenaDropDownUltra(Me.cmbTipoServ, "SELECT Derecho_Id, descripcion 
                                                    FROM tbl_derechos 
                                                   where len(msj_uno)>0 and len(msj_dos)>0 and (ejfiscal = CAST(YEAR(dbo.GETDATEmx()) AS CHAR(4))) 
                                                    ORDER BY descripcion") '(SUBSTRING(cve_cuenta,1,4) like '020%') 
        cxn.Select_SQL("select dbo.getdateMx()")
        Me.dtpFechaVenc.Value = cxn.arrayValores(0)
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If valida() Then
            Dim requerido As String = IIf(Me.chknotif.Checked = False, 0, 1).ToString
            Try
                Dim cxn1 As New cxnData
                cxn1.Get_SQL_DataGrid("exec CalculaDerechosConAccesorios '" & Me.cmbTipoServ.Value & "','" &
                                                                              Val(Me.uneDato1.Value) & "','" &
                                                                              Val(Me.uneDato2.Value) & "','" &
                                                                              Me.txtNombre.Text & "','" &
                                                                              Me.txtDomicilio.Text & "','" &
                                                                              Me.txtRfc.Text & "','" &
                                                                              requerido & "','" &
                                                                              Me.dtpFechaVenc.Text.Trim & "'",
                                                                              Me.grdDataMain)
            Catch ex As Exception
            End Try
            Total = 0
            For Each row As UltraGridRow In Me.grdDataMain.Rows
                row.Cells("chkCol").Value = True
                Total = Total + row.Cells("Total").Value
                Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
                Me.lblTotal.Visible = True
                NumLiq = row.Cells(14).Value
                NumRec = row.Cells(15).Value
                row.Selected = True
                SelectedRow = row.Index
            Next
            If NumLiq <= 0 Then
                cMensajes.DisplayMessage(Me, "No se pudo generar la liquidación, verifique la información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.btnPagar.Enabled = False
            Else
                Me.btnPagar.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbTipoServ_RowSelected(sender As Object, e As RowSelectedEventArgs) Handles cmbTipoServ.RowSelected
        Dim datosCont As New cxnData

        datosCont.Select_SQL("select dato_uno,msj_uno,dato_dos,msj_dos from tbl_derechos where derecho_id=" & Me.cmbTipoServ.Value)
        If datosCont.arrayValores(0) = True Then
            Me.lblDato1.Text = datosCont.arrayValores(1).ToString
            Me.lblDato1.Visible = True
            Me.uneDato1.Visible = True
        Else
            Me.lblDato1.Visible = False
            Me.uneDato1.Visible = False
        End If
        If datosCont.arrayValores(2) = True Then
            Me.lblDato2.Text = datosCont.arrayValores(3).ToString
            Me.lblDato2.Visible = True
            Me.uneDato2.Visible = True
        Else
            Me.lblDato2.Visible = False
            Me.uneDato2.Visible = False
        End If
    End Sub
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim frmPago As New frmConfirmaPago
        frmPago.Total = "Total a Pagar: " & vbCrLf & FormatCurrency(Total, , , TriState.True, TriState.True)
        frmPago.NLiq = NumLiq
        frmPago.NRec = NumRec
        frmPago.NumCuenta = "Pago de Otros Derechos"
        frmPago.Periodos = Me.cmbTipoServ.Text
        frmPago.StartPosition = FormStartPosition.CenterScreen
        DialogForm1(frmPago, Me.ParentForm)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
    Private Function valida() As Boolean
        Dim ban As Boolean = False
        Dim mensaje As String = ""
        Try
            If Me.txtNombre.Text.Trim.Length = 0 Then
                Me.txtNombre.Focus()
                mensaje = "Favor de proporcionar el Nombre..."
            Else
                If Me.txtDomicilio.Text.Trim.Length = 0 Then
                    Me.txtDomicilio.Focus()
                    mensaje = "Favor de proporcionar el Domicilio..."
                Else
                    If Me.cmbTipoServ.SelectedRow.Index <= 0 Then
                        Me.cmbTipoServ.Focus()
                        mensaje = "Seleccione el Tipo de Servicio..."
                    Else
                        If Me.uneDato1.Value <= 0 Then
                            Me.uneDato1.Focus()
                            mensaje = "El valor de " & Me.lblDato1.Text.Replace(":", " ") & ", debe ser mayor a cero..."

                        Else
                            If Me.uneDato2.Value <= 0 And Me.uneDato2.Visible Then
                                Me.uneDato2.Focus()
                                mensaje = "El valor de " & Me.lblDato2.Text.Replace(":", " ") & ", debe ser mayor a cero..."
                            Else
                                ban = True
                                Me.txtNombre.Text = Me.txtNombre.Text.ToUpper
                                Me.txtDomicilio.Text = Me.txtDomicilio.Text.ToUpper
                                Me.txtRfc.Text = Me.txtRfc.Text.ToUpper
                                Me.txtObservaciones.Text = Me.txtObservaciones.Text.ToUpper
                            End If
                        End If
                    End If
                End If
            End If
            If Not ban Then
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grdDataMain.InitializeLayout
        Dim Layout As UltraGridLayout = e.Layout
        Dim ov As UltraGridOverride = Layout.Override
        ov.RowSizing = RowSizing.AutoFree
        'ov.CellMultiLine = True
        Dim chkColumn As UltraGridColumn = e.Layout.Bands(0).Columns.Add("chkCol", "Chk")
        chkColumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        chkColumn.CellActivation = Activation.AllowEdit
        chkColumn.Header.VisiblePosition = 1
    End Sub
    Private Sub grdDataMain_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles grdDataMain.InitializeRow
        If e.Row.Band.Index = 0 Then
            For Each col In e.Row.Band.Columns
                If col.Key <> "Año" And col.Key <> "Per_Ini" And col.Key <> "Per_Fin" And col.Key <> "id_liq" And col.Key <> "num_Rec" Then
                    col.Format = "#,##0.00"
                End If
                col.CellAppearance.TextHAlign = HAlign.Center
            Next col
        End If

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).Header.VisiblePosition = 2
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).Header.Caption = "INICIO"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).Header.VisiblePosition = 3
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).Header.Caption = "FINAL"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).Header.VisiblePosition = 4
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).Header.Caption = "BASE GRAVABLE"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).Header.VisiblePosition = 5
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).Header.Caption = "IMPORTE"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).Header.VisiblePosition = 6
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).Header.Caption = "ACTUALIZACIÓN"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).Header.VisiblePosition = 7
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Header.Caption = "SANEAMIENTO"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Header.VisiblePosition = 8
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Header.Caption = "IVA"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Header.VisiblePosition = 9
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Header.Caption = "RECARGOS"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Header.VisiblePosition = 10
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Header.Caption = "MULTA"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Header.VisiblePosition = 11
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).Header.Caption = "GASTOS"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).Header.VisiblePosition = 12
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).Header.Caption = "SUB IMP"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).Header.VisiblePosition = 13
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).Header.Caption = "SUB REC"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).Header.VisiblePosition = 14
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(13).Header.Caption = "SUB MUL"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(13).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(13).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(13).Header.VisiblePosition = 15
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(14).Header.Caption = "SUB GST"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(14).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(14).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(14).Header.VisiblePosition = 16
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(15).Header.Caption = "TOTAL"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(15).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(15).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(15).Header.VisiblePosition = 17

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(16).Hidden = True
        'Me.grdDataMain.DisplayLayout.Bands(0).Columns(17).Hidden = True

    End Sub
    Private Sub grdDataMain_CellChange(sender As Object, e As CellEventArgs) Handles grdDataMain.CellChange
        Dim strToPeriodo As String = ""
        If e.Cell.Column.Key = "chkCol" Then
            Total = 0
            For Each row As UltraGridRow In Me.grdDataMain.Rows
                If e.Cell.Row.Index >= row.Index Then
                    row.Cells("chkCol").Value = True
                    row.Cells("chkCol").IgnoreRowColActivation = True
                    Total = Total + row.Cells("Total").Value
                    row.Selected = True
                Else
                    row.Cells("chkCol").Value = False
                    row.Cells("chkCol").IgnoreRowColActivation = True
                End If
            Next
        End If

        Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
        SelectedRow = e.Cell.Row.Index
    End Sub

    Private Sub grdDataMain_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdDataMain.BeforeCellActivate
        Me.grdDataMain.ActiveRow.Cells("chkCol").IgnoreRowColActivation = True
    End Sub

    Private Sub grdDataMain_BeforeRowDeactivate(sender As Object, e As CancelEventArgs) Handles grdDataMain.BeforeRowDeactivate
        Me.grdDataMain.ActiveRow.Cells("chkCol").IgnoreRowColActivation = False
    End Sub

    Private Sub txtRfc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRfc.KeyPress
#Region "valida rfc"
        If Char.IsLetterOrDigit(e.KeyChar) Then
            Dim Posicion As Integer = txtRfc.SelectionStart + 1
            If Posicion >= 1 Or Posicion <= 3 Then
                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            If Posicion = 4 Then
                If Char.IsLetterOrDigit(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            'si es numero es persona moral
            If Posicion >= 5 Then
                Dim pm As Boolean = False
                Dim pf As Boolean = False
                If Char.IsDigit(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona moral
                    pm = True
                End If

                If Char.IsLetter(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona fisica
                    pf = True
                End If
                If Char.IsDigit(e.KeyChar) = True Then
                    If pf = True Then
                        If Posicion >= 5 And Posicion <= 10 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If
                    If pm = True Then
                        If Posicion >= 5 And Posicion <= 9 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If

                Else
                    e.Handled = True
                End If
                'valida resto de la cadena
                If Posicion > 9 And Posicion <= 12 And pm = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
                If Posicion > 10 And Posicion <= 13 And pf = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        Else
            e.Handled = True
        End If

        If e.KeyChar = vbBack Then
            e.Handled = False
        End If
#End Region
    End Sub
End Class