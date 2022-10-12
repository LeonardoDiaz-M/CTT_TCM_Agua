Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.Touch

Public Class frmReportes
    Private Const V As Integer = 0
    Private cxn As New cxnData
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Public ImagePath As String = Application.StartupPath & "\Logos\LogoMpio.jpg"
    Private rptServer As String = ""
    Private rptDB As String = ""
    Private rptUsr As String = ""
    Private rptPsw As String = ""

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Datos_mpioTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.Arc_tranTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.Datos_mpioTableAdapter1.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.FacturasTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.OficinasTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.View_arc_ingTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.View_arc_tranTableAdapter.Connection.ConnectionString = cxn.SqlPubsConnString
        Me.Datos_mpioTableAdapter.Fill(Me.DsReportes.datos_mpio)
        cxn.Select_SQL("SELECT nombre FROM datos_mpio")
        load_Combos()
        If cxn.arrayValores(0) IsNot Nothing Then
            Nombre_Municipio = cxn.arrayValores(0)
        End If
        cxn.Get_SQL_DataGrid("Select num_caja As Caja,fol_rec As Folio,Cve_Cuenta As Cuenta,Fec_pago As Fecha,Nombre,(importe+actualiza) as Importe, Recargos, Multas,
                                        Gast_ejec As Gastos, (sub_imp+sub_rec+sub_multas+sub_gastos) as Subsidio 
                                    from arc_tran where tip_tran='P' AND YEAR(FEC_PAGO)=2021", grdTransacciones)
        grdTransacciones.Refresh()
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Seleccion_Reporte()
        'Imprimir()
    End Sub

    Private Sub Seleccion_Reporte()
        Dim Formulario As New frmGenerarReporte
        Me.Cursor = Cursors.WaitCursor
        'MsgBox(optTipoReporte.Value)
        If optTipoReporte.Value = 0 Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de reporte", vbYes, vbExclamation, vbYes)
            Exit Sub
        End If
        Try
            Select Case optTipoReporte.Text.ToLowerInvariant
                Case Is = "diario de recaudación"
                    Dim Rpt As New DiarioDeRecaudacion
                    Rpt.SetDatabaseLogon(rptUsr, rptPsw, rptServer, rptDB)
                    Rpt.VerifyDatabase()
                    Me.OficinasTableAdapter.FillByOficina(Me.DsReportes.oficinas, "0101")
                    Me.View_arc_ingTableAdapter.FillDiarioRecaudacion(Me.DsReportes.view_arc_ing, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                    Rpt.SetParameterValue("LogoMpio", ImagePath)

                Case Is = "corte de caja"
                    Dim Rpt As New CorteDeCaja
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "listado de transacciones"
                    Dim Rpt As New ListadoDeTransacciones
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "recibos cancelados"
                    Dim Rpt As New RecibosCancelados
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepRecibosCancelados(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")

                Case Is = "pagos con subsidio"
                    Dim Rpt As New PagosConSubsidios
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepPagosConSubsidio(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "recibo / ingreso"
                    Dim Rpt As New ReciboIngreso
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepReciboIngreso(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "póliza de ingreso"
                    Dim Rpt As New PolizaIngreso
                    SetRptSQLConn(Rpt)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("@FechaInicial", Format(dtpFechaInicial.Value, "dd/MM/yyyy"))
                    Rpt.SetParameterValue("@FechaFinal", Format(dtpFechaFinal.Value, "dd/MM/yyyy"))
                Case Is = "arqueo de caja"
                    If ucoCajero.IsItemInList = True Then
                        Dim Rpt As New ArqueoCaja
                        SetRptSQLConn(Rpt)
                        Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                        Me.View_arc_tranTableAdapter.FillRepArqueoCaja(Me.DsReportes.view_arc_tran, "0101", ucoCajero.Value.ToString, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                        Rpt.SetDataSource(DsReportes)
                        Formulario.CrystalReportViewer1.ReportSource = Rpt
                        Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                        Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                        Rpt.SetParameterValue("Oficina", "0101")
                        Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                    Else
                        cMensajes.DisplayMessage(Me, "Seleccione un cajero!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ucoCajero.Focus()
                    End If
                Case Is = "ingreso por concepto"
                    If ucoConcepto.IsItemInList = True Then
                        Dim Rpt As New IngresoPorConcepto
                        SetRptSQLConn(Rpt)
                        Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                        Me.View_arc_tranTableAdapter.FillByRepConcepto(Me.DsReportes.view_arc_tran, ucoConcepto.Value, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                        Rpt.SetDataSource(DsReportes)
                        Formulario.CrystalReportViewer1.ReportSource = Rpt
                        Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                        Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                        Rpt.SetParameterValue("Concepto", ucoConcepto.Value)
                        Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                    Else
                        cMensajes.DisplayMessage(Me, "Seleccione un concepto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ucoConcepto.Focus()
                    End If



                Case Is = "depósito en bancos"


                Case Is = "auxiliar de ingreso por folios"
                    Dim Rpt As New AuxiliarDeIngresos
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "auxiliar de ingreso por periodo"
                    Dim Rpt As New AuxiliarDeIngresosPeriodo
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Case Is = "agua potable y drenaje"

                Case Is = "folio por caja"
                    Dim Rpt As New FoliosUtilizadosPorCaja
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Case Is = "concentrado por oficina"
                    Dim Rpt As New DiarioDeRecaudacion
                    SetRptSQLConn(Rpt)
                    Me.OficinasTableAdapter.FillByOficina(Me.DsReportes.oficinas, "0101")
                    Me.View_arc_ingTableAdapter.FillDiarioRecaudacion(Me.DsReportes.view_arc_ing, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Case Is = "ingreso por dependencia"
                    Dim Rpt As New IngresoPorDependencia
                    SetRptSQLConn(Rpt)
                    Me.View_arc_tranTableAdapter.FillByRepIngresosPorDependencia(Me.DsReportes.view_arc_tran, 1, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                'Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                'Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                'Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "concentrado por dependencia"
                    Dim Rpt As New ConcentradoServiciosPorDependencia
                    SetRptSQLConn(Rpt)
                    Dim cxn1 As New cxnData
                    Dim dt As DataTable
                    dt = cxn1.Get_SQL_Datatable("REPORTE_CONCENTRADO_POR_DEPENDENCIA'" & dtpFechaInicial.Value.ToString("yyyy-MM-dd") & "','" & dtpFechaFinal.Value.ToString("yyyy-MM-dd") & "'")
                    Rpt.SetDataSource(dt)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)

                Case Is = "movimientos por usuario"

                Case Is = "facturas mensuales generadas"
                    Dim Rpt As New FacturasEmitidas
                    SetRptSQLConn(Rpt)
                    Me.FacturasTableAdapter.Fill(Me.DsReportes.facturas, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Case Is = "reporte de ingresos de gestión"
                Case Is = "informe predial osfem"

                Case Is = "informe traslado osfem"
                    Dim Rpt As New TrasladoDeDominio
                    SetRptSQLConn(Rpt)
                    Me.Datos_mpioTableAdapter.Fill(DsReportes.datos_mpio)
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.Arc_tranTableAdapter.FillTrasladoDominio(Me.DsReportes.arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Case Is = "comparativo de ingresos propios por periodo"
                    Dim Rpt As New RptComparativoDeIngresos
                    SetRptSQLConn(Rpt)
                    'Me.Datos_mpioTableAdapter1.Fill(DsPredial.datos_mpio)
                    'Me.App_GeneraConcentradoTableAdapter.FillGeneraConcentrado(Me.DsPredial.App_GeneraConcentrado, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("@FechaInicial", Format(dtpFechaInicial.Value, "yyyy-MM-dd"))
                    Rpt.SetParameterValue("@FechaFinal", Format(dtpFechaFinal.Value, "yyyy-MM-dd"))
                'Rpt.SetParameterValue(0, dtpFechaInicial.Value.ToString("yyyy-MM-dd"))
                'Rpt.SetParameterValue(1, dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                'Rpt.Refresh()
                Case Is = "comparativo de transacciones por periodo"
                    Dim Rpt As New RptComparativoDeTransacciones
                    SetRptSQLConn(Rpt)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("@FechaInicial", Format(dtpFechaInicial.Value, "yyyy-MM-dd"))
                    Rpt.SetParameterValue("@FechaFinal", Format(dtpFechaFinal.Value, "yyyy-MM-dd"))

            End Select

            Dim frmReporte As New Form
            With frmReporte
                .Controls.Add(Formulario.CrystalReportViewer1)
                .Text = optTipoReporte.Text
                .Show()
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub
    Private Sub SetRptSQLConn(crReportDocument As ReportDocument)
        Try
            Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()
            builder.ConnectionString = cxn.SqlPubsConnString
            Me.rptServer = TryCast(builder("Data Source"), String)
            Me.rptDB = TryCast(builder("Initial Catalog"), String)
            Me.rptUsr = TryCast(builder("User ID"), String)
            Me.rptPsw = TryCast(builder("Password"), String)

            Dim tables As CrystalDecisions.CrystalReports.Engine.Tables = crReportDocument.Database.Tables

            For Each table As CrystalDecisions.CrystalReports.Engine.Table In tables
                Dim tableLogOnInfo As CrystalDecisions.Shared.TableLogOnInfo = table.LogOnInfo
                tableLogOnInfo.ConnectionInfo.ServerName = Me.rptServer
                tableLogOnInfo.ConnectionInfo.DatabaseName = Me.rptDB
                tableLogOnInfo.ConnectionInfo.UserID = Me.rptUsr
                tableLogOnInfo.ConnectionInfo.Password = Me.rptPsw
                table.ApplyLogOnInfo(tableLogOnInfo)
            Next
            crReportDocument.SetDatabaseLogon(rptUsr, rptPsw, rptServer, rptDB)
            crReportDocument.VerifyDatabase()
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical + vbOKOnly, "Error Report Log On")
        End Try
    End Sub
    Private Sub Imprimir()
        Me.Cursor = Cursors.WaitCursor
        Dim Rpt As New CorteDeCaja
        Dim Formulario As New frmGenerarReporte
        Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
        'Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0201", "0", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
        Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0201", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
        Rpt.SetDataSource(DsReportes)
        Formulario.CrystalReportViewer1.ReportSource = Rpt
        Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
        Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
        Rpt.SetParameterValue("Oficina", "0201")
        'Rpt.SetParameterValue("Cajero", "0")
        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = optTipoReporte.Text
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoConcepto, "SELECT cve_cuenta,nombre FROM cat_cuentas")
        cxn.fLlenaDropDownUltra(ucoCajero, "select proNumeroCaja,proNombres +' '+ proApellidoPaterno +' '+ proApellidoMaterno as Cajero   from Users_Profiles where proIdPuesto=2")
    End Sub

    Private Sub optTipoReporte_ValueChanged(sender As Object, e As EventArgs) Handles optTipoReporte.ValueChanged
        gruConcepto.Visible = False
        gruCajero.Visible = False
        gruReciboIngreso.Visible = False

        Select Case optTipoReporte.Text
            Case Is = "Arqueo de Caja"
                gruCajero.Visible = True
            Case Is = "Ingreso por Concepto"
                gruConcepto.Visible = True
            Case Is = "Recibo / Ingreso"
                gruReciboIngreso.Visible = True
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click
        GeneraExcel(grdTransacciones, Me)
    End Sub
End Class
