<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MergingPage
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
        Panel2 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel4 = New Panel()
        Label1 = New Label()
        UiButtonRemove = New Sunny.UI.UIButton()
        Label3 = New Label()
        UiButtonMoveDown = New Sunny.UI.UIButton()
        Label10 = New Label()
        UiButtonMoveUp = New Sunny.UI.UIButton()
        Label8 = New Label()
        UiButtonAddFile = New Sunny.UI.UIButton()
        Label11 = New Label()
        Label20 = New Label()
        Panel73 = New Panel()
        Label123 = New Label()
        Panel5 = New Panel()
        UiTextBoxOutputFile = New Sunny.UI.UITextBox()
        Label6 = New Label()
        Label132 = New Label()
        UiButtonSelectLocation = New Sunny.UI.UIButton()
        UiButtonStartMerge = New Sunny.UI.UIButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel73.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(10, 49)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(1080, 581)
        Panel1.TabIndex = 88
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel2.Controls.Add(ListView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(10, 50)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 10, 0, 10)
        Panel2.Size = New Size(1060, 521)
        Panel2.TabIndex = 5
        ' 
        ' ListView1
        ' 
        ListView1.AllowDrop = True
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Fill
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(10, 10)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(1050, 501)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(UiButtonRemove)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(UiButtonMoveDown)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(UiButtonMoveUp)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(UiButtonAddFile)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(10, 10)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 0, 0, 10)
        Panel4.Size = New Size(1060, 40)
        Panel4.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(375, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 0, 0, 0)
        Label1.Size = New Size(685, 30)
        Label1.TabIndex = 105
        Label1.Text = "Use F3 / F4 to reorder, Delete to remove."
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButtonRemove
        ' 
        UiButtonRemove.AllowDrop = True
        UiButtonRemove.Dock = DockStyle.Left
        UiButtonRemove.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.Font = New Font("Segoe UI", 9.75F)
        UiButtonRemove.ForeColor = Color.IndianRed
        UiButtonRemove.ForeDisableColor = Color.IndianRed
        UiButtonRemove.ForeHoverColor = Color.IndianRed
        UiButtonRemove.ForePressColor = Color.IndianRed
        UiButtonRemove.ForeSelectedColor = Color.IndianRed
        UiButtonRemove.Location = New Point(300, 0)
        UiButtonRemove.MinimumSize = New Size(1, 1)
        UiButtonRemove.Name = "UiButtonRemove"
        UiButtonRemove.Radius = 30
        UiButtonRemove.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonRemove.RectHoverColor = Color.IndianRed
        UiButtonRemove.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRemove.RectSelectedColor = Color.IndianRed
        UiButtonRemove.Size = New Size(75, 30)
        UiButtonRemove.TabIndex = 104
        UiButtonRemove.Text = "Remove"
        UiButtonRemove.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Location = New Point(290, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 30)
        Label3.TabIndex = 103
        ' 
        ' UiButtonMoveDown
        ' 
        UiButtonMoveDown.AllowDrop = True
        UiButtonMoveDown.Dock = DockStyle.Left
        UiButtonMoveDown.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveDown.ForeColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeDisableColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeHoverColor = Color.CornflowerBlue
        UiButtonMoveDown.ForePressColor = Color.CornflowerBlue
        UiButtonMoveDown.ForeSelectedColor = Color.CornflowerBlue
        UiButtonMoveDown.Location = New Point(215, 0)
        UiButtonMoveDown.MinimumSize = New Size(1, 1)
        UiButtonMoveDown.Name = "UiButtonMoveDown"
        UiButtonMoveDown.Radius = 30
        UiButtonMoveDown.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveDown.RectHoverColor = Color.CornflowerBlue
        UiButtonMoveDown.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveDown.RectSelectedColor = Color.CornflowerBlue
        UiButtonMoveDown.Size = New Size(75, 30)
        UiButtonMoveDown.TabIndex = 102
        UiButtonMoveDown.Text = "Down"
        UiButtonMoveDown.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label10
        ' 
        Label10.Dock = DockStyle.Left
        Label10.Location = New Point(205, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(10, 30)
        Label10.TabIndex = 101
        ' 
        ' UiButtonMoveUp
        ' 
        UiButtonMoveUp.AllowDrop = True
        UiButtonMoveUp.Dock = DockStyle.Left
        UiButtonMoveUp.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.Font = New Font("Segoe UI", 9.75F)
        UiButtonMoveUp.ForeColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeDisableColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeHoverColor = Color.CornflowerBlue
        UiButtonMoveUp.ForePressColor = Color.CornflowerBlue
        UiButtonMoveUp.ForeSelectedColor = Color.CornflowerBlue
        UiButtonMoveUp.Location = New Point(130, 0)
        UiButtonMoveUp.MinimumSize = New Size(1, 1)
        UiButtonMoveUp.Name = "UiButtonMoveUp"
        UiButtonMoveUp.Radius = 30
        UiButtonMoveUp.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonMoveUp.RectHoverColor = Color.CornflowerBlue
        UiButtonMoveUp.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonMoveUp.RectSelectedColor = Color.CornflowerBlue
        UiButtonMoveUp.Size = New Size(75, 30)
        UiButtonMoveUp.TabIndex = 100
        UiButtonMoveUp.Text = "Up"
        UiButtonMoveUp.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Left
        Label8.Location = New Point(120, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(10, 30)
        Label8.TabIndex = 99
        ' 
        ' UiButtonAddFile
        ' 
        UiButtonAddFile.AllowDrop = True
        UiButtonAddFile.Dock = DockStyle.Left
        UiButtonAddFile.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.Font = New Font("Segoe UI", 9.75F)
        UiButtonAddFile.ForeColor = Color.YellowGreen
        UiButtonAddFile.ForeDisableColor = Color.YellowGreen
        UiButtonAddFile.ForeHoverColor = Color.YellowGreen
        UiButtonAddFile.ForePressColor = Color.YellowGreen
        UiButtonAddFile.ForeSelectedColor = Color.YellowGreen
        UiButtonAddFile.Location = New Point(0, 0)
        UiButtonAddFile.MinimumSize = New Size(1, 1)
        UiButtonAddFile.Name = "UiButtonAddFile"
        UiButtonAddFile.Radius = 30
        UiButtonAddFile.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddFile.RectHoverColor = Color.YellowGreen
        UiButtonAddFile.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddFile.RectSelectedColor = Color.YellowGreen
        UiButtonAddFile.Size = New Size(120, 30)
        UiButtonAddFile.TabIndex = 46
        UiButtonAddFile.Text = "Add File"
        UiButtonAddFile.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Bottom
        Label11.Location = New Point(10, 630)
        Label11.Name = "Label11"
        Label11.Size = New Size(1080, 10)
        Label11.TabIndex = 89
        ' 
        ' Label20
        ' 
        Label20.Dock = DockStyle.Top
        Label20.Location = New Point(10, 39)
        Label20.Name = "Label20"
        Label20.Size = New Size(1080, 10)
        Label20.TabIndex = 87
        ' 
        ' Panel73
        ' 
        Panel73.AutoSize = True
        Panel73.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel73.Controls.Add(Label123)
        Panel73.Dock = DockStyle.Top
        Panel73.Location = New Point(10, 0)
        Panel73.Name = "Panel73"
        Panel73.Padding = New Padding(10)
        Panel73.Size = New Size(1080, 39)
        Panel73.TabIndex = 86
        ' 
        ' Label123
        ' 
        Label123.AutoSize = True
        Label123.Dock = DockStyle.Top
        Label123.Font = New Font("Segoe UI", 9.75F)
        Label123.ForeColor = Color.Gray
        Label123.Location = New Point(10, 10)
        Label123.Name = "Label123"
        Label123.Size = New Size(477, 19)
        Label123.TabIndex = 4
        Label123.Text = "Basic merge only. Copies streams, requires matching parameters. For advanced needs, use video editing software."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel5.Controls.Add(UiTextBoxOutputFile)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Label132)
        Panel5.Controls.Add(UiButtonSelectLocation)
        Panel5.Controls.Add(UiButtonStartMerge)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(10, 640)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(1080, 50)
        Panel5.TabIndex = 90
        ' 
        ' UiTextBoxOutputFile
        ' 
        UiTextBoxOutputFile.Dock = DockStyle.Fill
        UiTextBoxOutputFile.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputFile.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputFile.Font = New Font("Segoe UI", 9.75F)
        UiTextBoxOutputFile.ForeColor = Color.DarkGray
        UiTextBoxOutputFile.ForeDisableColor = Color.DarkGray
        UiTextBoxOutputFile.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxOutputFile.Location = New Point(140, 10)
        UiTextBoxOutputFile.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxOutputFile.MinimumSize = New Size(1, 16)
        UiTextBoxOutputFile.Name = "UiTextBoxOutputFile"
        UiTextBoxOutputFile.Padding = New Padding(5)
        UiTextBoxOutputFile.Radius = 30
        UiTextBoxOutputFile.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxOutputFile.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputFile.ScrollBarColor = Color.DimGray
        UiTextBoxOutputFile.ScrollBarStyleInherited = False
        UiTextBoxOutputFile.ShowText = False
        UiTextBoxOutputFile.Size = New Size(800, 30)
        UiTextBoxOutputFile.TabIndex = 105
        UiTextBoxOutputFile.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxOutputFile.Watermark = "Output to target location"
        UiTextBoxOutputFile.WatermarkActiveColor = Color.DimGray
        UiTextBoxOutputFile.WatermarkColor = Color.DimGray
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Right
        Label6.Location = New Point(940, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(10, 30)
        Label6.TabIndex = 104
        ' 
        ' Label132
        ' 
        Label132.Dock = DockStyle.Left
        Label132.Location = New Point(130, 10)
        Label132.Name = "Label132"
        Label132.Size = New Size(10, 30)
        Label132.TabIndex = 103
        ' 
        ' UiButtonSelectLocation
        ' 
        UiButtonSelectLocation.AllowDrop = True
        UiButtonSelectLocation.Dock = DockStyle.Left
        UiButtonSelectLocation.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.Font = New Font("Segoe UI", 9.75F)
        UiButtonSelectLocation.ForeColor = Color.YellowGreen
        UiButtonSelectLocation.ForeDisableColor = Color.YellowGreen
        UiButtonSelectLocation.ForeHoverColor = Color.YellowGreen
        UiButtonSelectLocation.ForePressColor = Color.YellowGreen
        UiButtonSelectLocation.ForeSelectedColor = Color.YellowGreen
        UiButtonSelectLocation.Location = New Point(10, 10)
        UiButtonSelectLocation.MinimumSize = New Size(1, 1)
        UiButtonSelectLocation.Name = "UiButtonSelectLocation"
        UiButtonSelectLocation.Radius = 30
        UiButtonSelectLocation.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonSelectLocation.RectHoverColor = Color.YellowGreen
        UiButtonSelectLocation.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonSelectLocation.RectSelectedColor = Color.YellowGreen
        UiButtonSelectLocation.Size = New Size(120, 30)
        UiButtonSelectLocation.TabIndex = 102
        UiButtonSelectLocation.Text = "Select Location"
        UiButtonSelectLocation.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' UiButtonStartMerge
        ' 
        UiButtonStartMerge.AllowDrop = True
        UiButtonStartMerge.Dock = DockStyle.Right
        UiButtonStartMerge.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.FillDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.FillPressColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.Font = New Font("Segoe UI", 9.75F)
        UiButtonStartMerge.ForeColor = Color.YellowGreen
        UiButtonStartMerge.ForeDisableColor = Color.YellowGreen
        UiButtonStartMerge.ForeHoverColor = Color.YellowGreen
        UiButtonStartMerge.ForePressColor = Color.YellowGreen
        UiButtonStartMerge.ForeSelectedColor = Color.YellowGreen
        UiButtonStartMerge.Location = New Point(950, 10)
        UiButtonStartMerge.MinimumSize = New Size(1, 1)
        UiButtonStartMerge.Name = "UiButtonStartMerge"
        UiButtonStartMerge.Radius = 30
        UiButtonStartMerge.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonStartMerge.RectHoverColor = Color.YellowGreen
        UiButtonStartMerge.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonStartMerge.RectSelectedColor = Color.YellowGreen
        UiButtonStartMerge.Size = New Size(120, 30)
        UiButtonStartMerge.TabIndex = 101
        UiButtonStartMerge.Text = "Start Merge"
        UiButtonStartMerge.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' MergingPage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel1)
        Controls.Add(Label11)
        Controls.Add(Label20)
        Controls.Add(Panel73)
        Controls.Add(Panel5)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Silver
        Name = "MergingPage"
        Padding = New Padding(10, 0, 10, 10)
        Size = New Size(1100, 700)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel73.ResumeLayout(False)
        Panel73.PerformLayout()
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiButtonRemove As Sunny.UI.UIButton
    Friend WithEvents Label3 As Label
    Friend WithEvents UiButtonMoveDown As Sunny.UI.UIButton
    Friend WithEvents Label10 As Label
    Friend WithEvents UiButtonMoveUp As Sunny.UI.UIButton
    Friend WithEvents Label8 As Label
    Friend WithEvents UiButtonAddFile As Sunny.UI.UIButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel73 As Panel
    Friend WithEvents Label123 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UiTextBoxOutputFile As Sunny.UI.UITextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents UiButtonSelectLocation As Sunny.UI.UIButton
    Friend WithEvents UiButtonStartMerge As Sunny.UI.UIButton

End Class









