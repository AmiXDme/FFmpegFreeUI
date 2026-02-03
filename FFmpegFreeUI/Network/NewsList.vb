Public Class NewsList

    Public Shared Property NewsListData As New List(Of KeyValuePair(Of String, String))

    Public Shared Sub DisplayNewsList()
        Form1.StartPage.PanelNewsListPanel.Controls.Clear()

        For i = 0 To NewsListData.Count - 1
            Dim c1 As New LinkLabel With {.AutoSize = True, .Dock = DockStyle.Top, .TextAlign = ContentAlignment.MiddleLeft, .Padding = New Padding(0, 0, 0, 10 * Form1.DPI), .BackColor = Color.Transparent, .ActiveLinkColor = Color.Violet, .Text = NewsListData(i).Key, .Tag = i, .Font = New Font(UserSettings.Instance.Font, 11), .LinkBehavior = LinkBehavior.HoverUnderline, .Cursor = Cursors.Hand}
            AddHandler c1.Click, Sub(sender, e)
                                     Select Case NewsListData(sender.Tag).Value.Split("|")(0)
                                         Case "msgbox"
                                             Dim optionsDict As New Dictionary(Of String, Action)
                                             optionsDict("Understand") = Nothing
                                             InAppDialog.ShowDialog(Form1, sender.Text, NewsListData(sender.Tag).Value.Split("|")(1).Replace("{vbCrLf}", vbCrLf), optionsDict, InAppDialog.ThemeType.Normal)
                                         Case "link"
                                             Process.Start(New ProcessStartInfo With {.FileName = NewsListData(sender.Tag).Value.Split("|")(1), .UseShellExecute = True})
                                     End Select
                                 End Sub
            If NewsListData(i).Value.Split("|").Length >= 3 Then
                Select Case NewsListData(i).Value.Split("|")(2)
                    Case "red"
                        c1.LinkColor = Color.IndianRed
                    Case "orange"
                        c1.LinkColor = Color.Peru
                    Case "yellow"
                        c1.LinkColor = Color.GreenYellow
                    Case "green"
                        c1.LinkColor = Color.OliveDrab
                    Case "blue"
                        c1.LinkColor = Color.CornflowerBlue
                    Case "purple"
                        c1.LinkColor = Color.MediumPurple
                End Select
            End If

            Form1.StartPage.PanelNewsListPanel.Controls.Add(c1)
            c1.BringToFront()
        Next
    End Sub

    Public Shared Sub GetNews(Optional forceRefresh As Boolean = False)
        If My.Computer.Network.IsAvailable = False Then Exit Sub
        
        Dim newsWorker As New ComponentModel.BackgroundWorker
        AddHandler newsWorker.DoWork,
            Sub(sender As Object, e As ComponentModel.DoWorkEventArgs)
                Dim api As New GitAPI.TextFileString
                Dim newsFile As String = "news.ini"
                api.GetTextFileData(GitAPI.GitApiObject.OpenSourcePlatform.GitHub, "Lake1059/FFmpegFreeUI", "main", newsFile, Nothing, False)
                If api.ErrorString <> "" Then
                    e.Result = api.ErrorString
                    Exit Sub
                Else
                    e.Result = ""
                End If
                NewsListData.Clear()
                KeyValuePairIO.ReadKeyValuePairTextToList(NewsListData, api.Content)
            End Sub
        AddHandler newsWorker.RunWorkerCompleted,
            Sub(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs)
                If e.Result = "" Then
                    DisplayNewsList()
                Else
                    Form1.StartPage.PanelNewsListPanel.Controls.Add(New Label With {.Text = Translate("String.GetNewsFailed") & vbCrLf & vbCrLf & e.Result, .Dock = DockStyle.Fill, .AutoSize = False, .Font = New Font(UserSettings.Instance.Font, 11), .ForeColor = Color.Gray})
                End If
            End Sub
        newsWorker.RunWorkerAsync()

    End Sub

End Class
