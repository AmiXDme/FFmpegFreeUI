Imports System.IO
Imports Sunny.UI

Public Class Form1
    Public Shared Property DPI As Single = Form1.CreateGraphics.DpiX / 96

    Public IsInitialized As Boolean = False
    Private LastWindowState As FormWindowState

    Public StartPage As New StartPage With {.Dock = DockStyle.Fill}
    Public PrepareFilesPage As New PrepareFilesPage With {.Dock = DockStyle.Fill}
    Public GeneralParametersPage As New GeneralParametersPage With {.Dock = DockStyle.Fill}
    Public MediaInfoPage As New MediaInfoPage With {.Dock = DockStyle.Fill}
    Public PlayerPage As New PlayerPage With {.Dock = DockStyle.Fill}
    Public MuxingPage As New MuxingPage With {.Dock = DockStyle.Fill}
    Public MergingPage As New MergingPage With {.Dock = DockStyle.Fill}
    Public SettingsPage As New SettingsPage With {.Dock = DockStyle.Fill}
    Public PerformancePage As New PerformancePage With {.Dock = DockStyle.Fill}
    Public SupportersPage As New SupportersPage With {.Dock = DockStyle.Fill}

    Public PerformanceStatsObject As New PerformanceStats
    Public PerformanceStatsRefreshTimer As New Timer With {.Interval = 2000, .Enabled = False}

    Public SelectedItemRefreshInfoTimer As New Timer With {.Interval = 1500, .Enabled = False}
    Public TaskProgressUpdateTimer As New Timer With {.Interval = 1000, .Enabled = False}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableWin32APIDarkMode(Me.Handle)

        If Not FileIO.FileSystem.DirectoryExists(Path.Combine(Application.StartupPath, "Preset")) Then
            FileIO.FileSystem.CreateDirectory(Path.Combine(Application.StartupPath, "Preset"))
        End If
        'If Not FileIO.FileSystem.DirectoryExists(Path.Combine(Application.StartupPath, "Plugin")) Then
        '    FileIO.FileSystem.CreateDirectory(Path.Combine(Application.StartupPath, "Plugin"))
        'End If

        Dim versionNumber = String.Join(".", Application.ProductVersion.Split("."c).Take(3)).Split("+"c)(0)
        Me.Text = $"FFmpegFreeUI {versionNumber}"
        StartPage.LabelMainTitle.Text = $"FFmpegFreeUI 2026 Spring Festival Special Update {versionNumber}"

        VideoEncoderDatabase.Initialize()
        UIControl.Initialize()
        UserSettings.LoadSettingsOnStartup()
        PluginManager.ReadPersonalizationUnlockerOnStartup()
        UIControl.CalibrateUI()
        EncodingTask.Initialize()
        If DPI <> 1 Then CalibrateUIOnDPIChange()

        LastWindowState = Me.WindowState
    End Sub

    Private Sub Form1_DpiChanged(sender As Object, e As DpiChangedEventArgs) Handles Me.DpiChanged
        DPI = e.DeviceDpiNew / 96
        CalibrateUIOnDPIChange()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.PanelTopVisualCorrectionArea_Level1.Width = Me.UiTabControlMenu1.ItemSize.Width + 1
        StartPage.AdjustUI()

        'Bro, you know Schrodinger's cat, right? Without monitoring this thing is in a random state
        If UISynchronizationContext Is Nothing Then MsgBox("Warning: UI synchronization context is null, continuing to use the software will cause a crash, please contact the developer to investigate the problem", MsgBoxStyle.Critical)

        TaskProgressUpdateTimer.Enabled = True
        ExecuteOnUIThread(AddressOf PluginManager.LoadPluginsOnStartup)
        ExecuteOnUIThread(AddressOf CheckUpdate.Check)
        NewsList.GetNews()
        UserStatistics.ReportActive()
        CollectSelfMemoryUsage()
        If UserSettings.Instance.ListenPort Then PortListening.StartClient()
    End Sub

    Public Sub RecreateWindowHandle()
        Try
            If Not Me.IsHandleCreated Then Me.CreateHandle()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If IsInitialized = False Then Exit Sub
        If Me.WindowState = FormWindowState.Minimized Then Exit Sub
        If Me.WindowState <> LastWindowState Then
            UIControl.CalibrateUI()
            LastWindowState = Me.WindowState
        Else
            UIControl.CalibrateUI()
        End If
    End Sub

    Sub CalibrateUIOnDPIChange()
        Me.MinimumSize = New Size(0, 0)
        Me.Size = New Size(1200 * DPI, 700 * DPI)
        Me.MinimumSize = New Size(1200 * DPI, 700 * DPI)
        Me.UiTabControlMenu1.ItemSize = New Size(150 * DPI, 38 * DPI)
        Me.ImageList1.ImageSize = New Size(1, 30 * DPI)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If EncodingTask.Queue.Any(Function(task) task.Status = EncodingTask.TaskStatus.Processing) Then
            Dim result = MsgBox("There are tasks being processed, do you want to force close all processes?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        For Each task In EncodingTask.Queue
            task.Cleanup()
        Next
        RestoreSystemState()
        UserSettings.SaveSettingsOnExit()
        PlayerPage.StopPlayback()
        e.Cancel = False
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Select Case e.KeyState
            Case 4, 8, 32
                If files.Length > 0 Then
                    Dim a As New FormIndependentParameterPanel With {.FileList = files}
                    a.Label1.Text = $"For {files.Length} Files Use Independent Parameter Presets{vbCrLf}{files(0)}"
                    ShowForm(a, Me)
                End If
            Case Else
                If files.Length > 0 Then
                    UIControl_AddFile.AddToEncodingQueue(files, GeneralParametersPage)
                End If
        End Select
    End Sub
    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : UIControl_EncodingQueue.StartTask()
            Case Keys.Space : UIControl_EncodingQueue.PauseTask()
            Case Keys.A
                If e.Control Then UIControl_EncodingQueue.SelectAllTasks()
                If e.Alt Then UIControl_EncodingQueue.InvertTaskSelection()
            Case Keys.Delete : UIControl_EncodingQueue.RemoveTask()
            Case Keys.Escape : UIControl_EncodingQueue.ResetTask()
            Case Keys.End : UIControl_EncodingQueue.StopTask()
            Case Keys.PageUp : UIControl_EncodingQueue.MoveUpTask()
            Case Keys.PageDown : UIControl_EncodingQueue.MoveDownTask()
        End Select
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count = 1 Then
            LinkLabelSendToFFmpeg.Visible = True
            LinkLabelSwitchOutput.Visible = True
            LabelFFmpegRealTimeInfo.Visible = True
            Label1.Visible = False
            LabelFFmpegRealTimeInfo.BringToFront()
            LinkLabelSendToFFmpeg.SendToBack()
            If IsOutputPanelOpened Then PanelOutputPanel.Visible = True
            UIControl.CalibrateOutputPanelWidth()
            EncodingTask.RefreshSelectedItemInfo()
            SelectedItemRefreshInfoTimer.Enabled = True
        Else
            SelectedItemRefreshInfoTimer.Enabled = False
            Label1.Visible = True
            LinkLabelSendToFFmpeg.Visible = False
            LinkLabelSwitchOutput.Visible = False
            LabelFFmpegRealTimeInfo.Visible = False
            PanelOutputPanel.Visible = False
        End If
    End Sub

    Public IsOutputPanelOpened As Boolean = False

    Private Sub UiComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiComboBox3.SelectedIndexChanged
        For Each C As Control In Panel24.Controls
            Panel24.Controls.Remove(C)
        Next
        If Me.UiComboBox3.Text = "" Then Exit Sub
        If Me.UiComboBox3.SelectedIndex < 0 Then Exit Sub
        Panel24.Controls.Add(PluginManager.CustomInterfaceLoadedByPlugin(Me.UiComboBox3.Text))
        PluginManager.CustomInterfaceLoadedByPlugin(Me.UiComboBox3.Text).Dock = DockStyle.Fill
        SetControlFont(UserSettings.Instance.Font, Panel24)
    End Sub

    Public Shared Sub LoadCustomTaskCompleteSound(file As String)
        If FileIO.FileSystem.FileExists(file) Then
            Try
                Using fileStream As New FileStream(file, FileMode.Open, FileAccess.Read)
                    Dim soundStream As New MemoryStream()
                    fileStream.CopyTo(soundStream)
                    soundStream.Position = 0
                    Sound_SuccessSound = soundStream
                End Using
            Catch ex As Exception
                Sound_SuccessSound = My.Resources.Resource1.Success
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Public Shared Sub LoadCustomTaskFailedSound(file As String)
        If FileIO.FileSystem.FileExists(file) Then
            Try
                Using fileStream As New FileStream(file, FileMode.Open, FileAccess.Read)
                    Dim soundStream As New MemoryStream()
                    fileStream.CopyTo(soundStream)
                    soundStream.Position = 0
                    Sound_ErrorSound = soundStream
                End Using
            Catch ex As Exception
                Sound_ErrorSound = My.Resources.Resource1.Error
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Public Sub LoadCustomIcon(img As String)
        Try
            StartPage.PictureBox1.Width = StartPage.PictureBox1.Height
            If FileIO.FileSystem.FileExists(img) AndAlso img IsNot Nothing AndAlso img <> "" Then
                StartPage.PictureBox1.Image = LoadImageFromFile(img).GetThumbnailImage(StartPage.PictureBox1.Width, StartPage.PictureBox1.Height, Nothing, Nothing)
                Using bitmap As New Bitmap(StartPage.PictureBox1.Image)
                    Me.Icon = Icon.FromHandle(bitmap.GetHicon())
                End Using
            Else
                StartPage.PictureBox1.Image = My.Resources.Resource1.AppIcon.GetThumbnailImage(StartPage.PictureBox1.Width, StartPage.PictureBox1.Height, Nothing, Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class





















