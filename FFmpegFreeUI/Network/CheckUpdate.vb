Public Class CheckUpdate

    Public Shared Async Sub Check()
        Form1.StartPage.Label64.Text = Translate("String.CheckingUpdate")
        Form1.StartPage.Label65.Text = "" : Form1.StartPage.Label65.Visible = False
        Form1.StartPage.Label73.Text = "" : Form1.StartPage.Label73.Visible = False
        Form1.StartPage.Label75.Text = "" : Form1.StartPage.Label75.Visible = False
        Form1.StartPage.Label122.Text = "" : Form1.StartPage.Label122.Visible = False
        
        If My.Computer.Network.IsAvailable Then
            Dim a As New GitHubAPI.Release
            Dim s1 As String = Await a.GetRepositoryReleaseInfoAsync("Lake1059/FFmpegFreeUI")
            If s1 <> "" Then
                Form1.StartPage.Label64.Text = Translate("String.GetUpdateInfoFailed")
                Form1.StartPage.Label65.Text = "" : Form1.StartPage.Label65.Visible = False
                Form1.StartPage.Label73.Text = "" : Form1.StartPage.Label73.Visible = False
                Form1.StartPage.Label75.Text = "" : Form1.StartPage.Label75.Visible = False
                Form1.StartPage.Label122.Text = s1 : Form1.StartPage.Label122.Visible = True
            Else
                Form1.StartPage.Label64.Text = $"{Translate("String.ReleaseTitle")}: " & a.Title
                Form1.StartPage.Label65.Text = $"{Translate("String.LatestTag")}: " & a.TagName : Form1.StartPage.Label65.Visible = True
                Form1.StartPage.Label73.Text = $"{Translate("String.ReleaseUser")}: " & a.AuthorName : Form1.StartPage.Label73.Visible = True
                Form1.StartPage.Label75.Text = $"{Translate("String.FileCount")}: " & a.Assets.Count : Form1.StartPage.Label75.Visible = True
                Form1.StartPage.Label122.Text = $"{Translate("String.ReleaseTime")}: " & a.ReleaseTime : Form1.StartPage.Label122.Visible = True
            End If
        Else
            Form1.StartPage.Label64.Text = Translate("String.NoNetworkToCheckUpdate")
            Form1.StartPage.Label65.Text = "" : Form1.StartPage.Label65.Visible = False
            Form1.StartPage.Label73.Text = "" : Form1.StartPage.Label73.Visible = False
            Form1.StartPage.Label75.Text = "" : Form1.StartPage.Label75.Visible = False
            Form1.StartPage.Label122.Text = "" : Form1.StartPage.Label122.Visible = False
        End If
    End Sub

End Class
