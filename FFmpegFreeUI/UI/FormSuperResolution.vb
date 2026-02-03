Imports System.IO

Public Class FormSuperResolution
    Private Sub FormSuperResolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DarkListViewCustomDraw.BindListViewEvents2(ListView1)
        ListView1.SmallImageList = Form1.ImageList1
    End Sub

    Private Sub FormSuperResolution_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CalibrateUiComboBoxVisual(UiComboBoxUpsamplingAlgorithm)
        CalibrateUiComboBoxVisual(UiComboBoxDownsamplingAlgorithm)
        CalibrateUI()
    End Sub

    Private Sub FormSuperResolution_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState <> FormWindowState.Minimized AndAlso Me.Visible Then
            CalibrateUI()
        End If
    End Sub

    Sub CalibrateUI()
        Me.ListView1.Columns(0).Width = Me.ListView1.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI
    End Sub

    Private Sub FormSuperResolution_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UiTextBoxSuperResolutionWidth.Text = "" Or UiTextBoxSuperResolutionHeight.Text = "" Then
            ResetAllOptions()
        End If
        e.Cancel = True
        Me.Hide()
        Form1.Focus()
    End Sub

    Sub ResetAllOptions()
        UiTextBoxSuperResolutionWidth.Text = ""
        UiTextBoxSuperResolutionHeight.Text = ""
        UiComboBoxUpsamplingAlgorithm.Text = ""
        UiComboBoxDownsamplingAlgorithm.Text = ""
        UiTextBoxAntiRingingStrength.Text = ""
        ListView1.Items.Clear()
    End Sub

    Private Sub UiButtonAddShader_Click(sender As Object, e As EventArgs) Handles UiButtonAddShader.Click
        Using ofd As New OpenFileDialog
            ofd.Title = "Select Shader File"
            ofd.Filter = "Shader File|*.glsl;*.hook|All Files|*.*"
            ofd.Multiselect = True
            If ofd.ShowDialog = DialogResult.OK Then
                For Each FilePath In ofd.FileNames
                    ListView1.Items.Add(FilePath)
                Next
            End If
        End Using
    End Sub

    Private Sub UiButtonRemoveShader_Click(sender As Object, e As EventArgs) Handles UiButtonRemoveShader.Click
        For i As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.Items.Remove(ListView1.SelectedItems(i))
        Next
    End Sub

    Private Sub UiButtonMoveUpShader_Click(sender As Object, e As EventArgs) Handles UiButtonMoveUpShader.Click
        If ListView1.SelectedItems.Count = 0 Then
            Return
        End If
        Dim SelectedItem = ListView1.SelectedItems(0)
        Dim Index = SelectedItem.Index
        If Index = 0 Then
            Return
        End If
        ListView1.Items.RemoveAt(Index)
        ListView1.Items.Insert(Index - 1, SelectedItem)
    End Sub

    Private Sub UiButtonMoveDownShader_Click(sender As Object, e As EventArgs) Handles UiButtonMoveDownShader.Click
        If ListView1.SelectedItems.Count = 0 Then
            Return
        End If
        Dim SelectedItem = ListView1.SelectedItems(0)
        Dim Index = SelectedItem.Index
        If Index = ListView1.Items.Count - 1 Then
            Return
        End If
        ListView1.Items.RemoveAt(Index)
        ListView1.Items.Insert(Index + 1, SelectedItem)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim FilePathArray As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each FilePath In FilePathArray
                Select Case Path.GetExtension(FilePath)
                    Case ".glsl", ".hook" : ListView1.Items.Add(FilePath)
                End Select
            Next
        End If
    End Sub

    Private Sub UiButtonDownload_MouseDown(sender As Object, e As MouseEventArgs) Handles UiButtonDownload.MouseDown
        Dim a As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        a.Items.AddRange(New ToolStripItem() {
             New ToolStripSeparator() With {.Tag = "null"},
             New ToolStripMenuItem("General Super Resolution") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
             New ToolStripMenuItem("igv/FSRCNN-TensorFlow", Nothing, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/igv/FSRCNN-TensorFlow", .UseShellExecute = True})) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem("gist.github.com/igv", Nothing, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://gist.github.com/igv", .UseShellExecute = True})) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem("bjin/mpv-prescalers", Nothing, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/bjin/mpv-prescalers", .UseShellExecute = True})) With {.ForeColor = Color.Silver},
             New ToolStripSeparator(),
             New ToolStripMenuItem("Anime Super Resolution") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
             New ToolStripMenuItem("bloc97/Anime4K", Nothing, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/bloc97/Anime4K", .UseShellExecute = True})) With {.ForeColor = Color.Silver},
             New ToolStripSeparator() With {.Tag = "null"}})

        a.Show(sender, New Point(sender.Width - a.Width, sender.Height + sender.Parent.Padding.Bottom))
    End Sub
End Class








