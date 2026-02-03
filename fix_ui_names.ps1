$mappings = @{
    "TabPage准备File" = "TabPagePrepareFiles"
    "TabPage编码Queue" = "TabPageEncodingQueue"
    "Label预计剩余" = "LabelEstimatedRemaining"
    "Label比特率" = "LabelBitrate"
    "Label质量" = "LabelQuality"
    "Label输出大小" = "LabelOutputSize"
    "Label效率" = "LabelSpeed"
    "LabelProgress" = "LabelProgress"
    "LabelStatus" = "LabelStatus"
    "UiButton任务管理菜单" = "UiButtonQueueManagementMenu"
    "UiButton复制输出" = "UiButtonCopyOutput"
    "UiButton打开输出位置" = "UiButtonOpenOutputLocation"
    "UiLabel预计剩余" = "UiLabelEstimatedRemaining"
    "UiLabel比特率" = "UiLabelBitrate"
    "UiLabel质量" = "UiLabelQuality"
    "UiLabel输出大小" = "UiLabelOutputSize"
    "UiLabel效率" = "UiLabelSpeed"
    "UiLabelProgress" = "UiLabelProgress"
    "UiLabelStatus" = "UiLabelStatus"
}

$files = Get-ChildItem -Path "FFmpegFreeUI" -Recurse -Include "*.vb", "*.Designer.vb"

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw -Encoding UTF8
    $modified = $false
    foreach ($key in $mappings.Keys) {
        if ($content.Contains($key)) {
            $content = $content.Replace($key, $mappings[$key])
            $modified = $true
        }
    }
    if ($modified) {
        Write-Host "Updating $($file.FullName)"
        [System.IO.File]::WriteAllText($file.FullName, $content, [System.Text.Encoding]::UTF8)
    }
}
