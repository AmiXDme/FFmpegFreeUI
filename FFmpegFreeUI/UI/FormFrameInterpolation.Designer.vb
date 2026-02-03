<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFrameInterpolation
    Inherits System.Windows.Forms.Form

    'Form Override Dispose to clean up the component list.
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
        Label62 = New Label()
        Panel8 = New Panel()
        Panel11 = New Panel()
        Label13 = New Label()
        UiTextBoxTargetFrameRate = New Sunny.UI.UITextBox()
        Label1 = New Label()
        Label124 = New Label()
        Panel73 = New Panel()
        Label123 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        UiComboBoxMotionEstimationAlgorithm = New Sunny.UI.UIComboBox()
        Label3 = New Label()
        UiComboBoxMotionEstimationMode = New Sunny.UI.UIComboBox()
        Label4 = New Label()
        UiComboBoxFrameInterpolationMode = New Sunny.UI.UIComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        UiCheckBoxVariableBlockSizeMotionCompensation = New Sunny.UI.UICheckBox()
        Label12 = New Label()
        UiComboBoxMotionCompensationMode = New Sunny.UI.UIComboBox()
        Label9 = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        UiTextBoxSearchRange = New Sunny.UI.UITextBox()
        Label10 = New Label()
        UiTextBoxBlockSize = New Sunny.UI.UITextBox()
        Panel78 = New Panel()
        Label134 = New Label()
        Label135 = New Label()
        Label8 = New Label()
        Panel7 = New Panel()
        Panel9 = New Panel()
        Label15 = New Label()
        UiTextBoxSceneChangeDetectionStrength = New Sunny.UI.UITextBox()
        Label11 = New Label()
        Panel8.SuspendLayout()
        Panel11.SuspendLayout()
        Panel73.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel78.SuspendLayout()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label62
        ' 
        Label62.Dock = DockStyle.Top
        Label62.Location = New Point(10, 128)
        Label62.Name = "Label62"
        Label62.Size = New Size(714, 10)
        Label62.TabIndex = 68
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel8.Controls.Add(Panel11)
        Panel8.Controls.Add(Label1)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 78)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(714, 50)
        Panel8.TabIndex = 67
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Label13)
        Panel11.Controls.Add(UiTextBoxTargetFrameRate)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(100, 0)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10, 10, 0, 10)
        Panel11.Size = New Size(614, 50)
        Panel11.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.Dock = DockStyle.Fill
        Label13.ForeColor = Color.Gray
        Label13.Location = New Point(185, 10)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(10, 0, 0, 0)
        Label13.Size = New Size(429, 30)
        Label13.TabIndex = 98
        Label13.Text = "Target Frame Rate or Interpolation Mode blank to cancel using this filter"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxTargetFrameRate
        ' 
        UiTextBoxTargetFrameRate.Dock = DockStyle.Left
        UiTextBoxTargetFrameRate.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxTargetFrameRate.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxTargetFrameRate.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxTargetFrameRate.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxTargetFrameRate.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxTargetFrameRate.ForeColor = Color.DarkGray
        UiTextBoxTargetFrameRate.ForeDisableColor = Color.DarkGray
        UiTextBoxTargetFrameRate.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxTargetFrameRate.Location = New Point(10, 10)
        UiTextBoxTargetFrameRate.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxTargetFrameRate.MinimumSize = New Size(1, 16)
        UiTextBoxTargetFrameRate.Name = "UiTextBoxTargetFrameRate"
        UiTextBoxTargetFrameRate.Padding = New Padding(5)
        UiTextBoxTargetFrameRate.Radius = 30
        UiTextBoxTargetFrameRate.RectColor = Color.DimGray
        UiTextBoxTargetFrameRate.RectDisableColor = Color.DimGray
        UiTextBoxTargetFrameRate.RectReadOnlyColor = Color.DimGray
        UiTextBoxTargetFrameRate.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxTargetFrameRate.ScrollBarColor = Color.DimGray
        UiTextBoxTargetFrameRate.ScrollBarStyleInherited = False
        UiTextBoxTargetFrameRate.ShowText = False
        UiTextBoxTargetFrameRate.Size = New Size(175, 30)
        UiTextBoxTargetFrameRate.TabIndex = 97
        UiTextBoxTargetFrameRate.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxTargetFrameRate.Watermark = "Target Frame Rate"
        UiTextBoxTargetFrameRate.WatermarkActiveColor = Color.DimGray
        UiTextBoxTargetFrameRate.WatermarkColor = Color.DimGray
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 50)
        Label1.TabIndex = 4
        Label1.Text = "Target Frame Rate"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label124
        ' 
        Label124.Dock = DockStyle.Top
        Label124.Location = New Point(10, 68)
        Label124.Name = "Label124"
        Label124.Size = New Size(714, 10)
        Label124.TabIndex = 82
        ' 
        ' Panel73
        ' 
        Panel73.AutoSize = True
        Panel73.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel73.Controls.Add(Label123)
        Panel73.Dock = DockStyle.Top
        Panel73.Location = New Point(10, 10)
        Panel73.Name = "Panel73"
        Panel73.Padding = New Padding(10)
        Panel73.Size = New Size(714, 58)
        Panel73.TabIndex = 81
        ' 
        ' Label123
        ' 
        Label123.AutoSize = True
        Label123.Dock = DockStyle.Top
        Label123.Font = New Font("Segoe UI", 9.75F)
        Label123.ForeColor = Color.Gray
        Label123.Location = New Point(10, 10)
        Label123.Name = "Label123"
        Label123.Size = New Size(468, 38)
        Label123.TabIndex = 4
        Label123.Text = "minterpolate provides basic results but is fast and stable. Decimation also uses this filter." & vbCrLf & "Consider AI software: SVP, SVFI, Topaz Video AI."
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(10, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(714, 10)
        Label2.TabIndex = 84
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(10, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(714, 50)
        Panel1.TabIndex = 83
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UiComboBoxMotionEstimationAlgorithm)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(UiComboBoxMotionEstimationMode)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(UiComboBoxFrameInterpolationMode)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(100, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(614, 50)
        Panel2.TabIndex = 2
        ' 
        ' UiComboBoxMotionEstimationAlgorithm
        ' 
        UiComboBoxMotionEstimationAlgorithm.DataSource = Nothing
        UiComboBoxMotionEstimationAlgorithm.Dock = DockStyle.Left
        UiComboBoxMotionEstimationAlgorithm.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMotionEstimationAlgorithm.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationAlgorithm.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationAlgorithm.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationAlgorithm.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxMotionEstimationAlgorithm.ForeColor = Color.Silver
        UiComboBoxMotionEstimationAlgorithm.ForeDisableColor = Color.Silver
        UiComboBoxMotionEstimationAlgorithm.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationAlgorithm.ItemForeColor = Color.Silver
        UiComboBoxMotionEstimationAlgorithm.ItemHeight = 28
        UiComboBoxMotionEstimationAlgorithm.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMotionEstimationAlgorithm.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMotionEstimationAlgorithm.Items.AddRange(New Object() {"", "Exhaustive Search", "Three Step Search", "2D Logarithmic Search", "New Three Step Search", "Four Step Search", "Diamond Search", "Hexagon Based", "Enhanced Predictive Area", "Uneven Multi-Hexagon"})
        UiComboBoxMotionEstimationAlgorithm.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationAlgorithm.ItemSelectForeColor = Color.Silver
        UiComboBoxMotionEstimationAlgorithm.Location = New Point(380, 10)
        UiComboBoxMotionEstimationAlgorithm.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMotionEstimationAlgorithm.MaxDropDownItems = 17
        UiComboBoxMotionEstimationAlgorithm.MinimumSize = New Size(63, 0)
        UiComboBoxMotionEstimationAlgorithm.Name = "UiComboBoxMotionEstimationAlgorithm"
        UiComboBoxMotionEstimationAlgorithm.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMotionEstimationAlgorithm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMotionEstimationAlgorithm.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationAlgorithm.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationAlgorithm.ScrollBarHandleWidth = 20
        UiComboBoxMotionEstimationAlgorithm.Size = New Size(175, 30)
        UiComboBoxMotionEstimationAlgorithm.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMotionEstimationAlgorithm.SymbolSize = 24
        UiComboBoxMotionEstimationAlgorithm.TabIndex = 86
        UiComboBoxMotionEstimationAlgorithm.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMotionEstimationAlgorithm.Watermark = "Motion Estimation Algorithm"
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Location = New Point(370, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 30)
        Label3.TabIndex = 85
        ' 
        ' UiComboBoxMotionEstimationMode
        ' 
        UiComboBoxMotionEstimationMode.DataSource = Nothing
        UiComboBoxMotionEstimationMode.Dock = DockStyle.Left
        UiComboBoxMotionEstimationMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMotionEstimationMode.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationMode.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationMode.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationMode.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxMotionEstimationMode.ForeColor = Color.Silver
        UiComboBoxMotionEstimationMode.ForeDisableColor = Color.Silver
        UiComboBoxMotionEstimationMode.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionEstimationMode.ItemForeColor = Color.Silver
        UiComboBoxMotionEstimationMode.ItemHeight = 28
        UiComboBoxMotionEstimationMode.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMotionEstimationMode.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMotionEstimationMode.Items.AddRange(New Object() {"", "Bidirectional Motion Estimation", "Bilateral Motion Estimation"})
        UiComboBoxMotionEstimationMode.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationMode.ItemSelectForeColor = Color.Silver
        UiComboBoxMotionEstimationMode.Location = New Point(195, 10)
        UiComboBoxMotionEstimationMode.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMotionEstimationMode.MaxDropDownItems = 17
        UiComboBoxMotionEstimationMode.MinimumSize = New Size(63, 0)
        UiComboBoxMotionEstimationMode.Name = "UiComboBoxMotionEstimationMode"
        UiComboBoxMotionEstimationMode.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMotionEstimationMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMotionEstimationMode.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationMode.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionEstimationMode.ScrollBarHandleWidth = 20
        UiComboBoxMotionEstimationMode.Size = New Size(175, 30)
        UiComboBoxMotionEstimationMode.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMotionEstimationMode.SymbolSize = 24
        UiComboBoxMotionEstimationMode.TabIndex = 84
        UiComboBoxMotionEstimationMode.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMotionEstimationMode.Watermark = "Motion Estimation Mode"
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Location = New Point(185, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(10, 30)
        Label4.TabIndex = 83
        ' 
        ' UiComboBoxFrameInterpolationMode
        ' 
        UiComboBoxFrameInterpolationMode.DataSource = Nothing
        UiComboBoxFrameInterpolationMode.Dock = DockStyle.Left
        UiComboBoxFrameInterpolationMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxFrameInterpolationMode.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameInterpolationMode.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameInterpolationMode.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameInterpolationMode.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxFrameInterpolationMode.ForeColor = Color.Silver
        UiComboBoxFrameInterpolationMode.ForeDisableColor = Color.Silver
        UiComboBoxFrameInterpolationMode.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameInterpolationMode.ItemForeColor = Color.Silver
        UiComboBoxFrameInterpolationMode.ItemHeight = 28
        UiComboBoxFrameInterpolationMode.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxFrameInterpolationMode.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxFrameInterpolationMode.Items.AddRange(New Object() {"", "Two-Frame Weighted Average", "Motion Compensation Interpolation"})
        UiComboBoxFrameInterpolationMode.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameInterpolationMode.ItemSelectForeColor = Color.Silver
        UiComboBoxFrameInterpolationMode.Location = New Point(10, 10)
        UiComboBoxFrameInterpolationMode.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxFrameInterpolationMode.MaxDropDownItems = 17
        UiComboBoxFrameInterpolationMode.MinimumSize = New Size(63, 0)
        UiComboBoxFrameInterpolationMode.Name = "UiComboBoxFrameInterpolationMode"
        UiComboBoxFrameInterpolationMode.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxFrameInterpolationMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxFrameInterpolationMode.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameInterpolationMode.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameInterpolationMode.ScrollBarHandleWidth = 20
        UiComboBoxFrameInterpolationMode.Size = New Size(175, 30)
        UiComboBoxFrameInterpolationMode.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxFrameInterpolationMode.SymbolSize = 24
        UiComboBoxFrameInterpolationMode.TabIndex = 87
        UiComboBoxFrameInterpolationMode.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxFrameInterpolationMode.Watermark = "Interpolation Mode"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 50)
        Label5.TabIndex = 4
        Label5.Text = "Algorithm Mode"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Top
        Label6.Location = New Point(10, 248)
        Label6.Name = "Label6"
        Label6.Size = New Size(714, 10)
        Label6.TabIndex = 86
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label9)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(10, 198)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(714, 50)
        Panel3.TabIndex = 85
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(UiCheckBoxVariableBlockSizeMotionCompensation)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(UiComboBoxMotionCompensationMode)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(100, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10, 10, 0, 10)
        Panel4.Size = New Size(614, 50)
        Panel4.TabIndex = 2
        ' 
        ' UiCheckBoxVariableBlockSizeMotionCompensation
        ' 
        UiCheckBoxVariableBlockSizeMotionCompensation.CheckBoxColor = Color.Silver
        UiCheckBoxVariableBlockSizeMotionCompensation.CheckBoxSize = 20
        UiCheckBoxVariableBlockSizeMotionCompensation.Dock = DockStyle.Left
        UiCheckBoxVariableBlockSizeMotionCompensation.Font = New Font("Segoe UI", 9.75F)
        UiCheckBoxVariableBlockSizeMotionCompensation.ForeColor = Color.Silver
        UiCheckBoxVariableBlockSizeMotionCompensation.Location = New Point(195, 10)
        UiCheckBoxVariableBlockSizeMotionCompensation.MinimumSize = New Size(1, 1)
        UiCheckBoxVariableBlockSizeMotionCompensation.Name = "UiCheckBoxVariableBlockSizeMotionCompensation"
        UiCheckBoxVariableBlockSizeMotionCompensation.Size = New Size(175, 30)
        UiCheckBoxVariableBlockSizeMotionCompensation.TabIndex = 100
        UiCheckBoxVariableBlockSizeMotionCompensation.Text = "Variable Block Size Motion Compensation"
        ' 
        ' Label12
        ' 
        Label12.Dock = DockStyle.Left
        Label12.Location = New Point(185, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(10, 30)
        Label12.TabIndex = 84
        ' 
        ' UiComboBoxMotionCompensationMode
        ' 
        UiComboBoxMotionCompensationMode.DataSource = Nothing
        UiComboBoxMotionCompensationMode.Dock = DockStyle.Left
        UiComboBoxMotionCompensationMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMotionCompensationMode.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionCompensationMode.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionCompensationMode.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionCompensationMode.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxMotionCompensationMode.ForeColor = Color.Silver
        UiComboBoxMotionCompensationMode.ForeDisableColor = Color.Silver
        UiComboBoxMotionCompensationMode.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMotionCompensationMode.ItemForeColor = Color.Silver
        UiComboBoxMotionCompensationMode.ItemHeight = 28
        UiComboBoxMotionCompensationMode.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMotionCompensationMode.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMotionCompensationMode.Items.AddRange(New Object() {"", "Overlapped Block Motion Compensation", "Weighted OBMC"})
        UiComboBoxMotionCompensationMode.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionCompensationMode.ItemSelectForeColor = Color.Silver
        UiComboBoxMotionCompensationMode.Location = New Point(10, 10)
        UiComboBoxMotionCompensationMode.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMotionCompensationMode.MaxDropDownItems = 17
        UiComboBoxMotionCompensationMode.MinimumSize = New Size(63, 0)
        UiComboBoxMotionCompensationMode.Name = "UiComboBoxMotionCompensationMode"
        UiComboBoxMotionCompensationMode.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMotionCompensationMode.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMotionCompensationMode.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionCompensationMode.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMotionCompensationMode.ScrollBarHandleWidth = 20
        UiComboBoxMotionCompensationMode.Size = New Size(175, 30)
        UiComboBoxMotionCompensationMode.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMotionCompensationMode.SymbolSize = 24
        UiComboBoxMotionCompensationMode.TabIndex = 82
        UiComboBoxMotionCompensationMode.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMotionCompensationMode.Watermark = "Motion Compensation Mode"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label9.Dock = DockStyle.Left
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 50)
        Label9.TabIndex = 4
        Label9.Text = "Compensation Mode"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Top
        Label7.Location = New Point(10, 333)
        Label7.Name = "Label7"
        Label7.Size = New Size(714, 10)
        Label7.TabIndex = 88
        ' 
        ' Panel5
        ' 
        Panel5.AutoSize = True
        Panel5.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Panel78)
        Panel5.Controls.Add(Label8)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(10, 258)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(714, 75)
        Panel5.TabIndex = 87
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(UiTextBoxSearchRange)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(UiTextBoxBlockSize)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(100, 35)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10, 0, 0, 10)
        Panel6.Size = New Size(614, 40)
        Panel6.TabIndex = 2
        ' 
        ' UiTextBoxSearchRange
        ' 
        UiTextBoxSearchRange.Dock = DockStyle.Left
        UiTextBoxSearchRange.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSearchRange.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSearchRange.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSearchRange.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSearchRange.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxSearchRange.ForeColor = Color.DarkGray
        UiTextBoxSearchRange.ForeDisableColor = Color.DarkGray
        UiTextBoxSearchRange.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSearchRange.Location = New Point(195, 0)
        UiTextBoxSearchRange.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSearchRange.MinimumSize = New Size(1, 16)
        UiTextBoxSearchRange.Name = "UiTextBoxSearchRange"
        UiTextBoxSearchRange.Padding = New Padding(5)
        UiTextBoxSearchRange.Radius = 30
        UiTextBoxSearchRange.RectColor = Color.DimGray
        UiTextBoxSearchRange.RectDisableColor = Color.DimGray
        UiTextBoxSearchRange.RectReadOnlyColor = Color.DimGray
        UiTextBoxSearchRange.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSearchRange.ScrollBarColor = Color.DimGray
        UiTextBoxSearchRange.ScrollBarStyleInherited = False
        UiTextBoxSearchRange.ShowText = False
        UiTextBoxSearchRange.Size = New Size(175, 30)
        UiTextBoxSearchRange.TabIndex = 100
        UiTextBoxSearchRange.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSearchRange.Watermark = "Default 32"
        UiTextBoxSearchRange.WatermarkActiveColor = Color.DimGray
        UiTextBoxSearchRange.WatermarkColor = Color.DimGray
        ' 
        ' Label10
        ' 
        Label10.Dock = DockStyle.Left
        Label10.Location = New Point(185, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(10, 30)
        Label10.TabIndex = 99
        ' 
        ' UiTextBoxBlockSize
        ' 
        UiTextBoxBlockSize.Dock = DockStyle.Left
        UiTextBoxBlockSize.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlockSize.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlockSize.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlockSize.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlockSize.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxBlockSize.ForeColor = Color.DarkGray
        UiTextBoxBlockSize.ForeDisableColor = Color.DarkGray
        UiTextBoxBlockSize.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxBlockSize.Location = New Point(10, 0)
        UiTextBoxBlockSize.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxBlockSize.MinimumSize = New Size(1, 16)
        UiTextBoxBlockSize.Name = "UiTextBoxBlockSize"
        UiTextBoxBlockSize.Padding = New Padding(5)
        UiTextBoxBlockSize.Radius = 30
        UiTextBoxBlockSize.RectColor = Color.DimGray
        UiTextBoxBlockSize.RectDisableColor = Color.DimGray
        UiTextBoxBlockSize.RectReadOnlyColor = Color.DimGray
        UiTextBoxBlockSize.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxBlockSize.ScrollBarColor = Color.DimGray
        UiTextBoxBlockSize.ScrollBarStyleInherited = False
        UiTextBoxBlockSize.ShowText = False
        UiTextBoxBlockSize.Size = New Size(175, 30)
        UiTextBoxBlockSize.TabIndex = 98
        UiTextBoxBlockSize.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxBlockSize.Watermark = "Default 16"
        UiTextBoxBlockSize.WatermarkActiveColor = Color.DimGray
        UiTextBoxBlockSize.WatermarkColor = Color.DimGray
        ' 
        ' Panel78
        ' 
        Panel78.Controls.Add(Label134)
        Panel78.Controls.Add(Label135)
        Panel78.Dock = DockStyle.Top
        Panel78.Location = New Point(100, 0)
        Panel78.Name = "Panel78"
        Panel78.Padding = New Padding(7, 0, 0, 0)
        Panel78.Size = New Size(614, 35)
        Panel78.TabIndex = 5
        ' 
        ' Label134
        ' 
        Label134.Dock = DockStyle.Left
        Label134.Font = New Font("Segoe UI", 9.75F)
        Label134.Location = New Point(192, 0)
        Label134.Name = "Label134"
        Label134.Size = New Size(185, 35)
        Label134.TabIndex = 79
        Label134.Text = "Search Range (pixels)"
        Label134.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label135
        ' 
        Label135.Dock = DockStyle.Left
        Label135.Font = New Font("Segoe UI", 9.75F)
        Label135.Location = New Point(7, 0)
        Label135.Name = "Label135"
        Label135.Size = New Size(185, 35)
        Label135.TabIndex = 73
        Label135.Text = "Block Size"
        Label135.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label8.Dock = DockStyle.Left
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 75)
        Label8.TabIndex = 4
        Label8.Text = "Identification"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel7.Controls.Add(Panel9)
        Panel7.Controls.Add(Label11)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(10, 343)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(714, 50)
        Panel7.TabIndex = 89
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(UiTextBoxSceneChangeDetectionStrength)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(100, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(10, 10, 0, 10)
        Panel9.Size = New Size(614, 50)
        Panel9.TabIndex = 2
        ' 
        ' Label15
        ' 
        Label15.Dock = DockStyle.Fill
        Label15.ForeColor = Color.Gray
        Label15.Location = New Point(185, 10)
        Label15.Name = "Label15"
        Label15.Padding = New Padding(10, 0, 0, 0)
        Label15.Size = New Size(429, 30)
        Label15.TabIndex = 105
        Label15.Text = "Leave blank to cancel using this parameter"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSceneChangeDetectionStrength
        ' 
        UiTextBoxSceneChangeDetectionStrength.Dock = DockStyle.Left
        UiTextBoxSceneChangeDetectionStrength.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSceneChangeDetectionStrength.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSceneChangeDetectionStrength.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSceneChangeDetectionStrength.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSceneChangeDetectionStrength.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxSceneChangeDetectionStrength.ForeColor = Color.DarkGray
        UiTextBoxSceneChangeDetectionStrength.ForeDisableColor = Color.DarkGray
        UiTextBoxSceneChangeDetectionStrength.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSceneChangeDetectionStrength.Location = New Point(10, 10)
        UiTextBoxSceneChangeDetectionStrength.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSceneChangeDetectionStrength.MinimumSize = New Size(1, 16)
        UiTextBoxSceneChangeDetectionStrength.Name = "UiTextBoxSceneChangeDetectionStrength"
        UiTextBoxSceneChangeDetectionStrength.Padding = New Padding(5)
        UiTextBoxSceneChangeDetectionStrength.Radius = 30
        UiTextBoxSceneChangeDetectionStrength.RectColor = Color.DimGray
        UiTextBoxSceneChangeDetectionStrength.RectDisableColor = Color.DimGray
        UiTextBoxSceneChangeDetectionStrength.RectReadOnlyColor = Color.DimGray
        UiTextBoxSceneChangeDetectionStrength.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSceneChangeDetectionStrength.ScrollBarColor = Color.DimGray
        UiTextBoxSceneChangeDetectionStrength.ScrollBarStyleInherited = False
        UiTextBoxSceneChangeDetectionStrength.ShowText = False
        UiTextBoxSceneChangeDetectionStrength.Size = New Size(175, 30)
        UiTextBoxSceneChangeDetectionStrength.TabIndex = 103
        UiTextBoxSceneChangeDetectionStrength.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSceneChangeDetectionStrength.Watermark = "Default 10"
        UiTextBoxSceneChangeDetectionStrength.WatermarkActiveColor = Color.DimGray
        UiTextBoxSceneChangeDetectionStrength.WatermarkColor = Color.DimGray
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label11.Dock = DockStyle.Left
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 50)
        Label11.TabIndex = 4
        Label11.Text = "Scene Change"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormFrameInterpolation
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(734, 401)
        Controls.Add(Panel7)
        Controls.Add(Label7)
        Controls.Add(Panel5)
        Controls.Add(Label6)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label62)
        Controls.Add(Panel8)
        Controls.Add(Label124)
        Controls.Add(Panel73)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Silver
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(750, 440)
        Name = "FormFrameInterpolation"
        Padding = New Padding(10)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "minterpolate Frame Interpolation"
        Panel8.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel78.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label62 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Panel73 As Panel
    Friend WithEvents Label123 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiComboBoxMotionEstimationAlgorithm As Sunny.UI.UIComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UiComboBoxMotionEstimationMode As Sunny.UI.UIComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiComboBoxMotionCompensationMode As Sunny.UI.UIComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents UiTextBoxTargetFrameRate As Sunny.UI.UITextBox
    Friend WithEvents UiCheckBoxVariableBlockSizeMotionCompensation As Sunny.UI.UICheckBox
    Friend WithEvents UiTextBoxSceneChangeDetectionStrength As Sunny.UI.UITextBox
    Friend WithEvents UiComboBoxFrameInterpolationMode As Sunny.UI.UIComboBox
    Friend WithEvents Panel78 As Panel
    Friend WithEvents Label134 As Label
    Friend WithEvents Label135 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents UiTextBoxSearchRange As Sunny.UI.UITextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UiTextBoxBlockSize As Sunny.UI.UITextBox
End Class









