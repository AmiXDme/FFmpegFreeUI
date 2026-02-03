Imports System.IO
Imports System.Text.Json

Public Class UIControl_EncodingQueue

    Public Shared Sub StartTask()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim runningTasksCount = EncodingTask.Queue.Where(Function(item) item.Status = EncodingTask.TaskStatus.Processing).Count
        If runningTasksCount >= 10 Then
            Dim options As New Dictionary(Of String, Action)
            options("Cancel") = Nothing
            options("Confirm Start More Tasks") = AddressOf ReallyStartTask
            InAppDialog.ShowDialog(Form1, "Too many concurrent tasks", "The number of running tasks is already >= 10. Are you sure you want to start more tasks? Excessive resource usage by FFmpeg may slow down the system or cause crashes!", options, InAppDialog.ThemeType.Error)
        ElseIf runningTasksCount + Form1.ListView1.SelectedItems.Count > 10 Then
            Dim options As New Dictionary(Of String, Action)
            options("Cancel") = Nothing
            options("Confirm Start More Tasks") = AddressOf ReallyStartTask
            InAppDialog.ShowDialog(Form1, "Check selected task count", "You are about to start too many tasks. Including running ones, the count exceeds 10. Are you sure you want to continue? Excessive resource usage by FFmpeg may slow down the system or cause crashes!", options, InAppDialog.ThemeType.Error)
        Else
            ReallyStartTask()
        End If
    End Sub

    Private Shared Sub ReallyStartTask()
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Pending
                    Task.Run(AddressOf EncodingTask.Queue(i).Start)
            End Select
        Next
    End Sub

    Public Shared Sub PauseTask()
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Processing
                    EncodingTask.Queue(i).Pause()
            End Select
        Next
    End Sub

    Public Shared Sub ResumeTask()
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Paused
                    EncodingTask.Queue(i).ResumeTask()
            End Select
        Next
    End Sub

    Public Shared Sub StopTask()
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Processing, EncodingTask.TaskStatus.Paused, EncodingTask.TaskStatus.Error
                    EncodingTask.Queue(i).StopTask()
            End Select
        Next
    End Sub

    Public Shared Sub RemoveTask()
        Dim indices As New List(Of Integer)
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Completed, EncodingTask.TaskStatus.Pending, EncodingTask.TaskStatus.Error, EncodingTask.TaskStatus.Stopped
                    indices.Add(i)
            End Select
        Next
        indices.Sort()
        indices.Reverse()
        For Each i In indices
            EncodingTask.Queue(i).Cleanup()
            EncodingTask.Queue.RemoveAt(i)
        Next
    End Sub

    Public Shared Sub ResetTask()
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            Dim i = item.Index
            Select Case EncodingTask.Queue(i).Status
                Case EncodingTask.TaskStatus.Completed, EncodingTask.TaskStatus.Error, EncodingTask.TaskStatus.Stopped
                    EncodingTask.Queue(i).Status = EncodingTask.TaskStatus.Pending
                    EncodingTask.Queue(i).TaskStopwatch.Reset()
                    EncodingTask.Queue(i).UnifiedStatusRefreshLogic()
                    EncodingTask.Queue(i).ManuallyStoppedDoNotStartOthers = False
            End Select
        Next
    End Sub

    Public Shared Sub SelectAllTasks()
        For Each item As ListViewItem In Form1.ListView1.Items
            item.Selected = True
        Next
    End Sub

    Public Shared Sub InvertTaskSelection()
        For Each item As ListViewItem In Form1.ListView1.Items
            item.Selected = Not item.Selected
        Next
    End Sub

    Public Shared Sub SelectAllErrorTasks()
        For Each item As ListViewItem In Form1.ListView1.Items
            Select Case EncodingTask.Queue(item.Index).Status
                Case EncodingTask.TaskStatus.Error : item.Selected = True
                Case Else : item.Selected = False
            End Select
        Next
        If Form1.ListView1.SelectedItems.Count > 0 Then Form1.ListView1.EnsureVisible(Form1.ListView1.SelectedItems(0).Index)
    End Sub

    Public Shared Sub LocateOutput()
        If Form1.ListView1.SelectedItems.Count <> 1 Then Exit Sub
        Dim outputFile = EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).OutputFile
        Select Case EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).Status
            Case EncodingTask.TaskStatus.Pending
                If Not FileIO.FileSystem.FileExists(EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).InputFile) Then Exit Sub
                Dim options As New Dictionary(Of String, Action)
                options("No") = Nothing
                options("Yes") = Sub() Process.Start("explorer", "/select,""" & EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).InputFile & """")
                InAppDialog.ShowDialog(Form1, "Do you mean to locate the input file?", "Because this task hasn't started yet.", options, InAppDialog.ThemeType.Normal)
            Case Else
                If Not FileIO.FileSystem.FileExists(EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).OutputFile) Then Exit Sub
                Process.Start("explorer", "/select,""" & EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).OutputFile & """")
        End Select
    End Sub

    Public Shared Sub CopyCommandLines()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim commandLines As New List(Of String)
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            If EncodingTask.Queue(item.Index).CommandLine <> "" Then
                commandLines.Add("ffmpeg " & EncodingTask.Queue(item.Index).CommandLine)
            Else
                If EncodingTask.Queue(item.Index).PresetData IsNot Nothing Then
                    commandLines.Add("ffmpeg " & PresetManager.ConvertPresetToCommandLine(EncodingTask.Queue(item.Index).PresetData, EncodingTask.Queue(item.Index).InputFile, EncodingTask.Queue(item.Index).OutputFile))
                Else
                    commandLines.Add("No command line available")
                End If
            End If
        Next
        Clipboard.SetText(String.Join(vbCrLf, commandLines))
    End Sub

    Public Shared Sub ApplyParameterPanelToTasks()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim a As New PresetDataType
        PresetManager.SavePreset(a, Form1.GeneralParametersPage)
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            EncodingTask.Queue(item.Index).PresetData = a
        Next
    End Sub

    Public Shared Sub ApplyTaskParametersToPanel()
        If Form1.ListView1.SelectedItems.Count <> 1 Then Exit Sub
        If EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).PresetData Is Nothing Then
            MsgBox("This task does not contain 3FUI preset data. It might have been added by another program and cannot use this feature.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Are you sure you want to apply this task's configuration to the parameter panel? This operation is irreversible!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PresetManager.ShowPreset(EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).PresetData, Form1.GeneralParametersPage)
        End If
    End Sub

    Public Shared Sub AddTasksToPrepareFilesTab()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim existingFiles As New List(Of String)
        For Each item As ListViewItem In Form1.PrepareFilesPage.ListView1.Items
            existingFiles.Add(item.Text)
        Next
        For Each item As ListViewItem In Form1.ListView1.SelectedItems
            If Not existingFiles.Contains(EncodingTask.Queue(item.Index).InputFile) Then
                Form1.PrepareFilesPage.ListView1.Items.Add(EncodingTask.Queue(item.Index).InputFile)
            End If
        Next
    End Sub

    Public Shared Sub ExportTaskParametersToPresetFile()
        If Form1.ListView1.SelectedItems.Count <> 1 Then Exit Sub
        If EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).PresetData Is Nothing Then
            MsgBox("This task does not contain 3FUI preset data and cannot use this feature.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim d As New SaveFileDialog With {.Filter = "Json|*.json"}
        d.ShowDialog(Form1)
        If d.FileName = "" Then Exit Sub
        File.WriteAllText(d.FileName, JsonSerializer.Serialize(EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).PresetData, JsonSO))
    End Sub

    Public Shared Sub MoveUpTask()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        SyncLock EncodingTask.Queue
            Dim indices As New List(Of Integer)
            For Each item As ListViewItem In Form1.ListView1.SelectedItems
                indices.Add(item.Index)
            Next
            indices.Sort()
            For Each i In indices
                If i > 0 Then
                    Dim temp = EncodingTask.Queue(i - 1)
                    EncodingTask.Queue(i - 1) = EncodingTask.Queue(i)
                    EncodingTask.Queue(i) = temp
                    Dim item1 = Form1.ListView1.Items(i - 1)
                    Dim item2 = Form1.ListView1.Items(i)
                    Dim wasSelected1 = item1.Selected
                    Dim wasSelected2 = item2.Selected
                    Form1.ListView1.Items.RemoveAt(i)
                    Form1.ListView1.Items.RemoveAt(i - 1)
                    Form1.ListView1.Items.Insert(i - 1, item2)
                    Form1.ListView1.Items.Insert(i, item1)
                    Form1.ListView1.Items(i - 1).Selected = wasSelected2
                    Form1.ListView1.Items(i).Selected = wasSelected1
                    EncodingTask.Queue(i - 1).ListViewItem = Form1.ListView1.Items(i - 1)
                    EncodingTask.Queue(i).ListViewItem = Form1.ListView1.Items(i)
                End If
            Next
        End SyncLock
    End Sub

    Public Shared Sub MoveDownTask()
        If Form1.ListView1.SelectedItems.Count = 0 Then Exit Sub
        SyncLock EncodingTask.Queue
            Dim indices As New List(Of Integer)
            For Each item As ListViewItem In Form1.ListView1.SelectedItems
                indices.Add(item.Index)
            Next
            indices.Sort()
            indices.Reverse()
            For Each i In indices
                If i < EncodingTask.Queue.Count - 1 Then
                    Dim temp = EncodingTask.Queue(i + 1)
                    EncodingTask.Queue(i + 1) = EncodingTask.Queue(i)
                    EncodingTask.Queue(i) = temp
                    Dim item1 = Form1.ListView1.Items(i)
                    Dim item2 = Form1.ListView1.Items(i + 1)
                    Dim wasSelected1 = item1.Selected
                    Dim wasSelected2 = item2.Selected
                    Form1.ListView1.Items.RemoveAt(i + 1)
                    Form1.ListView1.Items.RemoveAt(i)
                    Form1.ListView1.Items.Insert(i, item2)
                    Form1.ListView1.Items.Insert(i + 1, item1)
                    Form1.ListView1.Items(i).Selected = wasSelected2
                    Form1.ListView1.Items(i + 1).Selected = wasSelected1
                    EncodingTask.Queue(i).ListViewItem = Form1.ListView1.Items(i)
                    EncodingTask.Queue(i + 1).ListViewItem = Form1.ListView1.Items(i + 1)
                End If
            Next
        End SyncLock
    End Sub

    Public Shared Sub MoveErrorTasksToTop()
        SyncLock EncodingTask.Queue
            Dim indices As New List(Of Integer)
            For Each item As ListViewItem In Form1.ListView1.Items
                Select Case EncodingTask.Queue(item.Index).Status
                    Case EncodingTask.TaskStatus.Error
                        indices.Add(item.Index)
                End Select
            Next
            If indices.Count > 0 Then
                indices.Sort()
                For Each i In indices
                    If i > 0 Then
                        Dim temp = EncodingTask.Queue(i)
                        EncodingTask.Queue.RemoveAt(i)
                        EncodingTask.Queue.Insert(0, temp)
                        Dim item1 = Form1.ListView1.Items(i)
                        Form1.ListView1.Items.RemoveAt(i)
                        Form1.ListView1.Items.Insert(0, item1)
                        For a As Integer = 0 To i
                            EncodingTask.Queue(a).ListViewItem = Form1.ListView1.Items(a)
                        Next
                    End If
                Next
            End If
        End SyncLock
    End Sub
End Class


