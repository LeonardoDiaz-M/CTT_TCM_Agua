Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraMessageBox
Public Class frmTratFiscDifer
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData

    Private Sub frmTratFiscDifer_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        load_combos()
        Me.Arc_subTableAdapter.Fill(Me.DsParametros1.arc_sub)
        If id <> "0" Then
            Me.BindingSource1.Position = Me.BindingSource1.Find("Tratamiento_id", id)
        End If
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.btnEliminar.Visible = Borrar
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpdata.Enabled = IIf(id = "0", True, False)
        Me.grpCuotas.Enabled = IIf(id = "0", True, False)
        Me.btnBack.Visible = True

        If id = "0" Then
            cxn.Select_SQL("select year(dbo.getdateMx())")
            Me.BindingNavigator1.BindingSource.AddNew()
        Else
            cxn.Select_SQL("select ejfiscal from [tbl_derechos] where derecho_id=" & id.ToString)
        End If
        Me.lblEjFiscal.Text = "Ejercicio Fiscal: " & cxn.arrayValores(0).ToString
        txtDescripcion.Focus()
        txtDescripcion.SelectAll()
    End Sub
    Private Sub frmTratFiscDifer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub load_combos()
        cxn.fLlenaDropDownUltra(ucoCuenta, "select distinct cve_cuenta,cve_cuenta + ' ' + nombre as texto  from [dbo].cat_cuentas")
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta

            If Me.txtDescripcion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtDescripcion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Descripción es requerido.." & "<br />"
                Me.txtDescripcion.SelectAll()
            End If

            If Me.ucoCuenta.IsItemInList = False Then
                ErrorProvider1.SetError(ucoCuenta, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Clave Cuenta es requerido." & "<br />"
                Me.ucoCuenta.SelectAll()
            End If

            If Me.txtNumeroOficio.Text.Trim = "" Then
                ErrorProvider1.SetError(txtNumeroOficio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo número de oficio es requerido." & "<br />"
                Me.txtNumeroOficio.SelectAll()
            End If

            If Not IsDate(dtpFechaVencimiento.Value) Then
                ErrorProvider1.SetError(dtpFechaVencimiento, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fecha actos es requerido." & "<br />"
                Me.dtpFechaVencimiento.Focus()
            End If

            If Me.txtMensajeRecibo.Text.Trim = "" Then
                ErrorProvider1.SetError(txtMensajeRecibo, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo mensaje en recibo es requerido." & "<br />"
                Me.txtMensajeRecibo.SelectAll()
            End If

            If Me.txtMensajePantalla.Text.Trim = "" Then
                ErrorProvider1.SetError(txtMensajePantalla, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo mensaje en pantalla es requerido." & "<br />"
                Me.txtMensajePantalla.SelectAll()
            End If

            If optTipo.Value = "" Then
                ErrorProvider1.SetError(optTipo, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el tipo." & "<br />"
                optTipo.Focus()
            End If

            If Me.txtformula.Text.Trim = "" Then
                ErrorProvider1.SetError(txtformula, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo condición es requerido." & "<br />"
                Me.txtformula.SelectAll()
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Arc_subTableAdapter.Update(Me.DsParametros1.arc_sub)
                    Me.grpCuotas.Enabled = False
                    Me.grpdata.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    id = Arc_subTableAdapter.Insert(Me.ucoCuenta.Value, "", txtTipoServicio.Text, txtNumeroOficio.Text _
                        , txtDescripcion.Text.Trim, dtpFechaVencimiento.Value, txtformula.Text, uneSubImpuesto.Value, uneSubActualizacion.Value _
                        , uneSubRecargos.Value, uneSubMultas.Value, uneSubGastosEjecucion.Value, optTipo.Value, txtMensajeRecibo.Text.Trim _
                        , txtMensajePantalla.Text.Trim, "")
                    Me.Arc_subTableAdapter.Update(Me.DsParametros1.arc_sub)
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                frmTratFiscDifer_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        Me.BindingSource1.CancelEdit()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        grpCuotas.Enabled = True
        grpdata.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = Editar
        Me.btnEliminar.Visible = Borrar
    End Sub

    Private Sub frmTratFiscDifer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Arc_subTableAdapter.Update(Me.DsParametros1.arc_sub)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class