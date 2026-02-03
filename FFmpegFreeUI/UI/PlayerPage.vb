Imports System.Runtime.InteropServices
Imports System.Text

Public Class PlayerPage
    <DllImport("user32.dll")>
    Private Shared Function EnumWindows(ByVal lpEnumFunc As EnumWindowsProc, ByVal lParam As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr,
                                         ByVal X As Integer, ByVal Y As Integer,
                                         ByVal cx As Integer, ByVal cy As Integer,
                                         ByVal uFlags As UInteger) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    Private Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Boolean
    Private Const SWP_NOZORDER As UInteger = &H4
    Private Const SWP_NOACTIVATE As UInteger = &H10
    Private Const SWP_FRAMECHANGED As UInteger = &H20
    Private Const GWL_STYLE As Integer = -16
    Private Const WS_CAPTION As Integer = &HC00000
    Private Const WS_THICKFRAME As Integer = &H40000

    Public ffplayHandle As IntPtr = IntPtr.Zero

    Private Sub PlayerPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler UiButtonOpenFile.Click, AddressOf OpenFile
        AddHandler UiButtonCloseProcess.Click, AddressOf StopPlayback
        AddHandler Form1.ResizeEnd, AddressOf VideoContainerSizeChangedEvent
    End Sub

    Public ffplayProcess As Process
    Public IsPlaybackCancelled As Boolean = False

    Async Sub Play(filePath As String)
        StopPlayback()
        IsPlaybackCancelled = False

        ffplayProcess = New Process
        ffplayProcess.StartInfo.FileName = "ffplay"
        ffplayProcess.StartInfo.WorkingDirectory = If(UserSettings.Instance.WorkingDirectory <> "", UserSettings.Instance.WorkingDirectory, "")
        ffplayProcess.StartInfo.Arguments = $"-x {Panel3.Width} -y {Panel3.Height} -noborder ""{filePath}"""
        ffplayProcess.StartInfo.UseShellExecute = False
        ffplayProcess.StartInfo.CreateNoWindow = False
        ffplayProcess.Start()

        While True
            Dim handle As IntPtr
            Await Task.Run(Sub() handle = FindWindowByTitle(ffplayProcess.Id, filePath))
            If handle <> IntPtr.Zero Then
                ffplayHandle = handle
                Exit While
            End If
            If IsPlaybackCancelled Then Exit Sub
            If ffplayProcess Is Nothing Then Exit Sub
            Await Task.Delay(200)
        End While

        SetParent(ffplayHandle, Panel3.Handle)
        SetWindowPos(ffplayHandle, IntPtr.Zero, 0, 0, Panel3.Width, Panel3.Height, SWP_NOZORDER Or SWP_NOACTIVATE)
        Form1.Focus()
    End Sub

    Sub VideoContainerSizeChangedEvent()
        If Form1.WindowState = FormWindowState.Minimized Then Exit Sub
        If Form1.UiTabControlMenu1.SelectedTab IsNot Me Then Exit Sub
        If ffplayProcess IsNot Nothing Then
            SetWindowPos(ffplayHandle, IntPtr.Zero, 0, 0, Panel3.Width, Panel3.Height, SWP_NOZORDER Or SWP_NOACTIVATE)
        End If
    End Sub

    Sub OpenFile()
        Dim a As New OpenFileDialog With {.Multiselect = False}
        If a.ShowDialog() = DialogResult.OK Then Play(a.FileName)
    End Sub

    Sub StopPlayback()
        If ffplayProcess IsNot Nothing Then
            Try
                If Not ffplayProcess.HasExited Then
                    ffplayProcess.Kill()
                End If
            Catch ex As Exception
            End Try
            ffplayProcess.Dispose()
            ffplayProcess = Nothing
        End If
        ffplayHandle = IntPtr.Zero
        IsPlaybackCancelled = True
    End Sub

    Public Shared Function GetProcessWindows(ByVal processId As Integer) As List(Of IntPtr)
        Dim windows As New List(Of IntPtr)
        EnumWindows(Function(hWnd As IntPtr, lParam As IntPtr) As Boolean
                        Dim windowProcessId As Integer = 0
                        GetWindowThreadProcessId(hWnd, windowProcessId)
                        If windowProcessId = processId AndAlso IsWindowVisible(hWnd) Then windows.Add(hWnd)
                        Return True
                    End Function, IntPtr.Zero)
        Return windows
    End Function
    Public Shared Function FindWindowByTitle(ByVal processId As Integer, ByVal expectedTitle As String) As IntPtr
        Dim windows = GetProcessWindows(processId)
        For Each hWnd In windows
            Dim titleBuilder As New StringBuilder(256)
            GetWindowText(hWnd, titleBuilder, titleBuilder.Capacity)
            Dim title As String = titleBuilder.ToString()
            If title = expectedTitle OrElse title = IO.Path.GetFileName(expectedTitle) Then
                Return hWnd
            End If
        Next
        Return IntPtr.Zero
    End Function

    Private Overloads Sub Dispose()
        StopPlayback()
    End Sub

    Private Sub Panel3_DragEnter(sender As Object, e As DragEventArgs) Handles Panel3.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Panel3_DragDrop(sender As Object, e As DragEventArgs) Handles Panel3.DragDrop
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        If files.Length > 0 Then Play(files(0))
    End Sub
End Class





