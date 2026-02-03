Public Class MuxingPage

    Private Sub MuxingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        DarkListViewCustomDraw.BindListViewEvents(Me.ListView1)
        Me.ListView1.SmallImageList = Form1.ImageList1
        AddHandler UiTextBoxVideoStreams.TextChanged, Sub()
                                               If Not UiTextBoxVideoStreams.Focused Then Exit Sub
                                               If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
                                               Me.ListView1.SelectedItems(0).SubItems(1).Text = UiTextBoxVideoStreams.Text
                                           End Sub
        AddHandler UiTextBoxAudioStreams.TextChanged, Sub()
                                               If Not UiTextBoxAudioStreams.Focused Then Exit Sub
                                               If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
                                               Me.ListView1.SelectedItems(0).SubItems(2).Text = UiTextBoxAudioStreams.Text
                                           End Sub
        AddHandler UiTextBoxSubtitleStreams.TextChanged, Sub()
                                               If Not UiTextBoxSubtitleStreams.Focused Then Exit Sub
                                               If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
                                               Me.ListView1.SelectedItems(0).SubItems(3).Text = UiTextBoxSubtitleStreams.Text
                                           End Sub
        AddHandler UiCheckBoxUseChapters.MouseClick, Sub()
                                               If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
                                               If UiCheckBoxUseChapters.Checked Then
                                                   For Each item In Me.ListView1.Items
                                                       item.SubItems(4).Text = ""
                                                   Next
                                                   Me.ListView1.SelectedItems(0).SubItems(4).Text = "UseCurrent"
                                               Else
                                                   Me.ListView1.SelectedItems(0).SubItems(4).Text = ""
                                               End If
                                           End Sub
        AddHandler UiCheckBoxUseMetadata.MouseClick, Sub()
                                               If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
                                               If UiCheckBoxUseMetadata.Checked Then
                                                   For Each item In Me.ListView1.Items
                                                       item.SubItems(5).Text = ""
                                                   Next
                                                   Me.ListView1.SelectedItems(0).SubItems(5).Text = "UseCurrent"
                                               Else
                                                   Me.ListView1.SelectedItems(0).SubItems(5).Text = ""
                                               End If
                                           End Sub

    End Sub

    Sub CalibrateUI()
        Me.ListView1.Columns(1).Width = LabelVideo.Width
        Me.ListView1.Columns(2).Width = LabelAudio.Width
        Me.ListView1.Columns(3).Width = LabelSubtitles.Width
        Me.ListView1.Columns(4).Width = LabelChapter.Width
        Me.ListView1.Columns(5).Width = LabelMetadata.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
        Me.ListView1.Columns(0).Width = Me.ListView1.Width - Me.ListView1.Columns(1).Width - Me.ListView1.Columns(2).Width - Me.ListView1.Columns(3).Width - Me.ListView1.Columns(4).Width - Me.ListView1.Columns(5).Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2 - 5 * Form1.DPI

        UiCheckBoxUseChapters.CheckBoxSize = 20 * Form1.DPI
        UiCheckBoxUseMetadata.CheckBoxSize = 20 * Form1.DPI
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count = 1 Then
            UiTextBoxVideoStreams.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            UiTextBoxAudioStreams.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            UiTextBoxSubtitleStreams.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            UiCheckBoxUseChapters.Checked = Me.ListView1.SelectedItems(0).SubItems(4).Text = "UseCurrent"
            UiCheckBoxUseMetadata.Checked = Me.ListView1.SelectedItems(0).SubItems(5).Text = "UseCurrent"
        Else
            UiTextBoxVideoStreams.Text = ""
            UiTextBoxAudioStreams.Text = ""
            UiTextBoxSubtitleStreams.Text = ""
            UiCheckBoxUseChapters.Checked = False
            UiCheckBoxUseMetadata.Checked = False
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If Me.ListView1.SelectedItems.Count <> 1 Then Exit Sub
        ShowForm(New FormMediaStreamSelector(mediaFileToRead:=ListView1.SelectedItems(0).Text,
             videoStreamTargetObject:=ListView1.SelectedItems(0).SubItems(1),
             audioStreamTargetObject:=ListView1.SelectedItems(0).SubItems(2),
             subtitleStreamTargetObject:=ListView1.SelectedItems(0).SubItems(3),
             videoStreamsSelected:=ListView1.SelectedItems(0).SubItems(1).Text,
             audioStreamsSelected:=ListView1.SelectedItems(0).SubItems(2).Text,
             subtitleStreamsSelected:=ListView1.SelectedItems(0).SubItems(3).Text), Form1)
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
                Dim item As New ListViewItem With {.Text = b}
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                ListView1.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub UiButtonAddFile_Click(sender As Object, e As EventArgs) Handles UiButtonAddFile.Click
        Dim ofd As New OpenFileDialog With {
            .Multiselect = True,
            .Filter = "All Files|*.*"
        }
        If ofd.ShowDialog() = DialogResult.OK Then
            For Each file In ofd.FileNames
                Dim item As New ListViewItem With {.Text = file}
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("")
                Me.ListView1.Items.Add(item)
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

    Private Sub UiButtonStartMuxing_Click(sender As Object, e As EventArgs) Handles UiButtonStartMuxing.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If UiTextBoxOutputFile.Text = "" Then Exit Sub
        Dim arg = "-hide_banner -nostdin "
        For Each item As ListViewItem In ListView1.Items
            arg &= $"-i {"""" & item.Text & """"} "
        Next

        For Each item As ListViewItem In ListView1.Items
            Dim va = item.SubItems(1).Text.Trim.Split(","c)
            For Each v In va
                If v <> "" Then
                    arg &= $" -map {item.Index}:v:{v} -c:v copy "
                End If
            Next

            Dim aa = item.SubItems(2).Text.Trim.Split(","c)
            For Each a In aa
                If a <> "" Then
                    arg &= $" -map {item.Index}:a:{a} -c:a copy "
                End If
            Next

            Dim sa = item.SubItems(3).Text.Trim.Split(","c)
            For Each s In sa
                If s <> "" Then
                    arg &= $" -map {item.Index}:s:{s} -c:s copy "
                End If
            Next

            If item.SubItems(4).Text = "UseCurrent" Then
                arg &= $"-map_metadata {item.Index} "
            End If
            If item.SubItems(5).Text = "UseCurrent" Then
                arg &= $"-map_chapters {item.Index} "
            End If
        Next

        arg &= """" & UiTextBoxOutputFile.Text & """" & " -y"

        PluginManager.AddMissionToQueueWithArgs(arg, $"Muxing Task {Now:HHmmss}", UiTextBoxOutputFile.Text)
        Form1.UiTabControlMenu1.SelectedTab = Form1.TabPageEncodingQueue
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True

    End Sub


End Class












