Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.Touch
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class RptPadronContribuyentes
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private TipoLiciencia As String = ""
    Private CuentaIngreso As String = ""
    Private Sub RptPadronContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.PropiedadesTableAdapter.Fill(Me.DsPredial.Propiedades)
        GridPredial.DataSource = Me.DsGridTableAdapter.GetData()
    End Sub

    Private Sub TsbExportarPredial_Click(sender As Object, e As EventArgs) Handles TsbExportarPredial.Click
        GeneraExcel(GridPredial, Me)
    End Sub

    Private Sub TsbExportarLicencias_Click(sender As Object, e As EventArgs) Handles TsbExportarLicencias.Click
        GeneraExcel(GridLicencias, Me)
    End Sub

    Private Sub TsbExportarAgua_Click(sender As Object, e As EventArgs) Handles TsbExportarAgua.Click
        GeneraExcel(GridAgua, Me)
    End Sub

    Private Sub TabReportesContribuyente_SelectedTabChanged(sender As Object, e As SelectedTabChangedEventArgs) Handles TabReportesContribuyente.SelectedTabChanged
        Try
            Select Case TabReportesContribuyente.SelectedTab.Key
                Case "TabPredial"
                    GridPredial.DataSource = Me.PropiedadesTableAdapter.GetData()
                Case "TabLicencias"
                    Me.CmbTipoLicencia.SelectedIndex = 0
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("LA")
                    CuentaIngreso = "021101"
                Case "TabAgua"
                    GridAgua.DataSource = Me.AguaTableAdapter.GetData
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CmbTipoLicencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoLicencia.SelectedIndexChanged
        Try
            Select Case Me.CmbTipoLicencia.SelectedIndex
                Case 0
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("LA")
                    TipoLiciencia = "LA"
                    CuentaIngreso = "021101"
                Case 1
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PC")
                    TipoLiciencia = "PC"
                    CuentaIngreso = "020401"
                Case 2
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("LC")
                    TipoLiciencia = "LC"
                    CuentaIngreso = "020301"
                Case 3
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PM")
                    TipoLiciencia = "PM"
                    CuentaIngreso = "010501"
                Case 4
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PE")
                    TipoLiciencia = "PE"
                    CuentaIngreso = "020901"
                Case 5
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PA")
                    TipoLiciencia = "PA"
                    CuentaIngreso = "010401"
                Case 6
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PP")
                    TipoLiciencia = "PP"
                    CuentaIngreso = "020801"
            End Select
            GridLicencias.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub TsbImprimirPredial_Click(sender As Object, e As EventArgs) Handles TsbImprimirPredial.Click
        Dim Formulario As New frmGenerarReporte
        Me.Cursor = Cursors.WaitCursor

        If optTipoReporte.Value = 0 Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de reporte", vbYes, vbExclamation, vbYes)
            Exit Sub
        End If
        Select Case optTipoReporte.Text
            Case Is = "Padrón General"
                Dim Rpt As New PadronPredialGeneral
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.PropiedadesTableAdapter.Fill(Me.DsPredial.Propiedades)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN GENERAL DE CONTRIBUYENTES DEL IMPUESTO PREDIAL")
            Case Is = "Contribuyentes Cumplidos"
                Dim Rpt As New PadronPredialGeneral
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.PropiedadesTableAdapter.FillByCorriente(Me.DsPredial.Propiedades)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE CONTRIBUYENTES AL CORRIENTE DE PAGO DEL IMPUESTO PREDIAL")
            Case Is = "Contribuyentes en Rezago"
                Dim Rpt As New PadronPredialGeneral
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.PropiedadesTableAdapter.FillByRezago(Me.DsPredial.Propiedades)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE CONTRIBUYENTES EN REZAGO DEL IMPUESTO PREDIAL")
            Case Is = "Histórico de Valores Catastrales"
                Dim Rpt As New RptValoresCatastrales
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.PropiedadesTableAdapter.FillByValCatastrales(Me.DsPredial.Propiedades, Me.txtcveCatastral.Text)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "COMPORTAMIENTO HISTÓRICO DE LOS VALORES CATASTRALES")
            Case Is = "Histórico de Pagos"
                Dim Rpt As New RptHistoricoPagos
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.PropiedadesTableAdapter.FillByCveCatastral(Me.DsPredial.Propiedades, Me.txtcveCatastral.Text)
                Me.HistoricoDePagosTableAdapter.Fill(Me.DsPredial.HistoricoDePagos, Me.txtcveCatastral.Text)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "COMPORTAMIENTO HISTÓRICO DE PAGOS DEL IMPUESTO PREDIAL")
        End Select

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TsbImprimirLicencias_Click(sender As Object, e As EventArgs) Handles TsbImprimirLicencias.Click
        Dim Formulario As New frmGenerarReporte
        Me.Cursor = Cursors.WaitCursor

        If OpcTipReporte.Value = 0 Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de reporte", vbYes, vbExclamation, vbYes)
            Exit Sub
        End If

        Select Case OpcTipReporte.Text
            Case Is = "Padrón General"
                Dim Rpt As New RptPadronLicencias
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, TipoLiciencia)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE LICENCIAS")

            Case Is = "Contribuyentes Cumplidos"
                Dim Rpt As New RptPadronLicencias
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.LicenciasTableAdapter.FillByCumplidos(Me.DsPredial.Licencias, TipoLiciencia)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE LICENCIAS - CONTRIBUYENTES CUMPLIDOS")

            Case Is = "Contribuyentes en Rezago"
                Dim Rpt As New RptPadronLicencias
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.LicenciasTableAdapter.FillByRezago(Me.DsPredial.Licencias, TipoLiciencia)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE LICENCIAS - CONTRIBUYENTES EN REZAGO")
            Case Is = "Histórico de Pagos"
                Dim Rpt As New RptPagosLicencias
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.LicenciasTableAdapter.FillByCveLicencia(Me.DsPredial.Licencias, Me.TxtCveLIcencia.Text)
                Me.HistoricoDePagosTableAdapter.FillByLicencias(Me.DsPredial.HistoricoDePagos, Me.TxtCveLIcencia.Text, CuentaIngreso)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "COMPORTAMIENTO HISTÓRICO DE PAGOS DEL ESTABLECIMIENTO")
        End Select
        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TsbImprimirAgua_Click(sender As Object, e As EventArgs) Handles TsbImprimirAgua.Click
        Dim Formulario As New frmGenerarReporte
        Me.Cursor = Cursors.WaitCursor

        If OpcTipoReporteAgua.Value = 0 Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de reporte", vbYes, vbExclamation, vbYes)
            Exit Sub
        End If
        Select Case OpcTipoReporteAgua.Text
            Case Is = "Padrón General"
                Dim Rpt As New RptPadronAgua
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.AguaTableAdapter.Fill(Me.DsPredial.Agua)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "PADRÓN DE USUARIOS DEL SERVICIO DE AGUA POTABLE")
            Case Is = "Usuarios Cumplidos"
                Dim Rpt As New RptPadronAgua
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.AguaTableAdapter.FillByCorriente(Me.DsPredial.Agua)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "USUARIOS DEL SERVICIO DE AGUA POTABLE AL CORRIENTE EN SUS PAGOS")
            Case Is = "Usuarios en Rezago"
                Dim Rpt As New RptPadronAgua
                Me.Datos_mpioTableAdapter.Fill(Me.DsPredial.datos_mpio)
                Me.AguaTableAdapter.FillByRezago(Me.DsPredial.Agua)
                Rpt.SetDataSource(DsPredial)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("TitReporte", "USUARIOS DEL SERVICIO DE AGUA POTABLE CON ADEUDO EN SUS PAGOS")
        End Select

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub optTipoReporte_ValueChanged(sender As Object, e As EventArgs) Handles optTipoReporte.ValueChanged
        gruClave.Visible = False
        If optTipoReporte.Text = "Histórico de Valores Catastrales" Or optTipoReporte.Text = "Histórico de Pagos" Then
            gruClave.Visible = True
        End If
    End Sub
    'Private Sub griCat_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griCat.DoubleClickRow
    Private Sub GridPredial_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles GridPredial.DoubleClickRow
        If optTipoReporte.Text = "Histórico de Valores Catastrales" Or optTipoReporte.Text = "Histórico de Pagos" Then
            Me.txtcveCatastral.Text = e.Row.Cells("Clave Catastral").Value
        End If
    End Sub
    Private Sub GridLicencias_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles GridLicencias.DoubleClickRow
        If OpcTipReporte.Text = "Histórico de Pagos" Then
            Me.TxtCveLIcencia.Text = e.Row.Cells("Clave").Value
            'Me.TxtCveLIcencia.Text = e.Row.Cells.Item(0)
        End If
    End Sub

    Private Sub OpcTipReporte_ValueChanged(sender As Object, e As EventArgs) Handles OpcTipReporte.ValueChanged
        GruClaveLicencia.Visible = False
        If OpcTipReporte.Text = "Histórico de Pagos" Then
            GruClaveLicencia.Visible = True
        End If
    End Sub
    Private Sub OpcTipReporteAgua_ValueChanged(sender As Object, e As EventArgs) Handles OpcTipoReporteAgua.ValueChanged
        GruNumCuenta.Visible = False
        If OpcTipoReporteAgua.Text = "Histórico de Pagos" Or OpcTipoReporteAgua.Text = "Histórico de Movimientos" Or OpcTipoReporteAgua.Text = "Histórico de Consumos" Then
            GruNumCuenta.Visible = True
        End If
    End Sub

    Private Sub SalirPredial_Click(sender As Object, e As EventArgs) Handles SalirPredial.Click
        GenericCloseChlildForm(Me)
    End Sub
End Class