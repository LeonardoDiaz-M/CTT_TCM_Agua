Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmFormaPago
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public myparent As Form = Nothing
    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        'Me.Fma_pagoTableAdapter.Fill(Me.DsAgua.fma_pago)
        load_Permiso()
        If id <> "0" Then
            Me.BindingSource1.Position = Me.BindingSource1.Find("forma_pago", id)
        End If
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpDatosCuenta.Enabled = IIf(id = "0", True, False)
        Me.txtClave.ReadOnly = True
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            Me.txtClave.ReadOnly = False
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtPago.Text.Trim.Length > 0 Then
                ban = True
            Else
                cMensajes.DisplayMessage(Me, "El campo Forma de Pago es requerido", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtPago.Focus()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function

    Private Sub frmFormaPago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If Editar And id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    'Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Insertar And id = "0" Then
                    'Fma_pagoTableAdapter.Insert(Me.txtPago.Text.Trim.ToUpperInvariant)
                    'Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    id = Me.txtClave.Text
                    frmFormaPago_Load(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnElimina_Click_1(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                'Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                cMensajes.DisplayMessage(Me, "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Contribuyente")
                Me.Close()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grpDatosCuenta.Enabled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
End Class