Imports System.Text.RegularExpressions
Imports Sunny.UI

Public Class FormMediaStreamSelector
    Public Sub New(Optional mediaFileToRead As String = "",
                    Optional videoStreamTargetObject As Object = Nothing,
                    Optional audioStreamTargetObject As Object = Nothing,
                    Optional subtitleStreamTargetObject As Object = Nothing,
                    Optional fileIndex As String = "",
                    Optional videoStreamsSelected As String = "",
                    Optional audioStreamsSelected As String = "",
                    Optional subtitleStreamsSelected As String = ""
                    )
        InitializeComponent()
        Me.Setting_MediaFileToRead = mediaFileToRead
        Me.Setting_VideoStreamTargetObject = videoStreamTargetObject
        Me.Setting_AudioStreamTargetObject = audioStreamTargetObject
        Me.Setting_SubtitleStreamTargetObject = subtitleStreamTargetObject
        Me.Setting_FileIndex = fileIndex

        Dim trailingDigitsRegex As New Regex("\d+$", RegexOptions.Compiled)

        Dim vlist As New List(Of String)(videoStreamsSelected.ToLower.Trim.Replace($"{fileIndex}:v:", "").Split(","c))
        Dim alist As New List(Of String)(audioStreamsSelected.ToLower.Trim.Replace($"{fileIndex}:a:", "").Split(","c))
        Dim slist As New List(Of String)(subtitleStreamsSelected.ToLower.Trim.Replace($"{fileIndex}:s:", "").Split(","c))

        If vlist.Contains("0:v") Then
            Me.Setting_IsAllVideoStreamsSelected = True
        Else
            For Each i In vlist
                If String.IsNullOrWhiteSpace(i) Then Continue For
                Dim m = trailingDigitsRegex.Match(i)
                If Not m.Success Then Continue For
                Dim n As Integer
                If Integer.TryParse(m.Value, n) Then Me.Setting_VideoStreamsSelected.Add(n)
            Next
        End If
        If alist.Contains("0:a") Then
            Me.Setting_IsAllAudioStreamsSelected = True
        Else
            For Each i In alist
                If String.IsNullOrWhiteSpace(i) Then Continue For
                Dim m = trailingDigitsRegex.Match(i)
                If Not m.Success Then Continue For
                Dim n As Integer
                If Integer.TryParse(m.Value, n) Then Me.Setting_AudioStreamsSelected.Add(n)
            Next
        End If
        If slist.Contains("0:s") Then
            Me.Setting_IsAllSubtitleStreamsSelected = True
        Else
            For Each i In slist
                If String.IsNullOrWhiteSpace(i) Then Continue For
                Dim m = trailingDigitsRegex.Match(i)
                If Not m.Success Then Continue For
                Dim n As Integer
                If Integer.TryParse(m.Value, n) Then Me.Setting_SubtitleStreamsSelected.Add(n)
            Next
        End If
    End Sub
    Enum Scenario
        GeneralParametersPage = 1
        SimpleMuxingPage = 2
    End Enum

    Private Setting_MediaFileToRead As String = ""
    Private Setting_VideoStreamTargetObject As Object
    Private Setting_AudioStreamTargetObject As Object
    Private Setting_SubtitleStreamTargetObject As Object
    Private Setting_FileIndex As String = ""
    Private Setting_VideoStreamsSelected As New List(Of Integer)
    Private Setting_AudioStreamsSelected As New List(Of Integer)
    Private Setting_SubtitleStreamsSelected As New List(Of Integer)

    Private Setting_IsAllVideoStreamsSelected As Boolean = False
    Private Setting_IsAllAudioStreamsSelected As Boolean = False
    Private Setting_IsAllSubtitleStreamsSelected As Boolean = False

    Private VideoStreamCheckBoxList As New List(Of UICheckBox)
    Private AudioStreamCheckBoxList As New List(Of UICheckBox)
    Private SubtitleStreamCheckBoxList As New List(Of UICheckBox)

    Sub ResetUI()
        Me.Panel2.Controls.Clear()
        VideoStreamCheckBoxList.Clear()
        AudioStreamCheckBoxList.Clear()
        SubtitleStreamCheckBoxList.Clear()
    End Sub

    Private Sub FormMediaStreamSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlFont(UserSettings.Instance.Font, Me,, True)
    End Sub
    Private Sub FormMediaStreamSelector_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If FileIO.FileSystem.FileExists(Setting_MediaFileToRead) Then StartReading(Setting_MediaFileToRead)
    End Sub
    Private Sub FormMediaStreamSelector_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Sub StartReading(mediaFile As String)
        Dim outputContent As New List(Of String)
        Dim ffprobeProcess As New Process
        ffprobeProcess.StartInfo.FileName = "ffprobe"
        ffprobeProcess.StartInfo.WorkingDirectory = If(UserSettings.Instance.WorkingDirectory <> "", UserSettings.Instance.WorkingDirectory, "")
        ffprobeProcess.StartInfo.Arguments = $"-hide_banner ""{mediaFile}"""
        ffprobeProcess.StartInfo.RedirectStandardOutput = True
        ffprobeProcess.StartInfo.RedirectStandardError = True
        ffprobeProcess.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8
        ffprobeProcess.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8
        ffprobeProcess.StartInfo.CreateNoWindow = True
        ffprobeProcess.EnableRaisingEvents = True
        AddHandler ffprobeProcess.OutputDataReceived, Sub(sender, e)
                                                          If e.Data Is Nothing Then Exit Sub
                                                          outputContent.Add(e.Data)
                                                      End Sub
        AddHandler ffprobeProcess.ErrorDataReceived, Sub(sender, e)
                                                         If e.Data Is Nothing Then Exit Sub
                                                         outputContent.Add(e.Data)
                                                     End Sub
        ffprobeProcess.Start()
        ffprobeProcess.BeginOutputReadLine()
        ffprobeProcess.BeginErrorReadLine()

        ffprobeProcess.WaitForExit()
        ffprobeProcess.Dispose()
        ResetUI()

        If outputContent.Count = 0 Then
            Me.Panel2.Controls.Add(New Label With {.Text = "ffprobe did not output any information", .AutoSize = True, .Dock = DockStyle.Top, .ForeColor = Color.IndianRed})
            Exit Sub
        End If
        Dim mediaInfo As MediaInfoParser.MediaInformation = MediaInfoParser.Parse(outputContent)

        For i = 0 To mediaInfo.VideoStreams.Count - 1
            Dim cb As New UICheckBox With {
                    .Text = $"Video [{i}]",
                    .BackColor = Panel2.BackColor,
                    .ForeColor = Panel2.ForeColor,
                    .Font = New Font(UserSettings.Instance.Font, 10),
                    .CheckBoxSize = 20 * Form1.DPI,
                    .Dock = DockStyle.Top,
                    .Height = 30 * Form1.DPI,
                    .AutoSize = False,
                    .Tag = i
                }
            If mediaInfo.VideoStreams(i).Language <> "" Then cb.Text &= $" [{mediaInfo.VideoStreams(i).Language}]"
            cb.Text &= $" {mediaInfo.VideoStreams(i).Encoder}"
            If mediaInfo.VideoStreams(i).Resolution <> "" Then cb.Text &= $" | {mediaInfo.VideoStreams(i).Resolution}"
            If mediaInfo.VideoStreams(i).FrameRate <> "" Then cb.Text &= $" | {mediaInfo.VideoStreams(i).FrameRate}"
            If mediaInfo.VideoStreams(i).Bitrate <> "" Then cb.Text &= $" | {mediaInfo.VideoStreams(i).Bitrate}"
            If Setting_VideoStreamsSelected.Contains(i) Then cb.Checked = True
            If Setting_IsAllVideoStreamsSelected Then cb.Checked = True
            Me.Panel2.Controls.Add(cb)
            cb.BringToFront()
            VideoStreamCheckBoxList.Add(cb)

            If mediaInfo.VideoStreams(i).PixelFormat <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.VideoStreams(i).PixelFormat}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.CornflowerBlue, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
            If mediaInfo.VideoStreams(i).EncoderLib <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.VideoStreams(i).EncoderLib}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
            If mediaInfo.VideoStreams(i).MetadataTitle <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.VideoStreams(i).MetadataTitle}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
        Next

        For i = 0 To mediaInfo.AudioStreams.Count - 1
            Dim cb As New UICheckBox With {
                    .Text = $"Audio [{i}]",
                    .BackColor = Panel2.BackColor,
                    .ForeColor = Panel2.ForeColor,
                    .Font = New Font(UserSettings.Instance.Font, 10),
                    .CheckBoxSize = 20 * Form1.DPI,
                    .Dock = DockStyle.Top,
                    .Height = 30 * Form1.DPI,
                    .AutoSize = False,
                    .CheckBoxColor = Color.OliveDrab,
                    .Tag = i
                }
            If mediaInfo.AudioStreams(i).Language <> "" Then cb.Text &= $" [{mediaInfo.AudioStreams(i).Language}]"
            cb.Text &= $" {mediaInfo.AudioStreams(i).Encoder}"
            If mediaInfo.AudioStreams(i).ChannelLayout <> "" Then cb.Text &= $" | {mediaInfo.AudioStreams(i).ChannelLayout}"
            If mediaInfo.AudioStreams(i).SampleRate <> "" Then cb.Text &= $" | {mediaInfo.AudioStreams(i).SampleRate}"
            If mediaInfo.AudioStreams(i).Bitrate <> "" Then cb.Text &= $" | {mediaInfo.AudioStreams(i).Bitrate}"
            If Setting_AudioStreamsSelected.Contains(i) Then cb.Checked = True
            If Setting_IsAllAudioStreamsSelected Then cb.Checked = True
            Me.Panel2.Controls.Add(cb)
            cb.BringToFront()
            AudioStreamCheckBoxList.Add(cb)
            If mediaInfo.AudioStreams(i).EncoderLib <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.AudioStreams(i).EncoderLib}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
            If mediaInfo.AudioStreams(i).MetadataTitle <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.AudioStreams(i).MetadataTitle}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
        Next

        For i = 0 To mediaInfo.SubtitleStreams.Count - 1
            Dim cb As New UICheckBox With {
                    .Text = $"Subtitle [{i}]",
                    .BackColor = Panel2.BackColor,
                    .ForeColor = Panel2.ForeColor,
                    .Font = New Font(UserSettings.Instance.Font, 10),
                    .CheckBoxSize = 20 * Form1.DPI,
                    .Dock = DockStyle.Top,
                    .Height = 30 * Form1.DPI,
                    .AutoSize = False,
                    .CheckBoxColor = Color.MediumPurple,
                    .Tag = i
                }
            If mediaInfo.SubtitleStreams(i).Language <> "" Then cb.Text &= $" [{mediaInfo.SubtitleStreams(i).Language}]"
            cb.Text &= $" {mediaInfo.SubtitleStreams(i).Encoder}"
            If Setting_SubtitleStreamsSelected.Contains(i) Then cb.Checked = True
            If Setting_IsAllSubtitleStreamsSelected Then cb.Checked = True
            Me.Panel2.Controls.Add(cb)
            cb.BringToFront()
            SubtitleStreamCheckBoxList.Add(cb)
            If mediaInfo.SubtitleStreams(i).EncoderLib <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.SubtitleStreams(i).EncoderLib}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
            If mediaInfo.SubtitleStreams(i).MetadataTitle <> "" Then
                Dim L1 As New Label With {.Text = $"{mediaInfo.SubtitleStreams(i).MetadataTitle}", .AutoSize = True, .Padding = New Padding(26 * Form1.DPI, 0, 0, 5 * Form1.DPI), .ForeColor = Color.DimGray, .Font = New Font(UserSettings.Instance.Font, 10), .Dock = DockStyle.Top}
                Me.Panel2.Controls.Add(L1)
                L1.BringToFront()
            End If
        Next
    End Sub

    Private Sub Panel2_DragEnter(sender As Object, e As DragEventArgs) Handles Panel2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Panel2_DragDrop(sender As Object, e As DragEventArgs) Handles Panel2.DragDrop
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        If files.Length > 0 Then
            StartReading(files(0))
        End If
    End Sub

    Private Sub UiButtonOpen_Click(sender As Object, e As EventArgs) Handles UiButtonOpen.Click
        Dim a As New OpenFileDialog With {.Multiselect = False}
        If a.ShowDialog = DialogResult.OK Then
            StartReading(a.FileName)
        End If
    End Sub

    Private Sub UiButtonReset_Click(sender As Object, e As EventArgs) Handles UiButtonReset.Click
        For Each cb As UICheckBox In VideoStreamCheckBoxList
            cb.Checked = False
        Next
        For Each cb As UICheckBox In AudioStreamCheckBoxList
            cb.Checked = False
        Next
        For Each cb As UICheckBox In SubtitleStreamCheckBoxList
            cb.Checked = False
        Next
    End Sub

    Private Sub UiButtonConfirm_Click(sender As Object, e As EventArgs) Handles UiButtonConfirm.Click
        Dim vlist As New List(Of String)
        For Each cb As UICheckBox In VideoStreamCheckBoxList
            If Not cb.Checked Then Continue For
            vlist.Add(If(Setting_FileIndex <> "", $"{Setting_FileIndex}:v:", "") & cb.Tag)
        Next
        If Setting_VideoStreamTargetObject IsNot Nothing Then Setting_VideoStreamTargetObject.Text = String.Join(",", vlist)
        Dim alist As New List(Of String)
        For Each cb As UICheckBox In AudioStreamCheckBoxList
            If Not cb.Checked Then Continue For
            alist.Add(If(Setting_FileIndex <> "", $"{Setting_FileIndex}:a:", "") & cb.Tag)
        Next
        If Setting_AudioStreamTargetObject IsNot Nothing Then Setting_AudioStreamTargetObject.Text = String.Join(",", alist)
        Dim slist As New List(Of String)
        For Each cb As UICheckBox In SubtitleStreamCheckBoxList
            If Not cb.Checked Then Continue For
            slist.Add(If(Setting_FileIndex <> "", $"{Setting_FileIndex}:s:", "") & cb.Tag)
        Next
        If Setting_SubtitleStreamTargetObject IsNot Nothing Then Setting_SubtitleStreamTargetObject.Text = String.Join(",", slist)
        Me.Close()
    End Sub

End Class


