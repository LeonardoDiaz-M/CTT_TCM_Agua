Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmCatTipoinmueble
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmCatTipoinmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        If id <> "0" Then
            Me.Tipo_inmuebleTableAdapter.Fill(Me.DsAgua.tipo_inmueble)
            Me.BindingSource1.Position = Me.BindingSource1.Find("clave", id)
        End If
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnElimina.Visible = False
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)
        Me.grpDatosCuenta.Enabled = IIf(id = "0", True, False)

        If id = "0" Then
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtNombre.Text.Trim.Length > 0 Then
                If Me.txtNomCorto.Text.Trim.Trim.Length > 0 Then
                    ban = True
                Else
                    cMensajes.DisplayMessage(Me, "El campo Nombre Corto es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtNomCorto.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo Nombre es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtNombre.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Tipo inmueble")
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If Editar And id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Insertar Then
                    Tipo_inmuebleTableAdapter.Insert(Me.txtNombre.Text.Trim.ToUpperInvariant, Me.txtNomCorto.Text.Trim.ToUpperInvariant)
                    Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    id = Me.txtClave.Text.Trim
                    frmCatTipoinmueble_Load(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

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
End Class