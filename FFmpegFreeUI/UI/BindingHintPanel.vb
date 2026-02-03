Imports FFmpegFreeUI.TooltipPanel

Public Class BindingHintPanel

    Public Shared Sub BindParameterPanelTooltip(parameterPanel As GeneralParametersPage)
        Binding(parameterPanel.UiTextBoxGlobalQualityControlValue, New List(Of Tp_Data) From {
           New Tp_Data With {.Title = "Recommended Visually Lossless Balanced Points", .Text = "libx264 & lib265 | crf=23<br>hevc_nvenc | cq=26~28<br>av1_nvenc | cq=36"}})


        Binding(parameterPanel.UiComboBoxClipMethod, New List(Of Tp_Data) From {
           New Tp_Data With {.Title = "Fast Cut (Instant Response)", .Text = "Locate keyframes, fastest but not precise.<br>Except for this mode, trimming parameters are part of the video parameters."},
           New Tp_Data With {.Title = "Precise Cut (Decode from Header)", .Text = "Decode from the beginning to the trim position, requires waiting but is precise.<br>Only re-encoding is truly precise."},
           New Tp_Data With {.Title = "Precise Cut (Fast Response)", .Text = "Manually specify to start decoding from a certain time before the in-point.<br>Ensure decoding from a keyframe; it's both fast and precise.<br>Only re-encoding is truly precise."},
           New Tp_Data With {.Title = "Trim Filter", .Text = "Requires re-encoding, must wait for decoding from the beginning.<br>Can be used with burnt-in subtitles; subtitles will also be properly trimmed.", .TextType = HintType.Warning},
           New Tp_Data With {.Title = "Must re-encode to achieve frame-level precision", .TitleColor = Color.CornflowerBlue, .Text = "FFmpeg cannot achieve frame-level precision using bitstream copying.<br>Otherwise, the video will be stuck until the next keyframe.", .TextType = HintType.Critical}})

        Binding(parameterPanel.UiComboBoxClipForwardDecodingDurationSeconds, New List(Of Tp_Data) From {
           New Tp_Data With {.Title = "For Precise Cut (Fast Response) only", .Text = "Ensure the lookahead time includes a keyframe.<br>Otherwise, it's no better than Fast Cut.<br>Make sure all times are entered correctly.<br>I need to calculate the difference between your entered times."},
           New Tp_Data With {.Title = "Note the time direction", .TitleColor = Color.Goldenrod, .Text = "Do not confuse this with the forward reference frame time direction concept.<br>Lookahead decoding here means towards the beginning.<br>Not towards the end.", .TextType = HintType.Critical}})

    End Sub

End Class





