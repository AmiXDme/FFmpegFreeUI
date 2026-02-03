Public Class VideoEncoderDatabase
    Public Shared Property Dictionary As New Dictionary(Of String, VideoEncoderDataStructure)

    Public Class VideoEncoderDataStructure
        Public Property Preset As New List(Of String)
        Public Property Profile As New List(Of String)
        Public Property Tune As New List(Of String)
        Public Property Pix_fmt As New List(Of String)
    End Class


    Public Shared Sub Initialize()
        Dictionary.Add("copy", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {""},
.Tune = New List(Of String) From {""},
.Pix_fmt = New List(Of String) From {""}
})

        Dictionary.Add("libx266", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast", "superfast", "ultrafast"},
.Profile = New List(Of String) From {"main", "main10"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv420p yuv420p10le", " ").ToList
})
        Dictionary.Add("libvvenc", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"slower", "slow", "medium", "fast", "faster"},
.Profile = New List(Of String) From {"main", "main10"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv420p yuv420p10le", " ").ToList
})



        Dictionary.Add("libaom-av1", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"0", "1", "2", "3", "4", "5", "6", "7", "8"},
.Profile = New List(Of String) From {"0", "1", "2"},
.Tune = New List(Of String) From {"psnr", "ssim", "qmt"},
.Pix_fmt = Split("yuv420p yuv422p yuv444p gbrp yuv420p10le yuv422p10le yuv444p10le yuv420p12le yuv422p12le yuv444p12le gbrp10le gbrp12le gray gray10le gray12le", " ").ToList
})
        Dictionary.Add("libsvtav1", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"},
.Profile = New List(Of String) From {"main", "high", "professional"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv420p yuv420p10le", " ").ToList
})
        Dictionary.Add("av1_nvenc", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"p7", "p6", "p5", "p4", "p3", "p2", "p1"},
.Profile = New List(Of String) From {"main", "high", "professional"},
.Tune = New List(Of String) From {"hq", "uhq", "ll", "ull", "lossless"},
.Pix_fmt = Split("yuv420p nv12 p010le yuv444p p016le nv16 p210le p216le yuv444p10msble yuv444p16le bgr0 bgra rgb0 rgba x2rgb10le x2bgr10le gbrp gbrp10msble gbrp16le cuda d3d11", " ").ToList
})
        Dictionary.Add("av1_amf", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"high_quality", "quality", "balanced", "speed"},
.Profile = New List(Of String) From {"main"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("nv12 yuv420p d3d11 dxva2_vld p010le amf bgr0 rgb0 bgra argb rgba x2bgr10le rgbaf16le", " ").ToList
})
        Dictionary.Add("av1_d3d12va", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"main", "high", "professional"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("d3d12", " ").ToList
})
        Dictionary.Add("av1_qsv", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast"},
.Profile = New List(Of String) From {"main", "main10"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("nv12 p010le qsv", " ").ToList
})
        Dictionary.Add("librav1e", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {""},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv420p yuvj420p yuv420p10le yuv420p12le yuv422p yuvj422p yuv422p10le yuv422p12le yuv444p yuvj444p yuv444p10le yuv444p12le", " ").ToList
})
        Dictionary.Add("av1_vulkan", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"main", "main10", "professional"},
.Tune = New List(Of String) From {"hq", "ll", "ull", "lossless"},
.Pix_fmt = Split("vulkan", " ").ToList
})


        Dictionary.Add("libx265", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast", "superfast", "ultrafast"},
.Profile = New List(Of String) From {"main", "mainstillpicture"},
.Tune = New List(Of String) From {"psnr", "ssim", "grain", "fastdecode", "zerolatency", "animation", "stillimage"},
.Pix_fmt = Split("yuv420p yuvj420p yuv422p yuvj422p yuv444p yuvj444p gbrp yuv420p10le yuv422p10le yuv444p10le gbrp10le yuv420p12le yuv422p12le yuv444p12le gbrp12le gray gray10le gray12le yuva420p yuva420p10le", " ").ToList
})
        Dictionary.Add("hevc_nvenc", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"p7", "p6", "p5", "p4", "p3", "p2", "p1"},
.Profile = New List(Of String) From {"main", "rext"},
.Tune = New List(Of String) From {"hq", "uhq", "ll", "ull", "lossless"},
.Pix_fmt = Split("yuv420p nv12 p010le yuv444p p016le nv16 p210le p216le yuv444p16le bgr0 bgra rgb0 rgba x2rgb10le x2bgr10le gbrp gbrp16le cuda d3d11", " ").ToList
})
        Dictionary.Add("hevc_amf", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"quality", "balanced", "speed"},
.Profile = New List(Of String) From {"main"},
.Tune = New List(Of String) From {"transcoding", "ultralowlatency", "lowlatency", "webcam", "high_quality", "lowlatency_high_quality"},
.Pix_fmt = Split("nv12 yuv420p d3d11 dxva2_vld p010le amf bgr0 rgb0 bgra argb rgba x2bgr10le rgbaf16le", " ").ToList
})
        Dictionary.Add("hevc_qsv", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast"},
.Profile = New List(Of String) From {"main", "mainsp", "rext", "scc"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("nv12 p010le p012le yuyv422 y210le qsv bgra x2rgb10le vuyx xv30le", " ").ToList
})
        Dictionary.Add("hevc_d3d12va", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"main", "main10"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("d3d12", " ").ToList
})
        Dictionary.Add("hevc_vulkan", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"main", "main10", "rext"},
.Tune = New List(Of String) From {"hq", "ll", "ull", "lossless"},
.Pix_fmt = Split("vulkan", " ").ToList
})


        Dictionary.Add("libx264", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast", "superfast", "ultrafast"},
.Profile = New List(Of String) From {"baseline", "main", "high", "high10", "high422", "high444"},
.Tune = New List(Of String) From {"film", "animation", "grain", "stillimage", "psnr", "ssim", "fastdecode", "zerolatency"},
.Pix_fmt = Split("yuv420p yuvj420p yuv422p yuvj422p yuv444p yuvj444p nv12 nv16 nv21 yuv420p10le yuv422p10le yuv444p10le nv20le gray gray10le", " ").ToList
})
        Dictionary.Add("h264_nvenc", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"p7", "p6", "p5", "p4", "p3", "p2", "p1"},
.Profile = New List(Of String) From {"baseline", "main", "high", "high10", "high422", "high444p"},
.Tune = New List(Of String) From {"hq", "ll", "ull", "lossless"},
.Pix_fmt = Split("yuv420p nv12 p010le yuv444p p016le nv16 p210le p216le yuv444p16le bgr0 bgra rgb0 rgba x2rgb10le x2bgr10le gbrp gbrp16le cuda d3d11", " ").ToList
})
        Dictionary.Add("h264_amf", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"quality", "balanced", "speed"},
.Profile = New List(Of String) From {"main", "high", "constrained_baseline", "constrained_high"},
.Tune = New List(Of String) From {"transcoding", "ultralowlatency", "lowlatency", "webcam", "high_quality", "lowlatency_high_quality"},
.Pix_fmt = Split("nv12 yuv420p d3d11 dxva2_vld p010le amf bgr0 rgb0 bgra argb rgba x2bgr10le rgbaf16le", " ").ToList
})
        Dictionary.Add("h264_qsv", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast"},
.Profile = New List(Of String) From {"baseline", "main", "high"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("nv12 qsv", " ").ToList
})
        Dictionary.Add("h264_vulkan", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"main", "main10", "rext", "constrained_baseline"},
.Tune = New List(Of String) From {"hq", "ll", "ull", "lossless"},
.Pix_fmt = Split("vulkan", " ").ToList
})



        Dictionary.Add("prores_ks", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"auto", "proxy", "lt", "standard", "hq", "4444", "4444xq"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv422p10le yuv444p10le yuva444p10le", " ").ToList
})
        Dictionary.Add("prores_aw", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {""},
.Profile = New List(Of String) From {"auto", "proxy", "lt", "standard", "hq", "4444", "4444xq"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("yuv422p10le yuv444p10le yuva444p10le", " ").ToList
})



        Dictionary.Add("libxeve", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"default", "slow", "medium", "fast"},
.Profile = New List(Of String) From {"main", "baseline"},
.Tune = New List(Of String) From {"psnr", "zerolatency", "none"},
.Pix_fmt = Split("yuv420p yuv420p10le", " ").ToList
})



        Dictionary.Add("libvpx-vp9", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"0", "1", "2", "3", "4", "5"},
.Profile = New List(Of String) From {""},
.Tune = New List(Of String) From {"psnr", "ssim"},
.Pix_fmt = Split("yuv420p yuva420p yuv422p yuv440p yuv444p yuv420p10le yuv422p10le yuv440p10le yuv444p10le yuv420p12le yuv422p12le yuv440p12le yuv444p12le gbrp gbrp10le gbrp12le", " ").ToList
})
        Dictionary.Add("libsvt_vp9", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"},
.Profile = New List(Of String) From {""},
.Tune = New List(Of String) From {"vq", "ssim", "vmaf"},
.Pix_fmt = Split("yuv420p", " ").ToList
})
        Dictionary.Add("vp9_qsv", New VideoEncoderDataStructure With {
.Preset = New List(Of String) From {"veryslow", "slower", "slow", "medium", "fast", "faster", "veryfast"},
.Profile = New List(Of String) From {"profile0", "profile1", "profile2", "profile3"},
.Tune = New List(Of String) From {""},
.Pix_fmt = Split("nv12 p010le vuyx qsv xv30le", " ").ToList
})


    End Sub

End Class


