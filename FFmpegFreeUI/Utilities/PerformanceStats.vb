Imports LibreHardwareMonitor.Hardware

Public Class PerformanceStats
    Implements IVisitor, IDisposable
    Private ReadOnly computer As Computer
    Public Sub New()
        computer = New Computer() With {
            .IsCpuEnabled = True,
            .IsGpuEnabled = True,
            .IsMemoryEnabled = True,
            .IsNetworkEnabled = False,
            .IsStorageEnabled = False
        }
        Try
            computer.Open()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub

    Public Shared Property CpuLogicalCoreUsageTable As New Dictionary(Of String, Integer)
    Public Shared Property MemoryInformation As New MemoryInfoStructure
    Public Class MemoryInfoStructure
        Public Property PhysicalMemoryUsedMB As Single
        Public Property PhysicalMemoryAvailableMB As Single
        Public Property PhysicalMemoryTotalSizeMB As Single
        Public Property PhysicalMemoryUsageRate As Integer
        Public Property VirtualMemoryUsedMB As Single
        Public Property VirtualMemoryAvailableMB As Single
        Public Property VirtualMemoryTotalSizeMB As Single
        Public Property VirtualMemoryUsageRate As Integer
    End Class
    Public Shared Property GpuInfoTable As New Dictionary(Of String, GpuInfoSingleCardStructure)
    Public Class GpuInfoSingleCardStructure
        Public Property DecodeCore As Integer
        Public Property EncodeCore As Integer
        Public Property PcieBandwidth As Integer
        Public Property VideoMemoryRate As Integer
        Public Property VideoMemoryGB As Single
        Public Property _3D As Integer
        Public Property Copy As Integer
        Public Property Core As Integer
        Public Property PowerP As Integer
        Public Property CoreTemperature As Single
        Public Property VideoMemoryTemperature As Single
        Public Property FanSpeed As Single
        Public Property PowerW As Single
        Public Property Others As New Dictionary(Of String, Integer)
    End Class

    Public Sub Update()
        Try
            computer.Accept(Me)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub VisitComputer(computer As IComputer) Implements IVisitor.VisitComputer
        Try
            For Each hardware In computer.Hardware
                hardware.Accept(Me)
            Next
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub VisitHardware(hardware As IHardware) Implements IVisitor.VisitHardware
        Try
            hardware.Update()
        Catch ex As Exception
            Exit Sub
        End Try

        Try

            Select Case hardware.HardwareType
                Case HardwareType.Cpu
                    Dim cpuUsages As New Dictionary(Of String, Integer)
                    For Each sensor In hardware.Sensors
                        Select Case sensor.SensorType
                            Case SensorType.Load
                                Select Case sensor.Name
                                    Case "CPU Total"
                                    Case Else
                                        If sensor.Name.Contains("CPU Core #") Then
                                            cpuUsages(sensor.Name.Replace("CPU Core ", "")) = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault())
                                        End If
                                End Select
                        End Select
                    Next
                    If cpuUsages.Count > 0 Then CpuLogicalCoreUsageTable = cpuUsages

                Case HardwareType.GpuNvidia, HardwareType.GpuAmd, HardwareType.GpuIntel
                    Dim gpuInfo As New GpuInfoSingleCardStructure
                    For Each sensor In hardware.Sensors
                        Select Case sensor.SensorType
                            Case SensorType.Load
                                Select Case True
                                    Case sensor.Name.Contains("Video Decode")
                                        gpuInfo.DecodeCore = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.Contains("Video Encode")
                                        gpuInfo.EncodeCore = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.EndsWith("Bus")
                                        gpuInfo.PcieBandwidth = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.EndsWith("Memory")
                                        gpuInfo.VideoMemoryRate = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.EndsWith("3D")
                                        gpuInfo._3D = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.EndsWith("Copy")
                                        gpuInfo.Copy = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.EndsWith("Core")
                                        gpuInfo.Core = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case sensor.Name.Contains("GPU Board Power")
                                        gpuInfo.PowerP = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault)
                                    Case Else
                                        gpuInfo.Others(sensor.Name) = sensor.Value.GetValueOrDefault()
                                End Select

                            Case SensorType.SmallData
                                Select Case True
                                    Case sensor.Name.Contains("Dedicated Memory Used")
                                        gpuInfo.VideoMemoryGB = Format(sensor.Value.GetValueOrDefault / 1024, "0.0")
                                End Select

                            Case SensorType.Temperature
                                Select Case True
                                    Case sensor.Name.Contains("Core")
                                        gpuInfo.CoreTemperature = sensor.Value.GetValueOrDefault
                                End Select

                            Case SensorType.Fan
                                Select Case True
                                    Case sensor.Name.Contains("Fan")
                                        gpuInfo.FanSpeed = sensor.Value.GetValueOrDefault
                                End Select

                            Case SensorType.Power
                                Select Case True
                                    Case sensor.Name.Contains("Package")
                                        gpuInfo.PowerW = sensor.Value.GetValueOrDefault
                                End Select

                        End Select
                    Next
                    GpuInfoTable(hardware.Name) = gpuInfo

                Case HardwareType.Memory
                    Dim memInfo As New MemoryInfoStructure
                    For Each sensor In hardware.Sensors
                        Select Case sensor.SensorType
                            Case SensorType.Data
                                Select Case sensor.Name
                                    Case "Memory Used"
                                        memInfo.PhysicalMemoryUsedMB = sensor.Value.GetValueOrDefault() * 1024
                                    Case "Memory Available"
                                        memInfo.PhysicalMemoryAvailableMB = sensor.Value.GetValueOrDefault() * 1024
                                    Case "Virtual Memory Used"
                                        memInfo.VirtualMemoryUsedMB = sensor.Value.GetValueOrDefault() * 1024
                                    Case "Virtual Memory Available"
                                        memInfo.VirtualMemoryAvailableMB = sensor.Value.GetValueOrDefault() * 1024
                                    Case Else
                                        Debug.WriteLine(sensor.Name)
                                End Select
                            Case SensorType.Load
                                Select Case sensor.Name
                                    Case "Memory"
                                        memInfo.PhysicalMemoryUsageRate = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault())
                                    Case "Virtual Memory"
                                        memInfo.VirtualMemoryUsageRate = ConvertToPercentageMax100(sensor.Value.GetValueOrDefault())
                                    Case Else
                                        Debug.WriteLine(sensor.Name)
                                End Select
                        End Select
                    Next
                    If memInfo.PhysicalMemoryUsedMB > 0 AndAlso memInfo.PhysicalMemoryAvailableMB > 0 Then
                        memInfo.PhysicalMemoryTotalSizeMB = memInfo.PhysicalMemoryUsedMB + memInfo.PhysicalMemoryAvailableMB
                    ElseIf memInfo.PhysicalMemoryUsedMB > 0 AndAlso memInfo.PhysicalMemoryUsageRate > 0 Then
                        memInfo.PhysicalMemoryTotalSizeMB = (memInfo.PhysicalMemoryUsedMB * 100) / memInfo.PhysicalMemoryUsageRate
                    End If
                    If memInfo.VirtualMemoryUsedMB > 0 AndAlso memInfo.VirtualMemoryAvailableMB > 0 Then
                        memInfo.VirtualMemoryTotalSizeMB = memInfo.VirtualMemoryUsedMB + memInfo.VirtualMemoryAvailableMB
                    ElseIf memInfo.VirtualMemoryUsedMB > 0 AndAlso memInfo.VirtualMemoryUsageRate > 0 Then
                        memInfo.VirtualMemoryTotalSizeMB = (memInfo.VirtualMemoryUsedMB * 100) / memInfo.VirtualMemoryUsageRate
                    End If
                    MemoryInformation = memInfo

            End Select
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Public Shared Function ConvertToPercentageMax1(s As Single) As Integer
        Dim a = s * 100
        Return Integer.Parse(a.ToString("0"))
    End Function

    Public Shared Function ConvertToPercentageMax100(s As Single) As Integer
        Return Integer.Parse(s.ToString("0"))
    End Function

    Public Shared Sub RefreshToUI()
        Form1.PerformanceStatsObject.Update()

        Dim cpus = CpuLogicalCoreUsageTable.Keys.ToList
        For i = 0 To CpuLogicalCoreUsageTable.Count - 1
            If i >= Form1.PerformancePage.FlowLayoutPanel1.Controls.Count Then
                Dim cpuTile As New Label With {
                    .AutoSize = False,
                    .Margin = New Padding(0, 0, 2 * Form1.DPI, 2 * Form1.DPI),
                    .Text = CpuLogicalCoreUsageTable(cpus(i)),
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(40 * Form1.DPI, 40 * Form1.DPI),
                    .Font = New Font(UserSettings.Instance.Font, 10),
                    .BackColor = GetCpuUsageColor(CpuLogicalCoreUsageTable(cpus(i)))
                }

                If CpuLogicalCoreUsageTable(cpus(i)) >= 100 Then
                    cpuTile.ForeColor = Color.IndianRed
                Else
                    cpuTile.ForeColor = Color.Silver
                End If
                CpuFloatingTooltip.SetToolTip(cpuTile, $"Logical Core {cpus(i)}")
                Form1.PerformancePage.FlowLayoutPanel1.Controls.Add(cpuTile)
            Else
                Dim cpuTile As Label = CType(Form1.PerformancePage.FlowLayoutPanel1.Controls(i), Label)
                cpuTile.Text = CpuLogicalCoreUsageTable(cpus(i))
                cpuTile.BackColor = GetCpuUsageColor(CpuLogicalCoreUsageTable(cpus(i)))
                If CpuLogicalCoreUsageTable(cpus(i)) >= 100 Then
                    cpuTile.ForeColor = Color.IndianRed
                Else
                    cpuTile.ForeColor = Color.Silver
                End If
            End If
        Next

        Form1.PerformancePage.UiRoundProcessPhysicalMemory.Value = MemoryInformation.PhysicalMemoryUsageRate
        Form1.PerformancePage.UiRoundProcessPhysicalMemory.ProcessColor = GetGpuUsageColor(MemoryInformation.PhysicalMemoryUsageRate)
        Form1.PerformancePage.Label20.Text = $"Physical Used {Format(MemoryInformation.PhysicalMemoryUsedMB / 1024, "0.0")}G"
        Form1.PerformancePage.UiRoundProcessVirtualMemory.Value = MemoryInformation.VirtualMemoryUsageRate
        Form1.PerformancePage.UiRoundProcessVirtualMemory.ProcessColor = GetGpuUsageColor(MemoryInformation.VirtualMemoryUsageRate)
        Form1.PerformancePage.Label22.Text = $"Committed {Format(MemoryInformation.VirtualMemoryUsedMB / 1024, "0.0")}G"

        If GpuInfoTable.Count = 0 Then Exit Sub
        If Not GpuInfoTable.ContainsKey(Form1.PerformancePage.LinkLabel1.Text) Then Form1.PerformancePage.LinkLabel1.Text = GpuInfoTable.Keys(0)

        Form1.PerformancePage.UiRoundProcessDecodingCore.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).DecodeCore
        Form1.PerformancePage.UiRoundProcessDecodingCore.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).DecodeCore)
        Form1.PerformancePage.UiRoundProcessEncodingCore.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).EncodeCore
        Form1.PerformancePage.UiRoundProcessEncodingCore.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).EncodeCore)
        Form1.PerformancePage.UiRoundProcessPcieBandwidth.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).PcieBandwidth
        Form1.PerformancePage.UiRoundProcessPcieBandwidth.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).PcieBandwidth)
        Form1.PerformancePage.Label8.Text = "Video Memory " & GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).VideoMemoryGB & "G"
        Form1.PerformancePage.UiRoundProcessVideoMemory.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).VideoMemoryRate
        Form1.PerformancePage.UiRoundProcessVideoMemory.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).VideoMemoryRate)
        Form1.PerformancePage.UiRoundProcess3D.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text)._3D
        Form1.PerformancePage.UiRoundProcess3D.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text)._3D)
        Form1.PerformancePage.UiRoundProcessCopy.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).Copy
        Form1.PerformancePage.UiRoundProcessCopy.ProcessColor = GetGpuUsageColor(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).Copy)
        Form1.PerformancePage.Label12.Text = "Temperature " & GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).CoreTemperature & "°C"
        Form1.PerformancePage.UiRoundProcessTemperature.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).CoreTemperature
        Form1.PerformancePage.UiRoundProcessTemperature.ProcessColor = GetGpuUsageColor(Form1.PerformancePage.UiRoundProcessTemperature.Value)
        Form1.PerformancePage.Label10.Text = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).FanSpeed & " RPM"
        Form1.PerformancePage.UiRoundProcessFanSpeed.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).FanSpeed / 3200 * 100
        Form1.PerformancePage.UiRoundProcessFanSpeed.ProcessColor = GetGpuUsageColor(Form1.PerformancePage.UiRoundProcessFanSpeed.Value)
        Form1.PerformancePage.Label17.Text = "Power " & Format(GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).PowerW, "0") & "W"
        Form1.PerformancePage.UiRoundProcessPowerConsumption.Value = GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).PowerP
        Form1.PerformancePage.UiRoundProcessPowerConsumption.ProcessColor = GetGpuUsageColor(Form1.PerformancePage.UiRoundProcessPowerConsumption.Value)

        Dim othersInfoText As New List(Of String)
        For Each kvp In GpuInfoTable(Form1.PerformancePage.LinkLabel1.Text).Others
            othersInfoText.Add($"{kvp.Value}% {kvp.Key}")
        Next
        Form1.PerformancePage.Label7.Text = String.Join(vbCrLf, othersInfoText)
    End Sub

    Public Shared ReadOnly CpuFloatingTooltip As New ToolTip With {.Active = True, .IsBalloon = False, .UseAnimation = True}

    Public Shared Function GetCpuUsageColor(usageRate As Integer) As Color
        Select Case usageRate
            Case 0
                Return ColorTranslator.FromWin32(RGB(48, 48, 48))
            Case < 50
                Return Color.FromArgb(100, Color.Green)
            Case < 80
                Return Color.FromArgb(80, Color.CornflowerBlue)
            Case < 90
                Return Color.FromArgb(128, Color.DarkGoldenrod)
            Case Else
                Return Color.FromArgb(128, Color.OrangeRed)
        End Select
    End Function

    Public Shared Function GetGpuUsageColor(usageRate As Integer) As Color
        Select Case usageRate
            Case < 50
                Return Color.FromArgb(150, Color.LimeGreen)
            Case < 80
                Return Color.FromArgb(150, Color.DeepSkyBlue)
            Case < 90
                Return Color.FromArgb(150, Color.Orange)
            Case Else
                Return Color.FromArgb(150, Color.OrangeRed)
        End Select
    End Function

    Public Sub VisitSensor(sensor As ISensor) Implements IVisitor.VisitSensor
    End Sub
    Public Sub VisitParameter(parameter As IParameter) Implements IVisitor.VisitParameter
    End Sub

End Class



