Imports System.IO
Public Class FormCropInteraction

    ' Private Fields
    Private cropRect As New Rectangle(0, 0, 200, 100)
    Private isDraggingLeftTop As Boolean = False
    Private isDraggingRightBottom As Boolean = False
    Private fixedAspectRatio As Double = 0
    Private ReadOnly magnifierSize As Integer = 5

    ' Cached image size to avoid repeated access
    Private cachedImageWidth As Integer = 0
    Private cachedImageHeight As Integer = 0

    Public FFmpegProcess As Process

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

#Region "Form Events"

    Private Sub FormCropInteraction_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeDpiSettings()
    End Sub

    Private Sub FormCropInteraction_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetControlFont(UserSettings.Instance.Font, Me)
    End Sub

    Private Sub FormCropInteraction_DpiChanged(sender As Object, e As DpiChangedEventArgs) Handles Me.DpiChanged
        InitializeDpiSettings()
    End Sub

    Private Sub FormCropInteraction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Dispose image resources
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
        If PictureBox2.Image IsNot Nothing Then
            PictureBox2.Image.Dispose()
            PictureBox2.Image = Nothing
        End If
        If PictureBox3.Image IsNot Nothing Then
            PictureBox3.Image.Dispose()
            PictureBox3.Image = Nothing
        End If
        GC.Collect()
    End Sub

#End Region

#Region "ButtonEvent"

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        OpenVideoToGetFrame(ShowFileOpenDialog())
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        If Not String.IsNullOrEmpty(UiTextBoxCropFilterParameters.Text) Then
            Form1.GeneralParametersPage.UiTextBoxCropFilterParameters.Text = UiTextBoxCropFilterParameters.Text
            Me.Close()
        End If
    End Sub

#End Region

#Region "Mouse Interaction Events"

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            isDraggingLeftTop = True
        ElseIf e.Button = MouseButtons.Right Then
            isDraggingRightBottom = True
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If Not (isDraggingLeftTop OrElse isDraggingRightBottom) Then Return
        If cachedImageWidth = 0 OrElse cachedImageHeight = 0 Then Return

        If isDraggingLeftTop Then
            HandleLeftTopDrag(e.X, e.Y)
        ElseIf isDraggingRightBottom Then
            HandleRightBottomDrag(e.X, e.Y)
        End If

        ' Apply alignment mode and update interface
        ApplyAlignMode()
        UpdateCropTextBox()
        PictureBox1.Invalidate()
        UpdateMagnifiers()
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        isDraggingLeftTop = False
        isDraggingRightBottom = False
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If cropRect.Width <= 0 OrElse cropRect.Height <= 0 OrElse cachedImageWidth = 0 Then Return

        ' Shrink inward when drawing to ensure borders are not obscured
        Dim drawRect As Rectangle = cropRect
        If cropRect.Right >= cachedImageWidth Then
            drawRect.Width -= 1
        End If
        If cropRect.Bottom >= cachedImageHeight Then
            drawRect.Height -= 1
        End If

        e.Graphics.DrawRectangle(Pens.Red, drawRect)
    End Sub

#End Region

#Region "TextBox and ComboBox Events"

    Private Sub UiTextBoxCropFilterParameters_KeyDown(sender As Object, e As KeyEventArgs) Handles UiTextBoxCropFilterParameters.KeyDown
        If e.KeyCode <> Keys.Enter Then Return

        If ParseCropParameters(UiTextBoxCropFilterParameters.Text.Trim()) Then
            ApplyAlignMode()
            PictureBox1.Invalidate()
            UpdateMagnifiers()
        End If
    End Sub

    Private Sub UiComboBoxRatio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiComboBoxRatio.SelectedIndexChanged
        fixedAspectRatio = GetAspectRatioFromIndex(UiComboBoxRatio.SelectedIndex)
    End Sub

#End Region

#Region "Helper Methods"

    ''' <summary>
    ''' InitializeDPISettings
    ''' </summary>
    Private Sub InitializeDpiSettings()
        Dim dpi As Single = Form1.DPI
        UiComboBoxRatio.ItemHeight = CInt(30 * dpi)
        UiCheckBoxCenterIn.CheckBoxSize = CInt(20 * dpi)
        PictureBox2.Width = PictureBox2.Height
        PictureBox3.Width = PictureBox3.Height
    End Sub

    ''' <summary>
    ''' DisplayFileSelectDialog
    ''' </summary>
    Private Function ShowFileOpenDialog() As String
        Using openFileDialog As New OpenFileDialog With {.Multiselect = False, .Filter = "All Files|*.*"}
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Return openFileDialog.FileName
            End If
        End Using
        Return String.Empty
    End Function

    ''' <summary>
    ''' Extract frame from video
    ''' </summary>
    Private Function ExtractFrameFromVideo(videoPath As String) As Boolean
        Try
            Using process As New Process()
                process.StartInfo.FileName = "ffmpeg"
                process.StartInfo.WorkingDirectory = If(UserSettings.Instance.WorkingDirectory <> "", UserSettings.Instance.WorkingDirectory, "")
                Dim timestamp As String = If(Not String.IsNullOrEmpty(UiTextBox1.Text), UiTextBox1.Text, "0:0:10")
                Dim outputPath As String = Path.Combine(Application.StartupPath, "ScreenCropPreview.png")
                process.StartInfo.Arguments = $"-ss {timestamp} -i ""{videoPath}"" -frames:v 1 -q:v 1 ""{outputPath}"" -y"
                process.Start()
                process.WaitForExit()
                Return process.ExitCode = 0
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error extracting video frame: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Initialize crop rectangle to a reasonable default value
    ''' </summary>
    Private Sub InitializeCropRect()
        Dim defaultWidth As Integer = Math.Min(cachedImageWidth, 800)
        Dim defaultHeight As Integer = Math.Min(cachedImageHeight, 450)
        cropRect = New Rectangle(
            (cachedImageWidth - defaultWidth) \ 2,
            (cachedImageHeight - defaultHeight) \ 2,
            defaultWidth,
            defaultHeight
        )
        UpdateCropTextBox()
    End Sub

    ''' <summary>
    ''' Handle top-left drag
    ''' </summary>
    Private Sub HandleLeftTopDrag(mouseX As Integer, mouseY As Integer)
        If mouseX > cropRect.Right OrElse mouseY > cropRect.Bottom Then
            ' Swap drag modes
            isDraggingLeftTop = False
            isDraggingRightBottom = True
            Dim oldRect As Rectangle = cropRect
            cropRect = New Rectangle(oldRect.Left, oldRect.Top,
                                    Math.Max(1, mouseX - oldRect.Left),
                                    Math.Max(1, mouseY - oldRect.Top))
        Else
            ' Normal top-left drag
            Dim newX As Integer = Math.Max(0, Math.Min(mouseX, cropRect.Right - 1))
            Dim newY As Integer = Math.Max(0, Math.Min(mouseY, cropRect.Bottom - 1))
            Dim newWidth As Integer = cropRect.Right - newX
            Dim newHeight As Integer = cropRect.Bottom - newY

            If fixedAspectRatio > 0 Then
                newHeight = CInt(newWidth / fixedAspectRatio)
            End If

            ' Boundary check
            newWidth = Math.Min(newWidth, cachedImageWidth - newX)
            newHeight = Math.Min(newHeight, cachedImageHeight - newY)

            cropRect = New Rectangle(newX, newY, newWidth, newHeight)
        End If
    End Sub

    ''' <summary>
    ''' Handle bottom-right drag
    ''' </summary>
    Private Sub HandleRightBottomDrag(mouseX As Integer, mouseY As Integer)
        If mouseX < cropRect.Left OrElse mouseY < cropRect.Top Then
            ' Swap drag modes
            isDraggingRightBottom = False
            isDraggingLeftTop = True
            Dim oldRect As Rectangle = cropRect
            cropRect = New Rectangle(mouseX, mouseY, oldRect.Right - mouseX, oldRect.Bottom - mouseY)
        Else
            ' Normal bottom-right drag
            Dim newRight As Integer = Math.Max(cropRect.Left + 1, Math.Min(mouseX, cachedImageWidth))
            Dim newBottom As Integer = Math.Max(cropRect.Top + 1, Math.Min(mouseY, cachedImageHeight))
            Dim newWidth As Integer = newRight - cropRect.Left
            Dim newHeight As Integer = newBottom - cropRect.Top

            If fixedAspectRatio > 0 Then
                newHeight = CInt(newWidth / fixedAspectRatio)
                If cropRect.Top + newHeight > cachedImageHeight Then
                    newHeight = cachedImageHeight - cropRect.Top
                    newWidth = CInt(newHeight * fixedAspectRatio)
                End If
            End If

            cropRect = New Rectangle(cropRect.Left, cropRect.Top, newWidth, newHeight)
        End If
    End Sub

    ''' <summary>
    ''' Apply center alignment mode
    ''' </summary>
    Private Sub ApplyAlignMode()
        If UiCheckBoxCenterIn.Checked AndAlso cachedImageWidth > 0 AndAlso cachedImageHeight > 0 Then
            cropRect.X = (cachedImageWidth - cropRect.Width) \ 2
            cropRect.Y = (cachedImageHeight - cropRect.Height) \ 2
        End If
    End Sub

    ''' <summary>
    ''' Update crop parameters textbox
    ''' </summary>
    Private Sub UpdateCropTextBox()
        UiTextBoxCropFilterParameters.Text = $"{cropRect.Width}:{cropRect.Height}:{cropRect.X}:{cropRect.Y}"
    End Sub

    ''' <summary>
    ''' Parse crop parameters
    ''' </summary>
    Private Function ParseCropParameters(text As String) As Boolean
        Dim parts As String() = text.Split(":"c)
        If parts.Length <> 4 Then Return False

        Dim w, h, x, y As Integer
        If Integer.TryParse(parts(0), w) AndAlso
           Integer.TryParse(parts(1), h) AndAlso
           Integer.TryParse(parts(2), x) AndAlso
           Integer.TryParse(parts(3), y) AndAlso
           w > 0 AndAlso h > 0 Then
            cropRect = New Rectangle(x, y, w, h)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Get aspect ratio from index
    ''' </summary>
    Private Function GetAspectRatioFromIndex(index As Integer) As Double
        Select Case index
            Case 0 : Return 0           ' Free
            Case 1 : Return 21.0 / 9.0  ' 21:9
            Case 2 : Return 16.0 / 9.0  ' 16:9
            Case 3 : Return 3.0 / 2.0   ' 3:2
            Case 4 : Return 2.0 / 1.0   ' 2:1
            Case 5 : Return 4.0 / 3.0   ' 4:3
            Case 6 : Return 1.0         ' 1:1
            Case Else : Return 0
        End Select
    End Function

#End Region

#Region "Magnifier Update"

    ''' <summary>
    ''' Update magnifier display
    ''' </summary>
    Private Sub UpdateMagnifiers()
        If PictureBox1.Image Is Nothing OrElse cachedImageWidth = 0 Then Return

        Try
            ' Top-left magnifier: Display the top-left coordinate of the crop rectangle (cropRect start pixel)
            UpdateSingleMagnifier(PictureBox2, cropRect.Left, cropRect.Top)

            ' Bottom-right magnifier: Display crop rectangle bottom-right point
            ' Rectangle's Right/Bottom are the first coordinates outside the boundary
            ' For example: Rectangle(0, 0, 1920, 1080) Has Right=1920, Bottom=1080
            ' But the actual pixels are [0, 1919] and [0, 1079]
            ' So the actual bottom-right pixel coordinates are (Right-1, Bottom-1)
            Dim rightPixel As Integer = cropRect.Right - 1
            Dim bottomPixel As Integer = cropRect.Bottom - 1
            UpdateSingleMagnifier(PictureBox3, rightPixel, bottomPixel)
        Catch ex As Exception
            Debug.WriteLine($"Magnifier Update Error: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Update single magnifier unit
    ''' </summary>
    Private Sub UpdateSingleMagnifier(pictureBox As PictureBox, centerX As Integer, centerY As Integer)
        Dim magnifierWidth As Integer = Math.Max(1, pictureBox.Width)
        Dim magnifierHeight As Integer = Math.Max(1, pictureBox.Height)

        Using bmp As New Bitmap(magnifierWidth, magnifierHeight)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.Black)
                g.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half

                ' Limit center point within image range
                centerX = Math.Max(0, Math.Min(centerX, cachedImageWidth - 1))
                centerY = Math.Max(0, Math.Min(centerY, cachedImageHeight - 1))

                ' Calculate source rectangle: taking centerX, centerY as center, take surrounding magnifierSize*2 area
                Dim sourceX As Integer = Math.Max(0, centerX - magnifierSize)
                Dim sourceY As Integer = Math.Max(0, centerY - magnifierSize)
                Dim sourceWidth As Integer = Math.Min(magnifierSize * 2, cachedImageWidth - sourceX)
                Dim sourceHeight As Integer = Math.Min(magnifierSize * 2, cachedImageHeight - sourceY)

                If sourceWidth <= 0 OrElse sourceHeight <= 0 Then
                    g.DrawString("Outside boundary", New Font("Arial", 10), Brushes.White, 5, 5)
                Else
                    ' Draw zoomed image area
                    Dim sourceRect As New Rectangle(sourceX, sourceY, sourceWidth, sourceHeight)
                    g.DrawImage(PictureBox1.Image,
                               New Rectangle(0, 0, magnifierWidth, magnifierHeight),
                               sourceRect,
                               GraphicsUnit.Pixel)

                    ' Calculate crosshair position
                    ' Check if the target pixel is on the boundary of the source area
                    Dim isAtLeftEdge As Boolean = (centerX = sourceX)
                    Dim isAtRightEdge As Boolean = (centerX = sourceX + sourceWidth - 1)
                    Dim isAtTopEdge As Boolean = (centerY = sourceY)
                    Dim isAtBottomEdge As Boolean = (centerY = sourceY + sourceHeight - 1)

                    Dim crossX As Integer
                    Dim crossY As Integer

                    ' X coordinate calculation
                    If isAtLeftEdge Then
                        crossX = 1 ' Left edge, offset inward
                    ElseIf isAtRightEdge Then
                        crossX = magnifierWidth - 2 ' Right edge, offset inward
                    Else
                        ' Middle position, precise mapping
                        Dim offsetX As Double = CDbl(centerX - sourceX) / sourceWidth
                        crossX = CInt(offsetX * magnifierWidth)
                    End If

                    ' Y coordinate calculation
                    If isAtTopEdge Then
                        crossY = 1 ' Top edge, offset inward
                    ElseIf isAtBottomEdge Then
                        crossY = magnifierHeight - 2 ' Bottom edge, offset inward
                    Else
                        ' Middle position, precise mapping
                        Dim offsetY As Double = CDbl(centerY - sourceY) / sourceHeight
                        crossY = CInt(offsetY * magnifierHeight)
                    End If

                    ' Draw crosshair
                    g.DrawLine(Pens.Red, crossX, 0, crossX, magnifierHeight - 1)
                    g.DrawLine(Pens.Red, 0, crossY, magnifierWidth - 1, crossY)
                End If
            End Using

            ' Dispose old image and set new image
            pictureBox.Image?.Dispose()
            pictureBox.Image = bmp.Clone()
        End Using
    End Sub

#End Region


    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        OpenVideoToGetFrame(e.Data.GetData(DataFormats.FileDrop)(0))
    End Sub

    Private Sub Panel2_DragEnter(sender As Object, e As DragEventArgs) Handles Panel2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Panel2_DragDrop(sender As Object, e As DragEventArgs) Handles Panel2.DragDrop
        OpenVideoToGetFrame(e.Data.GetData(DataFormats.FileDrop)(0))
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        OpenVideoToGetFrame(e.Data.GetData(DataFormats.FileDrop)(0))
    End Sub

    Sub OpenVideoToGetFrame(videoFile As String)
        If String.IsNullOrEmpty(videoFile) Then Exit Sub
        If Not ExtractFrameFromVideo(videoFile) Then Exit Sub
        Dim previewPath As String = Path.Combine(Application.StartupPath, "ScreenCropPreview.png")
        If Not File.Exists(previewPath) Then Exit Sub
        PictureBox1.Image?.Dispose()
        PictureBox1.Image = LoadImageFromFile(previewPath)
        If PictureBox1.Image IsNot Nothing Then
            cachedImageWidth = PictureBox1.Image.Width
            cachedImageHeight = PictureBox1.Image.Height
        End If
        File.Delete(previewPath)
        Panel2.Visible = True
        UpdateMagnifiers()
    End Sub




End Class
















