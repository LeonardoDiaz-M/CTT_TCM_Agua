Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatDiasInhabiles
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public myParent As Form = Nothing
    Private Sub frmCatDiasInhabiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        Me.Tbl_dias_inhabilesTableAdapter.Fill(Me.DsParametros.tbl_dias_inhabiles)
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpOficinas.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
            Me.grpOficinas.Enabled = True
        Else
            Me.TbldiasinhabilesBindingSource.Position = Me.TbldiasinhabilesBindingSource.Find("id", id)
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If Not IsDate(dtpFecha.Value) Then
                ErrorProvider1.SetError(dtpFecha, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fecha es requerido." & "<br />"
                Me.dtpFecha.Focus()
            End If

            If txtObservacion.Text = "" Then
                ErrorProvider1.SetError(txtObservacion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo observación es requerido." & "<br />"
                Me.txtObservacion.Focus()
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
                    Me.TbldiasinhabilesBindingSource.EndEdit()
                    Me.Tbl_dias_inhabilesTableAdapter.Update(Me.DsParametros.tbl_dias_inhabiles)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Tbl_dias_inhabilesTableAdapter.Insert(dtpFecha.Value, txtObservacion.Text)
                    id = Me.Tbl_dias_inhabilesTableAdapter.Update(Me.DsParametros.tbl_dias_inhabiles)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If

                Me.frmCatDiasInhabiles_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        grpOficinas.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tbl_dias_inhabilesTableAdapter.Update(DsParametros.tbl_dias_inhabiles)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmCatDiasInhabiles_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub


    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("nom_colonia", txtBusca.Text)
    'End Sub

    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        TbldiasinhabilesBindingSource.CancelEdit()
    End Sub

    Private Sub frmCatDiasInhabiles_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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