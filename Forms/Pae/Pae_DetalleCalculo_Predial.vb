Public Class Pae_DetalleCalculo_Predial
    Private Sub Pae_DetalleCalculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_mpioDataSet.viePaeDetalleCalculoPredial' Puede moverla o quitarla según sea necesario.
        'Me.ViePaeDetalleCalculoPredialTableAdapter.Fill(Me.Base_mpioDataSet.viePaeDetalleCalculoPredial)
        Me.griDetalle.DataSource = C_REQ_PRED_CONSULTATableAdapter.GetData()
        'TODO: esta línea de código carga datos en la tabla 'DsPae.viePaeDetalleCalculoPredial' Puede moverla o quitarla según sea necesario.
        Me.Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnExportaExcel_Click(sender As Object, e As EventArgs) Handles btnExportaExcel.Click
        Dim sfd As New SaveFileDialog

        If griDetalle.Rows.Count > 0 Then
            With sfd
                .Title = "Ingresa el nombre del archivo a exportar"
                .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    Me.Cursor = Cursors.WaitCursor
                    ugeExporter.Export(griDetalle, .FileName)
                    Me.Cursor = Cursors.Default
                    MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                End If
            End With
        Else
            MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class