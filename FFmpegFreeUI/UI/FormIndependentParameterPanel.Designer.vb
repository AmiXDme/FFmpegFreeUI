<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIndependentParameterPanel
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        UiButtonConfirmAndAddTask = New Sunny.UI.UIButton()
        Panel3 = New Panel()
        PanelTopVisualCorrectionArea = New Panel()
        PanelTopVisualCorrectionArea_Level2TabPage = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        PanelTopVisualCorrectionArea.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1084, 50)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.Location = New Point(170, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(914, 50)
        Label1.TabIndex = 110
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UiButtonConfirmAndAddTask)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8)
        Panel2.Size = New Size(170, 50)
        Panel2.TabIndex = 109
        ' 
        ' UiButtonConfirmAndAddTask
        ' 
        UiButtonConfirmAndAddTask.Dock = DockStyle.Fill
        UiButtonConfirmAndAddTask.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.FillHoverColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.FillPressColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.FillSelectedColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonConfirmAndAddTask.Font = New Font("Segoe UI", 9.75F)
        UiButtonConfirmAndAddTask.ForeColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.ForeDisableColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.ForeHoverColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.ForePressColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.ForeSelectedColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.Location = New Point(8, 8)
        UiButtonConfirmAndAddTask.MinimumSize = New Size(1, 1)
        UiButtonConfirmAndAddTask.Name = "UiButtonConfirmAndAddTask"
        UiButtonConfirmAndAddTask.Radius = 0
        UiButtonConfirmAndAddTask.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonConfirmAndAddTask.RectColor = Color.DimGray
        UiButtonConfirmAndAddTask.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonConfirmAndAddTask.RectHoverColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonConfirmAndAddTask.RectSelectedColor = Color.YellowGreen
        UiButtonConfirmAndAddTask.Size = New Size(154, 34)
        UiButtonConfirmAndAddTask.TabIndex = 109
        UiButtonConfirmAndAddTask.Text = "Confirm and Add Task"
        UiButtonConfirmAndAddTask.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PanelTopVisualCorrectionArea)
        Panel3.Controls.Add(Panel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1084, 661)
        Panel3.TabIndex = 1
        ' 
        ' PanelTopVisualCorrectionArea
        ' 
        PanelTopVisualCorrectionArea.Controls.Add(PanelTopVisualCorrectionArea_Level2TabPage)
        PanelTopVisualCorrectionArea.Dock = DockStyle.Top
        PanelTopVisualCorrectionArea.Location = New Point(0, 50)
        PanelTopVisualCorrectionArea.Name = "PanelTopVisualCorrectionArea"
        PanelTopVisualCorrectionArea.Size = New Size(1084, 10)
        PanelTopVisualCorrectionArea.TabIndex = 3
        ' 
        ' PanelTopVisualCorrectionArea_Level2TabPage
        ' 
        PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Left
        PanelTopVisualCorrectionArea_Level2TabPage.Location = New Point(0, 0)
        PanelTopVisualCorrectionArea_Level2TabPage.Name = "PanelTopVisualCorrectionArea_Level2TabPage"
        PanelTopVisualCorrectionArea_Level2TabPage.Size = New Size(202, 10)
        PanelTopVisualCorrectionArea_Level2TabPage.TabIndex = 1
        ' 
        ' FormIndependentParameterPanel
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1084, 661)
        Controls.Add(Panel3)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(1100, 700)
        Name = "FormIndependentParameterPanel"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "Independent Parameters Panel"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        PanelTopVisualCorrectionArea.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiButtonConfirmAndAddTask As Sunny.UI.UIButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelTopVisualCorrectionArea As Panel
    Friend WithEvents PanelTopVisualCorrectionArea_Level2TabPage As Panel
End Class









