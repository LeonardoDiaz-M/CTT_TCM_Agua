Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmGenerarReporte
    Private Sub frmGenerarReporte_Load(sender As Object, e As EventArgs) Handles Me.Load
        configureCrystalReports()
    End Sub
    Private Sub configureCrystalReports()
        Try
            Dim cxn As New cxnData
            Dim builder As System.Data.Common.DbConnectionStringBuilder = New System.Data.Common.DbConnectionStringBuilder()
            builder.ConnectionString = cxn.SqlPubsConnString
            Dim server As String = TryCast(builder("Data Source"), String)
            Dim database As String = TryCast(builder("Initial Catalog"), String)
            Dim UserID As String = TryCast(builder("User ID"), String)
            Dim password As String = TryCast(builder("Password"), String)

            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = server
            myConnectionInfo.DatabaseName = database
            myConnectionInfo.UserID = UserID
            myConnectionInfo.Password = password
            myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
            myConnectionInfo.IntegratedSecurity = False
            setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()
        mytableloginfos = CrystalReportViewer1.LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next
    End Sub
End Class