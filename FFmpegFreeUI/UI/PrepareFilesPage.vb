Public Class PrepareFilesPage
    Private Sub PrepareFilesPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        DarkListViewCustomDraw.BindListViewEvents(Me.ListView1)
        Me.ListView1.SmallImageList = Form1.ImageList1
        AddHandler Me.UiButtonAddToQueue.Click, AddressOf UIControl_AddFile.AddToEncodingQueue
        AddHandler Me.ListView1.DragEnter, AddressOf UIControl_AddFile.ListView2_DragEnter
        AddHandler Me.ListView1.DragDrop, AddressOf UIControl_AddFile.ListView2_DragDrop
        AddHandler Me.UiButtonAddFile.Click, AddressOf UIControl_AddFile.AddFiles
        AddHandler Me.UiButtonAddDirRecursive.Click, AddressOf UIControl_AddFile.AddAllFilesFromFolder
        AddHandler Me.UiButtonRemove.Click, AddressOf UIControl_AddFile.BatchRemoveSelectedItems
        AddHandler Me.UiButtonClear.Click, AddressOf UIControl_AddFile.RemoveAllItems

        QuickRemoveMenu.Items.AddRange(New ToolStripItem() {
                              New ToolStripSeparator() With {.Tag = "null"},
                              New ToolStripMenuItem("RemoveCommonNonMediaFiles", Nothing, AddressOf RemoveCommonNonMediaFiles),
                              New ToolStripSeparator() With {.Tag = "null"}})
        AddHandler Me.UiButtonQuickRemove.Click, Sub()
                                               QuickRemoveMenu.Font = Me.Font
                                               QuickRemoveMenu.Show(Me.UiButtonQuickRemove, New Point(0, Me.UiButtonQuickRemove.Height - 2))
                                           End Sub
        SortMenu.Items.AddRange(New ToolStripItem() {
                      New ToolStripSeparator() With {.Tag = "null"},
                      New ToolStripMenuItem("OrderByItemNameAscending", Nothing, AddressOf OrderByItemNameAscending),
                      New ToolStripMenuItem("OrderByItemNameDescending", Nothing, AddressOf OrderByItemNameDescending),
                      New ToolStripMenuItem("OrderByFileSizeAscending", Nothing, AddressOf OrderByItemNameAscending),
                      New ToolStripMenuItem("OrderByFileSizeDescending", Nothing, AddressOf OrderByItemNameDescending),
                      New ToolStripSeparator() With {.Tag = "null"}})
        AddHandler Me.UiButtonSort.Click, Sub()
                                            SortMenu.Font = Me.Font
                                            SortMenu.Show(Me.UiButtonSort, New Point(0, Me.UiButtonSort.Height - 2))
                                        End Sub
    End Sub

    Public Sub CalibrateUI()
        Dim TotalColumnWidth = Me.ListView1.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
        Me.ListView1.Columns(0).Width = TotalColumnWidth * 0.8
        Me.ListView1.Columns(1).Width = TotalColumnWidth * 0.2
    End Sub

    Public Shared ReadOnly QuickRemoveMenu As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}

    Sub RemoveCommonNonMediaFiles()
        For i = Me.ListView1.Items.Count - 1 To 0 Step -1
            Dim ext = IO.Path.GetExtension(Me.ListView1.Items(i).Text).ToLower
            Select Case ext
                Case ".txt", ".json", ".xml", ".csv", ".log", ".ini", ".zip", ".rar", ".7z", ".iso", ".dat"
                    Me.ListView1.Items.RemoveAt(i)
            End Select
        Next
    End Sub

    Public Shared ReadOnly SortMenu As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}

    Sub OrderByItemNameAscending()
        Dim ItemList As New List(Of ListViewItem)
        For Each item As ListViewItem In Me.ListView1.Items
            ItemList.Add(item)
        Next
        ItemList = ItemList.OrderBy(Function(x) x.Text).ToList()
        Me.ListView1.Items.Clear()
        For Each item In ItemList
            Me.ListView1.Items.Add(item)
        Next
    End Sub

    Sub OrderByItemNameDescending()
        Dim ItemList As New List(Of ListViewItem)
        For Each item As ListViewItem In Me.ListView1.Items
            ItemList.Add(item)
        Next
        ItemList = ItemList.OrderByDescending(Function(x) x.Text).ToList()
        Me.ListView1.Items.Clear()
        For Each item In ItemList
            Me.ListView1.Items.Add(item)
        Next
    End Sub

    Private Shared Function GetFileSizeInBytes(Path As String) As Long
        Try
            Return New IO.FileInfo(Path).Length
        Catch
            Return -1
        End Try
    End Function
    Private Sub EnsureSizeColumn(ByVal item As ListViewItem, ByVal sizeInBytes As Long)
        If item.SubItems.Count < 2 Then item.SubItems.Add("")
        If sizeInBytes >= 0 Then
            item.SubItems(1).Text = Format(sizeInBytes / 1024 / 1024, "0") & " MB"
        Else
            item.SubItems(1).Text = "Unknown"
        End If
    End Sub
    Sub OrderByFileSizeAscending()
        Dim SortingResult = Me.ListView1.Items.Cast(Of ListViewItem)() _
            .Select(Function(it)
                        Dim len = GetFileSizeInBytes(it.Text)
                        EnsureSizeColumn(it, len)
                        Return New With {.Item = it, .Key = If(len >= 0, len, Long.MaxValue)}
                    End Function) _
            .OrderBy(Function(x) x.Key) _
            .ThenBy(Function(x) x.Item.Text) _
            .ToList()
        Me.ListView1.BeginUpdate()
        Me.ListView1.Items.Clear()
        For Each x In SortingResult
            Me.ListView1.Items.Add(x.Item)
        Next
        Me.ListView1.EndUpdate()
    End Sub

    Sub OrderByFileSizeDescending()
        Dim SortingResult = Me.ListView1.Items.Cast(Of ListViewItem)() _
            .Select(Function(it)
                        Dim len = GetFileSizeInBytes(it.Text)
                        EnsureSizeColumn(it, len)
                        Return New With {.Item = it, .Key = If(len >= 0, len, Long.MinValue)}
                    End Function) _
            .OrderByDescending(Function(x) x.Key) _
            .ThenBy(Function(x) x.Item.Text) _
            .ToList()
        Me.ListView1.BeginUpdate()
        Me.ListView1.Items.Clear()
        For Each x In SortingResult
            Me.ListView1.Items.Add(x.Item)
        Next
        Me.ListView1.EndUpdate()
    End Sub
End Class









