Public Class PerformancePage

    Public IsInitialized As Boolean = False

    Private Sub PerformancePage_Load(sender As Object, e As EventArgs) Handles Me.Load
        CalibrateUI()
        FlowLayoutPanel1.Controls.Clear()
        UiRoundProcessPhysicalMemory.Value = 0
        UiRoundProcessVirtualMemory.Value = 0
        UiRoundProcessDecodingCore.Value = 0
        UiRoundProcessEncodingCore.Value = 0
        UiRoundProcessPcieBandwidth.Value = 0
        UiRoundProcessVideoMemory.Value = 0
        UiRoundProcess3D.Value = 0
        UiRoundProcessCopy.Value = 0
        UiRoundProcessTemperature.Value = 0
        UiRoundProcessFanSpeed.Value = 0
        UiRoundProcessPowerConsumption.Value = 0
        IsInitialized = True
    End Sub

    Public Sub CalibrateUI()
        Panel2.Width = (40 * 8 + 20 + 2 * 7 - 2) * Form1.DPI
        Panel18.Width = (Panel2.Width - Panel17.Padding.Left - Label21.Width) * 0.5

        FlowLayoutPanel1.Width = FlowLayoutPanel1.Parent.Width + SystemInformation.VerticalScrollBarWidth + 2 * Form1.DPI

        UiRoundProcessPhysicalMemory.Inner = 30 * Form1.DPI
        UiRoundProcessPhysicalMemory.Outer = 40 * Form1.DPI
        UiRoundProcessVirtualMemory.Inner = 30 * Form1.DPI
        UiRoundProcessVirtualMemory.Outer = 40 * Form1.DPI

        UiRoundProcessDecodingCore.Inner = 30 * Form1.DPI
        UiRoundProcessDecodingCore.Outer = 40 * Form1.DPI
        UiRoundProcessEncodingCore.Inner = 30 * Form1.DPI
        UiRoundProcessEncodingCore.Outer = 40 * Form1.DPI
        UiRoundProcessPcieBandwidth.Inner = 30 * Form1.DPI
        UiRoundProcessPcieBandwidth.Outer = 40 * Form1.DPI
        UiRoundProcessVideoMemory.Inner = 30 * Form1.DPI
        UiRoundProcessVideoMemory.Outer = 40 * Form1.DPI

        UiRoundProcess3D.Inner = 25 * Form1.DPI
        UiRoundProcess3D.Outer = 30 * Form1.DPI
        UiRoundProcessCopy.Inner = 25 * Form1.DPI
        UiRoundProcessCopy.Outer = 30 * Form1.DPI
        UiRoundProcessTemperature.Inner = 25 * Form1.DPI
        UiRoundProcessTemperature.Outer = 30 * Form1.DPI
        UiRoundProcessFanSpeed.Inner = 25 * Form1.DPI
        UiRoundProcessFanSpeed.Outer = 30 * Form1.DPI
        UiRoundProcessPowerConsumption.Inner = 25 * Form1.DPI
        UiRoundProcessPowerConsumption.Outer = 30 * Form1.DPI

    End Sub

    Private Sub PerformancePage_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        If IsInitialized Then CalibrateUI()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim a As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        a.Items.Add(New ToolStripSeparator() With {.Tag = "null"})
        a.Items.Add(New ToolStripMenuItem("Select GPU") With {.ForeColor = Color.CornflowerBlue, .Enabled = False})
        For Each item As String In PerformanceStats.GpuInfoTable.Keys
            Dim b As New ToolStripMenuItem(item) With {.Tag = item}
            AddHandler b.Click, Sub() LinkLabel1.Text = item
            a.Items.Add(b)
        Next
        a.Items.Add(New ToolStripSeparator() With {.Tag = "null"})
        a.Show(LinkLabel1, New Point(20 * Form1.DPI, LinkLabel1.Height + 20 * Form1.DPI))
    End Sub
End Class










