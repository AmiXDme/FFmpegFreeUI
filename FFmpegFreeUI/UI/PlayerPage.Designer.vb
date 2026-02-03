<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerPage
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        UiButtonCloseProcess = New Sunny.UI.UIButton()
        Label8 = New Label()
        UiButtonOpenFile = New Sunny.UI.UIButton()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10, 0, 10, 10)
        Panel1.Size = New Size(1143, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.ForeColor = Color.DarkGray
        Label3.Location = New Point(10, 45)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 5, 0, 0)
        Label3.Size = New Size(569, 25)
        Label3.TabIndex = 2
        Label3.Text = "Only recommended for temporary scenarios, such as playing the latest or niche encodings; use a mature player for daily viewing."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.ForeColor = Color.DarkGray
        Label2.Location = New Point(10, 20)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 5, 0, 0)
        Label2.Size = New Size(383, 25)
        Label2.TabIndex = 1
        Label2.Text = "ffplay is a player for debugging purposes and will consume a large amount of GPU PCIe bandwidth."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.ForeColor = Color.DarkGray
        Label1.Location = New Point(10, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(515, 20)
        Label1.TabIndex = 0
        Label1.Text = "Directly calls ffplay.exe and redirects for playback; ensures it is in the same directory or added to environment variables."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel2.Controls.Add(UiButtonCloseProcess)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(UiButtonOpenFile)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 677)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(1143, 50)
        Panel2.TabIndex = 1
        ' 
        ' UiButtonCloseProcess
        ' 
        UiButtonCloseProcess.AllowDrop = True
        UiButtonCloseProcess.Dock = DockStyle.Left
        UiButtonCloseProcess.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.Font = New Font("Segoe UI", 9.75F)
        UiButtonCloseProcess.ForeColor = Color.Silver
        UiButtonCloseProcess.ForeDisableColor = Color.Silver
        UiButtonCloseProcess.ForeHoverColor = Color.Silver
        UiButtonCloseProcess.ForePressColor = Color.Silver
        UiButtonCloseProcess.ForeSelectedColor = Color.Silver
        UiButtonCloseProcess.Location = New Point(100, 10)
        UiButtonCloseProcess.MinimumSize = New Size(1, 1)
        UiButtonCloseProcess.Name = "UiButtonCloseProcess"
        UiButtonCloseProcess.Radius = 30
        UiButtonCloseProcess.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCloseProcess.RectHoverColor = Color.Silver
        UiButtonCloseProcess.RectPressColor = Color.Gainsboro
        UiButtonCloseProcess.Size = New Size(80, 30)
        UiButtonCloseProcess.TabIndex = 101
        UiButtonCloseProcess.Text = "Close"
        UiButtonCloseProcess.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Left
        Label8.Location = New Point(90, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(10, 30)
        Label8.TabIndex = 100
        ' 
        ' UiButtonOpenFile
        ' 
        UiButtonOpenFile.AllowDrop = True
        UiButtonOpenFile.Dock = DockStyle.Left
        UiButtonOpenFile.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.Font = New Font("Segoe UI", 9.75F)
        UiButtonOpenFile.ForeColor = Color.Silver
        UiButtonOpenFile.ForeDisableColor = Color.Silver
        UiButtonOpenFile.ForeHoverColor = Color.Silver
        UiButtonOpenFile.ForePressColor = Color.Silver
        UiButtonOpenFile.ForeSelectedColor = Color.Silver
        UiButtonOpenFile.Location = New Point(10, 10)
        UiButtonOpenFile.MinimumSize = New Size(1, 1)
        UiButtonOpenFile.Name = "UiButtonOpenFile"
        UiButtonOpenFile.Radius = 30
        UiButtonOpenFile.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFile.RectHoverColor = Color.Silver
        UiButtonOpenFile.RectPressColor = Color.Gainsboro
        UiButtonOpenFile.Size = New Size(80, 30)
        UiButtonOpenFile.TabIndex = 47
        UiButtonOpenFile.Text = "Open"
        UiButtonOpenFile.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Panel3
        ' 
        Panel3.AllowDrop = True
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1143, 597)
        Panel3.TabIndex = 2
        ' 
        ' PlayerPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        Margin = New Padding(3, 4, 3, 4)
        Name = "PlayerPage"
        Size = New Size(1143, 727)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiButtonOpenFile As Sunny.UI.UIButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButtonCloseProcess As Sunny.UI.UIButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label

End Class








