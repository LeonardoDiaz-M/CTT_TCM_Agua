Imports System.Data
Imports Microsoft.VisualBasic
Imports Infragistics.Win.UltraMessageBox
Imports System.Web.Security
Public Class cMensajes

    Public Shared Function funMensajes(ByVal sCveMensaje As String) As String
        Dim sMensaje As String
        Select Case sCveMensaje
            Case "ErrorGrid" 'Error al Cargar la Grid
                sMensaje = "Ocurrio un error al cargar la grid"
            Case "ErrorInsert" 'Error al Insertar Registro
                sMensaje = "Ocurrio un error al tratar de insertar el registro"
            Case "ErrorDup" 'Error al Insertar Registro
                sMensaje = "Ocurrio un error la clave ya existe"

            Case "ErrorUpdate"
                sMensaje = "Ocurrio un error al tratar de actualizar el registro"
            Case Else
                sMensaje = "Ocurrio un Error"
        End Select
        Return sMensaje
    End Function
    Public Shared Function funMensajesTransacionCatalogos(ByVal iCveMensaje As String) As String
        Dim sMensaje As String
        Select Case iCveMensaje
            Case 0
                sMensaje = "Registro guardado exitosamente"
            Case 1
                sMensaje = "Registro actualizado exitosamente"
            Case 2
                sMensaje = "Ocurrio un error al guardar el registro"
            Case 3
                sMensaje = "Ocurrio un error al actualizar el registro"
            Case 4
                sMensaje = "Ya existe un registro con esa descripción"
            Case 5
                sMensaje = "Ya existe un registro con esta clave"
            Case Else
                sMensaje = ""
        End Select
        Return sMensaje
    End Function

    Public Shared Sub DisplayMessage(ByVal owner As IWin32Window, ByVal message As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon, ByVal defaultButton As MessageBoxDefaultButton)

        ' Create an UltraMessageBoxInfo and set all the appropriate properties 
        Using messageBoxInfo As New UltraMessageBoxInfo()
            messageBoxInfo.TextFormatted = message
            messageBoxInfo.Caption = Application.ProductName
            messageBoxInfo.Buttons = buttons
            messageBoxInfo.Icon = icon
            messageBoxInfo.DefaultButton = defaultButton
            messageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]
            messageBoxInfo.MaximumWidth = 400
            messageBoxInfo.MinimumWidth = 400
            messageBoxInfo.Owner = owner
            messageBoxInfo.Style = MessageBoxStyle.Vista
            messageBoxInfo.HeaderFormatted = "<i>Mensaje: </i>"
            messageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.False
            If message = "Object variable or With block variable not set." Then
                Exit Sub
            End If
            ' Create a HelpInfo object to hold the help data 
            Using helpData As New HelpInfo("", "")
                messageBoxInfo.HelpInfo = helpData
                UltraMessageBoxManager.Show(messageBoxInfo)
            End Using
        End Using
    End Sub



End Class
