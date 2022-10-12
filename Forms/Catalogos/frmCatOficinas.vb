Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatOficinas
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private Sub frmCatOficinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        load_Permiso()
        If id <> "0" Then
            Me.OficinasTableAdapter.Fill(Me.DsCatalogos.oficinas)
            Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("comun", id)
            btnElimina.Visible = True
            txtComun.ReadOnly = True
        End If
        txtNombre.SelectAll()
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpOficinas.Enabled = IIf(id = "0", True, False)
        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If txtComun.Text = "" Then
                ErrorProvider1.SetError(txtComun, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo id es requerido." & "<br />"
                Me.txtComun.Focus()
            End If

            If txtNombre.Text = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If

            If txtDireccion.Text = "" Then
                ErrorProvider1.SetError(txtDireccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo dirección es requerido." & "<br />"
                Me.txtDireccion.Focus()
            End If

            If txtResponsable.Text = "" Then
                ErrorProvider1.SetError(txtResponsable, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo responsable es requerido." & "<br />"
                Me.txtResponsable.Focus()
            End If

            If txtNombreAreaResponsable.Text = "" Then
                ErrorProvider1.SetError(txtNombreAreaResponsable, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre area responsable es requerido." & "<br />"
                Me.txtNombreAreaResponsable.Focus()
            End If

            If optTipoSalario.Value = 0 Then
                ErrorProvider1.SetError(optTipoSalario, "Error")
                ocurriounError += 1
                mensaje += "- " & "El tipo de salario es requerido." & "<br />"
                Me.optTipoSalario.Focus()
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
                    Me.OficinasBindingSource.EndEdit()
                    Me.OficinasTableAdapter.Update(Me.DsCatalogos.oficinas)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    OficinasTableAdapter.Insert(txtComun.Text.Trim, txtNombre.Text.Trim, txtDireccion.Text.Trim, txtResponsable.Text.Trim, txtNombreAreaResponsable.Text.Trim, txtContador.Text.Trim, txtNombreAreaContador.Text.Trim, txtResponsableFormasValoradas.Text.Trim, optTipoSalario.Value)
                    Me.OficinasTableAdapter.Update(Me.DsCatalogos.oficinas)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.btnEditar.Visible = False
        Me.btnGuardar.Visible = Editar
        Me.btnElimina.Visible = Borrar
        If Me.btnGuardar.Visible Then
            Me.grpOficinas.Enabled = True
        End If
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.OficinasTableAdapter.Update(DsCatalogos.oficinas)
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
    Private Sub frmCatOficinas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub


    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("nom_colonia", txtBusca.Text)
    'End Sub

    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        OficinasBindingSource.CancelEdit()
    End Sub

    Private Sub frmCatOficinas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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