Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class frmaguaRegistroConsumo
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myparent As Form = Nothing
    Dim Renglonfinal As Boolean = False
    Private m_comboBox As ComboBox
    Dim Renglon As Integer
    Dim Columna As Integer
    Dim ModificoLectura As Boolean = False
    Dim NumeroErrores As Integer = 0
    Private Sub frmaguaRegistroConsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.Forma_Calculo_Consumo_Agua
        ' Puede moverla o quitarla según sea necesario.
        'Me.Forma_Calculo_Consumo_AguaTableAdapter.Fill(Me.DsAgua.Forma_Calculo_Consumo_Agua)
        Me.lblCurrentMenu.Text = Me.Text
        load_Combos()
        optFormaPago.Value = 1
        cxn.Select_SQL("select year(dbo.getdateMx())")
        Dim actual_anio As Integer = cxn.arrayValores(0)
        txtanio.Value = actual_anio
        Me.AutoValidate = Windows.Forms.AutoValidate.EnableAllowFocusChange
    End Sub
    Private Sub griLecturasPeriodo_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles griLecturasPeriodo.InitializeRow
        Dim rowError As String = ""
        Dim cellError As String = ""
        Dim IdIncidencia As Object = e.Row.Cells("Id_Incidencia").Value
        Dim LecturaActual As Object = e.Row.Cells("lect_act").Value
        Dim LecturaAnterior As Object = e.Row.Cells("lect_ant").Value

        If IdIncidencia = 1 Then
            If LecturaActual <= LecturaAnterior Then
                rowError = "Error."
                cellError = "La lectura actual no puede ser igual o menor a la lectura anterior"
            End If
        End If
        If IdIncidencia = 2 Or IdIncidencia = 3 Then
            If LecturaActual <> LecturaAnterior Then
                rowError = "Error."
                cellError = "La lectura actual y la lectura anterior deben ser iguales"
            End If
        End If
        Dim drv As DataRowView = DirectCast(e.Row.ListObject, DataRowView)
        drv.Row.RowError = rowError
        drv.Row.SetColumnError("lect_act", cellError)

    End Sub
    Private Sub griLecturasPeriodo_KeyDown(sender As Object, e As KeyEventArgs) Handles griLecturasPeriodo.KeyDown
        ' rutina para mover el cursor
        Dim LecturaActual As Integer
        Dim LecturaAnterior As Integer
        Dim Consumo As Integer = 0
        Dim IdIncidencia As Integer
        Dim NumeroCuenta As String
        Dim aCell As UltraGridCell

        Select Case e.KeyValue
            Case Keys.Up
                griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                griLecturasPeriodo.PerformAction(UltraGridAction.AboveCell, False, False)
                e.Handled = True
                griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)

            Case Keys.Enter
                'activo la celda del grid en modo edicion
                griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                'obtengo la celda activa
                aCell = griLecturasPeriodo.ActiveCell
                'asigno a variables valores de celdas
                IdIncidencia = griLecturasPeriodo.ActiveRow.Cells("Id_Incidencia").Value
                NumeroCuenta = griLecturasPeriodo.ActiveRow.Cells("num_cuenta").Value
                LecturaAnterior = griLecturasPeriodo.ActiveRow.Cells("lect_ant").Value
                LecturaActual = griLecturasPeriodo.ActiveRow.Cells("lect_act").Value

                aCell = Me.griLecturasPeriodo.ActiveRow.Cells("lect_act")

                If IdIncidencia = 1 Then
                    If LecturaActual <= LecturaAnterior Then
                        cMensajes.DisplayMessage(Me, "La lectura actual no puede menor o igual a la lectura anterior!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        e.Handled = True
                        griLecturasPeriodo.ActiveCell = aCell
                        griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
                    Else
                        aCell = Me.griLecturasPeriodo.ActiveRow.Cells("consumo_bim")
                        Renglon = aCell.Row.Index + 1
                        LecturaActual = griLecturasPeriodo.ActiveRow.Cells("lect_act").Value
                        Consumo = LecturaActual - LecturaAnterior

                        griLecturasPeriodo.ActiveRow.Cells("consumo_bim").Value = Consumo
                        griLecturasPeriodo.ActiveRow.Cells("usuario").Value = CurrentUsrName

                        griLecturasPeriodo.Focus()
                        griLecturasPeriodo.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                        griLecturasPeriodo.ActiveCell.SelectAll()
                        ModificoLectura = True
                        'Me.griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode)
                        griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                        griLecturasPeriodo.PerformAction(UltraGridAction.BelowCell, False, False)
                        e.Handled = True
                        griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
                    End If
                ElseIf IdIncidencia = 2 Then
                    Dim ConsumoPromedio As Integer = 0
                    'ejecuto consulta para calcular el promedio
                    cxn.Select_SQL("Consumo_agua_forma_calculo '" & NumeroCuenta & "'," & "2")
                    ConsumoPromedio = cxn.arrayValores(0)
                    Consumo = ConsumoPromedio
                    'asigno valores a celdas del grid
                    griLecturasPeriodo.ActiveRow.Cells("lect_act").Value = LecturaAnterior
                    griLecturasPeriodo.ActiveRow.Cells("consumo_bim").Value = Consumo
                    griLecturasPeriodo.ActiveRow.Cells("usuario").Value = CurrentUsrName
                    'muevo el foco a la celda de lectura actual
                    griLecturasPeriodo.ActiveCell = aCell
                    griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                    griLecturasPeriodo.PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)

                ElseIf IdIncidencia = 3 Then
                    Dim ConsumoMinimo As Integer = 0
                    cxn.Select_SQL("Consumo_agua_forma_calculo '" & NumeroCuenta & "'," & "3")
                    ConsumoMinimo = cxn.arrayValores(0)
                    Consumo = ConsumoMinimo
                    griLecturasPeriodo.ActiveRow.Cells("lect_act").Value = LecturaAnterior
                    griLecturasPeriodo.ActiveRow.Cells("consumo_bim").Value = Consumo
                    griLecturasPeriodo.ActiveRow.Cells("usuario").Value = CurrentUsrName
                    'muevo el foco a la celda de lectura actual
                    griLecturasPeriodo.ActiveCell = aCell
                    griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                    griLecturasPeriodo.PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
                    ModificoLectura = True
                End If

            Case Keys.Right
                griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                griLecturasPeriodo.PerformAction(UltraGridAction.NextCellByTab, False, False)
                e.Handled = True
                griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
            Case Keys.Left
                griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                griLecturasPeriodo.PerformAction(UltraGridAction.PrevCellByTab, False, False)
                e.Handled = True
                griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
        End Select
    End Sub
    Private Sub Guarda_Datos()
        Dim FormaPago As Integer
        FormaPago = optFormaPago.Value
        TblconsumoaguaBindingSource.EndEdit()
        Me.Tbl_consumo_aguaTableAdapter.Update(DsAgua.tbl_consumo_agua)
        Me.Tbl_consumo_aguaTableAdapter.FillByAñoBimRuta(Me.DsAgua.tbl_consumo_agua, ucoRuta.Value, mskUltMes.Text, txtanio.Value, FormaPago)
        cMensajes.DisplayMessage(Me, "Registros actualizados!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoRuta, "SELECT id_ruta,Nombre from rutas")
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        ErrorProvider1.Clear()

        Try
            If optFormaPago.Value = 0 Then
                ErrorProvider1.SetError(optFormaPago, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo forma de pago es requerido" & "<br />"
                Me.optFormaPago.Focus()
            End If

            If txtanio.Value < 2000 Or txtanio.Value > 2050 Then
                ErrorProvider1.SetError(txtanio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo año es requerido" & "<br />"
                Me.txtanio.Focus()
            End If

            If mskUltMes.Text.Trim = "" Then
                ErrorProvider1.SetError(mskUltMes, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Mes es necesario!" & "<br />"
                Me.mskUltMes.Focus()
            End If

            If ucoRuta.IsItemInList = False Then
                ErrorProvider1.SetError(ucoRuta, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo ruta es necesario" & "<br />"
                Me.ucoRuta.Focus()
            End If

            If ocurriounError > 0 Then
                ban = True
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = False
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            If valida_datos() = False Then
                Dim TotalRegistros As Integer = 0
                Dim FormaPago As Integer

                FormaPago = optFormaPago.Value

                cxn.Select_SQL("select count(*) from tbl_consumo_agua where bimestre=" & mskUltMes.Text & " and año=" & txtanio.Value.ToString & " and idRuta=" & ucoRuta.Value.ToString)
                TotalRegistros = cxn.arrayValores(0)
                If TotalRegistros > 0 Then
                    cMensajes.DisplayMessage(Me, "Ya existen registros correspondientes al bimestre, ruta y año seleccionado!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                If cxn.Select_SQL("exec sp_arcgua_CreaConsumo '" & ucoRuta.Value & "','" & Me.txtanio.Value & "','" & Me.mskUltMes.Text & "','" & CurrentUsrName & "'") Then
                    Me.Tbl_consumo_aguaTableAdapter.FillByAñoBimRuta(Me.DsAgua.tbl_consumo_agua, ucoRuta.Value, mskUltMes.Text, txtanio.Value, FormaPago)

                    If griLecturasPeriodo.Rows.Count = 0 Then
                        btnGuardar.Visible = False
                        cMensajes.DisplayMessage(Me, "No se encontraron registros!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Registros generados!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        btnGuardar.Visible = True
                    End If
                    griLecturasPeriodo.Refresh()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If ModificoLectura = True Then
            If (MsgBox("¿Desea guardar los cambios antes de salir?", vbCritical + vbYesNo) = vbYes) Then
                Guarda_Datos()
            End If
        End If

        ModificoLectura = False
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs)
        Me.griLecturasPeriodo.DisplayLayout.Override.FilterOperandDropDownItems = FilterOperandDropDownItems.Errors
    End Sub
    Private Sub frmaguaRegistroConsumo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim nextControl As Control

        If e.KeyCode = Keys.Enter Then
            nextControl = GetNextControl(ActiveControl, Not e.Shift)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            SendKeys.Send("{TAB}")
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        If valida_datos() = False Then
            Dim FormaPago As Integer
            FormaPago = optFormaPago.Value
            Me.Tbl_consumo_aguaTableAdapter.FillByAñoBimRuta(Me.DsAgua.tbl_consumo_agua, ucoRuta.Value, mskUltMes.Text, txtanio.Value, FormaPago)
            If griLecturasPeriodo.Rows.Count = 0 Then
                btnGuardar.Visible = False
                'btnElimina.Visible = False
                cMensajes.DisplayMessage(Me, "No existen registros!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                btnGuardar.Visible = True
                'btnElimina.Visible = True
                cMensajes.DisplayMessage(Me, "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub optFormaPago_ValueChanged(sender As Object, e As EventArgs) Handles optFormaPago.ValueChanged
        mskUltMes.Items.Clear()
        If optFormaPago.Value = 2 Then
            mskUltMes.Items.Add(1)
            mskUltMes.Items.Add(2)
            mskUltMes.Items.Add(3)
            mskUltMes.Items.Add(4)
            mskUltMes.Items.Add(5)
            mskUltMes.Items.Add(6)
            mskUltMes.Items.Add(7)
            mskUltMes.Items.Add(8)
            mskUltMes.Items.Add(9)
            mskUltMes.Items.Add(10)
            mskUltMes.Items.Add(11)
            mskUltMes.Items.Add(12)
        Else
            mskUltMes.Items.Add(1)
            mskUltMes.Items.Add(2)
            mskUltMes.Items.Add(3)
            mskUltMes.Items.Add(4)
            mskUltMes.Items.Add(5)
            mskUltMes.Items.Add(6)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guarda_Datos()
    End Sub

    Private Sub mdiMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ModificoLectura = True Then
            If (MsgBox("¿Desea guardar los cambios antes de salir?", vbCritical + vbYesNo) = vbYes) Then
                Guarda_Datos()
                ModificoLectura = False
                GenericCloseChlildForm(Me)
            Else
                ModificoLectura = False
                e.Cancel = True
            End If
        End If

    End Sub



    Private Sub griLecturasPeriodo_Enter(sender As Object, e As EventArgs) Handles griLecturasPeriodo.Enter
        ' set ActiveRow and ActiveCell on grid entry 
        If griLecturasPeriodo.ActiveRow Is Nothing Then

            griLecturasPeriodo.ActiveRow = griLecturasPeriodo.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

        End If

        If griLecturasPeriodo.ActiveCell Is Nothing Then
            griLecturasPeriodo.ActiveCell = griLecturasPeriodo.ActiveRow.Cells(2)

        End If
    End Sub


End Class