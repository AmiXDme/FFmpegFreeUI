Imports System.IO
Imports Sunny.UI
Public Class PresetManager

    Public Shared Property AudioEncoderSortList As New List(Of String) From {
        "",
        "copy",
        "-an",
        "aac",
        "libfdk_aac",
        "libfdk_aac -profile:a aac_he",
        "libfdk_aac -profile:a aac_he_v2",
        "libmp3lame",
        "libopus",
        "flac",
        "alac",
        "pcm_s16le",
        "pcm_s24le",
        "pcm_s32le",
        "pcm_s64le",
        "ac3",
        "eac3",
        "dca",
        "truehd",
        "tta",
        "libvorbis",
        "real_144",
        "wavpack",
        "libtwolame",
        "libopencore_amrnb",
        "libvo_amrwbenc"
    }

    Public Shared Sub ShowPreset(a As PresetDataType, ui As GeneralParametersPage)
        ui.UiTextBoxOutputContainer.Text = a.OutputContainer

        If a.MachineName = Environment.MachineName AndAlso FileIO.FileSystem.DirectoryExists(a.OutputLocation) Then
            ui.UiComboBoxOutputDirectory.Text = "  " & a.OutputLocation
        Else
            ui.UiComboBoxOutputDirectory.SelectedIndex = 0
        End If

        ui.UiSwitchUseAutoNaming.Active = a.OutputNaming_UseAutoNaming
        ui.UiComboBoxAutoNamingOption.SelectedIndex = a.OutputNaming_AutoNamingOption
        ui.UiSwitchDoNotUseOutputFileParameters.Active = a.OutputNaming_DoNotUseOutputFileParams
        ui.UiTextBoxPrefixText.Text = a.OutputNaming_PrefixText
        ui.UiTextBoxReplacementText.Text = a.OutputNaming_ReplaceText
        ui.UiTextBoxSuffixText.Text = a.OutputNaming_SuffixText
        ui.UiCheckBoxPreserveCreationTime.Checked = a.OutputNaming_PreserveCreationTime
        ui.UiCheckBoxPreserveModificationTime.Checked = a.OutputNaming_PreserveModificationTime
        ui.UiCheckBoxPreserveAccessTime.Checked = a.OutputNaming_PreserveAccessTime

        ui.UiComboBoxDecodingDecoder.Text = a.DecodingParams_Decoder
        ui.UiTextBoxCPUDecodingThreadCount.Text = a.DecodingParams_CPUThreadCount
        ui.UiComboBoxDecodingDataFormat.Text = a.DecodingParams_OutputFormat
        ui.UiComboBoxHardwareAccelerationDecodingParamName.Text = a.DecodingParams_HardwareParamName
        ui.UiTextBoxHardwareAccelerationDecodingParameters.Text = a.DecodingParams_HardwareParamValue

        ui.UiComboBoxEncoderCategory.Text = a.VideoParams_Encoder_Category
        ui.UiComboBoxSpecificEncoder.Text = a.VideoParams_Encoder_Specific
        ui.UiComboBoxEncoderPreset.Text = a.VideoParams_Encoder_Preset
        ui.UiComboBoxProfileFile.Text = a.VideoParams_Encoder_Profile
        ui.UiComboBoxSceneTune.Text = a.VideoParams_Encoder_Tune
        ui.UiTextBoxgpu.Text = a.VideoParams_Encoder_GPU
        ui.UiTextBoxthreads.Text = a.VideoParams_Encoder_Threads

        ui.UiComboBoxResolution.Text = a.VideoParams_Resolution
        ui.UiTextBoxResolutionAutoWidth.Text = a.VideoParams_ResolutionAuto_Width
        ui.UiTextBoxResolutionAutoHeight.Text = a.VideoParams_ResolutionAuto_Height
        ui.UiTextBoxCropFilterParameters.Text = a.VideoParams_CropFilterParams
        ui.UiComboBoxFrameRate.Text = a.VideoParams_FrameRate
        ui.UiTextBoxFrameMaxChangeRatio.Text = a.VideoParams_FrameRate_MaxChangeRatio

        ui.FrameInterpolationPage.UiTextBoxTargetFrameRate.Text = a.VideoParams_FrameInterpolation_TargetFrameRate
        Select Case a.VideoParams_FrameInterpolation_Mode
            Case "dup" : ui.FrameInterpolationPage.UiComboBoxFrameInterpolationMode.SelectedIndex = 1
            Case "blend" : ui.FrameInterpolationPage.UiComboBoxFrameInterpolationMode.SelectedIndex = 2
            Case "mci" : ui.FrameInterpolationPage.UiComboBoxFrameInterpolationMode.SelectedIndex = 3
        End Select
        Select Case a.VideoParams_FrameInterpolation_MotionEstimationMode
            Case "bidir" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationMode.SelectedIndex = 1
            Case "bilat" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationMode.SelectedIndex = 2
        End Select
        Select Case a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm
            Case "esa" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 1
            Case "tss" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 2
            Case "tdls" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 3
            Case "ntss" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 4
            Case "fss" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 5
            Case "ds" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 6
            Case "hexbs" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 7
            Case "epzs" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 8
            Case "umh" : ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex = 9
        End Select
        Select Case a.VideoParams_FrameInterpolation_MotionCompensationMode
            Case "obmc" : ui.FrameInterpolationPage.UiComboBoxMotionCompensationMode.SelectedIndex = 1
            Case "aobmc" : ui.FrameInterpolationPage.UiComboBoxMotionCompensationMode.SelectedIndex = 2
        End Select
        ui.FrameInterpolationPage.UiCheckBoxVariableBlockSizeMotionCompensation.Checked = a.VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation
        ui.FrameInterpolationPage.UiTextBoxBlockSize.Text = a.VideoParams_FrameInterpolation_BlockSize
        ui.FrameInterpolationPage.UiTextBoxSearchRange.Text = a.VideoParams_FrameInterpolation_SearchRange
        ui.FrameInterpolationPage.UiTextBoxSceneChangeDetectionStrength.Text = a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength

        ui.MotionBlurPage.UiTextBoxTargetFrameRate.Text = a.VideoParams_FrameBlending_TargetFrameRate
        Select Case a.VideoParams_FrameBlending_BlendMode
            Case "average" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 1
            Case "difference" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 2
            Case "and" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 3
            Case "or" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 4
            Case "xor" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 5
            Case "add" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 6
            Case "multiply" : ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex = 7
        End Select
        ui.MotionBlurPage.UiTextBoxBlendRatio.Text = a.VideoParams_FrameBlending_BlendRatio

        ui.SuperResolutionPage.UiTextBoxSuperResolutionWidth.Text = a.VideoParams_SuperResolution_TargetWidth
        ui.SuperResolutionPage.UiTextBoxSuperResolutionHeight.Text = a.VideoParams_SuperResolution_TargetHeight
        ui.SuperResolutionPage.UiComboBoxUpsamplingAlgorithm.Text = a.VideoParams_SuperResolution_UpsamplingAlgorithm
        ui.SuperResolutionPage.UiComboBoxDownsamplingAlgorithm.Text = a.VideoParams_SuperResolution_DownsamplingAlgorithm
        ui.SuperResolutionPage.UiTextBoxAntiRingingStrength.Text = a.VideoParams_SuperResolution_AntiRingingStrength
        ui.SuperResolutionPage.ListView1.Items.Clear()
        For Each c In a.VideoParams_SuperResolution_ShaderList
            ui.SuperResolutionPage.ListView1.Items.Add(c)
        Next

        Select Case a.VideoParams_BurnSubtitles_FilterSelection
            Case "subtitles" : ui.BurnSubtitlesPage.UiComboBoxSelectFilter.SelectedIndex = 1
            Case "ass" : ui.BurnSubtitlesPage.UiComboBoxSelectFilter.SelectedIndex = 2
            Case Else : ui.BurnSubtitlesPage.UiComboBoxSelectFilter.SelectedIndex = 0
        End Select
        ui.BurnSubtitlesPage.UiComboBoxPrioritySelect.SelectedIndex = a.VideoParams_BurnSubtitles_SubtitleFormatPriority(0)
        ui.BurnSubtitlesPage.UiComboBoxThenSelect.SelectedIndex = a.VideoParams_BurnSubtitles_SubtitleFormatPriority(1)
        ui.BurnSubtitlesPage.UiComboBoxFinallySelect.SelectedIndex = a.VideoParams_BurnSubtitles_SubtitleFormatPriority(2)
        ui.BurnSubtitlesPage.UiCheckBoxSubtitleSourceUseExternalFile.Checked = a.VideoParams_BurnSubtitles_UseExternalFile
        ui.BurnSubtitlesPage.UiTextBoxSubtitleSourceExternalFileName.Text = a.VideoParams_BurnSubtitles_ExternalSubtitleFileName
        ui.BurnSubtitlesPage.UiTextBoxSubtitleSourceSpecifiedFolder.Text = a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation
        ui.BurnSubtitlesPage.UiCheckBoxSubtitleSourceIsEmbeddedStream.Checked = a.VideoParams_BurnSubtitles_UseEmbeddedStream
        ui.BurnSubtitlesPage.UiTextBoxSpecifiedEmbeddedStream.Text = a.VideoParams_BurnSubtitles_SpecifiedEmbeddedStream
        ui.BurnSubtitlesPage.UiTextBoxFontFolder.Text = a.VideoParams_BurnSubtitles_FontFolder
        If a.VideoParams_BurnSubtitles_BasicStyle_Name = "" Then
            ui.BurnSubtitlesPage.UiButtonClearBasicStyle.PerformClick()
        Else
            ui.BurnSubtitlesPage.LabelFontStylePreview.Enabled = True
            Dim s As New FontStyle
            If a.VideoParams_BurnSubtitles_BasicStyle_Bold Then s += FontStyle.Bold
            If a.VideoParams_BurnSubtitles_BasicStyle_Italic Then s += FontStyle.Italic
            If a.VideoParams_BurnSubtitles_BasicStyle_Underline Then s += FontStyle.Underline
            If a.VideoParams_BurnSubtitles_BasicStyle_Strikeout Then s += FontStyle.Strikeout
            ui.BurnSubtitlesPage.LabelFontStylePreview.Font = New Font(a.VideoParams_BurnSubtitles_BasicStyle_Name, a.VideoParams_BurnSubtitles_BasicStyle_Size, s)
        End If
        ui.BurnSubtitlesPage.UiComboBoxBorderType.SelectedIndex = a.VideoParams_BurnSubtitles_BorderStyle
        ui.BurnSubtitlesPage.UiTextBoxOutlineWidth.Text = a.VideoParams_BurnSubtitles_OutlineWidth
        ui.BurnSubtitlesPage.UiTextBoxShadowDistance.Text = a.VideoParams_BurnSubtitles_ShadowDistance
        ui.BurnSubtitlesPage.UiTextBoxSettingsPrimaryColorAlpha.Text = a.VideoParams_BurnSubtitles_PrimaryColor_Alpha
        ui.BurnSubtitlesPage.LabelPrimaryColor.BackColor = a.VideoParams_BurnSubtitles_PrimaryColor
        ui.BurnSubtitlesPage.UiTextBoxSettingsSecondaryColorAlpha.Text = a.VideoParams_BurnSubtitles_SecondaryColor_Alpha
        ui.BurnSubtitlesPage.LabelSecondaryColor.BackColor = a.VideoParams_BurnSubtitles_SecondaryColor
        ui.BurnSubtitlesPage.UiTextBoxSettingsOutlineColorAlpha.Text = a.VideoParams_BurnSubtitles_OutlineColor_Alpha
        ui.BurnSubtitlesPage.LabelOutlineColor.BackColor = a.VideoParams_BurnSubtitles_OutlineColor
        ui.BurnSubtitlesPage.UiTextBoxSettingsBackgroundColorAlpha.Text = a.VideoParams_BurnSubtitles_BackgroundColor_Alpha
        ui.BurnSubtitlesPage.LabelBackgroundColor.BackColor = a.VideoParams_BurnSubtitles_BackgroundColor
        ui.BurnSubtitlesPage.UiComboBoxAlignmentPosition.SelectedIndex = a.VideoParams_BurnSubtitles_Alignment
        ui.BurnSubtitlesPage.UiTextBoxVerticalMargin.Text = a.VideoParams_BurnSubtitles_VerticalMargin
        ui.BurnSubtitlesPage.UiTextBoxLeftMargin.Text = a.VideoParams_BurnSubtitles_LeftMargin
        ui.BurnSubtitlesPage.UiTextBoxRightMargin.Text = a.VideoParams_BurnSubtitles_RightMargin
        ui.BurnSubtitlesPage.UiTextBoxCharacterSpacing.Text = a.VideoParams_BurnSubtitles_Spacing
        ui.BurnSubtitlesPage.UiTextBoxLineSpacing.Text = a.VideoParams_BurnSubtitles_LineSpacing
        ui.BurnSubtitlesPage.UiTextBoxCustomStyle.Text = a.VideoParams_BurnSubtitles_CustomStyle
        ui.BurnSubtitlesPage.UiTextBoxCustomFilterParameters.Text = a.VideoParams_BurnSubtitles_CustomFilterParams

        Select Case a.VideoParams_Bitrate_ControlMethod
            Case "CRF" : ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = 1
            Case "VBR" : ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = 2
            Case "VBR HQ" : ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = 3
            Case "CQP" : ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = 4
            Case "CBR" : ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = 5
        End Select
        Select Case a.VideoParams_QualityControl_ParamName
            Case "crf" : ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex = 1
            Case "cq" : ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex = 2
            Case "qp" : ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex = 3
            Case "global_quality" : ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex = 4
        End Select
        ui.UiTextBoxGlobalQualityControlValue.Text = a.VideoParams_QualityControl_Value
        ui.UiTextBoxBaseBitrate.Text = a.VideoParams_Bitrate_Base
        ui.UiTextBoxMinBitrate.Text = a.VideoParams_Bitrate_MinValue
        ui.UiTextBoxMaxBitrate.Text = a.VideoParams_Bitrate_MaxValue
        ui.UiTextBoxBitrateBufferSize.Text = a.VideoParams_Bitrate_BufferSize
        ui.ClearAllAdvancedQualityControl()
        For Each c In a.VideoParams_QualityControl_AdvancedParamsList
            ui.CreateAdvancedQualityControlItem(c)
        Next

        ui.UiComboBoxPixelFormat.Text = a.VideoParams_ColorManagement_PixelFormat
        ui.UiComboBoxColorSpaceFilterSelect.Text = a.VideoParams_ColorManagement_FilterSelection
        ui.UiComboBoxMatrixCoefficients.Text = a.VideoParams_ColorManagement_MatrixCoefficients
        ui.UiComboBoxColorPrimaries.Text = a.VideoParams_ColorManagement_ColorGamut
        ui.UiComboBoxTransferCharacteristics.Text = a.VideoParams_ColorManagement_TransferCharacteristics
        Select Case a.VideoParams_ColorManagement_Range
            Case "tv" : ui.UiComboBoxColorRange.SelectedIndex = 1
            Case "pc" : ui.UiComboBoxColorRange.SelectedIndex = 2
        End Select
        ui.UiComboBoxToneMappingAlgorithm.Text = a.VideoParams_ColorManagement_ToneMappingAlgorithm
        ui.UiComboBoxColorManagementProcessMethod.SelectedIndex = a.VideoParams_ColorManagement_ProcessingMethod
        ui.UiTextBoxSimpleColorBrightness.Text = a.VideoParams_ColorManagement_Brightness
        ui.UiTextBoxSimpleColorContrast.Text = a.VideoParams_ColorManagement_Contrast
        ui.UiTextBoxSimpleColorSaturation.Text = a.VideoParams_ColorManagement_Saturation
        ui.UiTextBoxSimpleColorGamma.Text = a.VideoParams_ColorManagement_Gamma

        Select Case a.VideoParams_Denoise_Method
            Case "hqdn3d" : ui.UiComboBoxDenoiseMethod.SelectedIndex = 1
            Case "nlmeans" : ui.UiComboBoxDenoiseMethod.SelectedIndex = 2
            Case "atadenoise" : ui.UiComboBoxDenoiseMethod.SelectedIndex = 3
            Case "bm3d" : ui.UiComboBoxDenoiseMethod.SelectedIndex = 4
            Case Else : ui.UiComboBoxDenoiseMethod.Text = ""
        End Select
        ui.UiTextBoxDenoiseParameter1.Text = a.VideoParams_Denoise_Param1
        ui.UiTextBoxDenoiseParameter2.Text = a.VideoParams_Denoise_Param2
        ui.UiTextBoxDenoiseParameter3.Text = a.VideoParams_Denoise_Param3
        ui.UiTextBoxDenoiseParameter4.Text = a.VideoParams_Denoise_Param4
        ui.UiTextBoxSharpenHorizontalSize.Text = a.VideoParams_Sharpen_HorizontalSize
        ui.UiTextBoxSharpenVerticalSize.Text = a.VideoParams_Sharpen_VerticalSize
        ui.UiTextBoxSharpenStrength.Text = a.VideoParams_Sharpen_Strength
        ui.UiComboBoxInterlacedProgressiveProcMethod.SelectedIndex = a.VideoParams_ProgressiveInterlaced
        ui.UiComboBoxAngleRotate.SelectedIndex = a.VideoParams_Flip_AngleRotation
        ui.UiComboBoxMirrorFlip.SelectedIndex = a.VideoParams_Flip_MirrorFlip

        ui.UiCheckBoxUseAviSynth.Checked = a.VideoParam_VideoFrameServer_UseAviSynth
        ui.UiComboBoxSelectAvsFile.Text = a.VideoParam_VideoFrameServer_AvsScriptFile
        ui.UiCheckBoxUseVapourSynth.Checked = a.VideoParam_VideoFrameServer_UseVapourSynth
        ui.UiComboBoxSelectVpyFile.Text = a.VideoParam_VideoFrameServer_VpyScriptFile

        ui.UiComboBoxAudioEncoder.SelectedIndex = AudioEncoderSortList.IndexOf(a.AudioParams_Encoder_Specific)
        ui.UiComboBoxAudioBitrate.Text = a.AudioParams_Bitrate
        ui.UiComboBoxAudioQualityParameters.Text = a.AudioParams_QualityParamName
        ui.UiTextBoxAudioQualityValue.Text = a.AudioParams_QualityValue
        ui.UiComboBoxChannelLayout.Text = a.AudioParams_ChannelCount
        ui.UiComboBoxSampleRate.Text = a.AudioParams_SampleRate
        ui.UiTextBoxLoudnessNormalizationTargetLoudness.Text = a.AudioParams_LoudnessNormalization_TargetLoudness
        ui.UiTextBoxLoudnessNormalizationDynamicRange.Text = a.AudioParams_LoudnessNormalization_DynamicRange
        ui.UiTextBoxLoudnessNormalizationPeakValueLevel.Text = a.AudioParams_LoudnessNormalization_PeakLevel

        Select Case a.ImageParams_Encoder_EncoderName
            Case "png" : ui.UiComboBoxImageEncoder.SelectedIndex = 1
            Case "apng" : ui.UiComboBoxImageEncoder.SelectedIndex = 2
            Case "mjpeg" : ui.UiComboBoxImageEncoder.SelectedIndex = 3
            Case "libwebp" : ui.UiComboBoxImageEncoder.SelectedIndex = 4
            Case "libwebp_anim" : ui.UiComboBoxImageEncoder.SelectedIndex = 5
            Case "gif" : ui.UiComboBoxImageEncoder.SelectedIndex = 6
            Case "bmp" : ui.UiComboBoxImageEncoder.SelectedIndex = 7
            Case "libopenjpeg" : ui.UiComboBoxImageEncoder.SelectedIndex = 8
            Case "jpegls" : ui.UiComboBoxImageEncoder.SelectedIndex = 9
            Case "libsvtjpegxs" : ui.UiComboBoxImageEncoder.SelectedIndex = 10
            Case "hdr" : ui.UiComboBoxImageEncoder.SelectedIndex = 11
            Case "tiff" : ui.UiComboBoxImageEncoder.SelectedIndex = 12
            Case "dpx" : ui.UiComboBoxImageEncoder.SelectedIndex = 13
            Case "exr" : ui.UiComboBoxImageEncoder.SelectedIndex = 14
            Case Else : ui.UiComboBoxImageEncoder.SelectedIndex = 0
        End Select
        ui.UiTextBoxImageEncoderQuality.Text = a.ImageParams_Encoder_QualityValue

        ui.UiTextBoxCustomVideoFilter.Text = a.CustomParams_VideoFilter
        ui.UiTextBoxCustomAudioFilter.Text = a.CustomParams_AudioFilter
        ui.UiTextBoxfilter_complex.Text = a.CustomParams_FilterComplex
        ui.UiTextBoxCustomVideoParameters.Text = a.CustomParams_VideoParams
        ui.UiTextBoxCustomAudioParameters.Text = a.CustomParams_AudioParams
        ui.UiTextBoxStartParameters.Text = a.CustomParams_StartParams
        ui.UiTextBoxPreParameters.Text = a.CustomParams_BeforeParams
        ui.UiTextBoxPostParameters.Text = a.CustomParams_AfterParams
        ui.UiTextBoxFinalParameters.Text = a.CustomParams_EndParams
        ui.UiTextBoxCustomFullParameters.Text = a.CustomParams_CompletelyCustom

        ui.UiComboBoxClipMethod.SelectedIndex = a.ClipRange_Method
        ui.UiTextBoxQuickClipInPoint.Text = a.ClipRange_InPoint
        ui.UiTextBoxQuickClipOutPoint.Text = a.ClipRange_OutPoint
        ui.UiComboBoxClipForwardDecodingDurationSeconds.Text = a.ClipRange_PreDecodeSeconds

        ui.UiTextBoxApplyVideoParametersToStreams.Text = String.Join(",", a.StreamControl_ApplyVideoParamsToStreams)
        ui.UiCheckBoxPreserveOtherVideoStreams.Checked = a.StreamControl_PreserveOtherVideoStreams
        ui.UiTextBoxApplyAudioParametersToStreams.Text = String.Join(",", a.StreamControl_ApplyAudioParamsToStreams)
        ui.UiCheckBoxPreserveOtherAudioStreams.Checked = a.StreamControl_PreserveOtherAudioStreams
        ui.UiTextBoxWhichEmbeddedSubtitles.Text = String.Join(",", a.StreamControl_ApplySubtitleParamsToStreams)
        ui.UiComboBoxWhichEmbeddedSubtitlesOperation.SelectedIndex = a.StreamControl_SubtitleOperation
        ui.UiCheckBoxPreserveOtherSubtitleStreams.Checked = a.StreamControl_PreserveOtherSubtitleStreams
        ui.UiCheckBoxAutoMuxSRT.Checked = a.StreamControl_AutoMuxSRT
        ui.UiCheckBoxAutoMuxASS.Checked = a.StreamControl_AutoMuxASS
        ui.UiCheckBoxAutoMuxSSA.Checked = a.StreamControl_AutoMuxSSA
        ui.UiCheckBoxAutoMuxSubtitleToMovtext.Checked = a.StreamControl_ConvertSubtitlesToMovtext
        ui.UiComboBoxMetadataOption.SelectedIndex = a.StreamControl_MetadataOption
        ui.UiComboBoxChapterOption.SelectedIndex = a.StreamControl_ChapterOption
        ui.UiComboBoxAttachmentOption.SelectedIndex = a.StreamControl_AttachmentOption
    End Sub

    Shared ReadOnly separator As String() = {","}

    Public Shared Sub SavePreset(ByRef a As PresetDataType, ui As GeneralParametersPage)
        a.OutputContainer = ui.UiTextBoxOutputContainer.Text
        If ui.UiCheckBoxExtraSaveInfo.Checked AndAlso FileIO.FileSystem.DirectoryExists(ui.UiComboBoxOutputDirectory.Text.Trim) Then
            a.MachineName = Environment.MachineName
            a.OutputLocation = ui.UiComboBoxOutputDirectory.Text.Trim
        End If

        a.OutputNaming_UseAutoNaming = ui.UiSwitchUseAutoNaming.Active
        a.OutputNaming_AutoNamingOption = ui.UiComboBoxAutoNamingOption.SelectedIndex
        a.OutputNaming_DoNotUseOutputFileParams = ui.UiSwitchDoNotUseOutputFileParameters.Active
        a.OutputNaming_PrefixText = ui.UiTextBoxPrefixText.Text
        a.OutputNaming_ReplaceText = ui.UiTextBoxReplacementText.Text
        a.OutputNaming_SuffixText = ui.UiTextBoxSuffixText.Text
        a.OutputNaming_PreserveCreationTime = ui.UiCheckBoxPreserveCreationTime.Checked
        a.OutputNaming_PreserveModificationTime = ui.UiCheckBoxPreserveModificationTime.Checked
        a.OutputNaming_PreserveAccessTime = ui.UiCheckBoxPreserveAccessTime.Checked

        a.DecodingParams_Decoder = ui.UiComboBoxDecodingDecoder.Text
        a.DecodingParams_CPUThreadCount = ui.UiTextBoxCPUDecodingThreadCount.Text
        a.DecodingParams_OutputFormat = ui.UiComboBoxDecodingDataFormat.Text
        a.DecodingParams_HardwareParamName = ui.UiComboBoxHardwareAccelerationDecodingParamName.Text
        a.DecodingParams_HardwareParamValue = ui.UiTextBoxHardwareAccelerationDecodingParameters.Text

        a.VideoParams_Encoder_Category = ui.UiComboBoxEncoderCategory.Text
        a.VideoParams_Encoder_Specific = ui.UiComboBoxSpecificEncoder.Text
        a.VideoParams_Encoder_Preset = ui.UiComboBoxEncoderPreset.Text
        a.VideoParams_Encoder_Profile = ui.UiComboBoxProfileFile.Text
        a.VideoParams_Encoder_Tune = ui.UiComboBoxSceneTune.Text
        a.VideoParams_Encoder_GPU = ui.UiTextBoxgpu.Text
        a.VideoParams_Encoder_Threads = ui.UiTextBoxthreads.Text

        a.VideoParams_Resolution = ui.UiComboBoxResolution.Text
        a.VideoParams_ResolutionAuto_Width = ui.UiTextBoxResolutionAutoWidth.Text
        a.VideoParams_ResolutionAuto_Height = ui.UiTextBoxResolutionAutoHeight.Text
        a.VideoParams_CropFilterParams = ui.UiTextBoxCropFilterParameters.Text
        a.VideoParams_FrameRate = ui.UiComboBoxFrameRate.Text
        a.VideoParams_FrameRate_MaxChangeRatio = ui.UiTextBoxFrameMaxChangeRatio.Text

        a.VideoParams_FrameInterpolation_TargetFrameRate = ui.FrameInterpolationPage.UiTextBoxTargetFrameRate.Text
        Select Case ui.FrameInterpolationPage.UiComboBoxFrameInterpolationMode.SelectedIndex
            Case 1 : a.VideoParams_FrameInterpolation_Mode = "dup"
            Case 2 : a.VideoParams_FrameInterpolation_Mode = "blend"
            Case 3 : a.VideoParams_FrameInterpolation_Mode = "mci"
        End Select
        Select Case ui.FrameInterpolationPage.UiComboBoxMotionEstimationMode.SelectedIndex
            Case 1 : a.VideoParams_FrameInterpolation_MotionEstimationMode = "bidir"
            Case 2 : a.VideoParams_FrameInterpolation_MotionEstimationMode = "bilat"
        End Select
        Select Case ui.FrameInterpolationPage.UiComboBoxMotionEstimationAlgorithm.SelectedIndex
            Case 1 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "esa"
            Case 2 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "tss"
            Case 3 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "tdls"
            Case 4 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "ntss"
            Case 5 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "fss"
            Case 6 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "ds"
            Case 7 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "hexbs"
            Case 8 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "epzs"
            Case 9 : a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm = "umh"
        End Select
        Select Case ui.FrameInterpolationPage.UiComboBoxMotionCompensationMode.SelectedIndex
            Case 1 : a.VideoParams_FrameInterpolation_MotionCompensationMode = "obmc"
            Case 2 : a.VideoParams_FrameInterpolation_MotionCompensationMode = "aobmc"
        End Select
        a.VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation = ui.FrameInterpolationPage.UiCheckBoxVariableBlockSizeMotionCompensation.Checked
        a.VideoParams_FrameInterpolation_BlockSize = ui.FrameInterpolationPage.UiTextBoxBlockSize.Text
        a.VideoParams_FrameInterpolation_SearchRange = ui.FrameInterpolationPage.UiTextBoxSearchRange.Text
        a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength = ui.FrameInterpolationPage.UiTextBoxSceneChangeDetectionStrength.Text

        a.VideoParams_FrameBlending_TargetFrameRate = ui.MotionBlurPage.UiTextBoxTargetFrameRate.Text
        Select Case ui.MotionBlurPage.UiComboBoxBlendAlgorithm.SelectedIndex
            Case 1 : a.VideoParams_FrameBlending_BlendMode = "average"
            Case 2 : a.VideoParams_FrameBlending_BlendMode = "difference"
            Case 3 : a.VideoParams_FrameBlending_BlendMode = "and"
            Case 4 : a.VideoParams_FrameBlending_BlendMode = "or"
            Case 5 : a.VideoParams_FrameBlending_BlendMode = "xor"
            Case 6 : a.VideoParams_FrameBlending_BlendMode = "add"
            Case 7 : a.VideoParams_FrameBlending_BlendMode = "multiply"
        End Select
        a.VideoParams_FrameBlending_BlendRatio = ui.MotionBlurPage.UiTextBoxBlendRatio.Text

        a.VideoParams_SuperResolution_TargetWidth = ui.SuperResolutionPage.UiTextBoxSuperResolutionWidth.Text
        a.VideoParams_SuperResolution_TargetHeight = ui.SuperResolutionPage.UiTextBoxSuperResolutionHeight.Text
        a.VideoParams_SuperResolution_UpsamplingAlgorithm = ui.SuperResolutionPage.UiComboBoxUpsamplingAlgorithm.Text
        a.VideoParams_SuperResolution_DownsamplingAlgorithm = ui.SuperResolutionPage.UiComboBoxDownsamplingAlgorithm.Text
        a.VideoParams_SuperResolution_AntiRingingStrength = ui.SuperResolutionPage.UiTextBoxAntiRingingStrength.Text
        a.VideoParams_SuperResolution_ShaderList.Clear()
        For Each c As ListViewItem In ui.SuperResolutionPage.ListView1.Items
            a.VideoParams_SuperResolution_ShaderList.Add(c.Text)
        Next

        Select Case ui.BurnSubtitlesPage.UiComboBoxSelectFilter.SelectedIndex
            Case 1 : a.VideoParams_BurnSubtitles_FilterSelection = "subtitles"
            Case 2 : a.VideoParams_BurnSubtitles_FilterSelection = "ass"
            Case Else : a.VideoParams_BurnSubtitles_FilterSelection = ""
        End Select
        a.VideoParams_BurnSubtitles_SubtitleFormatPriority(0) = ui.BurnSubtitlesPage.UiComboBoxPrioritySelect.SelectedIndex
        a.VideoParams_BurnSubtitles_SubtitleFormatPriority(1) = ui.BurnSubtitlesPage.UiComboBoxThenSelect.SelectedIndex
        a.VideoParams_BurnSubtitles_SubtitleFormatPriority(2) = ui.BurnSubtitlesPage.UiComboBoxFinallySelect.SelectedIndex
        a.VideoParams_BurnSubtitles_UseExternalFile = ui.BurnSubtitlesPage.UiCheckBoxSubtitleSourceUseExternalFile.Checked
        a.VideoParams_BurnSubtitles_ExternalSubtitleFileName = ui.BurnSubtitlesPage.UiTextBoxSubtitleSourceExternalFileName.Text
        a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation = ui.BurnSubtitlesPage.UiTextBoxSubtitleSourceSpecifiedFolder.Text
        a.VideoParams_BurnSubtitles_UseEmbeddedStream = ui.BurnSubtitlesPage.UiCheckBoxSubtitleSourceIsEmbeddedStream.Checked
        a.VideoParams_BurnSubtitles_SpecifiedEmbeddedStream = ui.BurnSubtitlesPage.UiTextBoxSpecifiedEmbeddedStream.Text
        a.VideoParams_BurnSubtitles_FontFolder = ui.BurnSubtitlesPage.UiTextBoxFontFolder.Text
        If ui.BurnSubtitlesPage.LabelFontStylePreview.Enabled Then
            a.VideoParams_BurnSubtitles_BasicStyle_Name = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Name
            a.VideoParams_BurnSubtitles_BasicStyle_Size = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Size
            a.VideoParams_BurnSubtitles_BasicStyle_Bold = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Bold
            a.VideoParams_BurnSubtitles_BasicStyle_Italic = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Italic
            a.VideoParams_BurnSubtitles_BasicStyle_Underline = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Underline
            a.VideoParams_BurnSubtitles_BasicStyle_Strikeout = ui.BurnSubtitlesPage.LabelFontStylePreview.Font.Strikeout
        Else
            a.VideoParams_BurnSubtitles_BasicStyle_Name = ""
            a.VideoParams_BurnSubtitles_BasicStyle_Size = 0
            a.VideoParams_BurnSubtitles_BasicStyle_Bold = False
            a.VideoParams_BurnSubtitles_BasicStyle_Italic = False
            a.VideoParams_BurnSubtitles_BasicStyle_Underline = False
            a.VideoParams_BurnSubtitles_BasicStyle_Strikeout = False
        End If
        a.VideoParams_BurnSubtitles_BorderStyle = ui.BurnSubtitlesPage.UiComboBoxBorderType.SelectedIndex
        a.VideoParams_BurnSubtitles_OutlineWidth = ui.BurnSubtitlesPage.UiTextBoxOutlineWidth.Text
        a.VideoParams_BurnSubtitles_ShadowDistance = ui.BurnSubtitlesPage.UiTextBoxShadowDistance.Text
        a.VideoParams_BurnSubtitles_PrimaryColor = ui.BurnSubtitlesPage.LabelPrimaryColor.BackColor
        a.VideoParams_BurnSubtitles_PrimaryColor_Alpha = ui.BurnSubtitlesPage.UiTextBoxSettingsPrimaryColorAlpha.Text
        a.VideoParams_BurnSubtitles_SecondaryColor = ui.BurnSubtitlesPage.LabelSecondaryColor.BackColor
        a.VideoParams_BurnSubtitles_SecondaryColor_Alpha = ui.BurnSubtitlesPage.UiTextBoxSettingsSecondaryColorAlpha.Text
        a.VideoParams_BurnSubtitles_OutlineColor = ui.BurnSubtitlesPage.LabelOutlineColor.BackColor
        a.VideoParams_BurnSubtitles_OutlineColor_Alpha = ui.BurnSubtitlesPage.UiTextBoxSettingsOutlineColorAlpha.Text
        a.VideoParams_BurnSubtitles_BackgroundColor = ui.BurnSubtitlesPage.LabelBackgroundColor.BackColor
        a.VideoParams_BurnSubtitles_BackgroundColor_Alpha = ui.BurnSubtitlesPage.UiTextBoxSettingsBackgroundColorAlpha.Text
        a.VideoParams_BurnSubtitles_Alignment = ui.BurnSubtitlesPage.UiComboBoxAlignmentPosition.SelectedIndex
        a.VideoParams_BurnSubtitles_VerticalMargin = ui.BurnSubtitlesPage.UiTextBoxVerticalMargin.Text
        a.VideoParams_BurnSubtitles_LeftMargin = ui.BurnSubtitlesPage.UiTextBoxLeftMargin.Text
        a.VideoParams_BurnSubtitles_RightMargin = ui.BurnSubtitlesPage.UiTextBoxRightMargin.Text
        a.VideoParams_BurnSubtitles_Spacing = ui.BurnSubtitlesPage.UiTextBoxCharacterSpacing.Text
        a.VideoParams_BurnSubtitles_LineSpacing = ui.BurnSubtitlesPage.UiTextBoxLineSpacing.Text
        a.VideoParams_BurnSubtitles_CustomStyle = ui.BurnSubtitlesPage.UiTextBoxCustomStyle.Text
        a.VideoParams_BurnSubtitles_CustomFilterParams = ui.BurnSubtitlesPage.UiTextBoxCustomFilterParameters.Text

        Select Case ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex
            Case 1 : a.VideoParams_Bitrate_ControlMethod = "CRF"
            Case 2 : a.VideoParams_Bitrate_ControlMethod = "VBR"
            Case 3 : a.VideoParams_Bitrate_ControlMethod = "VBR HQ"
            Case 4 : a.VideoParams_Bitrate_ControlMethod = "CQP"
            Case 5 : a.VideoParams_Bitrate_ControlMethod = "CBR"
        End Select
        Select Case ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex
            Case 1 : a.VideoParams_QualityControl_ParamName = "crf"
            Case 2 : a.VideoParams_QualityControl_ParamName = "cq"
            Case 3 : a.VideoParams_QualityControl_ParamName = "qp"
            Case 4 : a.VideoParams_QualityControl_ParamName = "global_quality"
        End Select
        a.VideoParams_QualityControl_Value = ui.UiTextBoxGlobalQualityControlValue.Text
        a.VideoParams_Bitrate_Base = ui.UiTextBoxBaseBitrate.Text
        a.VideoParams_Bitrate_MinValue = ui.UiTextBoxMinBitrate.Text
        a.VideoParams_Bitrate_MaxValue = ui.UiTextBoxMaxBitrate.Text
        a.VideoParams_Bitrate_BufferSize = ui.UiTextBoxBitrateBufferSize.Text
        For Each c In ui.FlowLayoutPanel1.Controls
            If c.GetType IsNot GetType(UITextBox) Then Continue For
            a.VideoParams_QualityControl_AdvancedParamsList.Add(c.Text)
        Next

        a.VideoParams_ColorManagement_PixelFormat = ui.UiComboBoxPixelFormat.Text
        a.VideoParams_ColorManagement_FilterSelection = ui.UiComboBoxColorSpaceFilterSelect.Text
        a.VideoParams_ColorManagement_MatrixCoefficients = ui.UiComboBoxMatrixCoefficients.Text
        a.VideoParams_ColorManagement_ColorGamut = ui.UiComboBoxColorPrimaries.Text
        a.VideoParams_ColorManagement_TransferCharacteristics = ui.UiComboBoxTransferCharacteristics.Text
        Select Case ui.UiComboBoxColorRange.SelectedIndex
            Case 1 : a.VideoParams_ColorManagement_Range = "tv"
            Case 2 : a.VideoParams_ColorManagement_Range = "pc"
        End Select
        a.VideoParams_ColorManagement_ToneMappingAlgorithm = ui.UiComboBoxToneMappingAlgorithm.Text
        a.VideoParams_ColorManagement_ProcessingMethod = ui.UiComboBoxColorManagementProcessMethod.SelectedIndex
        a.VideoParams_ColorManagement_Brightness = ui.UiTextBoxSimpleColorBrightness.Text
        a.VideoParams_ColorManagement_Contrast = ui.UiTextBoxSimpleColorContrast.Text
        a.VideoParams_ColorManagement_Saturation = ui.UiTextBoxSimpleColorSaturation.Text
        a.VideoParams_ColorManagement_Gamma = ui.UiTextBoxSimpleColorGamma.Text

        Select Case ui.UiComboBoxDenoiseMethod.SelectedIndex
            Case 1 : a.VideoParams_Denoise_Method = "hqdn3d"
            Case 2 : a.VideoParams_Denoise_Method = "nlmeans"
            Case 3 : a.VideoParams_Denoise_Method = "atadenoise"
            Case 4 : a.VideoParams_Denoise_Method = "bm3d"
            Case 5 : a.VideoParams_Denoise_Method = "avs"
        End Select
        a.VideoParams_Denoise_Param1 = ui.UiTextBoxDenoiseParameter1.Text
        a.VideoParams_Denoise_Param2 = ui.UiTextBoxDenoiseParameter2.Text
        a.VideoParams_Denoise_Param3 = ui.UiTextBoxDenoiseParameter3.Text
        a.VideoParams_Denoise_Param4 = ui.UiTextBoxDenoiseParameter4.Text
        a.VideoParams_Sharpen_HorizontalSize = ui.UiTextBoxSharpenHorizontalSize.Text
        a.VideoParams_Sharpen_VerticalSize = ui.UiTextBoxSharpenVerticalSize.Text
        a.VideoParams_Sharpen_Strength = ui.UiTextBoxSharpenStrength.Text
        a.VideoParams_ProgressiveInterlaced = ui.UiComboBoxInterlacedProgressiveProcMethod.SelectedIndex
        a.VideoParams_Flip_AngleRotation = ui.UiComboBoxAngleRotate.SelectedIndex
        a.VideoParams_Flip_MirrorFlip = ui.UiComboBoxMirrorFlip.SelectedIndex

        a.VideoParam_VideoFrameServer_UseAviSynth = ui.UiCheckBoxUseAviSynth.Checked
        a.VideoParam_VideoFrameServer_AvsScriptFile = ui.UiComboBoxSelectAvsFile.Text
        a.VideoParam_VideoFrameServer_UseVapourSynth = ui.UiCheckBoxUseVapourSynth.Checked
        a.VideoParam_VideoFrameServer_VpyScriptFile = ui.UiComboBoxSelectVpyFile.Text

        If ui.UiComboBoxAudioEncoder.SelectedIndex <> -1 Then
            a.AudioParams_Encoder_Specific = AudioEncoderSortList(ui.UiComboBoxAudioEncoder.SelectedIndex)
        End If
        a.AudioParams_Bitrate = ui.UiComboBoxAudioBitrate.Text
        a.AudioParams_QualityParamName = ui.UiComboBoxAudioQualityParameters.Text
        a.AudioParams_QualityValue = ui.UiTextBoxAudioQualityValue.Text
        a.AudioParams_ChannelCount = ui.UiComboBoxChannelLayout.Text
        a.AudioParams_SampleRate = ui.UiComboBoxSampleRate.Text
        a.AudioParams_LoudnessNormalization_TargetLoudness = ui.UiTextBoxLoudnessNormalizationTargetLoudness.Text
        a.AudioParams_LoudnessNormalization_DynamicRange = ui.UiTextBoxLoudnessNormalizationDynamicRange.Text
        a.AudioParams_LoudnessNormalization_PeakLevel = ui.UiTextBoxLoudnessNormalizationPeakValueLevel.Text

        Select Case ui.UiComboBoxImageEncoder.SelectedIndex
            Case 1 : a.ImageParams_Encoder_EncoderName = "png"
            Case 2 : a.ImageParams_Encoder_EncoderName = "apng"
            Case 3 : a.ImageParams_Encoder_EncoderName = "mjpeg"
            Case 4 : a.ImageParams_Encoder_EncoderName = "libwebp"
            Case 5 : a.ImageParams_Encoder_EncoderName = "libwebp_anim"
            Case 6 : a.ImageParams_Encoder_EncoderName = "gif"
            Case 7 : a.ImageParams_Encoder_EncoderName = "bmp"
            Case 8 : a.ImageParams_Encoder_EncoderName = "libopenjpeg"
            Case 9 : a.ImageParams_Encoder_EncoderName = "jpegls"
            Case 10 : a.ImageParams_Encoder_EncoderName = "libsvtjpegxs"
            Case 11 : a.ImageParams_Encoder_EncoderName = "hdr"
            Case 12 : a.ImageParams_Encoder_EncoderName = "tiff"
            Case 13 : a.ImageParams_Encoder_EncoderName = "dpx"
            Case 14 : a.ImageParams_Encoder_EncoderName = "exr"
        End Select
        a.ImageParams_Encoder_QualityValue = ui.UiTextBoxImageEncoderQuality.Text

        a.CustomParams_VideoFilter = ui.UiTextBoxCustomVideoFilter.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_AudioFilter = ui.UiTextBoxCustomAudioFilter.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_FilterComplex = ui.UiTextBoxfilter_complex.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_VideoParams = ui.UiTextBoxCustomVideoParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_AudioParams = ui.UiTextBoxCustomAudioParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_StartParams = ui.UiTextBoxStartParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_BeforeParams = ui.UiTextBoxPreParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_AfterParams = ui.UiTextBoxPostParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_EndParams = ui.UiTextBoxFinalParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")
        a.CustomParams_CompletelyCustom = ui.UiTextBoxCustomFullParameters.Text.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace(vbCr, " ")

        a.ClipRange_Method = ui.UiComboBoxClipMethod.SelectedIndex
        a.ClipRange_InPoint = ui.UiTextBoxQuickClipInPoint.Text
        a.ClipRange_OutPoint = ui.UiTextBoxQuickClipOutPoint.Text
        a.ClipRange_PreDecodeSeconds = ui.UiComboBoxClipForwardDecodingDurationSeconds.Text

        a.StreamControl_ApplyVideoParamsToStreams = ui.UiTextBoxApplyVideoParametersToStreams.Text.Replace("-", "").Split(separator, StringSplitOptions.RemoveEmptyEntries)
        a.StreamControl_PreserveOtherVideoStreams = ui.UiCheckBoxPreserveOtherVideoStreams.Checked
        a.StreamControl_ApplyAudioParamsToStreams = ui.UiTextBoxApplyAudioParametersToStreams.Text.Replace("-", "").Split(separator, StringSplitOptions.RemoveEmptyEntries)
        a.StreamControl_PreserveOtherAudioStreams = ui.UiCheckBoxPreserveOtherAudioStreams.Checked
        a.StreamControl_ApplySubtitleParamsToStreams = ui.UiTextBoxWhichEmbeddedSubtitles.Text.Replace("-", "").Split(separator, StringSplitOptions.RemoveEmptyEntries)
        a.StreamControl_SubtitleOperation = ui.UiComboBoxWhichEmbeddedSubtitlesOperation.SelectedIndex
        a.StreamControl_PreserveOtherSubtitleStreams = ui.UiCheckBoxPreserveOtherSubtitleStreams.Checked
        a.StreamControl_AutoMuxSRT = ui.UiCheckBoxAutoMuxSRT.Checked
        a.StreamControl_AutoMuxASS = ui.UiCheckBoxAutoMuxASS.Checked
        a.StreamControl_AutoMuxSSA = ui.UiCheckBoxAutoMuxSSA.Checked
        a.StreamControl_ConvertSubtitlesToMovtext = ui.UiCheckBoxAutoMuxSubtitleToMovtext.Checked
        a.StreamControl_MetadataOption = ui.UiComboBoxMetadataOption.SelectedIndex
        a.StreamControl_ChapterOption = ui.UiComboBoxChapterOption.SelectedIndex
        a.StreamControl_AttachmentOption = ui.UiComboBoxAttachmentOption.SelectedIndex

    End Sub

    Public Shared Sub ResetAllSettingsInPresets(ui As GeneralParametersPage)
        ui.UiTextBoxOutputContainer.Text = ""
        ui.UiComboBoxOutputDirectory.SelectedIndex = 0

        ui.UiSwitchUseAutoNaming.Active = True
        ui.UiComboBoxAutoNamingOption.SelectedIndex = 0
        ui.UiSwitchDoNotUseOutputFileParameters.Active = False
        ui.UiTextBoxPrefixText.Text = ""
        ui.UiTextBoxReplacementText.Text = ""
        ui.UiTextBoxSuffixText.Text = ""
        ui.UiCheckBoxPreserveCreationTime.Checked = False
        ui.UiCheckBoxPreserveModificationTime.Checked = False
        ui.UiCheckBoxPreserveAccessTime.Checked = False

        ui.UiComboBoxDecodingDecoder.Text = ""
        ui.UiTextBoxCPUDecodingThreadCount.Text = ""
        ui.UiComboBoxDecodingDataFormat.Text = ""
        ui.UiComboBoxHardwareAccelerationDecodingParamName.Text = ""
        ui.UiTextBoxHardwareAccelerationDecodingParameters.Text = ""

        ui.UiComboBoxEncoderCategory.Text = ""
        ui.UiComboBoxSpecificEncoder.Text = ""
        ui.UiComboBoxEncoderPreset.Text = ""
        ui.UiComboBoxProfileFile.Text = ""
        ui.UiComboBoxSceneTune.Text = ""
        ui.UiTextBoxgpu.Text = ""
        ui.UiTextBoxthreads.Text = ""

        ui.UiComboBoxResolution.Text = ""
        ui.UiTextBoxResolutionAutoWidth.Text = ""
        ui.UiTextBoxResolutionAutoHeight.Text = ""
        ui.UiTextBoxCropFilterParameters.Text = ""
        ui.UiComboBoxFrameRate.Text = ""
        ui.UiTextBoxFrameMaxChangeRatio.Text = ""

        ui.FrameInterpolationPage.ResetAllOptions()
        ui.MotionBlurPage.ResetAllOptions()
        ui.SuperResolutionPage.ResetAllOptions()
        ui.BurnSubtitlesPage.ResetAllOptions()

        ui.UiComboBoxGlobalQualityControlMethod.SelectedIndex = -1
        ui.UiComboBoxGlobalQualityControlParameters.SelectedIndex = -1
        ui.UiTextBoxGlobalQualityControlValue.Text = ""
        ui.UiTextBoxBaseBitrate.Text = ""
        ui.UiTextBoxMinBitrate.Text = ""
        ui.UiTextBoxMaxBitrate.Text = ""
        ui.UiTextBoxBitrateBufferSize.Text = ""
        ui.ClearAllAdvancedQualityControl()

        ui.UiComboBoxPixelFormat.Text = ""
        ui.UiComboBoxColorSpaceFilterSelect.Text = ""
        ui.UiComboBoxMatrixCoefficients.Text = ""
        ui.UiComboBoxColorPrimaries.Text = ""
        ui.UiComboBoxTransferCharacteristics.Text = ""
        ui.UiComboBoxColorRange.SelectedIndex = -1
        ui.UiComboBoxToneMappingAlgorithm.Text = ""
        ui.UiComboBoxColorManagementProcessMethod.SelectedIndex = -1
        ui.UiComboBoxDenoiseMethod.SelectedIndex = -1
        ui.UiTextBoxSimpleColorBrightness.Text = ""
        ui.UiTextBoxSimpleColorContrast.Text = ""
        ui.UiTextBoxSimpleColorSaturation.Text = ""
        ui.UiTextBoxSimpleColorGamma.Text = ""

        ui.UiTextBoxDenoiseParameter1.Text = ""
        ui.UiTextBoxDenoiseParameter2.Text = ""
        ui.UiTextBoxDenoiseParameter3.Text = ""
        ui.UiTextBoxDenoiseParameter4.Text = ""
        ui.UiTextBoxSharpenHorizontalSize.Text = ""
        ui.UiTextBoxSharpenVerticalSize.Text = ""
        ui.UiTextBoxSharpenStrength.Text = ""
        ui.UiComboBoxInterlacedProgressiveProcMethod.SelectedIndex = -1
        ui.UiComboBoxAngleRotate.SelectedIndex = -1
        ui.UiComboBoxMirrorFlip.SelectedIndex = -1

        ui.UiCheckBoxUseAviSynth.Checked = False
        ui.UiComboBoxSelectAvsFile.SelectedIndex = -1
        ui.UiCheckBoxUseVapourSynth.Checked = False
        ui.UiComboBoxSelectVpyFile.SelectedIndex = -1

        ui.UiComboBoxAudioEncoder.Text = ""
        ui.UiComboBoxAudioBitrate.Text = ""
        ui.UiComboBoxAudioQualityParameters.Text = ""
        ui.UiTextBoxAudioQualityValue.Text = ""
        ui.UiComboBoxChannelLayout.Text = ""
        ui.UiComboBoxSampleRate.Text = ""
        ui.UiTextBoxLoudnessNormalizationTargetLoudness.Text = ""
        ui.UiTextBoxLoudnessNormalizationDynamicRange.Text = ""
        ui.UiTextBoxLoudnessNormalizationPeakValueLevel.Text = ""

        ui.UiComboBoxImageEncoder.Text = ""
        ui.UiTextBoxImageEncoderQuality.Text = ""

        ui.UiTextBoxCustomVideoFilter.Text = ""
        ui.UiTextBoxCustomAudioFilter.Text = ""
        ui.UiTextBoxfilter_complex.Text = ""
        ui.UiTextBoxCustomVideoParameters.Text = ""
        ui.UiTextBoxCustomAudioParameters.Text = ""
        ui.UiTextBoxStartParameters.Text = ""
        ui.UiTextBoxPreParameters.Text = ""
        ui.UiTextBoxPostParameters.Text = ""
        ui.UiTextBoxFinalParameters.Text = ""
        ui.UiTextBoxCustomFullParameters.Text = ""

        ui.UiComboBoxClipMethod.SelectedIndex = 0
        ui.UiTextBoxQuickClipInPoint.Text = ""
        ui.UiTextBoxQuickClipOutPoint.Text = ""
        ui.UiComboBoxClipForwardDecodingDurationSeconds.Text = ""

        ui.UiTextBoxApplyVideoParametersToStreams.Text = ""
        ui.UiCheckBoxPreserveOtherVideoStreams.Checked = False
        ui.UiTextBoxApplyAudioParametersToStreams.Text = ""
        ui.UiCheckBoxPreserveOtherAudioStreams.Checked = False
        ui.UiTextBoxWhichEmbeddedSubtitles.Text = ""
        ui.UiComboBoxWhichEmbeddedSubtitlesOperation.SelectedIndex = 0
        ui.UiCheckBoxPreserveOtherSubtitleStreams.Checked = False
        ui.UiCheckBoxAutoMuxSRT.Checked = False
        ui.UiCheckBoxAutoMuxASS.Checked = False
        ui.UiCheckBoxAutoMuxSSA.Checked = False
        ui.UiCheckBoxAutoMuxSubtitleToMovtext.Checked = False
        ui.UiComboBoxMetadataOption.SelectedIndex = 0
        ui.UiComboBoxChapterOption.SelectedIndex = 0
        ui.UiComboBoxAttachmentOption.SelectedIndex = 0
    End Sub

    Public Shared Function ConvertPresetToCommandLine(a As PresetDataType, InputFile As String, OutputFile As String) As String
        If a.CustomParams_CompletelyCustom <> "" Then
            Dim x1 = a.CustomParams_CompletelyCustom
            x1 = x1.Replace("<InputFile>", InputFile)
            x1 = x1.Replace("<OutputFile>", OutputFile)
            x1 = x1.Replace("<InputFileWithOutExtension>", Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile)))
            x1 = x1.Replace("<InputFilePath>", Path.GetDirectoryName(InputFile))
            x1 = x1.Replace("<InputFileName>", Path.GetFileName(InputFile))
            x1 = x1.Replace("<InputFileNameWithOutExtension>", Path.GetFileNameWithoutExtension(InputFile))
            x1 = x1.Replace("<\InputFileWithOutExtension>", ConvertPathToFFmpegFilterFormat(Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile))))
            x1 = x1.Replace("<\InputFilePath>", ConvertPathToFFmpegFilterFormat(Path.GetDirectoryName(InputFile)))
            Return x1
            Exit Function
        End If

        Dim VideoFilterParametersList As New List(Of String)
        Dim AudioFilterParametersList As New List(Of String)
        Dim VideoParameters As String = ""
        Dim AudioParameters As String = ""
        Dim SubtitleParameters As String = ""
        Dim InputFileFolder As String = Path.GetDirectoryName(InputFile)

        Dim SRTSubtitleToAutoMux As String = Path.Combine(InputFileFolder, Path.GetFileNameWithoutExtension(InputFile) & ".srt")
        Dim ASSSubtitleToAutoMux As String = Path.Combine(InputFileFolder, Path.GetFileNameWithoutExtension(InputFile) & ".ass")
        Dim SSASubtitleToAutoMux As String = Path.Combine(InputFileFolder, Path.GetFileNameWithoutExtension(InputFile) & ".ssa")
        Dim AutoMuxSubtitleCount As Integer = 0

        Dim arg As String = "-hide_banner -nostdin "

        If a.CustomParams_StartParams <> "" Then arg &= $"{a.CustomParams_StartParams} "

        If a.DecodingParams_Decoder <> "" Then arg &= $"-hwaccel {a.DecodingParams_Decoder} "
        If a.DecodingParams_CPUThreadCount <> "" Then arg &= $"-threads {a.DecodingParams_CPUThreadCount} "
        If a.DecodingParams_OutputFormat <> "" Then arg &= $"-hwaccel_output_format {a.DecodingParams_OutputFormat} "
        If a.DecodingParams_HardwareParamName <> "" AndAlso a.DecodingParams_HardwareParamValue <> "" Then
            arg &= $"{a.DecodingParams_HardwareParamName} {a.DecodingParams_HardwareParamValue} "
        End If

        Select Case a.ClipRange_Method
            Case 1
                If a.ClipRange_InPoint <> "" Then arg &= $"-ss {a.ClipRange_InPoint} "
                If a.ClipRange_OutPoint <> "" Then arg &= $"-to {a.ClipRange_OutPoint} "
            Case 3
                If a.ClipRange_PreDecodeSeconds = "" Then Exit Select
                Dim ForwardDecodingTime = ConvertTimeStringToTimeSpan(a.ClipRange_PreDecodeSeconds)
                Dim InPointTime = ConvertTimeStringToTimeSpan(a.ClipRange_InPoint)
                Dim CalculatedInPointTime = InPointTime - ForwardDecodingTime
                If CalculatedInPointTime < TimeSpan.Zero Then CalculatedInPointTime = TimeSpan.Zero
                arg &= $"-ss {ConvertTimeSpanToTimeString(CalculatedInPointTime)} "

        End Select

        ' Script file is created when the task starts
        If a.VideoParam_VideoFrameServer_UseAviSynth Then
            arg &= $"-i ""{Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile) & ".avs")}"" "
        ElseIf a.VideoParam_VideoFrameServer_UseVapourSynth Then
            arg &= $"-f vapoursynth -i ""{Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile) & Path.GetExtension(a.VideoParam_VideoFrameServer_VpyScriptFile))}"" "
        Else
            arg &= $"-i ""{InputFile}"" "
        End If

        ' Subtitle auto-muxing SRT
        If a.StreamControl_AutoMuxSRT AndAlso FileIO.FileSystem.FileExists(SRTSubtitleToAutoMux) Then
            arg &= $"-i {""""}{SRTSubtitleToAutoMux}{""""} " : AutoMuxSubtitleCount += 1
        End If
        ' Subtitle auto-muxing ASS
        If a.StreamControl_AutoMuxASS AndAlso FileIO.FileSystem.FileExists(ASSSubtitleToAutoMux) Then
            arg &= $"-i {""""}{ASSSubtitleToAutoMux}{""""} " : AutoMuxSubtitleCount += 1
        End If
        ' Subtitle auto-muxing SSA
        If a.StreamControl_AutoMuxSSA AndAlso FileIO.FileSystem.FileExists(SSASubtitleToAutoMux) Then
            arg &= $"-i {""""}{SSASubtitleToAutoMux}{""""} " : AutoMuxSubtitleCount += 1
        End If

        If a.CustomParams_BeforeParams <> "" Then arg &= $"{a.CustomParams_BeforeParams} "

        Select Case a.VideoParams_ProgressiveInterlaced
            Case 1 : VideoFilterParametersList.Add($"yadif=0:-1:0")
            Case 2 : VideoFilterParametersList.Add($"yadif=0:0:0")
            Case 3 : VideoFilterParametersList.Add($"yadif=0:1:0")
            Case 4 : VideoFilterParametersList.Add($"tinterlace=4")
            Case 5 : VideoFilterParametersList.Add($"tinterlace=6")
            Case 6 : VideoFilterParametersList.Add($"fieldmatch,yadif=deint=interlaced,decimate")
            Case 7 : VideoFilterParametersList.Add($"yadif=1")
            Case 8 : VideoFilterParametersList.Add($"pullup=jl=1:jr=1,fps=25")
            Case 9 : VideoFilterParametersList.Add($"yadif=0")
            Case 10 : VideoFilterParametersList.Add($"yadif=1")
            Case 11 : VideoFilterParametersList.Add($"bwdif=0")
            Case 12 : VideoFilterParametersList.Add($"bwdif=1")
        End Select

        If a.VideoParams_Encoder_Category = "Disable" Then VideoParameters &= $"-vn "
        If a.VideoParams_Encoder_Specific <> "" Then VideoParameters &= $"-c:v {a.VideoParams_Encoder_Specific} "

        Select Case a.ImageParams_Encoder_EncoderName
            Case "png" : VideoParameters &= $"-c:v png {If(a.ImageParams_Encoder_QualityValue <> "", "-compression_level " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "apng" : VideoParameters &= $"-c:v apng {If(a.ImageParams_Encoder_QualityValue <> "", "-compression_level " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "mjpeg" : VideoParameters &= $"-c:v mjpeg {If(a.ImageParams_Encoder_QualityValue <> "", "-q:v " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "libwebp" : VideoParameters &= $"-c:v libwebp {If(a.ImageParams_Encoder_QualityValue <> "", "-q:v " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "libwebp_anim" : VideoParameters &= $"-c:v libwebp_anim {If(a.ImageParams_Encoder_QualityValue <> "", "-q:v " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "gif"
                VideoParameters &= $"-c:v gif "
                If a.ImageParams_Encoder_QualityValue = "1" Then VideoFilterParametersList.Add("split [a][b];[a] palettegen [p];[b][p] paletteuse=dither=floyd_steinberg")
            Case "bmp" : VideoParameters &= $"-c:v bmp "
            Case "libopenjpeg" : VideoParameters &= $"-c:v libopenjpeg {If(a.ImageParams_Encoder_QualityValue <> "", "-q:v " & a.ImageParams_Encoder_QualityValue, "")} "
            Case "jpegls" : VideoParameters &= $"-c:v jpegls "
            Case "libsvtjpegxs" : VideoParameters &= $"-c:v libsvtjpegxs "
            Case "hdr" : VideoParameters &= $"-c:v hdr "
            Case "tiff" : VideoParameters &= $"-c:v tiff "
            Case "dpx" : VideoParameters &= $"-c:v dpx "
            Case "exr" : VideoParameters &= $"-c:v exr "
        End Select

        If a.VideoParams_Encoder_Preset <> "" Then
            Select Case a.VideoParams_Encoder_Specific
                Case "libaom-av1", "libvpx-vp9"
                    VideoParameters &= $"-cpu-used {a.VideoParams_Encoder_Preset} "
                Case Else
                    VideoParameters &= $"-preset {a.VideoParams_Encoder_Preset} "
            End Select
        End If
        If a.VideoParams_Encoder_Profile <> "" Then VideoParameters &= $"-profile:v {a.VideoParams_Encoder_Profile} "
        If a.VideoParams_Encoder_Tune <> "" Then
            Select Case a.VideoParams_Encoder_Specific
                Case "hevc_amf", "h264_amf"
                    VideoParameters &= $"-usage {a.VideoParams_Encoder_Tune} "
                Case "libvpx-vp9"
                    VideoParameters &= $"-deadline {a.VideoParams_Encoder_Tune} "
                Case Else
                    VideoParameters &= $"-tune {a.VideoParams_Encoder_Tune} "
            End Select
        End If
        If a.VideoParams_Encoder_GPU <> "" Then arg &= $"-gpu {a.VideoParams_Encoder_GPU} "
        If a.VideoParams_Encoder_Threads <> "" Then VideoParameters &= $"-threads {a.VideoParams_Encoder_Threads} "

        '---------------- VideoSize / FrameRate ----------------
        If a.VideoParams_CropFilterParams <> "" Then VideoFilterParametersList.Add($"crop={a.VideoParams_CropFilterParams}")
        If a.VideoParams_Resolution <> "" Then
            VideoParameters &= $"-s {a.VideoParams_Resolution} "
        Else
            If a.VideoParams_ResolutionAuto_Width <> "" Then
                VideoFilterParametersList.Add($"scale={a.VideoParams_ResolutionAuto_Width}:-2")
            ElseIf a.VideoParams_ResolutionAuto_Height <> "" Then
                VideoFilterParametersList.Add($"scale=-2:{a.VideoParams_ResolutionAuto_Height}")
            End If
        End If

        If a.VideoParams_FrameRate <> "" Then VideoParameters &= $"-r {a.VideoParams_FrameRate} "
        If a.VideoParams_FrameRate_MaxChangeRatio <> "" Then
            VideoFilterParametersList.Add($"mpdecimate=max={a.VideoParams_FrameRate_MaxChangeRatio}")
            VideoParameters &= "-fps_mode vfr "
        End If

        '---------------- Frame Interpolation ----------------
        If a.VideoParams_FrameInterpolation_TargetFrameRate <> "" AndAlso a.VideoParams_FrameInterpolation_Mode <> "" Then
            Dim s1 As String = $"minterpolate=fps={a.VideoParams_FrameInterpolation_TargetFrameRate}:mi_mode={a.VideoParams_FrameInterpolation_Mode}"
            If a.VideoParams_FrameInterpolation_Mode = "mci" AndAlso a.VideoParams_FrameInterpolation_MotionCompensationMode <> "" Then
                s1 &= $":mc_mode={a.VideoParams_FrameInterpolation_MotionCompensationMode}"
            End If
            If a.VideoParams_FrameInterpolation_MotionEstimationMode <> "" Then s1 &= $":me_mode={a.VideoParams_FrameInterpolation_MotionEstimationMode}"
            If a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm <> "" Then s1 &= $":me={a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm}"
            If a.VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation Then s1 &= $":vsbmc=1"
            If a.VideoParams_FrameInterpolation_BlockSize <> "" Then s1 &= $":mb_size={a.VideoParams_FrameInterpolation_BlockSize}"
            If a.VideoParams_FrameInterpolation_SearchRange <> "" Then s1 &= $":search_param={a.VideoParams_FrameInterpolation_SearchRange}"
            If a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength <> "" Then s1 &= $":scd=fdiff:scd_threshold={a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength}"
            VideoFilterParametersList.Add(s1)
        End If

        '---------------- Frame Blending ----------------
        If a.VideoParams_FrameBlending_BlendMode <> "" Then
            Dim s1 As String = $"tblend=all_mode={a.VideoParams_FrameBlending_BlendMode}"
            If a.VideoParams_FrameBlending_TargetFrameRate <> "" Then s1 = $"fps={a.VideoParams_FrameBlending_TargetFrameRate}," & s1
            If a.VideoParams_FrameBlending_BlendRatio <> "" Then s1 &= $":all_opacity={a.VideoParams_FrameBlending_BlendRatio}"
            VideoFilterParametersList.Add(s1)
        End If

        '---------------- Super Resolution ----------------
        If a.VideoParams_SuperResolution_TargetWidth <> "" AndAlso a.VideoParams_SuperResolution_TargetHeight <> "" Then
            Dim s1 As String = $"libplacebo=w={a.VideoParams_SuperResolution_TargetWidth}:h={a.VideoParams_SuperResolution_TargetHeight}"
            If a.VideoParams_SuperResolution_UpsamplingAlgorithm <> "" Then s1 &= $":upscaler={a.VideoParams_SuperResolution_UpsamplingAlgorithm}"
            If a.VideoParams_SuperResolution_DownsamplingAlgorithm <> "" Then s1 &= $":downscaler={a.VideoParams_SuperResolution_DownsamplingAlgorithm}"
            If a.VideoParams_SuperResolution_AntiRingingStrength <> "" Then s1 &= $":antiringing={a.VideoParams_SuperResolution_AntiRingingStrength}"
            For Each shader In a.VideoParams_SuperResolution_ShaderList
                s1 &= $":custom_shader_path='{ConvertPathToFFmpegFilterFormat(shader)}'"
            Next
            VideoFilterParametersList.Add(s1)
        End If

        '---------------- Video Parameters | Quality ----------------
        Select Case a.VideoParams_Bitrate_ControlMethod
            Case "VBR"
                Select Case a.VideoParams_Encoder_Specific
                    Case "av1_amf", "hevc_amf", "h264_amf"
                        VideoParameters &= $"-rc qvbr "
                    Case Else
                        VideoParameters &= $"-rc vbr "
                End Select
            Case "VBR HQ"
                Select Case a.VideoParams_Encoder_Specific
                    Case "hevc_nvenc", "h264_nvenc"
                        VideoParameters &= $"-rc vbr_hq "
                    Case "av1_amf"
                        VideoParameters &= $"-rc hqvbr -quality high_quality "
                    Case "hevc_amf", "h264_amf"
                        VideoParameters &= $"-rc hqvbr -quality quality "
                    Case "av1_qsv", "hevc_qsv", "h264_qsv"
                        VideoParameters &= $"-rc la_icq "
                End Select
            Case "CRF"
            Case "CQP"
                Select Case a.VideoParams_Encoder_Specific
                    Case "av1_nvenc", "hevc_nvenc", "h264_nvenc"
                        VideoParameters &= $"-rc constqp "
                    Case "av1_amf", "hevc_amf", "h264_amf"
                        VideoParameters &= $"-rc cqp "
                End Select
            Case "CBR"
                VideoParameters &= $"-rc cbr "
        End Select

        If a.VideoParams_QualityControl_Value <> "" Then
            Select Case a.VideoParams_QualityControl_ParamName
                Case "crf" : VideoParameters &= $"-crf {a.VideoParams_QualityControl_Value} "
                Case "cq" : VideoParameters &= $"-cq {a.VideoParams_QualityControl_Value} "
                Case "qp" : VideoParameters &= $"-qp {a.VideoParams_QualityControl_Value} "
                Case "global_quality" : VideoParameters &= $"-global_quality {a.VideoParams_QualityControl_Value} "
            End Select
        End If
        If a.VideoParams_Bitrate_Base <> "" Then VideoParameters &= $"-b:v {a.VideoParams_Bitrate_Base} "
        If a.VideoParams_Bitrate_MinValue <> "" Then VideoParameters &= $"-minrate {a.VideoParams_Bitrate_MinValue} "
        If a.VideoParams_Bitrate_MaxValue <> "" Then VideoParameters &= $"-maxrate {a.VideoParams_Bitrate_MaxValue} "
        If a.VideoParams_Bitrate_BufferSize <> "" Then VideoParameters &= $"-bufsize {a.VideoParams_Bitrate_BufferSize} "
        For Each c In a.VideoParams_QualityControl_AdvancedParamsList
            VideoParameters &= $"{c} "
        Next

        If a.VideoParams_ColorManagement_PixelFormat <> "" Then VideoParameters &= $"-pix_fmt {a.VideoParams_ColorManagement_PixelFormat} "

        Select Case a.VideoParams_ColorManagement_ProcessingMethod
            Case 1, 2
                If a.VideoParams_ColorManagement_MatrixCoefficients <> "" Then VideoParameters &= $"-colorspace {a.VideoParams_ColorManagement_MatrixCoefficients} "
                If a.VideoParams_ColorManagement_ColorGamut <> "" Then VideoParameters &= $"-color_primaries {a.VideoParams_ColorManagement_ColorGamut} "
                If a.VideoParams_ColorManagement_TransferCharacteristics <> "" Then VideoParameters &= $"-color_trc {a.VideoParams_ColorManagement_TransferCharacteristics} "
                If a.VideoParams_ColorManagement_Range <> "" Then VideoParameters &= $"-color_range {a.VideoParams_ColorManagement_Range} "
        End Select
        Select Case a.VideoParams_ColorManagement_ProcessingMethod
            Case 1, 3
                Select Case a.VideoParams_ColorManagement_FilterSelection
                    Case "zscale"
                        Dim abc As New List(Of String)
                        If a.VideoParams_ColorManagement_MatrixCoefficients <> "" Then abc.Add($"matrix={a.VideoParams_ColorManagement_MatrixCoefficients}")
                        If a.VideoParams_ColorManagement_ColorGamut <> "" Then abc.Add($"primaries={a.VideoParams_ColorManagement_ColorGamut}")
                        If a.VideoParams_ColorManagement_TransferCharacteristics <> "" Then abc.Add($"transfer={a.VideoParams_ColorManagement_TransferCharacteristics}")
                        If a.VideoParams_ColorManagement_Range = "pc" Then abc.Add($"range=full")
                        If a.VideoParams_ColorManagement_Range = "tv" Then abc.Add($"range=limited")
                        If abc.Count > 0 Then VideoFilterParametersList.Add($"zscale={String.Join(":", abc)}")
                    Case "libplacebo"
                        Dim abc As New List(Of String)
                        If a.VideoParams_ColorManagement_MatrixCoefficients <> "" Then abc.Add($"colorspace={a.VideoParams_ColorManagement_MatrixCoefficients}")
                        If a.VideoParams_ColorManagement_ColorGamut <> "" Then abc.Add($"color_primaries={a.VideoParams_ColorManagement_ColorGamut}")
                        If a.VideoParams_ColorManagement_TransferCharacteristics <> "" Then abc.Add($"color_trc={a.VideoParams_ColorManagement_TransferCharacteristics}")
                        If a.VideoParams_ColorManagement_Range = "pc" Then abc.Add($"range=full")
                        If a.VideoParams_ColorManagement_Range = "tv" Then abc.Add($"range=limited")
                        If a.VideoParams_ColorManagement_ToneMappingAlgorithm <> "" Then abc.Add($"tonemapping={a.VideoParams_ColorManagement_ToneMappingAlgorithm}")
                        If abc.Count > 0 Then VideoFilterParametersList.Add($"libplacebo={String.Join(":", abc)}")
                End Select
        End Select

        Select Case a.VideoParams_Denoise_Method
            Case "hqdn3d"
                Dim abc As New List(Of String)
                If a.VideoParams_Denoise_Param1 <> "" Then abc.Add($"luma_spatial={a.VideoParams_Denoise_Param1}")
                If a.VideoParams_Denoise_Param2 <> "" Then abc.Add($"chroma_spatial={a.VideoParams_Denoise_Param2}")
                If a.VideoParams_Denoise_Param3 <> "" Then abc.Add($"luma_tmp={a.VideoParams_Denoise_Param3}")
                If a.VideoParams_Denoise_Param4 <> "" Then abc.Add($"chroma_tmp={a.VideoParams_Denoise_Param4}")
                If abc.Count > 0 Then VideoFilterParametersList.Add($"hqdn3d={String.Join(":", abc)}")
            Case "nlmeans"
                Dim abc As New List(Of String)
                If a.VideoParams_Denoise_Param1 <> "" Then abc.Add($"s={a.VideoParams_Denoise_Param1}")
                If a.VideoParams_Denoise_Param2 <> "" Then abc.Add($"p={a.VideoParams_Denoise_Param2}")
                If a.VideoParams_Denoise_Param3 <> "" Then abc.Add($"pc={a.VideoParams_Denoise_Param3}")
                If a.VideoParams_Denoise_Param4 <> "" Then abc.Add($"r={a.VideoParams_Denoise_Param4}")
                If abc.Count > 0 Then VideoFilterParametersList.Add($"nlmeans={String.Join(":", abc)}")
            Case "atadenoise"
                Dim abc As New List(Of String)
                If a.VideoParams_Denoise_Param1 <> "" Then abc.Add($"0a={a.VideoParams_Denoise_Param1}")
                If a.VideoParams_Denoise_Param2 <> "" Then abc.Add($"0b={a.VideoParams_Denoise_Param2}")
                If a.VideoParams_Denoise_Param3 <> "" Then abc.Add($"1a={a.VideoParams_Denoise_Param3}")
                If a.VideoParams_Denoise_Param4 <> "" Then abc.Add($"1b={a.VideoParams_Denoise_Param4}")
                If abc.Count > 0 Then VideoFilterParametersList.Add($"atadenoise={String.Join(":", abc)}")
            Case "bm3d"
                Dim abc As New List(Of String)
                If a.VideoParams_Denoise_Param1 <> "" Then abc.Add($"sigma={a.VideoParams_Denoise_Param1}")
                If a.VideoParams_Denoise_Param2 <> "" Then abc.Add($"block={a.VideoParams_Denoise_Param2}")
                If a.VideoParams_Denoise_Param3 <> "" Then abc.Add($"bstep={a.VideoParams_Denoise_Param3}")
                If a.VideoParams_Denoise_Param4 <> "" Then abc.Add($"group={a.VideoParams_Denoise_Param4}")
                If abc.Count > 0 Then VideoFilterParametersList.Add($"bm3d={String.Join(":", abc)}")
        End Select

        If a.VideoParams_Sharpen_HorizontalSize <> "" AndAlso a.VideoParams_Sharpen_VerticalSize <> "" AndAlso a.VideoParams_Sharpen_Strength <> "" Then
            VideoFilterParametersList.Add($"unsharp=luma_msize_x={a.VideoParams_Sharpen_HorizontalSize}:luma_msize_y={a.VideoParams_Sharpen_VerticalSize}:luma_amount={a.VideoParams_Sharpen_Strength}")
        End If

        If a.VideoParams_BurnSubtitles_FilterSelection = "subtitles" OrElse a.VideoParams_BurnSubtitles_FilterSelection = "ass" Then
            Dim FilterParametersList As New List(Of String)
            Dim StyleParametersList As New List(Of String)
            If a.VideoParams_BurnSubtitles_UseExternalFile Then
                Dim SubtitleLocation, SubtitleFileName As String
                If a.VideoParams_BurnSubtitles_ExternalSubtitleFileName = "" Then
                    SubtitleFileName = Path.GetFileNameWithoutExtension(InputFile)
                Else
                    SubtitleFileName = a.VideoParams_BurnSubtitles_ExternalSubtitleFileName
                End If
                If a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation = "" Then
                    SubtitleLocation = Path.GetDirectoryName(InputFile)
                Else
                    SubtitleLocation = a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation
                End If
                If InputFile = "<InputFile>" Then
                    FilterParametersList.Add($"filename='<SubtitleFile | Special Character For Preview Mode>'")
                Else
                    For Each abc In a.VideoParams_BurnSubtitles_SubtitleFormatPriority
                        Select Case abc
                            Case 1
                                Dim efg = Path.Combine(SubtitleLocation, SubtitleFileName & ".srt")
                                If FileIO.FileSystem.FileExists(efg) Then
                                    FilterParametersList.Add($"filename='{ConvertPathToFFmpegFilterFormat(efg)}'")
                                    Exit For
                                End If
                            Case 2
                                Dim efg = Path.Combine(SubtitleLocation, SubtitleFileName & ".ass")
                                If FileIO.FileSystem.FileExists(efg) Then
                                    FilterParametersList.Add($"filename='{ConvertPathToFFmpegFilterFormat(efg)}'")
                                    Exit For
                                End If
                            Case 3
                                Dim efg = Path.Combine(SubtitleLocation, SubtitleFileName & ".ssa")
                                If FileIO.FileSystem.FileExists(efg) Then
                                    FilterParametersList.Add($"filename='{ConvertPathToFFmpegFilterFormat(efg)}'")
                                    Exit For
                                End If
                        End Select
                    Next
                End If
            End If
            If a.VideoParams_BurnSubtitles_UseEmbeddedStream Then
                FilterParametersList.Add($"filename='{ConvertPathToFFmpegFilterFormat(InputFile)}'")
                FilterParametersList.Add($"stream_index={a.VideoParams_BurnSubtitles_SpecifiedEmbeddedStream}")
            End If
            If a.VideoParams_BurnSubtitles_FontFolder <> "" Then FilterParametersList.Add($"fontsdir='{ConvertPathToFFmpegFilterFormat(a.VideoParams_BurnSubtitles_FontFolder)}'")
            If a.VideoParams_BurnSubtitles_BasicStyle_Name <> "" Then StyleParametersList.Add($"FontName={a.VideoParams_BurnSubtitles_BasicStyle_Name}")
            If a.VideoParams_BurnSubtitles_BasicStyle_Size <> 0 Then StyleParametersList.Add($"FontSize={a.VideoParams_BurnSubtitles_BasicStyle_Size}")
            If a.VideoParams_BurnSubtitles_BasicStyle_Bold Then StyleParametersList.Add($"Bold=-1")
            If a.VideoParams_BurnSubtitles_BasicStyle_Italic Then StyleParametersList.Add($"Italic=-1")
            If a.VideoParams_BurnSubtitles_BasicStyle_Underline Then StyleParametersList.Add($"Underline=-1")
            If a.VideoParams_BurnSubtitles_BasicStyle_Strikeout Then StyleParametersList.Add($"StrikeOut=-1")
            Select Case a.VideoParams_BurnSubtitles_BorderStyle
                Case 1 : StyleParametersList.Add($"BorderStyle=1")
                Case 2 : StyleParametersList.Add($"BorderStyle=3")
            End Select
            If a.VideoParams_BurnSubtitles_OutlineWidth <> "" Then StyleParametersList.Add($"Outline={a.VideoParams_BurnSubtitles_OutlineWidth}")
            If a.VideoParams_BurnSubtitles_ShadowDistance <> "" Then StyleParametersList.Add($"Shadow={a.VideoParams_BurnSubtitles_ShadowDistance}")
            If a.VideoParams_BurnSubtitles_PrimaryColor <> Color.Transparent Then StyleParametersList.Add($"PrimaryColour={ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_PrimaryColor.ToHTML, a.VideoParams_BurnSubtitles_PrimaryColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_SecondaryColor <> Color.Transparent Then StyleParametersList.Add($"SecondaryColour={ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_SecondaryColor.ToHTML, a.VideoParams_BurnSubtitles_SecondaryColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_OutlineColor <> Color.Transparent Then StyleParametersList.Add($"OutlineColour={ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_OutlineColor.ToHTML, a.VideoParams_BurnSubtitles_OutlineColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_BackgroundColor <> Color.Transparent Then StyleParametersList.Add($"BackColour={ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_BackgroundColor.ToHTML, a.VideoParams_BurnSubtitles_BackgroundColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_Alignment > 0 Then StyleParametersList.Add($"Alignment={a.VideoParams_BurnSubtitles_Alignment}")
            If a.VideoParams_BurnSubtitles_VerticalMargin <> "" Then StyleParametersList.Add($"MarginV={a.VideoParams_BurnSubtitles_VerticalMargin}")
            If a.VideoParams_BurnSubtitles_LeftMargin <> "" Then StyleParametersList.Add($"MarginL={a.VideoParams_BurnSubtitles_LeftMargin}")
            If a.VideoParams_BurnSubtitles_RightMargin <> "" Then StyleParametersList.Add($"MarginR={a.VideoParams_BurnSubtitles_RightMargin}")
            If a.VideoParams_BurnSubtitles_Spacing <> "" Then StyleParametersList.Add($"Spacing={a.VideoParams_BurnSubtitles_Spacing}")
            If a.VideoParams_BurnSubtitles_LineSpacing <> "" Then StyleParametersList.Add($"LineSpacing={a.VideoParams_BurnSubtitles_LineSpacing}")
            If a.VideoParams_BurnSubtitles_CustomStyle <> "" Then StyleParametersList.Add(a.VideoParams_BurnSubtitles_CustomStyle)
            If StyleParametersList.Count > 0 Then FilterParametersList.Add($"force_style='{Join(StyleParametersList.ToArray, ",")}'")
            If a.VideoParams_BurnSubtitles_CustomFilterParams <> "" Then FilterParametersList.Add(a.VideoParams_BurnSubtitles_CustomFilterParams)
            If FilterParametersList.Count > 0 Then VideoFilterParametersList.Add($"{a.VideoParams_BurnSubtitles_FilterSelection}={Join(FilterParametersList.ToArray, ":")}")
        End If

        Select Case a.VideoParams_Flip_AngleRotation
            Case 1 : VideoFilterParametersList.AddRange({$"transpose=1"})
            Case 2 : VideoFilterParametersList.AddRange({$"transpose=1", $"transpose=1"})
            Case 3 : VideoFilterParametersList.AddRange({$"transpose=1", $"transpose=1", $"transpose=1"})
            Case 4 : VideoFilterParametersList.AddRange({$"transpose=2"})
            Case 5 : VideoFilterParametersList.AddRange({$"transpose=2", $"transpose=2"})
            Case 6 : VideoFilterParametersList.AddRange({$"transpose=2", $"transpose=2", $"transpose=2"})
        End Select

        Select Case a.VideoParams_Flip_MirrorFlip
            Case 1 : VideoFilterParametersList.Add($"hflip")
            Case 2 : VideoFilterParametersList.Add($"vflip")
        End Select

        Select Case a.ClipRange_Method
            Case 2
                If a.ClipRange_InPoint <> "" Then VideoParameters &= $"-ss {a.ClipRange_InPoint} "
                If a.ClipRange_OutPoint <> "" Then VideoParameters &= $"-to {a.ClipRange_OutPoint} "
            Case 3
                If a.ClipRange_PreDecodeSeconds = "" Then Exit Select
                Dim ForwardDecodingTime = ConvertTimeStringToTimeSpan(a.ClipRange_PreDecodeSeconds)
                VideoParameters &= $"-ss {ConvertTimeSpanToTimeString(ForwardDecodingTime)} "
                If a.ClipRange_OutPoint = "" Then Exit Select
                Dim Duration = ConvertTimeStringToTimeSpan(a.ClipRange_OutPoint) - ConvertTimeStringToTimeSpan(a.ClipRange_InPoint)
                VideoParameters &= $"-t {ConvertTimeSpanToTimeString(Duration)} "
            Case 4
                Dim abc As New List(Of String)
                If a.ClipRange_InPoint <> "" Then abc.Add($"start={ConvertTimeStringToTimeSpan(a.ClipRange_InPoint).TotalSeconds}")
                If a.ClipRange_OutPoint <> "" Then abc.Add($"end={ConvertTimeStringToTimeSpan(a.ClipRange_OutPoint).TotalSeconds}")
                VideoFilterParametersList.Add($"trim={Join(abc.ToArray, ":")}")
                VideoFilterParametersList.Add("setpts=PTS-STARTPTS")
                AudioFilterParametersList.Add($"atrim={Join(abc.ToArray, ":")}")
                AudioFilterParametersList.Add("asetpts=PTS-STARTPTS")
        End Select

        If a.CustomParams_VideoFilter <> "" Then VideoFilterParametersList.Add(a.CustomParams_VideoFilter)
        'If VideoFilterParametersList.Count > 0 Then
        '    Dim vf As String = String.Join(",", VideoFilterParametersList)
        '    VideoParameters &= $"-vf ""{vf}"" "
        'End If

        If a.CustomParams_VideoParams <> "" Then VideoParameters &= $"{a.CustomParams_VideoParams} "

        '=============================================================

        If a.AudioParams_Encoder_Specific <> "" Then
            If a.AudioParams_Encoder_Specific = "-an" Then
                AudioParameters &= $"-an "
            Else
                AudioParameters &= $"-c:a {a.AudioParams_Encoder_Specific} "
            End If
        End If
        If a.AudioParams_Bitrate <> "" Then AudioParameters &= $"-b:a {a.AudioParams_Bitrate} "
        If a.AudioParams_QualityParamName <> "" AndAlso a.AudioParams_QualityValue <> "" Then
            AudioParameters &= $"{a.AudioParams_QualityParamName} {a.AudioParams_QualityValue} "
        End If
        If a.AudioParams_ChannelCount <> "" Then AudioParameters &= $"-channel_layout {a.AudioParams_ChannelCount} "
        If a.AudioParams_SampleRate <> "" Then AudioParameters &= $"-ar {a.AudioParams_SampleRate} "
        If a.AudioParams_LoudnessNormalization_TargetLoudness <> "" Then
            AudioFilterParametersList.Add($"loudnorm=I={If(a.AudioParams_LoudnessNormalization_TargetLoudness <> "", a.AudioParams_LoudnessNormalization_TargetLoudness, -16)}:LRA={If(a.AudioParams_LoudnessNormalization_DynamicRange <> "", a.AudioParams_LoudnessNormalization_DynamicRange, 1)}:tp={If(a.AudioParams_LoudnessNormalization_PeakLevel <> "", a.AudioParams_LoudnessNormalization_PeakLevel, -1)}")
        End If

        If a.CustomParams_AudioFilter <> "" Then AudioFilterParametersList.Add(a.CustomParams_AudioFilter)
        'If AudioFilterParametersList.Count > 0 Then
        '    Dim vf As String = String.Join(",", AudioFilterParametersList)
        '    AudioParameters &= $"-af ""{vf}"" "
        'End If

        If a.CustomParams_AudioParams <> "" Then arg &= $"{a.CustomParams_AudioParams} "

        '=================================================================

        If a.VideoParams_ColorManagement_Brightness <> "" AndAlso a.VideoParams_ColorManagement_Contrast <> "" AndAlso a.VideoParams_ColorManagement_Saturation <> "" AndAlso a.VideoParams_ColorManagement_Gamma <> "" Then
            Dim eq As New List(Of String)
            If a.VideoParams_ColorManagement_Brightness <> "" Then eq.Add($"brightness={a.VideoParams_ColorManagement_Brightness}")
            If a.VideoParams_ColorManagement_Contrast <> "" Then eq.Add($"contrast={a.VideoParams_ColorManagement_Contrast}")
            If a.VideoParams_ColorManagement_Saturation <> "" Then eq.Add($"saturation={a.VideoParams_ColorManagement_Saturation}")
            If a.VideoParams_ColorManagement_Gamma <> "" Then eq.Add($"gamma={a.VideoParams_ColorManagement_Gamma}")
            VideoFilterParametersList.Add($"eq={String.Join(":", eq)}")
        End If

        '=================================================================
        ' StreamControl - Video
        ' Core logic: When needing to preserve other streams, use -map to map all streams,
        ' set default -c:v copy first, then use -c:v:index to override specific streams.
        ' Filter and other parameters are specified via -filter:v:index for the target stream.
        '=================================================================

        Dim NeedToMapVideo As Boolean = a.StreamControl_PreserveOtherVideoStreams OrElse (a.StreamControl_ApplyVideoParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplyVideoParamsToStreams.Length > 0)
        If NeedToMapVideo Then
            If a.StreamControl_PreserveOtherVideoStreams Then
                ' Map all Video streams
                arg &= "-map 0:v? "
                ' Copy all streams by default
                arg &= "-c:v copy "
                ' Determine target stream index list
                Dim TargetStreamIndexList As New List(Of String)
                If a.StreamControl_ApplyVideoParamsToStreams.Length > 0 Then
                    For Each vi In a.StreamControl_ApplyVideoParamsToStreams
                        TargetStreamIndexList.Add(ExtractStreamTypeIndex(vi))
                    Next
                Else
                    TargetStreamIndexList.Add("0") ' Default to processing the first stream
                End If
                ' Apply parameters to each target stream
                If VideoParameters <> "" OrElse VideoFilterParametersList.Count > 0 Then
                    For Each StreamIndex In TargetStreamIndexList
                        arg &= GenerateVideoParametersForStream(VideoParameters, VideoFilterParametersList, StreamIndex)
                    Next
                End If
            Else
                ' Only map specified streams, do not preserve others
                For Each vi In a.StreamControl_ApplyVideoParamsToStreams
                    arg &= $"-map {vi}? "
                Next
                ' Apply parameters directly (acts on all mapped streams)
                If VideoFilterParametersList.Count > 0 Then
                    arg &= $"-vf ""{String.Join(",", VideoFilterParametersList)}"" "
                End If
                If VideoParameters <> "" Then arg &= $"{VideoParameters} "
            End If
        Else
            ' No map used, FFmpeg default behavior
            If VideoFilterParametersList.Count > 0 Then
                arg &= $"-vf ""{String.Join(",", VideoFilterParametersList)}"" "
            End If
            If VideoParameters <> "" Then arg &= $"{VideoParameters} "
        End If

        '=================================================================
        ' StreamControl - Audio
        '=================================================================

        Dim NeedToMapAudio As Boolean = a.StreamControl_PreserveOtherAudioStreams OrElse (a.StreamControl_ApplyAudioParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplyAudioParamsToStreams.Length > 0)
        If NeedToMapAudio Then
            If a.StreamControl_PreserveOtherAudioStreams Then
                arg &= "-map 0:a? "
                arg &= "-c:a copy "
                Dim TargetStreamIndexList As New List(Of String)
                If a.StreamControl_ApplyAudioParamsToStreams.Length > 0 Then
                    For Each ai In a.StreamControl_ApplyAudioParamsToStreams
                        TargetStreamIndexList.Add(ExtractStreamTypeIndex(ai))
                    Next
                Else
                    TargetStreamIndexList.Add("0")
                End If
                If AudioParameters <> "" OrElse AudioFilterParametersList.Count > 0 Then
                    For Each StreamIndex In TargetStreamIndexList
                        arg &= GenerateAudioParametersForStream(AudioParameters, AudioFilterParametersList, StreamIndex)
                    Next
                End If
            Else
                For Each ai In a.StreamControl_ApplyAudioParamsToStreams
                    arg &= $"-map {ai}? "
                Next
                If AudioFilterParametersList.Count > 0 Then
                    arg &= $"-af ""{String.Join(",", AudioFilterParametersList)}"" "
                End If
                If AudioParameters <> "" Then arg &= $"{AudioParameters} "
            End If
        Else
            If AudioFilterParametersList.Count > 0 Then
                arg &= $"-af ""{String.Join(",", AudioFilterParametersList)}"" "
            End If
            If AudioParameters <> "" Then arg &= $"{AudioParameters} "
        End If

        '=================================================================
        ' StreamControl - Subtitles
        '=================================================================

        Select Case a.StreamControl_SubtitleOperation
            Case 1 : SubtitleParameters = "copy"
            Case 2 : SubtitleParameters = "mov_text"
            Case 3 : SubtitleParameters = "srt"
            Case 4 : SubtitleParameters = "ass"
            Case 5 : SubtitleParameters = "ssa"
        End Select

        Dim NeedToMapSubtitles As Boolean = a.StreamControl_PreserveOtherSubtitleStreams OrElse (a.StreamControl_ApplySubtitleParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplySubtitleParamsToStreams.Length > 0)
        If NeedToMapSubtitles Then
            If a.StreamControl_PreserveOtherSubtitleStreams Then
                arg &= "-map 0:s? -c:s copy "
                If a.StreamControl_ApplySubtitleParamsToStreams.Length > 0 AndAlso SubtitleParameters <> "" Then
                    For Each si In a.StreamControl_ApplySubtitleParamsToStreams
                        Dim StreamIndex = ExtractStreamTypeIndex(si)
                        arg &= $"-c:s:{StreamIndex} {SubtitleParameters} "
                    Next
                ElseIf SubtitleParameters <> "" Then
                    arg &= $"-c:s:0 {SubtitleParameters} "
                End If
            Else
                For Each si In a.StreamControl_ApplySubtitleParamsToStreams
                    arg &= $"-map {si}? "
                Next
                If SubtitleParameters <> "" Then arg &= $"-c:s {SubtitleParameters} "
            End If
        End If

        '=================================================================
        ' Auto-mux Subtitles
        '=================================================================

        If AutoMuxSubtitleCount > 0 Then
            For i = 1 To AutoMuxSubtitleCount
                arg &= $"-map {i}:s? "
            Next
            arg &= $"-c:s {If(a.StreamControl_ConvertSubtitlesToMovtext, "mov_text", "copy")} "
        End If

        '=================================================================

        Select Case a.StreamControl_MetadataOption
            Case 1 : arg &= $"-map_metadata 0 "
            Case 2 : arg &= $"-map_metadata -1 "
            Case 3 : arg &= $"-movflags +use_metadata_tags "
        End Select

        Select Case a.StreamControl_ChapterOption
            Case 1 : arg &= $"-map_chapters 0 "
            Case 2 : arg &= $"-map_chapters -1 "
        End Select

        Select Case a.StreamControl_AttachmentOption
            Case 1 : arg &= $"{If(arg.Contains("-map"), "-map 0:t? ", "")}-c:t copy "
        End Select

        If a.CustomParams_FilterComplex <> "" Then
            arg &= $"-filter_complex ""{a.CustomParams_FilterComplex}"" "
        End If

        '=================================================================

        If a.CustomParams_AfterParams <> "" Then arg &= $"{a.CustomParams_AfterParams} "

        If Not a.OutputNaming_DoNotUseOutputFileParams Then arg &= $"""{OutputFile}"" -y "

        If a.CustomParams_EndParams <> "" Then arg &= $"{a.CustomParams_EndParams} "

        arg = arg.Replace("<InputFile>", InputFile)
        arg = arg.Replace("<InputFileWithOutExtension>", Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile)))
        arg = arg.Replace("<InputFilePath>", Path.GetDirectoryName(InputFile))
        arg = arg.Replace("<InputFileName>", Path.GetFileName(InputFile))
        arg = arg.Replace("<InputFileNameWithOutExtension>", Path.GetFileNameWithoutExtension(InputFile))
        arg = arg.Replace("<\InputFileWithOutExtension>", ConvertPathToFFmpegFilterFormat(Path.Combine(Path.GetDirectoryName(InputFile), Path.GetFileNameWithoutExtension(InputFile))))
        arg = arg.Replace("<\InputFilePath>", ConvertPathToFFmpegFilterFormat(Path.GetDirectoryName(InputFile)))

        Return arg
    End Function

    ''' <summary>
    ''' Generate VideoParameters for a specific stream
    ''' Supports adding index to parameters that support stream indexing, converts unsupported parameters to filters
    ''' </summary>
    Private Shared Function GenerateVideoParametersForStream(VideoParameters As String, VideoFilterParametersList As List(Of String), StreamIndex As String) As String
        Dim result As String = ""
        Dim ExtraFilters As New List(Of String)
        Dim ProcessedParameters As String = VideoParameters

        If ProcessedParameters <> "" Then
            ' Extract and remove -r (framerate), convert to fps filter
            Dim matchR = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-r\s+(\S+)")
            If matchR.Success Then
                ExtraFilters.Add($"fps={matchR.Groups(1).Value}")
                ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-r\s+\S+\s*", "")
            End If

            ' Extract and remove -s (resolution), convert to scale filter
            Dim matchS = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-s\s+(\d+)x(\d+)")
            If matchS.Success Then
                ExtraFilters.Add($"scale={matchS.Groups(1).Value}:{matchS.Groups(2).Value}")
                ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-s\s+\d+x\d+\s*", "")
            End If

            ' Extract and remove -pix_fmt (PixelFormat), convert to format filter
            Dim matchPix = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-pix_fmt\s+(\S+)")
            If matchPix.Success Then
                ExtraFilters.Add($"format={matchPix.Groups(1).Value}")
                ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-pix_fmt\s+\S+\s*", "")
            End If

            '' Extract and remove -aspect (aspect ratio), convert to setdar filter
            'Dim matchAspect = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-aspect\s+(\S+)")
            'If matchAspect.Success Then
            '    ExtraFilters.Add($"setdar={matchAspect.Groups(1).Value}")
            '    ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-aspect\s+\S+\s*", "")
            'End If

            ' Replace parameters that support stream indexing
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-c:v\s", $"-c:v:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-b:v\s", $"-b:v:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-q:v\s", $"-q:v:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-profile:v\s", $"-profile:v:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-tag:v\s", $"-tag:v:{StreamIndex} ")
        End If

        ' Merge original filters and extra filters
        Dim AllFilters As New List(Of String)
        AllFilters.AddRange(ExtraFilters)
        AllFilters.AddRange(VideoFilterParametersList)

        ' Generate filter parameters
        If AllFilters.Count > 0 Then
            result &= $"-filter:v:{StreamIndex} ""{String.Join(",", AllFilters)}"" "
        End If

        ' Add processed encoding parameters
        If ProcessedParameters.Trim() <> "" Then
            result &= ProcessedParameters.Trim() & " "
        End If

        Return result
    End Function

    ''' <summary>
    ''' Generate AudioParameters for a specific stream
    ''' Supports adding index to parameters that support stream indexing, converts unsupported parameters to filters
    ''' </summary>
    Private Shared Function GenerateAudioParametersForStream(AudioParameters As String, AudioFilterParametersList As List(Of String), StreamIndex As String) As String
        Dim result As String = ""
        Dim ExtraFilters As New List(Of String)
        Dim ProcessedParameters As String = AudioParameters

        If ProcessedParameters <> "" Then
            ' Extract and remove -ar (SampleRate), convert to aresample filter
            Dim matchAr = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-ar\s+(\S+)")
            If matchAr.Success Then
                ExtraFilters.Add($"aresample={matchAr.Groups(1).Value}")
                ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-ar\s+\S+\s*", "")
            End If

            '' Extract and remove -ac (channel count), convert to aformat filter
            'Dim matchAc = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-ac\s+(\S+)")
            'If matchAc.Success Then
            '    ExtraFilters.Add($"aformat=channel_layouts={matchAc.Groups(1).Value}")
            '    ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-ac\s+\S+\s*", "")
            'End If

            ' Extract and remove -channel_layout, convert to aformat filter
            Dim matchCh = System.Text.RegularExpressions.Regex.Match(ProcessedParameters, "-channel_layout\s+(\S+)")
            If matchCh.Success Then
                ExtraFilters.Add($"aformat=channel_layouts={matchCh.Groups(1).Value}")
                ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-channel_layout\s+\S+\s*", "")
            End If

            ' Replace parameters that support stream indexing
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-c:a\s", $"-c:a:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-b:a\s", $"-b:a:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-q:a\s", $"-q:a:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-profile:a\s", $"-profile:a:{StreamIndex} ")
            ProcessedParameters = System.Text.RegularExpressions.Regex.Replace(ProcessedParameters, "-tag:a\s", $"-tag:a:{StreamIndex} ")
        End If

        ' Merge filters
        Dim AllFilters As New List(Of String)
        AllFilters.AddRange(ExtraFilters)
        AllFilters.AddRange(AudioFilterParametersList)

        If AllFilters.Count > 0 Then
            result &= $"-filter:a:{StreamIndex} ""{String.Join(",", AllFilters)}"" "
        End If

        If ProcessedParameters.Trim() <> "" Then
            result &= ProcessedParameters.Trim() & " "
        End If

        Return result
    End Function

    ''' <summary>
    ''' Extracts the stream type index from a stream identifier (e.g., "0:v:1" returns "1", "0:v" returns "0")
    ''' </summary>
    Private Shared Function ExtractStreamTypeIndex(StreamIdentifier As String) As String
        Dim parts = StreamIdentifier.Replace(" ", "").Split(":"c)
        If parts.Length >= 3 Then
            Return parts(2)
        ElseIf parts.Length = 2 Then
            Return "0"
        End If
        Return ""
    End Function

    Shared Sub ShowParametersOverview(RTF As System.Windows.Forms.RichTextBox, a As PresetDataType)
        RTF.Clear()
        If a.CustomParams_CompletelyCustom <> "" Then
            OutputTextToRTF(RTF, "Using completely custom parameters mode. All other parameters will not take effect.", Color.IndianRed)
            Exit Sub
        End If

        If a.VideoParam_VideoFrameServer_UseAviSynth Then
            OutputTextToRTF(RTF, "Using AviSynth. Please do not copy the command line to other places directly, as the script file hasn't been generated. Run the task at least once first!", Color.RosyBrown)
            If FileIO.FileSystem.FileExists(a.VideoParam_VideoFrameServer_AvsScriptFile) Then
                OutputTextToRTF(RTF, "AviSynth Template: " & a.VideoParam_VideoFrameServer_AvsScriptFile, Color.Silver)
            Else
                OutputTextToRTF(RTF, "AviSynth template not specified!", Color.IndianRed)
            End If
        End If
        If a.VideoParam_VideoFrameServer_UseVapourSynth Then
            OutputTextToRTF(RTF, "Using VapourSynth. Please do not copy the command line directly, as the script file hasn't been generated. Run once first!", Color.RosyBrown)
            If FileIO.FileSystem.FileExists(a.VideoParam_VideoFrameServer_VpyScriptFile) Then
                OutputTextToRTF(RTF, "VapourSynth Template: " & a.VideoParam_VideoFrameServer_VpyScriptFile, Color.Silver)
            Else
                OutputTextToRTF(RTF, "VapourSynth template not specified!", Color.IndianRed)
            End If
        End If

        If a.OutputContainer <> "" Then
            OutputTextToRTF(RTF, "Output Container: " & a.OutputContainer, Color.Gray)
        Else
            OutputTextToRTF(RTF, "Output Container not specified", Color.IndianRed)
        End If
        If a.OutputNaming_UseAutoNaming And a.OutputNaming_AutoNamingOption = 0 Then
            OutputTextToRTF(RTF, "Using default timestamp suffix", Color.Gray)
        ElseIf a.OutputNaming_UseAutoNaming And a.OutputNaming_AutoNamingOption <> 0 Then
            OutputTextToRTF(RTF, "Using other auto naming rules", Color.Gray)
        ElseIf Not a.OutputNaming_UseAutoNaming Then
            OutputTextToRTF(RTF, "Warning: Auto naming not used", Color.IndianRed)
        End If
        If a.OutputNaming_DoNotUseOutputFileParams Then OutputTextToRTF(RTF, "Warning: DoNotUseOutputFileParameters enabled. Must specify via Custom Parameters.", Color.IndianRed)
        If a.OutputNaming_PrefixText <> "" Then OutputTextToRTF(RTF, "OutputFilePrefixText: " & a.OutputNaming_PrefixText, Color.Gray)
        If a.OutputNaming_ReplaceText <> "" Then OutputTextToRTF(RTF, "OutputFileReplacementText: " & a.OutputNaming_ReplaceText, Color.Gray)
        If a.OutputNaming_SuffixText <> "" Then OutputTextToRTF(RTF, "OutputFileSuffixText: " & a.OutputNaming_SuffixText, Color.Gray)

        If a.DecodingParams_Decoder <> "" Then OutputTextToRTF(RTF, "Decoder: " & a.DecodingParams_Decoder, Color.Silver)
        If a.DecodingParams_CPUThreadCount <> "" Then OutputTextToRTF(RTF, "CPU Decoding Threads: " & a.DecodingParams_CPUThreadCount, Color.Silver)
        If a.DecodingParams_OutputFormat <> "" Then OutputTextToRTF(RTF, "Decoding Data Format: " & a.DecodingParams_OutputFormat, Color.Silver)
        If a.DecodingParams_HardwareParamName <> "" Then
            If a.DecodingParams_HardwareParamValue <> "" Then
                OutputTextToRTF(RTF, "Hardware Decoding Parameters: -" & a.DecodingParams_HardwareParamName & " " & a.DecodingParams_HardwareParamValue, Color.Silver)
            Else
                OutputTextToRTF(RTF, "Hardware decoding parameters must be specified for it to work.", Color.IndianRed)
            End If
        End If

        If a.VideoParams_Encoder_Category <> "" Then OutputTextToRTF(RTF, "Video Encoding Category: " & a.VideoParams_Encoder_Category, Color.Silver)
        If a.VideoParams_Encoder_Specific <> "" Then OutputTextToRTF(RTF, "Video Encoder: " & a.VideoParams_Encoder_Specific, Color.Silver)
        If a.VideoParams_Encoder_Preset <> "" Then OutputTextToRTF(RTF, "Video Encoding Preset: " & a.VideoParams_Encoder_Preset, Color.Silver)
        If a.VideoParams_Encoder_Profile <> "" Then OutputTextToRTF(RTF, "Video Encoding Profile: " & a.VideoParams_Encoder_Profile, Color.Silver)
        If a.VideoParams_Encoder_Tune <> "" Then OutputTextToRTF(RTF, "Video Encoding Tune: " & a.VideoParams_Encoder_Tune, Color.Silver)

        '---------------- VideoSize / FrameRate ----------------
        If a.VideoParams_Resolution <> "" Then OutputTextToRTF(RTF, "Video Resolution: " & a.VideoParams_Resolution, Color.Silver)
        If a.VideoParams_ResolutionAuto_Width <> "" Then
            OutputTextToRTF(RTF, "Auto Resolution: Width = " & a.VideoParams_ResolutionAuto_Width, Color.Silver)
        End If
        If a.VideoParams_ResolutionAuto_Height <> "" Then
            OutputTextToRTF(RTF, "Auto Resolution: Height = " & a.VideoParams_ResolutionAuto_Height, Color.Silver)
        End If

        If a.VideoParams_CropFilterParams <> "" Then OutputTextToRTF(RTF, "Crop: " & a.VideoParams_CropFilterParams, Color.Silver)
        If a.VideoParams_FrameRate <> "" Then OutputTextToRTF(RTF, "Output Frame Rate: " & a.VideoParams_FrameRate, Color.Silver)
        If a.VideoParams_FrameRate_MaxChangeRatio <> "" Then OutputTextToRTF(RTF, "Max Change Ratio for Decimation: " & a.VideoParams_FrameRate_MaxChangeRatio, Color.Silver)

        '---------------- Interpolation ----------------
        If a.VideoParams_FrameInterpolation_TargetFrameRate <> "" Then OutputTextToRTF(RTF, "Target Interpolated Frame Rate: " & a.VideoParams_FrameInterpolation_TargetFrameRate, Color.Silver)
        If a.VideoParams_FrameInterpolation_Mode <> "" Then OutputTextToRTF(RTF, "Interpolation Mode: " & a.VideoParams_FrameInterpolation_Mode, Color.Silver)
        If a.VideoParams_FrameInterpolation_MotionEstimationMode <> "" Then OutputTextToRTF(RTF, "Motion Estimation Mode: " & a.VideoParams_FrameInterpolation_MotionEstimationMode, Color.Silver)
        If a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm <> "" Then OutputTextToRTF(RTF, "Motion Estimation Algorithm: " & a.VideoParams_FrameInterpolation_MotionEstimationAlgorithm, Color.Silver)
        If a.VideoParams_FrameInterpolation_MotionCompensationMode <> "" Then OutputTextToRTF(RTF, "Motion Compensation Mode: " & a.VideoParams_FrameInterpolation_MotionCompensationMode, Color.Silver)
        If a.VideoParams_FrameInterpolation_VariableBlockSizeMotionCompensation Then OutputTextToRTF(RTF, "Interpolation: Variable block size motion compensation enabled", Color.Silver)
        If a.VideoParams_FrameInterpolation_BlockSize <> "" Then OutputTextToRTF(RTF, "Interpolation Block Size: " & a.VideoParams_FrameInterpolation_BlockSize, Color.Silver)
        If a.VideoParams_FrameInterpolation_SearchRange <> "" Then OutputTextToRTF(RTF, "Interpolation Search Range: " & a.VideoParams_FrameInterpolation_SearchRange, Color.Silver)
        If a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength <> "" Then OutputTextToRTF(RTF, "Scene Change Detection Strength: " & a.VideoParams_FrameInterpolation_SceneChangeDetectionStrength, Color.Silver)

        '---------------- Frame Blending ----------------
        If a.VideoParams_FrameBlending_TargetFrameRate <> "" Then OutputTextToRTF(RTF, "Frame Blending Target Frame Rate: " & a.VideoParams_FrameBlending_TargetFrameRate, Color.Silver)
        If a.VideoParams_FrameBlending_BlendMode <> "" Then OutputTextToRTF(RTF, "Frame Blending Mode: " & a.VideoParams_FrameBlending_BlendMode, Color.Silver)
        If a.VideoParams_FrameBlending_BlendRatio <> "" Then OutputTextToRTF(RTF, "Frame Blending Ratio: " & a.VideoParams_FrameBlending_BlendRatio, Color.Silver)

        '---------------- Super Resolution ----------------
        If a.VideoParams_SuperResolution_TargetWidth <> "" Then OutputTextToRTF(RTF, $"Super Resolution Target: {a.VideoParams_SuperResolution_TargetWidth} x {a.VideoParams_SuperResolution_TargetHeight}", Color.Silver)
        If a.VideoParams_SuperResolution_UpsamplingAlgorithm <> "" Then OutputTextToRTF(RTF, $"Super Resolution Upsampling Algorithm: {a.VideoParams_SuperResolution_UpsamplingAlgorithm}", Color.Silver)
        If a.VideoParams_SuperResolution_DownsamplingAlgorithm <> "" Then OutputTextToRTF(RTF, $"Super Resolution Downsampling Algorithm: {a.VideoParams_SuperResolution_DownsamplingAlgorithm}", Color.Silver)
        If a.VideoParams_SuperResolution_AntiRingingStrength <> "" Then OutputTextToRTF(RTF, $"Super Resolution Anti-ringing Strength: {a.VideoParams_SuperResolution_AntiRingingStrength}", Color.Silver)
        If a.VideoParams_SuperResolution_ShaderList.Count > 0 Then OutputTextToRTF(RTF, $"Super Resolution using {a.VideoParams_SuperResolution_ShaderList.Count} custom shaders", Color.Silver)

        '---------------- Burn Subtitles ----------------
        If a.VideoParams_BurnSubtitles_FilterSelection <> "" Then
            Dim abc As New List(Of String) From {$"Filter: {a.VideoParams_BurnSubtitles_FilterSelection}"}
            If a.VideoParams_BurnSubtitles_UseExternalFile Then abc.Add($"Source: External File")
            If a.VideoParams_BurnSubtitles_UseEmbeddedStream Then abc.Add($"Source: Embedded Stream")
            If a.VideoParams_BurnSubtitles_ExternalSubtitleFileName = "" Then
                abc.Add($"External subtitle same name as input")
            Else
                abc.Add($"External subtitle name: {a.VideoParams_BurnSubtitles_ExternalSubtitleFileName}")
            End If
            If a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation = "" Then
                abc.Add($"External subtitle same folder as input")
            Else
                abc.Add($"External subtitle folder: {a.VideoParams_BurnSubtitles_ExternalSubtitleFolderLocation}")
            End If
            If a.VideoParams_BurnSubtitles_SpecifiedEmbeddedStream <> "" Then abc.Add($"Embedded stream index: {a.VideoParams_BurnSubtitles_SpecifiedEmbeddedStream}")
            If a.VideoParams_BurnSubtitles_FontFolder <> "" Then abc.Add($"Font Folder: {a.VideoParams_BurnSubtitles_FontFolder}")
            If a.VideoParams_BurnSubtitles_BasicStyle_Name <> "" Then
                abc.Add($"Font: {a.VideoParams_BurnSubtitles_BasicStyle_Name}")
                abc.Add($"Size: {a.VideoParams_BurnSubtitles_BasicStyle_Size}")
                If a.VideoParams_BurnSubtitles_BasicStyle_Bold Then abc.Add($"Bold")
                If a.VideoParams_BurnSubtitles_BasicStyle_Italic Then abc.Add($"Italic")
                If a.VideoParams_BurnSubtitles_BasicStyle_Underline Then abc.Add($"Underline")
                If a.VideoParams_BurnSubtitles_BasicStyle_Strikeout Then abc.Add($"Strikeout")
            End If
            Select Case a.VideoParams_BurnSubtitles_BorderStyle
                Case 1 : abc.Add($"Border Style: Outline + Shadow")
                Case 2 : abc.Add($"Border Style: Background Box")
            End Select
            If a.VideoParams_BurnSubtitles_OutlineWidth <> "" Then abc.Add($"Outline Width: {a.VideoParams_BurnSubtitles_OutlineWidth}")
            If a.VideoParams_BurnSubtitles_ShadowDistance <> "" Then abc.Add($"Shadow Distance: {a.VideoParams_BurnSubtitles_ShadowDistance}")
            If a.VideoParams_BurnSubtitles_PrimaryColor <> Color.Transparent Then abc.Add($"Primary Color: {ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_PrimaryColor.ToHTML, a.VideoParams_BurnSubtitles_PrimaryColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_SecondaryColor <> Color.Transparent Then abc.Add($"Secondary Color: {ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_SecondaryColor.ToHTML, a.VideoParams_BurnSubtitles_SecondaryColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_OutlineColor <> Color.Transparent Then abc.Add($"Outline Color: {ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_OutlineColor.ToHTML, a.VideoParams_BurnSubtitles_OutlineColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_BackgroundColor <> Color.Transparent Then abc.Add($"Background Color: {ConvertHTMLColorToFFmpegFormat(a.VideoParams_BurnSubtitles_BackgroundColor.ToHTML, a.VideoParams_BurnSubtitles_BackgroundColor_Alpha)}")
            If a.VideoParams_BurnSubtitles_Alignment > 0 Then abc.Add($"Alignment Pattern: {a.VideoParams_BurnSubtitles_Alignment}")
            If a.VideoParams_BurnSubtitles_VerticalMargin <> "" Then abc.Add($"Vertical Margin: {a.VideoParams_BurnSubtitles_VerticalMargin}")
            If a.VideoParams_BurnSubtitles_LeftMargin <> "" Then abc.Add($"Left Margin: {a.VideoParams_BurnSubtitles_LeftMargin}")
            If a.VideoParams_BurnSubtitles_RightMargin <> "" Then abc.Add($"Right Margin: {a.VideoParams_BurnSubtitles_RightMargin}")
            If a.VideoParams_BurnSubtitles_Spacing <> "" Then abc.Add($"Character Spacing: {a.VideoParams_BurnSubtitles_Spacing}")
            If a.VideoParams_BurnSubtitles_LineSpacing <> "" Then abc.Add($"Line Spacing: {a.VideoParams_BurnSubtitles_LineSpacing}")
            If a.VideoParams_BurnSubtitles_CustomStyle <> "" Then abc.Add($"Custom Style: {a.VideoParams_BurnSubtitles_CustomStyle}")
            If a.VideoParams_BurnSubtitles_CustomFilterParams <> "" Then abc.Add($"Custom Filter Params: {a.VideoParams_BurnSubtitles_CustomFilterParams}")
            OutputTextToRTF(RTF, $"Burn Subtitles: {String.Join("; ", abc)}", Color.Gray)
        End If

        '---------------- Bitrate / Quality Control ----------------
        If a.VideoParams_Bitrate_ControlMethod <> "" Then
            Select Case a.VideoParams_Bitrate_ControlMethod
                Case "CRF" : OutputTextToRTF(RTF, "Bitrate Control Method: CRF", Color.Silver)
                Case "VBR" : OutputTextToRTF(RTF, "Bitrate Control Method: VBR", Color.Silver)
                Case "VBR HQ" : OutputTextToRTF(RTF, "Bitrate Control Method: VBR HQ", Color.Silver)
                Case "CQP" : OutputTextToRTF(RTF, "Bitrate Control Method: CQP", Color.Silver)
                Case "CBR" : OutputTextToRTF(RTF, "Bitrate Control Method: CBR", Color.Silver)
            End Select
        End If
        If a.VideoParams_QualityControl_ParamName <> "" Then
            If a.VideoParams_QualityControl_Value <> "" Then
                OutputTextToRTF(RTF, "Quality Control Parameters: " & a.VideoParams_QualityControl_ParamName & " = " & a.VideoParams_QualityControl_Value, Color.Silver)
            Else
                OutputTextToRTF(RTF, "Quality control parameter name selected but no value provided!", Color.IndianRed)
            End If
        End If
        If a.VideoParams_Bitrate_Base <> "" Then OutputTextToRTF(RTF, "Base Bitrate: " & a.VideoParams_Bitrate_Base, Color.Silver)
        If a.VideoParams_Bitrate_MinValue <> "" Then OutputTextToRTF(RTF, "Min Bitrate: " & a.VideoParams_Bitrate_MinValue, Color.Silver)
        If a.VideoParams_Bitrate_MaxValue <> "" Then OutputTextToRTF(RTF, "Max Bitrate: " & a.VideoParams_Bitrate_MaxValue, Color.Silver)
        If a.VideoParams_Bitrate_BufferSize <> "" Then OutputTextToRTF(RTF, "Buffer Size: " & a.VideoParams_Bitrate_BufferSize, Color.Silver)
        If a.VideoParams_QualityControl_AdvancedParamsList IsNot Nothing AndAlso a.VideoParams_QualityControl_AdvancedParamsList.Count > 0 Then
            OutputTextToRTF(RTF, "Advanced Quality Control: " & String.Join(" ", a.VideoParams_QualityControl_AdvancedParamsList), Color.Silver)
        End If

        '---------------- ColorManagement ----------------
        If a.VideoParams_ColorManagement_PixelFormat <> "" Then OutputTextToRTF(RTF, "PixelFormat: " & a.VideoParams_ColorManagement_PixelFormat, Color.Silver)

        If a.VideoParams_ColorManagement_FilterSelection <> "" Then OutputTextToRTF(RTF, "Color Conversion Filter: " & a.VideoParams_ColorManagement_FilterSelection, Color.Silver)
        If a.VideoParams_ColorManagement_MatrixCoefficients <> "" Then OutputTextToRTF(RTF, "Matrix Coefficients & Color Format: " & a.VideoParams_ColorManagement_MatrixCoefficients, Color.Silver)
        If a.VideoParams_ColorManagement_ColorGamut <> "" Then OutputTextToRTF(RTF, "Color Gamut: " & a.VideoParams_ColorManagement_ColorGamut, Color.Silver)
        If a.VideoParams_ColorManagement_TransferCharacteristics <> "" Then OutputTextToRTF(RTF, "Transfer Characteristics: " & a.VideoParams_ColorManagement_TransferCharacteristics, Color.Silver)
        If a.VideoParams_ColorManagement_Range <> "" Then OutputTextToRTF(RTF, "Color Range: " & a.VideoParams_ColorManagement_Range, Color.Silver)
        If a.VideoParams_ColorManagement_ToneMappingAlgorithm <> "" Then OutputTextToRTF(RTF, "Tone Mapping Algorithm: " & a.VideoParams_ColorManagement_ToneMappingAlgorithm, Color.Silver)
        Select Case a.VideoParams_ColorManagement_ProcessingMethod
            Case 1 : OutputTextToRTF(RTF, "Color Management: Write to metadata and convert", Color.Silver)
            Case 2 : OutputTextToRTF(RTF, "Color Management: Write to metadata only, do not convert", Color.Silver)
            Case 3 : OutputTextToRTF(RTF, "Color Management: Convert only, do not write metadata", Color.Silver)
        End Select

        If a.VideoParams_ColorManagement_Brightness <> "" Then OutputTextToRTF(RTF, "Brightness Adjustment: " & a.VideoParams_ColorManagement_Brightness, Color.Silver)
        If a.VideoParams_ColorManagement_Contrast <> "" Then OutputTextToRTF(RTF, "Contrast Adjustment: " & a.VideoParams_ColorManagement_Contrast, Color.Silver)
        If a.VideoParams_ColorManagement_Saturation <> "" Then OutputTextToRTF(RTF, "Saturation Adjustment: " & a.VideoParams_ColorManagement_Saturation, Color.Silver)
        If a.VideoParams_ColorManagement_Gamma <> "" Then OutputTextToRTF(RTF, "Gamma Adjustment: " & a.VideoParams_ColorManagement_Gamma, Color.Silver)

        '---------------- CommonFilters ----------------
        If a.VideoParams_Denoise_Method <> "" Then OutputTextToRTF(RTF, "Denoise Method: " & a.VideoParams_Denoise_Method, Color.Silver)
        If a.VideoParams_Denoise_Param1 <> "" Then OutputTextToRTF(RTF, "Denoise Params 1: " & a.VideoParams_Denoise_Param1, Color.Silver)
        If a.VideoParams_Denoise_Param2 <> "" Then OutputTextToRTF(RTF, "Denoise Params 2: " & a.VideoParams_Denoise_Param2, Color.Silver)
        If a.VideoParams_Denoise_Param3 <> "" Then OutputTextToRTF(RTF, "Denoise Params 3: " & a.VideoParams_Denoise_Param3, Color.Silver)
        If a.VideoParams_Denoise_Param4 <> "" Then OutputTextToRTF(RTF, "Denoise Params 4: " & a.VideoParams_Denoise_Param4, Color.Silver)
        If a.VideoParams_Sharpen_HorizontalSize <> "" OrElse a.VideoParams_Sharpen_VerticalSize <> "" OrElse a.VideoParams_Sharpen_Strength <> "" Then
            OutputTextToRTF(RTF, "Sharpen: Horizontal = " & a.VideoParams_Sharpen_HorizontalSize & " Vertical = " & a.VideoParams_Sharpen_VerticalSize & " Strength = " & a.VideoParams_Sharpen_Strength, Color.Silver)
        End If
        If a.VideoParams_ProgressiveInterlaced > 0 Then OutputTextToRTF(RTF, "Deinterlacing selected, Option Index: " & a.VideoParams_ProgressiveInterlaced, Color.Silver)
        If a.VideoParams_Flip_AngleRotation > 0 Then OutputTextToRTF(RTF, "Angle Flip selected, Option Index: " & a.VideoParams_Flip_AngleRotation, Color.Silver)
        If a.VideoParams_Flip_MirrorFlip > 0 Then OutputTextToRTF(RTF, "Mirror Flip selected, Option Index: " & a.VideoParams_Flip_MirrorFlip, Color.Silver)

        '---------------- AudioParameters ----------------
        If a.AudioParams_Encoder_Specific <> "" Then OutputTextToRTF(RTF, "Audio Encoder: " & a.AudioParams_Encoder_Specific, Color.Silver)
        If a.AudioParams_Bitrate <> "" Then OutputTextToRTF(RTF, "Audio Bitrate: " & a.AudioParams_Bitrate, Color.Silver)
        If a.AudioParams_QualityParamName <> "" Then OutputTextToRTF(RTF, "Audio Quality Control: " & a.AudioParams_QualityParamName & "=" & a.AudioParams_QualityValue, Color.Silver)
        If a.AudioParams_ChannelCount <> "" Then OutputTextToRTF(RTF, "Channel Layout: " & a.AudioParams_ChannelCount, Color.Silver)
        If a.AudioParams_SampleRate <> "" Then OutputTextToRTF(RTF, "SampleRate: " & a.AudioParams_SampleRate, Color.Silver)
        If a.AudioParams_LoudnessNormalization_TargetLoudness <> "" Then OutputTextToRTF(RTF, "Loudness Normalization Target: " & a.AudioParams_LoudnessNormalization_TargetLoudness, Color.Silver)
        If a.AudioParams_LoudnessNormalization_DynamicRange <> "" Then OutputTextToRTF(RTF, "Loudness Dynamic Range: " & a.AudioParams_LoudnessNormalization_DynamicRange, Color.Silver)
        If a.AudioParams_LoudnessNormalization_PeakLevel <> "" Then OutputTextToRTF(RTF, "Loudness Peak Level: " & a.AudioParams_LoudnessNormalization_PeakLevel, Color.Silver)

        '---------------- ImageParameters ----------------
        If a.ImageParams_Encoder_EncoderName <> "" Then OutputTextToRTF(RTF, "Image Encoder: " & a.ImageParams_Encoder_EncoderName, Color.Silver)
        If a.ImageParams_Encoder_QualityValue <> "" Then OutputTextToRTF(RTF, "Image Quality: " & a.ImageParams_Encoder_QualityValue, Color.Silver)

        '---------------- CustomParameters ----------------
        If a.CustomParams_StartParams <> "" Then OutputTextToRTF(RTF, "Custom Start Parameters: " & a.CustomParams_StartParams, Color.Gray)
        If a.CustomParams_BeforeParams <> "" Then OutputTextToRTF(RTF, "Custom Before Parameters: " & a.CustomParams_BeforeParams, Color.Gray)
        If a.CustomParams_VideoFilter <> "" Then OutputTextToRTF(RTF, "Custom Video Filter: " & a.CustomParams_VideoFilter, Color.Gray)
        If a.CustomParams_AudioFilter <> "" Then OutputTextToRTF(RTF, "Custom Audio Filter: " & a.CustomParams_AudioFilter, Color.Gray)
        If a.CustomParams_FilterComplex <> "" Then OutputTextToRTF(RTF, "Custom filter_complex: " & a.CustomParams_FilterComplex, Color.Gray)
        If a.CustomParams_VideoParams <> "" Then OutputTextToRTF(RTF, "Custom Video Parameters: " & a.CustomParams_VideoParams, Color.Gray)
        If a.CustomParams_AudioParams <> "" Then OutputTextToRTF(RTF, "Custom Audio Parameters: " & a.CustomParams_AudioParams, Color.Gray)
        If a.CustomParams_AfterParams <> "" Then OutputTextToRTF(RTF, "Custom After Parameters: " & a.CustomParams_AfterParams, Color.Gray)
        If a.CustomParams_EndParams <> "" Then OutputTextToRTF(RTF, "Custom Final Parameters: " & a.CustomParams_EndParams, Color.Gray)

        '---------------- Clip Range ----------------
        Select Case a.ClipRange_Method
            Case 1 : OutputTextToRTF(RTF, "Clip Method: Rough Cut (Fast Response)", Color.Silver)
            Case 2 : OutputTextToRTF(RTF, "Clip Method: Precise Cut (Full Decoding)", Color.Silver)
            Case 3 : OutputTextToRTF(RTF, "Clip Method: Precise Cut (Fast Response)", Color.Silver)
            Case 4 : OutputTextToRTF(RTF, "Clip Method: Trim Filter", Color.Silver)
            Case Else : If a.ClipRange_InPoint <> "" OrElse a.ClipRange_OutPoint <> "" Then OutputTextToRTF(RTF, "Warning: Clip range specified but no clip method chosen. No clipping will occur.", Color.IndianRed)
        End Select
        If a.ClipRange_InPoint <> "" Then OutputTextToRTF(RTF, "Clip In Point: " & a.ClipRange_InPoint, Color.Silver)
        If a.ClipRange_OutPoint <> "" Then OutputTextToRTF(RTF, "Clip Out Point: " & a.ClipRange_OutPoint, Color.Silver)
        If a.ClipRange_PreDecodeSeconds <> "" Then OutputTextToRTF(RTF, "Precise cut fast response forward decoding " & a.ClipRange_PreDecodeSeconds & " seconds", Color.Silver)

        '---------------- StreamControl ----------------
        If a.StreamControl_ApplyVideoParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplyVideoParamsToStreams.Length > 0 Then
            OutputTextToRTF(RTF, "Apply Video Parameters to Streams: " & String.Join(",", a.StreamControl_ApplyVideoParamsToStreams), Color.Silver)
        End If
        If a.StreamControl_PreserveOtherVideoStreams Then OutputTextToRTF(RTF, "Selected: Preserve other Video streams", Color.Silver)

        If a.StreamControl_ApplyAudioParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplyAudioParamsToStreams.Length > 0 Then
            OutputTextToRTF(RTF, "Apply Audio Parameters to Streams: " & String.Join(",", a.StreamControl_ApplyAudioParamsToStreams), Color.Silver)
        End If
        If a.StreamControl_PreserveOtherAudioStreams Then OutputTextToRTF(RTF, "Selected: Preserve other Audio streams", Color.Silver)

        If a.StreamControl_ApplySubtitleParamsToStreams IsNot Nothing AndAlso a.StreamControl_ApplySubtitleParamsToStreams.Length > 0 Then
            OutputTextToRTF(RTF, "Use subtitles from these files: " & String.Join(",", a.StreamControl_ApplySubtitleParamsToStreams), Color.Silver)
            Select Case a.StreamControl_SubtitleOperation
                Case 1 : OutputTextToRTF(RTF, "Subtitle Action: Copy Stream", Color.Silver)
                Case 2 : OutputTextToRTF(RTF, "Subtitle Action: Convert to mov_text encoding", Color.Silver)
                Case 3 : OutputTextToRTF(RTF, "Subtitle Action: Convert to srt encoding", Color.Silver)
                Case 4 : OutputTextToRTF(RTF, "Subtitle Action: Convert to ass encoding", Color.Silver)
                Case 5 : OutputTextToRTF(RTF, "Subtitle Action: Convert to ssa encoding", Color.Silver)
            End Select
        End If
        If a.StreamControl_PreserveOtherSubtitleStreams Then OutputTextToRTF(RTF, "Selected: Preserve other subtitle streams", Color.Silver)

        If a.StreamControl_AutoMuxSRT Then OutputTextToRTF(RTF, "Auto-muxing SRT subtitle files with the same name", Color.Silver)
        If a.StreamControl_AutoMuxASS Then OutputTextToRTF(RTF, "Auto-muxing ASS subtitle files with the same name", Color.Silver)
        If a.StreamControl_AutoMuxSSA Then OutputTextToRTF(RTF, "Auto-muxing SSA subtitle files with the same name", Color.Silver)
        Select Case a.StreamControl_MetadataOption
            Case 1 : OutputTextToRTF(RTF, "Preserve Metadata", Color.Silver)
            Case 2 : OutputTextToRTF(RTF, "Clear Metadata", Color.Silver)
            Case 3 : OutputTextToRTF(RTF, "Clear More Metadata", Color.Silver)
        End Select
        Select Case a.StreamControl_ChapterOption
            Case 1 : OutputTextToRTF(RTF, "Preserve Chapters", Color.Silver)
            Case 2 : OutputTextToRTF(RTF, "Clear Chapters", Color.Silver)
        End Select
        If a.StreamControl_AttachmentOption = 1 Then OutputTextToRTF(RTF, "PreserveAttachment", Color.Silver)

        '---------------- Other ----------------
        If a.OutputLocation <> "" Then
            OutputTextToRTF(RTF, "Output Location: " & a.OutputLocation, Color.Gray)
        Else
            OutputTextToRTF(RTF, "Output to source file directory", Color.Gray)
        End If
    End Sub
End Class



















