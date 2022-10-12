Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmAguaLecturasPorCuenta
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public myparent As Form = Nothing
    Public idUsuario As String = CurrentUsrName
    Private cxn As New cxnData
    Private idColonia As Integer = -1

    Private Sub frmAguaLecturasPorCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.lblCurrentMenu.Text = "Consumo Agua por Número de Cuenta"
            load_Combos()
            Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
            Me.Tbl_consumo_aguaTableAdapter.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Existe un error:" & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoStatus, "Select cve_status, descripcion from tbl_Status_Contribuyente")
        cxn.fLlenaDropDownUltra(ucoTipoContribuyente, "Select cve_tip_con, descricion from tip_contribuyente")
        cxn.fLlenaDropDownUltra(ucoRuta, "SELECT id_ruta,Nombre from rutas")
    End Sub

    Private Sub btnAgregaLectura_Click(sender As Object, e As EventArgs) Handles btnAgregaLectura.Click
        Dim frm As New frmAguaRegistroConsumo_Alta
        Dim UltimoPeriodo As Integer
        Dim Año As Integer
        Dim LecturaAnterior As Integer = 0

        Año = uneUltAnio.Value

        If griLecturasPeriodo.Rows.Count = 0 Then 'No hay pagos registrados
            Año = uneUltAnio.Value
            If optFormaPago.Value = 1 Then 'Pago bimestral
                UltimoPeriodo = ucoUltMes.Text / 2
            Else
                UltimoPeriodo = ucoUltMes.Text 'Pago Mensual
            End If
            LecturaAnterior = uneUltimaLectura.Value
        Else
            'determina ultima lectura
            cxn.Select_SQL("SELECT Top 1 año,bimestre,lect_act  from tbl_Consumo_agua where (año>='" & uneUltAnio.Value & "' or Bimestre>'" & ucoUltMes.Text & "') AND num_cuenta='" & txtCuenta.Text.Trim & "'  ORDER BY idConsumo desc")
            Año = cxn.arrayValores(0)
            UltimoPeriodo = cxn.arrayValores(1)
            LecturaAnterior = cxn.arrayValores(2)
        End If

        'valida captura de lecturas
        Dim MesActual As Integer = Month(Date.Now)
        Dim AñoActual As Integer = Year(Date.Now)

        If optFormaPago.Value = 1 Then  'forma de pago bimestral
            If UltimoPeriodo = 6 Then
                UltimoPeriodo = 1
                Año = Año + 1
            Else
                UltimoPeriodo = UltimoPeriodo + 1
            End If
            If UltimoPeriodo * 2 + 1 > MesActual And Año = AñoActual Then
                MsgBox("El ingreso de lecturas por periodo supera la fecha actual")
                Exit Sub
            End If
        Else
            'forma de pago mensual
            If UltimoPeriodo = 12 Then
                UltimoPeriodo = 1
                Año = Año + 1
            Else
                UltimoPeriodo = UltimoPeriodo + 1
            End If

            If UltimoPeriodo + 1 > MesActual Then
                MsgBox("El ingreso de lecturas por periodo supera la fecha actual")
                Exit Sub
            End If
        End If
        frm.txtNumeroCuenta.Text = txtCuenta.Text
        frm.txtNombre.Text = txtNombre.Text
        frm.txtanio.Text = Año
        frm.unePeriodo.Text = UltimoPeriodo
        frm.uneLecturaAnterior.Value = LecturaAnterior
        frm.txtRuta.Text = ucoRuta.Value
        frm.ShowDialog()
        Me.TblconsumoaguaBindingSource.EndEdit()
        Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
        Me.Tbl_consumo_aguaTableAdapter.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmAguaLecturasPorCuenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
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
                Dim TotalRenglones As Integer
                Dim RenglonActual As Integer
                TotalRenglones = griLecturasPeriodo.Rows.Count
                RenglonActual = griLecturasPeriodo.ActiveRow.Index + 1

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
                        LecturaActual = griLecturasPeriodo.ActiveRow.Cells("lect_act").Value
                        Consumo = LecturaActual - LecturaAnterior

                        griLecturasPeriodo.ActiveRow.Cells("consumo_bim").Value = Consumo
                        griLecturasPeriodo.ActiveRow.Cells("usuario").Value = Me.idUsuario
                        griLecturasPeriodo.Focus()
                        griLecturasPeriodo.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                        griLecturasPeriodo.ActiveCell.SelectAll()

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
                    griLecturasPeriodo.ActiveRow.Cells("usuario").Value = Me.idUsuario
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
                    griLecturasPeriodo.ActiveRow.Cells("usuario").Value = Me.idUsuario
                    'muevo el foco a la celda de lectura actual
                    griLecturasPeriodo.ActiveCell = aCell
                    griLecturasPeriodo.PerformAction(UltraGridAction.ExitEditMode, False, False)
                    griLecturasPeriodo.PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    griLecturasPeriodo.PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If

                'si existen mas renglones
                If TotalRenglones > RenglonActual Then

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guarda_Datos()
    End Sub
    Private Sub Guarda_Datos()
        'Dim FormaPago As Integer
        'FormaPago = optFormaPago.Value
        TblconsumoaguaBindingSource.EndEdit()
        Me.Tbl_consumo_aguaTableAdapter.Update(DsAgua.tbl_consumo_agua)
        Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
        Me.Tbl_consumo_aguaTableAdapter.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        MsgBox("Se van a eliminar lecturas?????")
    End Sub
End Class

