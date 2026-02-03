Imports System.IO

Public Class MergingPage
    Private Sub MergingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DarkListViewCustomDraw.BindListViewEvents(Me.ListView1)
        Me.ListView1.SmallImageList = Form1.ImageList1
    End Sub

    Sub CalibrateUI()
        Me.ListView1.Columns(0).Width = Me.ListView1.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                If e.Control Then
                    For Each item As ListViewItem In ListView1.Items
                        item.Selected = True
                    Next
                End If
            Case Keys.F3
                UiButtonMoveUp.PerformClick()
                ListView1.Focus()
            Case Keys.F4
                UiButtonMoveDown.PerformClick()
                ListView1.Focus()
            Case Keys.Delete
                UiButtonRemove.PerformClick()
                ListView1.Focus()
        End Select
    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim a As String() = e.Data.GetData(DataFormats.FileDrop)
            For Each b As String In a
                ListView1.Items.Add(b)
            Next
        End If
    End Sub

    Private Sub UiButtonAddFile_Click(sender As Object, e As EventArgs) Handles UiButtonAddFile.Click
        Dim ofd As New OpenFileDialog With {.Multiselect = True, .Filter = "All Files|*.*"}
        If ofd.ShowDialog() = DialogResult.OK Then
            For Each file In ofd.FileNames
                Me.ListView1.Items.Add(file)
            Next
        End If
    End Sub

    Private Sub UiButtonMoveUp_Click(sender As Object, e As EventArgs) Handles UiButtonMoveUp.Click
        If Me.ListView1.SelectedItems.Count = 0 Then Exit Sub
        For i = 0 To Me.ListView1.SelectedIndices.Count - 1
            Dim index As Integer = Me.ListView1.SelectedIndices(i)
            If index > 0 Then
                If Me.ListView1.SelectedIndices.Contains(index - 1) Then Continue For
                Dim movingListViewItem As ListViewItem = Me.ListView1.Items(index)
                Me.ListView1.Items.RemoveAt(index)
                Me.ListView1.Items.Insert(index - 1, movingListViewItem)
                Me.ListView1.Items(index - 1).Focused = True
            End If
        Next
    End Sub

    Private Sub UiButtonMoveDown_Click(sender As Object, e As EventArgs) Handles UiButtonMoveDown.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub

        For i = Me.ListView1.SelectedIndices.Count - 1 To 0 Step -1
            Dim index As Integer = Me.ListView1.SelectedIndices(i)
            If index < Me.ListView1.Items.Count - 1 Then
                If Me.ListView1.SelectedIndices.Contains(index + 1) Then Continue For
                Dim movingListViewItem As ListViewItem = Me.ListView1.Items(index)
                Me.ListView1.Items.RemoveAt(index)
                Me.ListView1.Items.Insert(index + 1, movingListViewItem)
                Me.ListView1.Items(index + 1).Focused = True
            End If
        Next
    End Sub

    Private Sub UiButtonRemove_Click(sender As Object, e As EventArgs) Handles UiButtonRemove.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            For Each item In Me.ListView1.SelectedItems.Cast(Of ListViewItem)().ToList()
                Me.ListView1.Items.Remove(item)
            Next
        End If
    End Sub

    Private Sub UiButtonSelectLocation_Click(sender As Object, e As EventArgs) Handles UiButtonSelectLocation.Click
        Dim a As New SaveFileDialog With {.Filter = "All Files|*.*"}
        If a.ShowDialog(Form1) = DialogResult.OK Then
            UiTextBoxOutputFile.Text = a.FileName
        End If
    End Sub

    Private Sub UiButtonStartMerge_Click(sender As Object, e As EventArgs) Handles UiButtonStartMerge.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If UiTextBoxOutputFile.Text = "" Then Exit Sub
        Dim arg = "-hide_banner -nostdin "

        Dim fs As New List(Of String)
        For Each item As ListViewItem In ListView1.Items
            Dim processedText As String = item.Text.Replace("\", "\\")
            If processedText.StartsWith("\\\\") Then
                processedText = "\\" & processedText.Substring(4)
            End If
            fs.Add("file '" & processedText & "'")
        Next

        File.WriteAllText(Path.Combine(Application.StartupPath, "ffmpeg_concat_demuxer.txt"), String.Join(vbCrLf, fs), New Text.UTF8Encoding(False))

        arg &= $"-f concat -safe 0 -i ""{Path.Combine(Application.StartupPath, "ffmpeg_concat_demuxer.txt")}"" "

        arg &= "-c copy """ & UiTextBoxOutputFile.Text & """" & " -y"

        PluginManager.AddMissionToQueueWithArgs(arg, $"Merging Task {Now:HHmmss}", UiTextBoxOutputFile.Text)
        Form1.UiTabControlMenu1.SelectedTab = Form1.TabPageEncodingQueue
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True

    End Sub

End Class










