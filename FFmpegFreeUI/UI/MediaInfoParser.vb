Imports System.Text.RegularExpressions

Public Class MediaInfoParser
    Public Class MediaInformation
        Public Property VideoStreams As List(Of VideoStreamInfo)
        Public Property AudioStreams As List(Of AudioStreamInfo)
        Public Property SubtitleStreams As List(Of SubtitleStreamInfo)
    End Class
    Public Class VideoStreamInfo
        Public Property Encoder As String = ""
        Public Property EncoderLib As String = ""
        Public Property Bitrate As String = ""
        Public Property PixelFormat As String = ""
        Public Property Resolution As String = ""
        Public Property FrameRate As String = ""
        Public Property Language As String = ""
        Public Property MetadataTitle As String = ""
    End Class
    Public Class AudioStreamInfo
        Public Property Encoder As String = ""
        Public Property EncoderLib As String = ""
        Public Property Bitrate As String = ""
        Public Property SampleRate As String = ""
        Public Property ChannelLayout As String = ""
        Public Property Language As String = ""
        Public Property MetadataTitle As String = ""
    End Class
    Public Class SubtitleStreamInfo
        Public Property Encoder As String = ""
        Public Property EncoderLib As String = ""
        Public Property Language As String = ""
        Public Property MetadataTitle As String = ""
    End Class

    ''' <summary>
    ''' Parse ffprobe output content
    ''' </summary>
    ''' <param name="ffprobeOutput">Complete output text from ffprobe</param>
    ''' <returns>Parsed media information</returns>
    Public Shared Function Parse(ffprobeOutput As List(Of String)) As MediaInformation
        Dim result As New MediaInformation With {
            .VideoStreams = New List(Of VideoStreamInfo),
            .AudioStreams = New List(Of AudioStreamInfo),
            .SubtitleStreams = New List(Of SubtitleStreamInfo)
        }

        Dim currentStreamType As String = ""
        Dim currentVideoStream As VideoStreamInfo = Nothing
        Dim currentAudioStream As AudioStreamInfo = Nothing
        Dim currentSubtitleStream As SubtitleStreamInfo = Nothing

        For Each line In ffprobeOutput
            Dim trimmedLine = line.Trim()

            ' Detect stream type line
            ' MKV format: Stream #0:0(eng): Video: hevc (Main 10)...
            ' MP4 format: Stream #0:0[0x1](und): Video: hevc (Main 10) (hev1 / 0x31766568)...
            Dim streamMatch = Regex.Match(trimmedLine, "Stream #\d+:\d+(?:\[0x[0-9a-fA-F]+\])?(?:\((\w+)\))?: (Video|Audio|Subtitle): (.+)")
            If streamMatch.Success Then
                Dim lang = streamMatch.Groups(1).Value
                Dim streamType = streamMatch.Groups(2).Value
                Dim streamDetails = streamMatch.Groups(3).Value
                currentStreamType = streamType

                Select Case streamType
                    Case "Video"
                        currentVideoStream = ParseVideoStream(streamDetails, lang)
                        result.VideoStreams.Add(currentVideoStream)
                    Case "Audio"
                        currentAudioStream = ParseAudioStream(streamDetails, lang)
                        result.AudioStreams.Add(currentAudioStream)
                    Case "Subtitle"
                        currentSubtitleStream = ParseSubtitleStream(streamDetails, lang)
                        result.SubtitleStreams.Add(currentSubtitleStream)
                End Select
                Continue For
            End If

            ' Parse metadata title
            Dim titleMatch = Regex.Match(trimmedLine, "^\s*title\s*:\s*(.+)$", RegexOptions.IgnoreCase)
            If titleMatch.Success Then
                Dim titleValue = titleMatch.Groups(1).Value.Trim()
                Select Case currentStreamType
                    Case "Video"
                        If currentVideoStream IsNot Nothing Then currentVideoStream.MetadataTitle = titleValue
                    Case "Audio"
                        If currentAudioStream IsNot Nothing Then currentAudioStream.MetadataTitle = titleValue
                    Case "Subtitle"
                        If currentSubtitleStream IsNot Nothing Then currentSubtitleStream.MetadataTitle = titleValue
                End Select
            End If

            ' Parse metadata encoder
            Dim encoderLibMatch = Regex.Match(trimmedLine, "^\s*encoder\s*:\s*(.+)$", RegexOptions.IgnoreCase)
            If encoderLibMatch.Success Then
                Dim encoderLibValue = encoderLibMatch.Groups(1).Value.Trim()
                Select Case currentStreamType
                    Case "Video"
                        If currentVideoStream IsNot Nothing Then currentVideoStream.EncoderLib = encoderLibValue
                    Case "Audio"
                        If currentAudioStream IsNot Nothing Then currentAudioStream.EncoderLib = encoderLibValue
                    Case "Subtitle"
                        If currentSubtitleStream IsNot Nothing Then currentSubtitleStream.EncoderLib = encoderLibValue
                End Select
            End If

        Next

        Return result
    End Function

    Private Shared Function ParseVideoStream(streamDetails As String, lang As String) As VideoStreamInfo
        Dim info As New VideoStreamInfo With {.Language = lang}
        Dim parts = SplitStreamDetails(streamDetails)

        If parts.Count > 0 Then
            ' Encoder includes bracketed content, e.g.: hevc (Main 10)
            info.Encoder = ExtractBracketedContent(parts(0))
        End If

        For Each part In parts
            Dim trimmedPart = part.Trim()

            ' Pixel format includes bracketed content, e.g.: yuv420p10le(tv, bt2020nc/bt2020/smpte2084)
            If Regex.IsMatch(trimmedPart, "^(yuv|rgb|bgr|gray|p0|nv)\w*", RegexOptions.IgnoreCase) Then
                info.PixelFormat = ExtractBracketedContent(trimmedPart)
            End If

            ' Resolution, e.g.: 3840x2160 or 1920x1080 [SAR 1:1 DAR 16:9]
            Dim resolutionMatch = Regex.Match(trimmedPart, "(\d{2,5}x\d{2,5})")
            If resolutionMatch.Success AndAlso String.IsNullOrEmpty(info.Resolution) Then
                info.Resolution = resolutionMatch.Groups(1).Value
            End If

            ' Frame rate, e.g.: 23.98 fps or 24 fps
            Dim fpsMatch = Regex.Match(trimmedPart, "([\d.]+)\s*fps")
            If fpsMatch.Success Then
                Dim fpsValue As Double
                If Double.TryParse(fpsMatch.Groups(1).Value, fpsValue) Then
                    info.FrameRate = CInt(Math.Round(fpsValue)).ToString() & "fps"
                End If
            End If

            ' Bitrate, e.g.: 15000 kb/s
            Dim bitrateMatch = Regex.Match(trimmedPart, "(\d+)\s*kb/s(?:\s*\([^)]*\))?", RegexOptions.IgnoreCase)
            If bitrateMatch.Success Then
                info.Bitrate = bitrateMatch.Groups(1).Value & "kbps"
            End If
        Next

        Return info
    End Function

    Private Shared Function ParseAudioStream(streamDetails As String, lang As String) As AudioStreamInfo
        Dim info As New AudioStreamInfo With {.Language = lang}
        Dim parts = SplitStreamDetails(streamDetails)

        If parts.Count > 0 Then
            info.Encoder = ExtractBracketedContent(parts(0))
        End If

        For Each part In parts
            Dim trimmedPart = part.Trim()

            ' Sample rate, e.g.: 48000 Hz
            Dim sampleRateMatch = Regex.Match(trimmedPart, "(\d+)\s*Hz")
            If sampleRateMatch.Success Then
                info.SampleRate = sampleRateMatch.Groups(1).Value & "Hz"
            End If

            ' Channel layout, e.g.: stereo, 5.1, 7.1
            If Regex.IsMatch(trimmedPart, "^(mono|stereo|[\d.]+|[a-z]+\(side\))$", RegexOptions.IgnoreCase) Then
                info.ChannelLayout = trimmedPart
            End If

            ' Bitrate (allows e.g.: 192 kb/s (default))
            Dim bitrateMatch = Regex.Match(trimmedPart, "(\d+)\s*kb/s(?:\s*\([^)]*\))?", RegexOptions.IgnoreCase)
            If bitrateMatch.Success Then
                info.Bitrate = bitrateMatch.Groups(1).Value & "kbps"
            End If
        Next

        Return info
    End Function

    Private Shared Function ParseSubtitleStream(streamDetails As String, lang As String) As SubtitleStreamInfo
        Dim info As New SubtitleStreamInfo With {.Language = lang}
        Dim parts = SplitStreamDetails(streamDetails)

        If parts.Count > 0 Then
            info.Encoder = ExtractBracketedContent(parts(0))
        End If

        Return info
    End Function

    ''' <summary>
    ''' Extracts complete content including trailing brackets
    ''' </summary>
    Private Shared Function ExtractBracketedContent(input As String) As String
        Dim trimmedInput = input.Trim()
        Dim match = Regex.Match(trimmedInput, "^(\w+(?:\s*\([^)]*\))?)")
        If match.Success Then
            Return match.Groups(1).Value.Trim()
        End If
        Return trimmedInput.Split({","c, " "c})(0)
    End Function

    ''' <summary>
    ''' Intelligently splits stream details, preserving bracket integrity
    ''' </summary>
    Private Shared Function SplitStreamDetails(details As String) As List(Of String)
        Dim result As New List(Of String)
        Dim currentPart As New Text.StringBuilder()
        Dim bracketDepth As Integer = 0

        For Each c In details
            If c = "("c Then
                bracketDepth += 1
                currentPart.Append(c)
            ElseIf c = ")"c Then
                bracketDepth -= 1
                currentPart.Append(c)
            ElseIf c = ","c AndAlso bracketDepth = 0 Then
                If currentPart.Length > 0 Then
                    result.Add(currentPart.ToString().Trim())
                    currentPart.Clear()
                End If
            Else
                currentPart.Append(c)
            End If
        Next

        If currentPart.Length > 0 Then
            result.Add(currentPart.ToString().Trim())
        End If

        Return result
    End Function

End Class

