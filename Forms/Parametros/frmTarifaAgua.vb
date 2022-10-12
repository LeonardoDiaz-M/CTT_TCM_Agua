Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Public Class frmTarifaAgua
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmTarifaAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        load_Permiso()
    End Sub
    Private Sub load_Permiso()

        Me.btnElimina.Visible = False
        Me.btnNuevo.Visible = Insertar
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpdata.Enabled = IIf(id = "0", True, False)

        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            uneAnio.Value = Nothing
            lblOperacion.Text = "Alta Concepto Tarifa"
            txtFraccion.Text = ""
            txtGrupoMunicipio.Text = ""
            uneAnio.Value = Nothing
            grpdata.Enabled = True
            Me.grpdata.Visible = True
            btnEditar.Visible = False
            btnGuardar.Visible = True
            btnNuevo.Visible = False
            uneAnio.ReadOnly = False
            uneAnio.Focus()
        Else
            lblOperacion.Text = "Modifica Tarifa"
            Me.Tbl_tarifas_aguaTableAdapter.Fill(Me.DsParametros1.tbl_tarifas_agua)
            Me.TbltarifasaguaBindingSource1.Position = Me.TbltarifasaguaBindingSource1.Find("id_tarifa", id)
            'Me.Tbl_tarifas_aguaTableAdapter.Fill(Me.DsParametros1.tbl_tarifas_agua, id)
            Valida_Usuario_Servicio()
            uneAnio.ReadOnly = True
            Me.grpdata.Visible = True
            btnNuevo.Visible = True
        End If
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        TbltarifasaguaBindingSource1.CancelEdit()
        If id <> "0" Then
            btnElimina.Visible = True
            btnGuardar.Visible = False
            btnEditar.Visible = True
            grpdata.Enabled = False
        Else
            btnElimina.Visible = False
            btnGuardar.Visible = True
            btnEditar.Visible = False
            grpdata.Enabled = True
            uneAnio.Value = Nothing
            txtDescripcionTarifa.Text = ""
            txtFraccion.Text = ""
            txtGrupoMunicipio.Text = ""
            optTipoServicio.Value = 0
            optUsuario.Value = 0
            uneAnio.SelectAll()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub frmTarifaAgua_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If id <> "0" Then
                If lblOperacion.Text = "Modifica Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Me.Validate()
                        Me.TbltarifasaguaBindingSource1.EndEdit()
                        Me.Tbl_tarifas_aguaTableAdapter.Update(Me.DsParametros1.tbl_tarifas_agua)
                        Me.grpdata.Enabled = False
                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnElimina.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If

                If lblOperacion.Text = "Alta Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Dim diametrotoma As Integer = 0
                        Dim TipoInmueble As Integer = 0

                        If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
                            diametrotoma = vbNull
                            TipoInmueble = ucoTipoInmueble.Value
                        End If
                        'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
                        If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
                            diametrotoma = UcoTipoInmueble.Value
                            TipoInmueble = vbNull
                        End If

                        If optTipoServicio.Value = 1 Then
                            diametrotoma = vbNull
                            TipoInmueble = vbNull
                        End If


                        'Me.Tbl_tarifas_aguaTableAdapter.Insert(id, TipoInmueble, diametrotoma, CDec(uneLimiteInferior.Value), CDec(uneLimiteSuperior.Value), CDec(uneCuotaMinima.Value), CDec(uneFactor.Value))
                        'Me.Tbl_tarifas_aguaTableAdapter.FillByKey(Me.DsParametros1.tbl_tarifas_agua, id)
                        Me.grpdata.Enabled = False

                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnElimina.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If
            Else
                If valida_datos_Alta_Concepto_Tarifa() = False Then
                    'Me.Tbl_tarifas_aguaTableAdapter.Insert(uneAnio.Value, optUsuario.Value, optTipoServicio.Value, txtFraccion.Text, txtGrupoMunicipio.Text, txtDescripcionTarifa.Text, optFormaPago.Value)
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    Me.btnElimina.Visible = False

                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    Dim Mainbar As ToolStrip = TryCast(myParent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
                    Mainbar.Enabled = True
                    Me.Close()
                    Me.Dispose()
                End If
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Function valida_datos_Alta_Rango_Tarifa() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If UneLimiteSuperior.Value < UneLimiteInferior.Value Then
                ErrorProvider1.SetError(UneLimiteSuperior, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo límite superior no puede ser menor al límite inferior." & "<br />"
                Me.UneLimiteSuperior.Focus()
            End If

            If UneFactor.Value <= 0 Then
                ErrorProvider1.SetError(UneFactor, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo factor no puede ser igual a cero." & "<br />"
                Me.UneFactor.Focus()
            End If

            If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
                If UcoTipoInmueble.IsItemInList = False Then
                    ErrorProvider1.SetError(UcoTipoInmueble, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo tipo de inmueble es requerido" & "<br />"
                    Me.UcoTipoInmueble.Focus()
                End If
            End If
            'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
            If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
                If UcoDiametro.IsItemInList = False Then
                    ErrorProvider1.SetError(UcoTipoInmueble, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo diametro toma es requerido" & "<br />"
                    Me.UcoTipoInmueble.Focus()
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
    Private Function valida_datos_Alta_Concepto_Tarifa() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If uneAnio.Value < 2000 Or uneAnio.Value > 2050 Then
                ErrorProvider1.SetError(uneAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año es requerido" & "<br />"
                Me.uneAnio.Focus()
            End If

            If txtFraccion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtFraccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fracción es necesario!" & "<br />"
                Me.txtFraccion.Focus()
            End If

            If txtGrupoMunicipio.Text.Trim = "" Then
                ErrorProvider1.SetError(txtGrupoMunicipio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo grupo municipio es requerido" & "<br />"
                Me.txtGrupoMunicipio.Focus()
            End If

            If optTipoServicio.Value = "" Then
                ErrorProvider1.SetError(grpServicio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de servicio es requerido." & "<br />"
                Me.optTipoServicio.Focus()
            End If

            If optUsuario.Value = "" Then
                ErrorProvider1.SetError(grpTipoUsuario, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de usuario es requerido." & "<br />"
                Me.optUsuario.Focus()
            End If

            If optFormaPago.Value = "" Then
                ErrorProvider1.SetError(grpFormaPago, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo forma de pago es requerido." & "<br />"
                Me.optFormaPago.Focus()
            End If

            If txtDescripcionTarifa.Text.Trim = "" Then
                ErrorProvider1.SetError(txtDescripcionTarifa, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo descripción es necesario!" & "<br />"
                Me.txtDescripcionTarifa.Focus()
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
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        lblOperacion.Text = "Modifica Rango Tarifa"
        grpdata.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnElimina.Visible = False
        uneLimiteInferior.SelectAll()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblOperacion.Text = "Alta Rango Tarifa"
        Me.btnGuardar.Visible = True
        Me.btnEditar.Visible = False
        Me.btnElimina.Visible = False
        grpdata.Enabled = False
        UneLimiteInferior.Value = 0
        uneLimiteSuperior.Value = 0
        uneCuotaMinima.Value = 0
        uneFactor.Value = 0
        uneLimiteInferior.SelectAll()
    End Sub
    Private Sub optUsuario_ValueChanged(sender As Object, e As EventArgs) Handles optUsuario.ValueChanged
        Valida_Usuario_Servicio()
    End Sub

    Private Sub optTipoServicio_ValueChanged(sender As Object, e As EventArgs) Handles optTipoServicio.ValueChanged
        Valida_Usuario_Servicio()
    End Sub
    Private Sub Valida_Usuario_Servicio()
        'tipo de usuario domestico = 1 & tipo de servicio cuota fija = 2
        If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
            cxn.fLlenaDropDownUltra(UcoTipoInmueble, "SELECT clave,nombre from tipo_inmueble")
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tipo_inmueble' Puede moverla o quitarla según sea necesario.
            Me.Tipo_inmuebleTableAdapter.Fill(Me.DsParametros1.tipo_inmueble)
            UcoTipoInmueble.Visible = False
            UcoTipoInmueble.Visible = True
            lblDiametroToma.Visible = False
            lblTipoInmueble.Visible = True
        End If
        'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
        If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
            'cxn.fLlenaDropDownUltra(UcoTipoInmueble, "SELECT IdToma,Diametro from tbl_DiametroToma")
            cxn.fLlenaDropDownUltra(UcoDiametro, "SELECT IdToma,Diametro from tbl_DiametroToma")
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tbl_DiametroToma' Puede moverla o quitarla según sea necesario.
            Me.Tbl_DiametroTomaTableAdapter.Fill(Me.DsParametros1.tbl_DiametroToma)
            UcoDiametro.Visible = True
            UcoTipoInmueble.Visible = False
            lblDiametroToma.Visible = True
            lblTipoInmueble.Visible = False
        End If

        If optTipoServicio.Value = 1 Then
            UcoTipoInmueble.Visible = False
            UcoTipoInmueble.Visible = False
            lblDiametroToma.Visible = False
            lblTipoInmueble.Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tbl_tarifas_aguaTableAdapter.Update(Me.DsParametros1.tbl_tarifas_agua)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub frmTarifaAgua_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmTarifaAgua_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        uneAnio.SelectAll()
    End Sub
End Class