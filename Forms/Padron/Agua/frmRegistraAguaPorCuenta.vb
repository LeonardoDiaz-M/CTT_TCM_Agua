Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl

Public Class frmRegistraAguaPorCuenta
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing

    Private Sub frmRegistraAguaPorCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lblCurrentMenu.Text = Me.Text
            load_Combos()
            Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
            Me.Tbl_consumo_aguaTableAdapter1.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
            Valida_Usuario_Servicio()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Existe un error:" & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoStatus, "Select cve_status, descripcion from tbl_Status_Contribuyente")
        cxn.fLlenaDropDownUltra(ucoTipoContribuyente, "Select cve_tip_con, descricion from tip_contribuyente")
        cxn.fLlenaDropDownUltra(ucoRuta, "SELECT id_ruta,Nombre from rutas")
    End Sub
    Private Sub load_Permiso()
        Me.btnEditar.Visible = False
        Me.Text = "Registro de Consumo de la cuenta : " & id.ToString
        Me.grpDatosCuenta.Enabled = False
        Me.btnEditar.Visible = True
    End Sub

#Region "Usuario_Servicio"
    Private Function Valida_Usuario_Servicio() As Integer
        Dim tipo_servicio As Integer = -1
        Me.cmbMedidor.Visible = True
        Me.lblMedidor.Visible = True
        Me.lblUltLectura.Visible = False
        'Me.txtUltLectura.Visible = False
        Me.cmbMedidor.Enabled = True

        'tipo de usuario domestico = 1 & tipo de servicio cuota fija = 2
        If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
            If Me.lblMedidor.Text <> "Tipo de Inmueble:" Then
                Me.lblMedidor.Text = "Tipo de Inmueble:"
                cxn.Get_SQL_Combobox("SELECT * from tipo_inmueble", Me.cmbMedidor, "Nombre", "clave")
            End If

            tipo_servicio = 0
            Me.cmbMedidor.DropDownStyle = ComboBoxStyle.DropDownList
            'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
        ElseIf Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
            If Me.lblMedidor.Text <> "Diametro de la toma:" Then
                Me.lblMedidor.Text = "Diametro de la toma:"
                cxn.Get_SQL_Combobox("SELECT * from tbl_DiametroToma", Me.cmbMedidor, "Diametro", "idToma")
            End If
            Me.cmbMedidor.DropDownStyle = ComboBoxStyle.DropDownList
            tipo_servicio = 1
        Else

            Me.lblUltLectura.Visible = True
            'Me.txtUltLectura.Visible = True
            Me.cmbMedidor.DataSource = Nothing
            Me.cmbMedidor.Items.Clear()
            Me.lblMedidor.Text = "Medidor #"
            Me.cmbMedidor.DropDownStyle = ComboBoxStyle.Simple
            tipo_servicio = 2
        End If
        If Editar And id <> "0" Then
            Select Case tipo_servicio
                Case 0
                    cxn.Select_SQL("SELECT tipo_inmueble from arc_agua where num_cuenta='" & id.ToString & "'")
                    Me.cmbMedidor.SelectedValue = cxn.arrayValores(0)
                Case 1
                    cxn.Select_SQL("SELECT diametro_toma from arc_agua where num_cuenta='" & id.ToString & "'")
                    Me.cmbMedidor.SelectedValue = cxn.arrayValores(0)
                Case 2
                    cxn.Select_SQL("SELECT num_medidor from arc_agua where num_cuenta='" & id.ToString & "'")
                    Me.cmbMedidor.Text = cxn.arrayValores(0)
            End Select
        End If
        Return tipo_servicio
    End Function
#End Region
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Ingresa_Lectura()
    End Sub
    Private Sub uneLecturaActual_KeyUp(sender As Object, e As KeyEventArgs) Handles uneLecturaActual.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnEditar.PerformClick()
        End If
    End Sub
    Private Sub txtCuenta_LostFocus(sender As Object, e As EventArgs)
        'If Me.txtCvecatastral.Text.Trim.Length = 16 Then
        '    cxn.Select_SQL("select propietario from arc_predial where cve_catastral='" & Me.txtCvecatastral.Text & "'")
        '    If cxn.arrayValores(0) IsNot Nothing Then
        '        cMensajes.DisplayMessage(Me, "Cve.Catastral: " & Me.txtCvecatastral.Text & " - Propieatrio: " & Me.cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Else
        '        cMensajes.DisplayMessage(Me, "Error Cve. Catastral invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    End If
        'End If
    End Sub
    'Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
    '    Dim frm As New frmAguaRegistroConsumo_Alta
    '    frm.txtNumeroCuenta.Text = txtCuenta.Text
    '    frm.txtanio.Value = uneUltAnio.Value
    '    frm.ShowDialog()
    '    Me.Tbl_consumo_aguaTableAdapter1.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
    'End Sub
    Private Sub Ingresa_Lectura()
        Dim FormaCalculoConsumo As Integer = 0
        FormaCalculoConsumo = optLectura.Value
        If FormaCalculoConsumo = 1 Then
            txtConsumo.Text = uneLecturaActual.Value - uneLecturaAnterior.Value
        End If
        If FormaCalculoConsumo = 2 Then
            Dim ConsumoPromedio As Integer = 0
            cxn.Select_SQL("Consumo_agua_forma_calculo '" & txtCuenta.Text.Trim & "'," & "2")
            ConsumoPromedio = cxn.arrayValores(0)
            txtConsumo.Text = ConsumoPromedio
            uneLecturaActual.Value = uneLecturaAnterior.Value
        End If
        If FormaCalculoConsumo = 3 Then
            Dim ConsumoMinimo As Integer = 0
            cxn.Select_SQL("Consumo_agua_forma_calculo '" & txtCuenta.Text.Trim & "'," & "3")
            ConsumoMinimo = cxn.arrayValores(0)
            txtConsumo.Text = ConsumoMinimo
            uneLecturaActual.Value = uneLecturaAnterior.Value
        End If
        If valida_Lectura() = True Then
            Exit Sub
        End If

        Me.TblconsumoaguaBindingSource.EndEdit()
        Me.Tbl_consumo_aguaTableAdapter1.Update(DsAgua.tbl_consumo_agua)
        Dim Posicion As Integer
        Posicion = TblconsumoaguaBindingSource.Position
        cMensajes.DisplayMessage(Me, "Registro ingresado!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Me.Tbl_consumo_aguaTableAdapter1.FillByNumeroCuenta(Me.DsAgua.tbl_consumo_agua, id)
        TblconsumoaguaBindingSource.Position = Posicion + 1
        uneLecturaActual.SelectAll()
    End Sub


    Private Function valida_Lectura() As Boolean
        Dim bocurriounerror As Boolean = False

        If txtConsumo.Value < 1 Then
            bocurriounerror = True
            cMensajes.DisplayMessage(Me, "El consumo no puede ser menor o igual a cero!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        Return bocurriounerror
    End Function

    Private Sub TblconsumoaguaBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles TblconsumoaguaBindingSource.PositionChanged
        uneLecturaActual.SelectAll()
    End Sub

End Class