Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmRegistroEspecial
    Public id As String = "1"
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
    Private Sub UltraGrid1_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        Dim Layout As UltraGridLayout = e.Layout
        Dim ov As UltraGridOverride = Layout.Override
        ov.RowSizing = RowSizing.AutoFree
    End Sub

    Private Sub grdDataMain_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles grdDataMain.InitializeRow
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Hidden = True
    End Sub

    Private Sub frmRegistroMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grdDataMain.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click

        If Me.txtCuenta.Text.Length = 8 Then
            Dim cxn As New cxnData
            If cxn.Select_SQL("select num_cuenta from arc_agua where num_cuenta = '" & Me.txtCuenta.Text & "'") Then
                If cxn.arrayValores(0) IsNot Nothing AndAlso Me.txtCuenta.Text = cxn.arrayValores(0) Then
                    cxn.Get_SQL_DataGrid("select Año,Bimestre,Consumo_bim as Consumo,Lect_Act Actual, Lect_Ant Anterior, 
                                                fec_Captura Captura, IdConsumo, num_cuenta
                                          from tbl_consumo_agua where num_cuenta='" & Me.txtCuenta.Text & "' 
                                          order by 1 desc,2 desc ", Me.grdDataMain)
                End If
            Else
                cMensajes.DisplayMessage(Me, "Verifique la cuenta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            cMensajes.DisplayMessage(Me, "Verifique la cuenta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            gridexcel = Me.grdDataMain
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            cMensajes.DisplayMessage(Me, "Datos exportados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    End With
                Else
                    cMensajes.DisplayMessage(Me, "No existen registros a exportar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                cMensajes.DisplayMessage(Me, "No existen registros a exportar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmReg As New frmAguaRegistroConsumo_Alta
        frmReg.id = "0"
        frmReg.txtNumeroCuenta.Text = Me.grdDataMain.ActiveRow.Cells(7).Text
        DialogForm1(frmReg, Me.ParentForm)
        btnBusca_Click(Nothing, Nothing)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frmReg As New frmAguaRegistroConsumo_Alta
        frmReg.id = Me.grdDataMain.ActiveRow.Cells(6).Text
        DialogForm1(frmReg, Me.ParentForm)
        btnBusca_Click(Nothing, Nothing)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmRegistroEspecial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
End Class