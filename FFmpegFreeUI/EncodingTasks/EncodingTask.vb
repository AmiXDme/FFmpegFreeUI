Imports System.IO
Imports System.Text.RegularExpressions
Imports Sunny.UI

Public Class EncodingTask

    Public Shared Sub Initialize()
        AddHandler CheckAndStartNewTaskTimer.Tick, AddressOf CheckAndStartNewTaskTimer_Process
    End Sub

    Public Shared Property ErrorOutputMatchingStringList As New List(Of String) From {"Error", "Invalid", "cannot", "failed", "not supported", "require", "must be", "Could not", "is experimental", "if you want to use it", "Nothing was written"}

    Enum TaskStatus
        Pending = 0
        Processing = 1
        Paused = 2
        Completed = 10
        Stopped = 20
        [Error] = 99
    End Enum

    Public Shared Property Queue As New List(Of SingleTask)

    Public Shared Property CheckAndStartNewTaskTimer As New Timer With {.Interval = 100, .Enabled = False}
    Public Shared Sub CheckAndStartNewTaskTimer_Process()
        If UserSettings.Instance.AutoStartTaskOption <> 0 Then Exit Sub
        Dim currentRunningTasksCount As Integer = Queue.Where(Function(item) item.Status = TaskStatus.Processing).Count()

        If currentRunningTasksCount >= MaxConcurrentTasksLimit Then CheckAndStartNewTaskTimer.Enabled = False : Exit Sub
        For Each item As SingleTask In Queue
            If item.Status = TaskStatus.Pending Then
                Task.Run(AddressOf item.Start)
                currentRunningTasksCount += 1
                If currentRunningTasksCount >= MaxConcurrentTasksLimit Then CheckAndStartNewTaskTimer.Enabled = False : Exit Sub
            End If
        Next

        If currentRunningTasksCount = 0 Then
            If ErrorOccurredInCompletedTasks Then
                If UserSettings.Instance.SoundAlertOption = 0 Then
                    Sound_ErrorSound.Position = 0
                    My.Computer.Audio.Play(Sound_ErrorSound, AudioPlayMode.Background)
                End If
                ErrorOccurredInCompletedTasks = False
            Else
                If UserSettings.Instance.SoundAlertOption = 0 Then
                    Sound_SuccessSound.Position = 0
                    My.Computer.Audio.Play(Sound_SuccessSound, AudioPlayMode.Background)
                End If
            End If
        End If

        CheckAndStartNewTaskTimer.Enabled = False
    End Sub

    Public Shared Property ErrorOccurredInCompletedTasks As Boolean = False

    Public Shared Property ItemsToRefresh As New Dictionary(Of ListViewItem, UIDisplayDataStructure)
    Public Shared Property ItemsToRefreshBackup As Dictionary(Of ListViewItem, UIDisplayDataStructure)
    Public Class UIDisplayDataStructure
        Public Property Progress As String = ""
        Public Property Efficiency As String = ""
        Public Property OutputSize As String = ""
        Public Property Quality As String = ""
        Public Property Bitrate As String = ""
        Public Property Time As String = ""
    End Class
    Public Shared Sub RefreshUIWithTimer()
        If Queue.Count = 0 Then Exit Sub
        If ItemsToRefresh.Count = 0 Then Exit Sub
        SyncLock ItemsToRefresh
            ItemsToRefreshBackup = New Dictionary(Of ListViewItem, UIDisplayDataStructure)(ItemsToRefresh)
            ItemsToRefresh.Clear()
        End SyncLock
        For Each item As ListViewItem In ItemsToRefreshBackup.Keys
            item.SubItems(2).Text = ItemsToRefreshBackup(item).Progress
            item.SubItems(3).Text = ItemsToRefreshBackup(item).Efficiency
            item.SubItems(4).Text = ItemsToRefreshBackup(item).OutputSize
            item.SubItems(5).Text = ItemsToRefreshBackup(item).Quality
            item.SubItems(6).Text = ItemsToRefreshBackup(item).Bitrate
            item.SubItems(7).Text = ItemsToRefreshBackup(item).Time
        Next
    End Sub

    Public Class SingleTask
        Public Property PresetData As PresetDataType
        Public Property InputFile As String = ""
        Public Property InputFileSize As Long = 0
        Public Property OutputFile As String = ""
        Public Property CustomOutputDirectory As String = ""
        Public Property CommandLine As String = ""
        Public Property TotalDuration As TimeSpan = TimeSpan.Zero
        Public Property IsTotalDurationObtained As Boolean = False
        Public Property RealTime_Frame As String = ""
        Public Property RealTime_Fps As String = ""
        Public Property RealTime_Q As String = ""
        Public Property RealTime_Size As String = ""
        Public Property RealTime_Size_Num As Long = 0
        Public Property RealTime_Time As TimeSpan = TimeSpan.Zero
        Public Property RealTime_Bitrate As String = ""
        Public Property RealTime_Speed As String = ""
        Public Property Status As TaskStatus = TaskStatus.Pending

        Public Property ListViewItem As ListViewItem = Nothing

        Public Property RealTimeOutput As String = ""
        Public Property ErrorList As New List(Of String)
        Public Property NonProgressOutputList As New List(Of String)
        Public Property ManuallyStoppedDoNotStartOthers As Boolean = False
        Public Property FFmpegProcess As Process
        Public Property TaskStopwatch As New Stopwatch
        Public Property LastUIRefreshTimestamp As TimeSpan = Now.TimeOfDay

        Public Property AviSynthCachePath As String = ""
        Public Property VapourSynthCachePath As String = ""


        Public Sub Start()
            Status = TaskStatus.Processing
            Try
                ErrorList.Clear()
                NonProgressOutputList.Clear()
                If PresetData Is Nothing Then GoTo SkipPresetLogic

                If PresetData.VideoParam_VideoFrameServer_UseAviSynth Then
                    If FileIO.FileSystem.FileExists(PresetData.VideoParam_VideoFrameServer_AvsScriptFile) Then
                        Dim avs1 As String = File.ReadAllText(PresetData.VideoParam_VideoFrameServer_AvsScriptFile)
                        avs1 = avs1.Replace("<FilePath>", InputFile)
                        AviSynthCachePath = Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile) & ".avs")
                        File.WriteAllText(AviSynthCachePath, avs1, New Text.UTF8Encoding(False))
                    Else
                        Throw New FileNotFoundException("AviSynth script template file does not exist!")
                    End If
                End If
                If PresetData.VideoParam_VideoFrameServer_UseVapourSynth Then
                    If FileIO.FileSystem.FileExists(PresetData.VideoParam_VideoFrameServer_VpyScriptFile) Then
                        Dim vpy1 As String = File.ReadAllText(PresetData.VideoParam_VideoFrameServer_VpyScriptFile)
                        vpy1 = vpy1.Replace("<FilePath>", InputFile)
                        VapourSynthCachePath = Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile) & Path.GetExtension(PresetData.VideoParam_VideoFrameServer_VpyScriptFile))
                        File.WriteAllText(VapourSynthCachePath, vpy1, New Text.UTF8Encoding(False))
                    Else
                        Throw New FileNotFoundException("VapourSynth script template file does not exist!")
                    End If
                End If

                OutputFile = CalculateOutputPosition(InputFile, PresetData.OutputContainer, PresetData, CustomOutputDirectory)
                CommandLine = PresetManager.ConvertPresetToCommandLine(PresetData, InputFile, OutputFile)

                If PresetData.ClipRange_InPoint <> "" AndAlso PresetData.ClipRange_OutPoint <> "" Then
                    Dim t1 = ConvertTimeStringToTimeSpan(PresetData.ClipRange_InPoint)
                    Dim t2 = ConvertTimeStringToTimeSpan(PresetData.ClipRange_OutPoint)
                    TotalDuration = t2 - t1
                    IsTotalDurationObtained = True
                    GoTo EndClipRangeCalculation
                End If
                If PresetData.ClipRange_InPoint = "" AndAlso PresetData.ClipRange_OutPoint <> "" Then
                    TotalDuration = ConvertTimeStringToTimeSpan(PresetData.ClipRange_OutPoint)
                    IsTotalDurationObtained = True
                    GoTo EndClipRangeCalculation
                End If

EndClipRangeCalculation:
SkipPresetLogic:
                If FileIO.FileSystem.FileExists(InputFile) Then
                    Try
                        InputFileSize = FileIO.FileSystem.GetFileInfo(InputFile).Length
                    Catch ex As Exception
                    End Try
                End If

                FFmpegProcess = New Process()
                FFmpegProcess.StartInfo.FileName = If(UserSettings.Instance.AlternativeProcessFileName <> "", UserSettings.Instance.AlternativeProcessFileName, "ffmpeg")
                FFmpegProcess.StartInfo.WorkingDirectory = If(UserSettings.Instance.WorkingDirectory <> "", UserSettings.Instance.WorkingDirectory, "")
                FFmpegProcess.StartInfo.Arguments = If(UserSettings.Instance.OverrideParameterPassing <> "", UserSettings.Instance.OverrideParameterPassing.Replace("<args>", CommandLine), CommandLine)
                FFmpegProcess.StartInfo.UseShellExecute = False
                FFmpegProcess.StartInfo.RedirectStandardOutput = True
                FFmpegProcess.StartInfo.RedirectStandardError = True
                FFmpegProcess.StartInfo.StandardOutputEncoding = Text.Encoding.UTF8
                FFmpegProcess.StartInfo.StandardErrorEncoding = Text.Encoding.UTF8
                FFmpegProcess.StartInfo.RedirectStandardInput = True
                FFmpegProcess.StartInfo.StandardInputEncoding = Text.Encoding.UTF8
                FFmpegProcess.StartInfo.CreateNoWindow = True
                FFmpegProcess.EnableRaisingEvents = True
                AddHandler FFmpegProcess.OutputDataReceived, AddressOf FFmpegOutputHandler
                AddHandler FFmpegProcess.ErrorDataReceived, AddressOf FFmpegOutputHandler
                AddHandler FFmpegProcess.Exited, AddressOf FFmpegProcessExited

                FFmpegProcess.Start()
                FFmpegProcess.BeginOutputReadLine()
                FFmpegProcess.BeginErrorReadLine()

                If UserSettings.Instance.SpecifyProcessorCores <> "" Then FFmpegProcess.ProcessorAffinity = GetAffinityMask(UserSettings.Instance.SpecifyProcessorCores.Split(","c).Select(Function(s) s.Trim()).Where(Function(s) Integer.TryParse(s, Nothing)).Select(Function(s) Integer.Parse(s)).ToArray())

                SetSystemState()
                TaskStopwatch.Start()

            Catch ex As Exception
                RealTimeOutput = $"[3FUI] {ex.Message}"
                ErrorList.Add($"[3FUI] {ex.Message}")
            End Try
        End Sub

        Public Sub Pause()
            Try
                If Status = TaskStatus.Processing Then
                    If NtSuspendProcess(FFmpegProcess.Handle) = 0 Then
                        Status = TaskStatus.Paused
                        TaskStopwatch.Stop()
                        UnifiedStatusRefreshLogic()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Sub ResumeTask()
            Try
                If Status = TaskStatus.Paused Then
                    If NtResumeProcess(FFmpegProcess.Handle) = 0 Then
                        Status = TaskStatus.Processing
                        TaskStopwatch.Start()
                        UnifiedStatusRefreshLogic()
                        SetSystemState()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Sub StopTask()
            Try
                If FFmpegProcess IsNot Nothing AndAlso FFmpegProcess.HasExited = False Then
                    ManuallyStoppedDoNotStartOthers = True
                    FFmpegProcess?.Kill()
                    Status = TaskStatus.Stopped
                    TaskStopwatch.Stop()
                    UnifiedStatusRefreshLogic()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Sub Cleanup()
            Try
                If FFmpegProcess IsNot Nothing Then
                    If Not FFmpegProcess.HasExited Then
                        FFmpegProcess.Kill()
                    End If
                End If
                FFmpegProcess?.Dispose()
                ListViewItem?.Remove()
                TaskStopwatch.Stop()
                GC.Collect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Sub SendMessage(message As String)
            Try
                If FFmpegProcess IsNot Nothing AndAlso Not FFmpegProcess.HasExited Then
                    FFmpegProcess.StandardInput.WriteLine(message)
                    FFmpegProcess.StandardInput.Flush()
                End If
            Catch ex As Exception
                ErrorList.Add($"SendMessage failed: {ex.Message}")
            End Try
        End Sub

        Public Sub FFmpegOutputHandler(sender As Object, e As DataReceivedEventArgs)
            If e.Data Is Nothing Then Exit Sub
            RealTimeOutput = e.Data

            If Not IsTotalDurationObtained AndAlso e.Data.Contains("Duration") Then
                Dim durationMatch = DurationPattern.Match(e.Data)
                if durationMatch.Success Then
                    If PresetData IsNot Nothing AndAlso PresetData.ClipRange_InPoint <> "" AndAlso PresetData.ClipRange_OutPoint = "" Then
                        TotalDuration = ConvertTimeStringToTimeSpan(durationMatch.Groups(1).Value) - ConvertTimeStringToTimeSpan(PresetData.ClipRange_InPoint)
                    Else
                        TotalDuration = ConvertTimeStringToTimeSpan(durationMatch.Groups(1).Value)
                    End If
                    IsTotalDurationObtained = True
                End If
            End If

            If e.Data.StartsWith("frame=") OrElse e.Data.StartsWith("size=") Then
                If (Now.TimeOfDay - LastUIRefreshTimestamp).TotalSeconds >= 1 Then
                    ExtractDataFromRealTimeOutput(e.Data)
                    ProcessCapturedDataAndAddToRefreshQueue()
                    LastUIRefreshTimestamp = Now.TimeOfDay
                End If
            Else
                NonProgressOutputList.Add(e.Data)
                If NonProgressOutputList.Count > 1000 Then
                    NonProgressOutputList.RemoveRange(0, NonProgressOutputList.Count - 100)
                End If
            End If

            If ErrorOutputMatchingStringList.Any(Function(keyword) e.Data.Contains(keyword, StringComparison.OrdinalIgnoreCase)) Then
                ErrorList.Add(e.Data)
            End If

            ExecuteOnUIThread(AddressOf UnifiedStatusRefreshLogic)
        End Sub

        Public Sub FFmpegProcessExited(sender As Object, e As EventArgs)
            SyncLock ItemsToRefresh
                If ItemsToRefresh.ContainsKey(ListViewItem) Then ItemsToRefresh.Remove(ListViewItem)
            End SyncLock

            If FFmpegProcess.ExitCode = 0 Then
                Status = TaskStatus.Completed

                If PresetData IsNot Nothing Then
                    If PresetData.VideoParam_VideoFrameServer_UseAviSynth Then
                        If FileIO.FileSystem.FileExists(AviSynthCachePath) Then FileIO.FileSystem.DeleteFile(AviSynthCachePath)
                    End If
                    If PresetData.VideoParam_VideoFrameServer_UseVapourSynth Then
                        If FileIO.FileSystem.FileExists(VapourSynthCachePath) Then FileIO.FileSystem.DeleteFile(VapourSynthCachePath)
                    End If
                End If

                Dim concatDemuxerCache = Path.Combine(Application.StartupPath, "ffmpeg_concat_demuxer.txt")
                If FileIO.FileSystem.FileExists(concatDemuxerCache) Then
                    FileIO.FileSystem.DeleteFile(concatDemuxerCache)
                End If

                If FileIO.FileSystem.FileExists(OutputFile) AndAlso FileIO.FileSystem.FileExists(InputFile) Then
                    If PresetData.OutputNaming_PreserveCreationTime Then File.SetCreationTime(OutputFile, File.GetCreationTime(InputFile))
                    If PresetData.OutputNaming_PreserveModificationTime Then File.SetLastWriteTime(OutputFile, File.GetLastWriteTime(InputFile))
                    If PresetData.OutputNaming_PreserveAccessTime Then File.SetLastAccessTime(OutputFile, File.GetLastAccessTime(InputFile))
                End If

            Else

                ErrorOccurredInCompletedTasks = True
                If Not ManuallyStoppedDoNotStartOthers Then Status = TaskStatus.Error
                If FileIO.FileSystem.FileExists(OutputFile) Then
                    Select Case UserSettings.Instance.AutoDeleteOutputFileOnFailure
                        Case 0
                            If Path.GetExtension(OutputFile).ToLower.Trim = ".mp4" Then
                                If OutputFile.Trim.Equals(InputFile.Trim, StringComparison.CurrentCultureIgnoreCase) Then
                                    RealTimeOutput = $"[3FUI] What are you doing?! Output file is the same as input file?"
                                    ErrorList.Add($"[3FUI] What are you doing?! Output file is the same as input file?")
                                Else
                                    FileIO.FileSystem.DeleteFile(OutputFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                                End If
                            End If
                        Case 1
                            If OutputFile.Trim.Equals(InputFile.Trim, StringComparison.CurrentCultureIgnoreCase) Then
                                RealTimeOutput = $"[3FUI] What are you doing?! Output file is the same as input file?"
                                ErrorList.Add($"[3FUI] What are you doing?! Output file is the same as input file?")
                            Else
                                FileIO.FileSystem.DeleteFile(OutputFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        Case 2
                    End Select
                End If

            End If
            TaskStopwatch.Stop()

            ExecuteOnUIThread(AddressOf UnifiedStatusRefreshLogic)
        End Sub
        Public Sub UnifiedStatusRefreshLogic()
            If ListViewItem Is Nothing Then Exit Sub
            Select Case Status
                Case TaskStatus.Pending
                    ListViewItem.ForeColor = Color.Silver
                    ListViewItem.SubItems(1).Text = "Pending"
                    ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                Case TaskStatus.Processing
                    ListViewItem.ForeColor = Color.YellowGreen
                    ListViewItem.SubItems(1).Text = "Processing"
                    If InputFileSize > 0 AndAlso RealTime_Size_Num > 0 Then
                        Dim realTimeSizeRatio = RealTime_Size_Num / (InputFileSize / 1024)
                        Select Case realTimeSizeRatio
                            Case < 1 : ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                            Case >= 1 : ListViewItem.SubItems(4).ForeColor = Color.IndianRed
                        End Select
                    End If
                Case TaskStatus.Completed
                    ListViewItem.ForeColor = Color.OliveDrab
                    ListViewItem.SubItems(1).Text = "Completed"
                    ListViewItem.SubItems(2).Text = "100%"
                    If FileIO.FileSystem.FileExists(InputFile) And FileIO.FileSystem.FileExists(OutputFile) Then
                        Dim outputFileSize As Long = FileIO.FileSystem.GetFileInfo(OutputFile).Length
                        Dim sizeValue As Long = outputFileSize / 1024
                        Dim sizeText As String
                        If sizeValue >= 1024 * 1024 Then
                            sizeText = $"{sizeValue / 1024.0 / 1024.0:F2} GB"
                        ElseIf sizeValue >= 1024 Then
                            sizeText = $"{sizeValue / 1024.0:F0} MB"
                        Else
                            sizeText = $"{sizeValue} KB"
                        End If
                        Dim sizeRatio = outputFileSize / InputFileSize
                        ListViewItem.SubItems(4).Text = $"{sizeText} ({$"{sizeRatio * 100:F0}%"})"
                        Select Case sizeRatio
                            Case >= 1 : ListViewItem.SubItems(4).ForeColor = Color.IndianRed
                            Case < 1 : ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                        End Select
                        GoTo EndFileSizeCalculation
                    End If
                    If Not FileIO.FileSystem.FileExists(InputFile) And FileIO.FileSystem.FileExists(OutputFile) Then
                        Dim outputFileSize As Long = FileIO.FileSystem.GetFileInfo(OutputFile).Length
                        Dim sizeValue As Long = outputFileSize / 1024
                        Dim sizeText As String
                        If sizeValue >= 1024 * 1024 Then
                            sizeText = $"{sizeValue / 1024.0 / 1024.0:F2} GB"
                        ElseIf sizeValue >= 1024 Then
                            sizeText = $"{sizeValue / 1024.0:F0} MB"
                        Else
                            sizeText = $"{sizeValue} KB"
                        End If
                        ListViewItem.SubItems(4).Text = $"{sizeText}"
                        GoTo EndFileSizeCalculation
                    End If
                    If Not FileIO.FileSystem.FileExists(OutputFile) Then
                        ListViewItem.SubItems(4).Text = $"N/A"
                        GoTo EndFileSizeCalculation
                    End If
EndFileSizeCalculation:
                    ListViewItem.SubItems(5).Text = ""
                    Dim elapsed = TaskStopwatch.Elapsed
                    Dim elapsedParts As New List(Of String)
                    If elapsed.Hours > 0 Then elapsedParts.Add($"{elapsed.Hours}h")
                    If elapsed.Minutes > 0 OrElse elapsedParts.Count > 0 Then elapsedParts.Add($"{elapsed.Minutes}m")
                    elapsedParts.Add($"{elapsed.Seconds}s")
                    ListViewItem.SubItems(7).Text = "Time: " & String.Join(" ", elapsedParts)
                    If Not ManuallyStoppedDoNotStartOthers Then CheckAndStartNewTaskTimer.Enabled = True
                Case TaskStatus.Paused
                    ListViewItem.ForeColor = Color.Goldenrod
                    ListViewItem.SubItems(1).Text = "Paused"
                    If ListViewItem.SubItems(4).ForeColor <> Color.IndianRed Then ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                Case TaskStatus.Stopped
                    ListViewItem.ForeColor = Color.IndianRed
                    ListViewItem.SubItems(1).Text = "Stopped"
                    ListViewItem.SubItems(5).Text = ""
                    ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                Case TaskStatus.Error
                    ListViewItem.SubItems(4).ForeColor = ListViewItem.ForeColor
                    If ManuallyStoppedDoNotStartOthers Then
                        ListViewItem.ForeColor = Color.IndianRed
                        ListViewItem.SubItems(5).Text = ""
                    Else
                        ListViewItem.ForeColor = Color.IndianRed
                        ListViewItem.SubItems(1).Text = "Error"
                        CheckAndStartNewTaskTimer.Enabled = True
                    End If
            End Select
        End Sub
        Public Sub ProcessCapturedDataAndAddToRefreshQueue()
            If ListViewItem Is Nothing Then Exit Sub
            Dim total = TotalDuration.TotalSeconds, cur = RealTime_Time.TotalSeconds, progress = 0.0, progressText = "N/A"
            If total > 0 AndAlso cur > 0 Then
                progress = Math.Min(cur / total, 1.0) : progressText = $"{progress * 100:F1}%"
                If progress = 0 Then progressText = "N/A"
            End If
            Dim speedPercent = "N/A", speedVal As Double
            If Not String.IsNullOrWhiteSpace(RealTime_Speed) AndAlso Double.TryParse(RealTime_Speed.Replace("x", "").Trim(), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, speedVal) AndAlso speedVal > 0 Then
                speedPercent = $"{speedVal * 100:F0}%"
            End If
            If progress = 1 AndAlso speedPercent = "N/A" Then speedPercent = ""
            Dim sizeText = "N/A", sizeVal As Long
            If Not String.IsNullOrWhiteSpace(RealTime_Size) AndAlso Long.TryParse(RealTime_Size, sizeVal) AndAlso sizeVal > 0 Then
                If sizeVal >= 1048576 Then
                    sizeText = $"{sizeVal / 1048576.0:F2} GB"
                ElseIf sizeVal >= 1024 Then
                    sizeText = $"{sizeVal / 1024.0:F0} MB"
                Else
                    sizeText = $"{sizeVal} KB"
                End If
            ElseIf RealTime_Size <> "0" Then
                sizeText = RealTime_Size
            End If
            Dim estimatedSize = ""
            If progress > 0 AndAlso progress < 1 AndAlso Long.TryParse(RealTime_Size, sizeVal) AndAlso sizeVal > 0 Then
                Dim es = sizeVal / progress
                If es >= 1048576 Then
                    estimatedSize = $" - {es / 1048576.0:F1} GB"
                ElseIf es >= 1024 Then
                    estimatedSize = $" - {es / 1024.0:F0} MB"
                Else
                    estimatedSize = $" - {es:F0} KB"
                End If
            End If
            Dim qText = If(String.IsNullOrWhiteSpace(RealTime_Q) OrElse RealTime_Q = "0", "N/A", $"{RealTime_Q:F0}")
            Dim bitrateText = If(String.IsNullOrWhiteSpace(RealTime_Bitrate) OrElse RealTime_Bitrate = "0", "N/A", RealTime_Bitrate & " kbps")
            If progress = 1 AndAlso bitrateText = "N/A" Then bitrateText = ""
            Dim remainTime = "N/A", rs As Double
            If total > 0 AndAlso cur > 0 AndAlso Double.TryParse(RealTime_Speed.Replace("x", "").Trim(), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, rs) AndAlso rs > 0 Then
                Dim sec = (total - cur) / rs
                If sec > 0 Then
                    Dim h = CInt(Math.Floor(sec / 3600.0))
                    Dim leftover = sec - (h * 3600.0)
                    Dim m = CInt(Math.Floor(leftover / 60.0))
                    Dim s = CInt(Math.Floor(leftover - (m * 60.0)))
                    Dim parts = New List(Of String)
                    If h > 0 Then parts.Add($"{h}h")
                    If m > 0 OrElse h > 0 Then parts.Add($"{m}m")
                    parts.Add($"{s}s")
                    remainTime = String.Join("", parts)
                End If
            End If

            Dim infoData As New UIDisplayDataStructure With {
                .Progress = progressText,
                .Efficiency = speedPercent,
                .OutputSize = sizeText & estimatedSize,
                .Quality = qText,
                .Bitrate = bitrateText
            }
            Dim el = TaskStopwatch.Elapsed, elapsedParts = New List(Of String)
            If el.Hours > 0 Then elapsedParts.Add($"{el.Hours}h")
            If el.Minutes > 0 OrElse elapsedParts.Count > 0 Then elapsedParts.Add($"{el.Minutes}m")
            elapsedParts.Add($"{el.Seconds}s")
            infoData.Time = $"{remainTime} - {String.Join("", elapsedParts)}"

            SyncLock ItemsToRefresh
                ItemsToRefresh(ListViewItem) = infoData
            End SyncLock
        End Sub
        Public Sub ExtractDataFromRealTimeOutput(line As String)
            If String.IsNullOrEmpty(line) Then Return
            Dim frameStr = ExtractRegexValueAsString(FramePattern, line) : If frameStr <> "" Then RealTime_Frame = frameStr
            Dim fpsStr = ExtractRegexValueAsString(FpsPattern, line) : If fpsStr <> "" Then RealTime_Fps = fpsStr
            Dim qStr = ExtractRegexValueAsString(QPattern, line) : If qStr <> "" Then RealTime_Q = qStr
            Dim sm = SizePattern.Match(line)
            If sm.Success Then
                Dim val = sm.Groups("value").Value, unit = sm.Groups("unit").Value, sz As Long
                RealTime_Size = If(Long.TryParse(val, sz), ConvertToKB(sz, unit).ToString(), val)
                RealTime_Size_Num = sz
            End If
            Dim t = ExtractRegexValueAsString(TimePattern, line) : If t <> "" Then RealTime_Time = ConvertTimeStringToTimeSpan(t)
            Dim br = ExtractRegexValueAsString(BitratePattern, line) : If br <> "" Then RealTime_Bitrate = br
            Dim sp = ExtractRegexValueAsString(SpeedPattern, line) : If sp <> "" Then RealTime_Speed = sp
        End Sub

    End Class


    Public Shared ReadOnly DurationPattern As New Regex("Duration:\s*(\d+:\d{2}:\d{2}\.\d{2})", RegexOptions.Compiled)
    Public Shared ReadOnly FramePattern As New Regex("frame=\s*(?<value>\d+)", RegexOptions.Compiled)
    Public Shared ReadOnly FpsPattern As New Regex("fps=\s*(?<value>\d+)", RegexOptions.Compiled)
    Public Shared ReadOnly QPattern As New Regex("q=\s*(?<value>[\d\.]+)", RegexOptions.Compiled)
    Public Shared ReadOnly SizePattern As New Regex("size=\s*(?<value>\d+)\s*(?<unit>[KMG]iB)", RegexOptions.Compiled)
    Public Shared ReadOnly TimePattern As New Regex("time=\s*(?<value>\d+:\d{2}:\d{2}\.\d{2})", RegexOptions.Compiled)
    Public Shared ReadOnly BitratePattern As New Regex("bitrate=\s*(?<value>[\d\.]+)\s*kbits/s", RegexOptions.Compiled)
    Public Shared ReadOnly SpeedPattern As New Regex("speed=\s*(?<value>[\d\.eE\+\-]+)\s*x", RegexOptions.Compiled)

    Shared Function ConvertToKB(value As Long, unit As String) As Long
        Select Case unit.ToUpper()
            Case "KIB" : Return value
            Case "MIB" : Return value * 1024
            Case "GIB" : Return value * 1024 * 1024
            Case Else : Return value
        End Select
    End Function

    Shared Function ExtractRegexValueAsString(pattern As Regex, input As String) As String
        Dim m = pattern.Match(input)
        If m.Success AndAlso m.Groups("value").Success Then
            Return m.Groups("value").Value
        End If
        Return ""
    End Function

    Shared Function CalculateOutputPosition(inputFile As String, container As String, presetData As PresetDataType, customDir As String) As String
        If presetData.OutputNaming_DoNotUseOutputFileParam Then
            Return ""
        End If
        Dim outputDir As String
        If customDir = "" Then
            outputDir = Path.GetDirectoryName(inputFile)
        Else
            outputDir = customDir
        End If
        If Not container.StartsWith("."c) Then container = "." & container
        Dim fileNameWithoutExt As String = Path.GetFileNameWithoutExtension(inputFile)
        Dim fileName As String = presetData.OutputNaming_PrefixText
        If presetData.OutputNaming_ReplacementText = "" Then
            fileName &= fileNameWithoutExt
        Else
            fileName &= presetData.OutputNaming_ReplacementText
        End If
        fileName &= presetData.OutputNaming_SuffixText
        If presetData.OutputNaming_UseAutoNaming Then
            Select Case presetData.OutputNaming_AutoNamingOption
                Case 0 : fileName &= $"_{Now:yyyy.MM.dd-HH.mm.ss}"
                Case 1 : fileName &= $"~1"
                Case 2 : fileName &= $"_3fui"
                Case 3
                    If presetData.VideoParam_Encoder_SpecificCodec <> "" Then fileName &= $".{presetData.VideoParam_Encoder_SpecificCodec}"
                    If presetData.VideoParam_Encoder_Preset <> "" Then fileName &= $".{presetData.VideoParam_Encoder_Preset}"
                    If presetData.VideoParam_QualityControl_ParamName <> "" AndAlso presetData.VideoParam_QualityControl_Value <> "" Then
                        fileName &= $".{presetData.VideoParam_QualityControl_ParamName.Replace("-", "")}"
                        fileName &= $"{presetData.VideoParam_QualityControl_Value}"
                    End If
                    If presetData.VideoParam_Bitrate_Base <> "" Then fileName &= $".{presetData.VideoParam_Bitrate_Base}"
                    If presetData.VideoParam_Bitrate_Min <> "" Then fileName &= $".L{presetData.VideoParam_Bitrate_Min}"
                    If presetData.VideoParam_Bitrate_Max <> "" Then fileName &= $".H{presetData.VideoParam_Bitrate_Max}"
                    If presetData.VideoParam_Bitrate_Buffer <> "" Then fileName &= $".BF{presetData.VideoParam_Bitrate_Buffer}"
                Case 4 : fileName &= $"_{GenerateRandomString(8, True, False, False)}"
                Case 5 : fileName &= $"_{GenerateRandomString(16, True, False, False)}"
                Case 6 : fileName &= $"_{GenerateRandomString(8, False, False, True)}"
                Case 7 : fileName &= $"_{GenerateRandomString(16, False, False, True)}"
                Case 8 : fileName &= $"_{GenerateRandomString(8, True, False, True)}"
                Case 9 : fileName &= $"_{GenerateRandomString(16, True, False, True)}"
            End Select
        End If
        fileName &= container
        Dim outputPath = Path.Combine(outputDir, fileName)
        If UserSettings.Instance.TranslationMode Then
            Return ProcessPathForTranslationMode(outputPath)
        Else
            Return outputPath
        End If
    End Function

    Public Shared Sub RefreshSelectedItemInfo()
        Try
            Dim errorCount As Integer = Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList.Count
            Select Case errorCount
                Case > 0
                    Form1.LinkLabelSwitchOutput.Text = Translate("LinkLabel.CatchErrors").Replace("{0}", errorCount)
                    Form1.LinkLabelSwitchOutput.LinkColor = Color.IndianRed
                Case 0
                    Form1.LinkLabelSwitchOutput.Text = Translate("LinkLabel.SwitchOutputDisplay")
                    Form1.LinkLabelSwitchOutput.LinkColor = Color.YellowGreen
            End Select

            Select Case Form1.UiComboBoxOutputDisplayType.SelectedIndex
                Case 0
                    Dim pretext = String.Join(vbCrLf, Queue(Form1.ListView1.SelectedItems(0).Index).NonProgressOutputList)
                    If IsRichTextBoxTextDifferent(pretext, Form1.RichTextBox2) Then
                        Form1.RichTextBox2.Clear()
                        For Each s In Queue(Form1.ListView1.SelectedItems(0).Index).NonProgressOutputList
                            OutputToRichTextBox(Form1.RichTextBox2, s)
                        Next
                    End If
                Case 1
                    Dim pretext = String.Join(vbCrLf, Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList)
                    If IsRichTextBoxTextDifferent(pretext, Form1.RichTextBox2) Then
                        Form1.RichTextBox2.Clear()
                        For Each s In Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList
                            OutputToRichTextBox(Form1.RichTextBox2, s)
                        Next
                    End If
            End Select

            If Form1.UiCheckBoxForceScrollToBottom.Checked Then
                Module2.SendMessage(Form1.RichTextBox2.Handle, &H115, 7, 0)
            End If

            Form1.LabelFFmpegRealTimeInfo.Text = Queue(Form1.ListView1.SelectedItems(0).Index).RealTimeOutput
        Catch ex As Exception
            Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList.Add($"Failed to refresh real-time info for selected item {Now} {ex.Message}")
        Finally
            Select Case Queue(Form1.ListView1.SelectedItems(0).Index).Status
                Case TaskStatus.Stopped, TaskStatus.Completed, TaskStatus.Paused, TaskStatus.Pending, TaskStatus.Error
                    Form1.SelectedItemRefreshInfoTimer.Enabled = False
            End Select
        End Try
    End Sub

    Public Shared Sub RefreshWhenSwitchingOutputType()
        Try
            If Form1.ListView1.SelectedItems.Count <> 1 Then Exit Sub
            Form1.RichTextBox2.Clear()
            Select Case Form1.UiComboBoxOutputDisplayType.SelectedIndex
                Case 0
                    Dim pretext = String.Join(vbCrLf, Queue(Form1.ListView1.SelectedItems(0).Index).NonProgressOutputList)
                    If IsRichTextBoxTextDifferent(pretext, Form1.RichTextBox2) Then
                        For Each s In Queue(Form1.ListView1.SelectedItems(0).Index).NonProgressOutputList
                            OutputToRichTextBox(Form1.RichTextBox2, s)
                        Next
                    End If
                Case 1
                    Dim pretext = String.Join(vbCrLf, Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList)
                    If IsRichTextBoxTextDifferent(pretext, Form1.RichTextBox2) Then
                        For Each s In Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList
                            OutputToRichTextBox(Form1.RichTextBox2, s)
                        Next
                    End If
            End Select
        Catch ex As Exception
            Queue(Form1.ListView1.SelectedItems(0).Index).ErrorList.Add($"Failed in RefreshWhenSwitchingOutputType {Now} {ex.Message}")
        End Try
    End Sub
    Shared Function IsRichTextBoxTextDifferent(newText As String, richTextBox As RichTextBox) As Boolean
        Dim currentPlainText As String = richTextBox.Text
        Dim normalizedNewText As String = newText.Replace(vbCrLf, "").Replace(vbLf, "").Replace(vbCr, "")
        Dim normalizedCurrentText As String = currentPlainText.Replace(vbCrLf, "").Replace(vbLf, "").Replace(vbCr, "")
        Return Not String.Equals(normalizedNewText, normalizedCurrentText, StringComparison.CurrentCultureIgnoreCase)
    End Function

End Class






