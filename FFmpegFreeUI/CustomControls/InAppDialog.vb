
Public Class InAppDialog

    Public Shared Sub ShowDialog(Window As Form, Title As String, Content As String, ButtonListAndAction As Dictionary(Of String, Action), DialogTheme As ThemeType, Optional WidthRatio As Single = 0.5, Optional HeightRatio As Single = 0.5)
        Dim MainPanel As New Panel With {
            .BackColor = Color.FromArgb(0, 0, 0),
            .BackgroundImageLayout = ImageLayout.None
        }
        If Window Is Form1 Then
            Dim BackgroundImage As Image = CaptureScreen_ForDialogBackground()
            AddHandler MainPanel.Paint, Sub(sender As Object, e As PaintEventArgs) If BackgroundImage IsNot Nothing Then e.Graphics.DrawImage(BackgroundImage, MainPanel.ClientRectangle)
        End If

        Dim Dialogarea As New Panel With {.Dock = DockStyle.Fill, .Padding = New Padding(20 * Form1.DPI)}
        MainPanel.Controls.Add(Dialogarea)
        AddHandler MainPanel.SizeChanged, Sub() MainPanel.Padding = New Padding(MainPanel.Width * WidthRatio * 0.5, MainPanel.Height * HeightRatio * 0.5, MainPanel.Width * WidthRatio * 0.5, MainPanel.Height * HeightRatio * 0.5)
        Select Case DialogTheme
            Case ThemeType.Normal : Dialogarea.BackColor = Color.FromArgb(36, 36, 36)
            Case ThemeType.ErrorTheme : Dialogarea.BackColor = Color.FromArgb(64, 24, 24)
            Case ThemeType.Success : Dialogarea.BackColor = Color.FromArgb(24, 64, 24)
        End Select

        Dim TitleText As New Label With {
            .Text = Title,
            .Dock = DockStyle.Top,
            .AutoSize = True,
            .Padding = New Padding(0, 0, 0, 20),
            .Font = New Font(UserSettings.Instance.Font, 16),
            .ForeColor = Color.Silver
        }
        Dialogarea.Controls.Add(TitleText)

        Dim ButtonContainer As New Panel With {.Dock = DockStyle.Bottom, .Height = 40 * Form1.DPI}

        Dim ButtonTextList As New List(Of String)(ButtonListAndAction.Keys)
        For i As Integer = 0 To ButtonTextList.Count - 1
            Dim Button As New Sunny.UI.UIButton With {
                .Text = ButtonTextList(i),
                .Font = New Font(UserSettings.Instance.Font, 11),
                .Width = TextRenderer.MeasureText(ButtonTextList(i), New Font(UserSettings.Instance.Font, 11)).Width + 30 * Form1.DPI,
                .Dock = DockStyle.Right,
                .Radius = 0,
                .FillColor = Color.FromArgb(48, 48, 48),
                .FillHoverColor = Color.FromArgb(56, 56, 56),
                .FillPressColor = Color.FromArgb(64, 64, 64),
                .FillSelectedColor = Color.FromArgb(64, 64, 64),
                .ForeColor = Color.Silver,
                .RectColor = Color.FromArgb(80, 80, 80),
                .RectHoverColor = Color.FromArgb(80, 80, 80),
                .RectPressColor = Color.FromArgb(80, 80, 80),
                .RectSelectedColor = Color.FromArgb(80, 80, 80),
                .RectSize = 1
            }
            AddHandler Button.Click, Sub(s1, e1) ButtonListAndAction(s1.Text)?()
            AddHandler Button.Click, Sub()
                                     MainPanel.Dispose()
                                     GC.Collect()
                                 End Sub
            ButtonContainer.Controls.Add(Button)
            Button.BringToFront()
            If i < ButtonTextList.Count - 1 Then
                Dim SpacerLabel As New Label With {.Width = 10 * Form1.DPI, .Dock = DockStyle.Right}
                ButtonContainer.Controls.Add(SpacerLabel)
                SpacerLabel.BringToFront()
            End If
        Next
        Dialogarea.Controls.Add(ButtonContainer)

        Dim DescriptionText As New Label With {
            .Text = Content,
            .Dock = DockStyle.Fill,
            .AutoSize = False,
            .AutoEllipsis = True,
            .Padding = New Padding(2, 0, 0, 20),
            .Font = New Font(UserSettings.Instance.Font, 12),
            .ForeColor = Color.Silver
        }
        Dialogarea.Controls.Add(DescriptionText)
        DescriptionText.BringToFront()
        Window.Controls.Add(MainPanel)
        MainPanel.Location = New Point(0, 0)
        MainPanel.Size = Window.ClientSize
        MainPanel.BringToFront()
    End Sub

    Enum ThemeType
        Normal = 1
        ErrorTheme = 2
        [Error] = 2
        Success = 5
    End Enum




End Class












