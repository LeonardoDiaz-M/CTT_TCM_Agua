Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmWebParametros
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Private Sub frmWebParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cxn As New cxnData
            TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
            cxn.Get_SQL_DataGrid("SELECT  [id] as Clave, [Tipo], [Descripcion], [Valor], [Status], [Visible],[Link]
                                FROM [base_mpio_New].[dbo].[tb_WEBParametros]
                                where Tipo <>'System' and SobreEscribe>0", Me.grdDataMain)
            Me.grdDataMain.Rows(0).Cells(0).Selected = True
            id = Me.grdDataMain.Rows(0).Cells(0).Text
            load_Permiso()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub load_Permiso()
        Me.lblCurrentMenu.Text = Me.Text
        Me.btnGuardar.Visible = True
        Me.grpDatosRol.Enabled = True
        Me.grpTree.Enabled = True
    End Sub
    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        Me.lblDesc.Text = Me.grdDataMain.ActiveRow.Cells(0).Text.Trim & "-" & Me.grdDataMain.ActiveRow.Cells(2).Text.Trim & "(" & Me.grdDataMain.ActiveRow.Cells(1).Text.Trim & ")"
        Me.chkActive.Checked = IIf(Me.grdDataMain.ActiveRow.Cells(4).Text.Trim = "1", True, False)
        Me.chkVisible.Checked = IIf(Me.grdDataMain.ActiveRow.Cells(5).Text.Trim = "1", True, False)
        Me.txtValor.Text = Me.grdDataMain.ActiveRow.Cells(3).Text.Trim
        Me.txtLink.Text = Me.grdDataMain.ActiveRow.Cells(6).Text.Trim
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.grdDataMain.Selected.Rows.Count > 0 Then
                If Me.txtValor.Text.Trim.Length > 0 Then
                    If Me.txtLink.Text.Trim.Trim.Length > 0 Then
                        ban = True
                    Else
                        cMensajes.DisplayMessage(Me, "El campo Descripción es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.txtLink.Focus()
                    End If
                Else
                    cMensajes.DisplayMessage(Me, "El campo Rol es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.txtValor.Focus()
                End If
            Else
                cMensajes.DisplayMessage(Me, "Debe seleccionar un registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If cxn.Select_SQL("update tb_WEBParametros 
                                set Valor='" & Me.txtValor.Text.Trim & "', Link='" & Me.txtLink.Text.Trim & "' 
                                where [id]=" & Me.grdDataMain.ActiveRow.Cells(0).Text.Trim) Then
                    If cxn.arrayValores(0) Is Nothing AndAlso cxn.err = "" Then
                        cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.lblDesc.Text = ""
                        Me.chkActive.Checked = False
                        Me.chkVisible.Checked = False
                        Me.txtValor.Text = ""
                        Me.txtLink.Text = ""
                        frmWebParametros_Load(Nothing, Nothing)
                    Else
                        cMensajes.DisplayMessage(Me, "Error " & vbCrLf & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                End If
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error " & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmWebParametros_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        id = Me.grdDataMain.Rows(0).Cells(0).Text
        load_Permiso()
    End Sub
End Class