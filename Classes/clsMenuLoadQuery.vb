Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win

Public Class clsMenuLoadQuery
    Private cxn As New cxnData
    Public errmsg As String = ""
    Private form As String
    Public Function Load_Tab_data(tab As UltraTabControl, filterValue As String) As Boolean
        Dim ban As Boolean = False
        Dim grdtab As New UltraGrid

        Try
            If tab.SelectedTab.Index > 0 Then

                Dim currenttab As UltraTab = tab.SelectedTab
                currenttab.TabPage.Controls.RemoveByKey("grd" & tab.SelectedTab.Key)
                If cxn.Select_SQL("select * from tbMainMenuTabs where idTab=" & currenttab.Key.ToString) Then
                    If cxn.arrayValores(0) IsNot Nothing Then
                        If cxn.arrayValores(3) IsNot Nothing And cxn.arrayValores(3).Trim.Length > 0 Then
                            If cxn.Get_SQL_DataGrid(cxn.arrayValores(3).Replace("<$Filtro1$>", filterValue), grdtab) Then
                                grdtab.Name = "grd" & currenttab.Key.ToString
                                grdtab.Dock = DockStyle.Fill
                                grdtab.Refresh()
                                currenttab.TabPage.Controls.Add(grdtab)
                                tab.SelectedTab = currenttab
                                ban = True
                            Else
                                Me.errmsg = "Error al ejectuar la consulta: " & cxn.arrayValores(0)
                                'LoadForms()
                            End If
                        End If
                    Else
                        Me.errmsg = "No se encontro el registro del Tab " & currenttab.Key
                    End If
                Else
                    Me.errmsg = "Error al ejectuar la consulta: " & cxn.arrayValores(0)
                End If
            End If
        Catch ex As Exception
            Me.errmsg = ex.Message
        End Try
        Return ban
    End Function
    Public Function get_query_tab(currenttabKey As String, filtro As String) As String
        Dim qry As String = ""
        If cxn.Select_SQL("select * from tbMainMenuTabs where idTab=" & currenttabKey) Then
            qry = cxn.arrayValores(3).ToString.Trim.ToLower.Replace("<$filtro1$>", filtro)
        End If
        Return qry
    End Function
    Public Function add_tabs(mnucode As String, tab As UltraTabControl, grid As UltraGrid, Optional filtro As String = "") As Boolean
        Dim ban As Boolean = False
        Try
            Dim total_tabs As Integer = 0
            Dim readersql As System.Data.IDataReader = Nothing
            Dim counter As Integer = 1
            Dim exec_qry As Boolean = False
            Dim tabAdded As UltraTab
            Dim tabs As UltraTabsCollection = tab.Tabs
            Dim cxn2 As New cxnData
            If cxn.Select_SQL("select count(*) from tbMainMenuTabs  where Menu= '" & mnucode & "' and query <>''") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    total_tabs = cxn.arrayValores(0)
                End If
                If total_tabs > 0 Then
                    tab.BeginUpdate()
                    If tab.Tabs.Count > 0 Then
                        For Each tb As UltraTab In tab.Tabs
                            If tb.Index > 1 Then
                                Dim removetab As UltraTab
                                removetab = tb
                                tab.Tabs.Remove(removetab)
                            End If
                        Next
                    End If

                    readersql = cxn2.Select_SQL("select * 
                                                 from tbMainMenuTabs 
                                                where Menu= '" & mnucode & "' 
                                                and status=1  order by TabOrder asc", readersql)
                    counter = 1

                    If readersql.IsClosed = False Then
                        While readersql.Read()
                            If readersql.Item(3).ToString <> "" Then
                                Dim grid2 As New UltraGrid
                                If counter = 1 Then
                                    tab.Tabs(0).Text = "&" & readersql.Item(2).ToString.Trim
                                    tab.Tabs(0).Key = readersql.Item(0).ToString.Trim
                                    cxn2.Get_SQL_DataGrid(readersql.Item(3).ToString.Trim.ToLower.Replace("<$filtro1$>", filtro), grid)
                                Else
                                    cxn.Get_SQL_DataGrid("select 'Seleccione un registro... [Información]'", grid2)
                                    'agrega tab de forma dinamica en base al datareader con las propiedades: key and text
                                    tabAdded = tabs.Add(readersql.Item(0).ToString.Trim, "&" & readersql.Item(2).ToString.Trim)
                                    tabAdded.Active = True
                                    'establece propiedades del grid para agregarlo al tab
                                    grid2.Name = "grd" & readersql.Item(0).ToString.Trim
                                    grid2.DisplayLayout.Scrollbars = Scrollbars.Automatic
                                    grid2.Refresh()
                                    'agrega el grid al tab agregado dinamicamente en el ciclo.
                                    tabAdded.TabPage.Controls.Add(grid2)
                                End If
                                counter += 1
                            End If
                        End While
                    Else
                        cMensajes.DisplayMessage(Me, "Error de comunicación intente nuevamente", vbExclamation, vbYes, vbYes)
                    End If


                    tab.EndUpdate()
                    ban = True
                Else
                    If cxn.Select_SQL("select count(*) from tbMainMenuTabs  where Menu= '" & mnucode & "' and query =''") Then
                        If cxn.arrayValores(0) IsNot Nothing Then
                            total_tabs = cxn.arrayValores(0)
                        End If
                        If total_tabs = 1 Then
                            LoadForms("0", mnucode)
                        ElseIf total_tabs > 1 Then
                        Else
                            Me.errmsg = "No se encontrarón registros de Tabs del Menú: " & mnucode
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Me.errmsg = ex.Message
        End Try
        Return ban
    End Function



    Public Function LoadForms(idRegistro As String, mnuCode As String,
                              Optional mdiMainParent As Form = Nothing, Optional idTab As String = "-1") As Boolean
        Dim ban As Boolean = False
        Dim mnucod As String = ""
        Dim Dock As Boolean = False
        Try
            Dim Sql_Select As String = "select distinct FormName,Menu,dockform 
                                       from tbMainMenuTabs 
                                       where Menu= '" & mnuCode & "' and Status=1 "
            If idTab <> "-1" Then
                Sql_Select = "select distinct FormName,Menu,dockform 
                                       from tbMainMenuTabs 
                                       where idTab= '" & idTab & "' and Status=1 "
            End If

            If cxn.Select_SQL(Sql_Select) Then
                form = cxn.arrayValores(0)
                mnucod = cxn.arrayValores(1)
                Dock = cxn.arrayValores(2)
                Dim usr As New clsUser
                usr.UserName = CurrentUsrName
                usr.obtiene_Permisos_Menu(mnucod)
                If form.Trim.Length > 0 Then
                    Dim formDB As Object = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & form))
                    Try
                        formDB.id = idRegistro
                        formDB.Lectura = usr.ReadOpt
                        formDB.Borrar = usr.DelOpt
                        formDB.Editar = usr.UpdOpt
                        formDB.Insertar = usr.AddOpt
                    Catch ex As Exception
                    End Try
                    Dim Maintab As UltraTabControl = Nothing
                    If mdiMainParent IsNot Nothing Then
                        Maintab = TryCast(mdiMainParent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
                    End If
                    If Dock Then
                        If Maintab IsNot Nothing Then
                            Maintab.Visible = False
                        End If
                        formDB.FormBorderStyle = FormBorderStyle.None
                        TryCast(formDB, Form).MdiParent = mdiMainParent
                        TryCast(formDB, Form).TopLevel = False
                        TryCast(formDB, Form).FormBorderStyle = FormBorderStyle.None
                        TryCast(formDB, Form).Dock = DockStyle.Fill
                        formDB.myParent = mdiMainParent
                        cxn.Select_SQL("select description from tbMainSubMenus where submenu='" & mnucod & "'")
                        formDB.Text = cxn.arrayValores(0).ToUpperInvariant
                        'formDB.isMdiChild = True
                        formDB.TopMost = True
                        formDB.Show()
                    Else
                        Maintab.Visible = True
                        Plexiglass(formDB, mdiMainParent)
                    End If
                    ban = True
                End If
            Else
                errmsg = "Error, no se encontró una forma asociada al menú"
            End If

        Catch ex As Exception
            errmsg = ex.Message
        End Try
        Return ban
    End Function
    Public Shared Function Plexiglass(dialog As Form, parent As Form) As DialogResult
        Try
            dialog.TopLevel = True
            dialog.Parent = Nothing
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(dialog.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.45
                plexi.MdiParent = Nothing
                plexi.Show()
                dialog.StartPosition = FormStartPosition.CenterParent
                Return dialog.ShowDialog(plexi)

            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Return 0
    End Function
End Class
