Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinMaskedEdit
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatCuentas
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private currentmenu As String = currentmenu

    Private Sub frmCatCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        load_Combos()
        Me.DsCatalogos.EnforceConstraints = False
        Me.Cat_cuentasTableAdapter.Fill(Me.DsCatalogos.cat_cuentas)
        Modo_Simple_Combos()
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        txtClaveCuenta.ReadOnly = True
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.gruPrincipal.Enabled = IIf(id = "0", True, False)
        Me.gruSecundario.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            Me.gruPrincipal.Enabled = True
            Me.gruSecundario.Enabled = True
            txtClaveCuenta.ReadOnly = False
        Else
            Me.BindingSource.Position = Me.BindingSource.Find("cve_cuenta", id)
        End If
    End Sub

    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoDiarioRecaudacion, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoIngresoCorriente, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoIngresoRezago, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoRecargos, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoMultas, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(UcoGastosEjecucion, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoSubsidioIngresoCorriente, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoSubsidioRecargos, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoSubsidioMultas, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.fLlenaDropDownUltra(ucoSubsidioGastosEjecucion, "SELECT nombre,cve_cuenta from cat_Cuentas")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescDiarioRecaudacion, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescIngresoCorriente, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescIngresoRezago, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescRecargos, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescMultas, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescGastosEjecucion, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescSubsidioIngresoCorriente, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescSubsidioRecargos, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescSubsidioMultas, "nombre", "cve_cuenta")
        cxn.Get_SQL_Combobox("SELECT nombre,cve_cuenta from cat_Cuentas", Me.cboDescSubsidioGastosEjecucion, "nombre", "cve_cuenta")
    End Sub

    Private Sub Modo_Simple_Combos()
        Me.cboDescDiarioRecaudacion.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescIngresoCorriente.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescIngresoRezago.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescRecargos.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescMultas.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescGastosEjecucion.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescSubsidioIngresoCorriente.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescSubsidioRecargos.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescSubsidioMultas.DropDownStyle = ComboBoxStyle.Simple
        Me.cboDescSubsidioGastosEjecucion.DropDownStyle = ComboBoxStyle.Simple
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmCatCuentas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtClaveCuenta.ReadOnly = True
        gruPrincipal.Enabled = True
        gruSecundario.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
        Me.btnElimina.Visible = Borrar
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.BindingSource.EndEdit()
                    Me.Cat_cuentasTableAdapter.Update(Me.DsCatalogos.cat_cuentas)
                    Me.gruPrincipal.Enabled = False
                    Me.gruSecundario.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    Me.Cat_cuentasTableAdapter.Insert(txtClaveCuenta.Text, txtDescClaveCuenta.Text, "000000", "000000", "000000", "000000", "000000", "000000", "000000", "000000", "000000", "000000", 1, txtCuentaContable.Text)
                    Me.Cat_cuentasTableAdapter.Update(Me.DsCatalogos.cat_cuentas)
                    gruPrincipal.Enabled = False
                    gruSecundario.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    id = Me.txtClaveCuenta.Text
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    frmCatCuentas_Load(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        BindingSource.CancelEdit()
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If id <> "0" Then
                If txtClaveCuenta.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo clave cuenta es requerido" & "<br />"
                    Me.txtClaveCuenta.Focus()
                End If

                If txtDescClaveCuenta.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtDescClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo descripción cuenta es requerido" & "<br />"
                    Me.txtDescClaveCuenta.Focus()
                End If

                If txtCuentaContable.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtCuentaContable, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo cuenta contabilidad es requerido." & "<br />"
                    Me.txtCuentaContable.Focus()
                End If

                If Me.ucoDiarioRecaudacion.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoDiarioRecaudacion, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta diario de recaudación." & "<br />"
                    Me.ucoDiarioRecaudacion.Focus()
                End If

                If Me.ucoIngresoCorriente.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoIngresoCorriente, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta ingreso corriente." & "<br />"
                    Me.ucoIngresoCorriente.Focus()
                End If


                If Me.ucoIngresoRezago.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoIngresoRezago, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta ingreso rezago." & "<br />"
                    Me.ucoIngresoRezago.Focus()
                End If


                If Me.ucoRecargos.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoRecargos, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta recargos." & "<br />"
                    Me.ucoRecargos.Focus()
                End If


                If Me.ucoMultas.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoMultas, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta multas." & "<br />"
                    Me.ucoMultas.Focus()
                End If


                If Me.UcoGastosEjecucion.IsItemInList = False Then
                    ErrorProvider1.SetError(UcoGastosEjecucion, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta gastos de ejecución." & "<br />"
                    Me.UcoGastosEjecucion.Focus()
                End If

                If Me.ucoSubsidioIngresoCorriente.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoSubsidioIngresoCorriente, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta subsidio ingreso corriente." & "<br />"
                    Me.ucoSubsidioIngresoCorriente.Focus()
                End If

                If Me.ucoSubsidioRecargos.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoSubsidioRecargos, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta subsidio recargos." & "<br />"
                    Me.ucoSubsidioRecargos.Focus()
                End If


                If Me.ucoSubsidioMultas.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoSubsidioMultas, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta subsidio multas." & "<br />"
                    Me.ucoSubsidioMultas.Focus()
                End If


                If Me.ucoSubsidioGastosEjecucion.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoSubsidioGastosEjecucion, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Seleccione la cuenta subsidio gastos de ejecucion." & "<br />"
                    Me.ucoSubsidioGastosEjecucion.Focus()
                End If

            Else
                If txtClaveCuenta.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo clave cuenta es requerido" & "<br />"
                    Me.txtClaveCuenta.Focus()
                End If

                If txtClaveCuenta.Text.Trim.Length <> 6 Then
                    ErrorProvider1.SetError(txtClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "La longitud es incorrecta!" & "<br />"
                    Me.txtClaveCuenta.Focus()
                End If

                cxn.Select_SQL("select count(*) from cat_cuentas where cve_cuenta='" & txtClaveCuenta.Text.ToString & "'")
                Dim Registros As Integer = cxn.arrayValores(0)

                If Registros > 0 Then
                    ErrorProvider1.SetError(txtClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "La clave ingresada ya existe!" & "<br />"
                    Me.txtClaveCuenta.SelectAll()
                End If

                If txtDescClaveCuenta.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtDescClaveCuenta, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo descripción cuenta es requerido" & "<br />"
                    Me.txtDescClaveCuenta.Focus()
                End If

                If txtCuentaContable.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtCuentaContable, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo cuenta contabilidad es requerido." & "<br />"
                    Me.txtCuentaContable.Focus()
                End If
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

    Private Sub ucoDiarioRecaudacion_RowSelected(sender As Object, e As RowSelectedEventArgs) Handles ucoDiarioRecaudacion.RowSelected, ucoIngresoCorriente.RowSelected, ucoIngresoRezago.RowSelected, ucoRecargos.RowSelected _
        , ucoMultas.RowSelected, UcoGastosEjecucion.RowSelected, ucoSubsidioIngresoCorriente.RowSelected, ucoSubsidioRecargos.RowSelected, ucoSubsidioMultas.RowSelected, ucoSubsidioGastosEjecucion.RowSelected

        If sender.IsItemInList = True Then
            Select Case (sender.name)
                Case "ucoDiarioRecaudacion"
                    cboDescDiarioRecaudacion.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoIngresoCorriente"
                    cboDescIngresoCorriente.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoIngresoRezago"
                    cboDescIngresoRezago.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoRecargos"
                    cboDescRecargos.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoMultas"
                    cboDescMultas.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "UcoGastosEjecucion"
                    cboDescGastosEjecucion.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoSubsidioIngresoCorriente"
                    cboDescSubsidioIngresoCorriente.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoSubsidioRecargos"
                    cboDescSubsidioRecargos.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoSubsidioMultas"
                    cboDescSubsidioMultas.SelectedValue = e.Row.Cells("cve_cuenta").Value
                Case "ucoSubsidioGastosEjecucion"
                    cboDescSubsidioGastosEjecucion.SelectedValue = e.Row.Cells("cve_cuenta").Value
            End Select
        Else

        End If
    End Sub

    Private Sub ucoDiarioRecaudacion_ValueChanged(sender As Object, e As EventArgs) Handles ucoDiarioRecaudacion.ValueChanged, ucoIngresoCorriente.ValueChanged, ucoIngresoRezago.ValueChanged, ucoRecargos.ValueChanged _
        , ucoMultas.ValueChanged, UcoGastosEjecucion.ValueChanged, ucoSubsidioIngresoCorriente.ValueChanged, ucoSubsidioRecargos.ValueChanged, ucoSubsidioMultas.ValueChanged, ucoSubsidioGastosEjecucion.ValueChanged

        If sender.IsItemInList = False Then
            Select Case (sender.name)
                Case "ucoDiarioRecaudacion"
                    cboDescDiarioRecaudacion.Text = ""
                Case "ucoIngresoCorriente"
                    cboDescIngresoCorriente.SelectedValue = 0
                Case "ucoIngresoRezago"
                    cboDescIngresoRezago.SelectedValue = 0
                Case "ucoRecargos"
                    cboDescRecargos.SelectedValue = 0
                Case "ucoMultas"
                    cboDescMultas.SelectedValue = 0
                Case "UcoGastosEjecucion"
                    cboDescGastosEjecucion.SelectedValue = 0
                Case "ucoSubsidioIngresoCorriente"
                    cboDescSubsidioIngresoCorriente.SelectedValue = 0
                Case "ucoSubsidioRecargos"
                    cboDescSubsidioRecargos.SelectedValue = 0
                Case "ucoSubsidioMultas"
                    cboDescSubsidioMultas.SelectedValue = 0
                Case "ucoSubsidioGastosEjecucion"
                    cboDescSubsidioGastosEjecucion.SelectedValue = 0
            End Select
        End If
    End Sub

    Private Sub frmCatCuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Cat_cuentasTableAdapter.Update(Me.DsCatalogos.cat_cuentas)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class