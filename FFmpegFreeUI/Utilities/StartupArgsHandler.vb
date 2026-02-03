Imports System.IO

Public Class StartupArgsHandler

    Public Shared Property FileToPrepareForEncoding As String = ""
    Public Shared Property PresetFileToUse As String = ""
    Public Shared Property IndependentCommandLine As String = ""
    Public Shared Property IndependentCommandLine_DisplayFileName As String = ""

    ' Arg handlers: Key is arg name, Value is handler function (receives CLI list and current index, returns new index)
    Private Shared ReadOnly ArgHandlers As New Dictionary(Of String, Func(Of List(Of String), Integer, Integer)) From {
        {"-3fuiVideoHelperInPointTime", Function(args, i)
                                            Form1.GeneralParametersPage.UiTextBoxQuickClipInPoint.Text = args(i + 1)
                                            Return i + 1
                                        End Function},
        {"-3fuiVideoHelperOutPointTime", Function(args, i)
                                             Form1.GeneralParametersPage.UiTextBoxQuickClipOutPoint.Text = args(i + 1)
                                             Return i + 1
                                         End Function},
        {"-i", Function(args, i)
                   FileToPrepareForEncoding = args(i + 1)
                   Return i + 1
               End Function},
        {"-3fui_file", Function(args, i)
                           PresetFileToUse = args(i + 1)
                           Return i + 1
                       End Function}
    }

    ' No-arg handlers (do not need subsequent args)
    Private Shared ReadOnly NoArgHandlers As New Dictionary(Of String, Action) From {
        {"-test", Sub()
                      Debug.Print("Beep")
                      MsgBox("Beep", MsgBoxStyle.Information)
                  End Sub}
    }

    Public Shared Sub HandleReceivedArgs(CL As List(Of String))
        FileToPrepareForEncoding = ""
        PresetFileToUse = ""
        IndependentCommandLine = ""
        IndependentCommandLine_DisplayFileName = ""
        Dim i = 0
        While i < CL.Count
            Dim arg = CL(i)
            ' Special handling for -ffmpeg arg (collects all subsequent args)
            If arg = "-ffmpeg" Then
                HandleFFmpegArgs(CL, i)
                Exit While
            End If
            ' First Check no-arg handlers
            Dim value As Action = Nothing
            If NoArgHandlers.TryGetValue(arg, value) Then
                value()
                ' Then Check handlers needing subsequent args
            ElseIf ArgHandlers.ContainsKey(arg) Then
                If i < CL.Count - 1 Then
                    i = ArgHandlers(arg)(CL, i)
                End If
            End If
            i += 1
        End While
        If IndependentCommandLine <> "" Then
            PluginManager.AddMissionToQueueWithArgs(IndependentCommandLine, If(IndependentCommandLine_DisplayFileName <> "", IndependentCommandLine_DisplayFileName, $"External Command Task {Now:HHmmss}"), "")
        End If
        If FileToPrepareForEncoding <> "" AndAlso PresetFileToUse <> "" Then
            If Not FileIO.FileSystem.FileExists(FileToPrepareForEncoding) Then Exit Sub
            If Not FileIO.FileSystem.FileExists(PresetFileToUse) Then
                Dim abc = Path.Combine(My.Application.Info.DirectoryPath, "Preset", Path.GetFileNameWithoutExtension(PresetFileToUse) & ".json")
                If Not FileIO.FileSystem.FileExists(abc) Then
                    Exit Sub
                Else
                    PresetFileToUse = abc
                End If
            End If
            PluginManager.AddMissionToQueueWith3fuiFile(PresetFileToUse, Path.GetFileName(FileToPrepareForEncoding), "", FileToPrepareForEncoding)
        End If
    End Sub

    Public Shared Sub HandleFFmpegArgs(commandLine As List(Of String), startIndex As Integer)
        Dim abc As New List(Of String)
        For i3 = startIndex + 1 To commandLine.Count - 1
            Dim arg = commandLine(i3)
            ' Args containing spaces need to be re-quoted to restore
            If arg.Contains(" "c) Then
                abc.Add($"""{arg}""")
            Else
                abc.Add(arg)
            End If
            If IndependentCommandLine_DisplayFileName = "" AndAlso arg = "-i" AndAlso i3 < commandLine.Count - 1 Then
                IndependentCommandLine_DisplayFileName = Path.GetFileName(commandLine(i3 + 1))
            End If
        Next
        IndependentCommandLine = String.Join(" ", abc)
    End Sub
End Class



