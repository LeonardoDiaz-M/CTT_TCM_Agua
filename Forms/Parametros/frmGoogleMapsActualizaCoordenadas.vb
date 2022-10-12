Public Class frmGoogleMapsActualizaCoordenadas
    Dim Padron As String
    Dim ClavePadron As String
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If MsgBox("¿Seguro de actualizar las coordenadas del predio?" + ClavePadron, vbYesNo, "Confirmación") = vbYes Then

                DB.fExecuteScalarInt("UPDATE " & Padron & " SET Latitud= " & txtLatitud.Text & ",Longitud=" & txtLongitud.Text & " WHERE " & ClavePadron & "=" & ClavePadron)

                cMensajes.DisplayMessage(Me, "Registro actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class