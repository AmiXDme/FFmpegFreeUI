<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        UiTabControlMenu1 = New Sunny.UI.UITabControlMenu()
        TabPageStartPage = New TabPage()
        TabPageEncodingQueue = New TabPage()
        PanelOutputPanel = New Panel()
        Panel77 = New Panel()
        RichTextBox2 = New RichTextBox()
        Label45 = New Label()
        Panel13 = New Panel()
        UiCheckBoxForceScrollToBottom = New Sunny.UI.UICheckBox()
        Label44 = New Label()
        UiButtonCopyOutput = New Sunny.UI.UIButton()
        Label15 = New Label()
        UiComboBoxOutputDisplayType = New Sunny.UI.UIComboBox()
        Panel56 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ImageList1 = New ImageList(components)
        Panel1 = New Panel()
        Panel15 = New Panel()
        UiButtonTaskManagementMenu = New Sunny.UI.UIButton()
        LabelStatus = New Label()
        LabelProgress = New Label()
        LabelSpeed = New Label()
        LabelOutputSize = New Label()
        LabelQuality = New Label()
        LabelBitrate = New Label()
        LabelEstimatedRemaining = New Label()
        Panel41 = New Panel()
        Panel35 = New Panel()
        LabelFFmpegRealTimeInfo = New Label()
        LinkLabelSwitchOutput = New LinkLabel()
        LinkLabelSendToFFmpeg = New LinkLabel()
        Label1 = New Label()
        Panel2 = New Panel()
        UiButtonLocateOutput = New Sunny.UI.UIButton()
        UiButtonResetTask = New Sunny.UI.UIButton()
        UiButtonRemoveTask = New Sunny.UI.UIButton()
        UiButtonStopTask = New Sunny.UI.UIButton()
        UiButtonResumeTask = New Sunny.UI.UIButton()
        UiButtonPauseTask = New Sunny.UI.UIButton()
        UiButtonStartTask = New Sunny.UI.UIButton()
        TabPagePrepareFiles = New TabPage()
        TabPageParameters = New TabPage()
        Panel6 = New Panel()
        TabPageMediaInfo = New TabPage()
        TabPagePlayer = New TabPage()
        TabPageMuxing = New TabPage()
        TabPageMerging = New TabPage()
        TabPagePerformanceMonitoring = New TabPage()
        TabPagePlugins = New TabPage()
        Panel21 = New Panel()
        Panel24 = New Panel()
        Panel22 = New Panel()
        Label16 = New Label()
        UiComboBox3 = New Sunny.UI.UIComboBox()
        TabPageSettings = New TabPage()
        TabPageSupporters = New TabPage()
        PanelTopVisualCorrectionArea = New Panel()
        PanelTopVisualCorrectionArea_Level2TabPage = New Panel()
        PanelTopVisualCorrectionArea_Level1 = New Panel()
        UiTabControlMenu1.SuspendLayout()
        TabPageEncodingQueue.SuspendLayout()
        PanelOutputPanel.SuspendLayout()
        Panel77.SuspendLayout()
        Panel13.SuspendLayout()
        Panel56.SuspendLayout()
        Panel1.SuspendLayout()
        Panel15.SuspendLayout()
        Panel41.SuspendLayout()
        Panel35.SuspendLayout()
        Panel2.SuspendLayout()
        TabPageParameters.SuspendLayout()
        TabPagePlugins.SuspendLayout()
        Panel21.SuspendLayout()
        Panel22.SuspendLayout()
        PanelTopVisualCorrectionArea.SuspendLayout()
        SuspendLayout()
        ' 
        ' UiTabControlMenu1
        ' 
        UiTabControlMenu1.Alignment = TabAlignment.Left
        UiTabControlMenu1.Controls.Add(TabPageStartPage)
        UiTabControlMenu1.Controls.Add(TabPageEncodingQueue)
        UiTabControlMenu1.Controls.Add(TabPagePrepareFiles)
        UiTabControlMenu1.Controls.Add(TabPageParameters)
        UiTabControlMenu1.Controls.Add(TabPageMediaInfo)
        UiTabControlMenu1.Controls.Add(TabPagePlayer)
        UiTabControlMenu1.Controls.Add(TabPageMuxing)
        UiTabControlMenu1.Controls.Add(TabPageMerging)
        UiTabControlMenu1.Controls.Add(TabPagePerformanceMonitoring)
        UiTabControlMenu1.Controls.Add(TabPagePlugins)
        UiTabControlMenu1.Controls.Add(TabPageSettings)
        UiTabControlMenu1.Controls.Add(TabPageSupporters)
        UiTabControlMenu1.Dock = DockStyle.Fill
        UiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControlMenu1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControlMenu1.Font = New Font("Segoe UI", 11F)
        UiTabControlMenu1.ItemSize = New Size(150, 38)
        UiTabControlMenu1.Location = New Point(0, 10)
        UiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControlMenu1.Multiline = True
        UiTabControlMenu1.Name = "UiTabControlMenu1"
        UiTabControlMenu1.SelectedIndex = 0
        UiTabControlMenu1.Size = New Size(1184, 651)
        UiTabControlMenu1.SizeMode = TabSizeMode.Fixed
        UiTabControlMenu1.TabIndex = 1
        UiTabControlMenu1.TabSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControlMenu1.TabSelectedForeColor = Color.YellowGreen
        UiTabControlMenu1.TabSelectedHighColor = Color.YellowGreen
        UiTabControlMenu1.TextAlignment = HorizontalAlignment.Left
        ' 
        ' TabPageStartPage
        ' 
        TabPageStartPage.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageStartPage.Font = New Font("Segoe UI", 10F)
        TabPageStartPage.Location = New Point(151, 0)
        TabPageStartPage.Name = "TabPageStartPage"
        TabPageStartPage.Size = New Size(1033, 651)
        TabPageStartPage.TabIndex = 10
        TabPageStartPage.Text = "3FUI"
        ' 
        ' TabPageEncodingQueue
        ' 
        TabPageEncodingQueue.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageEncodingQueue.Controls.Add(PanelOutputPanel)
        TabPageEncodingQueue.Controls.Add(Panel56)
        TabPageEncodingQueue.Controls.Add(Panel1)
        TabPageEncodingQueue.Controls.Add(Panel41)
        TabPageEncodingQueue.Controls.Add(Panel2)
        TabPageEncodingQueue.Font = New Font("Segoe UI", 10F)
        TabPageEncodingQueue.Location = New Point(151, 0)
        TabPageEncodingQueue.Name = "TabPageEncodingQueue"
        TabPageEncodingQueue.Size = New Size(1033, 651)
        TabPageEncodingQueue.TabIndex = 0
        TabPageEncodingQueue.Tag = "TabPage.EncodingQueue"
        TabPageEncodingQueue.Text = "Encoding Queue"
        ' 
        ' PanelOutputPanel
        ' 
        PanelOutputPanel.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        PanelOutputPanel.Controls.Add(Panel77)
        PanelOutputPanel.Controls.Add(Label45)
        PanelOutputPanel.Controls.Add(Panel13)
        PanelOutputPanel.Dock = DockStyle.Right
        PanelOutputPanel.Location = New Point(533, 80)
        PanelOutputPanel.Name = "PanelOutputPanel"
        PanelOutputPanel.Padding = New Padding(10)
        PanelOutputPanel.Size = New Size(500, 531)
        PanelOutputPanel.TabIndex = 37
        PanelOutputPanel.Visible = False
        ' 
        ' Panel77
        ' 
        Panel77.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel77.Controls.Add(RichTextBox2)
        Panel77.Dock = DockStyle.Fill
        Panel77.Location = New Point(10, 80)
        Panel77.Name = "Panel77"
        Panel77.Padding = New Padding(10, 10, 0, 10)
        Panel77.Size = New Size(480, 441)
        Panel77.TabIndex = 37
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.DetectUrls = False
        RichTextBox2.Dock = DockStyle.Fill
        RichTextBox2.Font = New Font("Segoe UI", 10F)
        RichTextBox2.ForeColor = Color.DarkGray
        RichTextBox2.Location = New Point(10, 10)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox2.Size = New Size(470, 421)
        RichTextBox2.TabIndex = 11
        RichTextBox2.Text = ""
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Dock = DockStyle.Top
        Label45.Font = New Font("Segoe UI", 10F)
        Label45.ForeColor = Color.Gray
        Label45.Location = New Point(10, 50)
        Label45.Name = "Label45"
        Label45.Padding = New Padding(0, 0, 0, 10)
        Label45.Size = New Size(441, 30)
        Label45.TabIndex = 119
        Label45.Text = "Latest output saves up to 1000 lines. Viewing this information during tasks may affect experience."
        Label45.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(UiCheckBoxForceScrollToBottom)
        Panel13.Controls.Add(Label44)
        Panel13.Controls.Add(UiButtonCopyOutput)
        Panel13.Controls.Add(Label15)
        Panel13.Controls.Add(UiComboBoxOutputDisplayType)
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(10, 10)
        Panel13.Name = "Panel13"
        Panel13.Padding = New Padding(0, 0, 0, 10)
        Panel13.Size = New Size(480, 40)
        Panel13.TabIndex = 12
        ' 
        ' UiCheckBoxForceScrollToBottom
        ' 
        UiCheckBoxForceScrollToBottom.CheckBoxColor = Color.Silver
        UiCheckBoxForceScrollToBottom.CheckBoxSize = 20
        UiCheckBoxForceScrollToBottom.Dock = DockStyle.Fill
        UiCheckBoxForceScrollToBottom.Font = New Font("Segoe UI", 10F)
        UiCheckBoxForceScrollToBottom.ForeColor = Color.DarkGray
        UiCheckBoxForceScrollToBottom.Location = New Point(300, 0)
        UiCheckBoxForceScrollToBottom.MinimumSize = New Size(1, 1)
        UiCheckBoxForceScrollToBottom.Name = "UiCheckBoxForceScrollToBottom"
        UiCheckBoxForceScrollToBottom.Size = New Size(180, 30)
        UiCheckBoxForceScrollToBottom.TabIndex = 99
        UiCheckBoxForceScrollToBottom.Text = "ForceScrollToBottom"
        ' 
        ' Label44
        ' 
        Label44.Dock = DockStyle.Left
        Label44.Location = New Point(290, 0)
        Label44.Name = "Label44"
        Label44.Size = New Size(10, 30)
        Label44.TabIndex = 100
        ' 
        ' UiButtonCopyOutput
        ' 
        UiButtonCopyOutput.Dock = DockStyle.Left
        UiButtonCopyOutput.FillColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.FillColor2 = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.FillDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.FillHoverColor = SystemColors.WindowFrame
        UiButtonCopyOutput.FillPressColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiButtonCopyOutput.FillSelectedColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiButtonCopyOutput.Font = New Font("Segoe UI", 10F)
        UiButtonCopyOutput.ForeColor = Color.Silver
        UiButtonCopyOutput.ForeDisableColor = Color.Silver
        UiButtonCopyOutput.ForeHoverColor = Color.Silver
        UiButtonCopyOutput.ForeSelectedColor = Color.Silver
        UiButtonCopyOutput.Location = New Point(210, 0)
        UiButtonCopyOutput.MinimumSize = New Size(1, 1)
        UiButtonCopyOutput.Name = "UiButtonCopyOutput"
        UiButtonCopyOutput.Radius = 0
        UiButtonCopyOutput.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonCopyOutput.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.RectHoverColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButtonCopyOutput.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonCopyOutput.RectSelectedColor = Color.DarkGray
        UiButtonCopyOutput.Size = New Size(80, 30)
        UiButtonCopyOutput.TabIndex = 93
        UiButtonCopyOutput.Text = "Copy"
        UiButtonCopyOutput.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label15
        ' 
        Label15.Dock = DockStyle.Left
        Label15.Location = New Point(200, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(10, 30)
        Label15.TabIndex = 92
        ' 
        ' UiComboBoxOutputDisplayType
        ' 
        UiComboBoxOutputDisplayType.DataSource = Nothing
        UiComboBoxOutputDisplayType.Dock = DockStyle.Left
        UiComboBoxOutputDisplayType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxOutputDisplayType.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDisplayType.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDisplayType.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDisplayType.Font = New Font("Segoe UI", 10F)
        UiComboBoxOutputDisplayType.ForeColor = Color.Silver
        UiComboBoxOutputDisplayType.ForeDisableColor = Color.Silver
        UiComboBoxOutputDisplayType.ItemFillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDisplayType.ItemForeColor = Color.Silver
        UiComboBoxOutputDisplayType.ItemHeight = 30
        UiComboBoxOutputDisplayType.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxOutputDisplayType.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxOutputDisplayType.Items.AddRange(New Object() {"Latest Output (Excludes Progress)", "Error Information Only"})
        UiComboBoxOutputDisplayType.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxOutputDisplayType.ItemSelectForeColor = Color.Silver
        UiComboBoxOutputDisplayType.Location = New Point(0, 0)
        UiComboBoxOutputDisplayType.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxOutputDisplayType.MaxDropDownItems = 17
        UiComboBoxOutputDisplayType.MinimumSize = New Size(63, 0)
        UiComboBoxOutputDisplayType.Name = "UiComboBoxOutputDisplayType"
        UiComboBoxOutputDisplayType.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxOutputDisplayType.Radius = 0
        UiComboBoxOutputDisplayType.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxOutputDisplayType.RectColor = SystemColors.WindowFrame
        UiComboBoxOutputDisplayType.RectDisableColor = SystemColors.WindowFrame
        UiComboBoxOutputDisplayType.ScrollBarHandleWidth = 20
        UiComboBoxOutputDisplayType.Size = New Size(200, 30)
        UiComboBoxOutputDisplayType.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxOutputDisplayType.SymbolSize = 24
        UiComboBoxOutputDisplayType.TabIndex = 91
        UiComboBoxOutputDisplayType.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxOutputDisplayType.Watermark = "Select Category"
        ' 
        ' Panel56
        ' 
        Panel56.Controls.Add(ListView1)
        Panel56.Dock = DockStyle.Fill
        Panel56.Location = New Point(0, 80)
        Panel56.Name = "Panel56"
        Panel56.Padding = New Padding(15, 15, 0, 15)
        Panel56.Size = New Size(1033, 531)
        Panel56.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.AllowDrop = True
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        ListView1.Dock = DockStyle.Fill
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.LabelEdit = True
        ListView1.Location = New Point(15, 15)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.ShowItemToolTips = True
        ListView1.Size = New Size(1018, 501)
        ListView1.StateImageList = ImageList1
        ListView1.TabIndex = 0
        ListView1.TabStop = False
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(1, 30)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel15)
        Panel1.Controls.Add(LabelStatus)
        Panel1.Controls.Add(LabelProgress)
        Panel1.Controls.Add(LabelSpeed)
        Panel1.Controls.Add(LabelOutputSize)
        Panel1.Controls.Add(LabelQuality)
        Panel1.Controls.Add(LabelBitrate)
        Panel1.Controls.Add(LabelEstimatedRemaining)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1033, 40)
        Panel1.TabIndex = 2
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(UiButtonTaskManagementMenu)
        Panel15.Dock = DockStyle.Fill
        Panel15.Location = New Point(0, 0)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(283, 40)
        Panel15.TabIndex = 8
        ' 
        ' UiButtonTaskManagementMenu
        ' 
        UiButtonTaskManagementMenu.Dock = DockStyle.Left
        UiButtonTaskManagementMenu.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonTaskManagementMenu.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonTaskManagementMenu.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonTaskManagementMenu.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonTaskManagementMenu.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonTaskManagementMenu.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonTaskManagementMenu.Font = New Font("Segoe UI", 10F)
        UiButtonTaskManagementMenu.ForeColor = Color.CornflowerBlue
        UiButtonTaskManagementMenu.ForeDisableColor = Color.CornflowerBlue
        UiButtonTaskManagementMenu.ForeHoverColor = Color.CornflowerBlue
        UiButtonTaskManagementMenu.ForePressColor = Color.CornflowerBlue
        UiButtonTaskManagementMenu.ForeSelectedColor = Color.CornflowerBlue
        UiButtonTaskManagementMenu.Location = New Point(0, 0)
        UiButtonTaskManagementMenu.MinimumSize = New Size(1, 1)
        UiButtonTaskManagementMenu.Name = "UiButtonTaskManagementMenu"
        UiButtonTaskManagementMenu.Radius = 0
        UiButtonTaskManagementMenu.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonTaskManagementMenu.RectColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonTaskManagementMenu.RectDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonTaskManagementMenu.RectHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonTaskManagementMenu.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonTaskManagementMenu.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonTaskManagementMenu.Size = New Size(120, 40)
        UiButtonTaskManagementMenu.TabIndex = 45
        UiButtonTaskManagementMenu.Tag = "Button.MissionMenu"
        UiButtonTaskManagementMenu.Text = "Task Management Menu"
        UiButtonTaskManagementMenu.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' LabelStatus
        ' 
        LabelStatus.Dock = DockStyle.Right
        LabelStatus.Location = New Point(283, 0)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(80, 40)
        LabelStatus.TabIndex = 1
        LabelStatus.Tag = "Label.Status"
        LabelStatus.Text = "Status"
        LabelStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelProgress
        ' 
        LabelProgress.Dock = DockStyle.Right
        LabelProgress.Location = New Point(363, 0)
        LabelProgress.Name = "LabelProgress"
        LabelProgress.Size = New Size(70, 40)
        LabelProgress.TabIndex = 2
        LabelProgress.Tag = "Label.Progress"
        LabelProgress.Text = "Progress"
        LabelProgress.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelSpeed
        ' 
        LabelSpeed.Dock = DockStyle.Right
        LabelSpeed.Location = New Point(433, 0)
        LabelSpeed.Name = "LabelSpeed"
        LabelSpeed.Size = New Size(80, 40)
        LabelSpeed.TabIndex = 3
        LabelSpeed.Tag = "Label.Speed"
        LabelSpeed.Text = "Speed"
        LabelSpeed.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelOutputSize
        ' 
        LabelOutputSize.Dock = DockStyle.Right
        LabelOutputSize.Location = New Point(513, 0)
        LabelOutputSize.Name = "LabelOutputSize"
        LabelOutputSize.Size = New Size(150, 40)
        LabelOutputSize.TabIndex = 4
        LabelOutputSize.Tag = "Label.OutputSize"
        LabelOutputSize.Text = "Output Size && Estimated"
        LabelOutputSize.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelQuality
        ' 
        LabelQuality.Dock = DockStyle.Right
        LabelQuality.Location = New Point(663, 0)
        LabelQuality.Name = "LabelQuality"
        LabelQuality.Size = New Size(55, 40)
        LabelQuality.TabIndex = 5
        LabelQuality.Tag = "Label.Quality"
        LabelQuality.Text = "Quality"
        LabelQuality.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelBitrate
        ' 
        LabelBitrate.Dock = DockStyle.Right
        LabelBitrate.Location = New Point(718, 0)
        LabelBitrate.Name = "LabelBitrate"
        LabelBitrate.Size = New Size(115, 40)
        LabelBitrate.TabIndex = 6
        LabelBitrate.Tag = "Label.Bitrate"
        LabelBitrate.Text = "Bitrate"
        LabelBitrate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelEstimatedRemaining
        ' 
        LabelEstimatedRemaining.Dock = DockStyle.Right
        LabelEstimatedRemaining.Location = New Point(833, 0)
        LabelEstimatedRemaining.Name = "LabelEstimatedRemaining"
        LabelEstimatedRemaining.Size = New Size(200, 40)
        LabelEstimatedRemaining.TabIndex = 7
        LabelEstimatedRemaining.Tag = "Label.TimeRemaining"
        LabelEstimatedRemaining.Text = "Estimated Remaining && Used"
        LabelEstimatedRemaining.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel41
        ' 
        Panel41.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel41.Controls.Add(Panel35)
        Panel41.Dock = DockStyle.Bottom
        Panel41.Location = New Point(0, 611)
        Panel41.Name = "Panel41"
        Panel41.Padding = New Padding(10)
        Panel41.Size = New Size(1033, 40)
        Panel41.TabIndex = 5
        ' 
        ' Panel35
        ' 
        Panel35.AutoSize = True
        Panel35.Controls.Add(LabelFFmpegRealTimeInfo)
        Panel35.Controls.Add(LinkLabelSwitchOutput)
        Panel35.Controls.Add(LinkLabelSendToFFmpeg)
        Panel35.Controls.Add(Label1)
        Panel35.Dock = DockStyle.Top
        Panel35.Location = New Point(10, 10)
        Panel35.Name = "Panel35"
        Panel35.Size = New Size(1013, 20)
        Panel35.TabIndex = 17
        ' 
        ' LabelFFmpegRealTimeInfo
        ' 
        LabelFFmpegRealTimeInfo.AutoSize = True
        LabelFFmpegRealTimeInfo.Dock = DockStyle.Top
        LabelFFmpegRealTimeInfo.ForeColor = Color.CornflowerBlue
        LabelFFmpegRealTimeInfo.Location = New Point(293, 0)
        LabelFFmpegRealTimeInfo.Name = "LabelFFmpegRealTimeInfo"
        LabelFFmpegRealTimeInfo.Size = New Size(118, 20)
        LabelFFmpegRealTimeInfo.TabIndex = 14
        LabelFFmpegRealTimeInfo.Text = "ffmpeg RealTimeInfo"
        LabelFFmpegRealTimeInfo.Visible = False
        ' 
        ' LinkLabelSwitchOutput
        ' 
        LinkLabelSwitchOutput.ActiveLinkColor = Color.MediumPurple
        LinkLabelSwitchOutput.AutoSize = True
        LinkLabelSwitchOutput.Dock = DockStyle.Left
        LinkLabelSwitchOutput.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelSwitchOutput.LinkColor = Color.YellowGreen
        LinkLabelSwitchOutput.Location = New Point(228, 0)
        LinkLabelSwitchOutput.Name = "LinkLabelSwitchOutput"
        LinkLabelSwitchOutput.Size = New Size(65, 20)
        LinkLabelSwitchOutput.TabIndex = 17
        LinkLabelSwitchOutput.TabStop = True
        LinkLabelSwitchOutput.Text = "OutputPanel"
        LinkLabelSwitchOutput.Visible = False
        ' 
        ' LinkLabelSendToFFmpeg
        ' 
        LinkLabelSendToFFmpeg.ActiveLinkColor = Color.MediumPurple
        LinkLabelSendToFFmpeg.AutoSize = True
        LinkLabelSendToFFmpeg.Dock = DockStyle.Left
        LinkLabelSendToFFmpeg.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabelSendToFFmpeg.LinkColor = Color.Silver
        LinkLabelSendToFFmpeg.Location = New Point(191, 0)
        LinkLabelSendToFFmpeg.Name = "LinkLabelSendToFFmpeg"
        LinkLabelSendToFFmpeg.Size = New Size(37, 20)
        LinkLabelSendToFFmpeg.TabIndex = 18
        LinkLabelSendToFFmpeg.TabStop = True
        LinkLabelSendToFFmpeg.Tag = "LinkLabel.Send"
        LinkLabelSendToFFmpeg.Text = "Send"
        LinkLabelSendToFFmpeg.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 20)
        Label1.TabIndex = 19
        Label1.Text = "Select a task to view real-time info"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel2.Controls.Add(UiButtonLocateOutput)
        Panel2.Controls.Add(UiButtonResetTask)
        Panel2.Controls.Add(UiButtonRemoveTask)
        Panel2.Controls.Add(UiButtonStopTask)
        Panel2.Controls.Add(UiButtonResumeTask)
        Panel2.Controls.Add(UiButtonPauseTask)
        Panel2.Controls.Add(UiButtonStartTask)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 0, 10, 0)
        Panel2.Size = New Size(1033, 40)
        Panel2.TabIndex = 3
        ' 
        ' UiButtonLocateOutput
        ' 
        UiButtonLocateOutput.Dock = DockStyle.Left
        UiButtonLocateOutput.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonLocateOutput.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonLocateOutput.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonLocateOutput.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonLocateOutput.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonLocateOutput.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonLocateOutput.Font = New Font("Segoe UI", 11F)
        UiButtonLocateOutput.ForeColor = Color.MediumPurple
        UiButtonLocateOutput.ForeDisableColor = Color.MediumPurple
        UiButtonLocateOutput.ForeHoverColor = Color.MediumPurple
        UiButtonLocateOutput.ForePressColor = Color.MediumPurple
        UiButtonLocateOutput.ForeSelectedColor = Color.MediumPurple
        UiButtonLocateOutput.Location = New Point(390, 0)
        UiButtonLocateOutput.MinimumSize = New Size(1, 1)
        UiButtonLocateOutput.Name = "UiButtonLocateOutput"
        UiButtonLocateOutput.Radius = 0
        UiButtonLocateOutput.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonLocateOutput.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonLocateOutput.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonLocateOutput.RectHoverColor = Color.CornflowerBlue
        UiButtonLocateOutput.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonLocateOutput.RectSelectedColor = Color.CornflowerBlue
        UiButtonLocateOutput.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonLocateOutput.Size = New Size(65, 40)
        UiButtonLocateOutput.TabIndex = 86
        UiButtonLocateOutput.Tag = "Button.LocateMission"
        UiButtonLocateOutput.Text = "Position"
        UiButtonLocateOutput.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UiButtonLocateOutput.TipsText = "LocateOutput"
        ' 
        ' UiButtonResetTask
        ' 
        UiButtonResetTask.Dock = DockStyle.Left
        UiButtonResetTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonResetTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonResetTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonResetTask.Font = New Font("Segoe UI", 11F)
        UiButtonResetTask.ForeColor = Color.Goldenrod
        UiButtonResetTask.ForeDisableColor = Color.Goldenrod
        UiButtonResetTask.ForeHoverColor = Color.Goldenrod
        UiButtonResetTask.ForePressColor = Color.Goldenrod
        UiButtonResetTask.ForeSelectedColor = Color.Goldenrod
        UiButtonResetTask.Location = New Point(325, 0)
        UiButtonResetTask.MinimumSize = New Size(1, 1)
        UiButtonResetTask.Name = "UiButtonResetTask"
        UiButtonResetTask.Radius = 0
        UiButtonResetTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonResetTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonResetTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonResetTask.RectHoverColor = Color.CornflowerBlue
        UiButtonResetTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonResetTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonResetTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonResetTask.Size = New Size(65, 40)
        UiButtonResetTask.TabIndex = 78
        UiButtonResetTask.Tag = "Button.ResetMission"
        UiButtonResetTask.Text = "Reset"
        UiButtonResetTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonRemoveTask
        ' 
        UiButtonRemoveTask.Dock = DockStyle.Left
        UiButtonRemoveTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemoveTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemoveTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemoveTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonRemoveTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRemoveTask.Font = New Font("Segoe UI", 11F)
        UiButtonRemoveTask.ForeColor = Color.IndianRed
        UiButtonRemoveTask.ForeDisableColor = Color.IndianRed
        UiButtonRemoveTask.ForeHoverColor = Color.IndianRed
        UiButtonRemoveTask.ForePressColor = Color.IndianRed
        UiButtonRemoveTask.ForeSelectedColor = Color.IndianRed
        UiButtonRemoveTask.Location = New Point(260, 0)
        UiButtonRemoveTask.MinimumSize = New Size(1, 1)
        UiButtonRemoveTask.Name = "UiButtonRemoveTask"
        UiButtonRemoveTask.Radius = 0
        UiButtonRemoveTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonRemoveTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonRemoveTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonRemoveTask.RectHoverColor = Color.CornflowerBlue
        UiButtonRemoveTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRemoveTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonRemoveTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonRemoveTask.Size = New Size(65, 40)
        UiButtonRemoveTask.TabIndex = 54
        UiButtonRemoveTask.Tag = "Button.RemoveMission"
        UiButtonRemoveTask.Text = "Remove"
        UiButtonRemoveTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonStopTask
        ' 
        UiButtonStopTask.Dock = DockStyle.Left
        UiButtonStopTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStopTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStopTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStopTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStopTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonStopTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonStopTask.Font = New Font("Segoe UI", 11F)
        UiButtonStopTask.ForeColor = Color.IndianRed
        UiButtonStopTask.ForeDisableColor = Color.IndianRed
        UiButtonStopTask.ForeHoverColor = Color.IndianRed
        UiButtonStopTask.ForePressColor = Color.IndianRed
        UiButtonStopTask.ForeSelectedColor = Color.IndianRed
        UiButtonStopTask.Location = New Point(195, 0)
        UiButtonStopTask.MinimumSize = New Size(1, 1)
        UiButtonStopTask.Name = "UiButtonStopTask"
        UiButtonStopTask.Radius = 0
        UiButtonStopTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonStopTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonStopTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonStopTask.RectHoverColor = Color.CornflowerBlue
        UiButtonStopTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonStopTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonStopTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonStopTask.Size = New Size(65, 40)
        UiButtonStopTask.TabIndex = 52
        UiButtonStopTask.Tag = "Button.StopMission"
        UiButtonStopTask.Text = "Stop"
        UiButtonStopTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonResumeTask
        ' 
        UiButtonResumeTask.Dock = DockStyle.Left
        UiButtonResumeTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResumeTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResumeTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResumeTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonResumeTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonResumeTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonResumeTask.Font = New Font("Segoe UI", 11F)
        UiButtonResumeTask.ForeColor = Color.YellowGreen
        UiButtonResumeTask.ForeDisableColor = Color.YellowGreen
        UiButtonResumeTask.ForeHoverColor = Color.YellowGreen
        UiButtonResumeTask.ForePressColor = Color.YellowGreen
        UiButtonResumeTask.ForeSelectedColor = Color.YellowGreen
        UiButtonResumeTask.Location = New Point(130, 0)
        UiButtonResumeTask.MinimumSize = New Size(1, 1)
        UiButtonResumeTask.Name = "UiButtonResumeTask"
        UiButtonResumeTask.Radius = 0
        UiButtonResumeTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonResumeTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonResumeTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonResumeTask.RectHoverColor = Color.CornflowerBlue
        UiButtonResumeTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonResumeTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonResumeTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonResumeTask.Size = New Size(65, 40)
        UiButtonResumeTask.TabIndex = 48
        UiButtonResumeTask.Tag = "Button.ResumeMission"
        UiButtonResumeTask.Text = "Resume"
        UiButtonResumeTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonPauseTask
        ' 
        UiButtonPauseTask.Dock = DockStyle.Left
        UiButtonPauseTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonPauseTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonPauseTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonPauseTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonPauseTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonPauseTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonPauseTask.Font = New Font("Segoe UI", 11F)
        UiButtonPauseTask.ForeColor = Color.Goldenrod
        UiButtonPauseTask.ForeDisableColor = Color.Goldenrod
        UiButtonPauseTask.ForeHoverColor = Color.Goldenrod
        UiButtonPauseTask.ForePressColor = Color.Goldenrod
        UiButtonPauseTask.ForeSelectedColor = Color.Goldenrod
        UiButtonPauseTask.Location = New Point(65, 0)
        UiButtonPauseTask.MinimumSize = New Size(1, 1)
        UiButtonPauseTask.Name = "UiButtonPauseTask"
        UiButtonPauseTask.Radius = 0
        UiButtonPauseTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonPauseTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonPauseTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonPauseTask.RectHoverColor = Color.CornflowerBlue
        UiButtonPauseTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonPauseTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonPauseTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonPauseTask.Size = New Size(65, 40)
        UiButtonPauseTask.TabIndex = 46
        UiButtonPauseTask.Tag = "Button.PauseMission"
        UiButtonPauseTask.Text = "Pause"
        UiButtonPauseTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonStartTask
        ' 
        UiButtonStartTask.Dock = DockStyle.Left
        UiButtonStartTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStartTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStartTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonStartTask.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartTask.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonStartTask.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonStartTask.Font = New Font("Segoe UI", 11F)
        UiButtonStartTask.ForeColor = Color.YellowGreen
        UiButtonStartTask.ForeDisableColor = Color.YellowGreen
        UiButtonStartTask.ForeHoverColor = Color.YellowGreen
        UiButtonStartTask.ForePressColor = Color.YellowGreen
        UiButtonStartTask.ForeSelectedColor = Color.YellowGreen
        UiButtonStartTask.Location = New Point(0, 0)
        UiButtonStartTask.MinimumSize = New Size(1, 1)
        UiButtonStartTask.Name = "UiButtonStartTask"
        UiButtonStartTask.Radius = 0
        UiButtonStartTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonStartTask.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonStartTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonStartTask.RectHoverColor = Color.CornflowerBlue
        UiButtonStartTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonStartTask.RectSelectedColor = Color.CornflowerBlue
        UiButtonStartTask.RectSides = ToolStripStatusLabelBorderSides.None
        UiButtonStartTask.Size = New Size(65, 40)
        UiButtonStartTask.TabIndex = 44
        UiButtonStartTask.Tag = "Button.StartMission"
        UiButtonStartTask.Text = "Start"
        UiButtonStartTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' TabPagePrepareFiles
        ' 
        TabPagePrepareFiles.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPagePrepareFiles.Font = New Font("Segoe UI", 10F)
        TabPagePrepareFiles.Location = New Point(151, 0)
        TabPagePrepareFiles.Name = "TabPagePrepareFiles"
        TabPagePrepareFiles.Size = New Size(1033, 651)
        TabPagePrepareFiles.TabIndex = 1
        TabPagePrepareFiles.Tag = "TabPage.PrepareFile"
        TabPagePrepareFiles.Text = "Prepare Files"
        ' 
        ' TabPageParameters
        ' 
        TabPageParameters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageParameters.Controls.Add(Panel6)
        TabPageParameters.Location = New Point(151, 0)
        TabPageParameters.Name = "TabPageParameters"
        TabPageParameters.Size = New Size(1033, 651)
        TabPageParameters.TabIndex = 14
        TabPageParameters.Tag = "TabPage.ParameterPanel"
        TabPageParameters.Text = "ParametersPanel"
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Fill
        Panel6.Font = New Font("Segoe UI", 10F)
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1033, 651)
        Panel6.TabIndex = 0
        ' 
        ' TabPageMediaInfo
        ' 
        TabPageMediaInfo.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageMediaInfo.Location = New Point(151, 0)
        TabPageMediaInfo.Name = "TabPageMediaInfo"
        TabPageMediaInfo.Size = New Size(1033, 651)
        TabPageMediaInfo.TabIndex = 17
        TabPageMediaInfo.Tag = "TabPage.MediaInfo"
        TabPageMediaInfo.Text = "Media Info"
        ' 
        ' TabPagePlayer
        ' 
        TabPagePlayer.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPagePlayer.Location = New Point(151, 0)
        TabPagePlayer.Name = "TabPagePlayer"
        TabPagePlayer.Size = New Size(1033, 651)
        TabPagePlayer.TabIndex = 26
        TabPagePlayer.Tag = "TabPage.Player"
        TabPagePlayer.Text = "Player"
        ' 
        ' TabPageMuxing
        ' 
        TabPageMuxing.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageMuxing.Location = New Point(151, 0)
        TabPageMuxing.Name = "TabPageMuxing"
        TabPageMuxing.Size = New Size(1033, 651)
        TabPageMuxing.TabIndex = 18
        TabPageMuxing.Tag = "TabPage.Mixing"
        TabPageMuxing.Text = "Muxing"
        ' 
        ' TabPageMerging
        ' 
        TabPageMerging.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageMerging.Location = New Point(151, 0)
        TabPageMerging.Name = "TabPageMerging"
        TabPageMerging.Size = New Size(1033, 651)
        TabPageMerging.TabIndex = 19
        TabPageMerging.Tag = "TabPage.Merging"
        TabPageMerging.Text = "Merge"
        ' 
        ' TabPagePerformanceMonitoring
        ' 
        TabPagePerformanceMonitoring.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPagePerformanceMonitoring.Location = New Point(151, 0)
        TabPagePerformanceMonitoring.Name = "TabPagePerformanceMonitoring"
        TabPagePerformanceMonitoring.Size = New Size(1033, 651)
        TabPagePerformanceMonitoring.TabIndex = 21
        TabPagePerformanceMonitoring.Tag = "TabPage.PerformanceMonitoring"
        TabPagePerformanceMonitoring.Text = "Performance Monitor"
        ' 
        ' TabPagePlugins
        ' 
        TabPagePlugins.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPagePlugins.Controls.Add(Panel21)
        TabPagePlugins.Location = New Point(151, 0)
        TabPagePlugins.Name = "TabPagePlugins"
        TabPagePlugins.Size = New Size(1033, 651)
        TabPagePlugins.TabIndex = 22
        TabPagePlugins.Tag = "TabPage.PluginExtension"
        TabPagePlugins.Text = "Plugins"
        ' 
        ' Panel21
        ' 
        Panel21.Controls.Add(Panel24)
        Panel21.Controls.Add(Panel22)
        Panel21.Dock = DockStyle.Fill
        Panel21.Location = New Point(0, 0)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(1033, 651)
        Panel21.TabIndex = 0
        ' 
        ' Panel24
        ' 
        Panel24.Dock = DockStyle.Fill
        Panel24.Location = New Point(0, 40)
        Panel24.Name = "Panel24"
        Panel24.Size = New Size(1033, 611)
        Panel24.TabIndex = 86
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel22.Controls.Add(Label16)
        Panel22.Controls.Add(UiComboBox3)
        Panel22.Dock = DockStyle.Top
        Panel22.Location = New Point(0, 0)
        Panel22.Name = "Panel22"
        Panel22.Padding = New Padding(10, 0, 10, 10)
        Panel22.Size = New Size(1033, 40)
        Panel22.TabIndex = 84
        ' 
        ' Label16
        ' 
        Label16.Dock = DockStyle.Fill
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.ForeColor = Color.Gray
        Label16.Location = New Point(310, 0)
        Label16.Name = "Label16"
        Label16.Padding = New Padding(10, 0, 0, 0)
        Label16.Size = New Size(713, 30)
        Label16.TabIndex = 87
        Label16.Text = "Please refer to the README on GitHub for technical details on plugin development"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBox3
        ' 
        UiComboBox3.DataSource = Nothing
        UiComboBox3.Dock = DockStyle.Left
        UiComboBox3.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBox3.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox3.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox3.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox3.Font = New Font("Segoe UI", 9.75F)
        UiComboBox3.ForeColor = Color.Silver
        UiComboBox3.ForeDisableColor = Color.Silver
        UiComboBox3.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox3.ItemForeColor = Color.Silver
        UiComboBox3.ItemHeight = 30
        UiComboBox3.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBox3.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBox3.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox3.ItemSelectForeColor = Color.Silver
        UiComboBox3.Location = New Point(10, 0)
        UiComboBox3.Margin = New Padding(4, 5, 4, 5)
        UiComboBox3.MaxDropDownItems = 17
        UiComboBox3.MinimumSize = New Size(63, 0)
        UiComboBox3.Name = "UiComboBox3"
        UiComboBox3.Padding = New Padding(0, 0, 30, 2)
        UiComboBox3.Radius = 0
        UiComboBox3.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBox3.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox3.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox3.ScrollBarHandleWidth = 20
        UiComboBox3.Size = New Size(300, 30)
        UiComboBox3.Style = Sunny.UI.UIStyle.Custom
        UiComboBox3.SymbolSize = 24
        UiComboBox3.TabIndex = 86
        UiComboBox3.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBox3.Watermark = ""
        ' 
        ' TabPageSettings
        ' 
        TabPageSettings.AutoScroll = True
        TabPageSettings.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageSettings.Location = New Point(151, 0)
        TabPageSettings.Name = "TabPageSettings"
        TabPageSettings.Size = New Size(1033, 651)
        TabPageSettings.TabIndex = 24
        TabPageSettings.Tag = "TabPage.Settings"
        TabPageSettings.Text = "Settings"
        ' 
        ' TabPageSupporters
        ' 
        TabPageSupporters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageSupporters.Location = New Point(151, 0)
        TabPageSupporters.Name = "TabPageSupporters"
        TabPageSupporters.Size = New Size(1033, 651)
        TabPageSupporters.TabIndex = 25
        TabPageSupporters.Tag = "TabPage.Supporters"
        TabPageSupporters.Text = "Supporters"
        ' 
        ' PanelTopVisualCorrectionArea
        ' 
        PanelTopVisualCorrectionArea.Controls.Add(PanelTopVisualCorrectionArea_Level2TabPage)
        PanelTopVisualCorrectionArea.Controls.Add(PanelTopVisualCorrectionArea_Level1)
        PanelTopVisualCorrectionArea.Dock = DockStyle.Top
        PanelTopVisualCorrectionArea.Location = New Point(0, 0)
        PanelTopVisualCorrectionArea.Name = "PanelTopVisualCorrectionArea"
        PanelTopVisualCorrectionArea.Size = New Size(1184, 10)
        PanelTopVisualCorrectionArea.TabIndex = 2
        ' 
        ' PanelTopVisualCorrectionArea_Level2TabPage
        ' 
        PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Left
        PanelTopVisualCorrectionArea_Level2TabPage.Location = New Point(152, 0)
        PanelTopVisualCorrectionArea_Level2TabPage.Name = "PanelTopVisualCorrectionArea_Level2TabPage"
        PanelTopVisualCorrectionArea_Level2TabPage.Size = New Size(202, 10)
        PanelTopVisualCorrectionArea_Level2TabPage.TabIndex = 1
        ' 
        ' PanelTopVisualCorrectionArea_Level1
        ' 
        PanelTopVisualCorrectionArea_Level1.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        PanelTopVisualCorrectionArea_Level1.Dock = DockStyle.Left
        PanelTopVisualCorrectionArea_Level1.Location = New Point(0, 0)
        PanelTopVisualCorrectionArea_Level1.Name = "PanelTopVisualCorrectionArea_Level1"
        PanelTopVisualCorrectionArea_Level1.Size = New Size(152, 10)
        PanelTopVisualCorrectionArea_Level1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1184, 661)
        Controls.Add(UiTabControlMenu1)
        Controls.Add(PanelTopVisualCorrectionArea)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1200, 700)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "FFmpegFreeUI"
        UiTabControlMenu1.ResumeLayout(False)
        TabPageEncodingQueue.ResumeLayout(False)
        PanelOutputPanel.ResumeLayout(False)
        PanelOutputPanel.PerformLayout()
        Panel77.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel56.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel41.ResumeLayout(False)
        Panel41.PerformLayout()
        Panel35.ResumeLayout(False)
        Panel35.PerformLayout()
        Panel2.ResumeLayout(False)
        TabPageParameters.ResumeLayout(False)
        TabPagePlugins.ResumeLayout(False)
        Panel21.ResumeLayout(False)
        Panel22.ResumeLayout(False)
        PanelTopVisualCorrectionArea.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents UiTabControlMenu1 As Sunny.UI.UITabControlMenu
    Friend WithEvents TabPageEncodingQueue As TabPage
    Friend WithEvents TabPagePrepareFiles As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelEstimatedRemaining As Label
    Friend WithEvents LabelBitrate As Label
    Friend WithEvents LabelQuality As Label
    Friend WithEvents LabelOutputSize As Label
    Friend WithEvents LabelSpeed As Label
    Friend WithEvents LabelProgress As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiButtonStartTask As Sunny.UI.UIButton
    Friend WithEvents UiButtonRemoveTask As Sunny.UI.UIButton
    Friend WithEvents UiButtonStopTask As Sunny.UI.UIButton
    Friend WithEvents UiButtonResumeTask As Sunny.UI.UIButton
    Friend WithEvents UiButtonPauseTask As Sunny.UI.UIButton
    Friend WithEvents Panel56 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents UiButtonResetTask As Sunny.UI.UIButton
    Friend WithEvents TabPageStartPage As TabPage
    Friend WithEvents Panel41 As Panel
    Friend WithEvents TabPageParameters As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TabPageMediaInfo As TabPage
    Friend WithEvents UiButtonLocateOutput As Sunny.UI.UIButton
    Friend WithEvents TabPageMuxing As TabPage
    Friend WithEvents TabPageMerging As TabPage
    Friend WithEvents TabPagePerformanceMonitoring As TabPage
    Friend WithEvents TabPagePlugins As TabPage
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents UiComboBox3 As Sunny.UI.UIComboBox
    Friend WithEvents Panel35 As Panel
    Friend WithEvents LabelFFmpegRealTimeInfo As Label
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents PanelOutputPanel As Panel
    Friend WithEvents LinkLabelSwitchOutput As LinkLabel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents UiComboBoxOutputDisplayType As Sunny.UI.UIComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents UiButtonCopyOutput As Sunny.UI.UIButton
    Friend WithEvents UiCheckBoxForceScrollToBottom As Sunny.UI.UICheckBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Panel77 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents UiButtonTaskManagementMenu As Sunny.UI.UIButton
    Friend WithEvents TabPageSupporters As TabPage
    Friend WithEvents PanelTopVisualCorrectionArea As Panel
    Friend WithEvents PanelTopVisualCorrectionArea_Level1 As Panel
    Friend WithEvents PanelTopVisualCorrectionArea_Level2TabPage As Panel
    Friend WithEvents TabPagePlayer As TabPage
    Friend WithEvents LinkLabelSendToFFmpeg As LinkLabel
    Friend WithEvents Label1 As Label

End Class














