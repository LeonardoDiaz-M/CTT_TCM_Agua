Public Class frmConfirmaPago
    Public NumCuenta As String = ""
    Public Periodos As String = ""
    Public Total As String
    Public NLiq As Integer = 0
    Public NRec As Integer = 0
    Public TipoPago As Integer = 0

    Private Sub frmConfirmaPago_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lbCuenta.Text = Me.NumCuenta
        Me.lblPeriodos.Text = Me.Periodos
        Me.lblTot.Text = Me.Total
        Dim cxn As New cxnData
        cxn.fLlenaDropDownUltra(Me.cmbSatCta, "select cve_fma_pago,FormaPagoDesc from [dbo].[tbl_SAT_FmaPago]")
        Me.cmbSatCta.Value = "01"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim cxnPago As New cxnData
        Dim NumLiq As String = NLiq
        Dim NumRec As String = NRec
        Dim idOficina As String = ""
        Dim numCaja As String = ""
        cxnPago.Select_SQL("select o.comun, up.proNumeroCaja
                                    from Users_Profiles up
	                                    inner join Puestos p on p.pueId = up.proIdPuesto 
	                                    inner join oficinas o on o.comun = up.proIdOficina 
                            where proUserId = '" & CurrentUsrName & "'")
        idOficina = cxnPago.arrayValores(0)
        numCaja = cxnPago.arrayValores(1)
        Dim cxn As New cxnData
        cxn.Select_SQL("exec Rpt_Liq_Web " & Me.NLiq & "," & Me.NRec)
        If cxnPago.Gen_SQL("Exec [App_InsertaTransaccion] " & NumLiq & ",'" & numCaja & "','" & idOficina & "','" & Me.cmbSatCta.Value & "'") Then
            cMensajes.DisplayMessage(Me, "Pago Realizado !!" & vbCrLf, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            Dim rpt As New frmGenerarReporte
            Dim rptLiqAgua As New RptPagos
            Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()
            builder.ConnectionString = cxn.SqlPubsConnString
            Dim rptServer As String = TryCast(builder("Data Source"), String)
            Dim rptDB As String = TryCast(builder("Initial Catalog"), String)
            Dim rptUsr As String = TryCast(builder("User ID"), String)
            Dim rptPsw As String = TryCast(builder("Password"), String)
            rptLiqAgua.SetDatabaseLogon(rptUsr, rptPsw, rptServer, rptDB)
            rptLiqAgua.VerifyDatabase()
            Me.Datos_mpioTableAdapter1.Fill(Me.DsPagos1.datos_mpio)
            Me.Tab_det_liquidacionesTableAdapter1.FillByIdLiq(Me.DsPagos1.tab_det_liquidaciones, Me.NLiq, Me.NRec)
            Me.Tab_liquidacionesTableAdapter1.FillByidLiq(Me.DsPagos1.tab_liquidaciones, Me.NLiq)
            rptLiqAgua.SetDataSource(DsPagos1)
            rpt.CrystalReportViewer1.ReportSource = rptLiqAgua
            Dim frmReporte As New Form
            With frmReporte
                .Controls.Add(rpt.CrystalReportViewer1)
                .Text = Me.Text
                .Show()
            End With
            Me.Close()
        Else
            cMensajes.DisplayMessage(Me, "Error al procesar el pago" & vbCrLf & cxnPago.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.btnPago.Visible = False
        End If
    End Sub

End Class