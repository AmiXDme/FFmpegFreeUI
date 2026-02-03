<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrepareFilesPage
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
        Panel3 = New Panel()
        UiButtonSort = New Sunny.UI.UIButton()
        Label1 = New Label()
        UiButtonQuickRemove = New Sunny.UI.UIButton()
        Label3 = New Label()
        UiButtonClear = New Sunny.UI.UIButton()
        Label18 = New Label()
        UiButtonRemove = New Sunny.UI.UIButton()
        Label17 = New Label()
        UiButtonAddDirRecursive = New Sunny.UI.UIButton()
        Label24 = New Label()
        UiButtonAddFile = New Sunny.UI.UIButton()
        Label19 = New Label()
        UiButtonAddToQueue = New Sunny.UI.UIButton()
        Panel58 = New Panel()
        ListView1 = New ListView()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        Label2 = New Label()
        Panel3.SuspendLayout()
        Panel58.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel3.Controls.Add(UiButtonSort)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(UiButtonQuickRemove)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(UiButtonClear)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(UiButtonRemove)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(UiButtonAddDirRecursive)
        Panel3.Controls.Add(Label24)
        Panel3.Controls.Add(UiButtonAddFile)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(UiButtonAddToQueue)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10, 0, 10, 10)
        Panel3.Size = New Size(1000, 45)
        Panel3.TabIndex = 5
        ' 
        ' UiButtonSort
        ' 
        UiButtonSort.Dock = DockStyle.Left
        UiButtonSort.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSort.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSort.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSort.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSort.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSort.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSort.Font = New Font("Segoe UI", 10F)
        UiButtonSort.ForeColor = Color.Silver
        UiButtonSort.ForeDisableColor = Color.Silver
        UiButtonSort.ForeHoverColor = Color.Silver
        UiButtonSort.ForePressColor = Color.Silver
        UiButtonSort.ForeSelectedColor = Color.Silver
        UiButtonSort.Location = New Point(720, 0)
        UiButtonSort.MinimumSize = New Size(1, 1)
        UiButtonSort.Name = "UiButtonSort"
        UiButtonSort.Radius = 0
        UiButtonSort.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonSort.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonSort.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonSort.RectHoverColor = Color.DarkGray
        UiButtonSort.RectPressColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButtonSort.RectSelectedColor = Color.DarkGray
        UiButtonSort.RectSize = 2
        UiButtonSort.Size = New Size(70, 35)
        UiButtonSort.TabIndex = 129
        UiButtonSort.Text = "Sort"
        UiButtonSort.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Location = New Point(710, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(10, 35)
        Label1.TabIndex = 128
        ' 
        ' UiButtonQuickRemove
        ' 
        UiButtonQuickRemove.Dock = DockStyle.Left
        UiButtonQuickRemove.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonQuickRemove.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonQuickRemove.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonQuickRemove.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonQuickRemove.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonQuickRemove.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonQuickRemove.Font = New Font("Segoe UI", 10F)
        UiButtonQuickRemove.ForeColor = Color.Silver
        UiButtonQuickRemove.ForeDisableColor = Color.Silver
        UiButtonQuickRemove.ForeHoverColor = Color.Silver
        UiButtonQuickRemove.ForePressColor = Color.Silver
        UiButtonQuickRemove.ForeSelectedColor = Color.Silver
        UiButtonQuickRemove.Location = New Point(607, 0)
        UiButtonQuickRemove.MinimumSize = New Size(1, 1)
        UiButtonQuickRemove.Name = "UiButtonQuickRemove"
        UiButtonQuickRemove.Radius = 0
        UiButtonQuickRemove.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonQuickRemove.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonQuickRemove.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonQuickRemove.RectHoverColor = Color.DarkGray
        UiButtonQuickRemove.RectPressColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButtonQuickRemove.RectSelectedColor = Color.DarkGray
        UiButtonQuickRemove.RectSize = 2
        UiButtonQuickRemove.Size = New Size(103, 35)
        UiButtonQuickRemove.TabIndex = 127
        UiButtonQuickRemove.Text = "Quick Remove"
        UiButtonQuickRemove.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Location = New Point(597, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 35)
        Label3.TabIndex = 73
        ' 
        ' UiButton12
        ' 
        UiButtonClear.Dock = DockStyle.Left
        UiButtonClear.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonClear.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonClear.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonClear.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonClear.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonClear.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonClear.Font = New Font("Segoe UI", 10F)
        UiButtonClear.ForeColor = Color.IndianRed
        UiButtonClear.ForeDisableColor = Color.IndianRed
        UiButtonClear.ForeHoverColor = Color.IndianRed
        UiButtonClear.ForePressColor = Color.IndianRed
        UiButtonClear.ForeSelectedColor = Color.IndianRed
        UiButtonClear.Location = New Point(527, 0)
        UiButtonClear.MinimumSize = New Size(1, 1)
        UiButtonClear.Name = "UiButtonClear"
        UiButtonClear.Radius = 0
        UiButtonClear.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonClear.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonClear.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonClear.RectHoverColor = Color.IndianRed
        UiButtonClear.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonClear.RectSelectedColor = Color.IndianRed
        UiButtonClear.RectSize = 2
        UiButtonClear.Size = New Size(70, 35)
        UiButtonClear.TabIndex = 50
        UiButtonClear.Text = "Clear"
        UiButtonClear.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Location = New Point(517, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(10, 35)
        Label18.TabIndex = 49
        ' 
        ' UiButton11
        ' 
        UiButtonRemove.Dock = DockStyle.Left
        UiButtonRemove.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemove.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemove.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRemove.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRemove.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRemove.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRemove.Font = New Font("Segoe UI", 10F)
        UiButtonRemove.ForeColor = Color.IndianRed
        UiButtonRemove.ForeDisableColor = Color.IndianRed
        UiButtonRemove.ForeHoverColor = Color.IndianRed
        UiButtonRemove.ForePressColor = Color.IndianRed
        UiButtonRemove.ForeSelectedColor = Color.IndianRed
        UiButtonRemove.Location = New Point(447, 0)
        UiButtonRemove.MinimumSize = New Size(1, 1)
        UiButtonRemove.Name = "UiButtonRemove"
        UiButtonRemove.Radius = 0
        UiButtonRemove.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonRemove.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonRemove.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonRemove.RectHoverColor = Color.IndianRed
        UiButtonRemove.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRemove.RectSelectedColor = Color.IndianRed
        UiButtonRemove.RectSize = 2
        UiButtonRemove.Size = New Size(70, 35)
        UiButtonRemove.TabIndex = 48
        UiButtonRemove.Text = "Remove"
        UiButtonRemove.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label17
        ' 
        Label17.Dock = DockStyle.Left
        Label17.Location = New Point(437, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(10, 35)
        Label17.TabIndex = 47
        ' 
        ' UiButton10
        ' 
        UiButtonAddDirRecursive.Dock = DockStyle.Left
        UiButtonAddDirRecursive.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddDirRecursive.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddDirRecursive.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddDirRecursive.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddDirRecursive.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddDirRecursive.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddDirRecursive.Font = New Font("Segoe UI", 10F)
        UiButtonAddDirRecursive.ForeColor = Color.MediumPurple
        UiButtonAddDirRecursive.ForeDisableColor = Color.MediumPurple
        UiButtonAddDirRecursive.ForeHoverColor = Color.MediumPurple
        UiButtonAddDirRecursive.ForePressColor = Color.MediumPurple
        UiButtonAddDirRecursive.ForeSelectedColor = Color.MediumPurple
        UiButtonAddDirRecursive.Location = New Point(260, 0)
        UiButtonAddDirRecursive.MinimumSize = New Size(1, 1)
        UiButtonAddDirRecursive.Name = "UiButtonAddDirRecursive"
        UiButtonAddDirRecursive.Radius = 0
        UiButtonAddDirRecursive.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonAddDirRecursive.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddDirRecursive.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonAddDirRecursive.RectHoverColor = Color.MediumPurple
        UiButtonAddDirRecursive.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddDirRecursive.RectSelectedColor = Color.MediumPurple
        UiButtonAddDirRecursive.RectSize = 2
        UiButtonAddDirRecursive.Size = New Size(177, 35)
        UiButtonAddDirRecursive.TabIndex = 46
        UiButtonAddDirRecursive.Text = "Add Dir && SubDir"
        UiButtonAddDirRecursive.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label24
        ' 
        Label24.Dock = DockStyle.Left
        Label24.Location = New Point(250, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(10, 35)
        Label24.TabIndex = 45
        ' 
        ' UiButton18
        ' 
        UiButtonAddFile.Dock = DockStyle.Left
        UiButtonAddFile.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddFile.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddFile.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddFile.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddFile.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddFile.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddFile.Font = New Font("Segoe UI", 10F)
        UiButtonAddFile.ForeColor = Color.MediumPurple
        UiButtonAddFile.ForeDisableColor = Color.MediumPurple
        UiButtonAddFile.ForeHoverColor = Color.MediumPurple
        UiButtonAddFile.ForePressColor = Color.MediumPurple
        UiButtonAddFile.ForeSelectedColor = Color.MediumPurple
        UiButtonAddFile.Location = New Point(150, 0)
        UiButtonAddFile.MinimumSize = New Size(1, 1)
        UiButtonAddFile.Name = "UiButtonAddFile"
        UiButtonAddFile.Radius = 0
        UiButtonAddFile.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonAddFile.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddFile.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonAddFile.RectHoverColor = Color.MediumPurple
        UiButtonAddFile.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddFile.RectSelectedColor = Color.MediumPurple
        UiButtonAddFile.RectSize = 2
        UiButtonAddFile.Size = New Size(100, 35)
        UiButtonAddFile.TabIndex = 44
        UiButtonAddFile.Text = "Add File"
        UiButtonAddFile.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label19
        ' 
        Label19.Dock = DockStyle.Left
        Label19.Location = New Point(140, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(10, 35)
        Label19.TabIndex = 72
        ' 
        ' UiButton14
        ' 
        UiButtonAddToQueue.Dock = DockStyle.Left
        UiButtonAddToQueue.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddToQueue.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddToQueue.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddToQueue.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddToQueue.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddToQueue.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddToQueue.Font = New Font("Segoe UI", 10F)
        UiButtonAddToQueue.ForeColor = Color.YellowGreen
        UiButtonAddToQueue.ForeDisableColor = Color.YellowGreen
        UiButtonAddToQueue.ForeHoverColor = Color.YellowGreen
        UiButtonAddToQueue.ForePressColor = Color.YellowGreen
        UiButtonAddToQueue.ForeSelectedColor = Color.YellowGreen
        UiButtonAddToQueue.Location = New Point(10, 0)
        UiButtonAddToQueue.MinimumSize = New Size(1, 1)
        UiButtonAddToQueue.Name = "UiButtonAddToQueue"
        UiButtonAddToQueue.Radius = 0
        UiButtonAddToQueue.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonAddToQueue.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddToQueue.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonAddToQueue.RectHoverColor = Color.YellowGreen
        UiButtonAddToQueue.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddToQueue.RectSelectedColor = Color.YellowGreen
        UiButtonAddToQueue.RectSize = 2
        UiButtonAddToQueue.Size = New Size(130, 35)
        UiButtonAddToQueue.TabIndex = 71
        UiButtonAddToQueue.Text = "Add To Queue"
        UiButtonAddToQueue.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Panel58
        ' 
        Panel58.Controls.Add(ListView1)
        Panel58.Controls.Add(Label2)
        Panel58.Dock = DockStyle.Fill
        Panel58.Location = New Point(0, 45)
        Panel58.Name = "Panel58"
        Panel58.Padding = New Padding(10, 10, 0, 10)
        Panel58.Size = New Size(1000, 605)
        Panel58.TabIndex = 7
        ' 
        ' ListView1
        ' 
        ListView1.AllowDrop = True
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader9, ColumnHeader1})
        ListView1.Dock = DockStyle.Fill
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.LabelEdit = True
        ListView1.Location = New Point(10, 10)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.ShowItemToolTips = True
        ListView1.Size = New Size(990, 535)
        ListView1.TabIndex = 0
        ListView1.TabStop = False
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Bottom
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(10, 545)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 10, 0, 0)
        Label2.Size = New Size(513, 50)
        Label2.TabIndex = 1
        Label2.Text = "You can drag files directly into the Encoding Queue to start. Use this page if you have many files or other requirements." & vbCrLf & "Each file is an independent task and does not affect others!"
        ' 
        ' PrepareFilesPage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel58)
        Controls.Add(Panel3)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.Silver
        Margin = New Padding(3, 4, 3, 4)
        Name = "PrepareFilesPage"
        Size = New Size(1000, 650)
        Panel3.ResumeLayout(False)
        Panel58.ResumeLayout(False)
        Panel58.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents UiButtonClear As Sunny.UI.UIButton
    Friend WithEvents Label18 As Label
    Friend WithEvents UiButtonRemove As Sunny.UI.UIButton
    Friend WithEvents Label17 As Label
    Friend WithEvents UiButtonAddDirRecursive As Sunny.UI.UIButton
    Friend WithEvents Label24 As Label
    Friend WithEvents UiButtonAddFile As Sunny.UI.UIButton
    Friend WithEvents Label19 As Label
    Friend WithEvents UiButtonAddToQueue As Sunny.UI.UIButton
    Friend WithEvents Panel58 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents UiButtonSort As Sunny.UI.UIButton
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButtonQuickRemove As Sunny.UI.UIButton
    Friend WithEvents Label3 As Label

End Class









