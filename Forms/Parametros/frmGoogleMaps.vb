Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms.Markers

Public Class frmGoogleMaps

    Private Sub frmGoogleMaps_Load(sender As Object, e As EventArgs) Handles Me.Load
        GMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        'GMapControl1.SetPositionByKeywords("Lerma, México")

        Try
            GMapControl1.DragButton = MouseButtons.Left
            GMapControl1.CanDragMap = True
            GMapControl1.MapProvider = MapProviders.GoogleMapProvider.Instance
            If Val(txtLatitud.Text) = 0 Or Val(txtLongitud.Text) = 0 Then
                cMensajes.DisplayMessage(Me, "No se han registrado las coordenadas geográficas del inmueble en el padrón, actualice el registro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                GMapControl1.Position = New PointLatLng(19.3309698, -99.4762293)
            Else
                GMapControl1.Position = New PointLatLng(Val(txtLatitud.Text), Val(txtLongitud.Text))
                'agregamos marcador 
                Dim MarkerOverlay As New GMapOverlay("Marcador")
                Dim Marker As New GMarkerGoogle(New PointLatLng(txtLatitud.Text, txtLongitud.Text), GMarkerGoogleType.blue_pushpin)
                MarkerOverlay.Markers.Add(Marker) 'agregamos al marcador
                Dim Tooltip As String
                Tooltip = "  Ubicación: " & lblUbicacion.Text & vbCrLf
                Tooltip += "Reg. Mpal.: " & lblClavePadron.Text & vbCrLf
                Tooltip += "    Nombre: " & lblNombreContribuyente.Text & vbCrLf

                'agregamos tooltip
                Marker.ToolTipMode = MarkerTooltipMode.Always
                Marker.ToolTipText = Tooltip
                'String.Format("Ubicación: \n Clave:{0} \n Nombre:{1}", lblClavePadron.Text, lblClavePadron.Text)
                GMapControl1.Overlays.Add(MarkerOverlay)
            End If

            GMapControl1.MinZoom = 2
            GMapControl1.MaxZoom = 18
            GMapControl1.Zoom = 13
            GMapControl1.Refresh()
            GMapControl1.AutoScroll = True

        Catch ex As Exception
            MessageBox.Show("Existe un error al cargar el mapa")
        End Try

    End Sub

    Private Sub GMapControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseDoubleClick
        Dim latitud As Double
        Dim Longitud As Double
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            latitud = GMapControl1.FromLocalToLatLng(e.X, e.Y).Lat
            Longitud = GMapControl1.FromLocalToLatLng(e.X, e.Y).Lng
        End If
        txtLatitud.Text = latitud
        txtLongitud.Text = Longitud
        cMensajes.DisplayMessage(Me, "Coordenadas establecidas, presione el botón guardar para actualizar la ubicación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub btnSatelite_Click(sender As Object, e As EventArgs) Handles btnSatelite.Click
        GMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        GMapControl1.MapProvider = GMapProviders.GoogleMap
    End Sub

    Private Sub btnRelieve_Click(sender As Object, e As EventArgs) Handles btnRelieve.Click
        GMapControl1.MapProvider = GMapProviders.GoogleTerrainMap
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    trackZoom.Value = Convert.ToInt32(GMapControl1.Zoom)
    'End Sub

    Private Sub trackZoom_ValueChanged(sender As Object, e As EventArgs) Handles trackZoom.ValueChanged
        GMapControl1.Zoom = trackZoom.Value
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtLatitud.Text = "" Then
                cMensajes.DisplayMessage(Me, "Ingrese un valor para la latitud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If txtLongitud.Text = "" Then
                cMensajes.DisplayMessage(Me, "Ingrese un valor para la longitud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim cxn As New cxnData
            If cxn.Select_SQL("UPDATE " & lblTipoPadron.Text & " SET Latitud= '" & txtLatitud.Text & "',Longitud='" & txtLongitud.Text & "' WHERE " & lblCampo.Text & "='" & lblClavePadron.Text & "'") AndAlso cxn.err = "" Then
                cMensajes.DisplayMessage(Me, "Registro actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                cMensajes.DisplayMessage(Me, "Error: " & cxn.err, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class