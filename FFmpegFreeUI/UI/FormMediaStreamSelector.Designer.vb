<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMediaStreamSelector
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
        Panel2 = New Panel()
        Panel3 = New Panel()
        UiButtonReset = New Sunny.UI.UIButton()
        Label1 = New Label()
        UiButtonOpen = New Sunny.UI.UIButton()
        UiButtonConfirm = New Sunny.UI.UIButton()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AllowDrop = True
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(10, 10)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(664, 301)
        Panel2.TabIndex = 126
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(UiButtonReset)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(UiButtonOpen)
        Panel3.Controls.Add(UiButtonConfirm)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(10, 311)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 10, 0, 0)
        Panel3.Size = New Size(664, 40)
        Panel3.TabIndex = 127
        ' 
        ' UiButtonReset
        ' 
        UiButtonReset.Dock = DockStyle.Left
        UiButtonReset.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonReset.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonReset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonReset.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonReset.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonReset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonReset.Font = New Font("Segoe UI", 9.75F)
        UiButtonReset.ForeColor = Color.Silver
        UiButtonReset.ForeDisableColor = Color.Silver
        UiButtonReset.ForeHoverColor = Color.Silver
        UiButtonReset.ForePressColor = Color.Silver
        UiButtonReset.ForeSelectedColor = Color.Silver
        UiButtonReset.Location = New Point(90, 10)
        UiButtonReset.MinimumSize = New Size(1, 1)
        UiButtonReset.Name = "UiButtonReset"
        UiButtonReset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonReset.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonReset.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonReset.RectHoverColor = Color.DarkGray
        UiButtonReset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonReset.RectSelectedColor = Color.DarkGray
        UiButtonReset.Size = New Size(80, 30)
        UiButtonReset.TabIndex = 108
        UiButtonReset.Text = "Reset"
        UiButtonReset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Location = New Point(80, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(10, 30)
        Label1.TabIndex = 107
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonOpen
        ' 
        UiButtonOpen.Dock = DockStyle.Left
        UiButtonOpen.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpen.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpen.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonOpen.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpen.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonOpen.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonOpen.Font = New Font("Segoe UI", 9.75F)
        UiButtonOpen.ForeColor = Color.Silver
        UiButtonOpen.ForeDisableColor = Color.Silver
        UiButtonOpen.ForeHoverColor = Color.Silver
        UiButtonOpen.ForePressColor = Color.Silver
        UiButtonOpen.ForeSelectedColor = Color.Silver
        UiButtonOpen.Location = New Point(0, 10)
        UiButtonOpen.MinimumSize = New Size(1, 1)
        UiButtonOpen.Name = "UiButtonOpen"
        UiButtonOpen.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonOpen.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpen.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpen.RectHoverColor = Color.DarkGray
        UiButtonOpen.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonOpen.RectSelectedColor = Color.DarkGray
        UiButtonOpen.Size = New Size(80, 30)
        UiButtonOpen.TabIndex = 104
        UiButtonOpen.Text = "Open"
        UiButtonOpen.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonConfirm
        ' 
        UiButtonConfirm.Dock = DockStyle.Right
        UiButtonConfirm.FillColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.FillColor2 = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.FillDisableColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.FillHoverColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.FillPressColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.FillSelectedColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.Font = New Font("Segoe UI", 9.75F)
        UiButtonConfirm.ForeColor = Color.Black
        UiButtonConfirm.ForeDisableColor = Color.Black
        UiButtonConfirm.ForeHoverColor = Color.Black
        UiButtonConfirm.ForePressColor = Color.Black
        UiButtonConfirm.ForeSelectedColor = Color.Black
        UiButtonConfirm.Location = New Point(539, 10)
        UiButtonConfirm.MinimumSize = New Size(1, 1)
        UiButtonConfirm.Name = "UiButtonConfirm"
        UiButtonConfirm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonConfirm.RectColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.RectDisableColor = Color.FromArgb(CByte(145), CByte(132), CByte(238))
        UiButtonConfirm.RectHoverColor = Color.DarkGray
        UiButtonConfirm.RectPressColor = Color.White
        UiButtonConfirm.RectSelectedColor = Color.DarkGray
        UiButtonConfirm.Size = New Size(125, 30)
        UiButtonConfirm.TabIndex = 103
        UiButtonConfirm.Text = "Confirm Selection"
        UiButtonConfirm.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' FormMediaStreamSelector
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(684, 361)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(700, 400)
        Name = "FormMediaStreamSelector"
        Padding = New Padding(10)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "Media Stream Selector"
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UiButtonReset As Sunny.UI.UIButton
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButtonOpen As Sunny.UI.UIButton
    Friend WithEvents UiButtonConfirm As Sunny.UI.UIButton
End Class






