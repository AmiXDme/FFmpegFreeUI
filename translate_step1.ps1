$ErrorActionPreference = "Stop"

$files = @(
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\Utilities\StartupArgsHandler.vb",
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\EncodingTasks\PresetManager.vb",
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\UIControl\UIControl.vb",
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\UIControl\UIControl_AddFile.vb",
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\UI\BindingHintPanel.vb",
    "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI\UserSettings.vb"
)

$replacements = @{}

# Key mappings
$replacements["快速Clip入点"] = "QuickClipInPoint"
$replacements["快速Clip出点"] = "QuickClipOutPoint"
$replacements["Preserve创建时间"] = "PreserveCreationTime"
$replacements["Preserve修改时间"] = "PreserveModificationTime"
$replacements["Preserve访问时间"] = "PreserveAccessTime"
$replacements["色彩空间FilterSelect"] = "ColorSpaceFilterSelect"
$replacements["矩阵系数"] = "MatrixCoefficients"
$replacements["色域"] = "ColorPrimaries"
$replacements["传输特性"] = "TransferCharacteristics"
$replacements["色彩范围"] = "ColorRange"
$replacements["色调映射算法"] = "ToneMappingAlgorithm"
$replacements["目标调色亮度"] = "ToneMappingBrightness"
$replacements["目标调色对比度"] = "ToneMappingContrast"
$replacements["开头Parameters"] = "StartParameters"
$replacements["之前Parameters"] = "BeforeInputParameters"
$replacements["之后Parameters"] = "AfterInputParameters"
$replacements["最后Parameters"] = "FinalParameters"
$replacements["完整视频流参Parameters"] = "CompleteVideoStreamParameters"
$replacements["Clip方法"] = "ClipMethod"
$replacements["Metadata选项"] = "MetadataOption"
$replacements["Chapter选项"] = "ChapterOption"
$replacements["Attachment选项"] = "AttachmentOption"
$replacements["额外Save信息"] = "ExtraSaveInfo"
$replacements["To补到多帧率"] = "TargetFrameRate"
$replacements["运动补偿算法"] = "InterpolationMethod"
$replacements["撕裂范围"] = "SceneBlendRange"
$replacements["机器变化强度Strength"] = "MotionCompensationStrength"
$replacements["上采样算法"] = "UpsamplingAlgorithm"
$replacements["下采样算法"] = "DownsamplingAlgorithm"
$replacements["抗振铃Strength"] = "AntiRingingStrength"
$replacements["优先Select"] = "PrioritySelect"
$replacements["字幕Source指定Folder"] = "SubtitleSourceFolder"
$replacements["字幕FileYesEmbedded的Stream"] = "SubtitleFileUseEmbeddedStream"
$replacements["描边Width"] = "BorderWidth"
$replacements["阴影距离"] = "ShadowDistance"
$replacements["SelectExternal字幕File位置"] = "SelectExternalSubtitleFile"
$replacements["Auto开始最大任务数量"] = "AutoStartMaxTaskCount"
$replacements["有任务时系统Status"] = "NoTaskSystemStatus"
$replacements["Tooltip音"] = "TooltipVolume"
$replacements["修正_tabPageText增加差异空格"] = "Settings_TabPageTextStyle"
$replacements["修正_增加缩略Size"] = "Settings_ThumbnailSize"
$replacements["修正_List视Image项Height"] = "Settings_ListViewImageHeight"
$replacements["修正_编码Queue列宽调整选择"] = "Settings_EncoderQueueAlignment"
$replacements["外部器名称"] = "AlternativeProcessName"
$replacements["独立ParametersPanelAutoSwitch页面"] = "ParametersPanelAutoSwitchPage"
$replacements["替代Process的File名"] = "ReplaceProcessFileName"
$replacements["参与UserStatistics"] = "ParticipateUserStatistics"
$replacements["二级tabPage"] = "SecondaryTabPage"

foreach ($file in $files) {
    if (Test-Path $file) {
        Write-Host "Processing: $file"
        $content = [System.IO.File]::ReadAllText($file)
        foreach ($key in $replacements.Keys) {
            if ($content.Contains($key)) {
                Write-Host "  Replacing: $key -> $($replacements[$key])"
                $content = $content.Replace($key, $replacements[$key])
            }
        }
        [System.IO.File]::WriteAllText($file, $content)
    }
}

Write-Host "Done!"
