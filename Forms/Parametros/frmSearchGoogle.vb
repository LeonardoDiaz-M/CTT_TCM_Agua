Imports Microsoft.Win32
Public Class frmSearchGoogle
    Private Sub frmSearchGoogle_Load(sender As Object, e As EventArgs) Handles Me.Load
        webGoogle.Navigate("https://www.google.es/maps/search/" & txtLatitud.Text & "+" & txtLongitud.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub tsbRegistraNavegador_Click(sender As Object, e As EventArgs) Handles tsbRegistraNavegador.Click
        Try
            Dim Registro As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl", True)
            Registro = Registro.CreateSubKey("FEATURE_BROWSER_EMULATION")
            Registro.SetValue("TCMAdmin" & ".exe", 11001, RegistryValueKind.DWord) 'IE 11 64BITS=11001, IE 11 32BITS=11000, IE 10 64BITS=10001,IE 10 32BITS=10000
            Registro.Close()
            MsgBox("Listo!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class