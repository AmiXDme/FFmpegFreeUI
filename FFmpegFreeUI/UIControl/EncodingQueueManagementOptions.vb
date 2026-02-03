Public Class EncodingQueueManagementOptions

    Public Shared ReadOnly a As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}

    Public Shared Sub Initialize()
        AddHandler Form1.UiButtonTaskManagementMenu.MouseDown, Sub(s, e)
                                                       If e.Button = MouseButtons.Left Then
                                                           a.Show(Form1.UiButtonTaskManagementMenu, New Point(15 * Form1.DPI, 15 * Form1.DPI + Form1.UiButtonTaskManagementMenu.Height))
                                                       End If
                                                   End Sub
        a.Items.AddRange(New ToolStripItem() {
                 New ToolStripSeparator() With {.Tag = "null"},
                 New ToolStripMenuItem("Task Data Management") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
                 New ToolStripMenuItem("(Supports Multi-select) Copy command lines (one per line)", Nothing, AddressOf UIControl_EncodingQueue.CopyCommandLines),
                 New ToolStripMenuItem("(Supports Multi-select) Apply Parameter Panel Data to Task(s)", Nothing, AddressOf UIControl_EncodingQueue.ApplyParameterPanelToTasks),
                 New ToolStripMenuItem("(Single-selection only) Apply Task Parameters to Parameter Panel", Nothing, AddressOf UIControl_EncodingQueue.ApplyTaskParametersToPanel),
                 New ToolStripMenuItem("(Supports Multi-select) Move Tasks to Prepare Files Tab", Nothing, AddressOf UIControl_EncodingQueue.AddTasksToPrepareFilesTab),
                 New ToolStripMenuItem("(Single-selection only) Export Task Parameters to Preset File", Nothing, AddressOf UIControl_EncodingQueue.ExportTaskParametersToPresetFile),
                 New ToolStripSeparator(),
                 New ToolStripMenuItem("Task Management") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
                 New ToolStripMenuItem("Select All", Nothing, AddressOf UIControl_EncodingQueue.SelectAllTasks),
                 New ToolStripMenuItem("Invert Selection", Nothing, AddressOf UIControl_EncodingQueue.InvertTaskSelection),
                 New ToolStripMenuItem("Select All Error Tasks and Locate First", Nothing, AddressOf UIControl_EncodingQueue.SelectAllErrorTasks),
                 New ToolStripMenuItem("Move All Error Tasks to Top", Nothing, AddressOf UIControl_EncodingQueue.MoveErrorTasksToTop),
                 New ToolStripMenuItem("Locate First Selection", Nothing, Sub() If Form1.ListView1.SelectedItems.Count > 0 Then Form1.ListView1.EnsureVisible(Form1.ListView1.SelectedItems(0).Index)),
                 New ToolStripSeparator(),
                 New ToolStripMenuItem("Help Content") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
                 New ToolStripMenuItem("View Shortcuts", Nothing, Sub() InAppDialog.ShowDialog(Form1, "Shortcuts", My.Resources.Resource1.QueueShortcuts, New Dictionary(Of String, Action) From {{"Understand", Nothing}}, InAppDialog.ThemeType.Normal,, 0.3)),
                 New ToolStripSeparator() With {.Tag = "null"}})
    End Sub

    Public Shared Sub ResetFont()
        a.Font = New Font(UserSettings.Instance.Font, a.Font.Size)
    End Sub

End Class




