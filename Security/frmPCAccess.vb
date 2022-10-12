Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmPCAccess
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private Sub frmPCAccess_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblCurrentMenu.Text = Me.Text
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        cxn.Get_SQL_DataGrid("select idReg as Id,Allowed as Autorizar,WebAccess as WEB,UserId,PCName,IpAddress,WindowsUser,MacAddress,UltimoIngreso,
                                    FechaRegistro,FechaAutorizacion,FechaBaja
                            from tbl_PCAccess ", Me.grdDataMain)
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).CellClickAction = CellClickAction.EditAndSelectText
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmPCAccess_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            For Each row In Me.grdDataMain.Rows
                Dim baja As Int16 = IIf(row.Cells(1).Text = "True", 0, 1)
                cxn.Select_SQL(" update tbl_PCAccess set Allowed=" & IIf(baja = 1, 0, 1) & ",
                                               FechaAutorizacion = " & IIf(baja = 1, "null", "dbo.getdateMx()") &
                                "                  ,FechaBaja = " & IIf(baja = 1, "dbo.getdateMx()", " null ") &
                                " where idReg=" & row.Cells(0).Value)
            Next
            frmPCAccess_Load(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub
End Class