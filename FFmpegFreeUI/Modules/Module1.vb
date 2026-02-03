Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.Json
Imports System.Threading
Imports Sunny.UI
Module Module1

    Public Sound_SuccessSound As Stream = My.Resources.Resource1.Success
    Public Sound_ErrorSound As Stream = My.Resources.Resource1.Error

    <DllImport("user32.dll")>
    Public Function ReleaseCapture() As Boolean
    End Function
    <DllImport("user32.dll")>
    Public Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2
    Sub BindDragControlMoveWindow(s As Control)
        AddHandler s.MouseDown, Sub(s1, e1)
                                    Select Case e1.Button
                                        Case MouseButtons.Left
                                            ReleaseCapture()
                                            Dim unused = SendMessage(s1.FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
                                        Case MouseButtons.Right
                                            If Form1.FormBorderStyle <> FormBorderStyle.None Then Exit Sub
                                            Select Case Form1.WindowState
                                                Case FormWindowState.Maximized
                                                    Form1.WindowState = FormWindowState.Normal
                                                Case FormWindowState.Normal
                                                    Form1.WindowState = FormWindowState.Maximized
                                            End Select
                                    End Select
                                End Sub
    End Sub

    Public Property UISynchronizationContext As SynchronizationContext = SynchronizationContext.Current

    Public Sub ExecuteOnUIThread(d As SendOrPostCallback)
        If UISynchronizationContext IsNot Nothing Then
            UISynchronizationContext.Post(d, Nothing)
        Else
            Form1.RecreateWindowHandle()
            Form1.Invoke(Sub() UISynchronizationContext = SynchronizationContext.Current, Nothing)
            UISynchronizationContext.Post(d, Nothing)
        End If
    End Sub

    Public MaxConcurrentTasksLimit As Integer = 1

    <Extension>
    Public Sub DoubleBuffer(control As Control)
        Dim propertyInfo As PropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propertyInfo?.SetValue(control, True, Nothing)
    End Sub
    <Extension>
    Public Function IsEqual(page1 As TabPage, page2 As TabPage) As Boolean
        If page1 Is page2 Then Return True
        If page1 Is Nothing OrElse page2 Is Nothing Then Return False
        Return page1.Name = page2.Name
    End Function


    Public JsonSO As New JsonSerializerOptions With {
        .WriteIndented = True,
        .PropertyNamingPolicy = Nothing,
        .DictionaryKeyPolicy = Nothing,
        .Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    }
    Public Sub SetRichTextBoxLineHeight(RichTextBoxObject As Control, LineHeight As Integer)
        Dim fmt As New PARAFORMAT2()
        fmt.cbSize = Marshal.SizeOf(fmt)
        fmt.bLineSpacingRule = 4
        fmt.dyLineSpacing = LineHeight
        fmt.dwMask = PFM_LINESPACING
        SendMessage(New HandleRef(RichTextBoxObject, RichTextBoxObject.Handle), EM_SETPARAFORMAT, 4, fmt)
    End Sub

    Public Const WM_USER As Integer = &H400
    Public Const EM_GETPARAFORMAT As Integer = WM_USER + 61
    Public Const EM_SETPARAFORMAT As Integer = WM_USER + 71
    Public Const PFM_LINESPACING As UInteger = &H100

    <StructLayout(LayoutKind.Sequential)>
    Public Structure PARAFORMAT2
        Public cbSize As Integer
        Public dwMask As UInteger
        Public wNumbering As Short
        Public wReserved As Short
        Public dxStartIndent As Integer
        Public dxRightIndent As Integer
        Public dxOffset As Integer
        Public wAlignment As Short
        Public cTabCount As Short
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)>
        Public rgxTabs() As Integer
        ' PARAFORMAT2 incremental fields
        Public dySpaceBefore As Integer
        Public dySpaceAfter As Integer
        Public dyLineSpacing As Integer
        Public sStyle As Short
        Public bLineSpacingRule As Byte
        Public bOutlineLevel As Byte
        Public wShadingWeight As Short
        Public wShadingStyle As Short
        Public wNumberingStart As Short
        Public wNumberingStyle As Short
        Public wNumberingTab As Short
        Public wBorderSpace As Short
        Public wBorderWidth As Short
        Public wBorders As Short
    End Structure


    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function SendMessage(hWnd As HandleRef, msg As Integer, wParam As IntPtr, ByRef lParam As PARAFORMAT2) As IntPtr
    End Function

    <DllImport("ntdll.dll", SetLastError:=True)>
    Public Function NtSuspendProcess(processHandle As IntPtr) As Integer
    End Function
    <DllImport("ntdll.dll", SetLastError:=True)>
    Public Function NtResumeProcess(processHandle As IntPtr) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function SetThreadExecutionState(esFlags As EXECUTION_STATE) As EXECUTION_STATE
    End Function
    <Flags>
    Public Enum EXECUTION_STATE As UInteger
        ES_SYSTEM_REQUIRED = &H1
        ES_DISPLAY_REQUIRED = &H2
        ES_CONTINUOUS = &H80000000UI
    End Enum

    Public Sub SetSystemState()
        Select Case UserSettings.Instance.KeepSystemAwakeWhenTaskRunning
            Case 0
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_SYSTEM_REQUIRED)
            Case 1
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_DISPLAY_REQUIRED)
            Case 2
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
        End Select
    End Sub

    Public Sub RestoreSystemState()
        Dim unused = SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
    End Sub

    Public Sub SetLabelHeightBasedOnText(LabelControl As Label)
        Using g As Graphics = LabelControl.CreateGraphics()
            Dim availableWidth As Integer = LabelControl.Width - LabelControl.Padding.Left - LabelControl.Padding.Right
            Dim size As SizeF = g.MeasureString(LabelControl.Text, LabelControl.Font, availableWidth)
            LabelControl.Height = CInt(Math.Ceiling(size.Height)) + LabelControl.Padding.Top + LabelControl.Padding.Bottom + 2 * Form1.DPI + UserSettings.Instance.InterfaceFix_UseTextRenderSizeToAdjustLabelSize * Form1.DPI
        End Using
    End Sub

    Public Sub SetButtonWidthBasedOnText(Control As UIButton, Optional LanguageCalibration As Boolean = True, Optional ExtraAddition As Integer = 0)
        Using g As Graphics = Control.CreateGraphics()
            Dim size As SizeF = g.MeasureString(Control.Text, Control.Font)
            Dim ExtraWidthCorrectionValue As Integer = 0
            If LanguageCalibration Then
                ExtraWidthCorrectionValue = 20 * Form1.DPI
            End If
            Control.Width = CInt(Math.Ceiling(size.Width)) + Control.Padding.Left + Control.Padding.Right + ExtraWidthCorrectionValue + ExtraAddition
        End Using
    End Sub

    Public Function LoadImageFromFile(File As String) As Image
        Using fs As New FileStream(File, FileMode.Open, FileAccess.Read)
            Return Image.FromStream(fs)
        End Using
    End Function

    Public Sub ShowForm(WhichFormInstance As Form, ShowBasedOnWho As Form)
        If WhichFormInstance.Visible = True Then
            WhichFormInstance.Focus()
            WhichFormInstance.Left = (ShowBasedOnWho.Width - WhichFormInstance.Width) * 0.5 + ShowBasedOnWho.Left
            WhichFormInstance.Top = (ShowBasedOnWho.Height - WhichFormInstance.Height) * 0.5 + ShowBasedOnWho.Top
        Else
            WhichFormInstance.Left = (ShowBasedOnWho.Width - WhichFormInstance.Width) * 0.5 + ShowBasedOnWho.Left
            WhichFormInstance.Top = (ShowBasedOnWho.Height - WhichFormInstance.Height) * 0.5 + ShowBasedOnWho.Top
            WhichFormInstance.Show(ShowBasedOnWho)
        End If
    End Sub



    ''' <summary>
    ''' Generate Processor Affinity Mask
    ''' </summary>
    ''' <param name="cores">Logical core index, starting from 0</param>
    ''' <returns>IntPtr mask</returns>
    Function GetAffinityMask(cores As Integer()) As IntPtr
        Dim mask As Long = 0
        For Each core In cores
            If core >= 0 AndAlso core < Environment.ProcessorCount Then
                mask = mask Or CLng(1) << core
            Else
                Throw New ArgumentOutOfRangeException($"Core number {core} is invalid. The system has {Environment.ProcessorCount} cores (starting from 0).")
            End If
        Next
        Return New IntPtr(mask)
    End Function

    Public Sub SetControlFont(FontName As String, c As Control, Optional ExcludeContorl As Control() = Nothing, Optional Self As Boolean = False)
        If Self Then c.Font = New Font(FontName, c.Font.Size)
        For Each ctrl As Control In c.Controls
            If ExcludeContorl IsNot Nothing Then
                If ExcludeContorl.Contains(ctrl) Then Continue For
            End If
            Dim controlType As Type = ctrl.GetType()

            Dim propInfo As PropertyInfo = controlType.GetProperty("Font")
            If propInfo IsNot Nothing Then ctrl.Font = New Font(FontName, ctrl.Font.Size, ctrl.Font.Style)

            Dim propInfo2 As PropertyInfo = controlType.GetProperty("Tag")
            Dim propInfo3 As PropertyInfo = controlType.GetProperty("Text")
            If propInfo2 IsNot Nothing AndAlso propInfo3 IsNot Nothing AndAlso ctrl.Tag IsNot Nothing AndAlso ctrl.Tag.ToString().Trim() <> "" Then
                Dim a = Translate(ctrl.Tag.ToString())
                If a <> "" AndAlso a <> ctrl.Tag.ToString() Then ctrl.Text = a
            End If

            If ctrl.HasChildren Then SetControlFont(FontName, ctrl, ExcludeContorl)
        Next
    End Sub

    <DllImport("winmm.dll", CharSet:=CharSet.Auto)>
    Public Function PlaySound(pszSound As String, hmod As IntPtr, fdwSound As UInteger) As Boolean
    End Function

    Public Function ProcessPathForTranslationMode(p As String) As String
        Dim a = p
        Dim root As String = Path.GetPathRoot(a)
        If Not String.IsNullOrEmpty(root) Then
            a = a.Substring(root.Length)
        End If
        a = a.Replace("\", "/").Replace("//", "/")
        If Not a.StartsWith("/"c) Then a = "/" & a
        Return a
    End Function

    Public Function CaptureScreen_ForDialogBackground() As Bitmap
        Try
            Dim bounds As Rectangle = Form1.ClientRectangle
            Dim bitmap As New Bitmap(bounds.Width, bounds.Height)
            Using g As Graphics = Graphics.FromImage(bitmap)
                g.CopyFromScreen(Form1.PointToScreen(bounds.Location), Point.Empty, bounds.Size)
                g.CompositingMode = Drawing2D.CompositingMode.SourceOver
                Using brush As New SolidBrush(Color.FromArgb(180, 0, 0, 0))
                    g.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height)
                End Using
            End Using
            Return bitmap
        Catch ex As Exception
            Return New Bitmap(Form1.Width, Form1.Height)
        End Try
    End Function

    Public Function GenerateRandomString(Length As Integer, Optional IncludeNumbers As Boolean = True, Optional IncludeUpperCase As Boolean = True, Optional IncludeLowerCase As Boolean = True) As String
        If Length <= 0 Then
            Return ""
            Exit Function
        End If
        If Not IncludeNumbers AndAlso Not IncludeUpperCase AndAlso Not IncludeLowerCase Then
            Return ""
            Exit Function
        End If
        Dim numbers As String = "0123456789"
        Dim upperCase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowerCase As String = "abcdefghijklmnopqrstuvwxyz"
        Dim validChars As New StringBuilder()
        If IncludeNumbers Then validChars.Append(numbers)
        If IncludeUpperCase Then validChars.Append(upperCase)
        If IncludeLowerCase Then validChars.Append(lowerCase)
        If validChars.Length = 0 Then
            Return "Invalid character set"
        End If
        Dim rnd As New Random()
        Dim result As New StringBuilder(Length)
        For i As Integer = 1 To Length
            Dim randomIndex As Integer = rnd.Next(0, validChars.Length)
            result.Append(validChars(randomIndex))
        Next
        Return result.ToString()
    End Function

    Public Sub CalibrateUiComboBoxVisual(c As UIComboBox)
        c.ItemHeight = 28 * Form1.DPI
        c.SymbolSize = 24 * Form1.DPI
        c.ScrollBarHandleWidth = 30 * Form1.DPI
        c.ScrollBarBackColor = Color.FromArgb(64, 64, 64)
        c.ScrollBarColor = SystemColors.WindowFrame
        c.DropDownWidth = c.Width
    End Sub
    Public Sub BindComboBoxMouseWheelEvent(ComboBoxControl As UIComboBox)
        AddHandler ComboBoxControl.MouseWheel, AddressOf ComboBoxMouseWheelEvent
    End Sub
    Sub ComboBoxMouseWheelEvent(sender As Object, e As MouseEventArgs)
        Select Case e.Delta
            Case > 0 : If sender.SelectedIndex > 0 Then sender.SelectedIndex -= 1
            Case < 0 : If sender.SelectedIndex < sender.Items.Count - 1 Then sender.SelectedIndex += 1
        End Select
    End Sub



    Public Function ConvertTimeStringToTimeSpan(timeStr As String) As TimeSpan
        Try
            If String.IsNullOrWhiteSpace(timeStr) Then Return TimeSpan.Zero
            Dim numericValue As Double
            If Double.TryParse(timeStr.Trim(), numericValue) Then
                Return TimeSpan.FromSeconds(numericValue)
            End If
            Dim hours As Integer = 0
            Dim minutes As Integer = 0
            Dim seconds As Integer = 0
            Dim milliseconds As Integer = 0
            Dim timeParts = timeStr.Split(":"c)
            Select Case timeParts.Length
                Case 1 ' Only seconds, may contain decimals
                    Dim secValue As Double
                    If Double.TryParse(timeParts(0), secValue) Then
                        Return TimeSpan.FromSeconds(secValue)
                    End If
                Case 2 ' MM:SS format
                    If Integer.TryParse(timeParts(0), minutes) And
                   Double.TryParse(timeParts(1), numericValue) Then
                        seconds = CInt(Math.Floor(numericValue))
                        milliseconds = CInt((numericValue - seconds) * 1000)
                    End If
                Case 3 ' HH:MM:SS format
                    Integer.TryParse(timeParts(0), hours)
                    Integer.TryParse(timeParts(1), minutes)
                    Dim secPart = timeParts(2)
                    If secPart.Contains("."c) Then
                        Dim secMs = secPart.Split("."c)
                        Integer.TryParse(secMs(0), seconds)
                        Dim msStr = secMs(1).PadRight(3, "0"c)
                        If msStr.Length >= 3 Then
                            Integer.TryParse(msStr.AsSpan(0, 3), milliseconds)
                        End If
                    Else
                        Integer.TryParse(secPart, seconds)
                    End If
                Case Else
                    Return TimeSpan.Zero
            End Select
            Return New TimeSpan(0, hours, minutes, seconds, milliseconds)
        Catch
            Return TimeSpan.Zero
        End Try
    End Function

    Public Function ConvertTimeSpanToTimeString(timespan As TimeSpan) As String
        If timespan < TimeSpan.Zero Then timespan = TimeSpan.Zero
        Return String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
                            CInt(Math.Floor(timespan.TotalHours)),
                            timespan.Minutes,
                            timespan.Seconds,
                            timespan.Milliseconds)
    End Function

    <DllImport("psapi.dll")>
    Private Function EmptyWorkingSet(hProcess As IntPtr) As Boolean
    End Function
    Public Sub CollectSelfMemoryUsage()
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, True, True)
        GC.WaitForPendingFinalizers()
        EmptyWorkingSet(Process.GetCurrentProcess.Handle)
    End Sub

    Public Function ConfuseString_Meow(input As String) As String
        Return New String("m", input.Length)
    End Function

    <DllImport("dwmapi.dll")>
    Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, <MarshalAs(UnmanagedType.Bool)> ByRef attrValue As Boolean, attrSize As Integer) As Integer
    End Function
    Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20
    Public Sub EnableWin32APIDarkMode(WindowHandle As IntPtr)
        Try
            Dim unused = DwmSetWindowAttribute(WindowHandle, DWMWA_USE_IMMERSIVE_DARK_MODE, True, Marshal.SizeOf(Of Boolean)())
        Catch ex As Exception
        End Try
    End Sub

    Public Function ScanSingleLayerFiles(FolderPath As String, Extension As String) As List(Of String)
        Dim a As New List(Of String)
        Dim mFileInfo As System.IO.FileInfo
        Dim mDirInfo As New System.IO.DirectoryInfo(FolderPath)
        For Each mFileInfo In mDirInfo.GetFiles(Extension)
            a.Add(mFileInfo.FullName)
        Next
        Return a
    End Function

    Public Sub OutputTextToRTF(RTF As System.Windows.Forms.RichTextBox, Text As String, Color As Color)
        If String.IsNullOrEmpty(Text) Then Exit Sub
        Dim TextLength = Len(Text)
        If RTF.TextLength > 0 Then
            RTF.AppendText(vbCrLf & Text)
        Else
            RTF.AppendText(Text)
        End If
        Dim StartPosition As Integer = RTF.TextLength - TextLength
        RTF.Select(StartPosition, TextLength)
        RTF.SelectionColor = Color
        RTF.Select(RTF.TextLength, 0)
    End Sub

    Public Function ConvertPathToFFmpegFilterFormat(path As String) As String
        If String.IsNullOrEmpty(path) Then
            Return path
        End If
        If path.StartsWith("\\") Then
            Dim pathAfterPrefix As String = path.Substring(2)
            pathAfterPrefix = pathAfterPrefix.Replace("\", "\\")
            Return "\\" & pathAfterPrefix
        End If
        If path.Length >= 2 AndAlso path(1) = ":"c Then
            Dim driveLetter As String = path.Substring(0, 1)
            Dim pathAfterDrive As String = path.Substring(2)
            pathAfterDrive = pathAfterDrive.Replace("\", "\\")
            Return driveLetter & "\:" & pathAfterDrive
        End If
        Return path.Replace("\", "\\")
    End Function

    Public Sub OutputToRichTextBox(RTF As RichTextBox, Text As String)
        Dim TextLength = Len(Text)
        RTF.AppendText(If(RTF.Text <> "", vbCrLf, "") & Text)
        Dim StartPosition As Integer = RTF.TextLength - TextLength
        RTF.Select(StartPosition, TextLength)
        RTF.SelectionColor = IdentifyFFSingleLineOutputAndAdjustColor(Text, RTF.ForeColor)
        RTF.Select(RTF.TextLength, 0)
    End Sub

    Public Function IdentifyFFSingleLineOutputAndAdjustColor(SingleLineOutput As String, DefaultColor As Color) As Color
        If String.IsNullOrEmpty(SingleLineOutput) Then Return DefaultColor
        If EncodingTask.ErrorOutputMatchingStringList.Any(Function(keyword) SingleLineOutput.Contains(keyword, StringComparison.OrdinalIgnoreCase)) Then
            Return Color.IndianRed
        End If
        Select Case True
            Case SingleLineOutput.Contains("Input #", StringComparison.OrdinalIgnoreCase)
                Return Color.LightGreen
            Case SingleLineOutput.Contains("Duration:", StringComparison.OrdinalIgnoreCase)
                Return Color.CornflowerBlue
            Case SingleLineOutput.Contains("Stream #", StringComparison.OrdinalIgnoreCase)
                Return Color.Plum
            Case SingleLineOutput.Contains("Output #", StringComparison.OrdinalIgnoreCase)
                Return Color.Goldenrod
        End Select
        Return DefaultColor
    End Function

    Public Function ConvertHTMLColorToFFmpegFormat(HTMLColor As String, Optional Alpha As String = "") As String
        If String.IsNullOrWhiteSpace(HTMLColor) Then Return ""
        Dim parsedColor As Color
        Try
            parsedColor = ColorTranslator.FromHtml(HTMLColor.Trim())
        Catch
            Return ""
        End Try
        Dim a As Byte = parsedColor.A
        Dim r As Byte = parsedColor.R
        Dim g As Byte = parsedColor.G
        Dim b As Byte = parsedColor.B
        Dim Ap As String = Alpha.Trim()
        If Ap = "" Then Ap = "0"
        Dim alphaValue As Byte
        If Byte.TryParse(Ap, NumberStyles.Integer, CultureInfo.InvariantCulture, alphaValue) Then
            a = alphaValue
        ElseIf Byte.TryParse(Ap, NumberStyles.HexNumber, CultureInfo.InvariantCulture, alphaValue) Then
            a = alphaValue
        Else
            Return ""
        End If

        Return $"&H{a:X2}{b:X2}{g:X2}{r:X2}"
    End Function

End Module
















