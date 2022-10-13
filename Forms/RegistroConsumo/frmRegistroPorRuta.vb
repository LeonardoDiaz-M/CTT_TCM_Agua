Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmRegistroPorRuta
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
        e.Layout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste
    End Sub

    Private Sub grdDataMain_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles grdDataMain.InitializeRow

        If Me.optTipo.Value = 2 Then 'Cons Min
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).Hidden = True
            Me.btnProcesa.Enabled=True
        ElseIf Me.optTipo.Value = 3 Then 'Promedio
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).Hidden = True
            Me.btnProcesa.Enabled = True
        ElseIf Me.optTipo.Value = 1 Then
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(8).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(9).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(10).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(11).Hidden = True
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).Hidden = False
            For i As Int16 = 0 To 12
                If i = 12 Then
                    Me.grdDataMain.DisplayLayout.Bands(0).Columns(12).CellActivation = Activation.AllowEdit
                Else
                    Me.grdDataMain.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.NoEdit
                    Me.grdDataMain.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.Disabled
                End If
            Next
        End If
    End Sub

    Private Sub frmRegistroMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cxn As New cxnData
        cxn.fLlenaDropDownUltra(Me.cmbRuta, "Select * from rutas")
        Me.optTipo.Value = 1
        Me.btnProcesa.Enabled = False
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        If Me.cmbRuta.Value > 0 Then
            Dim cxn As New cxnData
            cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & "," & Me.cmbRuta.Value.ToString & ",'',0,'" & CurrentUsrName & "',0", Me.grdDataMain)
        Else
            cMensajes.DisplayMessage(Me, "Seleccione la Ruta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnProcesa_Click(sender As Object, e As EventArgs) Handles btnProcesa.Click
        Try
            If ConfirmaProceso(Me, "El proceso afectará todas las cuentas en la Ruta seleccionada" & vbCrLf & "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = "ok" Then
                Dim cxn As New cxnData
                If Me.optTipo.Value <> 1 Then
                    cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & "," & Me.cmbRuta.Value.ToString & ",'',0,'" & CurrentUsrName & "',1", Me.grdDataMain)
                Else
                    For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                        Dim grd As New UltraGrid
                        cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & ",-1,'" &
                                             Me.grdDataMain.Rows(i).Cells(0).Value & "', " &
                                             Me.grdDataMain.Rows(i).Cells(12).Value & ",'" &
                                             CurrentUsrName & "',1", grd)
                        grd = Nothing
                        MsgBox(i)
                    Next
                End If
                btnBusca_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub


    Public Function ConfirmaProceso(ByVal owner As IWin32Window, ByVal message As String,
                                      ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon,
                                      ByVal defaultButton As MessageBoxDefaultButton) As String
        Dim result As String = ""
        Using messageBoxInfo As New UltraMessageBoxInfo()
            messageBoxInfo.TextFormatted = message
            messageBoxInfo.Caption = Application.ProductName
            messageBoxInfo.Buttons = buttons
            messageBoxInfo.Icon = icon
            messageBoxInfo.DefaultButton = defaultButton
            messageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]
            messageBoxInfo.MaximumWidth = 400
            messageBoxInfo.MinimumWidth = 400
            messageBoxInfo.Owner = owner
            messageBoxInfo.Style = MessageBoxStyle.Vista
            messageBoxInfo.HeaderFormatted = "<i>Mensaje: </i>"
            messageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.False
            If message = "Object variable or With block variable not set." Then
                result = "-1"
            End If
            ' Create a HelpInfo object to hold the help data 
            Using helpData As New HelpInfo("", "")
                messageBoxInfo.HelpInfo = helpData
                If UltraMessageBoxManager.Show(messageBoxInfo) = DialogResult.Yes Then
                    result = "ok"
                Else
                    result = "-1"
                End If
            End Using
        End Using
        Return result
    End Function

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

    Private Sub grdDataMain_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdDataMain.AfterCellUpdate
        If Me.optTipo.Value = 1 Then
            If e.Cell.Value - Me.grdDataMain.Rows(e.Cell.Row.Index).Cells(5).Value > 1 Then
                e.Cell.Appearance.BackColor = Color.LightGreen
                e.Cell.Appearance.ForeColor = Color.Black
                Me.btnProcesa.Enabled = True
            Else
                e.Cell.Appearance.BackColor = Color.Red
                e.Cell.Appearance.ForeColor = Color.White
                Me.btnProcesa.Enabled = False
            End If
            For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                If Me.grdDataMain.Rows(i).Cells(12).Appearance.BackColor = Color.Red Then
                    Me.btnProcesa.Enabled = False
                    Exit For
                Else
                    Me.btnProcesa.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub grdDataMain_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdDataMain.ClickCell
        e.Cell.SelectAll()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmRegistroPorRuta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
End Class