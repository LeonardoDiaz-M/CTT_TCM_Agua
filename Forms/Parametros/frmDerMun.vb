Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraMessageBox
Imports System.Web.Security
Public Class frmDerMun
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private currentmenu As String = currentmenu

    Private Sub frmDerMun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Try
            load_combos()
            Me.Tbl_derechosTableAdapter.Fill(Me.DsParametros.tbl_derechos)
            load_Permiso()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        uneAnio.SelectAll()
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpCuotas.Enabled = IIf(id = "0", True, False)
        Me.grpdata.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        Else
            Me.Tbl_derechosTableAdapter.FillByDerechoId(Me.DsParametros.tbl_derechos, id)
            uneAnio.Value = Nothing
            uneAnio.ReadOnly = False
        End If
    End Sub
    Private Sub frmDerMun_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub load_combos()
        cxn.fLlenaDropDownUltra(ucoCuenta, "select distinct cve_cuenta,cve_cuenta + ' - ' + nombre as texto  from [dbo].cat_cuentas")
        cxn.fLlenaDropDownUltra(ucoDependencia, "select id_dep,nombre from dependencias ")
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta
            If id = "0" Then
                If uneAnio.Value < 2000 Then
                    ErrorProvider1.SetError(uneAnio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo año es requerido y debe ser mayor a el ejercicio actual." & "<br />"
                    Me.uneAnio.SelectAll()
                Else
                    cxn.Select_SQL("select count(*) from tbl_derechos where ejfiscal='" & uneAnio.Value.ToString & "' AND cve_Cuenta='" & ucoCuenta.Value &
                "' AND sub_cuenta='" & txtSubcuenta.Value & "' AND articulo='" & txtArticulo.Text & "' AND fraccion='" & txtFraccion.Text & "' AND parrafo='" & txtParrafo.Text & "'")

                    Dim Registros As Integer = cxn.arrayValores(0)

                    If Registros > 0 Then
                        ErrorProvider1.SetError(uneAnio, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "Ya existe un registro en la base de datos con la información proporcionada!." & "<br />"
                        Me.uneAnio.SelectAll()
                    End If
                End If
            End If

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

            If Me.txtSubcuenta.Text.Trim = "" Then
                ErrorProvider1.SetError(txtSubcuenta, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Sub Cuenta es requerido." & "<br />"
                Me.txtSubcuenta.SelectAll()
            End If

            If Me.txtArticulo.Text.Trim = "" Then
                ErrorProvider1.SetError(txtArticulo, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo artículo es requerido." & "<br />"
                Me.txtArticulo.SelectAll()
            End If

            If Me.txtFraccion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtFraccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Fracción es requerido." & "<br />"
                Me.txtFraccion.SelectAll()
            End If

            If Me.txtParrafo.Text.Trim = "" Then
                ErrorProvider1.SetError(txtParrafo, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo párrafo es requerido." & "<br />"
                Me.txtParrafo.SelectAll()
            End If

            If Me.optCuota.Value = "" Then
                ErrorProvider1.SetError(optCuota, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de cuota es requerido." & "<br />"
                Me.optCuota.Focus()
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
                If Editar And id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Tbl_derechosTableAdapter.Update(Me.DsParametros.tbl_derechos)
                    Me.grpCuotas.Enabled = False
                    Me.grpdata.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    cxn.Select_SQL("select year(dbo.getdateMx())")
                    id = Tbl_derechosTableAdapter.Insert(Me.uneAnio.Value.ToString,
                                                    Me.ucoCuenta.Value.ToString,
                                                    Me.txtSubcuenta.Text.Trim,
                                                    Me.txtArticulo.Text.Trim,
                                                    Me.txtFraccion.Text.Trim,
                                                    Me.txtParrafo.Text.Trim,
                                                    Me.uneCuotaUno.Value.ToString,
                                                    Me.uneCuotaDos.Value.ToString,
                                                    Me.uneCuotaTres.Value.ToString,
                                                    IIf(Me.chkDatos1.Checked = True, 1, 0).ToString,
                                                    Me.txtMensaje1.Text.Trim,
                                                    IIf(Me.chkDatos2.Checked = True, 1, 0).ToString,
                                                    Me.txtMensaje2.Text.Trim,
                                                    Me.optCuota.Value.ToString,
                                                    Me.txtformula.Text.Trim,
                                                    Me.UnoTipoCuota.Value.ToString,
                                                    Me.txtDescripcion.Text.Trim,
                                                    Me.txtArtSiguiente.Text.Trim,
                                                    Me.txtFraccSiguiente.Text.Trim,
                                                    Me.txtParrSiguiente.Text.Trim,
                                                    "",
                                                    Me.ucoDependencia.Value.ToString)
                    Me.Tbl_derechosTableAdapter.Update(Me.DsParametros.tbl_derechos)
                    If id > 0 Then
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cMensajes.DisplayMessage(Me, "Ocurrio un error al generar el registro.. ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                End If
                Me.frmDerMun_Load(Nothing, Nothing)
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
        Me.btnElimina.Visible = Borrar
    End Sub

    Private Sub frmDerMun_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                Me.Tbl_derechosTableAdapter.Update(Me.DsParametros.tbl_derechos)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class