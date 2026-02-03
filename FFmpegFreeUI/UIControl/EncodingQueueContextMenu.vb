Public Class EncodingQueueContextMenu

    Public Shared ReadOnly a As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}

    Public Shared Sub Initialize()
        Form1.ListView1.ContextMenuStrip = a
        a.Items.AddRange(New ToolStripItem() {
                         New ToolStripSeparator() With {.Tag = "null"},
                         New ToolStripMenuItem("Task Status Control") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
                         New ToolStripMenuItem("Start New Task", Nothing, AddressOf UIControl_EncodingQueue.StartTask) With {.ForeColor = Color.YellowGreen},
                         New ToolStripMenuItem("Pause (Suspend Process)", Nothing, AddressOf UIControl_EncodingQueue.PauseTask) With {.ForeColor = Color.Goldenrod},
                         New ToolStripMenuItem("Resume (Restore Process)", Nothing, AddressOf UIControl_EncodingQueue.ResumeTask) With {.ForeColor = Color.YellowGreen},
                         New ToolStripMenuItem("Stop (Terminate Process)", Nothing, AddressOf UIControl_EncodingQueue.StopTask) With {.ForeColor = Color.IndianRed},
                         New ToolStripMenuItem("Remove", Nothing, AddressOf UIControl_EncodingQueue.RemoveTask) With {.ForeColor = Color.IndianRed},
                         New ToolStripMenuItem("Reset Status", Nothing, AddressOf UIControl_EncodingQueue.ResetTask),
                         New ToolStripSeparator() With {.Tag = "null"}})
    End Sub

    Public Shared Sub ResetFont()
        a.Font = New Font(UserSettings.Instance.Font, a.Font.Size)
    End Sub

End Class


