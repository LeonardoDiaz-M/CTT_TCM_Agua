Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmMovtosPAdron
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing

    Private Sub frmMovtosPAdron_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.Tip_movtoTableAdapter.Fill(Me.DsCatalogos1.tip_movto)
        Me.BindingSource1.Position = Me.BindingSource1.Find("tip_movto", id)
        load_Permiso()
    End Sub

    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.txtClave.Enabled = False
        If Editar And id <> "0" Then  'Actualizar Registro
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
        ElseIf Insertar = 1 And id = "0" Then 'Agregar Registro           
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
        Me.lblCurrentMenu.Text = Me.Text
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtDesc.Text.Trim.Length > 0 Then
                ban = True
            Else
                cMensajes.DisplayMessage(Me, "El campo Descripción es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtDesc.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If Editar And id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Tip_movtoTableAdapter.Update(Me.DsCatalogos1.tip_movto)
                    cMensajes.DisplayMessage(Me, "Datos actualizados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    id = Tip_movtoTableAdapter.Insert(Me.txtDesc.Text.Trim.ToUpperInvariant)
                    Me.Tip_movtoTableAdapter.Update(Me.DsCatalogos1.tip_movto)
                    cMensajes.DisplayMessage(Me, "Datos actualizados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                Me.frmMovtosPAdron_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmMovtosPadron_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class