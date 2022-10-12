Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinEditors

Public Class frmParamBasic
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Private currentmenu As String = currentmenu

    Private Sub frmParamBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
            If id <> "0" Then
                Me.ParametrTableAdapter.Fill(Me.DsParametros.parametr)
                Me.ParametrBindingSource.Position = Me.ParametrBindingSource.Find("id_parametro", id)
            End If
            load_Permiso()
            uneAnio.SelectAll()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub
    Private Sub load_Permiso()
        Dim ban_enabled As Boolean = False
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grParImpPred.Enabled = IIf(id = "0", True, False)
        Me.grpGral.Enabled = IIf(id = "0", True, False)
        Me.grpimppred.Enabled = IIf(id = "0", True, False)
        Me.grpLicMun.Enabled = IIf(id = "0", True, False)
        Me.grpParBasico.Enabled = IIf(id = "0", True, False)
        Me.gpogpos.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            cxn.Select_SQL("select ejerfis from parametr where id_parametro=" & id.ToString)
        Else
            cxn.Select_SQL("select year(dbo.getdateMx())")
            Dim cxn2 As New cxnData
            cxn2.Select_SQL("select ejerfis from parametr where ejerfis=" & cxn.arrayValores(0))
            If cxn2.arrayValores(0) IsNot Nothing Then
                ShowContinueMessage("EL EJERCICIO FISCAL DE ESTE AÑO YA HA SIDO CAPTURADO")
                Me.Close()
            End If
            uneAnio.ReadOnly = False
            uneAnio.Value = Nothing
        End If
        Me.lblEjFiscal.Text = "Ejercicio Fiscal: " & cxn.arrayValores(0).ToString
        btnBack.Visible = True
    End Sub
    Private Function ShowContinueMessage(ByVal message As String) As DialogResult
        Using ultraMessageBoxInfo As New UltraMessageBoxInfo()
            ' Set the general display style 
            ultraMessageBoxInfo.Style = MessageBoxStyle.Vista

            ' Set the text for the Text, Caption, Header and Footer 
            ultraMessageBoxInfo.Text = message
            ultraMessageBoxInfo.Caption = ""
            ultraMessageBoxInfo.Header = "PARAMETROS DEL SISTEMA"
            ultraMessageBoxInfo.Footer = "Error, Ejercicio ya registrado"

            ' Specify which buttons should be used and which is the default button 
            ultraMessageBoxInfo.Buttons = MessageBoxButtons.OK
            'ultraMessageBoxInfo.DefaultButton = MessageBoxDefaultButton.Button2
            ultraMessageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.[False]

            ' Display the OS Error Icon 
            ultraMessageBoxInfo.Icon = MessageBoxIcon.Error

            ' Disable the default sounds 
            ultraMessageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]

            ' Show the UltraMessageBox 
            Dim resp As DialogResult = Me.UltraMessageBoxManager1.ShowMessageBox(ultraMessageBoxInfo)
            Return resp
        End Using
    End Function

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If id = "0" Then
                If uneAnio.Value < 2000 Then
                    ErrorProvider1.SetError(uneAnio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo año es requerido y debe ser mayor a el ejercicio actual." & "<br />"
                    Me.uneAnio.SelectAll()
                Else
                    cxn.Select_SQL("select count(ejerfis) from parametr where ejerfis='" & uneAnio.Value.ToString & "'")
                    Dim Registros As Integer = cxn.arrayValores(0)

                    If Registros > 0 Then
                        ErrorProvider1.SetError(uneAnio, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "Ya existen parametros registrados para el ejercicio ingresado." & "<br />"
                        Me.uneAnio.SelectAll()
                    End If
                End If
            End If

            If Me.uneSalarioMinimoC.Value <= 9 Then
                ErrorProvider1.SetError(uneSalarioMinimoC, "Error")
                ocurriounError += 1
                mensaje += "- " & "Ingrese la Unidad de Medida y Actualización." & "<br />"
                Me.uneSalarioMinimoC.SelectAll()
            End If

            If Me.uneFactorMultas.Value <= 0 Then
                ErrorProvider1.SetError(uneFactorMultas, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Multas para contribuyentes requeridos debe ser mayor a CERO" & "<br />"
                Me.uneFactorMultas.SelectAll()
            End If

            If Me.uneRecContEsp.Value <= 0 Then
                ErrorProvider1.SetError(uneRecContEsp, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Recargos para contribuyentes espontáneos es requerido y debe ser mayor a CERO" & "<br />"
                Me.uneRecContEsp.SelectAll()
            End If

            If Me.uneRecContMor.Value <= 0 Then
                ErrorProvider1.SetError(uneRecContMor, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Recargos para contribuyentes morosos es requerido y debe ser mayor a CERO" & "<br />"
                Me.uneRecContMor.SelectAll()
            End If

            If Me.uneMaxIncremAnual.Value <= 0 Then
                ErrorProvider1.SetError(uneMaxIncremAnual, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Máximo incremento anual es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneMaxIncremAnual.SelectAll()
            End If


            If Me.uneMesIniRecarg.Value < 1 Or Me.uneMesIniRecarg.Text >= 13 Then
                ErrorProvider1.SetError(uneMesIniRecarg, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Mes Inicio de recargos no es correcto, verifique." & "<br />"
                Me.uneMesIniRecarg.SelectAll()
            End If

            If Me.uneDiaIniRecarg.Value < 1 Or Me.uneDiaIniRecarg.Text >= 32 Then
                ErrorProvider1.SetError(uneDiaIniRecarg, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo día Inicio de recargos no es correcto, verifique." & "<br />"
                Me.uneDiaIniRecarg.SelectAll()
            End If

            If Me.uneGruCobroAgua.Value <= 0 Then
                ErrorProvider1.SetError(uneGruCobroAgua, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo para cobro de agua es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneGruCobroAgua.SelectAll()
            End If
            If Me.uneGruLicVtaAlcohol.Value <= 0 Then
                ErrorProvider1.SetError(uneGruLicVtaAlcohol, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo para Licencias venta de alcohol, es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneGruLicVtaAlcohol.SelectAll()
            End If

            If Me.uneFactorDrenaje.Value <= 0 Then
                ErrorProvider1.SetError(uneFactorDrenaje, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo factor drenaje, es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneFactorDrenaje.SelectAll()
            End If

            If Me.uneGruDesUrbano.Value <= 0 Then
                ErrorProvider1.SetError(uneGruDesUrbano, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Desarrollo Urbano es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneGruDesUrbano.SelectAll()
            End If

            If Me.uneGrupoMunSalarios.Value <= 0 Then
                ErrorProvider1.SetError(uneGrupoMunSalarios, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Municipio salarios es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneGrupoMunSalarios.SelectAll()
            End If

            If Me.uneConsumoMinimoAgua.Value <= 0 Then
                ErrorProvider1.SetError(uneConsumoMinimoAgua, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo consumo mínimo agua es obligatorio y debe ser mayor a CERO" & "<br />"
                Me.uneConsumoMinimoAgua.SelectAll()
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmPredial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If id <> "0" Then
                    Me.Validate()
                    Me.ParametrBindingSource.EndEdit()
                    Me.ParametrTableAdapter.Update(Me.DsParametros.parametr)
                    Me.panParametros.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                Else
                    id = ParametrTableAdapter.Insert(Me.uneAnio.Value, CDec(Me.uneSalarioMinimoC.Value), Me.uneSalarioMinimoA.Value,
                                                CDec(Me.uneFactorPredial.Value), CDec(Me.uneMesIniRecarg.Value), CDec(Me.uneDiaIniRecarg.Value),
                                                CDec(Me.uneRecContEsp.Value), CDec(Me.uneRecContMor.Value), CDec(Me.uneFactorMultas.Value),
                                                CDec(Me.uneMesIniRecarg.Value), CDec(Me.uneDiaIniRecarg.Value), CDec(Me.uneMaxIncremAnual.Value),
                                                 CDec(Me.uneGruCobroAgua.Value), CDec(Me.uneGruLicVtaAlcohol.Value), CDec(Me.uneGruDesUrbano.Value),
                                                 CDec(Me.uneGrupoMunSalarios.Value), CDec(Me.uneFactorDrenaje.Value), CDec(uneConsumoMinimoAgua.Value))
                    Me.ParametrTableAdapter.Update(Me.DsParametros.parametr)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                Me.frmParamBasic_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grParImpPred.Enabled = True
            Me.grpGral.Enabled = True
            Me.grpimppred.Enabled = True
            Me.grpLicMun.Enabled = True
            Me.grpParBasico.Enabled = True
            Me.gpogpos.Enabled = True
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        ParametrBindingSource.CancelEdit()
        If id <> "0" Then
            btnElimina.Visible = True
            btnGuardar.Visible = False
            btnEditar.Visible = True
            panParametros.Enabled = False
        Else
            btnElimina.Visible = False
            btnGuardar.Visible = True
            btnEditar.Visible = False
            panParametros.Enabled = True
        End If


    End Sub

    Private Sub frmParamBasic_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                Me.ParametrTableAdapter.Update(Me.DsParametros.parametr)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class