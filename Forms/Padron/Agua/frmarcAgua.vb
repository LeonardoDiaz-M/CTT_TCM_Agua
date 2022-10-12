Option Explicit Off
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Text.RegularExpressions
Public Class frmarcAgua
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private idColonia As Integer = -1

    Private Sub frmarcAguaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lblCurrentMenu.Text = Me.Text
            Me.BindingNavigator1.Visible = False
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoStatus, "Select cve_status, descripcion from tbl_Status_Contribuyente")
        cxn.fLlenaDropDownUltra(ucoRuta, "SELECT id_ruta,Nombre from rutas")
        cxn.fLlenaDropDownUltra(ucoLocalidad, "Select clave, nombre from localidades")
        cxn.fLlenaDropDownUltra(ucoPae, "Select clave, nombre from Pae")
        cxn.fLlenaDropDownUltra(ucoTipoContribuyente, "Select  cve_tip_con, descricion from tip_contribuyente")
    End Sub
    Private Sub load_Permiso()
        Me.btnElimina.Visible = False
        btnUndo.Visible = True
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        'Me.grpServicio.Enabled = IIf(id = "0", True, False)
        Me.grpDatosCuenta.Enabled = IIf(id = "0", True, False)
        Me.grpPropietario.Enabled = IIf(id = "0", True, False)
        Me.grpPAE.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            'txtCuenta.ReadOnly = False
            Me.BindingNavigator1.BindingSource.AddNew()
            Dim cxn2 As New cxnData
            cxn2.Select_SQL("SELECT RIGHT('00000000'+ CONVERT(VARCHAR(20),MAX(NUM_CUENTA)+1),8),dbo.getdateMx(),12,year(dbo.getdateMx())-1 FROM ARC_AGUA")
            Me.ArcaguaBindingSource.Current("num_cuenta") = cxn2.arrayValores(0)
            Me.ArcaguaBindingSource.Current("ult_mes_pago") = cxn2.arrayValores(2)
            Me.ArcaguaBindingSource.Current("ult_año_pago") = cxn2.arrayValores(3)
            Me.ArcaguaBindingSource.Current("fec_contrato") = cxn2.arrayValores(1)
            Me.ArcaguaBindingSource.Current("num_servicios") = 1
            Me.txtCuenta.Focus()
        Else
            'txtCuenta.ReadOnly = True
            Dim cxn1 As New cxnData
            cxn1.Select_SQL("select tipo_inmueble,diametro_toma,ult_lectura,num_medidor from arc_agua where num_cuenta='" & id & "'")
            Select Case Valida_Usuario_Servicio()
                Case 0
                    Me.cmbMedidor.SelectedValue = cxn1.arrayValores(0)
                Case 1
                    Me.cmbMedidor.SelectedValue = cxn1.arrayValores(1)
                Case 2
                    Me.uneUltimaLectura.Value = cxn1.arrayValores(2)
                    Me.cmbMedidor.Text = cxn1.arrayValores(3)
            End Select
        End If
    End Sub
    Private Sub ucoLocalidad_ValueChanged(sender As Object, e As EventArgs) Handles ucoLocalidad.ValueChanged
        Try
            If Me.ucoLocalidad.Value IsNot Nothing Then
                cxn.fLlenaDropDownUltra(ucoColonia, "SELECT id_colonia,nom_colonia from colonias where cve_loc='" & Me.ucoLocalidad.Value.ToString & "'")
                ucoColonia.Value = Nothing
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

#Region "Usuario_Servicio"
    Private Function Valida_Usuario_Servicio() As Integer
        Dim tipo_servicio As Integer = -1
        Me.cmbMedidor.Visible = True
        Me.lblMedidor.Visible = True
        Me.lblUltLectura.Visible = False
        Me.uneUltimaLectura.Visible = False
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
                cxn.Get_SQL_Combobox("SELECT * from tbl_DiametroToma", Me.cmbMedidor, "Diametro", "Diametro")
            End If
            Me.cmbMedidor.DropDownStyle = ComboBoxStyle.DropDownList
            tipo_servicio = 1
        Else

            Me.lblUltLectura.Visible = True
            Me.uneUltimaLectura.Visible = True
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim UltimaLectura As Decimal = 0

            If valida_datos() Then
                If id <> "0" Then
                    Me.Validate()

                    If optTipoServicio.Value = 1 Then
                        'Si tipo de servicio es medido
                        Me.ArcaguaBindingSource.Current("ult_lectura") = Me.uneUltimaLectura.Value
                        Me.ArcaguaBindingSource.Current("num_medidor") = Me.cmbMedidor.Text
                    End If
                    If optTipoServicio.Value = 2 Then
                        'si tipo de servicio es cuota fija
                        If optUsuario.Value = 1 Then
                            'si es domestico
                            Me.ArcaguaBindingSource.Current("tipo_inmueble") = Me.cmbMedidor.SelectedValue
                        End If
                        If optUsuario.Value = 2 Then
                            'si es comercial
                            Me.ArcaguaBindingSource.Current("diametro_toma") = Me.cmbMedidor.SelectedValue
                        End If
                    End If
                    Me.ArcaguaBindingSource.Current("Usuario") = "Usuario"
                    Me.ArcaguaBindingSource.EndEdit()
                    Me.Arc_aguaTableAdapter.Update(Me.DsAgua.arc_agua)

                    'Me.cxn.Select_SQL("exec sp_arcagua_registramovtos '" & Me.txtCuenta.Text.Trim & "','A','" & My.User.Name.ToString & "'")
                    ' If cxn.arrayValores(0).ToString = "1" Then
                    ActivaFormulario(False)
                    cMensajes.DisplayMessage(Me, "Datos actualizados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    Dim tipo_inmueble As Integer = 0
                    Dim diametro_toma As Integer = 0
                    Dim ult_lect As Integer = 0
                    Dim num_medidor As String = ""
                    If optTipoServicio.Value = 1 Then
                        'Si tipo de servicio es medido
                        ult_lect = Me.uneUltimaLectura.Value
                        num_medidor = Me.cmbMedidor.Text
                    End If
                    If optTipoServicio.Value = 2 Then
                        'si tipo de servicio es cuota fija
                        If optUsuario.Value = 1 Then
                            'si es domestico
                            tipo_inmueble = Me.cmbMedidor.SelectedValue.ToString
                        End If
                        If optUsuario.Value = 2 Then
                            'si es comercial
                            diametro_toma = Me.cmbMedidor.SelectedValue.ToString
                        End If
                    End If

                    Arc_aguaTableAdapter.Insert(Me.txtCuenta.Text.Trim.ToUpper,
                                            Me.txtRfc.Text,
                                            Me.txtNombre.Text.Trim.ToUpper,
                                            Me.txtCalle.Text.Trim,
                                            Me.txtNoInt.Text.Trim,
                                            Me.txtNoExt.Text.Trim,
                                            Me.txtCP.Text.Trim,
                                            Me.txtDomicilio.Text,
                                            Me.ucoTipoContribuyente.Value,
                                            Me.ucoColonia.Value,
                                            Me.ucoLocalidad.Value,
                                            "",
                                            Me.txtCvecatastral.Text.Trim,
                                            Me.optUsuario.Value.ToString,
                                            tipo_inmueble,
                                           Me.optTipoServicio.Value.ToString,
                                            diametro_toma,
                                            0,
                                            CDec(Me.ucoUltMes.Text).ToString, ' ultimo mes pago
                                            CDec(Me.uneUltAnio.Value).ToString,'Ultimo Pago
                                            txtFechaContrato.Value,
                                            Me.ucoStatus.Value.ToString,
                                             Me.chkNotificado.Checked,
                                             IIf(Me.chkNotificado.Checked = True, Me.txtNoOficioPae.Text, Nothing),'numero oficio pae,
                                             IIf(Me.chkNotificado.Checked = True, Me.txtFecPAE.Value, Nothing),'fec notif
                                             "",
                                            ult_lect,
                                            CDec(txtNoServs.Value).ToString,
                                            IIf(Me.ucoRuta.Value IsNot Nothing, Me.ucoRuta.Value, 1).ToString,
                                            Me.txtFechaContrato.Value,
                                            num_medidor, 0,
                                            IIf(Me.chkNotificado.Checked = True, Me.txtNoActos.Value, Nothing),
                                             IIf(Me.chkNotificado.Checked = True, Me.ucoPae.Value, Nothing),
                                            Me.txtObservaciones.Text.Trim,
                                            1,
                                            IIf(Me.chkDrenaje.Checked, 1, 0).ToString,
                                            Me.optFormaPago.Value.ToString,
                                            txtCurp.Text,
                                            txtTel.Text,
                                            txtemail.Text,
                                            CurrentUsrName.ToString,
                                            IIf(Me.txtLatitud.Text.Trim <> "", Me.txtLatitud.Text.Trim, ""),
                                            IIf(Me.txtLongitud.Text.Trim <> "", Me.txtLongitud.Text.Trim, "")
                                            )

                    Arc_aguaTableAdapter.Update(DsAgua.arc_agua)
                    cMensajes.DisplayMessage(Me, "Datos Registrados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    id = Me.txtCuenta.Text.Trim.ToUpper
                    frmarcAguaDatos_Load(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ArcaguaBindingSource.CancelEdit()
        ActivaFormulario(False)
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub ArcaguaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ArcaguaBindingSource.CurrentChanged
        Try
            If id <> "0" Then
                Select Case Valida_Usuario_Servicio()
                    Case 0
                        Me.cmbMedidor.SelectedValue = Me.ArcaguaBindingSource.Current("tipo_inmueble")
                    Case 1
                        Me.cmbMedidor.SelectedValue = Me.ArcaguaBindingSource.Current("diametro_toma")
                    Case 2
                        Me.uneUltimaLectura.Value = Me.ArcaguaBindingSource.Current("ult_lectura")
                        Me.cmbMedidor.SelectedValue = Me.ArcaguaBindingSource.Current("num_medidor")
                End Select

                If Me.ArcaguaBindingSource.Current("status_cta") = 0 Then
                    Me.lblStatusCuenta.Text = "Cuenta Eliminada"
                    Me.lblStatusCuenta.ForeColor = Color.Red
                    Me.grpDatosCuenta.Enabled = False
                    Me.grpPAE.Enabled = False
                    Me.grpPropietario.Enabled = False
                    Me.btnGuardar.Enabled = False
                    Me.btnUndo.Enabled = False
                    '   cMensajes.DisplayMessage(Me, "La cuenta ha sido eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    Me.lblStatusCuenta.Text = "Cuenta Activa"
                    Me.lblStatusCuenta.ForeColor = Color.Green
                    If Insertar Or Editar Then
                        Me.grpDatosCuenta.Enabled = True
                        Me.grpPAE.Enabled = True
                        Me.grpPropietario.Enabled = True
                        Me.btnGuardar.Enabled = True
                        Me.btnUndo.Enabled = True
                    End If

                End If
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""

        Try
            ErrorProvider1.Clear()

            'If Me.txtCvecatastral.Text.Trim.Length > 0 Then
            '    'If Me.txtCvecatastral.Text.Length = 16 Then
            '    '    cxn.Select_SQL("select cve_catastral from arc_predial where cve_catastral='" & Me.txtCvecatastral.Text.Trim & "'")
            '    '    If cxn.arrayValores(0) Is Nothing Then
            '    '        ErrorProvider1.SetError(txtCvecatastral, "Error")
            '    '        mensaje += "- " & "La clave catastral no existe, verifique." & "<br />"
            '    '        ocurriounError += 1
            '    '        Me.txtCvecatastral.SelectAll()
            '    '    End If
            '    'Else
            '    '    ErrorProvider1.SetError(txtCvecatastral, "Error")
            '    '    ocurriounError += 1
            '    '    mensaje += "- " & "Clave catastral erronéa, verifique." & "<br />"
            '    '    txtCvecatastral.Focus()
            '    'End If
            'Else
            '    ErrorProvider1.SetError(txtCvecatastral, "Error")
            '    ocurriounError += 1
            '    mensaje += "- " & "El campo clave catastral es requerido." & "<br />"
            '    txtCvecatastral.Focus()
            'End If

            If Me.ucoTipoContribuyente.IsItemInList = False Then
                ErrorProvider1.SetError(ucoTipoContribuyente, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el tipo de contribuyente." & "<br />"
                Me.ucoTipoContribuyente.Focus()
            End If

            If Me.ucoStatus.IsItemInList = False Then
                ErrorProvider1.SetError(ucoStatus, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el status del contribuyente." & "<br />"
                Me.ucoStatus.Focus()
            End If

            If Me.ucoRuta.IsItemInList = False Then
                ErrorProvider1.SetError(ucoRuta, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la ruta." & "<br />"
                Me.ucoRuta.Focus()
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


            'datos del propietario
            If Me.txtNombre.Text.Trim = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre o razón social es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If
            If Me.txtDomicilio.Text.Trim.Trim = "" Then
                ErrorProvider1.SetError(txtDomicilio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo domicilio fiscal es requerido." & "<br />"
                Me.txtDomicilio.Focus()
            End If

            If Me.ucoLocalidad.IsItemInList = False Then
                ErrorProvider1.SetError(ucoLocalidad, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la localidad." & "<br />"
                Me.ucoLocalidad.Focus()
            End If

            If Me.ucoColonia.IsItemInList = False Then
                ErrorProvider1.SetError(ucoColonia, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la colonia." & "<br />"
                Me.ucoColonia.Focus()
            End If

            If txtRfc.Text <> String.Empty Then
                If Regex.IsMatch(txtRfc.Text.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([A-Z]|[0-9]){2}([A]|[0-9]){1})?$") = False Then
                    ErrorProvider1.SetError(txtRfc, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese el RFC en un formato válido." & "<br />"
                    txtRfc.Focus()
                End If
            End If
            If txtCurp.Text <> String.Empty Then
                If Regex.IsMatch(txtCurp.Text.Trim, "[A-Z][A,E,I,O,U,X][A-Z]{2}[0-9]{2}[0-1][0-9][0-3][0-9][M|H](AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9,A-Z][0-9]$") = False Then
                    ErrorProvider1.SetError(txtCurp, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la curp en un formato válido." & "<br />"
                    txtCurp.Focus()
                End If
            End If

            If Me.txtNoExt.Text.Trim = "" Then
                ErrorProvider1.SetError(txtNoExt, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo número exterior es requerido." & "<br />"
                Me.txtNoExt.Focus()
            End If

            If Len(Me.uneUltAnio.Text.Trim) = 4 Then
                If Year(Now()) < Me.uneUltAnio.Value Then
                    ErrorProvider1.SetError(uneUltAnio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El año de pago no puede ser mayor al año actual, verifique." & "<br />"
                    Me.uneUltAnio.SelectAll()
                    Me.uneUltAnio.Focus()
                End If
            Else
                ErrorProvider1.SetError(uneUltAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año de pago es incorrecto, verifique." & "<br />"
                Me.uneUltAnio.SelectAll()
                Me.uneUltAnio.Focus()
            End If

            If Me.ucoUltMes.Text.Trim.Length > 0 Then
                If Me.ucoUltMes.Text <= 0 Or ucoUltMes.Text >= 13 Then
                    ErrorProvider1.SetError(ucoUltMes, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                    Me.ucoUltMes.SelectAll()
                    Me.ucoUltMes.Focus()
                End If
            Else
                ErrorProvider1.SetError(ucoUltMes, "Error")
                ocurriounError += 1
                mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                Me.ucoUltMes.SelectAll()
                Me.ucoUltMes.Focus()
            End If

            If Me.txtNoServs.Value = 0 Then
                ErrorProvider1.SetError(txtNoServs, "Error")
                ocurriounError += 1
                mensaje += "- " & "El Número de servicios es requerido..." & "<br />"
                Me.txtNoServs.SelectAll()
                Me.txtNoServs.Focus()
            End If

            If Me.txtCuenta.Text.Trim.Length <> 8 Then
                ErrorProvider1.SetError(txtCuenta, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Cuenta es requerido y debe tener una longitud de 8 digitos" & "<br />"
                txtCuenta.Focus()
                txtCuenta.SelectAll()
            End If

            If Not IsDate(txtFechaContrato.Value) Then
                ErrorProvider1.SetError(txtFechaContrato, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fecha del contrato es requerido." & "<br />"
                Me.txtFecPAE.Focus()
            End If

            If optTipoServicio.Value = 1 Then
                'Si tipo de servicio es medido
                If uneUltimaLectura.Value = 0 Then
                    ErrorProvider1.SetError(uneUltimaLectura, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo última lectura es requerido." & " < br /> "
                    Me.cmbMedidor.Focus()
                End If
                If cmbMedidor.Text = "" Then
                    ErrorProvider1.SetError(cmbMedidor, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo número de medidor es requerido." & " < br /> "
                    Me.cmbMedidor.Focus()
                End If
            End If

            If optTipoServicio.Value = 2 Then
                If cmbMedidor.SelectedValue = -1 Then
                    'Si tipo de servicio es medido
                    ErrorProvider1.SetError(cmbMedidor, "Error")
                    ocurriounError += 1
                    If optUsuario.Value = 1 Then
                        mensaje += "- " & "El campo tipo de inmueble es requerido." & " < br /> "
                    End If
                    If optUsuario.Value = 2 Then
                        mensaje += "- " & "El campo diámetro de la toma es requerido." & " < br /> "
                    End If
                    Me.cmbMedidor.Focus()
                End If
            End If


            'valida el PAE
            If chkNotificado.Checked = True Then
                If ucoPae.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoPae, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo etapa es requerido." & "<br />"
                    Me.ucoPae.Focus()
                End If

                If txtNoOficioPae.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtNoOficioPae, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo oficio número es requerido." & "<br />"
                    Me.txtNoOficioPae.Focus()
                End If

                If Not IsDate(txtFecPAE.Value) Then
                    ErrorProvider1.SetError(txtFecPAE, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo fecha actos es requerido." & "<br />"
                    Me.txtFecPAE.Focus()
                End If

                If IsDBNull(txtNoActos.Value) Then
                    ErrorProvider1.SetError(txtNoActos, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo número de acto es requerido." & "<br />"
                    Me.txtNoActos.Focus()
                End If

                If Not IsDBNull(txtNoActos.Value) Then
                    If txtNoActos.Value = 0 Then
                        ErrorProvider1.SetError(txtNoActos, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "El campo número de actos es requerido." & "<br />"
                        Me.txtNoActos.Focus()
                    End If
                End If
            End If
            If ocurriounError > 0 Then
                ban = False
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = True
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        If MsgBox("Se borrarán todos los datos." & vbCrLf & "¿Desea continuar con la operación?", vbYesNo, "Confirmación") = vbYes Then

            Me.cxn.Select_SQL("exec sp_agua_eliminapadron '" & Me.txtCuenta.Text.Trim & "'")
            If cxn.arrayValores(0).ToString = "" Then
                cMensajes.DisplayMessage(Me, "Datos eliminados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.Close()
            Else
                cMensajes.DisplayMessage(Me, "Error: " & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

        End If
    End Sub

    Private Sub optTipoServicio_Click(sender As Object, e As EventArgs) Handles optTipoServicio.Click
        Valida_Usuario_Servicio()
    End Sub

    Private Sub optUsuario_Click(sender As Object, e As EventArgs) Handles optUsuario.Click
        Valida_Usuario_Servicio()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Me.ArcaguaBindingSource.Position = Me.ArcaguaBindingSource.Find("num_cuenta", id)
    End Sub

    Private Sub optUsuario_MouseClick(sender As Object, e As MouseEventArgs) Handles optUsuario.MouseClick
        Valida_Usuario_Servicio()
    End Sub


    Private Sub optTipoServicio_MouseClick(sender As Object, e As MouseEventArgs) Handles optTipoServicio.MouseClick
        Valida_Usuario_Servicio()
    End Sub

    Private Sub optUsuario_ValueChanged(sender As Object, e As EventArgs) Handles optUsuario.ValueChanged
        Valida_Usuario_Servicio()
    End Sub

    Private Sub optTipoServicio_ValueChanged(sender As Object, e As EventArgs) Handles optTipoServicio.ValueChanged
        Valida_Usuario_Servicio()
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmarcAguaDatos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmarcAguaDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub chkNotificado_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotificado.CheckedChanged
        If chkNotificado.Checked = True Then
            panNotificado.Enabled = True
        Else
            panNotificado.Enabled = False
            ucoPae.Value = Nothing
            txtNoActos.Value = Nothing
            txtFecPAE.Value = Nothing
            txtNoOficioPae.Text = ""
        End If
    End Sub
    Private Sub txtRfc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRfc.KeyPress
#Region "valida rfc"
        If Char.IsLetterOrDigit(e.KeyChar) Then
            Dim Posicion As Integer = txtRfc.SelectionStart + 1
            If Posicion >= 1 Or Posicion <= 3 Then
                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            If Posicion = 4 Then
                If Char.IsLetterOrDigit(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            'si es numero es persona moral
            If Posicion >= 5 Then
                Dim pm As Boolean = False
                Dim pf As Boolean = False
                If Char.IsDigit(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona moral
                    pm = True
                End If

                If Char.IsLetter(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona fisica
                    pf = True
                End If
                If Char.IsDigit(e.KeyChar) = True Then
                    If pf = True Then
                        If Posicion >= 5 And Posicion <= 10 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If
                    If pm = True Then
                        If Posicion >= 5 And Posicion <= 9 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If

                Else
                    e.Handled = True
                End If
                'valida resto de la cadena
                If Posicion > 9 And Posicion <= 12 And pm = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
                If Posicion > 10 And Posicion <= 13 And pf = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        Else
            e.Handled = True
        End If

        If e.KeyChar = vbBack Then
            e.Handled = False
        End If
#End Region
    End Sub
    Private Sub ActivaFormulario(enable As Boolean)
        grpDatosCuenta.Enabled = enable
        grpPropietario.Enabled = enable
        grpPAE.Enabled = enable
        grpUltimoPago.Enabled = enable
        btnGuardar.Visible = enable
        btnEditar.Visible = True
        Me.ucoTipoContribuyente.Enabled = enable
        Me.ucoStatus.Enabled = enable
        Me.ucoRuta.Enabled = enable
        Me.ucoStatus.Enabled = enable
        Me.txtNoServs.Enabled = enable
        Me.grpTipoUsuario.Enabled = enable
        Me.grpServicio.Enabled = enable
        Me.grpFormaPago.Enabled = enable
        Me.txtFechaContrato.Enabled = enable
        Me.cmbMedidor.Enabled = enable
        Me.uneUltimaLectura.Enabled = enable
        Me.chkDrenaje.Enabled = enable
        Me.txtLatitud.Enabled = enable
        Me.txtLongitud.Enabled = enable
        'txtCuenta.ReadOnly = Enabled
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'valida permiso de edicion
            ActivaFormulario(True)
            btnGuardar.Visible = Insertar
            btnGuardar.Enabled = True
            btnEditar.Visible = False
            Me.btnElimina.Visible = Borrar
            txtCvecatastral.Focus()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim frm As New Padron_Imagenes
        frm.Show(txtCuenta.Text.Trim, "AGUA", Me)
    End Sub

    Private Sub btnMapa_Click(sender As Object, e As EventArgs) Handles btnMapa.Click
        Dim frm As New frmGoogleMaps
        frm.txtLatitud.Text = Me.txtLatitud.Text
        frm.txtLongitud.Text = Me.txtLongitud.Text
        frm.lblTipoPadron.Text = "arc_Agua"
        frm.lblClavePadron.Text = Me.txtCuenta.Text
        frm.lblCampo.Text = "num_cuenta"
        frm.lblNombreContribuyente.Text = Me.txtNombre.Text
        frm.ShowDialog(Me)
        'Me.frmarcAguaDatos_Load(Nothing, Nothing)
        Try
            Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
        Catch ex As Exception

        End Try

        Me.ArcaguaBindingSource.Position = Me.ArcaguaBindingSource.Find("num_cuenta", id)
    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click

        Me.id = Me.txtCuenta.Text
        load_Combos()
        Valida_Usuario_Servicio()
        If id <> "0" Then
            Me.Arc_aguaTableAdapter.Fill(Me.DsAgua.arc_agua, id)
            If Me.DsAgua.arc_agua.Rows.Count > 0 Then
                Me.BindingNavigator1.Visible = True
                ActivaFormulario(True)
            End If
        Else
            ActivaFormulario(True)
        End If
        load_Combos()
        load_Permiso()
    End Sub
End Class