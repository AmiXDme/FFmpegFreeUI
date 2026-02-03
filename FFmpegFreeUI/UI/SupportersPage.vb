Imports Sunny.UI

Public Class SupportersPage
    Private Sub SupportersPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ReadPaidSupporters()
        Dim a As New List(Of String)(My.Resources.Resource1.Supporters.Split(vbCrLf))
        For Each t In a
            Dim name = t.Split("|"c)(0)
            Dim color = If(t.Split("|"c).Length > 1, t.Split("|"c)(1), "")
            CreateSupporterLabel(name, color)
        Next
    End Sub

    Sub ReadGiftSupporters()
        Dim a As New List(Of String)(My.Resources.Resource1.Supporters_Gift.Split(vbCrLf))
        For Each t In a
            Dim data = t.Split("|"c)
            Dim name = data(0)
            Dim color = If(data.Length > 1, data(1), "")
            If data.Length <= 2 Then
                CreateSupporterLabel(name, color)
            ElseIf data.Length = 3 Then
                CreateSupporterLabel(name, color, data(2))
            End If
        Next
    End Sub

    Sub CreateSupporterLabel(Text As String, HTMLColorValueText As String, Optional specialTag As String = "")
        Dim BackgroundColor As Color
        If HTMLColorValueText.StartsWith("#"c) Then
            BackgroundColor = ColorTranslator.FromHtml(HTMLColorValueText)
        Else
            BackgroundColor = ColorTranslator.FromWin32(RGB(56, 56, 56))
        End If
        Dim brightness As Double = BackgroundColor.R * 0.299 + BackgroundColor.G * 0.587 + BackgroundColor.B * 0.114
        Dim TextColor As Color = If(brightness >= 128, Color.Black, Color.Silver)
        Dim b As New UIButton With {
            .Text = Text,
            .AutoSize = False,
            .Height = 30 * Form1.DPI,
            .Radius = 30 * Form1.DPI,
            .FillColor = BackgroundColor,
            .FillHoverColor = BackgroundColor,
            .FillPressColor = BackgroundColor,
            .RectColor = BackgroundColor,
            .RectHoverColor = BackgroundColor,
            .RectPressColor = BackgroundColor,
            .ForeColor = TextColor,
            .ForeHoverColor = TextColor,
            .ForePressColor = TextColor,
            .Font = New Font(UserSettings.Instance.Font, 10),
            .Margin = New Padding(0, 0, 15, 15),
            .Cursor = Cursors.Default
        }
        Select Case specialTag
            Case "ZOGMOS" ' Original: "The End Poem"
                b.RectHoverColor = Color.Yellow
        End Select

        Me.FlowLayoutPanel1.Controls.Add(b)
        SetButtonWidthBasedOnText(b, False, 24 * Form1.DPI)
    End Sub

    Sub ClearSupportersList()
        Me.FlowLayoutPanel1.Controls.Clear()
    End Sub


    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        UiButton1.FillColor = Color.DarkSlateBlue
        UiButton2.FillColor = Me.BackColor
        UiButton3.FillColor = Me.BackColor
        ClearSupportersList()
        ReadPaidSupporters()
        ReadGiftSupporters()
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        UiButton1.FillColor = Me.BackColor
        UiButton2.FillColor = Color.DarkSlateBlue
        UiButton3.FillColor = Me.BackColor
        ClearSupportersList()
        ReadPaidSupporters()
    End Sub

    Private Sub UiButton3_Click(sender As Object, e As EventArgs) Handles UiButton3.Click
        UiButton1.FillColor = BackColor
        UiButton2.FillColor = BackColor
        UiButton3.FillColor = Color.DarkSlateBlue
        ClearSupportersList()
        ReadGiftSupporters()
    End Sub

    Private Sub SupportersPage_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        AdjustUI()
    End Sub

    Sub AdjustUI()
        UiButton1.Radius = 30 * Form1.DPI
        UiButton2.Radius = 30 * Form1.DPI
        UiButton3.Radius = 30 * Form1.DPI
        UiButton4.Radius = 30 * Form1.DPI
        For Each b As UIButton In FlowLayoutPanel1.Controls.OfType(Of UIButton)()
            SetButtonWidthBasedOnText(b, False, 20 * Form1.DPI)
        Next
    End Sub

    Sub AdjustTopButtonsWidth()
        SetButtonWidthBasedOnText(UiButton1)
        SetButtonWidthBasedOnText(UiButton2)
        SetButtonWidthBasedOnText(UiButton3)
        SetButtonWidthBasedOnText(UiButton4)
    End Sub

    Private Sub UiButton4_Click(sender As Object, e As EventArgs) Handles UiButton4.Click
        ClearSupportersList()
    End Sub
End Class
