Imports System.ComponentModel
Imports System.Web.Services.Description
Imports Infragistics.Documents.Reports.Report
Imports Infragistics.Win
Imports Infragistics.Win.SupportDialogs.ConditionalFormatting
Imports Infragistics.Win.UltraWinGrid
Imports TCMAdmin.dsCatalogosTableAdapters

Public Class frmLiqAgua
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
    Private Sub frmLiqAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnImprimir.Visible = False
        Me.btnPagar.Visible = False
        Me.grdDataMain.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        Me.optFormaPago.Value = 2
        Me.lblTotal.Visible = False
        Me.lblPeriodo.Visible = False
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Dim cxn As New cxnData
        Me.lblTotal.Visible = False
        Me.lblPeriodo.Visible = False
        'Me.grdDataMain = Nothing
        Me.txtNombre.Text = ""
        Me.txtDomicilio.Text = ""
        Me.grdDataMain.DataSource = Nothing
        Me.btnImprimir.Visible = False
        Me.btnPagar.Visible = False
        Me.uneUltAnio.Text = 0
        Me.uneUltMes.Text = 0
        Me.txtUltLect.Text = 0
        NumCuenta = ""
        cxn.Select_SQL("select Nombre,Domicilio,ult_año_pago,ult_mes_pago, 
                                 case when year(dbo.getdateMx()) - ult_año_pago <=0 and        
                                            month(dbo.getdateMx())-ult_mes_pago <=0 then 'Sin Adeudo'
                                        else 'Con Adeudo' end Aduedo, ult_Lectura
                        from arc_agua 
                        where num_cuenta='" & Me.txtCuenta.Text.Trim & "'")
        If cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
            Me.txtNombre.Text = cxn.arrayValores(0)
            Me.txtDomicilio.Text = cxn.arrayValores(1)
            Me.uneUltAnio.Text = cxn.arrayValores(2)
            Me.uneUltMes.Text = cxn.arrayValores(3)
            Me.txtUltLect.Text = cxn.arrayValores(5)
            If cxn.arrayValores(4) = "Sin Adeudo" Then
                cMensajes.DisplayMessage(Me, "La cuenta no tiene adeudos fiscales registrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.btnImprimir.Visible = False
                Me.btnPagar.Visible = False
            Else
                cxn.Get_SQL_DataGrid("Exec Calcula_Agua '" & Me.txtCuenta.Text.Trim & "'," & Me.optFormaPago.Value.Trim, Me.grdDataMain)
                Me.btnImprimir.Visible = True
                Me.btnPagar.Visible = True
                Total = 0
                For Each row As UltraGridRow In Me.grdDataMain.Rows
                    row.Cells("chkCol").Value = True
                    Total = Total + row.Cells("Total").Value
                    Dim dateSplit1 As String() = Split(Me.grdDataMain.Rows(0).Cells(1).Value, "-")
                    Dim dateSplit2 As String() = Split(Me.grdDataMain.Rows(row.Index).Cells(2).Value, "-")
                    Me.lblPeriodo.Text = "De " & MonthName(dateSplit1(0), True).ToUpper & " " & dateSplit1(1) & " a " &
                                                MonthName(dateSplit2(0), True).ToUpper & " " & dateSplit2(1)
                    Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
                    Me.lblTotal.Visible = True
                    Me.lblPeriodo.Visible = True
                    NumCuenta = Me.txtCuenta.Text
                    row.Selected = True
                    SelectedRow = row.Index
                Next
            End If
        ElseIf cxn.err <> "" Then
            cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Else
            cMensajes.DisplayMessage(Me, "No se encontró la cuenta" & vbCrLf & "Verifique...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

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
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(17).Hidden = True

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
        Dim dateSplit1 As String() = Split(Me.grdDataMain.Rows(0).Cells(1).Value, "-")
        Dim dateSplit2 As String() = Split(Me.grdDataMain.Rows(e.Cell.Row.Index).Cells(2).Value, "-")
        Me.lblPeriodo.Text = "De " & MonthName(dateSplit1(0), True).ToUpper & " " & dateSplit1(1) & " a " &
                                                MonthName(dateSplit2(0), True).ToUpper & " " & dateSplit2(1)
        Me.lblTotal.Text = "Total a Pagar: " & FormatCurrency(Total, , , TriState.True, TriState.True)
        SelectedRow = e.Cell.Row.Index
    End Sub

    Private Sub grdDataMain_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdDataMain.BeforeCellActivate
        Me.grdDataMain.ActiveRow.Cells("chkCol").IgnoreRowColActivation = True
    End Sub

    Private Sub grdDataMain_BeforeRowDeactivate(sender As Object, e As CancelEventArgs) Handles grdDataMain.BeforeRowDeactivate
        Me.grdDataMain.ActiveRow.Cells("chkCol").IgnoreRowColActivation = False
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim frmPago As New frmConfirmaPago
        frmPago.Total = "Total a Pagar: " & vbCrLf & FormatCurrency(Total, , , TriState.True, TriState.True)
        Dim dateSplit1 As String() = Split(Me.grdDataMain.Rows(0).Cells(1).Value, "-")
        Dim dateSplit2 As String() = Split(Me.grdDataMain.Rows(SelectedRow).Cells(1).Value, "-")
        frmPago.Periodos = "De " & MonthName(dateSplit1(0), True).ToUpper & " " & dateSplit1(1) & " a " &
                               MonthName(dateSplit2(0), True).ToUpper & " " & dateSplit2(1)
        frmPago.NLiq = Me.grdDataMain.Rows(SelectedRow).Cells(16).Value
        frmPago.NRec = Me.grdDataMain.Rows(SelectedRow).Cells(17).Value
        frmPago.NumCuenta = "Cuenta: " & Me.NumCuenta
        frmPago.StartPosition = FormStartPosition.CenterScreen
        frmPago.TipoPago = Me.optFormaPago.Value
        DialogForm1(frmPago, Me.ParentForm)
        btnBusca_Click(Nothing, Nothing)
    End Sub



    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If Me.grdDataMain.Rows.Count > 0 Then
            Dim rpt As New frmGenerarReporte
            Dim rptLiqAgua As New RptPagos
            Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()
            Dim cxn As New cxnData
            cxn.Select_SQL("exec Rpt_Liq_Web " & Me.grdDataMain.Rows(SelectedRow).Cells(16).Value & "," & Me.grdDataMain.Rows(SelectedRow).Cells(17).Value)
            builder.ConnectionString = cxn.SqlPubsConnString
            Dim rptServer As String = TryCast(builder("Data Source"), String)
            Dim rptDB As String = TryCast(builder("Initial Catalog"), String)
            Dim rptUsr As String = TryCast(builder("User ID"), String)
            Dim rptPsw As String = TryCast(builder("Password"), String)
            rptLiqAgua.SetDatabaseLogon(rptUsr, rptPsw, rptServer, rptDB)
            rptLiqAgua.VerifyDatabase()
            Me.Datos_mpioTableAdapter1.Fill(Me.DsPagos1.datos_mpio)
            Me.Tab_det_liquidacionesTableAdapter1.FillByIdLiq(Me.DsPagos1.tab_det_liquidaciones,
                                                              Me.grdDataMain.Rows(SelectedRow).Cells(16).Value,
                                                              Me.grdDataMain.Rows(SelectedRow).Cells(17).Value)
            Me.Tab_liquidacionesTableAdapter1.FillByidLiq(Me.DsPagos1.tab_liquidaciones, Me.grdDataMain.Rows(SelectedRow).Cells(16).Value)
            rptLiqAgua.SetDataSource(DsPagos1)
            rpt.CrystalReportViewer1.ReportSource = rptLiqAgua
            rpt.CrystalReportViewer1.ShowGroupTreeButton = False
            Dim frmReporte As New Form
            With frmReporte
                .Height = Me.Height
                .Width = Me.Width
                .Controls.Add(rpt.CrystalReportViewer1)
                .Text = Me.Text
            End With
            DialogForm1(frmReporte, Me.ParentForm)
        Else
            cMensajes.DisplayMessage(Me, "No hay datos para imprimir ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmliqAgua_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
End Class