Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinGrid

Public Class cxnData
    Public SqlPubsConnString As String = My.Settings.base_mpioConnectionString
    Protected Cn As New SqlConnection(Me.SqlPubsConnString)
    Private SQLString As String
    Private SQLSelect As SqlDataReader
    Private sqlComm1 As New SqlCommand
    Public arrayValores(35) As String
    Public arrayCampos As New ArrayList
    Private cmd As New SqlCommand(SQLString, Cn)
    Private adapter As New SqlDataAdapter()
    Private table As New DataTable
    Public err As String = ""
    Private reader As System.Data.SqlClient.SqlDataReader
    Public Tree_Table As String = ""

    Public Function OpenCxn() As Boolean
        Dim ban As Boolean = False
        Try
            If Cn.State = System.Data.ConnectionState.Closed Then
                Cn.Open()
            Else
                Cn.Close()
                Cn.Open()
            End If
            ban = True
        Catch ex As System.Exception
            Me.arrayValores(0) = ex.Message
            MsgBox(ex.Message)
        End Try
        Return ban
    End Function
    Protected Function CloseCxn() As Boolean
        Dim ban As Boolean = False
        Try
            If Cn.State = System.Data.ConnectionState.Open Then
                Cn.Close()
            End If
            ban = True
        Catch ex As System.Exception
            Me.arrayValores(0) = ex.Message
        End Try
        Return ban
    End Function
    Public Function Select_SQL(ByVal Consulta As String) As Boolean
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim ban As Boolean = False
        adapter.Dispose()
        table.Clear()
        Try
            If Me.OpenCxn() Then

                sqlComm1.Connection = Cn 'conecta bd
                sqlComm1.CommandText = Consulta
                sqlComm1.CommandTimeout = 600
                adapter.SelectCommand = sqlComm1
                reader = adapter.SelectCommand.ExecuteReader()
                For i = 0 To Me.arrayValores.Length - 1
                    Me.arrayValores(i) = Nothing
                Next
                While reader.Read()
                    Me.arrayCampos.Add(j)
                    For i = 0 To reader.FieldCount - 1
                        Me.arrayValores(i) = reader(i).ToString.Trim
                        Me.arrayCampos.Insert(j, Me.arrayValores(i))
                    Next
                End While
                Me.CloseCxn()
                ban = True
                err = ""
            End If
        Catch ex As System.Exception
            Me.CloseCxn()
            Me.arrayValores(0) = ex.Message
            Me.err = ex.Message
            ban = False
        End Try
        Return ban
    End Function

    Public Function Get_SQL_DataGrid(ByVal query As String, dg As UltraGrid) As Boolean
        Dim dataSQL As New DataSet
        Dim ban As Boolean = False
        Try
            dg.DataSource = Nothing
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            'AddHandler dg.InitializeRow, AddressOf Me.grd_InitializeRow
            adaNwnd.Fill(dataSQL)
            dg.DataSource = dataSQL
            err = ""
            ban = True
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            'cMensajes.DisplayMessage(Me, "Existe un problema de comunicación central con el servidor, intente nuevamente!", vbYes, vbExclamation, vbYes)
            err = ex.Message
            ban = False
        End Try
        Return ban
    End Function

    Private Sub grd_InitializeRow(sender As System.Object, e As InitializeRowEventArgs)

        If e.Row.Band.Index = 0 Then
            For Each col In e.Row.Band.Columns
                If col.Key = "Valor terreno propio" Or col.Key = "Valor terreno común" Or col.Key = "Valor const propio" Or col.Key = "Valor const común" Or col.Key = "Valor catastral" Then
                    col.Format = "$#,##0.00"
                    col.CellAppearance.TextHAlign = HAlign.Right
                End If
                If col.Key = "Ult. Pago" Or col.Key = "Pago Ant." Or col.Key = "impuesto" Or col.Key = "recargos" Or col.Key = "multas" Or col.Key = "Gastos" Or col.Key = "Sub. Imp." Or col.Key = "Sub. Rec." Or col.Key = "Sub Multa" Or col.Key = "Sub Gasto" Then
                    col.Format = "$#,##0.00"
                    col.CellAppearance.TextHAlign = HAlign.Right
                End If
            Next col
        End If

    End Sub

    Public Function Get_SQL_DataGrid(ByVal query As String, dg As DataGridView) As Boolean
        Dim dataSQL As New DataSet
        err = ""
        Dim ban As Boolean = False
        Try
            dg.DataSource = Nothing
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dataSQL)
            dg.DataSource = dataSQL
            dg.AutoGenerateColumns = True
            err = ""
            ban = True
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try
        Return ban
    End Function
    Public Function Get_SQL_Combobox(ByVal query As String, cmb As ComboBox, member As String, value As String, Optional type As ComboBoxStyle = ComboBoxStyle.DropDownList) As Boolean
        Dim dataSQL As New DataSet
        Dim ban As Boolean = False
        Try
            Me.OpenCxn()
            cmb.DataSource = Nothing
            cmb.Items.Clear()
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dataSQL)
            Dim newRow As DataRow = dataSQL.Tables(0).NewRow()

            newRow(value) = -1
            newRow(member) = "-Seleccione-"

            dataSQL.Tables(0).Rows.Add(newRow)
            dataSQL.Tables(0).DefaultView.Sort = value
            cmb.DisplayMember = member
            cmb.ValueMember = value
            cmb.DataSource = dataSQL.Tables(0)
            cmb.DropDownStyle = type
            cmb.SelectedValue = -1
            cmb.Refresh()
            err = ""
            ban = True
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try
        Return ban
    End Function

    Public Function fLlenaDropDownUltra1(ByVal pobDrop As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal pstSql As String, member As String, value As String) As Boolean
        Dim lobDataReader As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim ban As Boolean = False

        Try
            Me.OpenCxn()
            Dim adaNwnd As New SqlDataAdapter(pstSql, SqlPubsConnString)
            adaNwnd.Fill(dt)
            pobDrop.DataSource = dt
            pobDrop.DisplayMember = member
            pobDrop.ValueMember = value
        Catch ex As Exception
            dt = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try

        Me.CloseCxn()
        Return ban
    End Function


    Public Function fLlenaDropDownUltra(ByVal pobDrop As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal pstSql As String) As Boolean
        Dim lobDataReader As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim ban As Boolean = False

        Try
            Me.OpenCxn()
            Dim adaNwnd As New SqlDataAdapter(pstSql, SqlPubsConnString)
            adaNwnd.Fill(dt)
            pobDrop.DataSource = dt
            pobDrop.DisplayMember = dt.Columns(1).ColumnName
            pobDrop.ValueMember = dt.Columns(0).ColumnName
        Catch ex As Exception
            dt = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try

        Me.CloseCxn()
        Return ban
    End Function

    Public Function Get_SQL_ListBox(ByVal query As String, cmb As ListBox, member As String, value As String) As Boolean
        Dim dataSQL As New DataSet
        Dim ban As Boolean = False
        Try
            Me.OpenCxn()
            cmb.DataSource = Nothing
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dataSQL)

            cmb.DisplayMember = member
            cmb.ValueMember = value
            cmb.DataSource = dataSQL.Tables(0)
            cmb.SelectedValue = -1
            cmb.Refresh()
            err = ""
            ban = True
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try
        Return ban
    End Function
    Public Function Get_SQL_ListView(ByVal query As String, lvw As ListView, Optional Key As String = "") As Boolean
        Dim dataSQL As New DataSet
        Dim ban As Boolean = False
        Try
            Me.OpenCxn()
            lvw.Items.Clear()
            lvw.CheckBoxes = True
            Dim List As New ListBox
            Dim reader As System.Data.IDataReader = Nothing
            reader = Select_SQL(query, reader)
            While reader.Read()
                If Key = "" Then
                    lvw.Items.Add(reader.Item(0).ToString.Trim)
                Else
                    lvw.Items.Add(reader.Item(0).ToString.Trim).Name = reader.Item(Key).ToString.Trim
                End If

            End While

            err = ""
            ban = True
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
            err = ex.Message
        End Try
        Return ban
    End Function
    Public Function Get_SQL_Data(ByVal query As String) As DataSet
        Dim dataSQL As New DataSet
        Try
            Dim conNwnd As New SqlConnection(SqlPubsConnString)
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dataSQL)
        Catch ex As Exception
            dataSQL = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
        End Try
        Return dataSQL  
    End Function
    Public Function Get_SQL_BindingSource(ByVal query As String) As BindingSource
        Dim DsBin As New BindingSource
        Dim dtable As New DataTable
        Try
            Dim conNwnd As New SqlConnection(SqlPubsConnString)
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dtable)
            DsBin.DataSource = dtable
            DsBin.Position = 0
        Catch ex As Exception
            dtable = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
        End Try
        Return DsBin
    End Function
    Public Function Get_SQL_Datatable(ByVal query As String) As DataTable
        Dim dtable As New DataTable
        Try
            Dim conNwnd As New SqlConnection(SqlPubsConnString)
            Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
            adaNwnd.Fill(dtable)

        Catch ex As Exception
            dtable = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
        End Try
        Return dtable
    End Function
    'Public Function Get_SQL_ReportDatatable(ByVal query As String) As dsReportes.GenericDataTableDataTable
    '    Dim dtable As New dsReportes.GenericDataTableDataTable
    '    Try
    '        Dim conNwnd As New SqlConnection(SqlPubsConnString)
    '        Dim adaNwnd As New SqlDataAdapter(query, SqlPubsConnString)
    '        adaNwnd.Fill(dtable)

    '    Catch ex As Exception
    '        dtable = Nothing
    '        Me.arrayValores(0) = ex.Message
    '        Me.CloseCxn()
    '    End Try
    '    Return dtable
    'End Function
    Public Function Select_SQL(ByVal strSql As String, ByVal reader As System.Data.IDataReader) As System.Data.IDataReader
        Dim cmd As New SqlCommand(strSql, Cn)
        Dim adapter As New SqlDataAdapter()
        Dim ban As Boolean = False
        Try
            Me.OpenCxn()
            sqlComm1.Connection = Cn 'conecta bd
            sqlComm1.CommandText = strSql
            adapter.SelectCommand = sqlComm1
            reader = adapter.SelectCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            ban = True
        Catch ex As System.Exception
            reader = Nothing
            Me.arrayValores(0) = ex.Message
            Me.CloseCxn()
        End Try
        Return reader
    End Function
    Public Function Gen_SQL(ByVal SentenciaSQL As String, Optional ByVal table As String = "", Optional ByVal tYPE As String = "") As Boolean
        Dim ban As Boolean = False
        Dim sqlComm As New SqlCommand
        Dim Cn2 As New SqlConnection(Me.SqlPubsConnString)
        Try
            SQLString = SentenciaSQL.Trim.ToUpper.ToString
            sqlComm.Connection = Cn2 'conecta bd
            If sqlComm.Connection.State = ConnectionState.Closed Then sqlComm.Connection.Open()
            sqlComm.CommandTimeout = 1200
            sqlComm.CommandText = SentenciaSQL
            sqlComm.ExecuteScalar()
            Cn2.Close()
            ban = True
        Catch ex As System.Exception
            Me.arrayValores(0) = ex.Message
            Cn2.Close()
        End Try
        Return ban
    End Function
    Public Function Gen_SQL3(ByVal SentenciaSQL As String, Optional ByVal table As String = "", Optional ByVal tYPE As String = "") As Boolean
        Dim ban As Boolean = False
        Dim sqlComm As New SqlCommand
        Dim Values As String = ""
        Dim Fields As String = ""
        Dim Valor As String = ""
        Dim Campo As String = ""
        Dim Nullable As String = ""
        Dim data_type As String = ""
        Dim Max_Len As String = ""
        Dim where As String = SentenciaSQL
        Dim Cn2 As New SqlConnection(Me.SqlPubsConnString)
        Try
            If table <> "" Then
                If Me.OpenCxn() Then
                    sqlComm1.Connection = Cn 'conecta bd
                    sqlComm1.CommandText = " Select  column_Name as Field, " &
                                           "        Ordinal_Position, is_Nullable  as Accept_Null, " &
                                           "        Data_Type as Tipo, Character_Maximum_length as Tamano  " &
                                           " From information_schema.columns where table_name='" & table & "' " &
                                           " order by ordinal_position asc "

                    adapter.SelectCommand = sqlComm1
                    reader = adapter.SelectCommand.ExecuteReader()

                    Dim i As Integer = 0

                    If tYPE = "insert" Then
                        Values = "Insert into " & table & "("
                        Fields = "values ("
                    Else
                        Values = "Update " & table & " set "
                        Fields = ""
                    End If
                    While reader.Read()
                        Campo = reader(0).ToString.Trim.ToUpperInvariant
                        i = CInt(reader(1).ToString.Trim)
                        Nullable = reader(2).ToString.Trim.ToUpperInvariant
                        data_type = reader(3).ToString.Trim.ToUpperInvariant
                        Max_Len = reader(4).ToString.Trim.ToUpperInvariant
                        If arrayValores(i - 1) Is Nothing Then
                            Valor = "NULL"
                        Else
                            Valor = arrayValores(i - 1).ToString.Trim
                        End If

                        If InStr(data_type.ToLower, "char") > 0 Then
                            data_type = "varchar"
                        End If
                        If Nullable = "NO" And Valor = "" Then
                            Me.err = "Campo requerido"
                            Exit Function
                        ElseIf Nullable <> "NO" And Valor = "" Then
                            Valor = "Null"
                        End If

                        Select Case data_type
                            Case "varchar"
                                If CInt(Max_Len) >= Valor.Length Then
                                    If tYPE = "insert" Then
                                        Values = Values & Campo & ","
                                        Fields = Fields & "'" & Valor & "',"
                                    Else
                                        Values = Values & Campo & "='" & Valor & "',"
                                        Fields = ""
                                    End If
                                Else
                                    err = "El campo sobre pasa la longitud maxima"
                                    Exit Function
                                End If
                            Case "DATETIME"
                                If IsDate(Valor) Then
                                    Valor = FormatDateTime(Valor, DateFormat.ShortDate)
                                ElseIf Valor.ToUpper = "NULL" Then
                                    Valor = "Null"
                                Else
                                    err = "El campo es de fecha"
                                    Exit Function
                                End If
                                If tYPE = "insert" Then
                                    Values = Values & Campo & ","
                                    Fields = Fields & "'" & Valor & "',"
                                Else
                                    Values = Values & Campo & "='" & Valor & "',"
                                    Fields = ""
                                End If
                            Case Else
                                If tYPE = "insert" Then
                                    Values = Values & Campo & ","
                                    Fields = Fields & "'" & Valor & "',"
                                Else
                                    Values = Values & Campo & "='" & Valor & "',"
                                    Fields = ""
                                End If
                        End Select
                    End While
                    Me.CloseCxn()
                    ban = True
                    If tYPE = "insert" Then
                        Values = Mid(Values, 1, Len(Values) - 1) & ")"
                        Fields = Mid(Fields, 1, Len(Fields) - 1) & ")"
                        Values = Values & " " & Fields
                    Else
                        Values = Mid(Values, 1, Len(Values) - 1) & " " & where
                    End If
                    SentenciaSQL = Replace(Values.ToUpper, "'NULL'", "NULL")
                End If
            End If
            SQLString = SentenciaSQL.Trim.ToUpper.ToString
            sqlComm.Connection = Cn2 'conecta bd
            If sqlComm.Connection.State = ConnectionState.Closed Then sqlComm.Connection.Open()
            sqlComm.CommandTimeout = 1200
            sqlComm.CommandText = SentenciaSQL
            sqlComm.ExecuteScalar()
            Cn2.Close()
            ban = True
        Catch ex As System.Exception
            Me.arrayValores(0) = ex.Message
            Cn2.Close()
            ban = False
        End Try
        Return ban
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths
    Function Select_SQL(ByVal SQL As String, ByVal dataset As Data.DataSet, Optional tableName As String = "") As Data.DataSet

        Dim DBAdapter As SqlDataAdapter
        Dim ResultsDataSet As DataSet = New DataSet

        Try

            ' Run the query and create a DataSet.
            Me.OpenCxn()
            DBAdapter = New SqlDataAdapter(SQL, Cn)
            If tableName = "" Then
                DBAdapter.Fill(ResultsDataSet)
            Else
                adapter.TableMappings.Add("Table", tableName)
                DBAdapter.Fill(dataset, tableName)
            End If

            ' Close the database connection.
            Me.CloseCxn()
        Catch ex As Exception
            ReDim Me.arrayValores(1)
            Me.arrayValores(0) = ex.Message + vbCrLf + "Error al ejecutar sentencia: " & vbCrLf & SQL
            Me.CloseCxn()
        End Try
        Return IIf(tableName = "", ResultsDataSet, dataset)

    End Function
    Function Select_SQL(ByVal tree As TreeView, ByVal SelectedNode As String, ByVal sql As String, ByVal Filter As String, ByVal Field As String) As Boolean
        Dim ResultSet As Data.DataSet = Nothing
        Dim ban As Boolean = False
        Try
            ResultSet = Select_SQL(sql, ResultSet)
            tree.Nodes.Clear()
            If ResultSet.Tables.Count > 0 Then

                For Each row As Data.DataRow In ResultSet.Tables(0).Rows
                    Dim newNode As TreeNode = New TreeNode()
                    Dim id As String = row(0).ToString()
                    Dim text As String = row(1).ToString()
                    Dim url As String = row(2).ToString()
                    Dim request_var As String = "" 'row(3).ToString()


                    create_node(newNode, id, text, url, request_var)
                    If SelectedNode.Trim <> "" AndAlso newNode.Name = SelectedNode Then
                        tree.SelectedNode = newNode
                    End If
                    tree.Nodes.Add(newNode)
                Next
            End If
            For i As Integer = 0 To tree.Nodes.Count - 1
                submenu(tree, tree.Nodes(i), SelectedNode, sql, Filter, Field)
            Next
            tree.ExpandAll()
            ban = True
        Catch ex As Exception
            ReDim Me.arrayValores(1)
            Me.arrayValores(0) = ex.Message + vbCrLf + "Error al ejecutar sentencia: " & vbCrLf & sql
            Me.CloseCxn()
        End Try
        Return ban
    End Function

    Private Sub submenu(tree As TreeView, ByVal node As TreeNode, ByVal selectednode As String, ByVal sql As String, ByVal Filter As String, ByVal Field As String)
        Dim ResultSet As Data.DataSet = Nothing
        Dim sql1 As String = ""
        If InStr(sql.ToLowerInvariant, " order by ") > 0 Then
            sql1 = Mid(sql, 1, InStr(sql, " order by") - 1)
            sql1 = sql1 & Field & "='" & node.Name & "'" & Mid(sql, InStr(sql, " order by"))
            sql = sql1
        End If
        'sql1 = IIf(Filter <> "", Replace(sql.ToLower, Filter, Field & "='" & node.Name & "' "), sql & IIf(sql.ToLowerInvariant.Contains(" where "), " and ", " ") & Field & "='" & node.Name & "' ")
        ResultSet = Select_SQL(sql1, ResultSet)
        ' Create the third-level nodes.
        If ResultSet.Tables.Count > 0 Then
            For Each row As Data.DataRow In ResultSet.Tables(0).Rows
                Dim newNode As TreeNode = New TreeNode()
                Dim id As String = row(0).ToString()
                Dim text As String = row(1).ToString()
                Dim url As String = row(2).ToString()
                Dim request_var As String = "" 'row(3).ToString()
                create_node(newNode, id, text, url, request_var)
                If selectednode.Trim <> "" AndAlso newNode.Name.ToString.ToLower = selectednode.ToLower Then
                    tree.SelectedNode = newNode
                End If

                Dim sql3 As String = Mid(sql, InStr(sql, " from "))
                If InStr(sql3.ToLowerInvariant, " order by ") > 0 Then
                    sql3 = Mid(sql3, 1, InStr(sql3, " order by") - 1)
                End If
                sql3 = "Select count(*) " & sql3
                If Select_SQL(sql3) Then
                    If arrayValores(0) IsNot Nothing Then
                        If CInt(arrayValores(0)) > 0 Then
                            submenu(tree, newNode, selectednode, sql, Filter.ToLower, Field.ToLower)
                        End If
                    End If
                End If
                node.Nodes.Add(newNode)
            Next
        End If
    End Sub
    Private Sub create_node(ByVal newNode As TreeNode, ByVal id As String, ByVal text As String,
                             ByVal URL As String, ByVal request_var As String)
        'Dim menu As String() = Split(Tree_Table, "/")
        'Select_SQL("select status from " & menu(0) & " where " & menu(1) & "='" & id & "'")
        If arrayValores(0) Is Nothing Or arrayValores(0) = "" Then
            arrayValores(0) = 1
        End If
        newNode.Name = id.Trim.ToUpper
        newNode.Text = text.Trim.ToUpper
        newNode.Checked = arrayValores(0)
        'Used to web 
        'If URL <> "" Then
        '    newNode.NavigateUrl = URL
        '    If request_var <> "" Then
        '        newNode.NavigateUrl &= "?" & request_var & "=" & id
        '    End If
        'End If
        'newNode.PopulateOnDemand = True
        'newNode.SelectAction = TreeNodeSelectAction.Expand
    End Sub
    Public Function load_parents(tree As TreeView, sql As String) As Boolean
        Dim ban As Boolean = False
        Try
            Dim ResultSet As Data.DataSet = Nothing
            ResultSet = Select_SQL(sql, ResultSet)
            tree.Nodes.Clear()
            If ResultSet.Tables.Count > 0 Then
                For Each row As Data.DataRow In ResultSet.Tables(0).Rows
                    Dim newNode As TreeNode = New TreeNode()
                    newNode.Name = row(0).Trim.ToUpper
                    newNode.Text = row(1).Trim.ToUpper
                    tree.Nodes.Add(newNode)
                Next
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Public Function load_childs(tree As TreeView, sql As String) As Boolean
        Dim ban As Boolean = False
        Try
            Dim myImageList As New ImageList()
            myImageList.Images.Add(Global.TCMAdmin.My.Resources._new)
            myImageList.Images.Add(Global.TCMAdmin.My.Resources.find)
            myImageList.Images.Add(Global.TCMAdmin.My.Resources.delete1)
            myImageList.Images.Add(Global.TCMAdmin.My.Resources.open_folder)

            tree.ImageList = myImageList

            For i As Integer = 0 To tree.Nodes.Count - 1
                tree.SelectedNode = tree.Nodes(i)
                Dim ResultSet As Data.DataSet = Nothing
                ResultSet = Select_SQL(sql.ToLower.Replace("<%parent%>", tree.SelectedNode.Name), ResultSet)
                If ResultSet.Tables.Count > 0 Then
                    For Each row As Data.DataRow In ResultSet.Tables(0).Rows

                        Dim newNode As TreeNode = New TreeNode()
                        newNode.Name = row(0).Trim.ToUpper
                        newNode.Text = row(1).Trim.ToUpper
                        tree.SelectedNode.Nodes.Add(newNode)
                        Dim newNodeVer As TreeNode = New TreeNode()
                        Dim newNodeNvo As TreeNode = New TreeNode()
                        Dim newNodeEdt As TreeNode = New TreeNode()
                        Dim newNodeElr As TreeNode = New TreeNode()
                        If row(2).ToString.Trim.ToLowerInvariant = "true" Then
                            newNodeVer.Name = row(0).Trim.ToUpper & "VER"
                            newNodeVer.Text = "VER"
                            newNodeVer.ImageIndex = 1
                            newNode.Nodes.Add(newNodeVer)
                        End If

                        If row(3).ToString.Trim.ToLowerInvariant = "true" Then
                            newNodeNvo.Name = row(0).Trim.ToUpper & "NVO"
                            newNodeNvo.Text = "Nuevo"
                            newNodeNvo.ImageIndex = 0
                            newNode.Nodes.Add(newNodeNvo)
                        End If

                        If row(4).ToString.Trim.ToLowerInvariant = "true" Then
                            newNodeEdt.Name = row(0).Trim.ToUpper & "EDT"
                            newNodeEdt.Text = "Editar"
                            newNodeEdt.ImageIndex = 3
                            newNode.Nodes.Add(newNodeEdt)
                        End If

                        If row(5).ToString.Trim.ToLowerInvariant = "true" Then
                            newNodeElr.Name = row(0).Trim.ToUpper & "ELR"
                            newNodeElr.Text = "Eliminar"
                            newNodeElr.ImageIndex = 2
                            newNode.Nodes.Add(newNodeElr)
                        End If
                        newNode.ImageIndex = -1
                    Next
                End If
            Next
            tree.ExpandAll()
            tree.SelectedNode = tree.Nodes.Item(0).FirstNode
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Public Function load_selected(tree As TreeView, sql As String) As Boolean
        Dim ban As Boolean = False
        Try
            Dim ResultSet As Data.DataSet = Nothing
            ResultSet = Select_SQL(sql, ResultSet)
            If ResultSet.Tables.Count > 0 Then
                For Each row As Data.DataRow In ResultSet.Tables(0).Rows
                    Dim node As TreeNode() = tree.Nodes.Find(row(0).ToString, True)
                    node(0).Checked = True
                Next
            End If
            tree.ExpandAll()
            tree.SelectedNode = tree.Nodes.Item(0).FirstNode
        Catch ex As Exception

        End Try
        Return ban
    End Function

    Public Function dtDataTable(ByVal pstSql As String) As DataTable
        Dim lobDataAdapter As SqlDataAdapter
        Dim lobSqlCommand As SqlCommand
        Dim dtable As DataTable = New DataTable

        Try
            lobDataAdapter = New SqlDataAdapter
            lobSqlCommand = New SqlCommand(pstSql, Cn)
            lobSqlCommand.CommandType = CommandType.Text

            lobDataAdapter.SelectCommand = lobSqlCommand
            lobDataAdapter.Fill(dtable)

            dtDataTable = dtable

        Catch ex As Exception
            dtDataTable = Nothing
        Finally
            Cn.Close()
        End Try
    End Function


End Class


