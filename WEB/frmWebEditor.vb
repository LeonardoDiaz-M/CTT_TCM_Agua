Public Class frmWebEditor
    Private doc As Object
    Private contentDiv As Object
    Private htmlContent As String = ""
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'Me.WebBrowser1.Document.DomDocument = doc
        contentDiv = doc.getElementsByTagName("div")(0)
        contentDiv.innerHtml = htmlContent
    End Sub

    Private Sub frmWebEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim html As New clsHtmlEditor(Me.WebBrowser1, "<html><body><div id=""editable"">Edit this text</div></body></html>")
        'htmlContent = html.HtmlContent

        'Me.WebBrowser1.Navigate("")
        'Application.DoEvents()
        'Me.WebBrowser1.Document.OpenNew(False).Write("<html><body><div id=""editable"">Edit this text</div></body></html>")
        ''turns off document body editing
        'For Each el As HtmlElement In Me.WebBrowser1.Document.All
        '    el.SetAttribute("unselectable", "on")
        '    el.SetAttribute("contenteditable", "false")
        'Next

        ''turns on editable div editing
        'With Me.WebBrowser1.Document.Body.All("editable")
        '    .SetAttribute("width", Me.Width & "px")
        '    .SetAttribute("height", "100%")
        '    .SetAttribute("contenteditable", "true")
        'End With

        ''turns on edit mode
        'Me.WebBrowser1.ActiveXInstance.Document.DesignMode = "On"
        ''stops right click->Browse View
        'Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
    End Sub

    Public Function DocLoaded(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        doc = Me.WebBrowser1.Document.DomDocument
        contentDiv = doc.getElementsByTagName("div")(0)
        contentDiv.innerHtml = ""
    End Function
End Class