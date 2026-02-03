<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuxingPage
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
        Label123 = New Label()
        Label20 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Panel3 = New Panel()
        Panel8 = New Panel()
        UiCheckBoxUseMetadata = New Sunny.UI.UICheckBox()
        UiCheckBoxUseChapters = New Sunny.UI.UICheckBox()
        Label21 = New Label()
        Panel62 = New Panel()
        UiTextBoxSubtitleStreams = New Sunny.UI.UITextBox()
        Label17 = New Label()
        UiTextBoxAudioStreams = New Sunny.UI.UITextBox()
        Label14 = New Label()
        UiTextBoxVideoStreams = New Sunny.UI.UITextBox()
        Label101 = New Label()
        Panel4 = New Panel()
        UiButtonRemove = New Sunny.UI.UIButton()
        Label3 = New Label()
        UiButtonMoveDown = New Sunny.UI.UIButton()
        Label10 = New Label()
        UiButtonMoveUp = New Sunny.UI.UIButton()
        Label8 = New Label()
        UiButtonAddFile = New Sunny.UI.UIButton()
        LabelVideo = New Label()
        LabelAudio = New Label()
        LabelSubtitles = New Label()
        LabelChapter = New Label()
        LabelMetadata = New Label()
        Label1 = New Label()
        Label11 = New Label()
        Panel5 = New Panel()
        UiTextBoxOutputFile = New Sunny.UI.UITextBox()
        Label6 = New Label()
        Label132 = New Label()
        UiButtonSelectLocation = New Sunny.UI.UIButton()
        UiButtonStartMuxing = New Sunny.UI.UIButton()
        Panel73.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel62.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel73
        ' 
        Panel73.AutoSize = True
        Panel73.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel73.Controls.Add(Label123)
        Panel73.Dock = DockStyle.Top
        Panel73.Location = New Point(10, 0)
        Panel73.Name = "Panel73"
        Panel73.Padding = New Padding(10)
        Panel73.Size = New Size(1080, 39)
        Panel73.TabIndex = 80
        ' 
        ' Label123
        ' 
        Label123.AutoSize = True
        Label123.Dock = DockStyle.Top
        Label123.Font = New Font("Segoe UI", 9.75F)
        Label123.ForeColor = Color.Gray
        Label123.Location = New Point(10, 10)
        Label123.Name = "Label123"
        Label123.Size = New Size(509, 19)
        Label123.TabIndex = 4
        Label123.Text = "Basic stream muxing only. For advanced features use MKVToolNix GUI; for extraction use MKVExtract GUI."
        ' 
        ' Label20
        ' 
        Label20.Dock = DockStyle.Top
        Label20.Location = New Point(10, 39)
        Label20.Name = "Label20"
        Label20.Size = New Size(1080, 10)
        Label20.TabIndex = 82
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(10, 49)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(1080, 581)
        Panel1.TabIndex = 83
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel2.Controls.Add(ListView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(10, 79)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(1060, 412)
        Panel2.TabIndex = 5
        ' 
        ' ListView1
        ' 
        ListView1.AllowDrop = True
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        ListView1.Dock = DockStyle.Fill
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(10, 10)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(1050, 392)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel3
        ' 
        Panel3.AutoSize = True
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel62)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(10, 491)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 10, 0, 0)
        Panel3.Size = New Size(1060, 80)
        Panel3.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(UiCheckBoxUseMetadata)
        Panel8.Controls.Add(UiCheckBoxUseChapters)
        Panel8.Controls.Add(Label21)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 50)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1060, 30)
        Panel8.TabIndex = 8
        UiCheckBoxUseMetadata.CheckBoxColor = Color.Silver
        UiCheckBoxUseMetadata.CheckBoxSize = 20
        UiCheckBoxUseMetadata.Dock = DockStyle.Left
        UiCheckBoxUseMetadata.Font = New Font("Segoe UI", 9.75F)
        UiCheckBoxUseMetadata.ForeColor = Color.Silver
        UiCheckBoxUseMetadata.Location = New Point(325, 0)
        UiCheckBoxUseMetadata.MinimumSize = New Size(1, 1)
        UiCheckBoxUseMetadata.Name = "UiCheckBoxUseMetadata"
        UiCheckBoxUseMetadata.Size = New Size(200, 30)
        UiCheckBoxUseMetadata.TabIndex = 101
        UiCheckBoxUseMetadata.Text = "Use Metadata from this file"
        UiCheckBoxUseChapters.CheckBoxColor = Color.Silver
        UiCheckBoxUseChapters.CheckBoxSize = 20
        UiCheckBoxUseChapters.Dock = DockStyle.Left
        UiCheckBoxUseChapters.Font = New Font("Segoe UI", 9.75F)
        UiCheckBoxUseChapters.ForeColor = Color.Silver
        UiCheckBoxUseChapters.Location = New Point(125, 0)
        UiCheckBoxUseChapters.MinimumSize = New Size(1, 1)
        UiCheckBoxUseChapters.Name = "UiCheckBoxUseChapters"
        UiCheckBoxUseChapters.Size = New Size(200, 30)
        UiCheckBoxUseChapters.TabIndex = 99
        UiCheckBoxUseChapters.Text = "Use Chapters from this file"
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Left
        Label21.Font = New Font("Segoe UI", 9.75F)
        Label21.Location = New Point(0, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(125, 30)
        Label21.TabIndex = 95
        Label21.Text = "Chapter and Metadata"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel62
        ' 
        Panel62.Controls.Add(UiTextBoxSubtitleStreams)
        Panel62.Controls.Add(Label17)
        Panel62.Controls.Add(UiTextBoxAudioStreams)
        Panel62.Controls.Add(Label14)
        Panel62.Controls.Add(UiTextBoxVideoStreams)
        Panel62.Controls.Add(Label101)
        Panel62.Dock = DockStyle.Top
        Panel62.Location = New Point(0, 10)
        Panel62.Name = "Panel62"
        Panel62.Padding = New Padding(0, 0, 0, 10)
        Panel62.Size = New Size(1060, 40)
        Panel62.TabIndex = 5
        ' 
        ' UiTextBox3
        ' 
        UiTextBoxSubtitleStreams.Dock = DockStyle.Left
        UiTextBoxSubtitleStreams.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSubtitleStreams.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSubtitleStreams.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxSubtitleStreams.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxSubtitleStreams.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxSubtitleStreams.ForeColor = Color.DarkGray
        UiTextBoxSubtitleStreams.ForeDisableColor = Color.DarkGray
        UiTextBoxSubtitleStreams.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSubtitleStreams.Location = New Point(775, 0)
        UiTextBoxSubtitleStreams.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSubtitleStreams.MinimumSize = New Size(1, 16)
        UiTextBoxSubtitleStreams.Name = "UiTextBoxSubtitleStreams"
        UiTextBoxSubtitleStreams.Padding = New Padding(5)
        UiTextBoxSubtitleStreams.Radius = 30
        UiTextBoxSubtitleStreams.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSubtitleStreams.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSubtitleStreams.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSubtitleStreams.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSubtitleStreams.ScrollBarColor = Color.DimGray
        UiTextBoxSubtitleStreams.ScrollBarStyleInherited = False
        UiTextBoxSubtitleStreams.ShowText = False
        UiTextBoxSubtitleStreams.Size = New Size(200, 30)
        UiTextBoxSubtitleStreams.TabIndex = 100
        UiTextBoxSubtitleStreams.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSubtitleStreams.Watermark = "Multiple streams separated by commas"
        UiTextBoxSubtitleStreams.WatermarkActiveColor = Color.DimGray
        UiTextBoxSubtitleStreams.WatermarkColor = Color.DimGray
        ' 
        ' Label17
        ' 
        Label17.Dock = DockStyle.Left
        Label17.Font = New Font("Segoe UI", 9.75F)
        Label17.Location = New Point(650, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(125, 30)
        Label17.TabIndex = 99
        Label17.Text = "Subtitle Stream Index:"
        Label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiTextBox2
        ' 
        UiTextBoxAudioStreams.Dock = DockStyle.Left
        UiTextBoxAudioStreams.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAudioStreams.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAudioStreams.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAudioStreams.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAudioStreams.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxAudioStreams.ForeColor = Color.DarkGray
        UiTextBoxAudioStreams.ForeDisableColor = Color.DarkGray
        UiTextBoxAudioStreams.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxAudioStreams.Location = New Point(450, 0)
        UiTextBoxAudioStreams.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxAudioStreams.MinimumSize = New Size(1, 16)
        UiTextBoxAudioStreams.Name = "UiTextBoxAudioStreams"
        UiTextBoxAudioStreams.Padding = New Padding(5)
        UiTextBoxAudioStreams.Radius = 30
        UiTextBoxAudioStreams.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAudioStreams.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAudioStreams.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAudioStreams.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAudioStreams.ScrollBarColor = Color.DimGray
        UiTextBoxAudioStreams.ScrollBarStyleInherited = False
        UiTextBoxAudioStreams.ShowText = False
        UiTextBoxAudioStreams.Size = New Size(200, 30)
        UiTextBoxAudioStreams.TabIndex = 98
        UiTextBoxAudioStreams.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxAudioStreams.Watermark = "Multiple streams separated by commas"
        UiTextBoxAudioStreams.WatermarkActiveColor = Color.DimGray
        UiTextBoxAudioStreams.WatermarkColor = Color.DimGray
        ' 
        ' Label14
        ' 
        Label14.Dock = DockStyle.Left
        Label14.Font = New Font("Segoe UI", 9.75F)
        Label14.Location = New Point(325, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 30)
        Label14.TabIndex = 97
        Label14.Text = "Audio Stream Index:"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiTextBox1
        ' 
        UiTextBoxVideoStreams.Dock = DockStyle.Left
        UiTextBoxVideoStreams.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxVideoStreams.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxVideoStreams.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxVideoStreams.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxVideoStreams.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxVideoStreams.ForeColor = Color.DarkGray
        UiTextBoxVideoStreams.ForeDisableColor = Color.DarkGray
        UiTextBoxVideoStreams.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxVideoStreams.Location = New Point(125, 0)
        UiTextBoxVideoStreams.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxVideoStreams.MinimumSize = New Size(1, 16)
        UiTextBoxVideoStreams.Name = "UiTextBoxVideoStreams"
        UiTextBoxVideoStreams.Padding = New Padding(5)
        UiTextBoxVideoStreams.Radius = 30
        UiTextBoxVideoStreams.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxVideoStreams.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxVideoStreams.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxVideoStreams.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxVideoStreams.ScrollBarColor = Color.DimGray
        UiTextBoxVideoStreams.ScrollBarStyleInherited = False
        UiTextBoxVideoStreams.ShowText = False
        UiTextBoxVideoStreams.Size = New Size(200, 30)
        UiTextBoxVideoStreams.TabIndex = 96
        UiTextBoxVideoStreams.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxVideoStreams.Watermark = "Multiple streams separated by commas"
        UiTextBoxVideoStreams.WatermarkActiveColor = Color.DimGray
        UiTextBoxVideoStreams.WatermarkColor = Color.DimGray
        ' 
        ' Label101
        ' 
        Label101.Dock = DockStyle.Left
        Label101.Font = New Font("Segoe UI", 9.75F)
        Label101.Location = New Point(0, 0)
        Label101.Name = "Label101"
        Label101.Size = New Size(125, 30)
        Label101.TabIndex = 95
        Label101.Text = "Video Stream Index:"
        Label101.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel4.Controls.Add(UiButtonRemove)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(UiButtonMoveDown)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(UiButtonMoveUp)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(UiButtonAddFile)
        Panel4.Controls.Add(LabelVideo)
        Panel4.Controls.Add(LabelAudio)
        Panel4.Controls.Add(LabelSubtitles)
        Panel4.Controls.Add(LabelChapter)
        Panel4.Controls.Add(LabelMetadata)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(10, 29)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 10, 0, 10)
        Panel4.Size = New Size(1060, 50)
        Panel4.TabIndex = 7
        ' 
        ' UiButtonRemove
        ' 
        UiButtonRemove.AllowDrop = True
        UiButtonRemove.Dock = DockStyle.Left
        UiButtonRemove.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.Font = New Font("Segoe UI", 9.75F)
        UiButtonRemove.ForeColor = Color.IndianRed
        UiButtonRemove.ForeDisableColor = Color.IndianRed
        UiButtonRemove.ForeHoverColor = Color.IndianRed
        UiButtonRemove.ForePressColor = Color.IndianRed
        UiButtonRemove.ForeSelectedColor = Color.IndianRed
        UiButtonRemove.Location = New Point(290, 10)
        UiButtonRemove.MinimumSize = New Size(1, 1)
        UiButtonRemove.Name = "UiButtonRemove"
        UiButtonRemove.Radius = 30
        UiButtonRemove.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.RectHoverColor = Color.IndianRed
        UiButtonRemove.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRemove.RectSelectedColor = Color.IndianRed
        UiButtonRemove.Size = New Size(70, 30)
        UiButtonRemove.TabIndex = 104
        UiButtonRemove.Text = "Remove"
        UiButtonRemove.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Location = New Point(280, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 30)
        Label3.TabIndex = 103
        ' 
        ' UiButtonMoveDown
        ' 
        UiButtonMoveDown.AllowDrop = True
        UiButtonMoveDown.Dock = DockStyle.Left
        UiButtonMoveDown.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveDown.ForeColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeDisableColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeHoverColor = Color.CornflowerBlue
        UiButtonMoveDown.ForePressColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeSelectedColor = Color.CornflowerBlue
        UiButtonMoveDown.Location = New Point(210, 10)
        UiButtonMoveDown.MinimumSize = New Size(1, 1)
        UiButtonMoveDown.Name = "UiButtonMoveDown"
        UiButtonMoveDown.Radius = 30
        UiButtonMoveDown.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.RectHoverColor = Color.CornflowerBlue
        UiButtonMoveDown.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveDown.RectSelectedColor = Color.CornflowerBlue
        UiButtonMoveDown.Size = New Size(70, 30)
        UiButtonMoveDown.TabIndex = 102
        UiButtonMoveDown.Text = "Down"
        UiButtonMoveDown.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label10
        ' 
        Label10.Dock = DockStyle.Left
        Label10.Location = New Point(200, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(10, 30)
        Label10.TabIndex = 101
        ' 
        ' UiButtonMoveUp
        ' 
        UiButtonMoveUp.AllowDrop = True
        UiButtonMoveUp.Dock = DockStyle.Left
        UiButtonMoveUp.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveUp.ForeColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeDisableColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeHoverColor = Color.CornflowerBlue
        UiButtonMoveUp.ForePressColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeSelectedColor = Color.CornflowerBlue
        UiButtonMoveUp.Location = New Point(130, 10)
        UiButtonMoveUp.MinimumSize = New Size(1, 1)
        UiButtonMoveUp.Name = "UiButtonMoveUp"
        UiButtonMoveUp.Radius = 30
        UiButtonMoveUp.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.RectHoverColor = Color.CornflowerBlue
        UiButtonMoveUp.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveUp.RectSelectedColor = Color.CornflowerBlue
        UiButtonMoveUp.Size = New Size(70, 30)
        UiButtonMoveUp.TabIndex = 100
        UiButtonMoveUp.Text = "Up"
        UiButtonMoveUp.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Left
        Label8.Location = New Point(120, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(10, 30)
        Label8.TabIndex = 99
        ' 
        ' UiButtonAddFile
        ' 
        UiButtonAddFile.AllowDrop = True
        UiButtonAddFile.Dock = DockStyle.Left
        UiButtonAddFile.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.Font = New Font("Segoe UI", 9.75F)
        UiButtonAddFile.ForeColor = Color.YellowGreen
        UiButtonAddFile.ForeDisableColor = Color.YellowGreen
        UiButtonAddFile.ForeHoverColor = Color.YellowGreen
        UiButtonAddFile.ForePressColor = Color.YellowGreen
        UiButtonAddFile.ForeSelectedColor = Color.YellowGreen
        UiButtonAddFile.Location = New Point(0, 10)
        UiButtonAddFile.MinimumSize = New Size(1, 1)
        UiButtonAddFile.Name = "UiButtonAddFile"
        UiButtonAddFile.Radius = 30
        UiButtonAddFile.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.RectHoverColor = Color.YellowGreen
        UiButtonAddFile.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddFile.RectSelectedColor = Color.YellowGreen
        UiButtonAddFile.Size = New Size(120, 30)
        UiButtonAddFile.TabIndex = 46
        UiButtonAddFile.Text = "Add File"
        UiButtonAddFile.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' LabelVideo
        ' 
        LabelVideo.Dock = DockStyle.Right
        LabelVideo.Font = New Font("Segoe UI", 10F)
        LabelVideo.Location = New Point(610, 10)
        LabelVideo.Name = "LabelVideo"
        LabelVideo.Size = New Size(75, 30)
        LabelVideo.TabIndex = 1
        LabelVideo.Text = "Video"
        LabelVideo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelAudio
        ' 
        LabelAudio.Dock = DockStyle.Right
        LabelAudio.Font = New Font("Segoe UI", 10F)
        LabelAudio.Location = New Point(685, 10)
        LabelAudio.Name = "LabelAudio"
        LabelAudio.Size = New Size(75, 30)
        LabelAudio.TabIndex = 2
        LabelAudio.Text = "Audio"
        LabelAudio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelSubtitles
        ' 
        LabelSubtitles.Dock = DockStyle.Right
        LabelSubtitles.Font = New Font("Segoe UI", 10F)
        LabelSubtitles.Location = New Point(760, 10)
        LabelSubtitles.Name = "LabelSubtitles"
        LabelSubtitles.Size = New Size(75, 30)
        LabelSubtitles.TabIndex = 5
        LabelSubtitles.Text = "Subtitles"
        LabelSubtitles.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelChapter
        ' 
        LabelChapter.Dock = DockStyle.Right
        LabelChapter.Font = New Font("Segoe UI", 10F)
        LabelChapter.Location = New Point(835, 10)
        LabelChapter.Name = "LabelChapter"
        LabelChapter.Size = New Size(75, 30)
        LabelChapter.TabIndex = 3
        LabelChapter.Text = "Chapter"
        LabelChapter.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelMetadata
        ' 
        LabelMetadata.Dock = DockStyle.Right
        LabelMetadata.Font = New Font("Segoe UI", 10F)
        LabelMetadata.Location = New Point(910, 10)
        LabelMetadata.Name = "LabelMetadata"
        LabelMetadata.Size = New Size(150, 30)
        LabelMetadata.TabIndex = 4
        LabelMetadata.Text = "Metadata"
        LabelMetadata.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(527, 19)
        Label1.TabIndex = 4
        Label1.Text = "Add input files, select to edit streams, use F3/F4 to reorder, Delete to remove."
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Bottom
        Label11.Location = New Point(10, 630)
        Label11.Name = "Label11"
        Label11.Size = New Size(1080, 10)
        Label11.TabIndex = 84
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel5.Controls.Add(UiTextBoxOutputFile)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Label132)
        Panel5.Controls.Add(UiButtonSelectLocation)
        Panel5.Controls.Add(UiButtonStartMuxing)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(10, 640)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(1080, 50)
        Panel5.TabIndex = 85
        ' 
        ' UiTextBoxOutputFile
        ' 
        UiTextBoxOutputFile.Dock = DockStyle.Fill
        UiTextBoxOutputFile.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputFile.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputFile.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxOutputFile.ForeColor = Color.DarkGray
        UiTextBoxOutputFile.ForeDisableColor = Color.DarkGray
        UiTextBoxOutputFile.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxOutputFile.Location = New Point(140, 10)
        UiTextBoxOutputFile.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxOutputFile.MinimumSize = New Size(1, 16)
        UiTextBoxOutputFile.Name = "UiTextBoxOutputFile"
        UiTextBoxOutputFile.Padding = New Padding(5)
        UiTextBoxOutputFile.Radius = 30
        UiTextBoxOutputFile.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputFile.ScrollBarColor = Color.DimGray
        UiTextBoxOutputFile.ScrollBarStyleInherited = False
        UiTextBoxOutputFile.ShowText = False
        UiTextBoxOutputFile.Size = New Size(800, 30)
        UiTextBoxOutputFile.TabIndex = 105
        UiTextBoxOutputFile.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxOutputFile.Watermark = "Output to target location"
        UiTextBoxOutputFile.WatermarkActiveColor = Color.DimGray
        UiTextBoxOutputFile.WatermarkColor = Color.DimGray
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Right
        Label6.Location = New Point(940, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(10, 30)
        Label6.TabIndex = 104
        ' 
        ' Label132
        ' 
        Label132.Dock = DockStyle.Left
        Label132.Location = New Point(130, 10)
        Label132.Name = "Label132"
        Label132.Size = New Size(10, 30)
        Label132.TabIndex = 103
        ' 
        ' UiButtonSelectLocation
        ' 
        UiButtonSelectLocation.AllowDrop = True
        UiButtonSelectLocation.Dock = DockStyle.Left
        UiButtonSelectLocation.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.Font = New Font("Segoe UI", 9.75F)
        UiButtonSelectLocation.ForeColor = Color.YellowGreen
        UiButtonSelectLocation.ForeDisableColor = Color.YellowGreen
        UiButtonSelectLocation.ForeHoverColor = Color.YellowGreen
        UiButtonSelectLocation.ForePressColor = Color.YellowGreen
        UiButtonSelectLocation.ForeSelectedColor = Color.YellowGreen
        UiButtonSelectLocation.Location = New Point(10, 10)
        UiButtonSelectLocation.MinimumSize = New Size(1, 1)
        UiButtonSelectLocation.Name = "UiButtonSelectLocation"
        UiButtonSelectLocation.Radius = 30
        UiButtonSelectLocation.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.RectHoverColor = Color.YellowGreen
        UiButtonSelectLocation.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonSelectLocation.RectSelectedColor = Color.YellowGreen
        UiButtonSelectLocation.Size = New Size(120, 30)
        UiButtonSelectLocation.TabIndex = 102
        UiButtonSelectLocation.Text = "Select Location"
        UiButtonSelectLocation.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonStartMuxing
        ' 
        UiButtonStartMuxing.AllowDrop = True
        UiButtonStartMuxing.Dock = DockStyle.Right
        UiButtonStartMuxing.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.Font = New Font("Segoe UI", 9.75F)
        UiButtonStartMuxing.ForeColor = Color.YellowGreen
        UiButtonStartMuxing.ForeDisableColor = Color.YellowGreen
        UiButtonStartMuxing.ForeHoverColor = Color.YellowGreen
        UiButtonStartMuxing.ForePressColor = Color.YellowGreen
        UiButtonStartMuxing.ForeSelectedColor = Color.YellowGreen
        UiButtonStartMuxing.Location = New Point(950, 10)
        UiButtonStartMuxing.MinimumSize = New Size(1, 1)
        UiButtonStartMuxing.Name = "UiButtonStartMuxing"
        UiButtonStartMuxing.Radius = 30
        UiButtonStartMuxing.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMuxing.RectHoverColor = Color.YellowGreen
        UiButtonStartMuxing.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonStartMuxing.RectSelectedColor = Color.YellowGreen
        UiButtonStartMuxing.Size = New Size(120, 30)
        UiButtonStartMuxing.TabIndex = 101
        UiButtonStartMuxing.Text = "Start Muxing"
        UiButtonStartMuxing.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' MuxingPage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel1)
        Controls.Add(Label11)
        Controls.Add(Label20)
        Controls.Add(Panel73)
        Controls.Add(Panel5)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Silver
        Name = "MuxingPage"
        Padding = New Padding(10, 0, 10, 10)
        Size = New Size(1100, 700)
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel62.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel73 As Panel
    Friend WithEvents Label123 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelMetadata As Label
    Friend WithEvents LabelChapter As Label
    Friend WithEvents LabelAudio As Label
    Friend WithEvents LabelVideo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel62 As Panel
    Friend WithEvents UiTextBoxVideoStreams As Sunny.UI.UITextBox
    Friend WithEvents Label101 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents UiCheckBoxUseChapters As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBoxUseMetadata As Sunny.UI.UICheckBox
    Friend WithEvents LabelSubtitles As Label
    Friend WithEvents UiTextBoxSubtitleStreams As Sunny.UI.UITextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents UiTextBoxAudioStreams As Sunny.UI.UITextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents UiButtonAddFile As Sunny.UI.UIButton
    Friend WithEvents UiButtonMoveDown As Sunny.UI.UIButton
    Friend WithEvents Label10 As Label
    Friend WithEvents UiButtonMoveUp As Sunny.UI.UIButton
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents UiButtonRemove As Sunny.UI.UIButton
    Friend WithEvents Label3 As Label
    Friend WithEvents UiTextBoxOutputFile As Sunny.UI.UITextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents UiButtonSelectLocation As Sunny.UI.UIButton
    Friend WithEvents UiButtonStartMuxing As Sunny.UI.UIButton

End Class








