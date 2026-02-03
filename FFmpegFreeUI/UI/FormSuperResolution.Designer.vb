<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuperResolution
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
        Panel73 = New Panel()
        Label123 = New Label()
        Panel8 = New Panel()
        Panel11 = New Panel()
        Label13 = New Label()
        UiTextBoxSuperResolutionHeight = New Sunny.UI.UITextBox()
        Label4 = New Label()
        UiTextBoxSuperResolutionWidth = New Sunny.UI.UITextBox()
        Label1 = New Label()
        Label124 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label8 = New Label()
        UiComboBoxDownsamplingAlgorithm = New Sunny.UI.UIComboBox()
        Label5 = New Label()
        UiComboBoxUpsamplingAlgorithm = New Sunny.UI.UIComboBox()
        Label6 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label7 = New Label()
        UiTextBoxAntiRingingStrength = New Sunny.UI.UITextBox()
        Label9 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel82 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel23 = New Panel()
        Label14 = New Label()
        UiButtonDownload = New Sunny.UI.UIButton()
        UiButtonMoveDownShader = New Sunny.UI.UIButton()
        Label12 = New Label()
        UiButtonMoveUpShader = New Sunny.UI.UIButton()
        Label82 = New Label()
        UiButtonRemoveShader = New Sunny.UI.UIButton()
        Label145 = New Label()
        UiButtonAddShader = New Sunny.UI.UIButton()
        Label10 = New Label()
        Label11 = New Label()
        Panel73.SuspendLayout()
        Panel8.SuspendLayout()
        Panel11.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel82.SuspendLayout()
        Panel23.SuspendLayout()
        SuspendLayout()
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
        Panel73.Size = New Size(664, 58)
        Panel73.TabIndex = 82
        ' 
        ' Label123
        ' 
        Label123.AutoSize = True
        Label123.Dock = DockStyle.Top
        Label123.Font = New Font("Segoe UI", 9.75F)
        Label123.ForeColor = Color.Gray
        Label123.Location = New Point(10, 10)
        Label123.Name = "Label123"
        Label123.Size = New Size(480, 38)
        Label123.TabIndex = 4
        Label123.Text = "libplacebo requires supported GPU; older graphics cards may not run." & vbCrLf & "Specify Resolution here directly; do not specify in the main Parameters Panel. You can use iw*2 and ih*2 for multiples."
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel8.Controls.Add(Panel11)
        Panel8.Controls.Add(Label1)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 78)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(664, 50)
        Panel8.TabIndex = 83
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Label13)
        Panel11.Controls.Add(UiTextBoxSuperResolutionHeight)
        Panel11.Controls.Add(Label4)
        Panel11.Controls.Add(UiTextBoxSuperResolutionWidth)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(100, 0)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10, 10, 0, 10)
        Panel11.Size = New Size(564, 50)
        Panel11.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.Dock = DockStyle.Fill
        Label13.ForeColor = Color.Gray
        Label13.Location = New Point(185, 10)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(10, 0, 0, 0)
        Label13.Size = New Size(379, 30)
        Label13.TabIndex = 98
        Label13.Text = "Leave either or both blank to cancel using this filter."
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSuperResolutionHeight
        ' 
        UiTextBoxSuperResolutionHeight.Dock = DockStyle.Left
        UiTextBoxSuperResolutionHeight.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionHeight.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionHeight.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionHeight.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionHeight.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxSuperResolutionHeight.ForeColor = Color.DarkGray
        UiTextBoxSuperResolutionHeight.ForeDisableColor = Color.DarkGray
        UiTextBoxSuperResolutionHeight.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSuperResolutionHeight.Location = New Point(102, 10)
        UiTextBoxSuperResolutionHeight.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSuperResolutionHeight.MinimumSize = New Size(1, 16)
        UiTextBoxSuperResolutionHeight.Name = "UiTextBoxSuperResolutionHeight"
        UiTextBoxSuperResolutionHeight.Padding = New Padding(5)
        UiTextBoxSuperResolutionHeight.Radius = 30
        UiTextBoxSuperResolutionHeight.RectColor = Color.DimGray
        UiTextBoxSuperResolutionHeight.RectDisableColor = Color.DimGray
        UiTextBoxSuperResolutionHeight.RectReadOnlyColor = Color.DimGray
        UiTextBoxSuperResolutionHeight.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSuperResolutionHeight.ScrollBarColor = Color.DimGray
        UiTextBoxSuperResolutionHeight.ScrollBarStyleInherited = False
        UiTextBoxSuperResolutionHeight.ShowText = False
        UiTextBoxSuperResolutionHeight.Size = New Size(83, 30)
        UiTextBoxSuperResolutionHeight.TabIndex = 99
        UiTextBoxSuperResolutionHeight.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSuperResolutionHeight.Watermark = "Height"
        UiTextBoxSuperResolutionHeight.WatermarkActiveColor = Color.DimGray
        UiTextBoxSuperResolutionHeight.WatermarkColor = Color.DimGray
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Location = New Point(93, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(9, 30)
        Label4.TabIndex = 100
        ' 
        ' UiTextBoxSuperResolutionWidth
        ' 
        UiTextBoxSuperResolutionWidth.Dock = DockStyle.Left
        UiTextBoxSuperResolutionWidth.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionWidth.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionWidth.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionWidth.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuperResolutionWidth.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxSuperResolutionWidth.ForeColor = Color.DarkGray
        UiTextBoxSuperResolutionWidth.ForeDisableColor = Color.DarkGray
        UiTextBoxSuperResolutionWidth.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSuperResolutionWidth.Location = New Point(10, 10)
        UiTextBoxSuperResolutionWidth.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSuperResolutionWidth.MinimumSize = New Size(1, 16)
        UiTextBoxSuperResolutionWidth.Name = "UiTextBoxSuperResolutionWidth"
        UiTextBoxSuperResolutionWidth.Padding = New Padding(5)
        UiTextBoxSuperResolutionWidth.Radius = 30
        UiTextBoxSuperResolutionWidth.RectColor = Color.DimGray
        UiTextBoxSuperResolutionWidth.RectDisableColor = Color.DimGray
        UiTextBoxSuperResolutionWidth.RectReadOnlyColor = Color.DimGray
        UiTextBoxSuperResolutionWidth.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSuperResolutionWidth.ScrollBarColor = Color.DimGray
        UiTextBoxSuperResolutionWidth.ScrollBarStyleInherited = False
        UiTextBoxSuperResolutionWidth.ShowText = False
        UiTextBoxSuperResolutionWidth.Size = New Size(83, 30)
        UiTextBoxSuperResolutionWidth.TabIndex = 97
        UiTextBoxSuperResolutionWidth.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSuperResolutionWidth.Watermark = "Width"
        UiTextBoxSuperResolutionWidth.WatermarkActiveColor = Color.DimGray
        UiTextBoxSuperResolutionWidth.WatermarkColor = Color.DimGray
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
        Label1.Text = "Target Resolution"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label124
        ' 
        Label124.Dock = DockStyle.Top
        Label124.Location = New Point(10, 68)
        Label124.Name = "Label124"
        Label124.Size = New Size(664, 10)
        Label124.TabIndex = 84
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(10, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(664, 10)
        Label2.TabIndex = 85
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(10, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(664, 50)
        Panel1.TabIndex = 86
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(UiComboBoxDownsamplingAlgorithm)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(UiComboBoxUpsamplingAlgorithm)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(100, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(564, 50)
        Panel2.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Fill
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(370, 10)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(10, 0, 0, 0)
        Label8.Size = New Size(194, 30)
        Label8.TabIndex = 99
        Label8.Text = "Custom shaders recommended"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxDownsamplingAlgorithm
        ' 
        UiComboBoxDownsamplingAlgorithm.DataSource = Nothing
        UiComboBoxDownsamplingAlgorithm.Dock = DockStyle.Left
        UiComboBoxDownsamplingAlgorithm.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxDownsamplingAlgorithm.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDownsamplingAlgorithm.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDownsamplingAlgorithm.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDownsamplingAlgorithm.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxDownsamplingAlgorithm.ForeColor = Color.Silver
        UiComboBoxDownsamplingAlgorithm.ForeDisableColor = Color.Silver
        UiComboBoxDownsamplingAlgorithm.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDownsamplingAlgorithm.ItemForeColor = Color.Silver
        UiComboBoxDownsamplingAlgorithm.ItemHeight = 28
        UiComboBoxDownsamplingAlgorithm.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxDownsamplingAlgorithm.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxDownsamplingAlgorithm.Items.AddRange(New Object() {"", "ewa_lanczos", "spline36", "mitchell", "hermite"})
        UiComboBoxDownsamplingAlgorithm.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDownsamplingAlgorithm.ItemSelectForeColor = Color.Silver
        UiComboBoxDownsamplingAlgorithm.Location = New Point(195, 10)
        UiComboBoxDownsamplingAlgorithm.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxDownsamplingAlgorithm.MaxDropDownItems = 17
        UiComboBoxDownsamplingAlgorithm.MinimumSize = New Size(63, 0)
        UiComboBoxDownsamplingAlgorithm.Name = "UiComboBoxDownsamplingAlgorithm"
        UiComboBoxDownsamplingAlgorithm.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxDownsamplingAlgorithm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxDownsamplingAlgorithm.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDownsamplingAlgorithm.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDownsamplingAlgorithm.ScrollBarHandleWidth = 20
        UiComboBoxDownsamplingAlgorithm.Size = New Size(175, 30)
        UiComboBoxDownsamplingAlgorithm.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxDownsamplingAlgorithm.SymbolSize = 24
        UiComboBoxDownsamplingAlgorithm.TabIndex = 84
        UiComboBoxDownsamplingAlgorithm.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxDownsamplingAlgorithm.Watermark = "Downsampling Algorithm (for scaling down)"
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Location = New Point(185, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(10, 30)
        Label5.TabIndex = 83
        ' 
        ' UiComboBoxUpsamplingAlgorithm
        ' 
        UiComboBoxUpsamplingAlgorithm.DataSource = Nothing
        UiComboBoxUpsamplingAlgorithm.Dock = DockStyle.Left
        UiComboBoxUpsamplingAlgorithm.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxUpsamplingAlgorithm.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxUpsamplingAlgorithm.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxUpsamplingAlgorithm.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxUpsamplingAlgorithm.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxUpsamplingAlgorithm.ForeColor = Color.Silver
        UiComboBoxUpsamplingAlgorithm.ForeDisableColor = Color.Silver
        UiComboBoxUpsamplingAlgorithm.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxUpsamplingAlgorithm.ItemForeColor = Color.Silver
        UiComboBoxUpsamplingAlgorithm.ItemHeight = 28
        UiComboBoxUpsamplingAlgorithm.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxUpsamplingAlgorithm.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxUpsamplingAlgorithm.Items.AddRange(New Object() {"", "ewa_lanczos", "spline36", "mitchell", "hermite"})
        UiComboBoxUpsamplingAlgorithm.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxUpsamplingAlgorithm.ItemSelectForeColor = Color.Silver
        UiComboBoxUpsamplingAlgorithm.Location = New Point(10, 10)
        UiComboBoxUpsamplingAlgorithm.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxUpsamplingAlgorithm.MaxDropDownItems = 17
        UiComboBoxUpsamplingAlgorithm.MinimumSize = New Size(63, 0)
        UiComboBoxUpsamplingAlgorithm.Name = "UiComboBoxUpsamplingAlgorithm"
        UiComboBoxUpsamplingAlgorithm.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxUpsamplingAlgorithm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxUpsamplingAlgorithm.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxUpsamplingAlgorithm.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxUpsamplingAlgorithm.ScrollBarHandleWidth = 20
        UiComboBoxUpsamplingAlgorithm.Size = New Size(175, 30)
        UiComboBoxUpsamplingAlgorithm.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxUpsamplingAlgorithm.SymbolSize = 24
        UiComboBoxUpsamplingAlgorithm.TabIndex = 87
        UiComboBoxUpsamplingAlgorithm.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxUpsamplingAlgorithm.Watermark = "Upsampling Algorithm (for scaling up)"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label6.Dock = DockStyle.Left
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 50)
        Label6.TabIndex = 4
        Label6.Text = "Sampling Algorithm"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Top
        Label3.Location = New Point(10, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(664, 10)
        Label3.TabIndex = 87
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label9)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(10, 198)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(664, 50)
        Panel3.TabIndex = 88
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(UiTextBoxAntiRingingStrength)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(100, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10, 10, 0, 10)
        Panel4.Size = New Size(564, 50)
        Panel4.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.ForeColor = Color.Gray
        Label7.Location = New Point(91, 10)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(10, 0, 0, 0)
        Label7.Size = New Size(473, 30)
        Label7.TabIndex = 98
        Label7.Text = "[Optional] Range 0.0 ~ 1.0"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxAntiRingingStrength
        ' 
        UiTextBoxAntiRingingStrength.Dock = DockStyle.Left
        UiTextBoxAntiRingingStrength.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAntiRingingStrength.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAntiRingingStrength.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAntiRingingStrength.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxAntiRingingStrength.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxAntiRingingStrength.ForeColor = Color.DarkGray
        UiTextBoxAntiRingingStrength.ForeDisableColor = Color.DarkGray
        UiTextBoxAntiRingingStrength.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxAntiRingingStrength.Location = New Point(10, 10)
        UiTextBoxAntiRingingStrength.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxAntiRingingStrength.MinimumSize = New Size(1, 16)
        UiTextBoxAntiRingingStrength.Name = "UiTextBoxAntiRingingStrength"
        UiTextBoxAntiRingingStrength.Padding = New Padding(5)
        UiTextBoxAntiRingingStrength.Radius = 30
        UiTextBoxAntiRingingStrength.RectColor = Color.DimGray
        UiTextBoxAntiRingingStrength.RectDisableColor = Color.DimGray
        UiTextBoxAntiRingingStrength.RectReadOnlyColor = Color.DimGray
        UiTextBoxAntiRingingStrength.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAntiRingingStrength.ScrollBarColor = Color.DimGray
        UiTextBoxAntiRingingStrength.ScrollBarStyleInherited = False
        UiTextBoxAntiRingingStrength.ShowText = False
        UiTextBoxAntiRingingStrength.Size = New Size(81, 30)
        UiTextBoxAntiRingingStrength.TabIndex = 97
        UiTextBoxAntiRingingStrength.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxAntiRingingStrength.Watermark = ""
        UiTextBoxAntiRingingStrength.WatermarkActiveColor = Color.DimGray
        UiTextBoxAntiRingingStrength.WatermarkColor = Color.DimGray
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
        Label9.Text = "Anti-Ringing Strength"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label10)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(10, 258)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(664, 193)
        Panel5.TabIndex = 90
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel82)
        Panel6.Controls.Add(Panel23)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(100, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10)
        Panel6.Size = New Size(564, 193)
        Panel6.TabIndex = 2
        ' 
        ' Panel82
        ' 
        Panel82.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel82.Controls.Add(ListView1)
        Panel82.Dock = DockStyle.Fill
        Panel82.Location = New Point(10, 40)
        Panel82.Name = "Panel82"
        Panel82.Padding = New Padding(0, 10, 0, 0)
        Panel82.Size = New Size(544, 143)
        Panel82.TabIndex = 24
        ' 
        ' ListView1
        ' 
        ListView1.AllowDrop = True
        ListView1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Fill
        ListView1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(0, 10)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.ShowItemToolTips = True
        ListView1.Size = New Size(544, 133)
        ListView1.TabIndex = 0
        ListView1.TabStop = False
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel23
        ' 
        Panel23.Controls.Add(Label14)
        Panel23.Controls.Add(UiButtonDownload)
        Panel23.Controls.Add(UiButtonMoveDownShader)
        Panel23.Controls.Add(Label12)
        Panel23.Controls.Add(UiButtonMoveUpShader)
        Panel23.Controls.Add(Label82)
        Panel23.Controls.Add(UiButtonRemoveShader)
        Panel23.Controls.Add(Label145)
        Panel23.Controls.Add(UiButtonAddShader)
        Panel23.Dock = DockStyle.Top
        Panel23.Location = New Point(10, 10)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(544, 30)
        Panel23.TabIndex = 23
        ' 
        ' Label14
        ' 
        Label14.Dock = DockStyle.Fill
        Label14.ForeColor = Color.Gray
        Label14.Location = New Point(255, 0)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(10, 0, 0, 0)
        Label14.Size = New Size(229, 30)
        Label14.TabIndex = 100
        Label14.Text = "Supports .glsl and .hook formats"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButtonDownload
        ' 
        UiButtonDownload.Dock = DockStyle.Right
        UiButtonDownload.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonDownload.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonDownload.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonDownload.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonDownload.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonDownload.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonDownload.Font = New Font("Segoe UI", 9.75F)
        UiButtonDownload.ForeColor = Color.Silver
        UiButtonDownload.ForeDisableColor = Color.Silver
        UiButtonDownload.ForeHoverColor = Color.Silver
        UiButtonDownload.ForePressColor = Color.Silver
        UiButtonDownload.ForeSelectedColor = Color.Silver
        UiButtonDownload.Location = New Point(484, 0)
        UiButtonDownload.MinimumSize = New Size(1, 1)
        UiButtonDownload.Name = "UiButtonDownload"
        UiButtonDownload.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonDownload.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonDownload.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonDownload.RectHoverColor = Color.DarkGray
        UiButtonDownload.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonDownload.RectSelectedColor = Color.DarkGray
        UiButtonDownload.Size = New Size(60, 30)
        UiButtonDownload.TabIndex = 102
        UiButtonDownload.Text = "Download"
        UiButtonDownload.TipsFont = New Font("Segoe UI", 9F)
        ' 
        ' UiButtonMoveDownShader
        ' 
        UiButtonMoveDownShader.Dock = DockStyle.Left
        UiButtonMoveDownShader.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDownShader.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDownShader.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonMoveDownShader.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDownShader.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonMoveDownShader.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonMoveDownShader.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveDownShader.ForeColor = Color.Silver
        UiButtonMoveDownShader.ForeDisableColor = Color.Silver
        UiButtonMoveDownShader.ForeHoverColor = Color.Silver
        UiButtonMoveDownShader.ForePressColor = Color.Silver
        UiButtonMoveDownShader.ForeSelectedColor = Color.Silver
        UiButtonMoveDownShader.Location = New Point(195, 0)
        UiButtonMoveDownShader.MinimumSize = New Size(1, 1)
        UiButtonMoveDownShader.Name = "UiButtonMoveDownShader"
        UiButtonMoveDownShader.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonMoveDownShader.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDownShader.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDownShader.RectHoverColor = Color.DarkGray
        UiButtonMoveDownShader.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveDownShader.RectSelectedColor = Color.DarkGray
        UiButtonMoveDownShader.Size = New Size(60, 30)
        UiButtonMoveDownShader.TabIndex = 90
        UiButtonMoveDownShader.Text = "Move Down"
        UiButtonMoveDownShader.TipsFont = New Font("Segoe UI", 9F)
        ' 
        ' Label12
        ' 
        Label12.Dock = DockStyle.Left
        Label12.Location = New Point(190, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(5, 30)
        Label12.TabIndex = 89
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonMoveUpShader
        ' 
        UiButtonMoveUpShader.Dock = DockStyle.Left
        UiButtonMoveUpShader.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUpShader.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUpShader.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonMoveUpShader.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUpShader.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonMoveUpShader.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonMoveUpShader.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveUpShader.ForeColor = Color.Silver
        UiButtonMoveUpShader.ForeDisableColor = Color.Silver
        UiButtonMoveUpShader.ForeHoverColor = Color.Silver
        UiButtonMoveUpShader.ForePressColor = Color.Silver
        UiButtonMoveUpShader.ForeSelectedColor = Color.Silver
        UiButtonMoveUpShader.Location = New Point(130, 0)
        UiButtonMoveUpShader.MinimumSize = New Size(1, 1)
        UiButtonMoveUpShader.Name = "UiButtonMoveUpShader"
        UiButtonMoveUpShader.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonMoveUpShader.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUpShader.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUpShader.RectHoverColor = Color.DarkGray
        UiButtonMoveUpShader.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveUpShader.RectSelectedColor = Color.DarkGray
        UiButtonMoveUpShader.Size = New Size(60, 30)
        UiButtonMoveUpShader.TabIndex = 88
        UiButtonMoveUpShader.Text = "Move Up"
        UiButtonMoveUpShader.TipsFont = New Font("Segoe UI", 9F)
        ' 
        ' Label82
        ' 
        Label82.Dock = DockStyle.Left
        Label82.Location = New Point(125, 0)
        Label82.Name = "Label82"
        Label82.Size = New Size(5, 30)
        Label82.TabIndex = 87
        Label82.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonRemoveShader
        ' 
        UiButtonRemoveShader.Dock = DockStyle.Left
        UiButtonRemoveShader.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveShader.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveShader.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemoveShader.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveShader.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonRemoveShader.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRemoveShader.Font = New Font("Segoe UI", 9.75F)
        UiButtonRemoveShader.ForeColor = Color.Silver
        UiButtonRemoveShader.ForeDisableColor = Color.Silver
        UiButtonRemoveShader.ForeHoverColor = Color.Silver
        UiButtonRemoveShader.ForePressColor = Color.Silver
        UiButtonRemoveShader.ForeSelectedColor = Color.Silver
        UiButtonRemoveShader.Location = New Point(65, 0)
        UiButtonRemoveShader.MinimumSize = New Size(1, 1)
        UiButtonRemoveShader.Name = "UiButtonRemoveShader"
        UiButtonRemoveShader.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonRemoveShader.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveShader.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemoveShader.RectHoverColor = Color.DarkGray
        UiButtonRemoveShader.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRemoveShader.RectSelectedColor = Color.DarkGray
        UiButtonRemoveShader.Size = New Size(60, 30)
        UiButtonRemoveShader.TabIndex = 86
        UiButtonRemoveShader.Text = "Remove"
        UiButtonRemoveShader.TipsFont = New Font("Segoe UI", 9F)
        ' 
        ' Label145
        ' 
        Label145.Dock = DockStyle.Left
        Label145.Location = New Point(60, 0)
        Label145.Name = "Label145"
        Label145.Size = New Size(5, 30)
        Label145.TabIndex = 85
        Label145.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonAddShader
        ' 
        UiButtonAddShader.Dock = DockStyle.Left
        UiButtonAddShader.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddShader.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddShader.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddShader.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddShader.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddShader.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddShader.Font = New Font("Segoe UI", 9.75F)
        UiButtonAddShader.ForeColor = Color.Silver
        UiButtonAddShader.ForeDisableColor = Color.Silver
        UiButtonAddShader.ForeHoverColor = Color.Silver
        UiButtonAddShader.ForePressColor = Color.Silver
        UiButtonAddShader.ForeSelectedColor = Color.Silver
        UiButtonAddShader.Location = New Point(0, 0)
        UiButtonAddShader.MinimumSize = New Size(1, 1)
        UiButtonAddShader.Name = "UiButtonAddShader"
        UiButtonAddShader.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonAddShader.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddShader.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddShader.RectHoverColor = Color.DarkGray
        UiButtonAddShader.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddShader.RectSelectedColor = Color.DarkGray
        UiButtonAddShader.Size = New Size(60, 30)
        UiButtonAddShader.TabIndex = 84
        UiButtonAddShader.Text = "Add"
        UiButtonAddShader.TipsFont = New Font("Segoe UI", 9F)
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label10.Dock = DockStyle.Left
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 193)
        Label10.TabIndex = 4
        Label10.Text = "Custom Shader"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Top
        Label11.Location = New Point(10, 248)
        Label11.Name = "Label11"
        Label11.Size = New Size(664, 10)
        Label11.TabIndex = 89
        ' 
        ' FormSuperResolution
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(684, 461)
        Controls.Add(Panel5)
        Controls.Add(Label11)
        Controls.Add(Panel3)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Panel8)
        Controls.Add(Label124)
        Controls.Add(Panel73)
        Font = New Font("Segoe UI", 9.75F)
        ForeColor = Color.Silver
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(700, 500)
        Name = "FormSuperResolution"
        Padding = New Padding(10)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "libplacebo Super Resolution"
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel82.ResumeLayout(False)
        Panel23.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel73 As Panel
    Friend WithEvents Label123 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents UiTextBoxSuperResolutionWidth As Sunny.UI.UITextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents UiTextBoxSuperResolutionHeight As Sunny.UI.UITextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiComboBoxDownsamplingAlgorithm As Sunny.UI.UIComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UiComboBoxUpsamplingAlgorithm As Sunny.UI.UIComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents UiTextBoxAntiRingingStrength As Sunny.UI.UITextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents UiButtonMoveUpShader As Sunny.UI.UIButton
    Friend WithEvents Label82 As Label
    Friend WithEvents UiButtonRemoveShader As Sunny.UI.UIButton
    Friend WithEvents Label145 As Label
    Friend WithEvents UiButtonAddShader As Sunny.UI.UIButton
    Friend WithEvents UiButtonMoveDownShader As Sunny.UI.UIButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel82 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label14 As Label
    Friend WithEvents UiButtonDownload As Sunny.UI.UIButton

End Class

