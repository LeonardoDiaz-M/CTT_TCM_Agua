Imports System.ComponentModel
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports GMap.NET
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmConvenios
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
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.optFormaPago.Value = 1
        Me.txtCuenta.Focus()
    End Sub


    Private Sub grdDataMain_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdDataMain.AfterCellUpdate
        Try
            If e.Cell.Column.ToString <> "Total" And e.Cell.Column.ToString <> "Per_Ini" And e.Cell.Column.ToString <> "Per_Fin" Then
                Total = 0
                For Each row As UltraGridRow In Me.grdDataMain.Rows
                    'row.Cells("chkCol").Value = True
                    row.Cells("Total").Value = 0
                    row.Cells("Total").Value = row.Cells("Importe").Value +
                                               row.Cells("Actualizacion").Value +
                                               row.Cells("Saneamiento").Value +
                                               row.Cells("Recargos").Value +
                                               row.Cells("Multas").Value +
                                               row.Cells("Gastos").Value
                    Total = Total + row.Cells("Total").Value
                    Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
                    Me.lblTotal.Visible = True
                    NumLiq = row.Cells("id_Liq").Value
                    NumRec = row.Cells("num_rec").Value
                    row.Selected = True
                    SelectedRow = row.Index
                Next
                If Total > 0 Then
                    Me.btnPagar.Enabled = True
                Else
                    Me.btnPagar.Enabled = False
                End If
            ElseIf e.Cell.Column.ToString = "Per_Ini" Then
                If Not (e.Cell.Value >= 1 And e.Cell.Value <= 12) Then
                    e.Cell.Value = 12
                    cMensajes.DisplayMessage(Me, "El número digitado debe ser un Mes del 1 al 12 ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    e.Cell.CancelUpdate()
                    Me.btnPagar.Enabled = False
                End If
            ElseIf e.Cell.Column.ToString = "Per_Fin" Then
                If Not (e.Cell.Value >= 1 And e.Cell.Value <= 12) Then
                    cMensajes.DisplayMessage(Me, "El número digitado debe ser un Mes del 1 al 12 ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    e.Cell.Value = 12
                    e.Cell.CancelUpdate()
                    Me.btnPagar.Enabled = False
                End If
            End If
            For Each row As UltraGridRow In Me.grdDataMain.Rows
                If CInt(row.Cells("Per_Ini").Value) > CInt(row.Cells("Per_Fin").Value) Then
                    cMensajes.DisplayMessage(Me, "El Periodo Inicial debe ser menor que el Final ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.btnPagar.Enabled = False
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            For Each row As UltraGridRow In Me.grdDataMain.Rows
                If CInt(row.Cells("Per_Ini").Value) > CInt(row.Cells("Per_Fin").Value) Then
                    cMensajes.DisplayMessage(Me, "El Periodo Inicial debe ser menor que el Final ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.btnPagar.Enabled = False
                    Exit Sub
                End If
                Total = Total + row.Cells("Total").Value
            Next
            If Total <= 0 Then
                cMensajes.DisplayMessage(Me, "El Total debe ser mayor que cero ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.btnPagar.Enabled = False
                Exit Sub
            End If
            Dim cxn1 As New cxnData
            If cxn1.Get_SQL_DataGrid("exec PagoConveniosDiferencias '" & Me.txtCuenta.Text &
                                                                "','2" & ' Solo para agua
                                                                "','" & Me.optFormaPago.Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Importe").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Actualizacion").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Saneamiento").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Recargos").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Multas").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Gastos").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Per_Ini").Value &
                                                                "','" & Me.grdDataMain.Rows(0).Cells("Per_Fin").Value &
                                                                "','" & Me.txtObservaciones.Text & "'", Me.grdDataMain) Then
                If Me.grdDataMain.Rows(0).Cells("id_Liq").Value <= 0 Then
                    cMensajes.DisplayMessage(Me, "No se pudo generar la liquidación, verifique la información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.btnPagar.Enabled = True
                Else
                    Total = 0
                    For Each row As UltraGridRow In Me.grdDataMain.Rows
                        'row.Cells("chkCol").Value = True
                        Total = Total + row.Cells("Total").Value
                        Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
                        Me.lblTotal.Visible = True
                        NumLiq = row.Cells("id_Liq").Value
                        NumRec = row.Cells("num_rec").Value
                        row.Selected = True
                        SelectedRow = row.Index
                    Next

                    Dim frmPago As New frmConfirmaPago
                    frmPago.Total = "Total a Pagar: " & vbCrLf & FormatCurrency(Total, , , TriState.True, TriState.True)
                    frmPago.NLiq = NumLiq
                    frmPago.NRec = NumRec
                    frmPago.NumCuenta = "Pago de Convenios y Diferencias"
                    frmPago.Periodos = Me.optFormaPago.Text
                    frmPago.StartPosition = FormStartPosition.CenterScreen
                    DialogForm1(frmPago, Me.ParentForm)
                    Me.btnPagar.Enabled = False
                    btnBusca_Click(Nothing, Nothing)
                End If
            Else
                cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) 'Handles grdDataMain.InitializeLayout
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
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).Header.VisiblePosition = 3

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).Header.Caption = "FINAL"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).Header.VisiblePosition = 4

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).Header.Caption = "IMPORTE"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).Header.VisiblePosition = 5

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).Header.Caption = "ACTUALIZACIÓN"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).Header.VisiblePosition = 6

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).Header.Caption = "SANEAMIENTO"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(5).Header.VisiblePosition = 7

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Header.Caption = "RECARGOS"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Header.VisiblePosition = 8

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Header.Caption = "MULTA"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Header.VisiblePosition = 9

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Header.Caption = "GASTOS"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).CellActivation = Activation.AllowEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Header.VisiblePosition = 10

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Header.Caption = "TOTAL"
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).CellActivation = Activation.NoEdit
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).CellActivation = Activation.Disabled
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Header.VisiblePosition = 11

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).Hidden = True
        'Me.grdDataMain.DisplayLayout.Bands(0).Columns(17).Hidden = True

    End Sub




    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Dim datosCont As New cxnData
        If datosCont.Select_SQL("select Nombre,domicilio_fiscal,ult_año_pago,ult_mes_pago, ult_lectura from arc_agua where num_cuenta='" & Me.txtCuenta.Text.Trim & "'") Then
            If datosCont.arrayValores(0) IsNot Nothing Then
                Me.txtNombre.Text = datosCont.arrayValores(0)
                Me.txtDomicilio.Text = datosCont.arrayValores(1)
                Me.uneUltMes.Text = datosCont.arrayValores(2)
                Me.uneUltAnio.Text = datosCont.arrayValores(3)
                Me.txtUltLect.Text = datosCont.arrayValores(4)
                datosCont.Get_SQL_DataGrid(" Select year(dbo.getdateMx()) Año, 1 Per_Ini, 12 Per_Fin, 
                                                    0.00 Importe, 00.00 Actualizacion, 0.00 Saneamiento, 0.00 Recargos, 
                                                    0.00 Multas, 0.00 Gastos,0.00 Total, 
                                                    0 id_Liq, 0 num_rec", Me.grdDataMain)
            Else
                cMensajes.DisplayMessage(Me, "La cuenta no existe, verifique...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtCuenta.SelectAll()
                Me.txtCuenta.Focus()
            End If
        Else
            cMensajes.DisplayMessage(Me, datosCont.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class