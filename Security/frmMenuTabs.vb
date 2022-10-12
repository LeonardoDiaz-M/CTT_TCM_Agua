Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmMenuTabs
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Private cxn As New cxnData
    Public myParent As Form = Nothing
    Public SubMnu As String = ""
    Private Sub frmMenuTabs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Permiso()
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
    End Sub

    Private Sub load_Permiso()
        Get_Forms(Me.ddlForm)
        If id <> "0" Then
            cxn.Select_SQL("Select Parent+' \'+ SubMenu,
                                    TabName,Query,FormName,tabOrder,DockForm,tb.Status
                                from tbMainSubMenus sb 
                                    inner join tbMainMenuTabs tb on tb.Menu=sb.SubMenu 
                            where idTab=" & id)
            Me.lblCurrentMenu.Text = "Menu: " & cxn.arrayValores(0)
            Me.txtTabName.Text = cxn.arrayValores(1)
            Me.txtQuery.Text = cxn.arrayValores(2)
            If cxn.arrayValores(3) Is Nothing Or cxn.arrayValores(3) = "" Then
                Me.ddlForm.Value = ""
            Else
                Me.ddlForm.Value = cxn.arrayValores(3)
            End If
            Me.numPos.Value = cxn.arrayValores(4)
            Me.chkActivo.Checked = IIf(cxn.arrayValores(6) = "1", True, False)
            Me.chkModal.Checked = IIf(cxn.arrayValores(5) = "1", True, False)
        Else
            Me.lblCurrentMenu.Text = "SubMenu: " & SubMnu & " - Nuevo TAB"
        End If

    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtQuery.Text.ToLowerInvariant.Contains("delete") _
                Or Me.txtQuery.Text.ToLowerInvariant.Contains("insert") _
                Or Me.txtQuery.Text.ToLowerInvariant.Contains("update") _
                Or Me.txtQuery.Text.ToLowerInvariant.Contains("exec ") _
                Or Me.txtQuery.Text.ToLowerInvariant.Contains("execute ") Then
                cMensajes.DisplayMessage(Me, "Error en el query verifique ...!!.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
            If Me.txtTabName.Text.Trim.Length > 0 Then
                If (Me.txtQuery.Text.Trim.Trim.Length = 0 And Me.ddlForm.Value = "") Then
                    cMensajes.DisplayMessage(Me, "Debe colocar un query o elegir una Forma!!.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    ban = True
                End If
            Else
                cMensajes.DisplayMessage(Me, "El campo Tab Nombre es requerido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtTabName.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If valida_datos() Then

            Dim filtro As String = ""
                Dim query_test As String = ""
                If (Me.txtQuery.Text.ToLowerInvariant.Contains("<$filtro1$>")) Then
                    filtro = InputBox("Valor para el filtro:", "Filtro del query")
                    query_test = Me.txtQuery.Text.ToLowerInvariant.Replace("<$filtro1$>", filtro)
                Else
                    query_test = Me.txtQuery.Text
                End If
            'Dim grdQuery As New UltraGrid
            If Me.txtQuery.Text.Trim = "" And Me.ddlForm.SelectedRow.Cells(1).Value.Trim <> "" Then
                query_test = "Select '' as Resultado"
            End If
            If cxn.Get_SQL_DataGrid(query_test, Me.grdTabs) Then
                    Dim resp As DialogResult = DialogResult.Yes
                    If grdTabs.Rows.Count = 0 Then
                        cMensajes.DisplayMessage(Me, "El query no produjo resultados...",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        resp = ShowContinueMessage("Confirmar Acción", " ",
                                                             "No se encontrarón datos con el query" & vbCrLf &
                                                             "¿Desea Guardar los cambios?", Me.UltraMessageBoxManager1,
                                                             MessageBoxButtons.YesNo)
                    End If
                    If resp = DialogResult.Yes Then
                        If cxn.Select_SQL("select * from [tbMainMenuTabs] where idTab='" & id & "'") Then
                            If cxn.arrayValores(0) Is Nothing Then
                                Dim resp2 As DialogResult = ShowContinueMessage("Confirmar Acción", " ",
                                                             "Se agregará un nueva Pestaña (Tab)" & vbCrLf &
                                                             "¿Desea Continuar?", Me.UltraMessageBoxManager1,
                                                             MessageBoxButtons.YesNo)
                                If resp2 = vbYes Then
                                If cxn.Select_SQL(" insert into tbMainMenuTabs (Menu,TabName,Query,TabOrder,FormName,Status,DockForm)" &
                                                  " values ('" & SubMnu & "'," &
                                                           "'" & Me.txtTabName.Text.ToUpperInvariant & "'," &
                                                           "'" & Me.txtQuery.Text.Replace("'", "''") & "'," &
                                                            "'" & Me.numPos.Value.ToString & "'," &
                                                           IIf(Me.ddlForm.Value = "", "NULL", "'" & Me.ddlForm.Value & "'") &
                                                           "," & IIf(Me.chkActivo.Checked = True, 1, 0) &
                                                           "," & IIf(Me.chkModal.Checked = True, 1, 0) & ")") Then
                                    cMensajes.DisplayMessage(Me, "Se han guardado los cambios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    Me.Close()
                                Else
                                    cMensajes.DisplayMessage(Me, "Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    End If
                                End If
                            Else
                            If cxn.Select_SQL("update tbMainMenuTabs set  TabName='" & Me.txtTabName.Text.ToUpperInvariant & "'" &
                                              ", Status=" & IIf(Me.chkActivo.Checked = True, 1, 0) &
                                              ", DockForm=" & IIf(Me.chkModal.Checked = True, 1, 0) &
                                              ", Query='" & Me.txtQuery.Text.Replace("'", "''") & "'" &
                                              ", TabOrder='" & Me.numPos.Value.ToString & "'" &
                                              ", FormName=" & IIf(Me.ddlForm.Value = "", "Null", "'" & Me.ddlForm.Value & "'") &
                                               " where idTab='" & id & "'") Then
                                cMensajes.DisplayMessage(Me, "Se han guardado los cambios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                Me.Close()
                            Else
                                cMensajes.DisplayMessage(Me, "Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                End If
                            End If
                        Else
                            cMensajes.DisplayMessage(Me, "Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                Else
                    cMensajes.DisplayMessage(Me, "Error al generar la sentencia sql, verifique..." & cxn.arrayValores(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            End If
    End Sub
    Private Sub frmMenuTabs_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            GenericCloseChlildForm(Me)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub btnSQL_Click(sender As Object, e As EventArgs) Handles btnSQL.Click
        If Me.txtQuery.Text.Trim <> "" And Not Me.txtQuery.Text.ToLowerInvariant.Contains("delete") _
                And Not Me.txtQuery.Text.ToLowerInvariant.Contains("insert") _
                And Not Me.txtQuery.Text.ToLowerInvariant.Contains("update") _
                And Not Me.txtQuery.Text.ToLowerInvariant.Contains("exec ") _
                And Not Me.txtQuery.Text.ToLowerInvariant.Contains("execute ") Then
            Dim filtro As String = ""
            Dim query_test As String = ""
            If (Me.txtQuery.Text.ToLowerInvariant.Contains("<$filtro1$>")) Then
                filtro = InputBox("Valor para el filtro:", "Filtro del query")
                query_test = Me.txtQuery.Text.ToLowerInvariant.Replace("<$filtro1$>", filtro)
            Else
                query_test = Me.txtQuery.Text
            End If
            If cxn.Get_SQL_DataGrid(query_test, Me.grdTabs) Then
                If grdTabs.Rows.Count = 0 Then
                    cMensajes.DisplayMessage(Me, "El query no produjo resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                cMensajes.DisplayMessage(Me, "Ocurrío un error: " & cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Else
            cMensajes.DisplayMessage(Me, "El campo Query es requerido...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.txtQuery.Focus()
        End If
    End Sub

End Class