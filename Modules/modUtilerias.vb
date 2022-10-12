Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.ExcelExport
Imports Infragistics.Win.UltraMessageBox
Imports System.Text.RegularExpressions
Imports SMcMaster
Imports Infragistics.Win.UltraWinTabControl

Module modUtilerias
    Public Sub CambiaTextoDeFiltros()
        With Infragistics.Win.UltraWinGrid.Resources.Customizer
            .SetCustomizedString("RowFilterDropDown_Operator_Contains", "Contiene")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotContain", "No contiene")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotEndWith", "No termina con")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotMatch", "No coincide con")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotStartWith", "No comienza con")
            .SetCustomizedString("RowFilterDropDown_Operator_EndsWith", "Termina con")
            .SetCustomizedString("RowFilterDropDown_Operator_Equals", "=")
            .SetCustomizedString("RowFilterDropDown_Operator_GreaterThan", ">")
            .SetCustomizedString("RowFilterDropDown_Operator_GreaterThanOrEqualTo", ">=")
            .SetCustomizedString("RowFilterDropDown_Operator_LessThan", "<")
            .SetCustomizedString("RowFilterDropDown_Operator_LessThanOrEqualTo", "<=")
            .SetCustomizedString("RowFilterDropDown_Operator_Like", "Como")
            .SetCustomizedString("RowFilterDropDown_Operator_Match", "Coincida")
            .SetCustomizedString("RowFilterDropDown_Operator_NotEquals", "No igual a")
            .SetCustomizedString("RowFilterDropDown_Operator_NotLike", "No como")
            .SetCustomizedString("RowFilterDropDown_Operator_StartsWith", "Comienza con")
            .SetCustomizedString("RowFilterDropDownAllItem", "(Todos)")
            .SetCustomizedString("RowFilterDropDownBlanksItem", "(En Blanco)")
            .SetCustomizedString("RowFilterDropDownCustomItem", "(Personalizado)")
            .SetCustomizedString("RowFilterDropDownEquals", "Igual a")
            .SetCustomizedString("RowFilterDropDownErrorsItem", "Erroneos")
            .SetCustomizedString("RowFilterDropDownGreaterThan", "Mayor que")
            .SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo", "Mayor o igual que")
            .SetCustomizedString("RowFilterDropDownLessThan", "Menor que")
            .SetCustomizedString("RowFilterDropDownLessThanOrEqualTo", "Menor o igual a que")
            .SetCustomizedString("RowFilterDropDownLike", "Como")
            .SetCustomizedString("RowFilterDropDownMatch", "Coincide expresión regular")
            .SetCustomizedString("RowFilterDropDownNonBlanksItem", "(No En Blanco)")
            .SetCustomizedString("RowFilterDropDownNonErrorsItem", "(No Erroneos")
            .SetCustomizedString("RowFilterDropDownNotEquals", "No es igual que")
        End With
    End Sub
    Public Sub GeneraExcel(ByVal grid As UltraGrid, ByVal parent As IWin32Window)
        Try
            Dim sfd As New SaveFileDialog
            Dim export As New UltraGridExcelExporter

            If grid.Rows.Count > 0 Then
                With sfd
                    .Title = "Ingresa el nombre del archivo a guardar"
                    .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                    .ShowDialog()
                    If .FileName <> "" Then
                        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                        export.Export(grid, .FileName)
                        Cursor.Current = System.Windows.Forms.Cursors.Default

                        MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                    End If
                End With
            Else
                cMensajes.DisplayMessage(parent, "No existen registros a exportar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(parent, "Existe un problema al exportar los registros...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try


    End Sub
    Public Sub ChangeFitlerText()
        With Infragistics.Win.UltraWinGrid.Resources.Customizer
            .SetCustomizedString("RowFilterDropDown_Operator_Contains", "Contiene")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotContain", "No contiene")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotEndWith", "No termina con")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotMatch", "No coincide con")
            .SetCustomizedString("RowFilterDropDown_Operator_DoesNotStartWith", "No comienza con")
            .SetCustomizedString("RowFilterDropDown_Operator_EndsWith", "Termina con")
            .SetCustomizedString("RowFilterDropDown_Operator_Equals", "=")
            .SetCustomizedString("RowFilterDropDown_Operator_GreaterThan", ">")
            .SetCustomizedString("RowFilterDropDown_Operator_GreaterThanOrEqualTo", ">=")
            .SetCustomizedString("RowFilterDropDown_Operator_LessThan", "<")
            .SetCustomizedString("RowFilterDropDown_Operator_LessThanOrEqualTo", "<=")
            .SetCustomizedString("RowFilterDropDown_Operator_Like", "Como")
            .SetCustomizedString("RowFilterDropDown_Operator_Match", "Coincida")
            .SetCustomizedString("RowFilterDropDown_Operator_NotEquals", "No igual a")
            .SetCustomizedString("RowFilterDropDown_Operator_NotLike", "No como")
            .SetCustomizedString("RowFilterDropDown_Operator_StartsWith", "Comienza con")
            .SetCustomizedString("RowFilterDropDownAllItem", "(Todos)")
            .SetCustomizedString("RowFilterDropDownBlanksItem", "(En Blanco)")
            .SetCustomizedString("RowFilterDropDownCustomItem", "(Personalizado)")
            .SetCustomizedString("RowFilterDropDownEquals", "Igual a")
            .SetCustomizedString("RowFilterDropDownErrorsItem", "Erroneos")
            .SetCustomizedString("RowFilterDropDownGreaterThan", "Mayor que")
            .SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo", "Mayor o igual que")
            .SetCustomizedString("RowFilterDropDownLessThan", "Menor que")
            .SetCustomizedString("RowFilterDropDownLessThanOrEqualTo", "Menor o igual a que")
            .SetCustomizedString("RowFilterDropDownLike", "Como")
            .SetCustomizedString("RowFilterDropDownMatch", "Coincide expresión regular")
            .SetCustomizedString("RowFilterDropDownNonBlanksItem", "(No En Blanco)")
            .SetCustomizedString("RowFilterDropDownNonErrorsItem", "(No Erroneos")
            .SetCustomizedString("RowFilterDropDownNotEquals", "No es igual que")
        End With
    End Sub
    Public Function ShowContinueMessage(ByVal message_header As String, ByVal message_footer As String,
                                        message As String, UltraMessageBoxManager1 As UltraMessageBoxManager,
                                        Optional type1 As MessageBoxButtons = MessageBoxButtons.YesNo,
                                        Optional msgtype As MessageBoxIcon = MessageBoxIcon.Question) As DialogResult
        Using ultraMessageBoxInfo As New UltraMessageBoxInfo()
            ' Set the general display style 
            ultraMessageBoxInfo.Style = MessageBoxStyle.Vista

            ' Set the text for the Text, Caption, Header and Footer 
            ultraMessageBoxInfo.Text = message
            ultraMessageBoxInfo.Caption = ""
            ultraMessageBoxInfo.Header = message_header
            ultraMessageBoxInfo.Footer = message_footer

            ' Specify which buttons should be used and which is the default button 
            ultraMessageBoxInfo.Buttons = type1
            'ultraMessageBoxInfo.DefaultButton = MessageBoxDefaultButton.Button1
            ultraMessageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.[False]

            ' Display the OS Error Icon 
            ultraMessageBoxInfo.Icon = msgtype

            ' Disable the default sounds 
            ultraMessageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]

            ' Show the UltraMessageBox 
            Dim resp As DialogResult = UltraMessageBoxManager1.ShowMessageBox(ultraMessageBoxInfo)
            Return resp
        End Using
    End Function

    Public Function Get_Forms(ByVal ddl As Infragistics.Win.UltraWinGrid.UltraCombo)
        Try
            Dim FormsNotAllowed As String = "frmLogin,frmPassword,mdiMain,frmGeneraReporte,Padron_Imagenes"
            Dim forms(200) As String
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            ddl.DataSource = Nothing

            Dim types As Type() = myAssembly.GetTypes()
            Dim comboBoxItems As New DataTable()
            comboBoxItems.Columns.Add("Display")
            comboBoxItems.Columns.Add("Value")
            Dim itemRow2 As DataRow = comboBoxItems.NewRow()
            itemRow2("Display") = "-Seleccione-"
            itemRow2("Value") = "-1"
            comboBoxItems.Rows.Add(itemRow2)
            Dim i As Integer = 0
            For Each t As Type In types
                If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                    If Not FormsNotAllowed.Contains(t.Name) Then
                        Dim formDB As Object = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & t.Name))
                        Dim itemRow As DataRow = comboBoxItems.NewRow()
                        itemRow("Display") = formDB.Text
                        itemRow("Value") = t.Name
                        comboBoxItems.Rows.Add(itemRow)
                        formDB.dispose()
                        formDB = Nothing
                    End If
                End If
            Next
            ddl.DisplayMember = "Display"
            ddl.ValueMember = "Value"
            ddl.DataSource = comboBoxItems
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(Trim(email))
        Return (m.Captures.Count <> 0)
    End Function
    Public Function DialogForm1(dialog As Form, parent As Form) As DialogResult
        Try
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(dialog.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.45
                'plexi.MdiParent = parent
                plexi.Show()
                dialog.StartPosition = FormStartPosition.CenterParent
                Return dialog.ShowDialog(plexi)
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Public Sub TabOrderSequence(frm As Form, scheme As TabOrderManager.TabScheme)
        Dim scheme1 As TabOrderManager.TabScheme = scheme
        Dim tom As New TabOrderManager(frm)

        '// This method lets you change the scheme for a specified control rather than
        '// inherit from its parents.

        tom.SetSchemeForControl(frm, TabOrderManager.TabScheme.DownFirst)


        '// This method actually sets the order all the way down the control hierarchy.
        tom.SetTabOrder(scheme)
    End Sub

    Public Sub GenericCloseChlildForm(chld As Object)
        Try
            If chld.myParent IsNot Nothing Then
                Dim Maintab As Object = chld.myParent.Controls.Find("tabPrincipal", True)
                Dim tab As UltraTabControl = DirectCast(Maintab(0), UltraTabControl)
                tab.Visible = True
                tab.Enabled = True
                Dim Mainbar As Object = chld.myParent.Controls.Find("CommandBar", True)
                Dim barCmd As ToolStrip = DirectCast(Mainbar(0), ToolStrip)
                barCmd.Visible = True
                barCmd.Enabled = True
            Else
                Dim Mainbar As Object = mdiMain.Controls.Find("CommandBar", True)
                Dim barCmd As ToolStrip = DirectCast(Mainbar(0), ToolStrip)
                barCmd.Visible = True
                barCmd.Enabled = True
            End If
            chld.Dispose()
            chld.Close()
            mdiMain.Focus()
            mdiMain.Activate()
        Catch ex As Exception
            '    MsgBox(ex.Message)
        End Try
    End Sub

End Module
