
Public Class DarkListViewCustomDraw

    Public Shared Sub BindListViewEvents(listViewControl As ListView)
        listViewControl.DoubleBuffer
        AddHandler listViewControl.DrawSubItem, Sub(sender, e) DrawSubItem(sender, e)
        AddHandler listViewControl.SelectedIndexChanged, Sub(sender, e) sender.Invalidate(sender.ClientRectangle)
        AddHandler listViewControl.ItemMouseHover, Sub(sender, e) sender.Invalidate(sender.ClientRectangle)
    End Sub

    Public Shared Sub BindListViewEvents2(listViewControl As ListView)
        listViewControl.DoubleBuffer
        AddHandler listViewControl.DrawSubItem, Sub(sender, e) DrawSubItem2(sender, e)
        AddHandler listViewControl.SelectedIndexChanged, Sub(sender, e) sender.Invalidate(sender.ClientRectangle)
        AddHandler listViewControl.ItemMouseHover, Sub(sender, e) sender.Invalidate(sender.ClientRectangle)
    End Sub

    Public Shared Property ItemSelectedBackgroundColor As Color = ColorTranslator.FromWin32(RGB(48, 48, 48))
    Public Shared Property ItemSelectedHighlightMaskColor As Color = Color.FromArgb(60, 200, 200, 200)

    ''' <summary>
    ''' When binding this event, do not bind DrawListViewItemEvent. This event directly draws the main item.
    ''' </summary>
    ''' <param name="listViewControl"></param>
    ''' <param name="e"></param>
    Public Shared Sub DrawSubItem(listViewControl As ListView, e As DrawListViewSubItemEventArgs)
        Try
            Form1.RecreateWindowHandle()
            If Not e.Bounds.IntersectsWith(listViewControl.ClientRectangle) OrElse e.Bounds.Width = 0 Then Exit Sub
            Dim itemBackgroundColor As Color = If(listViewControl.SelectedIndices.Contains(e.ItemIndex), Color.FromArgb(48, 48, 48), listViewControl.BackColor)
            Dim textHeightAdjustment As Integer = (e.Bounds.Height - TextRenderer.MeasureText(e.SubItem.Text, e.SubItem.Font).Height) \ 2
            Dim textRenderArea As New Rectangle(e.Bounds.X + 5 * Form1.DPI, e.Bounds.Y + textHeightAdjustment, e.Bounds.Width, e.Bounds.Height)
            Dim textSize As Size = TextRenderer.MeasureText(e.SubItem.Text, e.SubItem.Font)
            Dim actualTextToDraw As String = e.SubItem.Text
            If textSize.Width > (e.Bounds.Width - 3 * Form1.DPI) Then
                Dim ellipsisWidth As Integer = TextRenderer.MeasureText("...", e.SubItem.Font).Width
                Dim availableTextWidth As Integer = e.Bounds.Width - ellipsisWidth
                While TextRenderer.MeasureText(actualTextToDraw, e.SubItem.Font).Width > availableTextWidth AndAlso actualTextToDraw.Length > 0
                    actualTextToDraw = actualTextToDraw.Substring(0, actualTextToDraw.Length - 1)
                End While
                actualTextToDraw &= "..."
            End If
            Using brush As New SolidBrush(itemBackgroundColor)
                e.Graphics.FillRectangle(brush, e.Bounds)
            End Using
            Select Case e.ColumnIndex
                Case 2
                    Dim progressText As String = e.SubItem.Text
                    Dim progressValue As Double = 0
                    If progressText.EndsWith("%"c) Then
                        Dim unused = Double.TryParse(progressText.AsSpan(0, progressText.Length - 1), progressValue)
                        progressValue = Math.Max(0, Math.Min(100, progressValue))
                    Else
                        Exit Select
                    End If
                    Dim margin As Integer = 3 * Form1.DPI
                    Dim Height As Integer = Math.Max(8 * Form1.DPI, e.Bounds.Height - 6 * Form1.DPI)
                    Dim area As New Rectangle(e.Bounds.X + margin, e.Bounds.Y + (e.Bounds.Height - Height) \ 2, e.Bounds.Width - 2 * margin, Height)
                    If progressValue > 0 Then
                        Using fillBrush As New SolidBrush(If(e.Item.Selected, Color.FromArgb(64, 64, 64), Color.FromArgb(56, 56, 56)))
                            e.Graphics.FillRectangle(fillBrush, New Rectangle(area.X, area.Y, area.Width * (progressValue / 100), area.Height))
                        End Using
                    End If
            End Select
            TextRenderer.DrawText(e.Graphics, actualTextToDraw.Replace("&", "&&"), e.SubItem.Font, textRenderArea, If(e.SubItem.ForeColor = listViewControl.ForeColor, e.Item.ForeColor, e.SubItem.ForeColor), Color.Transparent, TextFormatFlags.Default)
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub DrawSubItem2(listViewControl As ListView, e As DrawListViewSubItemEventArgs)
        Try
            Form1.RecreateWindowHandle()
            If Not e.Bounds.IntersectsWith(listViewControl.ClientRectangle) OrElse e.Bounds.Width = 0 Then Exit Sub
            Dim itemBackgroundColor As Color = If(listViewControl.SelectedIndices.Contains(e.ItemIndex), Color.FromArgb(56, 56, 56), listViewControl.BackColor)
            Dim textHeightAdjustment As Integer = (e.Bounds.Height - TextRenderer.MeasureText(e.SubItem.Text, e.SubItem.Font).Height) \ 2
            Dim textRenderArea As New Rectangle(e.Bounds.X + 5 * Form1.DPI, e.Bounds.Y + textHeightAdjustment, e.Bounds.Width, e.Bounds.Height)
            Dim textSize As Size = TextRenderer.MeasureText(e.SubItem.Text, e.SubItem.Font)
            Dim actualTextToDraw As String = e.SubItem.Text
            If textSize.Width > (e.Bounds.Width - 3 * Form1.DPI) Then
                Dim ellipsisWidth As Integer = TextRenderer.MeasureText("...", e.SubItem.Font).Width
                Dim availableTextWidth As Integer = e.Bounds.Width - ellipsisWidth
                While TextRenderer.MeasureText(actualTextToDraw, e.SubItem.Font).Width > availableTextWidth AndAlso actualTextToDraw.Length > 0
                    actualTextToDraw = actualTextToDraw.Substring(0, actualTextToDraw.Length - 1)
                End While
                actualTextToDraw &= "..."
            End If
            Using brush As New SolidBrush(itemBackgroundColor)
                e.Graphics.FillRectangle(brush, e.Bounds)
            End Using
            TextRenderer.DrawText(e.Graphics, actualTextToDraw.Replace("&", "&&"), e.SubItem.Font, textRenderArea, If(e.SubItem.ForeColor = listViewControl.ForeColor, e.Item.ForeColor, e.SubItem.ForeColor), Color.Transparent, TextFormatFlags.Default)
        Catch ex As Exception
        End Try
    End Sub

End Class







