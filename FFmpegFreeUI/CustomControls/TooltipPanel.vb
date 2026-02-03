Imports Sunny.UI

Public Class TooltipPanel

    Public Shared Sub Binding(targetControl As Control, data As List(Of Tp_Data))
        Dim menu As New DarkContextMenu With {.ShowImageMargin = False}
        menu.Items.Add(New ToolStripSeparator() With {.Tag = "null"})
        For Each item In data
            If menu.Items.Count > 1 Then menu.Items.Add(New ToolStripSeparator())
            If item.Title <> "" Then
                Dim titleItem As New ToolStripMenuItem(item.Title) With {.Enabled = False, .Tag = "label", .ForeColor = item.TitleColor}
                menu.Items.Add(titleItem)
            End If
            Dim lines As New List(Of String)(item.Text.Split("<br>"))
            For Each t In lines
                Dim contentItem As New ToolStripMenuItem(t) With {.Tag = "label"}
                Select Case item.TextType
                    Case HintType.Warning : contentItem.ForeColor = Color.Goldenrod
                    Case HintType.Critical : contentItem.ForeColor = Color.IndianRed
                End Select
                menu.Items.Add(contentItem)
            Next
        Next
        menu.Items.Add(New ToolStripSeparator() With {.Tag = "null"})

        AddHandler targetControl.MouseClick, Sub(s1, e1)
                                        Select Case e1.Button
                                            Case MouseButtons.Middle, MouseButtons.XButton1, MouseButtons.XButton2
                                                menu.Font = Form1.Font
                                                menu.Show(Control.MousePosition)
                                        End Select
                                    End Sub
        AddHandler targetControl.KeyDown, Sub(s1, e1)
                                     Select Case e1.KeyCode
                                         Case Keys.F1
                                             menu.Font = Form1.Font
                                             menu.Show(Control.MousePosition)
                                     End Select
                                 End Sub

        Dim c1 As UIComboBox = TryCast(targetControl, UIComboBox)
        If c1 IsNot Nothing Then
            AddHandler c1.TextBox.MouseDown, Sub(s2, e1)
                                                 Select Case e1.Button
                                                     Case MouseButtons.Middle, MouseButtons.XButton1, MouseButtons.XButton2
                                                         menu.Font = Form1.Font
                                                         menu.Show(Control.MousePosition)
                                                 End Select
                                             End Sub
            AddHandler c1.TextBox.KeyDown, Sub(s1, e1)
                                               Select Case e1.KeyCode
                                                   Case Keys.F1
                                                       menu.Font = Form1.Font
                                                       menu.Show(Control.MousePosition)
                                               End Select
                                           End Sub
        End If

        Dim c2 As UITextBox = TryCast(targetControl, UITextBox)
        If c2 IsNot Nothing Then
            AddHandler c2.TextBox.MouseDown, Sub(s2, e1)
                                                 Select Case e1.Button
                                                     Case MouseButtons.Middle, MouseButtons.XButton1, MouseButtons.XButton2
                                                         menu.Font = Form1.Font
                                                         menu.Show(Control.MousePosition)
                                                 End Select
                                             End Sub
            AddHandler c2.TextBox.KeyDown, Sub(s1, e1)
                                               Select Case e1.KeyCode
                                                   Case Keys.F1
                                                       menu.Font = Form1.Font
                                                       menu.Show(Control.MousePosition)
                                               End Select
                                           End Sub
        End If

    End Sub

    Public Class Tp_Data
        Public Property Title As String
        Public Property TitleColor As Color = Color.YellowGreen
        Public Property Text As String
        Public Property TextType As HintType
    End Class

    Enum HintType
        Warning = 1
        Critical = 2
    End Enum

End Class


