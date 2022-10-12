Public Class frmAguaRegistroConsumo_Alta
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim OpcionCalculo As Integer = 0
        If valida_datos() = False Then
            cxn.Select_SQL("Select id_Ruta from arc_agua where num_cuenta='" & id & "'")
            If id <> "0" Then
                cxn.Select_SQL("update tbl_consumo_agua 
                                set Año=" & CType(txtanio.Value, Decimal) & ", 
                                    Bimestre=" & unePeriodo.Value & ", 
                                    consumo_bim=" & CType(uneConsumo.Value, Decimal) & ", 
                                    lect_ant=" & CType(uneLecturaAnterior.Value, Decimal) & ", 
                                    lect_act=" & CType(uneLecturaActual.Value, Decimal) & ", 
                                    Usuario ='" & CurrentUsrName & "',
                                    fec_captura= dbo.getdateMx(), TipoConsumo=99 
                                where idConsumo=" & id)
                If cxn.err <> "" Then
                    cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    cMensajes.DisplayMessage(Me, "Registro actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            Else

                Tbl_consumo_aguaTableAdapter.Insert(txtNumeroCuenta.Text,
                                                    CType(txtanio.Value, Decimal),
                                                    unePeriodo.Value,
                                                    CType(uneConsumo.Value, Decimal),
                                                    CType(uneLecturaActual.Value, Decimal),
                                                    CType(uneLecturaAnterior.Value, Decimal),
                                                    Date.Now, OpcionCalculo,
                                                    CurrentUsrName,
                                                    CType(cxn.arrayValores(0), Integer))
                cMensajes.DisplayMessage(Me, "Registro guardado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        End If
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta
            If Me.txtanio.Value Is Nothing Then
                ErrorProvider1.SetError(txtanio, "Error")
                ocurriounError += 1
                mensaje += "- " & "Ingrese el año." & "<br />"
                txtanio.SelectAll()
            End If

            If unePeriodo.Value < 1 And unePeriodo.Value > 6 Then
                ErrorProvider1.SetError(unePeriodo, "Error")
                ocurriounError += 1
                mensaje += "- " & "El Periodo debe estar entre 1 y 6 " & "<br />"
                unePeriodo.Focus()
            End If

            If uneLecturaActual.Value <= uneLecturaAnterior.Value Then
                ErrorProvider1.SetError(uneLecturaActual, "Error")
                ocurriounError += 1
                mensaje += "- " & "La lectura actual no puede ser menor o igual a la lectura Anterior." & "<br />"
                uneLecturaActual.SelectAll()
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub uneLecturaActual_ValueChanged(sender As Object, e As EventArgs) Handles uneLecturaActual.ValueChanged, uneLecturaAnterior.ValueChanged
        If uneLecturaActual.Value >= uneLecturaAnterior.Value Then
            uneConsumo.Value = uneLecturaActual.Value - uneLecturaAnterior.Value
        End If

    End Sub

    Private Sub frmAguaRegistroConsumo_Alta_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.id <> "0" Then
            cxn.Select_SQL("select num_cuenta,Año,Bimestre,Consumo_bim,Lect_Act,Lect_Ant from tbl_consumo_agua where idConsumo= " & Me.id) 'frmReg
            If cxn.err = "" Then
                Me.txtNumeroCuenta.Text = cxn.arrayValores(0)
                Me.txtanio.Text = cxn.arrayValores(1)
                Me.unePeriodo.Text = cxn.arrayValores(2)
                Me.uneConsumo.Text = cxn.arrayValores(3)
                Me.uneLecturaActual.Text = cxn.arrayValores(4)
                Me.uneLecturaAnterior.Text = cxn.arrayValores(5)
            Else
                cMensajes.DisplayMessage(Me, cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
        Me.txtNumeroCuenta.ReadOnly = True
    End Sub
End Class