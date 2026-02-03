Public Class StartPage
    Private Sub StartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindDragControlMoveWindow(Me.Panel73)
        BindDragControlMoveWindow(Me.LabelMainTitle)
        BindDragControlMoveWindow(Me.LabelSubtitle)
        BindDragControlMoveWindow(Me.PictureBox1)
        BindDragControlMoveWindow(Me.Label11)
        BindDragControlMoveWindow(Me.Label36)

        AddHandler Me.LinkLabelClearMemory.LinkClicked, AddressOf CollectSelfMemoryUsage
        AddHandler Me.LinkLabel3FUIRepository.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/Lake1059/FFmpegFreeUI", .UseShellExecute = True})
        AddHandler Me.LinkLabelFFmpegDocs.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://ffmpeg.org/documentation.html", .UseShellExecute = True})
        AddHandler Me.LinkLabelDownloadFFmpeg1.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://www.gyan.dev/ffmpeg/builds/", .UseShellExecute = True})
        AddHandler Me.LinkLabelDownloadFFmpeg2.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/BtbN/FFmpeg-Builds/releases", .UseShellExecute = True})
        AddHandler Me.LinkLabelSponsor.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://afdian.com/a/1059Studio", .UseShellExecute = True})
        AddHandler Me.LinkLabelAuthorPage.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://space.bilibili.com/319785096", .UseShellExecute = True})
        AddHandler Me.LinkLabelOfficialSite1.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://ffmpegfreeui.top", .UseShellExecute = True})
        AddHandler Me.LinkLabelOfficialSite2.LinkClicked, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://3fui.top", .UseShellExecute = True})
        AddHandler Me.LinkLabelDoNotTrustAI.LinkClicked, Sub()
                                                       InAppDialog.ShowDialog(Form1, "Do not trust AI suggestions !!!", "Generative AI has no self-awareness, and its operating principle is not what the public thinks. Its answers rely on its training data and web searches or even background control. AI basically cannot find what you cannot find, and AI often talks nonsense seriously. Different models often contradict each other, and even the answers to each conversation are different. Figure out what your needs are. Encoding and decoding are very professional things and belong to heavy productivity. It is only under the rendering of media and market demand that the public thinks it is very simple. When asking questions, don't use AI's suggestions to question the industry's decades of experience!", New Dictionary(Of String, Action) From {{"Understand", Nothing}, {"Too long didn't read", Nothing}, {"Don't understand", Nothing}, {"Understand but Don't understand", Nothing}, {"Killing intent rising", Nothing}}, InAppDialog.ThemeType.Error, 0.3, 0.3)
                                                   End Sub

    End Sub

    Public Sub AdjustUI()
        SetLabelHeightBasedOnText(Me.LabelNoticeBoardDesc)
        SetLabelHeightBasedOnText(Me.LabelHelpInfoDesc1)
        SetLabelHeightBasedOnText(Me.LabelHelpInfoDesc2)
        SetLabelHeightBasedOnText(Me.LabelHighDPISupportDesc)
    End Sub

End Class





