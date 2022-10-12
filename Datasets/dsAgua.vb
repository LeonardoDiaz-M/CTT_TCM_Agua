Partial Class dsAgua
    Partial Public Class arc_aguaDataTable
        Private Sub arc_aguaDataTable_arc_aguaRowChanging(sender As Object, e As arc_aguaRowChangeEvent) Handles Me.arc_aguaRowChanging

        End Sub

    End Class

    Partial Public Class tbl_consumo_aguaDataTable
        Private Sub tbl_consumo_aguaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.lect_actColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace dsAguaTableAdapters
    Partial Public Class arc_aguaTableAdapter
    End Class

    Partial Public Class tbl_consumo_aguaTableAdapter
    End Class
End Namespace
