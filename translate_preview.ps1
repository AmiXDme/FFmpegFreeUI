# FFmpegFreeUI Systematic Translation Script
# This script translates all Chinese identifiers to English

$ErrorActionPreference = "Continue"

# Comprehensive mapping dictionary - Chinese to English
$translations = @{
    # PresetDataType properties
    "输出容器" = "OutputContainer"  
    "输出命名_使用自动命名" = "OutputNaming_UseAutoNaming"
    "输出命名_自动命名选项" = "OutputNaming_AutoNamingOption"
    "输出命名_不使用OutputFileParameters" = "OutputNaming_DoNotUseOutputFileParams"
    "输出命名_开头Text" = "OutputNaming_PrefixText"
    "输出命名_替代Text" = "OutputNaming_ReplaceText"
    "输出命名_结尾Text" = "OutputNaming_SuffixText"
    "输出命名_保留创建时间" = "OutputNaming_PreserveCreationTime"
    "输出命名_保留修改时间" = "OutputNaming_PreserveModificationTime"
    "输出命名_保留访问时间" = "OutputNaming_PreserveAccessTime"
    
    "解码Parameters_解码器" = "DecodingParams_Decoder"
    "解码Parameters_CPU解码线程数" = "DecodingParams_CPUThreadCount"
    "解码Parameters_解码数据格式" = "DecodingParams_OutputFormat"
    "解码Parameters_指定硬件的Parameters名" = "DecodingParams_HardwareParamName"
    "解码Parameters_指定硬件的Parameters" = "DecodingParams_HardwareParamValue"
    
    "视频Parameters_编码器_类别" = "VideoParams_Encoder_Category"
    "视频Parameters_编码器_具体编码" = "VideoParams_Encoder_Specific"
    "视频Parameters_编码器_编码预设" = "VideoParams_Encoder_Preset"
    "视频Parameters_编码器_配置File" = "VideoParams_Encoder_Profile"
    "视频Parameters_编码器_场景优化" = "VideoParams_Encoder_Tune"
    "视频Parameters_编码器_gpu" = "VideoParams_Encoder_GPU"
    "视频Parameters_编码器_threads" = "VideoParams_Encoder_Threads"
    
    "视频Parameters_分辨率" = "VideoParams_Resolution"
    "视频Parameters_分辨率自动计算_Width" = "VideoParams_ResolutionAuto_Width"
    "视频Parameters_分辨率自动计算_Height" = "VideoParams_ResolutionAuto_Height"
    "视频Parameters_分辨率_裁剪滤镜Parameters" ="VideoParams_CropFilterParams"
    "视频Parameters_帧速率" = "VideoParams_FrameRate"
    "视频Parameters_帧速率_抽帧最大变化Ratio" = "VideoParams_FrameRate_MaxChangeRatio"
    
    # Clipping
    "剪辑区间_方法" = "ClipRange_Method"
    "剪辑区间_入点" = "ClipRange_InPoint"
    "剪辑区间_出点" = "ClipRange_OutPoint"
    "剪辑区间_向前解码多久秒" = "ClipRange_PreDecodeSeconds"
    
    # Stream Control
    "流控制_启用保留其他视频流" = "StreamControl_PreserveOtherVideoStreams"
    "流控制_将视频Parameters应用于指定流" = "StreamControl_ApplyVideoParamsToStreams"
    "流控制_启用保留其他音频流" = "StreamControl_PreserveOtherAudioStreams"
    "流控制_将音频Parameters应用于指定流" = "StreamControl_ApplyAudioParamsToStreams"
    "流控制_将字幕Parameters应用于指定流" = "StreamControl_ApplySubtitleParamsToStreams"
    "流控制_如何操作指定的字幕" = "StreamControl_SubtitleOperation"
    "流控制_启用保留其他字幕流" = "StreamControl_PreserveOtherSubtitleStreams"
    "流控制_自动混流SRT" = "StreamControl_AutoMuxSRT"
    "流控制_自动混流ASS" = "StreamControl_AutoMuxASS"
    "流控制_自动混流SSA" = "StreamControl_AutoMuxSSA"
    "流控制_自动混流的字幕转为MOVTEXT" = "StreamControl_ConvertSubtitlesToMovtext"
    "流控制_元数据选项" = "StreamControl_MetadataOption"
    "流控制_章节选项" = "StreamControl_ChapterOption"
    "流控制_附件选项" = "StreamControl_AttachmentOption"
    
    # Video Frame Server
    "视频Parameters_视频帧服务器_使用AviSynth" = "VideoParam_VideoFrameServer_UseAviSynth"
    "视频Parameters_视频帧服务器_avs脚本File" = "VideoParam_VideoFrameServer_AvsScriptFile"
    "视频Parameters_视频帧服务器_使用VapourSynth" = "VideoParam_VideoFrameServer_UseVapourSynth"
    "视频Parameters_视频帧服务器_vpy脚本File" = "VideoParam_VideoFrameServer_VpyScriptFile"
    
    # Other  
    "计算机Name" = "MachineName"
    "输出位置" = "OutputLocation"
}

Write-Host "FFmpegFreeUI Translation Script" -ForegroundColor Cyan
Write-Host "This is a preview - full implementation would require careful testing" -ForegroundColor Yellow
Write-Host ""
Write-Host "Total translations mapped: $($translations.Count)" -ForegroundColor Green
Write-Host ""
Write-Host "Sample translations:" -ForegroundColor Cyan
$translations.GetEnumerator() | Select-Object -First 10 | ForEach-Object {
    Write-Host "  $($_.Key) -> $($_.Value)"
}
