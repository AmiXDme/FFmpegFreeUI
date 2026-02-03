Imports System.IO
Imports System.Text.Json
Imports FFmpegFreeUI.MediaInfoParser
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Sunny.UI
Public Class GeneralParametersPage

    Public IsInitialized As Boolean = False

    Public FrameInterpolationPage As New FormFrameInterpolation
    Public MotionBlurPage As New FormFrameBlending
    Public CropPage As New FormCropInteraction
    Public SuperResolutionPage As New FormSuperResolution
    Public BurnSubtitlesPage As New FormBurnSubtitles


    Private Shared ReadOnly VapourSynthScriptExtensions As String() = {"*.vpy", "*.py"}

    Public SelectContainerContextMenu As DarkContextMenu

    Private Sub GeneralParametersPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        UiTabControlMenu1.ItemSize = New Size(200 * Form1.DPI, 36 * Form1.DPI)

        DarkListViewCustomDraw.BindListViewEvents2(ListView2)
        ListView2.SmallImageList = Form1.ImageList1
        InitializeAdvancedQualityControlPresetsMenu()
        SetRichTextBoxLineHeight(RichTextBox1, 350)
        SetRichTextBoxLineHeight(RichTextBox2, 350)
        SetRichTextBoxLineHeight(RichTextBox3, 300)
        SetRichTextBoxLineHeight(RichTextBox4, 300)

        AddHandler UiButtonCopyRealTimeCommand.Click, Sub() Clipboard.SetText(RichTextBox1.Text)
        '==============================================
        InitializeSelectOutputContainerContextMenu()
        AddHandler UiButtonSelectContainer.MouseDown, Sub(s1, e1) SelectContainerContextMenu.Show(s1, New Point(0, s1.Height))
        AddHandler UiComboBoxOutputDirectory.SelectedIndexChanged, AddressOf SelectOutputDirectory
        UiComboBoxOutputDirectory.SelectedIndex = 0
        AddHandler UiComboBoxOutputDirectory.DragEnter, Sub(s, e1) e1.Effect = If(e1.Data.GetDataPresent(DataFormats.FileDrop), DragDropEffects.Copy, DragDropEffects.None)
        AddHandler UiComboBoxOutputDirectory.DragDrop, Sub(s, e1)
                                                Dim F As String = e1.Data.GetData(DataFormats.FileDrop)(0)
                                                If FileIO.FileSystem.DirectoryExists(F) Then
                                                    UiComboBoxOutputDirectory.Text = "  " & F
                                                ElseIf FileIO.FileSystem.FileExists(F) Then
                                                    UiComboBoxOutputDirectory.Text = "  " & Path.GetDirectoryName(F)
                                                End If
                                            End Sub
        '==============================================
        AddHandler UiComboBoxEncoderCategory.SelectedIndexChanged, AddressOf VideoEncodingCategoryChangedEvent
        AddHandler UiComboBoxSpecificEncoder.SelectedIndexChanged, AddressOf VideoEncoderChangedEvent
        '==============================================
        AddHandler UiComboBoxResolution.TextChanged, AddressOf VideoResolutionChangedEvent
        AddHandler UiTextBoxResolutionAutoWidth.TextChanged, AddressOf VideoResolutionAutoWidthChangedEvent
        AddHandler UiTextBoxResolutionAutoHeight.TextChanged, AddressOf VideoResolutionAutoHeightChangedEvent
        AddHandler UiButtonCropWindow.Click, Sub() ShowForm(CropPage, Form1)
        '==============================================
        AddHandler UiButtonOpenFrameInterpolationParametersWindow.Click, Sub()
                                               ShowForm(FrameInterpolationPage, Me.ParentForm)
                                               SetControlFont(UserSettings.Instance.Font, FrameInterpolationPage)
                                           End Sub
        AddHandler UiButtonOpenMotionBlurParametersWindow.Click, Sub()
                                                 ShowForm(MotionBlurPage, Me.ParentForm)
                                                 SetControlFont(UserSettings.Instance.Font, MotionBlurPage)
                                             End Sub
        AddHandler UiButtonOpenSuperResolutionParametersWindow.Click, Sub()
                                               ShowForm(SuperResolutionPage, Me.ParentForm)
                                               SetControlFont(UserSettings.Instance.Font, SuperResolutionPage)
                                           End Sub
        '==============================================
        AddHandler UiButtonBurnSubtitles.Click, Sub()
                                           ShowForm(BurnSubtitlesPage, Me.ParentForm)
                                           SetControlFont(UserSettings.Instance.Font, BurnSubtitlesPage, {BurnSubtitlesPage.LabelFontStylePreview})
                                       End Sub
        '==============================================
        AddHandler UiComboBoxGlobalQualityControlMethod.SelectedIndexChanged, AddressOf VideoBitrateControlMethodChangedEvent
        AddHandler UiButtonAddAdvancedQualityControlPreset.Click, Sub()
                                                  advancedQualityControlPresetsMenu.Font = New Font(UserSettings.Instance.Font, 10)
                                                  advancedQualityControlPresetsMenu.Show(TabPageVideoParametersQuality, New Point(20 * Form1.DPI, 20 * Form1.DPI))
                                              End Sub
        AddHandler UiButtonAddAdvancedQualityControlEmpty.Click, Sub() CreateAdvancedQualityControlItem("")
        AddHandler UiButtonClearAllAdvancedQualityControl.Click, AddressOf ClearAllAdvancedQualityControl
        '==============================================
        AddHandler UiComboBoxColorManagementProcessMethod.TextChanged, AddressOf ColorManagementProcessingMethodChangedEvent
        '==============================================
        AddHandler UiComboBoxDenoiseMethod.TextChanged, AddressOf VideoDenoiseMethodChangedEvent
        '==============================================
        AddHandler UiCheckBoxUseAviSynth.Click, Sub(s1, e1) VideoFrameServerOperationChangedEvent(s1)
        AddHandler UiComboBoxSelectAvsFile.SelectedIndexChanged, Sub(s1, e1) VideoFrameServerOperationChangedEvent(s1)
        AddHandler UiCheckBoxUseVapourSynth.Click, Sub(s1, e1) VideoFrameServerOperationChangedEvent(s1)
        AddHandler UiComboBoxSelectVpyFile.SelectedIndexChanged, Sub(s1, e1) VideoFrameServerOperationChangedEvent(s1)
        '==============================================
        AddHandler UiComboBoxAudioEncoder.TextChanged, AddressOf AudioEncodingParameterChangedEvent
        AddHandler UiComboBoxAudioBitrate.TextChanged, AddressOf AudioBitrateParameterChangedEvent
        AddHandler UiComboBoxAudioQualityParameters.TextChanged, AddressOf AudioQualityParameterChangedEvent
        '==============================================
        AddHandler UiComboBoxImageEncoder.TextChanged, AddressOf ImageEncoderParameterChangedEvent
        '==============================================
        AddHandler UiButtonVisualStreamSelector.Click, Sub()
                                              ShowForm(New FormMediaStreamSelector(
                                                   videoStreamTargetObject:=UiTextBoxApplyVideoParametersToStreams,
                                                   audioStreamTargetObject:=UiTextBoxApplyAudioParametersToStreams,
                                                   subtitleStreamTargetObject:=UiTextBoxWhichEmbeddedSubtitles,
                                                   fileIndex:="0",
                                                   videoStreamsSelected:=UiTextBoxApplyVideoParametersToStreams.Text,
                                                   audioStreamsSelected:=UiTextBoxApplyAudioParametersToStreams.Text,
                                                   subtitleStreamsSelected:=UiTextBoxWhichEmbeddedSubtitles.Text), Me.ParentForm)
                                          End Sub
        AddHandler UiTextBoxApplyVideoParametersToStreams.TextBox.MouseWheel, Sub(s1, e1)
                                                               Select Case e1.Delta
                                                                   Case > 0 : UiTextBoxApplyVideoParametersToStreams.Text = "0:v"
                                                                   Case < 0 : UiTextBoxApplyVideoParametersToStreams.Text = "0:v:0"
                                                               End Select
                                                           End Sub
        AddHandler UiTextBoxApplyAudioParametersToStreams.TextBox.MouseWheel, Sub(s1, e1)
                                                               Select Case e1.Delta
                                                                   Case > 0 : UiTextBoxApplyAudioParametersToStreams.Text = "0:a"
                                                                   Case < 0 : UiTextBoxApplyAudioParametersToStreams.Text = "0:a:0"
                                                               End Select
                                                           End Sub
        AddHandler UiTextBoxWhichEmbeddedSubtitles.TextBox.MouseWheel, Sub(s1, e1)
                                                                  Select Case e1.Delta
                                                                      Case > 0 : UiTextBoxWhichEmbeddedSubtitles.Text = "0:s"
                                                                      Case < 0 : UiTextBoxWhichEmbeddedSubtitles.Text = "0:s:0"
                                                                  End Select
                                                              End Sub
        '==============================================
        AddHandler UiButtonRefreshPresetList.Click, AddressOf RefreshPresetList
        AddHandler UiButtonSavePreset.Click, AddressOf SaveToPreset
        AddHandler UiButtonReadPreset.Click, AddressOf LoadSelectedPreset
        AddHandler UiButtonExportPreset.Click, AddressOf SavePresetToFile
        AddHandler UiButtonImportPreset.Click, AddressOf LoadPresetFromFile

        AddHandler ListView2.SelectedIndexChanged, AddressOf PresetListViewSelectedIndexChangedEvent
        AddHandler ListView2.DoubleClick, AddressOf LoadSelectedPreset
        AddHandler ListView2.BeforeLabelEdit, AddressOf PresetListViewBeforeLabelEditEvent
        AddHandler ListView2.AfterLabelEdit, AddressOf PresetListViewAfterLabelEditEvent
        AddHandler ListView2.SizeChanged, Sub() ListView2.Columns(0).Width = ListView2.Parent.Width - ListView2.Parent.Padding.Left - SystemInformation.VerticalScrollBarWidth * Form1.DPI
        AddHandler UiButtonResetParametersPanel.Click, Sub() PresetManager.ResetAllSettingsInPresets(Me)
        '==============================================
        UiComboBoxAutoNamingOption.SelectedIndex = 0
        '==============================================
        If Me IsNot Form1.GeneralParametersPage Then
            Panel69.Visible = False
        Else
            AddHandler UiComboBoxAutoLoadPresetOption.SelectedIndexChanged, Sub()
                                                                    UserSettings.Instance.AutoLoadPresetOption = UiComboBoxAutoLoadPresetOption.SelectedIndex
                                                                    Select Case UiComboBoxAutoLoadPresetOption.SelectedIndex
                                                                        Case UserSettings.AutoLoadPresetOptionEnum.NoAutoLoad, UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastAllChanges
                                                                            UiTextBoxAutoLoadPresetFilePath.Text = ""
                                                                    End Select
                                                                End Sub
            AddHandler UiButtonSelectLoadSpecificPresetFile.Click, Sub()
                                                     Dim d As New OpenFileDialog With {.Filter = "Json|*.json"}
                                                     d.ShowDialog(Form1)
                                                     If Not FileIO.FileSystem.FileExists(d.FileName) Then Exit Sub
                                                     UiTextBoxAutoLoadPresetFilePath.Text = d.FileName
                                                     UiComboBoxAutoLoadPresetOption.SelectedIndex = UserSettings.AutoLoadPresetOptionEnum.AutoLoadSpecifiedPresetFile
                                                 End Sub
            AddHandler UiTextBoxAutoLoadPresetFilePath.TextChanged, Sub()
                                                             If UiTextBoxAutoLoadPresetFilePath.Text <> "" Then
                                                                 Select Case UiComboBoxAutoLoadPresetOption.SelectedIndex
                                                                     Case UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastPresetFile, UserSettings.AutoLoadPresetOptionEnum.AutoLoadSpecifiedPresetFile
                                                                         UserSettings.Instance.AutoLoadPresetFilePath = UiTextBoxAutoLoadPresetFilePath.Text
                                                                 End Select
                                                             Else
                                                                 UserSettings.Instance.AutoLoadPresetFilePath = ""
                                                             End If
                                                         End Sub
            Select Case UserSettings.Instance.AutoLoadPresetOption
                Case UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastPresetFile, UserSettings.AutoLoadPresetOptionEnum.AutoLoadSpecifiedPresetFile
                    If FileIO.FileSystem.FileExists(UserSettings.Instance.AutoLoadPresetFilePath) Then
                        PresetManager.ShowPreset(JsonSerializer.Deserialize(Of PresetDataType)(FileIO.FileSystem.ReadAllText(UserSettings.Instance.AutoLoadPresetFilePath)), Me)
                    End If
                Case UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastAllChanges
                    If UserSettings.Instance.LastPresetData IsNot Nothing Then PresetManager.ShowPreset(UserSettings.Instance.LastPresetData, Me)
            End Select
        End If

        '==================================================
        AddHandler UiComboBoxAutoNamingOption.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxDecodingDecoder.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxDecodingDataFormat.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxHardwareAccelerationDecodingParamName.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxEncoderCategory.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxSpecificEncoder.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxEncoderPreset.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxProfileFile.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxSceneTune.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxResolution.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxFrameRate.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxGlobalQualityControlMethod.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxGlobalQualityControlParameters.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxPixelFormat.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxMatrixCoefficients.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxColorPrimaries.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxTransferCharacteristics.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxColorRange.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxDenoiseMethod.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxInterlacedProgressiveProcMethod.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxAngleRotate.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxMirrorFlip.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxAudioEncoder.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxAudioQualityParameters.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxChannelLayout.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxSampleRate.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxImageEncoder.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxClipMethod.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxClipForwardDecodingDurationSeconds.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxWhichEmbeddedSubtitlesOperation.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxMetadataOption.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxChapterOption.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        AddHandler UiComboBoxAttachmentOption.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================
        AddHandler UiComboBoxAutoLoadPresetOption.MouseWheel, AddressOf ComboBoxMouseWheelEvent
        '==================================================

        Dim AviSynthDirPath = Path.Combine(Application.StartupPath, "AviSynth")
        If FileIO.FileSystem.DirectoryExists(AviSynthDirPath) Then
            Dim FileList = FileIO.FileSystem.GetFiles(AviSynthDirPath, FileIO.SearchOption.SearchTopLevelOnly, "*.avs")
            If FileList.Count > 0 Then
                For Each File In FileList
                    UiComboBoxSelectAvsFile.Items.Add(File)
                Next
            End If
        End If
        Dim VapourSynthDirPath = Path.Combine(Application.StartupPath, "VapourSynth")
        If FileIO.FileSystem.DirectoryExists(VapourSynthDirPath) Then
            Dim FileList = FileIO.FileSystem.GetFiles(VapourSynthDirPath, FileIO.SearchOption.SearchTopLevelOnly, VapourSynthScriptExtensions)
            If FileList.Count > 0 Then
                For Each File In FileList
                    UiComboBoxSelectVpyFile.Items.Add(File)
                Next
            End If
        End If

        CalibrateUI()
        IsInitialized = True
    End Sub

    Private Sub GeneralParametersPage_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        UiTabControlMenu1.ItemSize = New Size(200 * Form1.DPI, 40 * Form1.DPI)
    End Sub

    Sub ComboBoxMouseWheelEvent(sender As Object, e As MouseEventArgs)
        Select Case e.Delta
            Case > 0 : If sender.SelectedIndex > 0 Then sender.SelectedIndex -= 1
            Case < 0 : If sender.SelectedIndex < sender.Items.Count - 1 Then sender.SelectedIndex += 1
        End Select
    End Sub

    Sub VideoEncodingCategoryChangedEvent()
        UiComboBoxSpecificEncoder.Items.Clear()
        UiComboBoxSpecificEncoder.Text = ""
        Select Case UiComboBoxEncoderCategory.SelectedIndex
            Case 0
                UiComboBoxEncoderPreset.Items.Clear()
                UiComboBoxEncoderPreset.Text = ""
                UiComboBoxProfileFile.Items.Clear()
                UiComboBoxProfileFile.Text = ""
                UiComboBoxSceneTune.Items.Clear()
                UiComboBoxSceneTune.Text = ""
                UiComboBoxPixelFormat.Items.Clear()
                UiComboBoxPixelFormat.Text = ""
            Case 1
                UiComboBoxSpecificEncoder.Items.Add("copy")
                UiComboBoxSpecificEncoder.SelectedIndex = 0
            Case 2    'H.266/VVC
                UiComboBoxSpecificEncoder.Items.Add("libvvenc")
                UiComboBoxSpecificEncoder.Items.Add("libx266")
            Case 3    'AV1
                UiComboBoxSpecificEncoder.Items.Add("libsvtav1")
                UiComboBoxSpecificEncoder.Items.Add("av1_nvenc")
                UiComboBoxSpecificEncoder.Items.Add("av1_qsv")
                UiComboBoxSpecificEncoder.Items.Add("av1_amf")
                UiComboBoxSpecificEncoder.Items.Add("av1_d3d12va")
                UiComboBoxSpecificEncoder.Items.Add("libaom-av1")
                UiComboBoxSpecificEncoder.Items.Add("librav1e")
                UiComboBoxSpecificEncoder.Items.Add("av1_vaapi")
                UiComboBoxSpecificEncoder.Items.Add("av1_vulkan")
            Case 4    'H.265/HEVC
                UiComboBoxSpecificEncoder.Items.Add("libx265")
                UiComboBoxSpecificEncoder.Items.Add("hevc_nvenc")
                UiComboBoxSpecificEncoder.Items.Add("hevc_qsv")
                UiComboBoxSpecificEncoder.Items.Add("hevc_amf")
                UiComboBoxSpecificEncoder.Items.Add("hevc_d3d12va")
                UiComboBoxSpecificEncoder.Items.Add("hevc_vaapi")
                UiComboBoxSpecificEncoder.Items.Add("hevc_vulkan")
                UiComboBoxSpecificEncoder.Items.Add("libkvazaar")
            Case 5    'H.264/AVC
                UiComboBoxSpecificEncoder.Items.Add("libx264")
                UiComboBoxSpecificEncoder.Items.Add("h264_nvenc")
                UiComboBoxSpecificEncoder.Items.Add("h264_qsv")
                UiComboBoxSpecificEncoder.Items.Add("h264_amf")
                UiComboBoxSpecificEncoder.Items.Add("h264_d3d12va")
                UiComboBoxSpecificEncoder.Items.Add("h264_vaapi")
                UiComboBoxSpecificEncoder.Items.Add("h264_vulkan")
            Case 6    'From Apple
                UiComboBoxSpecificEncoder.Items.Add("prores_ks")
                UiComboBoxSpecificEncoder.Items.Add("prores_aw")
            Case 7    'From Google
                UiComboBoxSpecificEncoder.Items.Add("libvpx-vp9")
                UiComboBoxSpecificEncoder.Items.Add("libsvt_vp9")
                UiComboBoxSpecificEncoder.Items.Add("vp9_qsv")
                UiComboBoxSpecificEncoder.Items.Add("vp9_vaapi")
                UiComboBoxSpecificEncoder.Items.Add("libvpx")
                UiComboBoxSpecificEncoder.Items.Add("vp8_vaapi")
            Case 8    'FFv1
                UiComboBoxSpecificEncoder.Items.Add("ffv1 -level 3")
                UiComboBoxSpecificEncoder.Items.Add("ffv1 -level 1")
                UiComboBoxSpecificEncoder.Items.Add("ffv1_vulkan")
            Case 9    'Other Modern Encoders
                UiComboBoxSpecificEncoder.Items.Add("libxeve")
                UiComboBoxSpecificEncoder.Items.Add("libxavs")
                UiComboBoxSpecificEncoder.Items.Add("libxavs2")
                UiComboBoxSpecificEncoder.Items.Add("cfhd")
            Case 10    'Legacy Format
                UiComboBoxSpecificEncoder.Items.Add("mpeg4")
                UiComboBoxSpecificEncoder.Items.Add("libxvid")
                UiComboBoxSpecificEncoder.Items.Add("rv20")
                UiComboBoxSpecificEncoder.Items.Add("rv10")
                UiComboBoxSpecificEncoder.Items.Add("wmv2")
                UiComboBoxSpecificEncoder.Items.Add("wmv1")
            Case 11    'Disable
                UiComboBoxSpecificEncoder.Items.Add("")
            Case 12
                For Each item In UserSettings.Instance.CustomVideoEncoderList
                    UiComboBoxSpecificEncoder.Items.Add(item)
                Next
        End Select
        If UiComboBoxSpecificEncoder.Items.Count > 1 Then UiComboBoxSpecificEncoder.SelectedIndex = 0
    End Sub
    Sub VideoEncoderChangedEvent()
        Select Case UiComboBoxSpecificEncoder.Text
            Case "libkvazaar"
                Label124.Visible = True
            Case Else
                Label124.Visible = False
        End Select

        UiComboBoxEncoderPreset.Items.Clear()
        UiComboBoxEncoderPreset.Text = ""
        UiComboBoxProfileFile.Items.Clear()
        UiComboBoxProfileFile.Text = ""
        UiComboBoxSceneTune.Items.Clear()
        UiComboBoxSceneTune.Text = ""
        UiComboBoxPixelFormat.Items.Clear()
        UiComboBoxPixelFormat.Text = ""

        Dim value As VideoEncoderDatabase.VideoEncoderDataStructure = Nothing
        If UiComboBoxSpecificEncoder.SelectedIndex > -1 AndAlso VideoEncoderDatabase.Dictionary.TryGetValue(UiComboBoxSpecificEncoder.Text, value) Then
            UiComboBoxEncoderPreset.Items.AddRange(value.Preset.ToArray)
            Select Case UiComboBoxSpecificEncoder.Text
                Case "libvvenc" : UiComboBoxEncoderPreset.Text = "faster"
                Case "libaom-av1" : UiComboBoxEncoderPreset.Text = "4"
                Case "libsvtav1" : UiComboBoxEncoderPreset.Text = "6"
                Case "libx265" : UiComboBoxEncoderPreset.Text = "medium"
                Case "libx264" : UiComboBoxEncoderPreset.Text = "slow"
                Case Else : UiComboBoxEncoderPreset.SelectedIndex = 0
            End Select
            UiComboBoxProfileFile.Items.AddRange(value.Profile.ToArray)
            UiComboBoxSceneTune.Items.AddRange(value.Tune.ToArray)
            UiComboBoxPixelFormat.Items.AddRange(value.Pix_fmt.ToArray)
        End If
    End Sub
    Sub VideoResolutionChangedEvent()
        If UiComboBoxResolution.Text <> "" Then
            UiTextBoxResolutionAutoWidth.Text = ""
            UiTextBoxResolutionAutoHeight.Text = ""
        End If
    End Sub
    Sub VideoResolutionAutoWidthChangedEvent()
        If UiTextBoxResolutionAutoWidth.Text <> "" Then
            UiTextBoxResolutionAutoHeight.Text = ""
            UiComboBoxResolution.Text = ""
        End If
    End Sub
    Sub VideoResolutionAutoHeightChangedEvent()
        If UiTextBoxResolutionAutoHeight.Text <> "" Then
            UiTextBoxResolutionAutoWidth.Text = ""
            UiComboBoxResolution.Text = ""
        End If
    End Sub
    Sub VideoBitrateControlMethodChangedEvent()
        Select Case UiComboBoxGlobalQualityControlMethod.SelectedIndex
            Case 0
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 0
                UiTextBoxGlobalQualityControlValue.Text = ""
            Case 1    'Constant Quality CRF
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 1
            Case 2    'Variable Bitrate VBR
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 2
            Case 3    'Variable Bitrate VBR HQ
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 2
            Case 4    'Constant Quantization CQP
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 3
            Case 5    'Constant Bitrate CBR
                UiComboBoxGlobalQualityControlParameters.SelectedIndex = 0
                UiTextBoxGlobalQualityControlValue.Text = ""
        End Select
    End Sub
    Sub VideoDenoiseMethodChangedEvent()
        Select Case UiComboBoxDenoiseMethod.SelectedIndex
            Case 1 'hqdn3d - Spatio-temporal denoising
                LabelDenoiseParameters1.Text = "Luma Spatial Strength" & vbCrLf & "luma_spatial"
                UiTextBoxDenoiseParameter1.Watermark = "Default 4"
                LabelDenoiseParameters2.Text = "Chroma Spatial Strength" & vbCrLf & "chroma_spatial"
                UiTextBoxDenoiseParameter2.Watermark = "Default 3"
                LabelDenoiseParameters3.Text = "Luma Temporal Strength" & vbCrLf & "luma_tmp"
                UiTextBoxDenoiseParameter3.Watermark = "Default 6"
                LabelDenoiseParameters4.Text = "Chroma Temporal Strength" & vbCrLf & "chroma_tmp"
                UiTextBoxDenoiseParameter4.Watermark = "Default 4.5"
                Panel36.Visible = True
                Panel35.Visible = True
            Case 2    'nlmeans - Advanced denoising
                LabelDenoiseParameters1.Text = "Denoise Strength" & vbCrLf & "s (strength)"
                UiTextBoxDenoiseParameter1.Watermark = "Default 1.0"
                LabelDenoiseParameters2.Text = "Patch Size" & vbCrLf & "p (patch size) must be odd"
                UiTextBoxDenoiseParameter2.Watermark = "Default 7"
                LabelDenoiseParameters3.Text = "Plane Config" & vbCrLf & "pc (plane config)"
                UiTextBoxDenoiseParameter3.Watermark = "Default 0"
                LabelDenoiseParameters4.Text = "Search Radius" & vbCrLf & "r (research size)"
                UiTextBoxDenoiseParameter4.Watermark = "Default 15"
                Panel36.Visible = True
                Panel35.Visible = True
            Case 3  'atadenoise - Lightweight temporal denoising
                LabelDenoiseParameters1.Text = "Luma Static Frame Weight" & vbCrLf & "0a"
                UiTextBoxDenoiseParameter1.Watermark = "Default 0.02"
                LabelDenoiseParameters2.Text = "Luma Dynamic Frame Weight" & vbCrLf & "0b"
                UiTextBoxDenoiseParameter2.Watermark = "Default 0.04"
                LabelDenoiseParameters3.Text = "Chroma Static Weight" & vbCrLf & "1a"
                UiTextBoxDenoiseParameter3.Watermark = "Default 0.02"
                LabelDenoiseParameters4.Text = "Chroma Dynamic Weight" & vbCrLf & "1b"
                UiTextBoxDenoiseParameter4.Watermark = "Default 0.04"
                Panel36.Visible = True
                Panel35.Visible = True
            Case 4    'bm3d - High quality denoising
                LabelDenoiseParameters1.Text = "Noise Strength" & vbCrLf & "sigma"
                UiTextBoxDenoiseParameter1.Watermark = "Default 10"
                LabelDenoiseParameters2.Text = "Block Size" & vbCrLf & "block"
                UiTextBoxDenoiseParameter2.Watermark = "Default 16"
                LabelDenoiseParameters3.Text = "Block Step" & vbCrLf & "bstep"
                UiTextBoxDenoiseParameter3.Watermark = "Default 4"
                LabelDenoiseParameters4.Text = "Similar Blocks Count" & vbCrLf & "group"
                UiTextBoxDenoiseParameter4.Watermark = "Default 1"
                Panel36.Visible = True
                Panel35.Visible = True
            Case Else
                UiTextBoxDenoiseParameter1.Text = ""
                UiTextBoxDenoiseParameter2.Text = ""
                UiTextBoxDenoiseParameter3.Text = ""
                UiTextBoxDenoiseParameter4.Text = ""
                Panel35.Visible = False
                Panel36.Visible = False
        End Select
    End Sub
    Sub ColorManagementProcessingMethodChangedEvent()
        If UiComboBoxColorManagementProcessMethod.Text = "" Then
            UiComboBoxMatrixCoefficients.Text = ""
            UiComboBoxColorPrimaries.Text = ""
            UiComboBoxTransferCharacteristics.Text = ""
            UiComboBoxColorRange.Text = ""
        End If
    End Sub

    Sub VideoFrameServerOperationChangedEvent(changedControl As Control)
        Select Case changedControl.Name
            Case UiCheckBoxUseAviSynth.Name
                If UiCheckBoxUseAviSynth.Checked Then
                    UiCheckBoxUseVapourSynth.Checked = False
                    UiComboBoxSelectVpyFile.Text = ""
                    UiComboBoxSelectAvsFile.Text = ""
                Else
                    UiComboBoxSelectAvsFile.Text = ""
                End If

            Case UiComboBoxSelectAvsFile.Name
                If UiComboBoxSelectAvsFile.SelectedIndex = 0 Then
                    Dim a As New OpenFileDialog With {.Filter = "avs|*.avs"}
                    If a.ShowDialog = DialogResult.OK Then
                        If FileIO.FileSystem.FileExists(a.FileName) Then
                            UiComboBoxSelectAvsFile.Text = a.FileName
                            UiCheckBoxUseAviSynth.Checked = True
                            UiCheckBoxUseVapourSynth.Checked = False
                            UiComboBoxSelectVpyFile.Text = ""
                        Else
                            UiComboBoxSelectAvsFile.SelectedIndex = -1
                        End If
                    End If
                End If

            Case UiCheckBoxUseVapourSynth.Name
                If UiCheckBoxUseVapourSynth.Checked Then
                    UiCheckBoxUseAviSynth.Checked = False
                    UiComboBoxSelectAvsFile.Text = ""
                    UiComboBoxSelectVpyFile.Text = ""
                Else
                    UiComboBoxSelectVpyFile.Text = ""
                End If

            Case UiComboBoxSelectVpyFile.Name
                If UiComboBoxSelectVpyFile.SelectedIndex = 0 Then
                    Dim a As New OpenFileDialog With {.Filter = "vpy/py|*.vpy;*.py"}
                    If a.ShowDialog = DialogResult.OK Then
                        If FileIO.FileSystem.FileExists(a.FileName) Then
                            UiComboBoxSelectVpyFile.Text = a.FileName
                            UiCheckBoxUseVapourSynth.Checked = True
                            UiCheckBoxUseAviSynth.Checked = False
                            UiComboBoxSelectAvsFile.Text = ""
                        Else
                            UiComboBoxSelectVpyFile.SelectedIndex = -1
                        End If
                    End If
                End If

        End Select
    End Sub

    Sub AudioEncodingParameterChangedEvent()
        Select Case UiComboBoxAudioEncoder.Text
            Case "Copy Stream", "Disable"
                UiComboBoxAudioBitrate.Text = ""
                UiComboBoxAudioQualityParameters.Text = ""
                UiTextBoxAudioQualityValue.Text = ""
                UiComboBoxChannelLayout.Text = ""
                UiComboBoxSampleRate.Text = ""
                UiTextBoxLoudnessNormalizationTargetLoudness.Text = ""
                UiTextBoxLoudnessNormalizationDynamicRange.Text = ""
                UiTextBoxLoudnessNormalizationPeakValueLevel.Text = ""
                Label25.Visible = False
            Case "FDK AAC", "FDK AAC HE", "FDK AAC HE v2"
                Label25.Visible = True
            Case Else
                Label25.Visible = False
        End Select
    End Sub
    Sub AudioBitrateParameterChangedEvent()
        If UiComboBoxAudioBitrate.Text = "" Then
            UiComboBoxAudioQualityParameters.Text = ""
            UiTextBoxAudioQualityValue.Text = ""
        End If
    End Sub
    Sub AudioQualityParameterChangedEvent()
        If UiComboBoxAudioQualityParameters.Text = "" Then
            UiTextBoxAudioQualityValue.Text = ""
        End If
    End Sub
    Sub ImageEncoderParameterChangedEvent()
        If UiComboBoxImageEncoder.Text = "" Then
            UiTextBoxImageEncoderQuality.Text = ""
        End If
    End Sub

    Private Sub UiTabControlMenu1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiTabControlMenu1.SelectedIndexChanged
        CalibrateUI()
    End Sub
    Sub CalibrateUI()
        Dim tabPage As TabPage = UiTabControlMenu1.SelectedTab
        Select Case True
            Case tabPage.IsEqual(TabPageParametersOverview)
                Panel72.Width = Panel72.Parent.Width * 0.5
                Dim a As New PresetDataType
                PresetManager.SavePreset(a, Me)
                PresetManager.ShowParametersOverview(RichTextBox2, a)
                RichTextBox1.Text = "ffmpeg " & PresetManager.ConvertPresetToCommandLine(a, "<InputFile>", "<OutputFile>")

            Case tabPage.IsEqual(TabPageOutputFileSettings)
                CalibrateUiComboBoxVisual(UiComboBoxAutoNamingOption)
                CalibrateUiComboBoxVisual(UiComboBoxOutputDirectory)
                UiCheckBoxPreserveCreationTime.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxPreserveModificationTime.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxPreserveAccessTime.CheckBoxSize = 20 * Form1.DPI

            Case tabPage.IsEqual(TabPageDecodingSettings)
                CalibrateUiComboBoxVisual(UiComboBoxDecodingDecoder)
                CalibrateUiComboBoxVisual(UiComboBoxDecodingDataFormat)
                CalibrateUiComboBoxVisual(UiComboBoxHardwareAccelerationDecodingParamName)

            Case tabPage.IsEqual(TabPageVideoParametersEncoder)
                CalibrateUiComboBoxVisual(UiComboBoxEncoderCategory)
                CalibrateUiComboBoxVisual(UiComboBoxSpecificEncoder)
                CalibrateUiComboBoxVisual(UiComboBoxEncoderPreset)
                CalibrateUiComboBoxVisual(UiComboBoxProfileFile)
                CalibrateUiComboBoxVisual(UiComboBoxSceneTune)

            Case tabPage.IsEqual(TabPageVideoParametersFrame)
                CalibrateUiComboBoxVisual(UiComboBoxResolution)
                CalibrateUiComboBoxVisual(UiComboBoxFrameRate)

            Case tabPage.IsEqual(TabPageVideoParametersQuality)
                CalibrateUiComboBoxVisual(UiComboBoxGlobalQualityControlMethod)
                CalibrateUiComboBoxVisual(UiComboBoxGlobalQualityControlParameters)

            Case tabPage.IsEqual(TabPageVideoParametersColorManagement)
                CalibrateUiComboBoxVisual(UiComboBoxPixelFormat)
                CalibrateUiComboBoxVisual(UiComboBoxColorSpaceFilterSelect)
                CalibrateUiComboBoxVisual(UiComboBoxMatrixCoefficients)
                CalibrateUiComboBoxVisual(UiComboBoxColorPrimaries)
                CalibrateUiComboBoxVisual(UiComboBoxTransferCharacteristics)
                CalibrateUiComboBoxVisual(UiComboBoxColorRange)
                CalibrateUiComboBoxVisual(UiComboBoxToneMappingAlgorithm)
                CalibrateUiComboBoxVisual(UiComboBoxColorManagementProcessMethod)

            Case tabPage.IsEqual(TabPageVideoParametersCommonFilters)
                CalibrateUiComboBoxVisual(UiComboBoxDenoiseMethod)
                CalibrateUiComboBoxVisual(UiComboBoxInterlacedProgressiveProcMethod)
                CalibrateUiComboBoxVisual(UiComboBoxAngleRotate)
                CalibrateUiComboBoxVisual(UiComboBoxMirrorFlip)

            Case tabPage.IsEqual(TabPageVideoFrameServer)
                CalibrateUiComboBoxVisual(UiComboBoxSelectAvsFile)
                CalibrateUiComboBoxVisual(UiComboBoxSelectVpyFile)
                UiCheckBoxUseAviSynth.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxUseVapourSynth.CheckBoxSize = 20 * Form1.DPI

            Case tabPage.IsEqual(TabPageAudioParameters)
                CalibrateUiComboBoxVisual(UiComboBoxAudioEncoder)
                CalibrateUiComboBoxVisual(UiComboBoxAudioBitrate)
                CalibrateUiComboBoxVisual(UiComboBoxAudioQualityParameters)
                CalibrateUiComboBoxVisual(UiComboBoxChannelLayout)
                CalibrateUiComboBoxVisual(UiComboBoxSampleRate)

            Case tabPage.IsEqual(TabPageImageParameters)
                CalibrateUiComboBoxVisual(UiComboBoxImageEncoder)

            Case tabPage.IsEqual(TabPageCustomParameters)
                UiTabControl1.ItemSize = New Size(150 * Form1.DPI, 50 * Form1.DPI)

            Case tabPage.IsEqual(TabPageClipInterval)
                CalibrateUiComboBoxVisual(UiComboBoxClipMethod)
                CalibrateUiComboBoxVisual(UiComboBoxClipForwardDecodingDurationSeconds)

            Case tabPage.IsEqual(TabPageStreamControl)
                UiCheckBoxPreserveOtherVideoStreams.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxPreserveOtherAudioStreams.CheckBoxSize = 20 * Form1.DPI
                CalibrateUiComboBoxVisual(UiComboBoxWhichEmbeddedSubtitlesOperation)
                UiCheckBoxPreserveOtherSubtitleStreams.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxAutoMuxSRT.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxAutoMuxASS.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxAutoMuxSSA.CheckBoxSize = 20 * Form1.DPI
                UiCheckBoxAutoMuxSubtitleToMovtext.CheckBoxSize = 20 * Form1.DPI
                CalibrateUiComboBoxVisual(UiComboBoxMetadataOption)
                CalibrateUiComboBoxVisual(UiComboBoxChapterOption)
                CalibrateUiComboBoxVisual(UiComboBoxAttachmentOption)

            Case tabPage.IsEqual(TabPagePresetManagement)
                UiCheckBoxExtraSaveInfo.CheckBoxSize = 20 * Form1.DPI
                CalibrateUiComboBoxVisual(UiComboBoxAutoLoadPresetOption)
                If ListView2.Items.Count = 0 Then RefreshPresetList()
        End Select

    End Sub

    Sub RefreshPresetList()
        Me.RichTextBox3.Text = ""
        Me.RichTextBox4.Text = ""
        Dim s1 = (Panel77.Width - Panel77.Padding.Left - Panel77.Padding.Right - Label157.Width * 2) / 3
        Panel82.Width = s1
        Panel83.Width = s1
        ListView2.Items.Clear()
        For Each p As String In ScanSingleLayerFiles(Path.Combine(Application.StartupPath, "Preset"), "*.json")
            ListView2.Items.Add(Path.GetFileNameWithoutExtension(p))
        Next
    End Sub
    Sub PresetListViewSelectedIndexChangedEvent()
        Select Case ListView2.SelectedItems.Count
            Case 1
                Dim a As PresetDataType = JsonSerializer.Deserialize(Of PresetDataType)(FileIO.FileSystem.ReadAllText(Path.Combine(Application.StartupPath, "Preset", ListView2.SelectedItems(0).Text & ".json")))
                PresetManager.ShowParametersOverview(Me.RichTextBox3, a)
                RichTextBox4.Text = "ffmpeg " & PresetManager.ConvertPresetToCommandLine(a, "<InputFile>", "<OutputFile>")
            Case Else
                Me.RichTextBox3.Text = ""
                Me.RichTextBox4.Text = ""
        End Select
    End Sub
    Sub SaveToPreset()
        Select Case ListView2.SelectedItems.Count
            Case 1
                Dim a As New PresetDataType
                PresetManager.SavePreset(a, Me)
                File.WriteAllText(Path.Combine(Application.StartupPath, "Preset", ListView2.SelectedItems(0).Text & ".json"), JsonSerializer.Serialize(a, JsonSO))
                Sunny.UI.UIMessageTip.ShowOk($"Saved: {ListView2.SelectedItems(0).Text}", 1500, False)
            Case 0
                Dim a As New PresetDataType
                PresetManager.SavePreset(a, Me)
                Dim name As String = $"Preset-{Now:yyyyMMdd-HHmmss}"
                File.WriteAllText(Path.Combine(Application.StartupPath, "Preset", name & ".json"), JsonSerializer.Serialize(a, JsonSO))
                ListView2.Items.Add(name)
                Sunny.UI.UIMessageTip.ShowOk($"Saved: {name}", 1500, False)
        End Select
    End Sub
    Sub LoadSelectedPreset()
        Select Case ListView2.SelectedItems.Count
            Case 1
                PresetManager.ShowPreset(JsonSerializer.Deserialize(Of PresetDataType)(FileIO.FileSystem.ReadAllText(Path.Combine(Application.StartupPath, "Preset", ListView2.SelectedItems(0).Text & ".json"))), Me)
                Sunny.UI.UIMessageTip.ShowOk($"Loaded: { ListView2.SelectedItems(0).Text}", 1500, False)
        End Select
    End Sub
    Sub PresetListViewBeforeLabelEditEvent(sender As Object, e As LabelEditEventArgs)
        presetNameBeforeRename = ListView2.Items(e.Item).Text
    End Sub
    Dim presetNameBeforeRename As String
    Sub PresetListViewAfterLabelEditEvent(sender As Object, e As LabelEditEventArgs)
        If presetNameBeforeRename = e.Label Then Exit Sub
        If Not FileIO.FileSystem.FileExists(Path.Combine(Application.StartupPath, "Preset", e.Label & ".json")) AndAlso e.Label <> "" AndAlso e.CancelEdit = False Then
            FileIO.FileSystem.RenameFile(Path.Combine(Application.StartupPath, "Preset", presetNameBeforeRename & ".json"), e.Label & ".json")
        Else
            e.CancelEdit = True
        End If
    End Sub
    Public Sub SavePresetToFile()
        Dim d As New SaveFileDialog With {.Filter = "Json|*.json", .Title = "Save preset to a separate file (put it in the 'Preset' folder to add it to the list)"}
        If ListView2.SelectedItems.Count > 0 Then Sunny.UI.UIMessageTip.ShowWarning($"Note: This is not saving to the list", 1500, False)
        d.ShowDialog(Form1)
        If d.FileName = "" Then Exit Sub
        Dim a As New PresetDataType
        PresetManager.SavePreset(a, Me)
        File.WriteAllText(d.FileName, JsonSerializer.Serialize(a, JsonSO))
        Select Case UserSettings.Instance.AutoLoadPresetOption
            Case UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastPresetFile
                UserSettings.Instance.AutoLoadPresetFilePath = d.FileName
                Me.UiTextBoxAutoLoadPresetFilePath.Text = d.FileName
        End Select
    End Sub
    Public Sub LoadPresetFromFile()
        Dim d As New OpenFileDialog With {.Filter = "Json|*.json", .Title = "Load external preset file (this won't add it to the list)"}
        d.ShowDialog(Form1)
        If Not File.Exists(d.FileName) Then Exit Sub
        Dim a As PresetDataType = JsonSerializer.Deserialize(Of PresetDataType)(File.ReadAllText(d.FileName))
        PresetManager.ShowPreset(a, Me)
        Me.RichTextBox1.Text = "ffmpeg " & PresetManager.ConvertPresetToCommandLine(a, "<InputFile>", "<OutputFile>")
        Select Case UserSettings.Instance.AutoLoadPresetOption
            Case UserSettings.AutoLoadPresetOptionEnum.AutoLoadLastPresetFile
                UserSettings.Instance.AutoLoadPresetFilePath = d.FileName
                Form1.GeneralParametersPage.UiTextBoxAutoLoadPresetFilePath.Text = d.FileName
        End Select
    End Sub

    Sub ClearAllAdvancedQualityControl()
        For Each c In Me.FlowLayoutPanel1.Controls
            c.Dispose()
        Next
        Me.FlowLayoutPanel1.Controls.Clear()
        GC.Collect()
    End Sub

    Sub CreateAdvancedQualityControlItem(text As String)
        Dim a As New UITextBox With {
            .FillColor = Color.FromArgb(48, 48, 48),
            .ForeColor = Color.Silver,
            .RectColor = Color.FromArgb(48, 48, 48),
            .Font = New Font(UserSettings.Instance.Font, 10),
            .Margin = New Padding(0, 0, 10, 10),
            .ButtonFillColor = Color.FromArgb(80, 80, 80),
            .ButtonFillHoverColor = Color.FromArgb(100, 100, 100),
            .ButtonFillPressColor = Color.FromArgb(120, 120, 120),
            .ButtonForeColor = Color.Silver,
            .ButtonForeHoverColor = Color.Silver,
            .ButtonForePressColor = Color.White,
            .ButtonRectColor = Color.FromArgb(80, 80, 80),
            .ButtonRectHoverColor = Color.FromArgb(100, 100, 100),
            .ButtonRectPressColor = Color.FromArgb(120, 120, 120),
            .ButtonSymbol = 10005,
            .ButtonSymbolOffset = New Point(0, 1),
            .ShowButton = True,
            .Height = 30 * Form1.DPI,
            .ButtonWidth = 29 * Form1.DPI,
            .ButtonSymbolSize = 24 * Form1.DPI,
            .Text = text
        }
        a.Width = TextRenderer.MeasureText(text, New Font(UserSettings.Instance.Font, 10)).Width + a.ButtonWidth + 30 * Form1.DPI
        AddHandler a.TextChanged, Sub(sender, e)
                                      Dim s = TextRenderer.MeasureText(sender.Text, sender.Font).Width + sender.ButtonWidth + 30 * Form1.DPI
                                      If s < 50 * Form1.DPI Then
                                          sender.Width = 50 * Form1.DPI
                                      Else
                                          sender.Width = s
                                      End If
                                  End Sub
        AddHandler a.DpiChangedAfterParent, Sub(sender, e)
                                                sender.Height = sender.Height * Form1.DPI
                                                sender.ButtonWidth = 29 * Form1.DPI
                                                sender.ButtonSymbolSize = 24 * Form1.DPI
                                            End Sub
        AddHandler a.ButtonClick, Sub() a.Dispose()
        AddHandler a.KeyDown, Sub(sender, e)
                                  Select Case e.KeyCode
                                      Case Keys.F3
                                          Dim idx As Integer = sender.Parent.Controls.GetChildIndex(sender)
                                          If idx > 0 Then
                                              sender.Parent.Controls.SetChildIndex(sender, idx - 1)
                                          End If
                                      Case Keys.F4
                                          Dim idx As Integer = sender.Parent.Controls.GetChildIndex(sender)
                                          If idx <> sender.Parent.Controls.Count - 1 Then
                                              sender.Parent.Controls.SetChildIndex(sender, idx + 1)
                                          End If
                                  End Select
                              End Sub
        Me.FlowLayoutPanel1.Controls.Add(a)
    End Sub



    Public advancedQualityControlPresetsMenu As New DarkContextMenu With {.ShowImageMargin = False, .Font = New Font(UserSettings.Instance.Font, 10)}

    Sub InitializeAdvancedQualityControlPresetsMenu()
        advancedQualityControlPresetsMenu.Items.AddRange(New ToolStripItem() {
        New ToolStripSeparator() With {.Tag = "null"},
        New ToolStripMenuItem("-rc-lookahead (Nvidia\libx264)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-rc-lookahead ")) With {.ForeColor = Color.YellowGreen},
        New ToolStripMenuItem("-look_ahead_depth (Intel)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-look_ahead_depth ")) With {.ForeColor = Color.CornflowerBlue},
        New ToolStripMenuItem("-extbrc=1 (Intel Aggressive Bitrate)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-extbrc 1")) With {.ForeColor = Color.CornflowerBlue},
        New ToolStripMenuItem("-g (Keyframe Gap)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-g ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-bf (B-frames Count)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-bf ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-level (Encoder Level)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-level ")) With {.ForeColor = Color.Gray},
        New ToolStripMenuItem("-qmin (Min Quantizer / Max Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qmin ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qpmin (Min Quantizer / Max Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qpmin ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qmax (Max Quantizer / Min Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qmax ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qpmax (Max Quantizer / Min Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qpmax ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qcomp (Quant Compression 0.0~1.0)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qcomp ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-aq-mode (Adaptive Quantization - libaom-av1)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-aq-mode ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-arnr-strength (Adaptive Noise Reduction 0~6 - libaom-av1)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-arnr-strength ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-la_depth (Look-ahead Depth - libsvtav1)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-la_depth ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qp_i (I-frame Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qp_i ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qp_p (P-frame Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qp_p ")) With {.ForeColor = Color.Silver},
        New ToolStripMenuItem("-qp_b (B-frame Quality)", Nothing, Sub(s1, e1) CreateAdvancedQualityControlItem("-qp_b ")) With {.ForeColor = Color.Silver},
        New ToolStripSeparator() With {.Tag = "null"}})
    End Sub

    Sub InitializeSelectOutputContainerContextMenu()

        Dim b As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        b.Items.AddRange(New ToolStripItem() {
             New ToolStripSeparator() With {.Tag = "null"},
             New ToolStripMenuItem(".mp4", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".mkv", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".flv", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".mov", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".webm", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".m2ts", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".wmv", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".avi", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".rmvb", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".ts", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".3gp", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripSeparator() With {.Tag = "null"}})

        Dim c As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        c.Items.AddRange(New ToolStripItem() {
             New ToolStripSeparator() With {.Tag = "null"},
             New ToolStripMenuItem(".mp3", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".aac", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".wav", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".flac", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".alac", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".aiff", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".ac3", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".ogg", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".opus", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".m4a", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripSeparator() With {.Tag = "null"}})

        Dim d As New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        d.Items.AddRange(New ToolStripItem() {
             New ToolStripSeparator() With {.Tag = "null"},
             New ToolStripMenuItem(".png", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".jpg", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".jpeg", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".webp", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".avif", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".bmp", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".gif", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".ico", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripSeparator() With {.Tag = "null"}})

        selectContainerContextMenu = New DarkContextMenu With {.ShowImageMargin = False, .Font = Form1.Font}
        selectContainerContextMenu.Items.AddRange(New ToolStripItem() {
             New ToolStripSeparator() With {.Tag = "null"},
             New ToolStripMenuItem("All Categories") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
             New ToolStripMenuItem("Video") With {.ForeColor = Color.Silver, .DropDown = b},
             New ToolStripMenuItem("Audio") With {.ForeColor = Color.Silver, .DropDown = c},
             New ToolStripMenuItem("Image") With {.ForeColor = Color.Silver, .DropDown = d},
             New ToolStripMenuItem("Common Containers") With {.ForeColor = Color.CornflowerBlue, .Enabled = False},
             New ToolStripMenuItem(".mp4", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripMenuItem(".mkv", Nothing, Sub(s1, e1) UiTextBoxOutputContainer.Text = s1.Text) With {.ForeColor = Color.Silver},
             New ToolStripSeparator() With {.Tag = "null"}})
    End Sub

    Sub SelectOutputDirectory()
        If UiComboBoxOutputDirectory.SelectedIndex = 1 Then
            Dim dialog As New CommonOpenFileDialog With {.IsFolderPicker = True}
            If dialog.ShowDialog() = CommonFileDialogResult.Ok Then
                If UserSettings.Instance.TranslationMode Then
                    UiComboBoxOutputDirectory.Text = "  " & ProcessPathForTranslationMode(dialog.FileName)
                Else
                    UiComboBoxOutputDirectory.Text = "  " & dialog.FileName
                End If
            Else
                UiComboBoxOutputDirectory.SelectedIndex = 0
            End If
        End If
    End Sub

End Class


















