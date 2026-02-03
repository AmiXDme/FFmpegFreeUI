# Bulk Translation Script for FFmpegFreeUI
# This script replaces Chinese variable names with English equivalents

$projectPath = "c:\Users\AmiXDme\Desktop\FFmpegFreeUI\FFmpegFreeUI"

# Define all the replacement mappings
$replacements = @{
    # GeneralParametersPage controls - using actual Chinese characters
    '快速Clip入点' = 'ClipInPoint'
    '快速Clip出点' = 'ClipOutPoint'
    'Preserve创建时间' = 'PreserveCreationTime'
    'Preserve修改时间' = 'PreserveModificationTime'
    'Preserve访问时间' = 'PreserveAccessTime'
    '色彩空间FilterSelect' = 'ColorSpaceFilterSelect'
    '矩阵系数' = 'MatrixCoefficients'
    '色域' = 'ColorPrimaries'
    '传输特性' = 'TransferCharacteristics'
    '色彩范围' = 'ColorRange'
    '色调映射算法' = 'ToneMappingAlgorithm'
    '目标调色亮度' = 'ToneMappingTargetBrightness'
    '目标调色对比度' = 'ToneMappingContrastRatio'
    '开头Parameters' = 'StartParameters'
    '之前Parameters' = 'BeforeInputParameters'
    '之后Parameters' = 'AfterInputParameters'
    '最后Parameters' = 'FinalParameters'
    '完整视频流参Parameters' = 'CompleteVideoStreamParameters'
    'Clip方法' = 'ClipMethod'
    'Metadata选项' = 'MetadataOption'
    'Chapter选项' = 'ChapterOption'
    'Attachment选项' = 'AttachmentOption'
    '额外Save信息' = 'ExtraSaveInfo'
    
    # FormFrameInterpolation controls
    'To补到多帧率' = 'TargetFrameRate'
    '运动补偿算法' = 'InterpolationMethod'
    '撕裂范围' = 'SceneBlendRange'
    '机器变化强度Strength' = 'MotionCompensationStrength'
    
    # FormSuperResolution controls
    '上采样算法' = 'UpsamplingAlgorithm'
    '下采样算法' = 'DownsamplingAlgorithm'
    '抗振铃Strength' = 'AntiRingingStrength'
    
    # FormBurnSubtitles controls
    '优先Select' = 'PrioritySelect'
    '字幕Source指定Folder' = 'SubtitleSourceFolder'
    '字幕FileYesEmbedded的Stream' = 'SubtitleFileUseEmbeddedStream'
    '描边Width' = 'BorderWidth'
    '阴影距离' = 'ShadowDistance'
    'SelectExternal字幕File位置' = 'SelectExternalSubtitleFile'
    
    # SettingsPage controls
    'Auto开始最大任务数量' = 'AutoStartMaxTaskCount'
    '有任务时系统Status' = 'NoTaskSystemStatus'
    'Tooltip音' = 'TooltipVolume'
    '修正_tabPageText增加差异空格' = 'Settings_TabPageTextStyle'
    '修正_增加缩略Size' = 'Settings_ThumbnailSize'
    '修正_List视Image项Height' = 'Settings_ListViewImageHeight'
    '修正_编码Queue列宽调整选择' = 'Settings_EncoderQueueAlignment'
    '外部器名称' = 'AlternativeProcessName'
    '独立ParametersPanelAutoSwitch页面' = 'ParametersPanelAutoSwitchPage'
    '替代Process的File名' = 'ReplaceProcessFileName'
    '参与UserStatistics' = 'ParticipateUserStatistics'
    
    # UIControl controls
    '二级tabPage' = 'SecondaryTabPage'
    
    # Other controls with Chinese
    '尝Auto混Stream的SRT字幕' = 'AutoMuxSRTSubtitles'
    '尝Auto混Stream的ASS字幕' = 'AutoMuxASSSubtitles'
    '尝Auto混Stream的SSA字幕' = 'AutoMuxSSASubtitles'
    'Auto混Stream字幕Unit数' = 'AutoMuxSubtitleUnitCount'
    'VideoFilterParameters链' = 'VideoFilterParametersList'
    'AudioFilterParameters链' = 'AudioFilterParametersList'
    'InputFile的Folder' = 'InputFileFolder'
    
    # PerformancePage controls
    '虚拟Memory' = 'VirtualMemory'
    '物理Memory' = 'PhysicalMemory'
    '功耗' = 'Power'
    '额载软速' = 'EncodingSpeed'
    '温度' = 'Temperature'
    '显存' = 'Display'
    'PCIE带宽' = 'PCIEBandwidth'
    '编码核心' = 'EncodingCore'
    'Decoding核心' = 'DecodingCore'
}

# Get all VB files
$files = Get-ChildItem -Path $projectPath -Filter "*.vb" -Recurse

foreach ($file in $files) {
    $content = Get-Content -Path $file.FullName -Raw -Encoding UTF8
    $originalContent = $content
    $modified = $false
    
    foreach ($key in $replacements.Keys) {
        if ($content -match [regex]::Escape($key)) {
            $content = $content -replace [regex]::Escape($key), $replacements[$key]
            $modified = $true
        }
    }
    
    if ($modified) {
        Set-Content -Path $file.FullName -Value $content -Encoding UTF8 -NoNewline
        Write-Host "Modified: $($file.Name)"
    }
}

Write-Host "Translation complete!"
