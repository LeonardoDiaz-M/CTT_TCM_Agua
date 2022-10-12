Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmRegistroPorCuenta
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
        Dim i As Int32
        For i = 0 To Me.grdDataMain.DisplayLayout.Bands(0).Columns.Count - 1
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.NoEdit
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.Disabled
            If i = 0 Then
                Me.grdDataMain.Rows(0).Cells(i).Appearance.BackColor = Color.WhiteSmoke
            End If
            If i >= 8 And i = 5 Then
                Me.grdDataMain.DisplayLayout.Bands(0).Columns(i).Hidden = True
            End If
        Next

        Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).Hidden = True
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(1).Header.VisiblePosition = 1
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(2).Header.VisiblePosition = 2
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(3).Header.VisiblePosition = 3
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(4).Header.VisiblePosition = 4
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(6).Header.VisiblePosition = 5
        Me.grdDataMain.DisplayLayout.Bands(0).Columns(7).Header.VisiblePosition = 6

    End Sub

    Private Sub frmRegistroMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblLectura.Visible = False
        Me.mskLectura.Visible = False
        Me.grdDataMain.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
        Me.lblConsumo.Text = ""
        Me.lblRegistro.Text = ""
        Me.btnProcesa.Enabled = False
        Me.optTipo.Value = 1
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Me.btnProcesa.Enabled = False
        If Me.optTipo.Value Is Nothing Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de Registro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.optTipo.Focus()
            Exit Sub
        End If
        If Me.txtCuenta.Text.Length = 8 Then
            Dim cxn As New cxnData
            If cxn.Select_SQL("select num_cuenta,tipo_servicio from arc_agua where num_cuenta = '" & Me.txtCuenta.Text & "'") Then
                If cxn.arrayValores(0) IsNot Nothing AndAlso Me.txtCuenta.Text = cxn.arrayValores(0) And cxn.arrayValores(1) = "1" Then
                    Dim lectura As String = IIf(Me.mskLectura.Text <> "", Me.mskLectura.Text, 0)
                    cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & ",-1,'" & Me.txtCuenta.Text & "'," & lectura & ",'" & CurrentUsrName & "',0", Me.grdDataMain)
                    If Me.grdDataMain.Rows.Count > 0 Then
                        Me.lblRegistro.Text = "Bimestre a registrar " & Me.grdDataMain.Rows(0).Cells(2).Text & " de " & Me.grdDataMain.Rows(0).Cells(1).Text

                        Select Case Me.optTipo.Value
                            Case 1
                                Me.lblConsumo.Text = "Lectura: " & Me.grdDataMain.Rows(0).Cells(5).Text & " Consumo: " & Me.grdDataMain.Rows(0).Cells(3).Text
                                If CDbl(Me.grdDataMain.Rows(0).Cells(3).Text) < 0 Then
                                    Me.lblConsumo.Appearance.BackColor = Color.Crimson
                                    Me.lblConsumo.Appearance.ForeColor = Color.White
                                Else
                                    Me.lblConsumo.Appearance.BackColor = Color.LightGreen
                                    Me.lblConsumo.Appearance.ForeColor = Color.DimGray
                                    Me.btnProcesa.Enabled = True
                                End If
                            Case 3
                                Me.lblConsumo.Text = "Promedio: " & Me.grdDataMain.Rows(0).Cells(11).Text & " Consumo: " & Me.grdDataMain.Rows(0).Cells(10).Text
                                Me.lblConsumo.Appearance.BackColor = Color.LightGreen
                                Me.lblConsumo.Appearance.ForeColor = Color.DimGray
                                Me.btnProcesa.Enabled = True
                            Case 2
                                Me.lblConsumo.Text = "Mínimo: " & Me.grdDataMain.Rows(0).Cells(9).Text & " Consumo: " & Me.grdDataMain.Rows(0).Cells(8).Text
                                Me.lblConsumo.Appearance.BackColor = Color.LightGreen
                                Me.lblConsumo.Appearance.ForeColor = Color.DimGray
                                Me.btnProcesa.Enabled = True
                        End Select
                        Me.grdDataMain.Rows(0).Hidden = True
                    End If
                ElseIf cxn.arrayValores(1) = "2" Then
                    cMensajes.DisplayMessage(Me, "La cuenta no es de tipo de servicio Medido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                cMensajes.DisplayMessage(Me, "Verifique la cuenta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            cMensajes.DisplayMessage(Me, "Verifique la cuenta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnProcesa_Click(sender As Object, e As EventArgs) Handles btnProcesa.Click
        Dim cxn As New cxnData
        If cxn.Select_SQL("select num_cuenta from arc_agua where num_cuenta = '" & Me.txtCuenta.Text & "'") Then
            If cxn.arrayValores(0) IsNot Nothing AndAlso Me.txtCuenta.Text = cxn.arrayValores(0) Then
                If Me.optTipo.Value = 1 Then
                    cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & ",-1,'" & Me.txtCuenta.Text & "'," & Me.mskLectura.Text & ",'" & CurrentUsrName & "',1", Me.grdDataMain)
                Else
                    cxn.Get_SQL_DataGrid("exec RegistroConsumo " & Me.optTipo.Value.ToString & ",-1,'" & Me.txtCuenta.Text & "',0,'" & CurrentUsrName & "',1", Me.grdDataMain)
                End If
                btnBusca_Click(Nothing, Nothing)
            End If
        Else
            cMensajes.DisplayMessage(Me, "Verifique la cuenta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
        Me.mskLectura.Clear()
        Me.btnProcesa.Enabled = False
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

    Private Sub optTipo_ValueChanged(sender As Object, e As EventArgs) Handles optTipo.ValueChanged
        If Me.optTipo.Value = 1 Then
            Me.lblLectura.Visible = True
            Me.mskLectura.Visible = True
        Else
            Me.lblLectura.Visible = False
            Me.mskLectura.Visible = False
        End If
        Me.mskLectura.Text = ""
        Me.btnProcesa.Enabled = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmRegistroPorCuenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
End Class