<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFrameBlending
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
        Label124 = New Label()
        Panel8 = New Panel()
        Panel11 = New Panel()
        Label13 = New Label()
        UiTextBoxTargetFrameRate = New Sunny.UI.UITextBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        UiComboBoxBlendAlgorithm = New Sunny.UI.UIComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label6 = New Label()
        UiTextBoxBlendRatio = New Sunny.UI.UITextBox()
        Label7 = New Label()
        Panel73.SuspendLayout()
        Panel8.SuspendLayout()
        Panel11.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
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
        Panel73.Size = New Size(514, 58)
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
        Label123.Size = New Size(347, 38)
        Label123.TabIndex = 4
        Label123.Text = "Time Blend blends adjacent frames to simulate camera effects." & vbCrLf & "Note that algorithmic motion blur may not match the quality of real recorded motion blur."
        ' 
        ' Label124
        ' 
        Label124.Dock = DockStyle.Top
        Label124.Location = New Point(10, 68)
        Label124.Name = "Label124"
        Label124.Size = New Size(514, 10)
        Label124.TabIndex = 83
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel8.Controls.Add(Panel11)
        Panel8.Controls.Add(Label1)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(10, 78)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(514, 50)
        Panel8.TabIndex = 84
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(Label13)
        Panel11.Controls.Add(UiTextBoxTargetFrameRate)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(100, 0)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(10, 10, 0, 10)
        Panel11.Size = New Size(414, 50)
        Panel11.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.Dock = DockStyle.Fill
        Label13.ForeColor = Color.Gray
        Label13.Location = New Point(185, 10)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(10, 0, 0, 0)
        Label13.Size = New Size(229, 30)
        Label13.TabIndex = 98
        Label13.Text = "Optional"
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
        UiTextBoxTargetFrameRate.Watermark = "Specify frame rate in filter"
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
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(10, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(514, 10)
        Label2.TabIndex = 85
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(10, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(514, 50)
        Panel1.TabIndex = 86
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(UiComboBoxBlendAlgorithm)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(100, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(414, 50)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(185, 10)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(10, 0, 0, 0)
        Label3.Size = New Size(229, 30)
        Label3.TabIndex = 99
        Label3.Text = "Leave blank to cancel using this filter"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxBlendAlgorithm
        ' 
        UiComboBoxBlendAlgorithm.DataSource = Nothing
        UiComboBoxBlendAlgorithm.Dock = DockStyle.Left
        UiComboBoxBlendAlgorithm.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxBlendAlgorithm.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxBlendAlgorithm.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxBlendAlgorithm.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxBlendAlgorithm.Font = New Font("Segoe UI", 9.75F)
        UiComboBoxBlendAlgorithm.ForeColor = Color.Silver
        UiComboBoxBlendAlgorithm.ForeDisableColor = Color.Silver
        UiComboBoxBlendAlgorithm.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxBlendAlgorithm.ItemForeColor = Color.Silver
        UiComboBoxBlendAlgorithm.ItemHeight = 30
        UiComboBoxBlendAlgorithm.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxBlendAlgorithm.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxBlendAlgorithm.Items.AddRange(New Object() {"", "Average value with previous frame", "Interpolated value blend", "Bitwise AND", "Bitwise OR", "Bitwise XOR", "Pixel value addition", "Pixel value multiplication"})
        UiComboBoxBlendAlgorithm.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxBlendAlgorithm.ItemSelectForeColor = Color.Silver
        UiComboBoxBlendAlgorithm.Location = New Point(10, 10)
        UiComboBoxBlendAlgorithm.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxBlendAlgorithm.MaxDropDownItems = 17
        UiComboBoxBlendAlgorithm.MinimumSize = New Size(63, 0)
        UiComboBoxBlendAlgorithm.Name = "UiComboBoxBlendAlgorithm"
        UiComboBoxBlendAlgorithm.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxBlendAlgorithm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxBlendAlgorithm.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxBlendAlgorithm.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxBlendAlgorithm.ScrollBarHandleWidth = 20
        UiComboBoxBlendAlgorithm.Size = New Size(175, 30)
        UiComboBoxBlendAlgorithm.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxBlendAlgorithm.SymbolSize = 24
        UiComboBoxBlendAlgorithm.TabIndex = 88
        UiComboBoxBlendAlgorithm.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxBlendAlgorithm.Watermark = "Blend Algorithm"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 50)
        Label4.TabIndex = 4
        Label4.Text = "Blend Mode"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Top
        Label5.Location = New Point(10, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(514, 10)
        Label5.TabIndex = 87
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label7)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(10, 198)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(514, 50)
        Panel3.TabIndex = 88
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(UiTextBoxBlendRatio)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(100, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10, 10, 0, 10)
        Panel4.Size = New Size(414, 50)
        Panel4.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Fill
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(185, 10)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(10, 0, 0, 0)
        Label6.Size = New Size(229, 30)
        Label6.TabIndex = 100
        Label6.Text = "May not always be effective"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxBlendRatio
        ' 
        UiTextBoxBlendRatio.Dock = DockStyle.Left
        UiTextBoxBlendRatio.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlendRatio.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlendRatio.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlendRatio.FillReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxBlendRatio.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxBlendRatio.ForeColor = Color.DarkGray
        UiTextBoxBlendRatio.ForeDisableColor = Color.DarkGray
        UiTextBoxBlendRatio.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxBlendRatio.Location = New Point(10, 10)
        UiTextBoxBlendRatio.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxBlendRatio.MinimumSize = New Size(1, 16)
        UiTextBoxBlendRatio.Name = "UiTextBoxBlendRatio"
        UiTextBoxBlendRatio.Padding = New Padding(5)
        UiTextBoxBlendRatio.Radius = 30
        UiTextBoxBlendRatio.RectColor = Color.DimGray
        UiTextBoxBlendRatio.RectDisableColor = Color.DimGray
        UiTextBoxBlendRatio.RectReadOnlyColor = Color.DimGray
        UiTextBoxBlendRatio.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxBlendRatio.ScrollBarColor = Color.DimGray
        UiTextBoxBlendRatio.ScrollBarStyleInherited = False
        UiTextBoxBlendRatio.ShowText = False
        UiTextBoxBlendRatio.Size = New Size(175, 30)
        UiTextBoxBlendRatio.TabIndex = 98
        UiTextBoxBlendRatio.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxBlendRatio.Watermark = "0.0~1.0"
        UiTextBoxBlendRatio.WatermarkActiveColor = Color.DimGray
        UiTextBoxBlendRatio.WatermarkColor = Color.DimGray
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label7.Dock = DockStyle.Left
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 50)
        Label7.TabIndex = 4
        Label7.Text = "Blend Ratio"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormFrameBlending
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(534, 261)
        Controls.Add(Panel3)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Panel8)
        Controls.Add(Label124)
        Controls.Add(Panel73)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Silver
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(550, 300)
        Name = "FormFrameBlending"
        Padding = New Padding(10)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "Time Blend (tblend) Motion Blur"
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel73 As Panel
    Friend WithEvents Label123 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents UiTextBoxTargetFrameRate As Sunny.UI.UITextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UiComboBoxBlendAlgorithm As Sunny.UI.UIComboBox
    Friend WithEvents UiTextBoxBlendRatio As Sunny.UI.UITextBox
    Friend WithEvents Label6 As Label
End Class









