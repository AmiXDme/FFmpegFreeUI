<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Note: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel73 = New Panel()
        LabelSubtitle = New Label()
        LabelMainTitle = New Label()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        Panel16 = New Panel()
        Label36 = New Label()
        LinkLabelClearMemory = New LinkLabel()
        Panel5 = New Panel()
        PanelNewsListPanel = New Panel()
        LabelNewsList = New Label()
        Panel44 = New Panel()
        LabelHighDPISupport = New Label()
        LabelHighDPISupportDesc = New Label()
        LabelHelpInfoDesc2 = New Label()
        LabelHelpInfoDesc1 = New Label()
        LabelHelpInfo = New Label()
        LabelNoticeBoardDesc = New Label()
        LabelNoticeBoard = New Label()
        Panel7 = New Panel()
        Label122 = New Label()
        Label75 = New Label()
        Label73 = New Label()
        Label65 = New Label()
        Label64 = New Label()
        LabelCheckUpdate = New Label()
        LinkLabelOfficialSite2 = New LinkLabel()
        LinkLabelOfficialSite1 = New LinkLabel()
        LinkLabelAuthorPage = New LinkLabel()
        LinkLabelSponsor = New LinkLabel()
        LinkLabelDownloadFFmpeg2 = New LinkLabel()
        LinkLabelDownloadFFmpeg1 = New LinkLabel()
        LinkLabelFFmpegDocs = New LinkLabel()
        LinkLabel3FUIRepository = New LinkLabel()
        LinkLabelDoNotTrustAI = New LinkLabel()
        LabelLinksAndDocs = New Label()
        Panel73.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel16.SuspendLayout()
        Panel5.SuspendLayout()
        Panel44.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel73
        ' 
        Panel73.AutoSize = True
        Panel73.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel73.Controls.Add(LabelSubtitle)
        Panel73.Controls.Add(LabelMainTitle)
        Panel73.Controls.Add(Label11)
        Panel73.Controls.Add(PictureBox1)
        Panel73.Controls.Add(Panel16)
        Panel73.Dock = DockStyle.Top
        Panel73.Location = New Point(0, 0)
        Panel73.Name = "Panel73"
        Panel73.Padding = New Padding(20, 10, 20, 20)
        Panel73.Size = New Size(1000, 80)
        Panel73.TabIndex = 82
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Dock = DockStyle.Top
        LabelSubtitle.Font = New Font("Segoe UI", 10F)
        LabelSubtitle.ForeColor = Color.CornflowerBlue
        LabelSubtitle.Location = New Point(80, 40)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Padding = New Padding(1, 0, 0, 0)
        LabelSubtitle.Size = New Size(388, 20)
        LabelSubtitle.TabIndex = 12
        LabelSubtitle.Tag = "Label.SubTitle"
        LabelSubtitle.Text = "Add FFmpeg to environment variables or place it in the 3FUI directory to use."
        ' 
        ' LabelMainTitle
        ' 
        LabelMainTitle.AutoSize = True
        LabelMainTitle.Dock = DockStyle.Top
        LabelMainTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        LabelMainTitle.Location = New Point(80, 10)
        LabelMainTitle.Name = "LabelMainTitle"
        LabelMainTitle.Padding = New Padding(0, 0, 0, 5)
        LabelMainTitle.Size = New Size(210, 30)
        LabelMainTitle.TabIndex = 9
        LabelMainTitle.Text = "FFmpegFreeUI Official"
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Left
        Label11.ForeColor = Color.Gray
        Label11.Location = New Point(70, 10)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(10, 0, 0, 0)
        Label11.Size = New Size(10, 50)
        Label11.TabIndex = 113
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(20, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Panel16
        ' 
        Panel16.AutoSize = True
        Panel16.Controls.Add(Label36)
        Panel16.Controls.Add(LinkLabelClearMemory)
        Panel16.Dock = DockStyle.Right
        Panel16.Location = New Point(776, 10)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(204, 50)
        Panel16.TabIndex = 116
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Dock = DockStyle.Fill
        Label36.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.Gray
        Label36.Location = New Point(0, 0)
        Label36.Name = "Label36"
        Label36.Padding = New Padding(0, 3, 0, 0)
        Label36.Size = New Size(204, 22)
        Label36.TabIndex = 115
        Label36.Text = "@StrawByTheLake (1059 Studio)"
        Label36.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LinkLabelClearMemory
        ' 
        LinkLabelClearMemory.ActiveLinkColor = Color.MediumPurple
        LinkLabelClearMemory.Dock = DockStyle.Fill
        LinkLabelClearMemory.Font = New Font("Segoe UI", 10F)
        LinkLabelClearMemory.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelClearMemory.LinkColor = Color.MediumPurple
        LinkLabelClearMemory.Location = New Point(0, 0)
        LinkLabelClearMemory.Name = "LinkLabelClearMemory"
        LinkLabelClearMemory.Padding = New Padding(0, 0, 0, 3)
        LinkLabelClearMemory.Size = New Size(204, 50)
        LinkLabelClearMemory.TabIndex = 28
        LinkLabelClearMemory.TabStop = True
        LinkLabelClearMemory.Tag = "LinkLabel.GC"
        LinkLabelClearMemory.Text = "CleanUp 3FUI Memory (GC + Kernel)"
        LinkLabelClearMemory.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImageLayout = ImageLayout.Zoom
        Panel5.Controls.Add(PanelNewsListPanel)
        Panel5.Controls.Add(LabelNewsList)
        Panel5.Controls.Add(Panel44)
        Panel5.Controls.Add(Panel7)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(0, 80)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1000, 570)
        Panel5.TabIndex = 89
        ' 
        ' PanelNewsListPanel
        ' 
        PanelNewsListPanel.BackColor = Color.Transparent
        PanelNewsListPanel.Dock = DockStyle.Fill
        PanelNewsListPanel.Location = New Point(645, 54)
        PanelNewsListPanel.Name = "PanelNewsListPanel"
        PanelNewsListPanel.Padding = New Padding(1, 0, 20, 20)
        PanelNewsListPanel.Size = New Size(355, 516)
        PanelNewsListPanel.TabIndex = 92
        ' 
        ' LabelNewsList
        ' 
        LabelNewsList.AutoSize = True
        LabelNewsList.BackColor = Color.Transparent
        LabelNewsList.Dock = DockStyle.Top
        LabelNewsList.Font = New Font("Segoe UI", 13F)
        LabelNewsList.Location = New Point(645, 0)
        LabelNewsList.Name = "LabelNewsList"
        LabelNewsList.Padding = New Padding(0, 20, 0, 10)
        LabelNewsList.Size = New Size(82, 54)
        LabelNewsList.TabIndex = 91
        LabelNewsList.Tag = "Label.News"
        LabelNewsList.Text = "NewsList"
        ' 
        ' Panel44
        ' 
        Panel44.BackColor = Color.Transparent
        Panel44.BackgroundImageLayout = ImageLayout.Stretch
        Panel44.Controls.Add(LabelHighDPISupportDesc)
        Panel44.Controls.Add(LabelHighDPISupport)
        Panel44.Controls.Add(LabelHelpInfoDesc2)
        Panel44.Controls.Add(LabelHelpInfoDesc1)
        Panel44.Controls.Add(LabelHelpInfo)
        Panel44.Controls.Add(LabelNoticeBoardDesc)
        Panel44.Controls.Add(LabelNoticeBoard)
        Panel44.Dock = DockStyle.Left
        Panel44.Font = New Font("Segoe UI", 9.75F)
        Panel44.Location = New Point(300, 0)
        Panel44.Name = "Panel44"
        Panel44.Padding = New Padding(0, 0, 20, 0)
        Panel44.Size = New Size(345, 570)
        Panel44.TabIndex = 89
        ' 
        ' LabelHighDPISupportDesc
        ' 
        LabelHighDPISupportDesc.Dock = DockStyle.Fill
        LabelHighDPISupportDesc.Font = New Font("Segoe UI", 10F)
        LabelHighDPISupportDesc.ForeColor = Color.Gray
        LabelHighDPISupportDesc.Location = New Point(0, 420)
        LabelHighDPISupportDesc.Name = "LabelHighDPISupportDesc"
        LabelHighDPISupportDesc.Padding = New Padding(0, 5, 0, 0)
        LabelHighDPISupportDesc.Size = New Size(325, 150)
        LabelHighDPISupportDesc.TabIndex = 47
        LabelHighDPISupportDesc.Tag = "Label.HighDPISupportDescription"
        LabelHighDPISupportDesc.Text = "Please try to use only on the main display; moving between displays with different scaling can easily cause fonts to appear too large in SunnyUI, as its internal support is limited; if problems occur on the main display, please report directly."
        ' 
        ' LabelHighDPISupport
        ' 
        LabelHighDPISupport.AutoSize = True
        LabelHighDPISupport.Dock = DockStyle.Top
        LabelHighDPISupport.Font = New Font("Segoe UI", 13F)
        LabelHighDPISupport.Location = New Point(0, 371)
        LabelHighDPISupport.Name = "LabelHighDPISupport"
        LabelHighDPISupport.Padding = New Padding(0, 20, 0, 5)
        LabelHighDPISupport.Size = New Size(104, 49)
        LabelHighDPISupport.TabIndex = 46
        LabelHighDPISupport.Tag = "Label.HighDPISupport"
        LabelHighDPISupport.Text = "High DPI Support"
        ' 
        ' LabelHelpInfoDesc2
        ' 
        LabelHelpInfoDesc2.Dock = DockStyle.Top
        LabelHelpInfoDesc2.Font = New Font("Segoe UI", 10F)
        LabelHelpInfoDesc2.ForeColor = Color.Gray
        LabelHelpInfoDesc2.Location = New Point(0, 290)
        LabelHelpInfoDesc2.Name = "LabelHelpInfoDesc2"
        LabelHelpInfoDesc2.Padding = New Padding(0, 10, 0, 0)
        LabelHelpInfoDesc2.Size = New Size(325, 81)
        LabelHelpInfoDesc2.TabIndex = 48
        LabelHelpInfoDesc2.Tag = "Label.HelpInfoDescription2"
        LabelHelpInfoDesc2.Text = "When asking for help, please provide error information, task command line, and parameter overview immediately. Stay focused and mature, do not vent emotions; complaining and guessing won't solve any problems."
        ' 
        ' LabelHelpInfoDesc1
        ' 
        LabelHelpInfoDesc1.Dock = DockStyle.Top
        LabelHelpInfoDesc1.Font = New Font("Segoe UI", 10F)
        LabelHelpInfoDesc1.ForeColor = Color.Gray
        LabelHelpInfoDesc1.Location = New Point(0, 173)
        LabelHelpInfoDesc1.Name = "LabelHelpInfoDesc1"
        LabelHelpInfoDesc1.Padding = New Padding(0, 5, 0, 0)
        LabelHelpInfoDesc1.Size = New Size(325, 117)
        LabelHelpInfoDesc1.TabIndex = 40
        LabelHelpInfoDesc1.Tag = "Label.HelpInfoDescription1"
        LabelHelpInfoDesc1.Text = "3FUI's main logic is to set options in the Parameters Panel first, then drag files into the Encoding Queue to automatically start. If you encounter any concepts you don't understand, you can ask AI directly; these are all terms written in Wikipedia. But DO NOT trust the advice AI gives you!"
        ' 
        ' LabelHelpInfo
        ' 
        LabelHelpInfo.AutoSize = True
        LabelHelpInfo.Dock = DockStyle.Top
        LabelHelpInfo.Font = New Font("Segoe UI", 13F)
        LabelHelpInfo.Location = New Point(0, 124)
        LabelHelpInfo.Name = "LabelHelpInfo"
        LabelHelpInfo.Padding = New Padding(0, 20, 0, 5)
        LabelHelpInfo.Size = New Size(82, 49)
        LabelHelpInfo.TabIndex = 39
        LabelHelpInfo.Tag = "Label.HelpInfo"
        LabelHelpInfo.Text = "Help Info"
        ' 
        ' LabelNoticeBoardDesc
        ' 
        LabelNoticeBoardDesc.Dock = DockStyle.Top
        LabelNoticeBoardDesc.Font = New Font("Segoe UI", 10F)
        LabelNoticeBoardDesc.ForeColor = Color.Gray
        LabelNoticeBoardDesc.Location = New Point(0, 49)
        LabelNoticeBoardDesc.Name = "LabelNoticeBoardDesc"
        LabelNoticeBoardDesc.Padding = New Padding(0, 5, 0, 0)
        LabelNoticeBoardDesc.Size = New Size(325, 75)
        LabelNoticeBoardDesc.TabIndex = 35
        LabelNoticeBoardDesc.Tag = "Label.NoticeBoardDescription"
        LabelNoticeBoardDesc.Text = "Some options have bound tooltips. Use middle click, side buttons, or F1 key to view. For editable dropdowns, try using the keyboard or clicking in non-text areas."
        ' 
        ' LabelNoticeBoard
        ' 
        LabelNoticeBoard.AutoSize = True
        LabelNoticeBoard.Dock = DockStyle.Top
        LabelNoticeBoard.Font = New Font("Segoe UI", 13F)
        LabelNoticeBoard.Location = New Point(0, 0)
        LabelNoticeBoard.Name = "LabelNoticeBoard"
        LabelNoticeBoard.Padding = New Padding(0, 20, 0, 5)
        LabelNoticeBoard.Size = New Size(64, 49)
        LabelNoticeBoard.TabIndex = 24
        LabelNoticeBoard.Tag = "Label.NoticeBoard"
        LabelNoticeBoard.Text = "Tooltip Board"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.Controls.Add(Label122)
        Panel7.Controls.Add(Label75)
        Panel7.Controls.Add(Label73)
        Panel7.Controls.Add(Label65)
        Panel7.Controls.Add(Label64)
        Panel7.Controls.Add(LabelCheckUpdate)
        Panel7.Controls.Add(LinkLabelOfficialSite2)
        Panel7.Controls.Add(LinkLabelOfficialSite1)
        Panel7.Controls.Add(LinkLabelAuthorPage)
        Panel7.Controls.Add(LinkLabelSponsor)
        Panel7.Controls.Add(LinkLabelDownloadFFmpeg2)
        Panel7.Controls.Add(LinkLabelDownloadFFmpeg1)
        Panel7.Controls.Add(LinkLabelFFmpegDocs)
        Panel7.Controls.Add(LinkLabel3FUIRepository)
        Panel7.Controls.Add(LinkLabelDoNotTrustAI)
        Panel7.Controls.Add(LabelLinksAndDocs)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(300, 570)
        Panel7.TabIndex = 90
        ' 
        ' Label122
        ' 
        Label122.Dock = DockStyle.Fill
        Label122.Font = New Font("Segoe UI", 10F)
        Label122.ForeColor = Color.Gray
        Label122.Location = New Point(0, 423)
        Label122.Name = "Label122"
        Label122.Padding = New Padding(20, 5, 20, 20)
        Label122.Size = New Size(300, 147)
        Label122.TabIndex = 37
        Label122.Text = "Update Info"
        ' 
        ' Label75
        ' 
        Label75.AutoSize = True
        Label75.Dock = DockStyle.Top
        Label75.Font = New Font("Segoe UI", 10F)
        Label75.ForeColor = Color.Gray
        Label75.Location = New Point(0, 398)
        Label75.Name = "Label75"
        Label75.Padding = New Padding(20, 5, 0, 0)
        Label75.Size = New Size(85, 25)
        Label75.TabIndex = 36
        Label75.Text = "Update Info"
        ' 
        ' Label73
        ' 
        Label73.AutoSize = True
        Label73.Dock = DockStyle.Top
        Label73.Font = New Font("Segoe UI", 10F)
        Label73.ForeColor = Color.Gray
        Label73.Location = New Point(0, 373)
        Label73.Name = "Label73"
        Label73.Padding = New Padding(20, 5, 0, 0)
        Label73.Size = New Size(85, 25)
        Label73.TabIndex = 35
        Label73.Text = "Update Info"
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Dock = DockStyle.Top
        Label65.Font = New Font("Segoe UI", 10F)
        Label65.ForeColor = Color.Gray
        Label65.Location = New Point(0, 348)
        Label65.Name = "Label65"
        Label65.Padding = New Padding(20, 5, 0, 0)
        Label65.Size = New Size(85, 25)
        Label65.TabIndex = 34
        Label65.Text = "Update Info"
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Dock = DockStyle.Top
        Label64.Font = New Font("Segoe UI", 10F)
        Label64.ForeColor = Color.Gray
        Label64.Location = New Point(0, 323)
        Label64.Name = "Label64"
        Label64.Padding = New Padding(20, 5, 0, 0)
        Label64.Size = New Size(85, 25)
        Label64.TabIndex = 33
        Label64.Text = "Update Info"
        ' 
        ' LabelCheckUpdate
        ' 
        LabelCheckUpdate.AutoSize = True
        LabelCheckUpdate.Dock = DockStyle.Top
        LabelCheckUpdate.Font = New Font("Segoe UI", 13F)
        LabelCheckUpdate.Location = New Point(0, 274)
        LabelCheckUpdate.Name = "LabelCheckUpdate"
        LabelCheckUpdate.Padding = New Padding(20, 20, 0, 5)
        LabelCheckUpdate.Size = New Size(102, 49)
        LabelCheckUpdate.TabIndex = 32
        LabelCheckUpdate.Tag = "Label.CheckUpdate"
        LabelCheckUpdate.Text = "CheckUpdate"
        ' 
        ' LinkLabelOfficialSite2
        ' 
        LinkLabelOfficialSite2.ActiveLinkColor = Color.CornflowerBlue
        LinkLabelOfficialSite2.AutoSize = True
        LinkLabelOfficialSite2.Dock = DockStyle.Top
        LinkLabelOfficialSite2.Font = New Font("Segoe UI", 10F)
        LinkLabelOfficialSite2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelOfficialSite2.LinkColor = Color.CornflowerBlue
        LinkLabelOfficialSite2.Location = New Point(0, 249)
        LinkLabelOfficialSite2.Name = "LinkLabelOfficialSite2"
        LinkLabelOfficialSite2.Padding = New Padding(20, 5, 0, 0)
        LinkLabelOfficialSite2.Size = New Size(113, 25)
        LinkLabelOfficialSite2.TabIndex = 31
        LinkLabelOfficialSite2.TabStop = True
        LinkLabelOfficialSite2.Tag = "Label.OfficialWebsite2"
        LinkLabelOfficialSite2.Text = "OfficialSite 3fui.top"
        ' 
        ' LinkLabelOfficialSite1
        ' 
        LinkLabelOfficialSite1.ActiveLinkColor = Color.CornflowerBlue
        LinkLabelOfficialSite1.AutoSize = True
        LinkLabelOfficialSite1.Dock = DockStyle.Top
        LinkLabelOfficialSite1.Font = New Font("Segoe UI", 10F)
        LinkLabelOfficialSite1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelOfficialSite1.LinkColor = Color.CornflowerBlue
        LinkLabelOfficialSite1.Location = New Point(0, 224)
        LinkLabelOfficialSite1.Name = "LinkLabelOfficialSite1"
        LinkLabelOfficialSite1.Padding = New Padding(20, 5, 0, 0)
        LinkLabelOfficialSite1.Size = New Size(175, 25)
        LinkLabelOfficialSite1.TabIndex = 30
        LinkLabelOfficialSite1.TabStop = True
        LinkLabelOfficialSite1.Tag = "Label.OfficialWebsite1"
        LinkLabelOfficialSite1.Text = "OfficialSite ffmpegfreeui.top"
        ' 
        ' LinkLabelAuthorPage
        ' 
        LinkLabelAuthorPage.ActiveLinkColor = Color.Orchid
        LinkLabelAuthorPage.AutoSize = True
        LinkLabelAuthorPage.Dock = DockStyle.Top
        LinkLabelAuthorPage.Font = New Font("Segoe UI", 10F)
        LinkLabelAuthorPage.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelAuthorPage.LinkColor = Color.Orchid
        LinkLabelAuthorPage.Location = New Point(0, 199)
        LinkLabelAuthorPage.Name = "LinkLabelAuthorPage"
        LinkLabelAuthorPage.Padding = New Padding(20, 5, 0, 0)
        LinkLabelAuthorPage.Size = New Size(169, 25)
        LinkLabelAuthorPage.TabIndex = 28
        LinkLabelAuthorPage.TabStop = True
        LinkLabelAuthorPage.Tag = "Label.bilibili"
        LinkLabelAuthorPage.Text = "Author (Bilibili)"
        ' 
        ' LinkLabelSponsor
        ' 
        LinkLabelSponsor.ActiveLinkColor = Color.MediumPurple
        LinkLabelSponsor.AutoSize = True
        LinkLabelSponsor.Dock = DockStyle.Top
        LinkLabelSponsor.Font = New Font("Segoe UI", 10F)
        LinkLabelSponsor.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelSponsor.LinkColor = Color.MediumPurple
        LinkLabelSponsor.Location = New Point(0, 174)
        LinkLabelSponsor.Name = "LinkLabelSponsor"
        LinkLabelSponsor.Padding = New Padding(20, 5, 0, 0)
        LinkLabelSponsor.Size = New Size(156, 25)
        LinkLabelSponsor.TabIndex = 27
        LinkLabelSponsor.TabStop = True
        LinkLabelSponsor.Tag = "Label.afdian"
        LinkLabelSponsor.Text = "Donation (Afdian)"
        ' 
        ' LinkLabelDownloadFFmpeg2
        ' 
        LinkLabelDownloadFFmpeg2.ActiveLinkColor = Color.OliveDrab
        LinkLabelDownloadFFmpeg2.AutoSize = True
        LinkLabelDownloadFFmpeg2.Dock = DockStyle.Top
        LinkLabelDownloadFFmpeg2.Font = New Font("Segoe UI", 10F)
        LinkLabelDownloadFFmpeg2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelDownloadFFmpeg2.LinkColor = Color.OliveDrab
        LinkLabelDownloadFFmpeg2.Location = New Point(0, 149)
        LinkLabelDownloadFFmpeg2.Name = "LinkLabelDownloadFFmpeg2"
        LinkLabelDownloadFFmpeg2.Padding = New Padding(20, 5, 0, 0)
        LinkLabelDownloadFFmpeg2.Size = New Size(176, 25)
        LinkLabelDownloadFFmpeg2.TabIndex = 26
        LinkLabelDownloadFFmpeg2.TabStop = True
        LinkLabelDownloadFFmpeg2.Tag = "Label.DownloadFFmpegBtbN"
        LinkLabelDownloadFFmpeg2.Text = "Download FFmpeg (BtbN)"
        ' 
        ' LinkLabelDownloadFFmpeg1
        ' 
        LinkLabelDownloadFFmpeg1.ActiveLinkColor = Color.OliveDrab
        LinkLabelDownloadFFmpeg1.AutoSize = True
        LinkLabelDownloadFFmpeg1.Dock = DockStyle.Top
        LinkLabelDownloadFFmpeg1.Font = New Font("Segoe UI", 10F)
        LinkLabelDownloadFFmpeg1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelDownloadFFmpeg1.LinkColor = Color.OliveDrab
        LinkLabelDownloadFFmpeg1.Location = New Point(0, 124)
        LinkLabelDownloadFFmpeg1.Name = "LinkLabelDownloadFFmpeg1"
        LinkLabelDownloadFFmpeg1.Padding = New Padding(20, 5, 0, 0)
        LinkLabelDownloadFFmpeg1.Size = New Size(202, 25)
        LinkLabelDownloadFFmpeg1.TabIndex = 25
        LinkLabelDownloadFFmpeg1.TabStop = True
        LinkLabelDownloadFFmpeg1.Tag = "Label.DownloadFFmpegGyandev"
        LinkLabelDownloadFFmpeg1.Text = "Download FFmpeg (gyan.dev)"
        ' 
        ' LinkLabelFFmpegDocs
        ' 
        LinkLabelFFmpegDocs.ActiveLinkColor = Color.OliveDrab
        LinkLabelFFmpegDocs.AutoSize = True
        LinkLabelFFmpegDocs.Dock = DockStyle.Top
        LinkLabelFFmpegDocs.Font = New Font("Segoe UI", 10F)
        LinkLabelFFmpegDocs.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelFFmpegDocs.LinkColor = Color.OliveDrab
        LinkLabelFFmpegDocs.Location = New Point(0, 99)
        LinkLabelFFmpegDocs.Name = "LinkLabelFFmpegDocs"
        LinkLabelFFmpegDocs.Padding = New Padding(20, 5, 0, 0)
        LinkLabelFFmpegDocs.Size = New Size(245, 25)
        LinkLabelFFmpegDocs.TabIndex = 24
        LinkLabelFFmpegDocs.TabStop = True
        LinkLabelFFmpegDocs.Tag = "Label.FFmpegOfficialDoc"
        LinkLabelFFmpegDocs.Text = "FFmpeg Docs (ffmpeg.org)"
        ' 
        ' LinkLabel3FUIRepository
        ' 
        LinkLabel3FUIRepository.ActiveLinkColor = Color.OliveDrab
        LinkLabel3FUIRepository.AutoSize = True
        LinkLabel3FUIRepository.Dock = DockStyle.Top
        LinkLabel3FUIRepository.Font = New Font("Segoe UI", 10F)
        LinkLabel3FUIRepository.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel3FUIRepository.LinkColor = Color.OliveDrab
        LinkLabel3FUIRepository.Location = New Point(0, 74)
        LinkLabel3FUIRepository.Name = "LinkLabel3FUIRepository"
        LinkLabel3FUIRepository.Padding = New Padding(20, 5, 0, 0)
        LinkLabel3FUIRepository.Size = New Size(142, 25)
        LinkLabel3FUIRepository.TabIndex = 29
        LinkLabel3FUIRepository.TabStop = True
        LinkLabel3FUIRepository.Tag = "Label.3FUIGithubRepository"
        LinkLabel3FUIRepository.Text = "3FUI GitHub Repository"
        ' 
        ' LinkLabelDoNotTrustAI
        ' 
        LinkLabelDoNotTrustAI.ActiveLinkColor = Color.Peru
        LinkLabelDoNotTrustAI.AutoSize = True
        LinkLabelDoNotTrustAI.Dock = DockStyle.Top
        LinkLabelDoNotTrustAI.Font = New Font("Segoe UI", 10F)
        LinkLabelDoNotTrustAI.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelDoNotTrustAI.LinkColor = Color.Peru
        LinkLabelDoNotTrustAI.Location = New Point(0, 49)
        LinkLabelDoNotTrustAI.Name = "LinkLabelDoNotTrustAI"
        LinkLabelDoNotTrustAI.Padding = New Padding(20, 5, 0, 0)
        LinkLabelDoNotTrustAI.Size = New Size(121, 25)
        LinkLabelDoNotTrustAI.TabIndex = 38
        LinkLabelDoNotTrustAI.TabStop = True
        LinkLabelDoNotTrustAI.Tag = "Label.DonotTrustAI"
        LinkLabelDoNotTrustAI.Text = "Do Not Trust AI!"
        ' 
        ' LabelLinksAndDocs
        ' 
        LabelLinksAndDocs.AutoSize = True
        LabelLinksAndDocs.Dock = DockStyle.Top
        LabelLinksAndDocs.Font = New Font("Segoe UI", 13F)
        LabelLinksAndDocs.Location = New Point(0, 0)
        LabelLinksAndDocs.Name = "LabelLinksAndDocs"
        LabelLinksAndDocs.Padding = New Padding(20, 20, 0, 5)
        LabelLinksAndDocs.Size = New Size(120, 49)
        LabelLinksAndDocs.TabIndex = 23
        LabelLinksAndDocs.Tag = "Label.LinkAndDocument"
        LabelLinksAndDocs.Text = "Links and Docs"
        ' 
        ' StartPage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel5)
        Controls.Add(Panel73)
        ForeColor = Color.Silver
        Name = "StartPage"
        Size = New Size(1000, 650)
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel44.ResumeLayout(False)
        Panel44.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel73 As Panel
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelMainTitle As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents LinkLabelClearMemory As LinkLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PanelNewsListPanel As Panel
    Friend WithEvents LabelNewsList As Label
    Friend WithEvents Panel44 As Panel
    Friend WithEvents LabelHighDPISupportDesc As Label
    Friend WithEvents LabelHighDPISupport As Label
    Friend WithEvents LabelHelpInfoDesc2 As Label
    Friend WithEvents LabelHelpInfoDesc1 As Label
    Friend WithEvents LabelHelpInfo As Label
    Friend WithEvents LabelNoticeBoardDesc As Label
    Friend WithEvents LabelNoticeBoard As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label122 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents LabelCheckUpdate As Label
    Friend WithEvents LinkLabelOfficialSite2 As LinkLabel
    Friend WithEvents LinkLabelOfficialSite1 As LinkLabel
    Friend WithEvents LinkLabelAuthorPage As LinkLabel
    Friend WithEvents LinkLabelSponsor As LinkLabel
    Friend WithEvents LinkLabelDownloadFFmpeg2 As LinkLabel
    Friend WithEvents LinkLabelDownloadFFmpeg1 As LinkLabel
    Friend WithEvents LinkLabelFFmpegDocs As LinkLabel
    Friend WithEvents LinkLabel3FUIRepository As LinkLabel
    Friend WithEvents LabelLinksAndDocs As Label
    Friend WithEvents LinkLabelDoNotTrustAI As LinkLabel

End Class














