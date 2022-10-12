Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Data.OleDb
Public Class DB
    Dim cnx As New SqlConnection
    Public Shared Function lobConnection() As SqlConnection
        Dim lobConn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("base_mpioConnectionString").ToString())
        lobConnection = lobConn
    End Function
    Public Shared Function lobDataSet(ByVal pstSql As String) As DataSet
        Try
            Dim lobConn As SqlConnection = lobConnection()
            Dim lobDataAdapter As SqlDataAdapter
            Dim lobSqlCommand As SqlCommand
            Dim lobDs As DataSet = New DataSet

            lobDataAdapter = New SqlDataAdapter
            lobDataAdapter.TableMappings.Add("Table", "Varios")

            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobSqlCommand.CommandType = CommandType.Text

            lobDataAdapter.SelectCommand = lobSqlCommand

            lobDataAdapter.Fill(lobDs)

            If lobDs.Tables(0).Rows.Count = 0 Then
                'lobDataSet = Nothing
                lobDataSet = lobDs
            Else
                lobDataSet = lobDs
            End If


        Catch ex As Exception
            lobDataSet = Nothing
        Finally
            lobConnection.Close()
        End Try
    End Function

    Public Shared Function dtDataTable(ByVal pstSql As String) As DataTable
        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataAdapter As SqlDataAdapter
        Dim lobSqlCommand As SqlCommand
        Dim dtable As DataTable = New DataTable

        Try
            lobDataAdapter = New SqlDataAdapter
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobSqlCommand.CommandType = CommandType.Text

            lobDataAdapter.SelectCommand = lobSqlCommand
            lobDataAdapter.Fill(dtable)

            dtDataTable = dtable

        Catch ex As Exception
            dtDataTable = Nothing
        Finally
            lobConnection.Close()
        End Try
    End Function


    Public Shared Function lobDataSet(ByVal pstSql As String, ByVal iTimeOut As Integer) As DataSet
        Try
            Dim lobConn As SqlConnection = lobConnection()
            Dim lobDataAdapter As SqlDataAdapter
            Dim lobSqlCommand As SqlCommand
            Dim lobDs As DataSet = New DataSet

            lobDataAdapter = New SqlDataAdapter
            lobDataAdapter.TableMappings.Add("Table", "Varios")

            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobSqlCommand.CommandType = CommandType.Text

            lobSqlCommand.CommandTimeout = iTimeOut
            lobDataAdapter.SelectCommand = lobSqlCommand

            lobDataAdapter.Fill(lobDs)

            If lobDs.Tables(0).Rows.Count = 0 Then
                lobDataSet = Nothing
            Else
                lobDataSet = lobDs
            End If


        Catch ex As Exception
            lobDataSet = Nothing
        Finally
            lobConnection.Close()
        End Try
    End Function

    Public Shared Sub fLlenaDropDown(ByVal pobDrop As ComboBox, ByVal pstSql As String, ByVal pstTexto As String, Optional ByVal pbAgregaTodos As Boolean = False)

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataReader As SqlDataReader = Nothing
        Dim lobSqlCommand As SqlCommand
        Dim dt As New DataTable
        Try
            lobConn.Open()
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobDataReader = lobSqlCommand.ExecuteReader
            dt.Load(lobDataReader)

            pobDrop.DisplayMember = dt.Columns(1).ColumnName
            pobDrop.ValueMember = dt.Columns(0).ColumnName
            pobDrop.DataSource = dt




        Catch ex As Exception
            Throw ex
        Finally

            If Not lobDataReader Is Nothing Then
                lobDataReader.Close()
            End If

            lobConnection.Close()
        End Try


    End Sub

    Public Shared Sub fLlenaDropDownUltra(ByVal pobDrop As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal pstSql As String, ByVal pstTexto As String, Optional ByVal pbAgregaTodos As Boolean = False)

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataReader As SqlDataReader = Nothing
        Dim lobSqlCommand As SqlCommand
        Dim dt As New DataTable
        Try
            lobConn.Open()
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobDataReader = lobSqlCommand.ExecuteReader
            dt.Load(lobDataReader)


            pobDrop.DataSource = dt

            pobDrop.DisplayMember = dt.Columns(1).ColumnName
            pobDrop.ValueMember = dt.Columns(0).ColumnName




        Catch ex As Exception
            Throw ex
        Finally

            If Not lobDataReader Is Nothing Then
                lobDataReader.Close()
            End If

        End Try

        lobConnection.Close()

    End Sub

    Public Shared Sub fLlenaDropDownUltraDropDown(ByVal pobDrop As Infragistics.Win.UltraWinGrid.UltraDropDown, ByVal pstSql As String, ByVal pstTexto As String, Optional ByVal pbAgregaTodos As Boolean = False)

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataReader As SqlDataReader = Nothing
        Dim lobSqlCommand As SqlCommand
        Dim dt As New DataTable
        Try
            lobConn.Open()
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobDataReader = lobSqlCommand.ExecuteReader
            dt.Load(lobDataReader)

            pobDrop.DisplayMember = dt.Columns(1).ColumnName
            pobDrop.ValueMember = dt.Columns(0).ColumnName
            pobDrop.DataSource = dt



        Catch ex As Exception
            Throw ex
        Finally

            If Not lobDataReader Is Nothing Then
                lobDataReader.Close()
            End If

            lobConnection.Close()
        End Try


    End Sub


    Public Shared Sub fLlenaCheckBoxList(ByVal pobDrop As CheckedListBox, ByVal pstSql As String, ByVal pstTexto As String)

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataReader As SqlDataReader = Nothing
        Dim lobSqlCommand As SqlCommand

        Try
            lobConn.Open()
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobDataReader = lobSqlCommand.ExecuteReader

            pobDrop.Items.Clear()
            If pstTexto.Trim <> "" Then
                pobDrop.Items.Add(New ListViewItem(pstTexto, ""))
            End If

            While lobDataReader.Read()
                pobDrop.Items.Add(New ListViewItem(lobDataReader(1).ToString(), lobDataReader(0).ToString()))
            End While
        Catch ex As Exception
            Throw ex
        Finally


            If Not lobDataReader Is Nothing Then
                lobDataReader.Close()
            End If

            lobConnection.Close()
        End Try


    End Sub
    Public Shared Sub fLlenaListBox(ByVal pobDrop As ListBox, ByVal pstSql As String, ByVal pstTexto As String)

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobDataReader As SqlDataReader = Nothing
        Dim lobSqlCommand As SqlCommand

        Try
            lobConn.Open()
            lobSqlCommand = New SqlCommand(pstSql, lobConn)
            lobDataReader = lobSqlCommand.ExecuteReader

            pobDrop.Items.Clear()
            If pstTexto.Trim <> "" Then
                pobDrop.Items.Add(New ListViewItem(pstTexto, ""))
            End If

            While lobDataReader.Read()
                pobDrop.Items.Add(New ListViewItem(lobDataReader(1).ToString(), lobDataReader(0).ToString()))
            End While
        Catch ex As Exception
            Throw ex
        Finally


            If Not lobDataReader Is Nothing Then
                lobDataReader.Close()
            End If

            lobConnection.Close()
        End Try


    End Sub

    Public Shared Function ExecInsertSql(ByVal pstSql As String) As Integer

        Dim lobConn As SqlConnection = lobConnection()
        Dim lobSB As StringBuilder = New StringBuilder()

        Try

            'lobSB.Append(" SET NOCOUNT ON ")
            lobSB.Append(pstSql)
            lobSB.Append(" SELECT @@IDENTITY as 'IDIdentity'")


            'SELECT IDENT_CURRENT('CheckList_Respuesta_DatosGenerales')

            Dim lobCommand As SqlCommand = New SqlCommand(lobSB.ToString(), lobConn)

            lobConn.Open()

            ExecInsertSql = lobCommand.ExecuteScalar

        Catch ex As Exception
            Throw ex
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If

            lobConnection.Close()
        End Try

    End Function
    Public Shared Function fExecuteScalarInt(ByVal sQuery As String) As Integer
        Dim lobConn As SqlConnection = lobConnection()

        Try
            Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)

            lobCommand.CommandTimeout = 0
            lobConn.Open()

            fExecuteScalarInt = lobCommand.ExecuteScalar
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If
        End Try
        Return 0
    End Function

    Public Shared Function fExecuteScalarTransactionInt(ByVal sQuery As String, SqlTran As SqlTransaction) As Integer
        Dim lobConn As SqlConnection = lobConnection()
        lobConn.BeginTransaction()
        Try
            Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)
            lobCommand.Transaction = SqlTran
            lobCommand.CommandTimeout = 0
            lobConn.Open()

            fExecuteScalarTransactionInt = lobCommand.ExecuteScalar
            SqlTran.Commit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Try
                SqlTran.Rollback()
            Catch exRollBack As Exception
                MessageBox.Show(exRollBack.Message)
            End Try
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If
        End Try
        Return 0
    End Function

    Public Shared Function fExecuteScalarStr(ByVal sQuery As String) As String
        Dim lobConn As SqlConnection = lobConnection()
        Try
            Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)
            lobConn.Open()
            fExecuteScalarStr = lobCommand.ExecuteScalar
        Catch ex As Exception
            Throw ex
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If
        End Try
    End Function
    Public Shared Function GeneraDataSetString(ByVal Sentencia As String, ByVal Ruta As String, ByVal TipoArchivo As String) As DataSet
        Try
            Dim ConectarCon As String
            If TipoArchivo = "TXT" Then
                ConectarCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Ruta & ";" & "Extended Properties=text;"
            Else
                ConectarCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Ruta & ";" & "Extended Properties=Excel 8.0;"
            End If
            Dim lobConn As OleDbConnection = New OleDbConnection(ConectarCon)
            lobConn.Open()

            Dim lobDataAdapter As OleDbDataAdapter
            Dim lobSqlCommand As OleDbCommand
            Dim lobDs As DataSet = New DataSet

            lobDataAdapter = New OleDbDataAdapter
            lobDataAdapter.TableMappings.Add("Table", "Varios")

            lobSqlCommand = New OleDbCommand(Sentencia, lobConn)
            lobSqlCommand.CommandType = CommandType.Text

            lobDataAdapter.SelectCommand = lobSqlCommand

            lobDataAdapter.Fill(lobDs)

            If lobDs.Tables(0).Rows.Count = 0 Then
                GeneraDataSetString = Nothing
            Else
                GeneraDataSetString = lobDs
            End If
            lobConn.Close()
        Catch ex As Exception
            GeneraDataSetString = Nothing
        End Try

    End Function
    Public Shared Function fExecuteScalarIntTimeOut(ByVal sQuery As String, ByVal iTimeOut As Integer) As Integer
        Dim lobConn As SqlConnection = lobConnection()
        Try
            Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)
            lobConn.Open()
            lobCommand.CommandTimeout = iTimeOut
            fExecuteScalarIntTimeOut = lobCommand.ExecuteScalar
        Catch ex As Exception
            Throw ex
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If
        End Try
    End Function
    Public Shared Function fExecuteScalarStrTimeOut(ByVal sQuery As String, ByVal iTimeOut As Integer) As String
        Dim lobConn As SqlConnection = lobConnection()
        Try
            Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)
            lobConn.Open()
            lobCommand.CommandTimeout = iTimeOut
            fExecuteScalarStrTimeOut = lobCommand.ExecuteScalar
        Catch ex As Exception
            Throw ex
        Finally
            If Not lobConn Is Nothing Then
                lobConn.Close()
            End If
        End Try
    End Function
End Class
