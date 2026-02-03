Public Class MediaInfoPage

    Private Sub MediaInfoPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetRichTextBoxLineHeight(RichTextBox1, 350)
        AddHandler UiButton1.DragEnter, AddressOf FileDragEnterEvent
        AddHandler Label123.DragEnter, AddressOf FileDragEnterEvent
        AddHandler Panel9.DragEnter, AddressOf FileDragEnterEvent
        AddHandler UiButton1.DragDrop, AddressOf FileDragDropEvent
        AddHandler Label123.DragDrop, AddressOf FileDragDropEvent
        AddHandler Panel9.DragDrop, AddressOf FileDragDropEvent
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        Dim openFileDialog As New OpenFileDialog With {.Multiselect = False}
        If openFileDialog.ShowDialog = DialogResult.OK Then
            ShowMediaInfoProcess(openFileDialog.FileName)
        End If
    End Sub

    Sub FileDragEnterEvent(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Sub FileDragDropEvent(sender As Object, e As DragEventArgs)
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        If files.Length > 0 Then ShowMediaInfoProcess(files(0))
    End Sub

    Sub ShowMediaInfoProcess(filePath As String)
        Me.RichTextBox1.Text = ""
        Dim ffprobeProcess As New Process
        ffprobeProcess = New Process()
        ffprobeProcess.StartInfo.FileName = "ffprobe"
        ffprobeProcess.StartInfo.WorkingDirectory = If(UserSettings.Instance.WorkingDirectory <> "", UserSettings.Instance.WorkingDirectory, "")
        ffprobeProcess.StartInfo.Arguments = $"-hide_banner ""{filePath}"""
        ffprobeProcess.StartInfo.RedirectStandardOutput = True
        ffprobeProcess.StartInfo.RedirectStandardError = True
        ffprobeProcess.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8
        ffprobeProcess.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8
        ffprobeProcess.StartInfo.CreateNoWindow = True
        ffprobeProcess.EnableRaisingEvents = True
        AddHandler ffprobeProcess.OutputDataReceived, AddressOf ShowMediaInfoOutputEvent
        AddHandler ffprobeProcess.ErrorDataReceived, AddressOf ShowMediaInfoOutputEvent
        ffprobeProcess.Start()
        ffprobeProcess.BeginOutputReadLine()
        ffprobeProcess.BeginErrorReadLine()
    End Sub
    Sub ShowMediaInfoOutputEvent(sender As Object, e As DataReceivedEventArgs)
        If e.Data Is Nothing Then Exit Sub
        Try
            ExecuteOnUIThread(Sub() OutputToRichTextBox(Me.RichTextBox1, e.Data))
        Catch ex As Exception
        End Try
    End Sub

    Sub AdjustUI()
        RichTextBox1.Size = New Size(RichTextBox1.Parent.Width - RichTextBox1.Parent.Padding.Left, RichTextBox1.Parent.Height - RichTextBox1.Parent.Padding.Top * 2)
    End Sub

End Class

