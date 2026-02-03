<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformancePage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Note: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label31 = New Label()
        Panel2 = New Panel()
        Panel15 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel17 = New Panel()
        Panel19 = New Panel()
        UiRoundProcessVirtualMemory = New Sunny.UI.UIRoundProcess()
        Label22 = New Label()
        Label21 = New Label()
        Panel18 = New Panel()
        UiRoundProcessPhysicalMemory = New Sunny.UI.UIRoundProcess()
        Label20 = New Label()
        Label19 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label1 = New Label()
        Panel9 = New Panel()
        Panel14 = New Panel()
        UiRoundProcessPowerConsumption = New Sunny.UI.UIRoundProcess()
        Label17 = New Label()
        Label18 = New Label()
        Panel10 = New Panel()
        UiRoundProcessFanSpeed = New Sunny.UI.UIRoundProcess()
        Label10 = New Label()
        Label11 = New Label()
        Panel11 = New Panel()
        UiRoundProcessTemperature = New Sunny.UI.UIRoundProcess()
        Label12 = New Label()
        Label13 = New Label()
        Panel12 = New Panel()
        UiRoundProcessCopy = New Sunny.UI.UIRoundProcess()
        Label14 = New Label()
        Label15 = New Label()
        Panel13 = New Panel()
        UiRoundProcess3D = New Sunny.UI.UIRoundProcess()
        Label16 = New Label()
        Panel4 = New Panel()
        Panel8 = New Panel()
        UiRoundProcessVideoMemory = New Sunny.UI.UIRoundProcess()
        Label8 = New Label()
        Label9 = New Label()
        Panel7 = New Panel()
        UiRoundProcessPcieBandwidth = New Sunny.UI.UIRoundProcess()
        Label5 = New Label()
        Label6 = New Label()
        Panel6 = New Panel()
        UiRoundProcessEncodingCore = New Sunny.UI.UIRoundProcess()
        Label4 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        UiRoundProcessDecodingCore = New Sunny.UI.UIRoundProcess()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel15.SuspendLayout()
        Panel17.SuspendLayout()
        Panel19.SuspendLayout()
        Panel18.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel14.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel1.Controls.Add(Label31)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 10, 20, 20)
        Panel1.Size = New Size(1033, 50)
        Panel1.TabIndex = 82
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Dock = DockStyle.Top
        Label31.Font = New Font("Segoe UI", 10F)
        Label31.Location = New Point(20, 10)
        Label31.Name = "Label31"
        Label31.Size = New Size(625, 20)
        Label31.TabIndex = 0
        Label31.Text = "Performance monitoring will auto-pause when switching to other tabs; depending on drivers, system settings, and hardware, some sensors may not work."
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel15)
        Panel2.Controls.Add(Panel17)
        Panel2.Controls.Add(Label19)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(352, 601)
        Panel2.TabIndex = 83
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(FlowLayoutPanel1)
        Panel15.Dock = DockStyle.Fill
        Panel15.Location = New Point(0, 224)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(352, 377)
        Panel15.TabIndex = 128
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(20, 0, 0, 20)
        FlowLayoutPanel1.Size = New Size(333, 377)
        FlowLayoutPanel1.TabIndex = 127
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(Panel19)
        Panel17.Controls.Add(Label21)
        Panel17.Controls.Add(Panel18)
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(0, 44)
        Panel17.Name = "Panel17"
        Panel17.Padding = New Padding(20, 20, 0, 10)
        Panel17.Size = New Size(352, 180)
        Panel17.TabIndex = 127
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel19.Controls.Add(UiRoundProcessVirtualMemory)
        Panel19.Controls.Add(Label22)
        Panel19.Dock = DockStyle.Fill
        Panel19.Location = New Point(192, 20)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(160, 150)
        Panel19.TabIndex = 3
        ' 
        ' UiRoundProcessVirtualMemory
        ' 
        UiRoundProcessVirtualMemory.DecimalPlaces = 0
        UiRoundProcessVirtualMemory.Dock = DockStyle.Fill
        UiRoundProcessVirtualMemory.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessVirtualMemory.ForeColor = Color.Silver
        UiRoundProcessVirtualMemory.ForeColor2 = Color.Black
        UiRoundProcessVirtualMemory.Location = New Point(0, 30)
        UiRoundProcessVirtualMemory.MinimumSize = New Size(1, 1)
        UiRoundProcessVirtualMemory.Name = "UiRoundProcessVirtualMemory"
        UiRoundProcessVirtualMemory.Outer = 40
        UiRoundProcessVirtualMemory.ProcessBackColor = Color.DimGray
        UiRoundProcessVirtualMemory.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessVirtualMemory.ShowProcess = True
        UiRoundProcessVirtualMemory.Size = New Size(160, 120)
        UiRoundProcessVirtualMemory.TabIndex = 1
        UiRoundProcessVirtualMemory.Text = "50%"
        UiRoundProcessVirtualMemory.Value = 50
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Dock = DockStyle.Top
        Label22.Location = New Point(0, 0)
        Label22.Name = "Label22"
        Label22.Padding = New Padding(10, 10, 0, 0)
        Label22.Size = New Size(75, 30)
        Label22.TabIndex = 0
        Label22.Text = "Virtual Used"
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Left
        Label21.Location = New Point(182, 20)
        Label21.Name = "Label21"
        Label21.Size = New Size(10, 150)
        Label21.TabIndex = 2
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel18.Controls.Add(UiRoundProcessPhysicalMemory)
        Panel18.Controls.Add(Label20)
        Panel18.Dock = DockStyle.Left
        Panel18.Location = New Point(20, 20)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(162, 150)
        Panel18.TabIndex = 1
        ' 
        ' UiRoundProcessPhysicalMemory
        ' 
        UiRoundProcessPhysicalMemory.DecimalPlaces = 0
        UiRoundProcessPhysicalMemory.Dock = DockStyle.Fill
        UiRoundProcessPhysicalMemory.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessPhysicalMemory.ForeColor = Color.Silver
        UiRoundProcessPhysicalMemory.ForeColor2 = Color.Black
        UiRoundProcessPhysicalMemory.Location = New Point(0, 30)
        UiRoundProcessPhysicalMemory.MinimumSize = New Size(1, 1)
        UiRoundProcessPhysicalMemory.Name = "UiRoundProcessPhysicalMemory"
        UiRoundProcessPhysicalMemory.Outer = 40
        UiRoundProcessPhysicalMemory.ProcessBackColor = Color.DimGray
        UiRoundProcessPhysicalMemory.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessPhysicalMemory.ShowProcess = True
        UiRoundProcessPhysicalMemory.Size = New Size(162, 120)
        UiRoundProcessPhysicalMemory.TabIndex = 1
        UiRoundProcessPhysicalMemory.Text = "50%"
        UiRoundProcessPhysicalMemory.Value = 50
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Dock = DockStyle.Top
        Label20.Location = New Point(0, 0)
        Label20.Name = "Label20"
        Label20.Padding = New Padding(10, 10, 0, 0)
        Label20.Size = New Size(75, 30)
        Label20.TabIndex = 0
        Label20.Text = "Physical Used"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Top
        Label19.Font = New Font("Segoe UI", 13F)
        Label19.Location = New Point(0, 0)
        Label19.Name = "Label19"
        Label19.Padding = New Padding(16, 20, 0, 0)
        Label19.Size = New Size(201, 44)
        Label19.TabIndex = 127
        Label19.Text = "CPU Logical Core && Memory"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Panel9)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(LinkLabel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(352, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(681, 601)
        Panel3.TabIndex = 84
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Top
        Label7.Location = New Point(0, 399)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(16, 0, 0, 0)
        Label7.Size = New Size(34, 20)
        Label7.TabIndex = 132
        Label7.Text = "..."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(0, 369)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(16, 0, 0, 10)
        Label1.Size = New Size(235, 30)
        Label1.TabIndex = 131
        Label1.Text = "The following are sensors not included on the dashboard"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Panel14)
        Panel9.Controls.Add(Label18)
        Panel9.Controls.Add(Panel10)
        Panel9.Controls.Add(Label11)
        Panel9.Controls.Add(Panel11)
        Panel9.Controls.Add(Label13)
        Panel9.Controls.Add(Panel12)
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(Panel13)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 224)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(20, 0, 20, 20)
        Panel9.Size = New Size(681, 145)
        Panel9.TabIndex = 130
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel14.Controls.Add(UiRoundProcessPowerConsumption)
        Panel14.Controls.Add(Label17)
        Panel14.Dock = DockStyle.Left
        Panel14.Location = New Point(532, 0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(118, 125)
        Panel14.TabIndex = 8
        ' 
        ' UiRoundProcessPowerConsumption
        ' 
        UiRoundProcessPowerConsumption.DecimalPlaces = 0
        UiRoundProcessPowerConsumption.Dock = DockStyle.Fill
        UiRoundProcessPowerConsumption.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        UiRoundProcessPowerConsumption.ForeColor = Color.Silver
        UiRoundProcessPowerConsumption.ForeColor2 = Color.Black
        UiRoundProcessPowerConsumption.Inner = 25
        UiRoundProcessPowerConsumption.Location = New Point(0, 30)
        UiRoundProcessPowerConsumption.MinimumSize = New Size(1, 1)
        UiRoundProcessPowerConsumption.Name = "UiRoundProcessPowerConsumption"
        UiRoundProcessPowerConsumption.Outer = 30
        UiRoundProcessPowerConsumption.ProcessBackColor = Color.DimGray
        UiRoundProcessPowerConsumption.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessPowerConsumption.ShowProcess = True
        UiRoundProcessPowerConsumption.Size = New Size(118, 95)
        UiRoundProcessPowerConsumption.TabIndex = 1
        UiRoundProcessPowerConsumption.Text = "50%"
        UiRoundProcessPowerConsumption.Value = 50
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Top
        Label17.Location = New Point(0, 0)
        Label17.Name = "Label17"
        Label17.Padding = New Padding(10, 10, 0, 0)
        Label17.Size = New Size(47, 30)
        Label17.TabIndex = 0
        Label17.Text = "Power"
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Location = New Point(522, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(10, 125)
        Label18.TabIndex = 7
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel10.Controls.Add(UiRoundProcessFanSpeed)
        Panel10.Controls.Add(Label10)
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(404, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(118, 125)
        Panel10.TabIndex = 6
        ' 
        ' UiRoundProcessFanSpeed
        ' 
        UiRoundProcessFanSpeed.DecimalPlaces = 0
        UiRoundProcessFanSpeed.Dock = DockStyle.Fill
        UiRoundProcessFanSpeed.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        UiRoundProcessFanSpeed.ForeColor = Color.Silver
        UiRoundProcessFanSpeed.ForeColor2 = Color.Black
        UiRoundProcessFanSpeed.Inner = 25
        UiRoundProcessFanSpeed.Location = New Point(0, 30)
        UiRoundProcessFanSpeed.MinimumSize = New Size(1, 1)
        UiRoundProcessFanSpeed.Name = "UiRoundProcessFanSpeed"
        UiRoundProcessFanSpeed.Outer = 30
        UiRoundProcessFanSpeed.ProcessBackColor = Color.DimGray
        UiRoundProcessFanSpeed.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessFanSpeed.ShowProcess = True
        UiRoundProcessFanSpeed.Size = New Size(118, 95)
        UiRoundProcessFanSpeed.TabIndex = 1
        UiRoundProcessFanSpeed.Text = "50%"
        UiRoundProcessFanSpeed.Value = 50
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Top
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(10, 10, 0, 0)
        Label10.Size = New Size(47, 30)
        Label10.TabIndex = 0
        Label10.Text = "Fan"
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Left
        Label11.Location = New Point(394, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(10, 125)
        Label11.TabIndex = 5
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel11.Controls.Add(UiRoundProcessTemperature)
        Panel11.Controls.Add(Label12)
        Panel11.Dock = DockStyle.Left
        Panel11.Location = New Point(276, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(118, 125)
        Panel11.TabIndex = 4
        ' 
        ' UiRoundProcessTemperature
        ' 
        UiRoundProcessTemperature.DecimalPlaces = 0
        UiRoundProcessTemperature.Dock = DockStyle.Fill
        UiRoundProcessTemperature.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        UiRoundProcessTemperature.ForeColor = Color.Silver
        UiRoundProcessTemperature.ForeColor2 = Color.Black
        UiRoundProcessTemperature.Inner = 25
        UiRoundProcessTemperature.Location = New Point(0, 30)
        UiRoundProcessTemperature.MinimumSize = New Size(1, 1)
        UiRoundProcessTemperature.Name = "UiRoundProcessTemperature"
        UiRoundProcessTemperature.Outer = 30
        UiRoundProcessTemperature.ProcessBackColor = Color.DimGray
        UiRoundProcessTemperature.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessTemperature.ShowProcess = True
        UiRoundProcessTemperature.Size = New Size(118, 95)
        UiRoundProcessTemperature.TabIndex = 1
        UiRoundProcessTemperature.Text = "50%"
        UiRoundProcessTemperature.Value = 50
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Top
        Label12.Location = New Point(0, 0)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(10, 10, 0, 0)
        Label12.Size = New Size(47, 30)
        Label12.TabIndex = 0
        Label12.Text = "Temp"
        ' 
        ' Label13
        ' 
        Label13.Dock = DockStyle.Left
        Label13.Location = New Point(266, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(10, 125)
        Label13.TabIndex = 3
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel12.Controls.Add(UiRoundProcessCopy)
        Panel12.Controls.Add(Label14)
        Panel12.Dock = DockStyle.Left
        Panel12.Location = New Point(148, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(118, 125)
        Panel12.TabIndex = 2
        ' 
        ' UiRoundProcessCopy
        ' 
        UiRoundProcessCopy.DecimalPlaces = 0
        UiRoundProcessCopy.Dock = DockStyle.Fill
        UiRoundProcessCopy.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        UiRoundProcessCopy.ForeColor = Color.Silver
        UiRoundProcessCopy.ForeColor2 = Color.Black
        UiRoundProcessCopy.Inner = 25
        UiRoundProcessCopy.Location = New Point(0, 30)
        UiRoundProcessCopy.MinimumSize = New Size(1, 1)
        UiRoundProcessCopy.Name = "UiRoundProcessCopy"
        UiRoundProcessCopy.Outer = 30
        UiRoundProcessCopy.ProcessBackColor = Color.DimGray
        UiRoundProcessCopy.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessCopy.ShowProcess = True
        UiRoundProcessCopy.Size = New Size(118, 95)
        UiRoundProcessCopy.TabIndex = 1
        UiRoundProcessCopy.Text = "50%"
        UiRoundProcessCopy.Value = 50
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Top
        Label14.Location = New Point(0, 0)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(10, 10, 0, 0)
        Label14.Size = New Size(53, 30)
        Label14.TabIndex = 0
        Label14.Text = "Copy"
        ' 
        ' Label15
        ' 
        Label15.Dock = DockStyle.Left
        Label15.Location = New Point(138, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(10, 125)
        Label15.TabIndex = 1
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel13.Controls.Add(UiRoundProcess3D)
        Panel13.Controls.Add(Label16)
        Panel13.Dock = DockStyle.Left
        Panel13.Location = New Point(20, 0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(118, 125)
        Panel13.TabIndex = 0
        ' 
        ' UiRoundProcess3D
        ' 
        UiRoundProcess3D.DecimalPlaces = 0
        UiRoundProcess3D.Dock = DockStyle.Fill
        UiRoundProcess3D.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        UiRoundProcess3D.ForeColor = Color.Silver
        UiRoundProcess3D.ForeColor2 = Color.Black
        UiRoundProcess3D.Inner = 25
        UiRoundProcess3D.Location = New Point(0, 30)
        UiRoundProcess3D.MinimumSize = New Size(1, 1)
        UiRoundProcess3D.Name = "UiRoundProcess3D"
        UiRoundProcess3D.Outer = 30
        UiRoundProcess3D.ProcessBackColor = Color.DimGray
        UiRoundProcess3D.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcess3D.ShowProcess = True
        UiRoundProcess3D.Size = New Size(118, 95)
        UiRoundProcess3D.TabIndex = 1
        UiRoundProcess3D.Text = "50%"
        UiRoundProcess3D.Value = 50
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Top
        Label16.Location = New Point(0, 0)
        Label16.Name = "Label16"
        Label16.Padding = New Padding(10, 10, 0, 0)
        Label16.Size = New Size(38, 30)
        Label16.TabIndex = 0
        Label16.Text = "3D"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel8)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Panel5)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 44)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20, 20, 20, 10)
        Panel4.Size = New Size(681, 180)
        Panel4.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel8.Controls.Add(UiRoundProcessVideoMemory)
        Panel8.Controls.Add(Label8)
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(500, 20)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(150, 150)
        Panel8.TabIndex = 6
        ' 
        ' UiRoundProcessVideoMemory
        ' 
        UiRoundProcessVideoMemory.DecimalPlaces = 0
        UiRoundProcessVideoMemory.Dock = DockStyle.Fill
        UiRoundProcessVideoMemory.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessVideoMemory.ForeColor = Color.Silver
        UiRoundProcessVideoMemory.ForeColor2 = Color.Black
        UiRoundProcessVideoMemory.Location = New Point(0, 30)
        UiRoundProcessVideoMemory.MinimumSize = New Size(1, 1)
        UiRoundProcessVideoMemory.Name = "UiRoundProcessVideoMemory"
        UiRoundProcessVideoMemory.Outer = 40
        UiRoundProcessVideoMemory.ProcessBackColor = Color.DimGray
        UiRoundProcessVideoMemory.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessVideoMemory.ShowProcess = True
        UiRoundProcessVideoMemory.Size = New Size(150, 120)
        UiRoundProcessVideoMemory.TabIndex = 1
        UiRoundProcessVideoMemory.Text = "50%"
        UiRoundProcessVideoMemory.Value = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Top
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(10, 10, 0, 0)
        Label8.Size = New Size(47, 30)
        Label8.TabIndex = 0
        Label8.Text = "VRAM"
        ' 
        ' Label9
        ' 
        Label9.Dock = DockStyle.Left
        Label9.Location = New Point(490, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(10, 150)
        Label9.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel7.Controls.Add(UiRoundProcessPcieBandwidth)
        Panel7.Controls.Add(Label5)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(340, 20)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(150, 150)
        Panel7.TabIndex = 4
        ' 
        ' UiRoundProcessPcieBandwidth
        ' 
        UiRoundProcessPcieBandwidth.DecimalPlaces = 0
        UiRoundProcessPcieBandwidth.Dock = DockStyle.Fill
        UiRoundProcessPcieBandwidth.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessPcieBandwidth.ForeColor = Color.Silver
        UiRoundProcessPcieBandwidth.ForeColor2 = Color.Black
        UiRoundProcessPcieBandwidth.Location = New Point(0, 30)
        UiRoundProcessPcieBandwidth.MinimumSize = New Size(1, 1)
        UiRoundProcessPcieBandwidth.Name = "UiRoundProcessPcieBandwidth"
        UiRoundProcessPcieBandwidth.Outer = 40
        UiRoundProcessPcieBandwidth.ProcessBackColor = Color.DimGray
        UiRoundProcessPcieBandwidth.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessPcieBandwidth.ShowProcess = True
        UiRoundProcessPcieBandwidth.Size = New Size(150, 120)
        UiRoundProcessPcieBandwidth.TabIndex = 1
        UiRoundProcessPcieBandwidth.Text = "50%"
        UiRoundProcessPcieBandwidth.Value = 50
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Top
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(10, 10, 0, 0)
        Label5.Size = New Size(81, 30)
        Label5.TabIndex = 0
        Label5.Text = "PCIe Bandwidth"
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Left
        Label6.Location = New Point(330, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(10, 150)
        Label6.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel6.Controls.Add(UiRoundProcessEncodingCore)
        Panel6.Controls.Add(Label4)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(180, 20)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(150, 150)
        Panel6.TabIndex = 2
        ' 
        ' UiRoundProcessEncodingCore
        ' 
        UiRoundProcessEncodingCore.DecimalPlaces = 0
        UiRoundProcessEncodingCore.Dock = DockStyle.Fill
        UiRoundProcessEncodingCore.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessEncodingCore.ForeColor = Color.Silver
        UiRoundProcessEncodingCore.ForeColor2 = Color.Black
        UiRoundProcessEncodingCore.Location = New Point(0, 30)
        UiRoundProcessEncodingCore.MinimumSize = New Size(1, 1)
        UiRoundProcessEncodingCore.Name = "UiRoundProcessEncodingCore"
        UiRoundProcessEncodingCore.Outer = 40
        UiRoundProcessEncodingCore.ProcessBackColor = Color.DimGray
        UiRoundProcessEncodingCore.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessEncodingCore.ShowProcess = True
        UiRoundProcessEncodingCore.Size = New Size(150, 120)
        UiRoundProcessEncodingCore.TabIndex = 1
        UiRoundProcessEncodingCore.Text = "50%"
        UiRoundProcessEncodingCore.Value = 50
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Top
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(10, 10, 0, 0)
        Label4.Size = New Size(75, 30)
        Label4.TabIndex = 0
        Label4.Text = "Encoding Core"
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Location = New Point(170, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 150)
        Label3.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel5.Controls.Add(UiRoundProcessDecodingCore)
        Panel5.Controls.Add(Label2)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(20, 20)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(150, 150)
        Panel5.TabIndex = 0
        ' 
        ' UiRoundProcessDecodingCore
        ' 
        UiRoundProcessDecodingCore.DecimalPlaces = 0
        UiRoundProcessDecodingCore.Dock = DockStyle.Fill
        UiRoundProcessDecodingCore.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        UiRoundProcessDecodingCore.ForeColor = Color.Silver
        UiRoundProcessDecodingCore.ForeColor2 = Color.Black
        UiRoundProcessDecodingCore.Location = New Point(0, 30)
        UiRoundProcessDecodingCore.MinimumSize = New Size(1, 1)
        UiRoundProcessDecodingCore.Name = "UiRoundProcessDecodingCore"
        UiRoundProcessDecodingCore.Outer = 40
        UiRoundProcessDecodingCore.ProcessBackColor = Color.DimGray
        UiRoundProcessDecodingCore.ProcessColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRoundProcessDecodingCore.ShowProcess = True
        UiRoundProcessDecodingCore.Size = New Size(150, 120)
        UiRoundProcessDecodingCore.TabIndex = 1
        UiRoundProcessDecodingCore.Text = "50%"
        UiRoundProcessDecodingCore.Value = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10, 10, 0, 0)
        Label2.Size = New Size(75, 30)
        Label2.TabIndex = 0
        Label2.Text = "Decoding Core"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.MediumOrchid
        LinkLabel1.AutoSize = True
        LinkLabel1.Dock = DockStyle.Top
        LinkLabel1.Font = New Font("Segoe UI", 13F)
        LinkLabel1.LinkColor = Color.CornflowerBlue
        LinkLabel1.Location = New Point(0, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Padding = New Padding(16, 20, 0, 0)
        LinkLabel1.Size = New Size(383, 44)
        LinkLabel1.TabIndex = 127
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "NVIDIA RTX Pro Max Ultra 9000 Ti 1024G"
        ' 
        ' PerformancePage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        Name = "PerformancePage"
        Size = New Size(1033, 651)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel19.ResumeLayout(False)
        Panel19.PerformLayout()
        Panel18.ResumeLayout(False)
        Panel18.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UiRoundProcessDecodingCore As Sunny.UI.UIRoundProcess
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents UiRoundProcessEncodingCore As Sunny.UI.UIRoundProcess
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents UiRoundProcessVideoMemory As Sunny.UI.UIRoundProcess
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UiRoundProcessPcieBandwidth As Sunny.UI.UIRoundProcess
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents UiRoundProcessFanSpeed As Sunny.UI.UIRoundProcess
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents UiRoundProcessTemperature As Sunny.UI.UIRoundProcess
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents UiRoundProcessCopy As Sunny.UI.UIRoundProcess
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents UiRoundProcess3D As Sunny.UI.UIRoundProcess
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents UiRoundProcessPowerConsumption As Sunny.UI.UIRoundProcess
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents UiRoundProcessPhysicalMemory As Sunny.UI.UIRoundProcess
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents UiRoundProcessVirtualMemory As Sunny.UI.UIRoundProcess
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label

End Class








