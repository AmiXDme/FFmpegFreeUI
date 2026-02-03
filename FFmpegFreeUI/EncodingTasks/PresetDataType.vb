Imports System.Text.Json.Serialization

<Serializable()>
Public Class PresetDataType
    <JsonPropertyName("OutputContainer")>
    Public Property OutputContainer As String = ""

    <JsonPropertyName("OutputNaming_UseAutoNaming")>
    Public Property OutputNaming_UseAutoNaming As Boolean = False
    <JsonPropertyName("OutputNaming_AutoNamingOption")>
    Public Property OutputNaming_AutoNamingOption As Integer = 0
    <JsonPropertyName("OutputNaming_DoNotUseOutputFileParams")>
    Public Property OutputNaming_DoNotUseOutputFileParams As Boolean = False
    <JsonPropertyName("OutputNaming_PrefixText")>
    Public Property OutputNaming_PrefixText As String = ""
    <JsonPropertyName("OutputNaming_ReplaceText")>
    Public Property OutputNaming_ReplaceText As String = ""
    <JsonPropertyName("OutputNaming_SuffixText")>
    Public Property OutputNaming_SuffixText As String = ""
    <JsonPropertyName("OutputNaming_PreserveCreationTime")>
    Public Property OutputNaming_PreserveCreationTime As Boolean = False
    <JsonPropertyName("OutputNaming_PreserveModificationTime")>
    Public Property OutputNaming_PreserveModificationTime As Boolean = False
    <JsonPropertyName("OutputNaming_PreserveAccessTime")>
    Public Property OutputNaming_PreserveAccessTime As Boolean = False

    <JsonPropertyName("DecodingParams_Decoder")>
    Public Property DecodingParams_Decoder As String = ""
    <JsonPropertyName("DecodingParams_CPUThreadCount")>
    Public Property DecodingParams_CPUThreadCount As String = ""
    <JsonPropertyName("DecodingParams_OutputFormat")>
    Public Property DecodingParams_OutputFormat As String = ""
    <JsonPropertyName("DecodingParams_HardwareParamName")>
    Public Property DecodingParams_HardwareParamName As String = ""
    <JsonPropertyName("DecodingParams_HardwareParamValue")>
    Public Property DecodingParams_HardwareParamValue As String = ""

    <JsonPropertyName("VideoParams_Encoder_Category")>
    Public Property VideoParams_Encoder_Category As String = ""
    <JsonPropertyName("VideoParams_Encoder_Specific")>
    Public Property VideoParams_Encoder_Specific As String = ""
    <JsonPropertyName("VideoParams_Encoder_Preset")>
    Public Property VideoParams_Encoder_Preset As String = ""
    <JsonPropertyName("VideoParams_Encoder_Profile")>
    Public Property VideoParams_Encoder_Profile As String = ""
    <JsonPropertyName("VideoParams_Encoder_Tune")>
    Public Property VideoParams_Encoder_Tune As String = ""
    <JsonPropertyName("VideoParams_Encoder_GPU")>
    Public Property VideoParams_Encoder_GPU As String = ""
    <JsonPropertyName("VideoParams_Encoder_Threads")>
    Public Property VideoParams_Encoder_Threads As String = ""

    <JsonPropertyName("VideoParams_Resolution")>
    Public Property VideoParams_Resolution As String = ""
    <JsonPropertyName("VideoParams_ResolutionAuto_Width")>
    Public Property VideoParams_ResolutionAuto_Width As String = ""
    <JsonPropertyName("VideoParams_ResolutionAuto_Height")>
    Public Property VideoParams_ResolutionAuto_Height As String = ""
    <JsonPropertyName("VideoParams_CropFilterParams")>
    Public Property VideoParams_CropFilterParams As String = ""
    <JsonPropertyName("VideoParams_FrameRate")>
    Public Property VideoParams_FrameRate As String = ""
    <JsonPropertyName("VideoParams_FrameRate_MaxChangeRatio")>
    Public Property VideoParams_FrameRate_MaxChangeRatio As String = ""

    <JsonPropertyName("VideoParams_FrameInterpolation_TargetFrameRate")>
    Public Property VideoParams_FrameInterpolation_TargetFrameRate As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_Mode")>
    Public Property VideoParams_FrameInterpolation_Mode As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_MotionEstimationMode")>
    Public Property VideoParams_FrameInterpolation_MotionEstimationMode As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_MotionEstimationAlgorithm")>
    Public Property VideoParams_FrameInterpolation_MotionEstimationAlgorithm As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_MotionCompensationMode")>
    Public Property VideoParams_FrameInterpolation_MotionCompensationMode As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation")>
    Public Property VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation As Boolean = False
    <JsonPropertyName("VideoParams_FrameInterpolation_BlockSize")>
    Public Property VideoParams_FrameInterpolation_BlockSize As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_SearchRange")>
    Public Property VideoParams_FrameInterpolation_SearchRange As String = ""
    <JsonPropertyName("VideoParams_FrameInterpolation_SceneChangeDetectionStrength")>
    Public Property VideoParams_FrameInterpolation_SceneChangeDetectionStrength As String = ""

    <JsonPropertyName("VideoParams_FrameBlending_TargetFrameRate")>
    Public Property VideoParams_FrameBlending_TargetFrameRate As String = ""
    <JsonPropertyName("VideoParams_FrameBlending_BlendMode")>
    Public Property VideoParams_FrameBlending_BlendMode As String = ""
    <JsonPropertyName("VideoParams_FrameBlending_BlendRatio")>
    Public Property VideoParams_FrameBlending_BlendRatio As String = ""

    <JsonPropertyName("VideoParams_SuperResolution_TargetWidth")>
    Public Property VideoParams_SuperResolution_TargetWidth As String = ""
    <JsonPropertyName("VideoParams_SuperResolution_TargetHeight")>
    Public Property VideoParams_SuperResolution_TargetHeight As String = ""
    <JsonPropertyName("VideoParams_SuperResolution_UpsamplingAlgorithm")>
    Public Property VideoParams_SuperResolution_UpsamplingAlgorithm As String = ""
    <JsonPropertyName("VideoParams_SuperResolution_DownsamplingAlgorithm")>
    Public Property VideoParams_SuperResolution_DownsamplingAlgorithm As String = ""
    <JsonPropertyName("VideoParams_SuperResolution_AntiRingingStrength")>
    Public Property VideoParams_SuperResolution_AntiRingingStrength As String = ""
    <JsonPropertyName("VideoParams_SuperResolution_ShaderList")>
    Public Property VideoParams_SuperResolution_ShaderList As New List(Of String)

    <JsonPropertyName("VideoParams_BurnSubtitles_FilterSelection")>
    Public Property VideoParams_BurnSubtitles_FilterSelection As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_SubtitleFormatPriority")>
    Public Property VideoParams_BurnSubtitles_SubtitleFormatPriority As New List(Of Integer) From {-1, -1, -1}
    <JsonPropertyName("VideoParams_BurnSubtitles_UseExternalFile")>
    Public Property VideoParams_BurnSubtitles_UseExternalFile As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_ExternalSubtitleFileName")>
    Public Property VideoParams_BurnSubtitles_ExternalSubtitleFileName As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation")>
    Public Property VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_UseEmbeddedStream")>
    Public Property VideoParams_BurnSubtitles_UseEmbeddedStream As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_SpecifiedEmbeddedStream")>
    Public Property VideoParams_BurnSubtitles_SpecifiedEmbeddedStream As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_FontFolder")>
    Public Property VideoParams_BurnSubtitles_FontFolder As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Name")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Name As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Size")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Size As Single
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Bold")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Bold As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Italic")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Italic As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Underline")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Underline As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_BasicStyle_Strikeout")>
    Public Property VideoParams_BurnSubtitles_BasicStyle_Strikeout As Boolean = False
    <JsonPropertyName("VideoParams_BurnSubtitles_BorderStyle")>
    Public Property VideoParams_BurnSubtitles_BorderStyle As Integer = -1
    <JsonPropertyName("VideoParams_BurnSubtitles_OutlineWidth")>
    Public Property VideoParams_BurnSubtitles_OutlineWidth As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_ShadowDistance")>
    Public Property VideoParams_BurnSubtitles_ShadowDistance As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_PrimaryColor")>
    Public Property VideoParams_BurnSubtitles_PrimaryColor As Color = Color.Transparent
    <JsonPropertyName("VideoParams_BurnSubtitles_PrimaryColor_Alpha")>
    Public Property VideoParams_BurnSubtitles_PrimaryColor_Alpha As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_SecondaryColor")>
    Public Property VideoParams_BurnSubtitles_SecondaryColor As Color = Color.Transparent
    <JsonPropertyName("VideoParams_BurnSubtitles_SecondaryColor_Alpha")>
    Public Property VideoParams_BurnSubtitles_SecondaryColor_Alpha As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_OutlineColor")>
    Public Property VideoParams_BurnSubtitles_OutlineColor As Color = Color.Transparent
    <JsonPropertyName("VideoParams_BurnSubtitles_OutlineColor_Alpha")>
    Public Property VideoParams_BurnSubtitles_OutlineColor_Alpha As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_BackgroundColor")>
    Public Property VideoParams_BurnSubtitles_BackgroundColor As Color = Color.Transparent
    <JsonPropertyName("VideoParams_BurnSubtitles_BackgroundColor_Alpha")>
    Public Property VideoParams_BurnSubtitles_BackgroundColor_Alpha As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_Alignment")>
    Public Property VideoParams_BurnSubtitles_Alignment As Integer = -1
    <JsonPropertyName("VideoParams_BurnSubtitles_VerticalMargin")>
    Public Property VideoParams_BurnSubtitles_VerticalMargin As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_LeftMargin")>
    Public Property VideoParams_BurnSubtitles_LeftMargin As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_RightMargin")>
    Public Property VideoParams_BurnSubtitles_RightMargin As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_Spacing")>
    Public Property VideoParams_BurnSubtitles_Spacing As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_LineSpacing")>
    Public Property VideoParams_BurnSubtitles_LineSpacing As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_VideoResolution")>
    Public Property VideoParams_BurnSubtitles_VideoResolution As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_CustomStyle")>
    Public Property VideoParams_BurnSubtitles_CustomStyle As String = ""
    <JsonPropertyName("VideoParams_BurnSubtitles_CustomFilterParams")>
    Public Property VideoParams_BurnSubtitles_CustomFilterParams As String = ""

    <JsonPropertyName("VideoParams_Bitrate_ControlMethod")>
    Public Property VideoParams_Bitrate_ControlMethod As String = ""
    <JsonPropertyName("VideoParams_QualityControl_ParamName")>
    Public Property VideoParams_QualityControl_ParamName As String = ""
    <JsonPropertyName("VideoParams_QualityControl_Value")>
    Public Property VideoParams_QualityControl_Value As String = ""
    <JsonPropertyName("VideoParams_Bitrate_Base")>
    Public Property VideoParams_Bitrate_Base As String = ""
    <JsonPropertyName("VideoParams_Bitrate_MinValue")>
    Public Property VideoParams_Bitrate_MinValue As String = ""
    <JsonPropertyName("VideoParams_Bitrate_MaxValue")>
    Public Property VideoParams_Bitrate_MaxValue As String = ""
    <JsonPropertyName("VideoParams_Bitrate_BufferSize")>
    Public Property VideoParams_Bitrate_BufferSize As String = ""
    <JsonPropertyName("VideoParams_QualityControl_AdvancedParamsList")>
    Public Property VideoParams_QualityControl_AdvancedParamsList As New List(Of String)

    <JsonPropertyName("VideoParams_ColorManagement_PixelFormat")>
    Public Property VideoParams_ColorManagement_PixelFormat As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_FilterSelection")>
    Public Property VideoParams_ColorManagement_FilterSelection As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_MatrixCoefficients")>
    Public Property VideoParams_ColorManagement_MatrixCoefficients As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_ColorGamut")>
    Public Property VideoParams_ColorManagement_ColorGamut As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_TransferCharacteristics")>
    Public Property VideoParams_ColorManagement_TransferCharacteristics As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_Range")>
    Public Property VideoParams_ColorManagement_Range As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_ToneMappingAlgorithm")>
    Public Property VideoParams_ColorManagement_ToneMappingAlgorithm As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_ProcessingMethod")>
    Public Property VideoParams_ColorManagement_ProcessingMethod As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_Brightness")>
    Public Property VideoParams_ColorManagement_Brightness As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_Contrast")>
    Public Property VideoParams_ColorManagement_Contrast As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_Saturation")>
    Public Property VideoParams_ColorManagement_Saturation As String = ""
    <JsonPropertyName("VideoParams_ColorManagement_Gamma")>
    Public Property VideoParams_ColorManagement_Gamma As String = ""

    <JsonPropertyName("VideoParams_Denoise_Method")>
    Public Property VideoParams_Denoise_Method As String = ""
    <JsonPropertyName("VideoParams_Denoise_Param1")>
    Public Property VideoParams_Denoise_Param1 As String = ""
    <JsonPropertyName("VideoParams_Denoise_Param2")>
    Public Property VideoParams_Denoise_Param2 As String = ""
    <JsonPropertyName("VideoParams_Denoise_Param3")>
    Public Property VideoParams_Denoise_Param3 As String = ""
    <JsonPropertyName("VideoParams_Denoise_Param4")>
    Public Property VideoParams_Denoise_Param4 As String = ""
    <JsonPropertyName("VideoParams_Sharpen_HorizontalSize")>
    Public Property VideoParams_Sharpen_HorizontalSize As String = ""
    <JsonPropertyName("VideoParams_Sharpen_VerticalSize")>
    Public Property VideoParams_Sharpen_VerticalSize As String = ""
    <JsonPropertyName("VideoParams_Sharpen_Strength")>
    Public Property VideoParams_Sharpen_Strength As String = ""
    <JsonPropertyName("VideoParams_ProgressiveInterlaced")>
    Public Property VideoParams_ProgressiveInterlaced As Integer = 0
    <JsonPropertyName("VideoParams_Flip_AngleRotation")>
    Public Property VideoParams_Flip_AngleRotation As Integer = 0
    <JsonPropertyName("VideoParams_Flip_MirrorFlip")>
    Public Property VideoParams_Flip_MirrorFlip As Integer = 0

    <JsonPropertyName("VideoParam_VideoFrameServer_UseAviSynth")>
    Public Property VideoParam_VideoFrameServer_UseAviSynth As Boolean = False
    <JsonPropertyName("VideoParam_VideoFrameServer_AvsScriptFile")>
    Public Property VideoParam_VideoFrameServer_AvsScriptFile As String = ""
    <JsonPropertyName("VideoParam_VideoFrameServer_UseVapourSynth")>
    Public Property VideoParam_VideoFrameServer_UseVapourSynth As Boolean = False
    <JsonPropertyName("VideoParam_VideoFrameServer_VpyScriptFile")>
    Public Property VideoParam_VideoFrameServer_VpyScriptFile As String = ""

    <JsonPropertyName("AudioParams_Encoder_Specific")>
    Public Property AudioParams_Encoder_Specific As String = ""
    <JsonPropertyName("AudioParams_Bitrate")>
    Public Property AudioParams_Bitrate As String = ""
    <JsonPropertyName("AudioParams_QualityParamName")>
    Public Property AudioParams_QualityParamName As String = ""
    <JsonPropertyName("AudioParams_QualityValue")>
    Public Property AudioParams_QualityValue As String = ""
    <JsonPropertyName("AudioParams_ChannelCount")>
    Public Property AudioParams_ChannelCount As String = ""
    <JsonPropertyName("AudioParams_SampleRate")>
    Public Property AudioParams_SampleRate As String = ""
    <JsonPropertyName("AudioParams_LoudnessNormalization_TargetLoudness")>
    Public Property AudioParams_LoudnessNormalization_TargetLoudness As String = ""
    <JsonPropertyName("AudioParams_LoudnessNormalization_DynamicRange")>
    Public Property AudioParams_LoudnessNormalization_DynamicRange As String = ""
    <JsonPropertyName("AudioParams_LoudnessNormalization_PeakLevel")>
    Public Property AudioParams_LoudnessNormalization_PeakLevel As String = ""

    <JsonPropertyName("ImageParams_Encoder_EncoderName")>
    Public Property ImageParams_Encoder_EncoderName As String = ""
    <JsonPropertyName("ImageParams_Encoder_QualityValue")>
    Public Property ImageParams_Encoder_QualityValue As String = ""

    <JsonPropertyName("CustomParams_VideoFilter")>
    Public Property CustomParams_VideoFilter As String = ""
    <JsonPropertyName("CustomParams_AudioFilter")>
    Public Property CustomParams_AudioFilter As String = ""
    <JsonPropertyName("CustomParams_FilterComplex")>
    Public Property CustomParams_FilterComplex As String = ""
    <JsonPropertyName("CustomParams_VideoParams")>
    Public Property CustomParams_VideoParams As String = ""
    <JsonPropertyName("CustomParams_AudioParams")>
    Public Property CustomParams_AudioParams As String = ""
    <JsonPropertyName("CustomParams_StartParams")>
    Public Property CustomParams_StartParams As String = ""
    <JsonPropertyName("CustomParams_BeforeParams")>
    Public Property CustomParams_BeforeParams As String = ""
    <JsonPropertyName("CustomParams_AfterParams")>
    Public Property CustomParams_AfterParams As String = ""
    <JsonPropertyName("CustomParams_EndParams")>
    Public Property CustomParams_EndParams As String = ""
    <JsonPropertyName("CustomParams_CompletelyCustom")>
    Public Property CustomParams_CompletelyCustom As String = ""

    <JsonPropertyName("ClipRange_Method")>
    Public Property ClipRange_Method As Integer = 0
    <JsonPropertyName("ClipRange_InPoint")>
    Public Property ClipRange_InPoint As String = ""
    <JsonPropertyName("ClipRange_OutPoint")>
    Public Property ClipRange_OutPoint As String = ""
    <JsonPropertyName("ClipRange_PreDecodeSeconds")>
    Public Property ClipRange_PreDecodeSeconds As String = ""

    <JsonPropertyName("StreamControl_PreserveOtherVideoStreams")>
    Public Property StreamControl_PreserveOtherVideoStreams As Boolean = False
    <JsonPropertyName("StreamControl_ApplyVideoParamsToStreams")>
    Public Property StreamControl_ApplyVideoParamsToStreams As String() = Array.Empty(Of String)()
    <JsonPropertyName("StreamControl_PreserveOtherAudioStreams")>
    Public Property StreamControl_PreserveOtherAudioStreams As Boolean = False
    <JsonPropertyName("StreamControl_ApplyAudioParamsToStreams")>
    Public Property StreamControl_ApplyAudioParamsToStreams As String() = Array.Empty(Of String)()
    <JsonPropertyName("StreamControl_ApplySubtitleParamsToStreams")>
    Public Property StreamControl_ApplySubtitleParamsToStreams As String() = Array.Empty(Of String)()
    <JsonPropertyName("StreamControl_SubtitleOperation")>
    Public Property StreamControl_SubtitleOperation As Integer = 0
    <JsonPropertyName("StreamControl_PreserveOtherSubtitleStreams")>
    Public Property StreamControl_PreserveOtherSubtitleStreams As Boolean = False
    <JsonPropertyName("StreamControl_AutoMuxSRT")>
    Public Property StreamControl_AutoMuxSRT As Boolean = False
    <JsonPropertyName("StreamControl_AutoMuxASS")>
    Public Property StreamControl_AutoMuxASS As Boolean = False
    <JsonPropertyName("StreamControl_AutoMuxSSA")>
    Public Property StreamControl_AutoMuxSSA As Boolean = False
    <JsonPropertyName("StreamControl_ConvertSubtitlesToMovtext")>
    Public Property StreamControl_ConvertSubtitlesToMovtext As Boolean = False
    <JsonPropertyName("StreamControl_MetadataOption")>
    Public Property StreamControl_MetadataOption As Integer = 0
    <JsonPropertyName("StreamControl_ChapterOption")>
    Public Property StreamControl_ChapterOption As Integer = 0
    <JsonPropertyName("StreamControl_AttachmentOption")>
    Public Property StreamControl_AttachmentOption As Integer = 0

    <JsonPropertyName("MachineName")>
    Public Property MachineName As String = ""
    <JsonPropertyName("OutputLocation")>
    Public Property OutputLocation As String = ""

    ' Aliases for naming variations from earlier partial anglicization
    Public ReadOnly Property OutputNaming_ReplacementText As String
        Get
            Return OutputNaming_ReplaceText
        End Get
    End Property

    Public ReadOnly Property OutputNaming_DoNotUseOutputFileParam As Boolean
        Get
            Return OutputNaming_DoNotUseOutputFileParams
        End Get
    End Property

    Public ReadOnly Property VideoParam_Encoder_SpecificCodec As String
        Get
            Return VideoParams_Encoder_Specific
        End Get
    End Property

    Public ReadOnly Property VideoParam_Encoder_Preset As String
        Get
            Return VideoParams_Encoder_Preset
        End Get
    End Property

    Public ReadOnly Property VideoParam_QualityControl_ParamName As String
        Get
            Return VideoParams_QualityControl_ParamName
        End Get
    End Property

    Public ReadOnly Property VideoParam_QualityControl_Value As String
        Get
            Return VideoParams_QualityControl_Value
        End Get
    End Property

    Public ReadOnly Property VideoParam_Bitrate_Base As String
        Get
            Return VideoParams_Bitrate_Base
        End Get
    End Property

    Public ReadOnly Property VideoParam_Bitrate_Min As String
        Get
            Return VideoParams_Bitrate_MinValue
        End Get
    End Property

    Public ReadOnly Property VideoParam_Bitrate_Max As String
        Get
            Return VideoParams_Bitrate_MaxValue
        End Get
    End Property

    Public ReadOnly Property VideoParam_Bitrate_Buffer As String
        Get
            Return VideoParams_Bitrate_BufferSize
        End Get
    End Property

End Class
