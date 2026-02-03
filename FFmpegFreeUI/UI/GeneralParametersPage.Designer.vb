<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralParametersPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Note: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralParametersPage))
        UiTabControlMenu1 = New Sunny.UI.UITabControlMenu()
        TabPageParametersOverview = New TabPage()
        Panel74 = New Panel()
        Panel81 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label74 = New Label()
        Panel70 = New Panel()
        UiButtonCopyRealTimeCommand = New Sunny.UI.UIButton()
        Panel72 = New Panel()
        Panel73 = New Panel()
        RichTextBox2 = New RichTextBox()
        Label17 = New Label()
        TabPageOutputFileSettings = New TabPage()
        Panel71 = New Panel()
        UiCheckBoxPreserveAccessTime = New Sunny.UI.UICheckBox()
        UiCheckBoxPreserveModificationTime = New Sunny.UI.UICheckBox()
        UiCheckBoxPreserveCreationTime = New Sunny.UI.UICheckBox()
        Label128 = New Label()
        Label127 = New Label()
        Panel7 = New Panel()
        Label6 = New Label()
        UiTextBoxSuffixText = New Sunny.UI.UITextBox()
        Panel6 = New Panel()
        Label5 = New Label()
        UiTextBoxReplacementText = New Sunny.UI.UITextBox()
        Panel5 = New Panel()
        Label4 = New Label()
        UiTextBoxPrefixText = New Sunny.UI.UITextBox()
        Panel8 = New Panel()
        Label141 = New Label()
        UiComboBoxAutoNamingOption = New Sunny.UI.UIComboBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        UiSwitchUseAutoNaming = New Sunny.UI.UISwitch()
        Label3 = New Label()
        Panel80 = New Panel()
        UiComboBoxOutputDirectory = New Sunny.UI.UIComboBox()
        Panel3 = New Panel()
        Label2 = New Label()
        Panel4 = New Panel()
        UiSwitchDoNotUseOutputFileParameters = New Sunny.UI.UISwitch()
        Panel79 = New Panel()
        UiTextBoxOutputContainer = New Sunny.UI.UITextBox()
        UiButtonSelectContainer = New Sunny.UI.UIButton()
        Label76 = New Label()
        Label155 = New Label()
        TabPageDecodingSettings = New TabPage()
        Panel78 = New Panel()
        UiTextBoxHardwareAccelerationDecodingParameters = New Sunny.UI.UITextBox()
        Panel12 = New Panel()
        UiComboBoxHardwareAccelerationDecodingParamName = New Sunny.UI.UIComboBox()
        Label13 = New Label()
        Label14 = New Label()
        Panel11 = New Panel()
        UiComboBoxDecodingDataFormat = New Sunny.UI.UIComboBox()
        Label11 = New Label()
        Label12 = New Label()
        Panel10 = New Panel()
        UiTextBoxCPUDecodingThreadCount = New Sunny.UI.UITextBox()
        Label9 = New Label()
        Label10 = New Label()
        Panel9 = New Panel()
        UiComboBoxDecodingDecoder = New Sunny.UI.UIComboBox()
        Label8 = New Label()
        Label7 = New Label()
        TabPageVideoParametersEncoder = New TabPage()
        Panel19 = New Panel()
        Label171 = New Label()
        UiTextBoxthreads = New Sunny.UI.UITextBox()
        Panel18 = New Panel()
        Label167 = New Label()
        UiTextBoxgpu = New Sunny.UI.UITextBox()
        Label23 = New Label()
        Label136 = New Label()
        Panel17 = New Panel()
        Label26 = New Label()
        UiComboBoxSceneTune = New Sunny.UI.UIComboBox()
        Panel16 = New Panel()
        Label24 = New Label()
        UiComboBoxProfileFile = New Sunny.UI.UIComboBox()
        Panel15 = New Panel()
        Label22 = New Label()
        UiComboBoxEncoderPreset = New Sunny.UI.UIComboBox()
        Label27 = New Label()
        Label124 = New Label()
        Panel14 = New Panel()
        Label21 = New Label()
        UiComboBoxSpecificEncoder = New Sunny.UI.UIComboBox()
        Label19 = New Label()
        Panel13 = New Panel()
        UiComboBoxEncoderCategory = New Sunny.UI.UIComboBox()
        Label16 = New Label()
        Label20 = New Label()
        TabPageVideoParametersFrame = New TabPage()
        Panel96 = New Panel()
        UiButtonBurnSubtitles = New Sunny.UI.UIButton()
        Label68 = New Label()
        Label170 = New Label()
        Panel23 = New Panel()
        UiButtonOpenSuperResolutionParametersWindow = New Sunny.UI.UIButton()
        Label82 = New Label()
        UiButtonOpenMotionBlurParametersWindow = New Sunny.UI.UIButton()
        Label145 = New Label()
        UiButtonOpenFrameInterpolationParametersWindow = New Sunny.UI.UIButton()
        Label37 = New Label()
        Label38 = New Label()
        Panel22 = New Panel()
        Label39 = New Label()
        UiTextBoxFrameMaxChangeRatio = New Sunny.UI.UITextBox()
        Label36 = New Label()
        UiComboBoxFrameRate = New Sunny.UI.UIComboBox()
        Label33 = New Label()
        Label34 = New Label()
        Panel21 = New Panel()
        UiTextBoxCropFilterParameters = New Sunny.UI.UITextBox()
        Label137 = New Label()
        UiButtonCropWindow = New Sunny.UI.UIButton()
        Label31 = New Label()
        Panel20 = New Panel()
        UiTextBoxResolutionAutoHeight = New Sunny.UI.UITextBox()
        Label35 = New Label()
        UiTextBoxResolutionAutoWidth = New Sunny.UI.UITextBox()
        Label30 = New Label()
        UiComboBoxResolution = New Sunny.UI.UIComboBox()
        Label28 = New Label()
        Label29 = New Label()
        TabPageVideoParametersQuality = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel26 = New Panel()
        Label56 = New Label()
        UiButtonClearAllAdvancedQualityControl = New Sunny.UI.UIButton()
        Label18 = New Label()
        UiButtonAddAdvancedQualityControlEmpty = New Sunny.UI.UIButton()
        Label55 = New Label()
        UiButtonAddAdvancedQualityControlPreset = New Sunny.UI.UIButton()
        Label49 = New Label()
        Label54 = New Label()
        Panel25 = New Panel()
        UiTextBoxBitrateBufferSize = New Sunny.UI.UITextBox()
        Label46 = New Label()
        UiTextBoxMaxBitrate = New Sunny.UI.UITextBox()
        Label47 = New Label()
        UiTextBoxMinBitrate = New Sunny.UI.UITextBox()
        Label48 = New Label()
        UiTextBoxBaseBitrate = New Sunny.UI.UITextBox()
        Panel30 = New Panel()
        Label50 = New Label()
        Label51 = New Label()
        Label52 = New Label()
        Label53 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        Panel24 = New Panel()
        UiTextBoxGlobalQualityControlValue = New Sunny.UI.UITextBox()
        Label42 = New Label()
        UiComboBoxGlobalQualityControlParameters = New Sunny.UI.UIComboBox()
        Label43 = New Label()
        UiComboBoxGlobalQualityControlMethod = New Sunny.UI.UIComboBox()
        Label40 = New Label()
        Label41 = New Label()
        TabPageVideoParametersColorManagement = New TabPage()
        Panel40 = New Panel()
        Panel33 = New Panel()
        Label61 = New Label()
        UiComboBoxColorManagementProcessMethod = New Sunny.UI.UIComboBox()
        Label143 = New Label()
        Panel90 = New Panel()
        Label59 = New Label()
        UiComboBoxToneMappingAlgorithm = New Sunny.UI.UIComboBox()
        Panel32 = New Panel()
        Label65 = New Label()
        UiComboBoxColorRange = New Sunny.UI.UIComboBox()
        Panel31 = New Panel()
        Label64 = New Label()
        UiComboBoxTransferCharacteristics = New Sunny.UI.UIComboBox()
        Panel29 = New Panel()
        Label63 = New Label()
        UiComboBoxColorPrimaries = New Sunny.UI.UIComboBox()
        Panel28 = New Panel()
        Label62 = New Label()
        UiComboBoxMatrixCoefficients = New Sunny.UI.UIComboBox()
        Label81 = New Label()
        Panel41 = New Panel()
        Label147 = New Label()
        UiComboBoxColorSpaceFilterSelect = New Sunny.UI.UIComboBox()
        Label80 = New Label()
        Label60 = New Label()
        Panel27 = New Panel()
        UiComboBoxPixelFormat = New Sunny.UI.UIComboBox()
        Label57 = New Label()
        Label58 = New Label()
        Panel85 = New Panel()
        Panel89 = New Panel()
        UiTextBoxSimpleColorGamma = New Sunny.UI.UITextBox()
        Label156 = New Label()
        Panel88 = New Panel()
        UiTextBoxSimpleColorSaturation = New Sunny.UI.UITextBox()
        Label130 = New Label()
        Panel87 = New Panel()
        UiTextBoxSimpleColorContrast = New Sunny.UI.UITextBox()
        Label78 = New Label()
        Panel86 = New Panel()
        UiTextBoxSimpleColorBrightness = New Sunny.UI.UITextBox()
        Label83 = New Label()
        Label160 = New Label()
        Label79 = New Label()
        TabPageVideoParametersCommonFilters = New TabPage()
        Panel39 = New Panel()
        UiComboBoxMirrorFlip = New Sunny.UI.UIComboBox()
        Label92 = New Label()
        UiComboBoxAngleRotate = New Sunny.UI.UIComboBox()
        Label77 = New Label()
        Panel38 = New Panel()
        UiComboBoxInterlacedProgressiveProcMethod = New Sunny.UI.UIComboBox()
        Label75 = New Label()
        Panel37 = New Panel()
        Label87 = New Label()
        UiTextBoxSharpenStrength = New Sunny.UI.UITextBox()
        Label118 = New Label()
        UiTextBoxSharpenVerticalSize = New Sunny.UI.UITextBox()
        Label117 = New Label()
        UiTextBoxSharpenHorizontalSize = New Sunny.UI.UITextBox()
        Label72 = New Label()
        Label73 = New Label()
        Panel36 = New Panel()
        UiTextBoxDenoiseParameter4 = New Sunny.UI.UITextBox()
        Label69 = New Label()
        UiTextBoxDenoiseParameter3 = New Sunny.UI.UITextBox()
        Label70 = New Label()
        UiTextBoxDenoiseParameter2 = New Sunny.UI.UITextBox()
        Label71 = New Label()
        UiTextBoxDenoiseParameter1 = New Sunny.UI.UITextBox()
        Panel35 = New Panel()
        LabelDenoiseParameters4 = New Label()
        LabelDenoiseParameters3 = New Label()
        LabelDenoiseParameters2 = New Label()
        LabelDenoiseParameters1 = New Label()
        Panel34 = New Panel()
        UiComboBoxDenoiseMethod = New Sunny.UI.UIComboBox()
        Label66 = New Label()
        Label67 = New Label()
        TabPageVideoFrameServer = New TabPage()
        Label189 = New Label()
        Panel94 = New Panel()
        UiComboBoxSelectVpyFile = New Sunny.UI.UIComboBox()
        Panel95 = New Panel()
        UiCheckBoxUseVapourSynth = New Sunny.UI.UICheckBox()
        Label188 = New Label()
        Label186 = New Label()
        Panel49 = New Panel()
        UiComboBoxSelectAvsFile = New Sunny.UI.UIComboBox()
        Panel48 = New Panel()
        UiCheckBoxUseAviSynth = New Sunny.UI.UICheckBox()
        Label187 = New Label()
        Label185 = New Label()
        Label183 = New Label()
        Label182 = New Label()
        TabPageAudioParameters = New TabPage()
        Panel93 = New Panel()
        UiTextBoxLoudnessNormalizationPeakValueLevel = New Sunny.UI.UITextBox()
        Label178 = New Label()
        UiTextBoxLoudnessNormalizationDynamicRange = New Sunny.UI.UITextBox()
        Label173 = New Label()
        UiTextBoxLoudnessNormalizationTargetLoudness = New Sunny.UI.UITextBox()
        Panel92 = New Panel()
        Label174 = New Label()
        Label176 = New Label()
        Label177 = New Label()
        Label179 = New Label()
        Label90 = New Label()
        Panel46 = New Panel()
        UiComboBoxSampleRate = New Sunny.UI.UIComboBox()
        Label89 = New Label()
        Panel45 = New Panel()
        UiComboBoxChannelLayout = New Sunny.UI.UIComboBox()
        Label86 = New Label()
        Panel44 = New Panel()
        Label134 = New Label()
        UiTextBoxAudioQualityValue = New Sunny.UI.UITextBox()
        Label84 = New Label()
        UiComboBoxAudioQualityParameters = New Sunny.UI.UIComboBox()
        Panel43 = New Panel()
        Label131 = New Label()
        UiComboBoxAudioBitrate = New Sunny.UI.UIComboBox()
        Label88 = New Label()
        Panel42 = New Panel()
        Label25 = New Label()
        UiComboBoxAudioEncoder = New Sunny.UI.UIComboBox()
        Label85 = New Label()
        TabPageImageParameters = New TabPage()
        Label94 = New Label()
        Label135 = New Label()
        Label15 = New Label()
        Label154 = New Label()
        Label91 = New Label()
        Label93 = New Label()
        Label161 = New Label()
        Label162 = New Label()
        Panel67 = New Panel()
        UiTextBoxImageEncoderQuality = New Sunny.UI.UITextBox()
        Label122 = New Label()
        UiComboBoxImageEncoder = New Sunny.UI.UIComboBox()
        Label121 = New Label()
        Label120 = New Label()
        TabPageCustomParameters = New TabPage()
        Panel50 = New Panel()
        UiTabControl1 = New Sunny.UI.UITabControl()
        TabPage1 = New TabPage()
        Panel51 = New Panel()
        TextBox1 = New TextBox()
        Label98 = New Label()
        Label97 = New Label()
        TabPage2 = New TabPage()
        Panel52 = New Panel()
        UiTextBoxCustomVideoFilter = New Sunny.UI.UITextBox()
        Label99 = New Label()
        Panel53 = New Panel()
        UiTextBoxCustomAudioFilter = New Sunny.UI.UITextBox()
        Label119 = New Label()
        Panel65 = New Panel()
        UiTextBoxfilter_complex = New Sunny.UI.UITextBox()
        Label138 = New Label()
        Label96 = New Label()
        TabPage3 = New TabPage()
        Panel54 = New Panel()
        UiTextBoxCustomVideoParameters = New Sunny.UI.UITextBox()
        Label100 = New Label()
        Label101 = New Label()
        Panel55 = New Panel()
        UiTextBoxCustomAudioParameters = New Sunny.UI.UITextBox()
        TabPage4 = New TabPage()
        Panel59 = New Panel()
        UiTextBoxFinalParameters = New Sunny.UI.UITextBox()
        Label105 = New Label()
        Panel58 = New Panel()
        UiTextBoxPostParameters = New Sunny.UI.UITextBox()
        Label104 = New Label()
        Panel57 = New Panel()
        UiTextBoxPreParameters = New Sunny.UI.UITextBox()
        Label103 = New Label()
        Panel56 = New Panel()
        UiTextBoxStartParameters = New Sunny.UI.UITextBox()
        Label102 = New Label()
        TabPage5 = New TabPage()
        Panel60 = New Panel()
        UiTextBoxCustomFullParameters = New Sunny.UI.UITextBox()
        Label106 = New Label()
        TabPageClipInterval = New TabPage()
        Label181 = New Label()
        Panel75 = New Panel()
        UiComboBoxClipForwardDecodingDurationSeconds = New Sunny.UI.UIComboBox()
        Label151 = New Label()
        Label150 = New Label()
        Panel76 = New Panel()
        UiTextBoxQuickClipOutPoint = New Sunny.UI.UITextBox()
        Label116 = New Label()
        UiTextBoxQuickClipInPoint = New Sunny.UI.UITextBox()
        Label115 = New Label()
        Label152 = New Label()
        Panel66 = New Panel()
        UiComboBoxClipMethod = New Sunny.UI.UIComboBox()
        Label109 = New Label()
        Label146 = New Label()
        TabPageStreamControl = New TabPage()
        Label32 = New Label()
        Panel64 = New Panel()
        Label108 = New Label()
        UiComboBoxAttachmentOption = New Sunny.UI.UIComboBox()
        Label163 = New Label()
        UiComboBoxChapterOption = New Sunny.UI.UIComboBox()
        Label148 = New Label()
        UiComboBoxMetadataOption = New Sunny.UI.UIComboBox()
        Label111 = New Label()
        Label165 = New Label()
        Panel91 = New Panel()
        Label110 = New Label()
        UiCheckBoxAutoMuxSubtitleToMovtext = New Sunny.UI.UICheckBox()
        UiCheckBoxAutoMuxSSA = New Sunny.UI.UICheckBox()
        UiCheckBoxAutoMuxASS = New Sunny.UI.UICheckBox()
        UiCheckBoxAutoMuxSRT = New Sunny.UI.UICheckBox()
        Label164 = New Label()
        Panel97 = New Panel()
        Label107 = New Label()
        UiButtonVisualStreamSelector = New Sunny.UI.UIButton()
        Panel47 = New Panel()
        UiCheckBoxPreserveOtherSubtitleStreams = New Sunny.UI.UICheckBox()
        Label184 = New Label()
        Panel63 = New Panel()
        Label166 = New Label()
        Label169 = New Label()
        UiComboBoxWhichEmbeddedSubtitlesOperation = New Sunny.UI.UIComboBox()
        Label168 = New Label()
        UiTextBoxWhichEmbeddedSubtitles = New Sunny.UI.UITextBox()
        Label112 = New Label()
        Panel61 = New Panel()
        Label140 = New Label()
        UiCheckBoxPreserveOtherAudioStreams = New Sunny.UI.UICheckBox()
        Label133 = New Label()
        UiTextBoxApplyAudioParametersToStreams = New Sunny.UI.UITextBox()
        Label113 = New Label()
        Panel62 = New Panel()
        Label139 = New Label()
        UiCheckBoxPreserveOtherVideoStreams = New Sunny.UI.UICheckBox()
        Label132 = New Label()
        UiTextBoxApplyVideoParametersToStreams = New Sunny.UI.UITextBox()
        Label114 = New Label()
        TabPagePresetManagement = New TabPage()
        Panel77 = New Panel()
        Panel84 = New Panel()
        RichTextBox4 = New RichTextBox()
        Label158 = New Label()
        Panel83 = New Panel()
        RichTextBox3 = New RichTextBox()
        Label157 = New Label()
        Panel82 = New Panel()
        ListView2 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel69 = New Panel()
        UiTextBoxAutoLoadPresetFilePath = New Sunny.UI.UITextBox()
        UiButtonSelectLoadSpecificPresetFile = New Sunny.UI.UIButton()
        Label175 = New Label()
        UiComboBoxAutoLoadPresetOption = New Sunny.UI.UIComboBox()
        Label142 = New Label()
        Panel68 = New Panel()
        UiCheckBoxExtraSaveInfo = New Sunny.UI.UICheckBox()
        Label126 = New Label()
        UiButtonResetParametersPanel = New Sunny.UI.UIButton()
        Label125 = New Label()
        UiButtonImportPreset = New Sunny.UI.UIButton()
        Label149 = New Label()
        UiButtonExportPreset = New Sunny.UI.UIButton()
        Label95 = New Label()
        UiButtonReadPreset = New Sunny.UI.UIButton()
        Label129 = New Label()
        UiButtonSavePreset = New Sunny.UI.UIButton()
        Label159 = New Label()
        UiButtonRefreshPresetList = New Sunny.UI.UIButton()
        Label123 = New Label()
        UiTabControlMenu1.SuspendLayout()
        TabPageParametersOverview.SuspendLayout()
        Panel74.SuspendLayout()
        Panel81.SuspendLayout()
        Panel70.SuspendLayout()
        Panel72.SuspendLayout()
        Panel73.SuspendLayout()
        TabPageOutputFileSettings.SuspendLayout()
        Panel71.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel80.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel79.SuspendLayout()
        TabPageDecodingSettings.SuspendLayout()
        Panel78.SuspendLayout()
        Panel12.SuspendLayout()
        Panel11.SuspendLayout()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        TabPageVideoParametersEncoder.SuspendLayout()
        Panel19.SuspendLayout()
        Panel18.SuspendLayout()
        Panel17.SuspendLayout()
        Panel16.SuspendLayout()
        Panel15.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        TabPageVideoParametersFrame.SuspendLayout()
        Panel96.SuspendLayout()
        Panel23.SuspendLayout()
        Panel22.SuspendLayout()
        Panel21.SuspendLayout()
        Panel20.SuspendLayout()
        TabPageVideoParametersQuality.SuspendLayout()
        Panel26.SuspendLayout()
        Panel25.SuspendLayout()
        Panel30.SuspendLayout()
        Panel24.SuspendLayout()
        TabPageVideoParametersColorManagement.SuspendLayout()
        Panel40.SuspendLayout()
        Panel33.SuspendLayout()
        Panel90.SuspendLayout()
        Panel32.SuspendLayout()
        Panel31.SuspendLayout()
        Panel29.SuspendLayout()
        Panel28.SuspendLayout()
        Panel41.SuspendLayout()
        Panel27.SuspendLayout()
        Panel85.SuspendLayout()
        Panel89.SuspendLayout()
        Panel88.SuspendLayout()
        Panel87.SuspendLayout()
        Panel86.SuspendLayout()
        TabPageVideoParametersCommonFilters.SuspendLayout()
        Panel39.SuspendLayout()
        Panel38.SuspendLayout()
        Panel37.SuspendLayout()
        Panel36.SuspendLayout()
        Panel35.SuspendLayout()
        Panel34.SuspendLayout()
        TabPageVideoFrameServer.SuspendLayout()
        Panel94.SuspendLayout()
        Panel95.SuspendLayout()
        Panel49.SuspendLayout()
        Panel48.SuspendLayout()
        TabPageAudioParameters.SuspendLayout()
        Panel93.SuspendLayout()
        Panel92.SuspendLayout()
        Panel46.SuspendLayout()
        Panel45.SuspendLayout()
        Panel44.SuspendLayout()
        Panel43.SuspendLayout()
        Panel42.SuspendLayout()
        TabPageImageParameters.SuspendLayout()
        Panel67.SuspendLayout()
        TabPageCustomParameters.SuspendLayout()
        Panel50.SuspendLayout()
        UiTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel51.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel52.SuspendLayout()
        Panel53.SuspendLayout()
        Panel65.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel54.SuspendLayout()
        Panel55.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel59.SuspendLayout()
        Panel58.SuspendLayout()
        Panel57.SuspendLayout()
        Panel56.SuspendLayout()
        TabPage5.SuspendLayout()
        Panel60.SuspendLayout()
        TabPageClipInterval.SuspendLayout()
        Panel75.SuspendLayout()
        Panel76.SuspendLayout()
        Panel66.SuspendLayout()
        TabPageStreamControl.SuspendLayout()
        Panel64.SuspendLayout()
        Panel91.SuspendLayout()
        Panel97.SuspendLayout()
        Panel47.SuspendLayout()
        Panel63.SuspendLayout()
        Panel61.SuspendLayout()
        Panel62.SuspendLayout()
        TabPagePresetManagement.SuspendLayout()
        Panel77.SuspendLayout()
        Panel84.SuspendLayout()
        Panel83.SuspendLayout()
        Panel82.SuspendLayout()
        Panel69.SuspendLayout()
        Panel68.SuspendLayout()
        SuspendLayout()
        ' 
        ' UiTabControlMenu1
        ' 
        UiTabControlMenu1.Alignment = TabAlignment.Left
        UiTabControlMenu1.Controls.Add(TabPageParametersOverview)
        UiTabControlMenu1.Controls.Add(TabPageOutputFileSettings)
        UiTabControlMenu1.Controls.Add(TabPageDecodingSettings)
        UiTabControlMenu1.Controls.Add(TabPageVideoParametersEncoder)
        UiTabControlMenu1.Controls.Add(TabPageVideoParametersFrame)
        UiTabControlMenu1.Controls.Add(TabPageVideoParametersQuality)
        UiTabControlMenu1.Controls.Add(TabPageVideoParametersColorManagement)
        UiTabControlMenu1.Controls.Add(TabPageVideoParametersCommonFilters)
        UiTabControlMenu1.Controls.Add(TabPageVideoFrameServer)
        UiTabControlMenu1.Controls.Add(TabPageAudioParameters)
        UiTabControlMenu1.Controls.Add(TabPageImageParameters)
        UiTabControlMenu1.Controls.Add(TabPageCustomParameters)
        UiTabControlMenu1.Controls.Add(TabPageClipInterval)
        UiTabControlMenu1.Controls.Add(TabPageStreamControl)
        UiTabControlMenu1.Controls.Add(TabPagePresetManagement)
        UiTabControlMenu1.Dock = DockStyle.Fill
        UiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControlMenu1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControlMenu1.Font = New Font("Segoe UI", 11F)
        UiTabControlMenu1.ItemSize = New Size(200, 36)
        UiTabControlMenu1.Location = New Point(0, 0)
        UiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControlMenu1.Multiline = True
        UiTabControlMenu1.Name = "UiTabControlMenu1"
        UiTabControlMenu1.SelectedIndex = 0
        UiTabControlMenu1.Size = New Size(1100, 650)
        UiTabControlMenu1.SizeMode = TabSizeMode.Fixed
        UiTabControlMenu1.TabBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControlMenu1.TabIndex = 0
        UiTabControlMenu1.TabSelectedForeColor = Color.CornflowerBlue
        UiTabControlMenu1.TabSelectedHighColor = Color.CornflowerBlue
        UiTabControlMenu1.TextAlignment = HorizontalAlignment.Left
        ' 
        ' TabPageParametersOverview
        ' 
        TabPageParametersOverview.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageParametersOverview.Controls.Add(Panel74)
        TabPageParametersOverview.Controls.Add(Panel72)
        TabPageParametersOverview.Location = New Point(201, 0)
        TabPageParametersOverview.Name = "TabPageParametersOverview"
        TabPageParametersOverview.Size = New Size(899, 650)
        TabPageParametersOverview.TabIndex = 0
        TabPageParametersOverview.Tag = "TabPage.ParameterOverview"
        TabPageParametersOverview.Text = "ParametersOverview"
        ' 
        ' Panel74
        ' 
        Panel74.Controls.Add(Panel81)
        Panel74.Controls.Add(Label74)
        Panel74.Controls.Add(Panel70)
        Panel74.Dock = DockStyle.Fill
        Panel74.Location = New Point(416, 0)
        Panel74.Name = "Panel74"
        Panel74.Padding = New Padding(10, 10, 20, 20)
        Panel74.Size = New Size(483, 650)
        Panel74.TabIndex = 39
        ' 
        ' Panel81
        ' 
        Panel81.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel81.Controls.Add(RichTextBox1)
        Panel81.Dock = DockStyle.Fill
        Panel81.Location = New Point(10, 45)
        Panel81.Name = "Panel81"
        Panel81.Padding = New Padding(10)
        Panel81.Size = New Size(453, 535)
        Panel81.TabIndex = 36
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.DetectUrls = False
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Font = New Font("Segoe UI", 12F)
        RichTextBox1.ForeColor = Color.DarkGray
        RichTextBox1.Location = New Point(10, 10)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox1.Size = New Size(433, 515)
        RichTextBox1.TabIndex = 12
        RichTextBox1.Text = ""
        ' 
        ' Label74
        ' 
        Label74.Dock = DockStyle.Top
        Label74.Font = New Font("Segoe UI", 13F)
        Label74.Location = New Point(10, 10)
        Label74.Name = "Label74"
        Label74.Size = New Size(453, 35)
        Label74.TabIndex = 37
        Label74.Text = "Actual Command Line"
        Label74.Tag = "Label.ActualCommandLine"
        Label74.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel70
        ' 
        Panel70.Controls.Add(UiButtonCopyRealTimeCommand)
        Panel70.Dock = DockStyle.Bottom
        Panel70.Location = New Point(10, 580)
        Panel70.Name = "Panel70"
        Panel70.Padding = New Padding(0, 15, 0, 0)
        Panel70.Size = New Size(453, 50)
        Panel70.TabIndex = 38
        ' 
        ' UiButtonCopyRealTimeCommand
        ' 
        UiButtonCopyRealTimeCommand.Dock = DockStyle.Fill
        UiButtonCopyRealTimeCommand.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCopyRealTimeCommand.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCopyRealTimeCommand.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonCopyRealTimeCommand.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCopyRealTimeCommand.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonCopyRealTimeCommand.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonCopyRealTimeCommand.Font = New Font("Segoe UI", 10F)
        UiButtonCopyRealTimeCommand.ForeColor = Color.Silver
        UiButtonCopyRealTimeCommand.ForeDisableColor = Color.Silver
        UiButtonCopyRealTimeCommand.ForeHoverColor = Color.Silver
        UiButtonCopyRealTimeCommand.ForePressColor = Color.Silver
        UiButtonCopyRealTimeCommand.ForeSelectedColor = Color.Silver
        UiButtonCopyRealTimeCommand.Location = New Point(0, 15)
        UiButtonCopyRealTimeCommand.MinimumSize = New Size(1, 1)
        UiButtonCopyRealTimeCommand.Name = "UiButtonCopyRealTimeCommand"
        UiButtonCopyRealTimeCommand.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonCopyRealTimeCommand.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCopyRealTimeCommand.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCopyRealTimeCommand.RectHoverColor = Color.DarkGray
        UiButtonCopyRealTimeCommand.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonCopyRealTimeCommand.RectSelectedColor = Color.DarkGray
        UiButtonCopyRealTimeCommand.Size = New Size(453, 35)
        UiButtonCopyRealTimeCommand.TabIndex = 84
        UiButtonCopyRealTimeCommand.Text = "Copy Command Line"
        UiButtonCopyRealTimeCommand.Tag = "Button.CopyCommandLine"
        UiButtonCopyRealTimeCommand.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Panel72
        ' 
        Panel72.Controls.Add(Panel73)
        Panel72.Controls.Add(Label17)
        Panel72.Dock = DockStyle.Left
        Panel72.Location = New Point(0, 0)
        Panel72.Name = "Panel72"
        Panel72.Padding = New Padding(20, 10, 10, 20)
        Panel72.Size = New Size(416, 650)
        Panel72.TabIndex = 38
        ' 
        ' Panel73
        ' 
        Panel73.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel73.Controls.Add(RichTextBox2)
        Panel73.Dock = DockStyle.Fill
        Panel73.Location = New Point(20, 45)
        Panel73.Name = "Panel73"
        Panel73.Padding = New Padding(10)
        Panel73.Size = New Size(386, 585)
        Panel73.TabIndex = 36
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.DetectUrls = False
        RichTextBox2.Dock = DockStyle.Fill
        RichTextBox2.Font = New Font("Segoe UI", 12F)
        RichTextBox2.ForeColor = Color.DarkGray
        RichTextBox2.Location = New Point(10, 10)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox2.Size = New Size(366, 565)
        RichTextBox2.TabIndex = 11
        RichTextBox2.Text = ""
        ' 
        ' Label17
        ' 
        Label17.Dock = DockStyle.Top
        Label17.Font = New Font("Segoe UI", 13F)
        Label17.Location = New Point(20, 10)
        Label17.Name = "Label17"
        Label17.Size = New Size(386, 35)
        Label17.TabIndex = 37
        Label17.Text = "ParametersOverview"
        Label17.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TabPageOutputFileSettings
        ' 
        TabPageOutputFileSettings.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageOutputFileSettings.Controls.Add(Panel71)
        TabPageOutputFileSettings.Controls.Add(Label128)
        TabPageOutputFileSettings.Controls.Add(Label127)
        TabPageOutputFileSettings.Controls.Add(Panel7)
        TabPageOutputFileSettings.Controls.Add(Panel6)
        TabPageOutputFileSettings.Controls.Add(Panel5)
        TabPageOutputFileSettings.Controls.Add(Panel8)
        TabPageOutputFileSettings.Controls.Add(Panel1)
        TabPageOutputFileSettings.Controls.Add(Label3)
        TabPageOutputFileSettings.Controls.Add(Panel80)
        TabPageOutputFileSettings.Controls.Add(Panel3)
        TabPageOutputFileSettings.Controls.Add(Panel79)
        TabPageOutputFileSettings.Controls.Add(Label76)
        TabPageOutputFileSettings.Controls.Add(Label155)
        TabPageOutputFileSettings.Location = New Point(201, 0)
        TabPageOutputFileSettings.Name = "TabPageOutputFileSettings"
        TabPageOutputFileSettings.Size = New Size(899, 650)
        TabPageOutputFileSettings.TabIndex = 1
        TabPageOutputFileSettings.Tag = "TabPage.OutputFileSettings"
        TabPageOutputFileSettings.Text = "OutputFileSettings"
        ' 
        ' Panel71
        ' 
        Panel71.Controls.Add(UiCheckBoxPreserveAccessTime)
        Panel71.Controls.Add(UiCheckBoxPreserveModificationTime)
        Panel71.Controls.Add(UiCheckBoxPreserveCreationTime)
        Panel71.Dock = DockStyle.Top
        Panel71.Location = New Point(0, 458)
        Panel71.Name = "Panel71"
        Panel71.Padding = New Padding(18, 5, 20, 0)
        Panel71.Size = New Size(899, 35)
        Panel71.TabIndex = 17
        ' 
        ' UiCheckBoxPreserveAccessTime
        ' 
        UiCheckBoxPreserveAccessTime.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveAccessTime.CheckBoxSize = 20
        UiCheckBoxPreserveAccessTime.Dock = DockStyle.Left
        UiCheckBoxPreserveAccessTime.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveAccessTime.Text = "Preserve Access Time"
        ' 
        ' UiCheckBoxPreserveModificationTime
        ' 
        UiCheckBoxPreserveModificationTime.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveModificationTime.CheckBoxSize = 20
        UiCheckBoxPreserveModificationTime.Dock = DockStyle.Left
        UiCheckBoxPreserveModificationTime.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveModificationTime.ForeColor = Color.DarkGray
        UiCheckBoxPreserveModificationTime.Location = New Point(178, 5)
        UiCheckBoxPreserveModificationTime.MinimumSize = New Size(1, 1)
        UiCheckBoxPreserveModificationTime.Name = "UiCheckBoxPreserveModificationTime"
        UiCheckBoxPreserveModificationTime.Size = New Size(160, 30)
        UiCheckBoxPreserveModificationTime.TabIndex = 100
        UiCheckBoxPreserveModificationTime.Text = "Preserve Modification Time"
        ' 
        ' UiCheckBoxPreserveCreationTime
        ' 
        UiCheckBoxPreserveCreationTime.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveCreationTime.CheckBoxSize = 20
        UiCheckBoxPreserveCreationTime.Dock = DockStyle.Left
        UiCheckBoxPreserveCreationTime.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveCreationTime.ForeColor = Color.DarkGray
        UiCheckBoxPreserveCreationTime.Location = New Point(18, 5)
        UiCheckBoxPreserveCreationTime.MinimumSize = New Size(1, 1)
        UiCheckBoxPreserveCreationTime.Name = "UiCheckBoxPreserveCreationTime"
        UiCheckBoxPreserveCreationTime.Size = New Size(160, 30)
        UiCheckBoxPreserveCreationTime.TabIndex = 99
        UiCheckBoxPreserveCreationTime.Text = "Preserve Creation Time"
        ' 
        ' Label128
        ' 
        Label128.AutoSize = True
        Label128.Dock = DockStyle.Top
        Label128.Font = New Font("Segoe UI", 10F)
        Label128.ForeColor = Color.Gray
        Label128.Location = New Point(0, 433)
        Label128.Name = "Label128"
        Label128.Padding = New Padding(16, 5, 0, 0)
        Label128.Size = New Size(385, 25)
        Label128.TabIndex = 18
        Label128.Text = "These functions are processed by 3FUI at the end of the task, unrelated to ffmpeg."
        ' 
        ' Label127
        ' 
        Label127.AutoSize = True
        Label127.Dock = DockStyle.Top
        Label127.Font = New Font("Segoe UI", 13F)
        Label127.Location = New Point(0, 389)
        Label127.Name = "Label127"
        Label127.Padding = New Padding(16, 20, 0, 0)
        Label127.Size = New Size(98, 44)
        Label127.TabIndex = 16
        Label127.Text = "File Time"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(UiTextBoxSuffixText)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 349)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(20, 10, 20, 0)
        Panel7.Size = New Size(899, 40)
        Panel7.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Left
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(370, 10)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(10, 0, 0, 0)
        Label6.Size = New Size(120, 30)
        Label6.TabIndex = 0
        Label6.Text = "Suffix Characters"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSuffixText
        ' 
        UiTextBoxSuffixText.Dock = DockStyle.Left
        UiTextBoxSuffixText.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSuffixText.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuffixText.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxSuffixText.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxSuffixText.Font = New Font("Segoe UI", 10F)
        UiTextBoxSuffixText.ForeColor = Color.DarkGray
        UiTextBoxSuffixText.ForeDisableColor = Color.DarkGray
        UiTextBoxSuffixText.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxSuffixText.Location = New Point(20, 10)
        UiTextBoxSuffixText.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSuffixText.MinimumSize = New Size(1, 16)
        UiTextBoxSuffixText.Name = "UiTextBoxSuffixText"
        UiTextBoxSuffixText.Padding = New Padding(5)
        UiTextBoxSuffixText.Radius = 30
        UiTextBoxSuffixText.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuffixText.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuffixText.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxSuffixText.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxSuffixText.ScrollBarColor = Color.DimGray
        UiTextBoxSuffixText.ScrollBarStyleInherited = False
        UiTextBoxSuffixText.ShowText = False
        UiTextBoxSuffixText.Size = New Size(350, 30)
        UiTextBoxSuffixText.TabIndex = 81
        UiTextBoxSuffixText.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSuffixText.Watermark = "Output File Suffix"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(UiTextBoxReplacementText)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 309)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20, 10, 20, 0)
        Panel6.Size = New Size(899, 40)
        Panel6.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(370, 10)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(10, 0, 0, 0)
        Label5.Size = New Size(120, 30)
        Label5.TabIndex = 0
        Label5.Text = "Replacement Filename"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxReplacementText
        ' 
        UiTextBoxReplacementText.Dock = DockStyle.Left
        UiTextBoxReplacementText.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxReplacementText.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxReplacementText.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxReplacementText.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxReplacementText.Font = New Font("Segoe UI", 10F)
        UiTextBoxReplacementText.ForeColor = Color.DarkGray
        UiTextBoxReplacementText.ForeDisableColor = Color.DarkGray
        UiTextBoxReplacementText.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxReplacementText.Location = New Point(20, 10)
        UiTextBoxReplacementText.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxReplacementText.MinimumSize = New Size(1, 16)
        UiTextBoxReplacementText.Name = "UiTextBoxReplacementText"
        UiTextBoxReplacementText.Padding = New Padding(5)
        UiTextBoxReplacementText.Radius = 30
        UiTextBoxReplacementText.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxReplacementText.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxReplacementText.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxReplacementText.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxReplacementText.ScrollBarColor = Color.DimGray
        UiTextBoxReplacementText.ScrollBarStyleInherited = False
        UiTextBoxReplacementText.ShowText = False
        UiTextBoxReplacementText.Size = New Size(350, 30)
        UiTextBoxReplacementText.TabIndex = 81
        UiTextBoxReplacementText.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxReplacementText.Watermark = "Do not use input filename, use this instead"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(UiTextBoxPrefixText)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 269)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20, 10, 20, 0)
        Panel5.Size = New Size(899, 40)
        Panel5.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(370, 10)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(10, 0, 0, 0)
        Label4.Size = New Size(120, 30)
        Label4.TabIndex = 0
        Label4.Text = "Prefix Characters"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxPrefixText
        ' 
        UiTextBoxPrefixText.Dock = DockStyle.Left
        UiTextBoxPrefixText.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPrefixText.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxPrefixText.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxPrefixText.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxPrefixText.Font = New Font("Segoe UI", 10F)
        UiTextBoxPrefixText.ForeColor = Color.DarkGray
        UiTextBoxPrefixText.ForeDisableColor = Color.DarkGray
        UiTextBoxPrefixText.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxPrefixText.Location = New Point(20, 10)
        UiTextBoxPrefixText.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxPrefixText.MinimumSize = New Size(1, 16)
        UiTextBoxPrefixText.Name = "UiTextBoxPrefixText"
        UiTextBoxPrefixText.Padding = New Padding(5)
        UiTextBoxPrefixText.Radius = 30
        UiTextBoxPrefixText.RectColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxPrefixText.RectDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxPrefixText.RectReadOnlyColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTextBoxPrefixText.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxPrefixText.ScrollBarColor = Color.DimGray
        UiTextBoxPrefixText.ScrollBarStyleInherited = False
        UiTextBoxPrefixText.ShowText = False
        UiTextBoxPrefixText.Size = New Size(350, 30)
        UiTextBoxPrefixText.TabIndex = 81
        UiTextBoxPrefixText.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxPrefixText.Watermark = "Output File Prefix"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label141)
        Panel8.Controls.Add(UiComboBoxAutoNamingOption)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 239)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(20, 0, 20, 0)
        Panel8.Size = New Size(899, 30)
        Panel8.TabIndex = 6
        ' 
        ' Label141
        ' 
        Label141.Dock = DockStyle.Fill
        Label141.Font = New Font("Segoe UI", 10F)
        Label141.ForeColor = Color.Gray
        Label141.Location = New Point(270, 0)
        Label141.Name = "Label141"
        Label141.Padding = New Padding(10, 0, 0, 0)
        Label141.Size = New Size(609, 30)
        Label141.TabIndex = 98
        Label141.Text = "Select Auto-Naming Method"
        Label141.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxAutoNamingOption
        ' 
        UiComboBoxAutoNamingOption.DataSource = Nothing
        UiComboBoxAutoNamingOption.Dock = DockStyle.Left
        UiComboBoxAutoNamingOption.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAutoNamingOption.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoNamingOption.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoNamingOption.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoNamingOption.Font = New Font("Segoe UI", 10F)
        UiComboBoxAutoNamingOption.ForeColor = Color.Silver
        UiComboBoxAutoNamingOption.ForeDisableColor = Color.Silver
        UiComboBoxAutoNamingOption.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoNamingOption.ItemForeColor = Color.Silver
        UiComboBoxAutoNamingOption.ItemHeight = 30
        UiComboBoxAutoNamingOption.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAutoNamingOption.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAutoNamingOption.Items.AddRange(New Object() {"Append _Timestamp (Default)", "Append ~1", "Append _3fui", "Standard Compressing (Encoder+Quality)", "Append _8-digit Random Number", "Append _16-digit Random Number", "Append _8-char Random Letter", "Append _16-char Random Letter", "Append _8-char Random Alphanumeric", "Append _16-char Random Alphanumeric"})
        UiComboBoxAutoNamingOption.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoNamingOption.ItemSelectForeColor = Color.Silver
        UiComboBoxAutoNamingOption.Location = New Point(20, 0)
        UiComboBoxAutoNamingOption.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAutoNamingOption.MaxDropDownItems = 17
        UiComboBoxAutoNamingOption.MinimumSize = New Size(63, 0)
        UiComboBoxAutoNamingOption.Name = "UiComboBoxAutoNamingOption"
        UiComboBoxAutoNamingOption.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAutoNamingOption.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAutoNamingOption.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoNamingOption.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoNamingOption.ScrollBarHandleWidth = 20
        UiComboBoxAutoNamingOption.Size = New Size(250, 30)
        UiComboBoxAutoNamingOption.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAutoNamingOption.SymbolSize = 24
        UiComboBoxAutoNamingOption.TabIndex = 97
        UiComboBoxAutoNamingOption.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAutoNamingOption.Watermark = ""
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 193)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 4, 20, 4)
        Panel1.Size = New Size(899, 46)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(80, 4)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 0, 0, 0)
        Label1.Size = New Size(799, 38)
        Label1.TabIndex = 2
        Label1.Text = "Use Auto-Naming (Disabling does not affect custom characters)"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UiSwitchUseAutoNaming)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(20, 4)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 6, 0, 6)
        Panel2.Size = New Size(60, 38)
        Panel2.TabIndex = 1
        ' 
        ' UiSwitchUseAutoNaming
        ' 
        UiSwitchUseAutoNaming.Active = True
        UiSwitchUseAutoNaming.ActiveColor = Color.OliveDrab
        UiSwitchUseAutoNaming.ActiveText = ""
        UiSwitchUseAutoNaming.ButtonColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiSwitchUseAutoNaming.Dock = DockStyle.Fill
        UiSwitchUseAutoNaming.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UiSwitchUseAutoNaming.ForeColor = Color.Silver
        UiSwitchUseAutoNaming.InActiveColor = Color.IndianRed
        UiSwitchUseAutoNaming.InActiveText = ""
        UiSwitchUseAutoNaming.Location = New Point(0, 6)
        UiSwitchUseAutoNaming.Margin = New Padding(19, 0, 0, 0)
        UiSwitchUseAutoNaming.MinimumSize = New Size(1, 1)
        UiSwitchUseAutoNaming.Name = "UiSwitchUseAutoNaming"
        UiSwitchUseAutoNaming.Size = New Size(60, 26)
        UiSwitchUseAutoNaming.Style = Sunny.UI.UIStyle.Custom
        UiSwitchUseAutoNaming.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(0, 149)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(16, 20, 0, 0)
        Label3.Size = New Size(98, 44)
        Label3.TabIndex = 2
        Label3.Text = "Naming Convention"
        ' 
        ' Panel80
        ' 
        Panel80.Controls.Add(UiComboBoxOutputDirectory)
        Panel80.Dock = DockStyle.Top
        Panel80.Location = New Point(0, 104)
        Panel80.Name = "Panel80"
        Panel80.Padding = New Padding(20, 10, 20, 0)
        Panel80.Size = New Size(899, 45)
        Panel80.TabIndex = 14
        ' 
        ' UiComboBoxOutputDirectory
        ' 
        UiComboBoxOutputDirectory.AllowDrop = True
        UiComboBoxOutputDirectory.DataSource = Nothing
        UiComboBoxOutputDirectory.Dock = DockStyle.Fill
        UiComboBoxOutputDirectory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxOutputDirectory.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDirectory.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxOutputDirectory.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxOutputDirectory.Font = New Font("Segoe UI", 10F)
        UiComboBoxOutputDirectory.ForeColor = Color.Silver
        UiComboBoxOutputDirectory.ForeDisableColor = Color.Silver
        UiComboBoxOutputDirectory.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxOutputDirectory.ItemForeColor = Color.Silver
        UiComboBoxOutputDirectory.ItemHeight = 30
        UiComboBoxOutputDirectory.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxOutputDirectory.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxOutputDirectory.Items.AddRange(New Object() {"  Output to Source Directory", "  Browse ..."})
        UiComboBoxOutputDirectory.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxOutputDirectory.ItemSelectForeColor = Color.Silver
        UiComboBoxOutputDirectory.Location = New Point(20, 10)
        UiComboBoxOutputDirectory.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxOutputDirectory.MaxDropDownItems = 17
        UiComboBoxOutputDirectory.MinimumSize = New Size(63, 0)
        UiComboBoxOutputDirectory.Name = "UiComboBoxOutputDirectory"
        UiComboBoxOutputDirectory.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxOutputDirectory.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxOutputDirectory.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxOutputDirectory.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxOutputDirectory.ScrollBarBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxOutputDirectory.ScrollBarColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxOutputDirectory.ScrollBarHandleWidth = 20
        UiComboBoxOutputDirectory.ScrollBarStyleInherited = False
        UiComboBoxOutputDirectory.Size = New Size(859, 35)
        UiComboBoxOutputDirectory.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxOutputDirectory.SymbolSize = 24
        UiComboBoxOutputDirectory.TabIndex = 93
        UiComboBoxOutputDirectory.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxOutputDirectory.Watermark = "Select Output Directory"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 600)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 0, 20, 10)
        Panel3.Size = New Size(899, 50)
        Panel3.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(80, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10, 0, 0, 0)
        Label2.Size = New Size(799, 40)
        Label2.TabIndex = 2
        Label2.Text = "Do Not Append Output File Parameters (Special use, beginners avoid)"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(UiSwitchDoNotUseOutputFileParameters)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(20, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 6, 0, 6)
        Panel4.Size = New Size(60, 40)
        Panel4.TabIndex = 1
        ' 
        ' UiSwitchDoNotUseOutputFileParameters
        ' 
        UiSwitchDoNotUseOutputFileParameters.ActiveColor = Color.IndianRed
        UiSwitchDoNotUseOutputFileParameters.ActiveText = ""
        UiSwitchDoNotUseOutputFileParameters.ButtonColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiSwitchDoNotUseOutputFileParameters.Dock = DockStyle.Fill
        UiSwitchDoNotUseOutputFileParameters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UiSwitchDoNotUseOutputFileParameters.ForeColor = Color.Silver
        UiSwitchDoNotUseOutputFileParameters.InActiveColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiSwitchDoNotUseOutputFileParameters.InActiveText = ""
        UiSwitchDoNotUseOutputFileParameters.Location = New Point(0, 6)
        UiSwitchDoNotUseOutputFileParameters.Margin = New Padding(19, 0, 0, 0)
        UiSwitchDoNotUseOutputFileParameters.MinimumSize = New Size(1, 1)
        UiSwitchDoNotUseOutputFileParameters.Name = "UiSwitchDoNotUseOutputFileParameters"
        UiSwitchDoNotUseOutputFileParameters.Size = New Size(60, 28)
        UiSwitchDoNotUseOutputFileParameters.Style = Sunny.UI.UIStyle.Custom
        UiSwitchDoNotUseOutputFileParameters.TabIndex = 50
        ' 
        ' Panel79
        ' 
        Panel79.Controls.Add(UiTextBoxOutputContainer)
        Panel79.Controls.Add(UiButtonSelectContainer)
        Panel79.Dock = DockStyle.Top
        Panel79.Location = New Point(0, 59)
        Panel79.Name = "Panel79"
        Panel79.Padding = New Padding(20, 10, 20, 0)
        Panel79.Size = New Size(899, 45)
        Panel79.TabIndex = 12
        ' 
        ' UiTextBoxOutputContainer
        ' 
        UiTextBoxOutputContainer.Dock = DockStyle.Left
        UiTextBoxOutputContainer.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputContainer.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputContainer.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputContainer.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxOutputContainer.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UiTextBoxOutputContainer.ForeColor = Color.DarkGray
        UiTextBoxOutputContainer.ForeDisableColor = Color.DarkGray
        UiTextBoxOutputContainer.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxOutputContainer.Location = New Point(100, 10)
        UiTextBoxOutputContainer.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxOutputContainer.MinimumSize = New Size(1, 16)
        UiTextBoxOutputContainer.Name = "UiTextBoxOutputContainer"
        UiTextBoxOutputContainer.Padding = New Padding(10, 5, 5, 5)
        UiTextBoxOutputContainer.Radius = 0
        UiTextBoxOutputContainer.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiTextBoxOutputContainer.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputContainer.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputContainer.RectReadOnlyColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputContainer.RectSides = ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        UiTextBoxOutputContainer.RectSize = 2
        UiTextBoxOutputContainer.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxOutputContainer.ScrollBarColor = Color.DimGray
        UiTextBoxOutputContainer.ScrollBarStyleInherited = False
        UiTextBoxOutputContainer.ShowText = False
        UiTextBoxOutputContainer.Size = New Size(180, 35)
        UiTextBoxOutputContainer.TabIndex = 92
        UiTextBoxOutputContainer.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxOutputContainer.Watermark = "Enter Output Container (Suffix)"
        UiTextBoxOutputContainer.WatermarkActiveColor = Color.DimGray
        UiTextBoxOutputContainer.WatermarkColor = Color.DimGray
        ' 
        ' UiButtonSelectContainer
        ' 
        UiButtonSelectContainer.Dock = DockStyle.Left
        UiButtonSelectContainer.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectContainer.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectContainer.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectContainer.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectContainer.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectContainer.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectContainer.Font = New Font("Segoe UI", 10F)
        UiButtonSelectContainer.ForeColor = Color.CornflowerBlue
        UiButtonSelectContainer.ForeDisableColor = Color.CornflowerBlue
        UiButtonSelectContainer.ForeHoverColor = Color.CornflowerBlue
        UiButtonSelectContainer.ForePressColor = Color.CornflowerBlue
        UiButtonSelectContainer.ForeSelectedColor = Color.CornflowerBlue
        UiButtonSelectContainer.Location = New Point(20, 10)
        UiButtonSelectContainer.MinimumSize = New Size(1, 1)
        UiButtonSelectContainer.Name = "UiButtonSelectContainer"
        UiButtonSelectContainer.Radius = 0
        UiButtonSelectContainer.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonSelectContainer.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonSelectContainer.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonSelectContainer.RectHoverColor = Color.CornflowerBlue
        UiButtonSelectContainer.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonSelectContainer.RectSelectedColor = Color.CornflowerBlue
        UiButtonSelectContainer.RectSize = 2
        UiButtonSelectContainer.Size = New Size(80, 35)
        UiButtonSelectContainer.TabIndex = 93
        UiButtonSelectContainer.Text = "Select"
        UiButtonSelectContainer.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label76
        ' 
        Label76.AutoSize = True
        Label76.Dock = DockStyle.Top
        Label76.Font = New Font("Segoe UI", 10F)
        Label76.ForeColor = Color.Gray
        Label76.Location = New Point(0, 34)
        Label76.Name = "Label76"
        Label76.Padding = New Padding(16, 5, 0, 0)
        Label76.Size = New Size(403, 25)
        Label76.TabIndex = 15
        Label76.Text = "Output Directory is not saved to Preset by default, check extra save box to include."
        ' 
        ' Label155
        ' 
        Label155.AutoSize = True
        Label155.Dock = DockStyle.Top
        Label155.Font = New Font("Segoe UI", 13F)
        Label155.Location = New Point(0, 0)
        Label155.Name = "Label155"
        Label155.Padding = New Padding(16, 10, 0, 0)
        Label155.Size = New Size(196, 34)
        Label155.TabIndex = 11
        Label155.Text = "Output Suffix && Output Directory"
        ' 
        ' TabPageDecodingSettings
        ' 
        TabPageDecodingSettings.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageDecodingSettings.Controls.Add(Panel78)
        TabPageDecodingSettings.Controls.Add(Panel12)
        TabPageDecodingSettings.Controls.Add(Label13)
        TabPageDecodingSettings.Controls.Add(Label14)
        TabPageDecodingSettings.Controls.Add(Panel11)
        TabPageDecodingSettings.Controls.Add(Label11)
        TabPageDecodingSettings.Controls.Add(Label12)
        TabPageDecodingSettings.Controls.Add(Panel10)
        TabPageDecodingSettings.Controls.Add(Label9)
        TabPageDecodingSettings.Controls.Add(Label10)
        TabPageDecodingSettings.Controls.Add(Panel9)
        TabPageDecodingSettings.Controls.Add(Label8)
        TabPageDecodingSettings.Controls.Add(Label7)
        TabPageDecodingSettings.Location = New Point(201, 0)
        TabPageDecodingSettings.Name = "TabPageDecodingSettings"
        TabPageDecodingSettings.Size = New Size(899, 650)
        TabPageDecodingSettings.TabIndex = 2
        TabPageDecodingSettings.Tag = "TabPage.DecodingSettings"
        TabPageDecodingSettings.Text = "Decoding Settings"
        ' 
        ' Panel78
        ' 
        Panel78.Controls.Add(UiTextBoxHardwareAccelerationDecodingParameters)
        Panel78.Dock = DockStyle.Top
        Panel78.Location = New Point(0, 466)
        Panel78.Name = "Panel78"
        Panel78.Padding = New Padding(21, 10, 20, 0)
        Panel78.Size = New Size(899, 40)
        Panel78.TabIndex = 18
        ' 
        ' UiTextBoxHardwareAccelerationDecodingParameters
        ' 
        UiTextBoxHardwareAccelerationDecodingParameters.Dock = DockStyle.Left
        UiTextBoxHardwareAccelerationDecodingParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxHardwareAccelerationDecodingParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxHardwareAccelerationDecodingParameters.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxHardwareAccelerationDecodingParameters.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxHardwareAccelerationDecodingParameters.Font = New Font("Segoe UI", 10F)
        UiTextBoxHardwareAccelerationDecodingParameters.ForeColor = Color.Silver
        UiTextBoxHardwareAccelerationDecodingParameters.ForeDisableColor = Color.Silver
        UiTextBoxHardwareAccelerationDecodingParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxHardwareAccelerationDecodingParameters.Location = New Point(21, 10)
        UiTextBoxHardwareAccelerationDecodingParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxHardwareAccelerationDecodingParameters.MinimumSize = New Size(1, 16)
        UiTextBoxHardwareAccelerationDecodingParameters.Name = "UiTextBoxHardwareAccelerationDecodingParameters"
        UiTextBoxHardwareAccelerationDecodingParameters.Padding = New Padding(5)
        UiTextBoxHardwareAccelerationDecodingParameters.Radius = 30
        UiTextBoxHardwareAccelerationDecodingParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxHardwareAccelerationDecodingParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxHardwareAccelerationDecodingParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxHardwareAccelerationDecodingParameters.ShowText = False
        UiTextBoxHardwareAccelerationDecodingParameters.Size = New Size(220, 30)
        UiTextBoxHardwareAccelerationDecodingParameters.TabIndex = 84
        UiTextBoxHardwareAccelerationDecodingParameters.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxHardwareAccelerationDecodingParameters.Watermark = "Parameters"
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(UiComboBoxHardwareAccelerationDecodingParamName)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 426)
        Panel12.Name = "Panel12"
        Panel12.Padding = New Padding(21, 10, 20, 0)
        Panel12.Size = New Size(899, 40)
        Panel12.TabIndex = 17
        ' 
        ' UiComboBoxHardwareAccelerationDecodingParamName
        ' 
        UiComboBoxHardwareAccelerationDecodingParamName.DataSource = Nothing
        UiComboBoxHardwareAccelerationDecodingParamName.Dock = DockStyle.Left
        UiComboBoxHardwareAccelerationDecodingParamName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxHardwareAccelerationDecodingParamName.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxHardwareAccelerationDecodingParamName.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxHardwareAccelerationDecodingParamName.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxHardwareAccelerationDecodingParamName.Font = New Font("Segoe UI", 10F)
        UiComboBoxHardwareAccelerationDecodingParamName.ForeColor = Color.Silver
        UiComboBoxHardwareAccelerationDecodingParamName.ForeDisableColor = Color.Silver
        UiComboBoxHardwareAccelerationDecodingParamName.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxHardwareAccelerationDecodingParamName.ItemForeColor = Color.Silver
        UiComboBoxHardwareAccelerationDecodingParamName.ItemHeight = 30
        UiComboBoxHardwareAccelerationDecodingParamName.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxHardwareAccelerationDecodingParamName.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxHardwareAccelerationDecodingParamName.Items.AddRange(New Object() {"", "-hwaccel_device", "-init_hw_device", "-qsv_device"})
        UiComboBoxHardwareAccelerationDecodingParamName.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxHardwareAccelerationDecodingParamName.ItemSelectForeColor = Color.Silver
        UiComboBoxHardwareAccelerationDecodingParamName.Location = New Point(21, 10)
        UiComboBoxHardwareAccelerationDecodingParamName.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxHardwareAccelerationDecodingParamName.MaxDropDownItems = 17
        UiComboBoxHardwareAccelerationDecodingParamName.MinimumSize = New Size(63, 0)
        UiComboBoxHardwareAccelerationDecodingParamName.Name = "UiComboBoxHardwareAccelerationDecodingParamName"
        UiComboBoxHardwareAccelerationDecodingParamName.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxHardwareAccelerationDecodingParamName.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxHardwareAccelerationDecodingParamName.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxHardwareAccelerationDecodingParamName.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxHardwareAccelerationDecodingParamName.ScrollBarHandleWidth = 20
        UiComboBoxHardwareAccelerationDecodingParamName.Size = New Size(220, 30)
        UiComboBoxHardwareAccelerationDecodingParamName.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxHardwareAccelerationDecodingParamName.SymbolSize = 24
        UiComboBoxHardwareAccelerationDecodingParamName.TabIndex = 88
        UiComboBoxHardwareAccelerationDecodingParamName.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxHardwareAccelerationDecodingParamName.Watermark = "Select Parameters"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Top
        Label13.Font = New Font("Segoe UI", 10F)
        Label13.ForeColor = Color.Gray
        Label13.Location = New Point(0, 401)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(16, 5, 0, 0)
        Label13.Size = New Size(403, 25)
        Label13.TabIndex = 16
        Label13.Text = "If multiple graphics cards of the same brand are installed, specify which one to use; may be ineffective."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Top
        Label14.Font = New Font("Segoe UI", 13F)
        Label14.Location = New Point(0, 357)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(16, 20, 0, 0)
        Label14.Size = New Size(170, 44)
        Label14.TabIndex = 15
        Label14.Text = "Hardware Acceleration Decoding Device"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(UiComboBoxDecodingDataFormat)
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 317)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(21, 10, 20, 0)
        Panel11.Size = New Size(899, 40)
        Panel11.TabIndex = 14
        ' 
        ' UiComboBoxDecodingDataFormat
        ' 
        UiComboBoxDecodingDataFormat.DataSource = Nothing
        UiComboBoxDecodingDataFormat.Dock = DockStyle.Left
        UiComboBoxDecodingDataFormat.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDataFormat.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDataFormat.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDataFormat.Font = New Font("Segoe UI", 10F)
        UiComboBoxDecodingDataFormat.ForeColor = Color.Silver
        UiComboBoxDecodingDataFormat.ForeDisableColor = Color.Silver
        UiComboBoxDecodingDataFormat.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDataFormat.ItemForeColor = Color.Silver
        UiComboBoxDecodingDataFormat.ItemHeight = 30
        UiComboBoxDecodingDataFormat.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxDecodingDataFormat.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxDecodingDataFormat.Items.AddRange(New Object() {"", "d3d11", "yuv420p", "nv12", "p010"})
        UiComboBoxDecodingDataFormat.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDataFormat.ItemSelectForeColor = Color.Silver
        UiComboBoxDecodingDataFormat.Location = New Point(21, 10)
        UiComboBoxDecodingDataFormat.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxDecodingDataFormat.MaxDropDownItems = 17
        UiComboBoxDecodingDataFormat.MinimumSize = New Size(63, 0)
        UiComboBoxDecodingDataFormat.Name = "UiComboBoxDecodingDataFormat"
        UiComboBoxDecodingDataFormat.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxDecodingDataFormat.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxDecodingDataFormat.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDataFormat.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDataFormat.ScrollBarHandleWidth = 20
        UiComboBoxDecodingDataFormat.Size = New Size(220, 30)
        UiComboBoxDecodingDataFormat.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxDecodingDataFormat.SymbolSize = 24
        UiComboBoxDecodingDataFormat.TabIndex = 70
        UiComboBoxDecodingDataFormat.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxDecodingDataFormat.Watermark = "-hwaccel_output_format"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.ForeColor = Color.Gray
        Label11.Location = New Point(0, 272)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(16, 5, 0, 0)
        Label11.Size = New Size(510, 45)
        Label11.TabIndex = 13
        Label11.Text = "If decoding and encoding are not the same hardware acceleration, you may need to set this parameter." & vbCrLf & "For example, Intel decoding + Nvidia encoding. CPU encoding does not need to consider this. Consider only if issues arise!"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Segoe UI", 13F)
        Label12.Location = New Point(0, 228)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(16, 20, 0, 0)
        Label12.Size = New Size(134, 44)
        Label12.TabIndex = 12
        Label12.Text = "Decoding Data Format"
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(UiTextBoxCPUDecodingThreadCount)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 188)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(21, 10, 20, 0)
        Panel10.Size = New Size(899, 40)
        Panel10.TabIndex = 11
        ' 
        ' UiTextBoxCPUDecodingThreadCount
        ' 
        UiTextBoxCPUDecodingThreadCount.Dock = DockStyle.Left
        UiTextBoxCPUDecodingThreadCount.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCPUDecodingThreadCount.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCPUDecodingThreadCount.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxCPUDecodingThreadCount.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxCPUDecodingThreadCount.Font = New Font("Segoe UI", 10F)
        UiTextBoxCPUDecodingThreadCount.ForeColor = Color.Silver
        UiTextBoxCPUDecodingThreadCount.ForeDisableColor = Color.Silver
        UiTextBoxCPUDecodingThreadCount.ForeReadOnlyColor = Color.Silver
        UiTextBoxCPUDecodingThreadCount.Location = New Point(21, 10)
        UiTextBoxCPUDecodingThreadCount.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCPUDecodingThreadCount.MinimumSize = New Size(1, 16)
        UiTextBoxCPUDecodingThreadCount.Name = "UiTextBoxCPUDecodingThreadCount"
        UiTextBoxCPUDecodingThreadCount.Padding = New Padding(5)
        UiTextBoxCPUDecodingThreadCount.Radius = 30
        UiTextBoxCPUDecodingThreadCount.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCPUDecodingThreadCount.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCPUDecodingThreadCount.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCPUDecodingThreadCount.ShowText = False
        UiTextBoxCPUDecodingThreadCount.Size = New Size(120, 30)
        UiTextBoxCPUDecodingThreadCount.TabIndex = 83
        UiTextBoxCPUDecodingThreadCount.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxCPUDecodingThreadCount.Watermark = "-threads"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Top
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(0, 163)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(16, 5, 0, 0)
        Label9.Size = New Size(425, 25)
        Label9.TabIndex = 10
        Label9.Text = "If using CPU Decoding, you can specify thread count (usually not needed)."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Top
        Label10.Font = New Font("Segoe UI", 13F)
        Label10.Location = New Point(0, 119)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(16, 20, 0, 0)
        Label10.Size = New Size(157, 44)
        Label10.TabIndex = 9
        Label10.Text = "CPU Decoding Thread Count"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(UiComboBoxDecodingDecoder)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 79)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(21, 10, 20, 0)
        Panel9.Size = New Size(899, 40)
        Panel9.TabIndex = 7
        ' 
        ' UiComboBoxDecodingDecoder
        ' 
        UiComboBoxDecodingDecoder.DataSource = Nothing
        UiComboBoxDecodingDecoder.Dock = DockStyle.Left
        UiComboBoxDecodingDecoder.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDecoder.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDecoder.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDecoder.Font = New Font("Segoe UI", 10F)
        UiComboBoxDecodingDecoder.ForeColor = Color.Silver
        UiComboBoxDecodingDecoder.ForeDisableColor = Color.Silver
        UiComboBoxDecodingDecoder.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDecodingDecoder.ItemForeColor = Color.Silver
        UiComboBoxDecodingDecoder.ItemHeight = 30
        UiComboBoxDecodingDecoder.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxDecodingDecoder.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxDecodingDecoder.Items.AddRange(New Object() {"", "auto", "cpu", "d3d11va", "d3d12va", "cuda", "amf", "qsv", "vaapi", "vulkan", "dxva2", "opencl"})
        UiComboBoxDecodingDecoder.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDecoder.ItemSelectForeColor = Color.Silver
        UiComboBoxDecodingDecoder.Location = New Point(21, 10)
        UiComboBoxDecodingDecoder.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxDecodingDecoder.MaxDropDownItems = 17
        UiComboBoxDecodingDecoder.MinimumSize = New Size(63, 0)
        UiComboBoxDecodingDecoder.Name = "UiComboBoxDecodingDecoder"
        UiComboBoxDecodingDecoder.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxDecodingDecoder.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxDecodingDecoder.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDecoder.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDecodingDecoder.ScrollBarHandleWidth = 20
        UiComboBoxDecodingDecoder.Size = New Size(220, 30)
        UiComboBoxDecodingDecoder.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxDecodingDecoder.SymbolSize = 24
        UiComboBoxDecodingDecoder.TabIndex = 87
        UiComboBoxDecodingDecoder.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxDecodingDecoder.Watermark = "-hwaccel"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Top
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(0, 34)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(16, 5, 0, 0)
        Label8.Size = New Size(445, 45)
        Label8.TabIndex = 8
        Label8.Text = "If you don't know what to set, leave it! This applies to all settings on this page!" & vbCrLf & "cuda = NVIDIA   qsv = Intel   amf = AMD"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Top
        Label7.Font = New Font("Segoe UI", 13F)
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(16, 10, 0, 0)
        Label7.Size = New Size(80, 34)
        Label7.TabIndex = 3
        Label7.Text = "Decoder"
        ' 
        ' TabPageVideoParametersEncoder
        ' 
        TabPageVideoParametersEncoder.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoParametersEncoder.Controls.Add(Panel19)
        TabPageVideoParametersEncoder.Controls.Add(Panel18)
        TabPageVideoParametersEncoder.Controls.Add(Label23)
        TabPageVideoParametersEncoder.Controls.Add(Label136)
        TabPageVideoParametersEncoder.Controls.Add(Panel17)
        TabPageVideoParametersEncoder.Controls.Add(Panel16)
        TabPageVideoParametersEncoder.Controls.Add(Panel15)
        TabPageVideoParametersEncoder.Controls.Add(Label27)
        TabPageVideoParametersEncoder.Controls.Add(Label124)
        TabPageVideoParametersEncoder.Controls.Add(Panel14)
        TabPageVideoParametersEncoder.Controls.Add(Label19)
        TabPageVideoParametersEncoder.Controls.Add(Panel13)
        TabPageVideoParametersEncoder.Controls.Add(Label16)
        TabPageVideoParametersEncoder.Controls.Add(Label20)
        TabPageVideoParametersEncoder.Location = New Point(201, 0)
        TabPageVideoParametersEncoder.Name = "TabPageVideoParametersEncoder"
        TabPageVideoParametersEncoder.Size = New Size(899, 650)
        TabPageVideoParametersEncoder.TabIndex = 3
        TabPageVideoParametersEncoder.Tag = "TabPage.VideoParametersEncoder"
        TabPageVideoParametersEncoder.Text = "Video Parameters | Encoder"
        ' 
        ' Panel19
        ' 
        Panel19.Controls.Add(Label171)
        Panel19.Controls.Add(UiTextBoxthreads)
        Panel19.Dock = DockStyle.Top
        Panel19.Location = New Point(0, 460)
        Panel19.Name = "Panel19"
        Panel19.Padding = New Padding(21, 10, 20, 0)
        Panel19.Size = New Size(899, 40)
        Panel19.TabIndex = 27
        ' 
        ' Label171
        ' 
        Label171.Dock = DockStyle.Fill
        Label171.Font = New Font("Segoe UI", 10F)
        Label171.ForeColor = Color.Gray
        Label171.Location = New Point(131, 10)
        Label171.Name = "Label171"
        Label171.Padding = New Padding(10, 0, 0, 0)
        Label171.Size = New Size(748, 30)
        Label171.TabIndex = 91
        Label171.Text = "Specify CPU Encoding Thread Count"
        Label171.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxthreads
        ' 
        UiTextBoxthreads.Dock = DockStyle.Left
        UiTextBoxthreads.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.Font = New Font("Segoe UI", 10F)
        UiTextBoxthreads.ForeColor = Color.Silver
        UiTextBoxthreads.ForeDisableColor = Color.Silver
        UiTextBoxthreads.ForeReadOnlyColor = Color.Silver
        UiTextBoxthreads.Location = New Point(21, 10)
        UiTextBoxthreads.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxthreads.MinimumSize = New Size(1, 16)
        UiTextBoxthreads.Name = "UiTextBoxthreads"
        UiTextBoxthreads.Padding = New Padding(5)
        UiTextBoxthreads.Radius = 30
        UiTextBoxthreads.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxthreads.ShowText = False
        UiTextBoxthreads.Size = New Size(110, 30)
        UiTextBoxthreads.TabIndex = 92
        UiTextBoxthreads.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxthreads.Watermark = "-threads"
        ' 
        ' Panel18
        ' 
        Panel18.Controls.Add(Label167)
        Panel18.Controls.Add(UiTextBoxgpu)
        Panel18.Dock = DockStyle.Top
        Panel18.Location = New Point(0, 420)
        Panel18.Name = "Panel18"
        Panel18.Padding = New Padding(21, 10, 20, 0)
        Panel18.Size = New Size(899, 40)
        Panel18.TabIndex = 26
        ' 
        ' Label167
        ' 
        Label167.Dock = DockStyle.Fill
        Label167.Font = New Font("Segoe UI", 10F)
        Label167.ForeColor = Color.Gray
        Label167.Location = New Point(131, 10)
        Label167.Name = "Label167"
        Label167.Padding = New Padding(10, 0, 0, 0)
        Label167.Size = New Size(748, 30)
        Label167.TabIndex = 88
        Label167.Text = "Specify card for multiple same-brand GPUs (Likely Nvidia only, others set in OS/Driver)"
        Label167.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxgpu
        ' 
        UiTextBoxgpu.Dock = DockStyle.Left
        UiTextBoxgpu.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.Font = New Font("Segoe UI", 10F)
        UiTextBoxgpu.ForeColor = Color.Silver
        UiTextBoxgpu.ForeDisableColor = Color.Silver
        UiTextBoxgpu.ForeReadOnlyColor = Color.Silver
        UiTextBoxgpu.Location = New Point(21, 10)
        UiTextBoxgpu.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxgpu.MinimumSize = New Size(1, 16)
        UiTextBoxgpu.Name = "UiTextBoxgpu"
        UiTextBoxgpu.Padding = New Padding(5)
        UiTextBoxgpu.Radius = 30
        UiTextBoxgpu.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxgpu.ShowText = False
        UiTextBoxgpu.Size = New Size(110, 30)
        UiTextBoxgpu.TabIndex = 87
        UiTextBoxgpu.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxgpu.Watermark = "-gpu"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Dock = DockStyle.Top
        Label23.Font = New Font("Segoe UI", 10F)
        Label23.ForeColor = Color.Gray
        Label23.Location = New Point(0, 384)
        Label23.Name = "Label23"
        Label23.Padding = New Padding(16, 16, 0, 0)
        Label23.Size = New Size(221, 36)
        Label23.TabIndex = 25
        Label23.Text = "Other Performance Settings, usually not needed"
        ' 
        ' Label136
        ' 
        Label136.AutoSize = True
        Label136.Dock = DockStyle.Top
        Label136.Font = New Font("Segoe UI", 10F)
        Label136.ForeColor = Color.Gray
        Label136.Location = New Point(0, 354)
        Label136.Name = "Label136"
        Label136.Padding = New Padding(16, 10, 0, 0)
        Label136.Size = New Size(375, 30)
        Label136.TabIndex = 29
        Label136.Text = "Many values for the above three parameters are not yet listed. Feedback welcome."
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(Label26)
        Panel17.Controls.Add(UiComboBoxSceneTune)
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(0, 314)
        Panel17.Name = "Panel17"
        Panel17.Padding = New Padding(21, 10, 20, 0)
        Panel17.Size = New Size(899, 40)
        Panel17.TabIndex = 23
        ' 
        ' Label26
        ' 
        Label26.Dock = DockStyle.Fill
        Label26.Font = New Font("Segoe UI", 10F)
        Label26.ForeColor = Color.Gray
        Label26.Location = New Point(196, 10)
        Label26.Name = "Label26"
        Label26.Padding = New Padding(10, 0, 0, 0)
        Label26.Size = New Size(683, 30)
        Label26.TabIndex = 92
        Label26.Text = "Scene Tune: Optimization for specific needs, usually not needed."
        Label26.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxSceneTune
        ' 
        UiComboBoxSceneTune.DataSource = Nothing
        UiComboBoxSceneTune.Dock = DockStyle.Left
        UiComboBoxSceneTune.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSceneTune.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiComboBoxSceneTune.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSceneTune.FilterIgnoreCase = True
        UiComboBoxSceneTune.Font = New Font("Segoe UI", 10F)
        UiComboBoxSceneTune.ForeColor = Color.Silver
        UiComboBoxSceneTune.ForeDisableColor = Color.Silver
        UiComboBoxSceneTune.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSceneTune.ItemForeColor = Color.Silver
        UiComboBoxSceneTune.ItemHeight = 30
        UiComboBoxSceneTune.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxSceneTune.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSceneTune.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSceneTune.ItemSelectForeColor = Color.Silver
        UiComboBoxSceneTune.Location = New Point(21, 10)
        UiComboBoxSceneTune.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxSceneTune.MaxDropDownItems = 20
        UiComboBoxSceneTune.MinimumSize = New Size(63, 0)
        UiComboBoxSceneTune.Name = "UiComboBoxSceneTune"
        UiComboBoxSceneTune.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxSceneTune.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxSceneTune.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSceneTune.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSceneTune.Size = New Size(175, 30)
        UiComboBoxSceneTune.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxSceneTune.SymbolSize = 24
        UiComboBoxSceneTune.TabIndex = 91
        UiComboBoxSceneTune.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxSceneTune.Watermark = "-tune"
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(Label24)
        Panel16.Controls.Add(UiComboBoxProfileFile)
        Panel16.Dock = DockStyle.Top
        Panel16.Location = New Point(0, 274)
        Panel16.Name = "Panel16"
        Panel16.Padding = New Padding(21, 10, 20, 0)
        Panel16.Size = New Size(899, 40)
        Panel16.TabIndex = 20
        ' 
        ' Label24
        ' 
        Label24.Dock = DockStyle.Fill
        Label24.Font = New Font("Segoe UI", 10F)
        Label24.ForeColor = Color.Gray
        Label24.Location = New Point(196, 10)
        Label24.Name = "Label24"
        Label24.Padding = New Padding(10, 0, 0, 0)
        Label24.Size = New Size(683, 30)
        Label24.TabIndex = 89
        Label24.Text = "Profile: Supported technical specs and features, usually not needed."
        Label24.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxProfileFile
        ' 
        UiComboBoxProfileFile.DataSource = Nothing
        UiComboBoxProfileFile.Dock = DockStyle.Left
        UiComboBoxProfileFile.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxProfileFile.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxProfileFile.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxProfileFile.Font = New Font("Segoe UI", 10F)
        UiComboBoxProfileFile.ForeColor = Color.Silver
        UiComboBoxProfileFile.ForeDisableColor = Color.Silver
        UiComboBoxProfileFile.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxProfileFile.ItemForeColor = Color.Silver
        UiComboBoxProfileFile.ItemHeight = 30
        UiComboBoxProfileFile.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxProfileFile.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxProfileFile.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxProfileFile.ItemSelectForeColor = Color.Silver
        UiComboBoxProfileFile.Location = New Point(21, 10)
        UiComboBoxProfileFile.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxProfileFile.MaxDropDownItems = 20
        UiComboBoxProfileFile.MinimumSize = New Size(63, 0)
        UiComboBoxProfileFile.Name = "UiComboBoxProfileFile"
        UiComboBoxProfileFile.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxProfileFile.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxProfileFile.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxProfileFile.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxProfileFile.ScrollBarHandleWidth = 20
        UiComboBoxProfileFile.Size = New Size(175, 30)
        UiComboBoxProfileFile.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxProfileFile.SymbolSize = 24
        UiComboBoxProfileFile.TabIndex = 88
        UiComboBoxProfileFile.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxProfileFile.Watermark = "-profile"
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(Label22)
        Panel15.Controls.Add(UiComboBoxEncoderPreset)
        Panel15.Dock = DockStyle.Top
        Panel15.Location = New Point(0, 234)
        Panel15.Name = "Panel15"
        Panel15.Padding = New Padding(21, 10, 20, 0)
        Panel15.Size = New Size(899, 40)
        Panel15.TabIndex = 17
        ' 
        ' Label22
        ' 
        Label22.Dock = DockStyle.Fill
        Label22.Font = New Font("Segoe UI", 10F)
        Label22.ForeColor = Color.Gray
        Label22.Location = New Point(196, 10)
        Label22.Name = "Label22"
        Label22.Padding = New Padding(10, 0, 0, 0)
        Label22.Size = New Size(683, 30)
        Label22.TabIndex = 88
        Label22.Text = "Encoder Preset: Balance compression vs speed; higher is slower, lower is faster."
        Label22.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxEncoderPreset
        ' 
        UiComboBoxEncoderPreset.DataSource = Nothing
        UiComboBoxEncoderPreset.Dock = DockStyle.Left
        UiComboBoxEncoderPreset.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderPreset.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderPreset.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderPreset.Font = New Font("Segoe UI", 10F)
        UiComboBoxEncoderPreset.ForeColor = Color.Silver
        UiComboBoxEncoderPreset.ForeDisableColor = Color.Silver
        UiComboBoxEncoderPreset.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderPreset.ItemForeColor = Color.Silver
        UiComboBoxEncoderPreset.ItemHeight = 30
        UiComboBoxEncoderPreset.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxEncoderPreset.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxEncoderPreset.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderPreset.ItemSelectForeColor = Color.Silver
        UiComboBoxEncoderPreset.Location = New Point(21, 10)
        UiComboBoxEncoderPreset.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxEncoderPreset.MaxDropDownItems = 17
        UiComboBoxEncoderPreset.MinimumSize = New Size(63, 0)
        UiComboBoxEncoderPreset.Name = "UiComboBoxEncoderPreset"
        UiComboBoxEncoderPreset.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxEncoderPreset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxEncoderPreset.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderPreset.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderPreset.ScrollBarHandleWidth = 20
        UiComboBoxEncoderPreset.Size = New Size(175, 30)
        UiComboBoxEncoderPreset.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxEncoderPreset.SymbolSize = 24
        UiComboBoxEncoderPreset.TabIndex = 87
        UiComboBoxEncoderPreset.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxEncoderPreset.Watermark = "-preset"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Dock = DockStyle.Top
        Label27.Font = New Font("Segoe UI", 10F)
        Label27.ForeColor = Color.Gray
        Label27.Location = New Point(0, 204)
        Label27.Name = "Label27"
        Label27.Padding = New Padding(16, 10, 0, 0)
        Label27.Size = New Size(473, 30)
        Label27.TabIndex = 28
        Label27.Text = "Video Encoder General Config (Parameter names vary by encoder, auto-adjusted)"
        ' 
        ' Label124
        ' 
        Label124.AutoSize = True
        Label124.Dock = DockStyle.Top
        Label124.Font = New Font("Segoe UI", 10F)
        Label124.ForeColor = Color.IndianRed
        Label124.Location = New Point(0, 174)
        Label124.Name = "Label124"
        Label124.Padding = New Padding(16, 10, 0, 0)
        Label124.Size = New Size(296, 30)
        Label124.TabIndex = 30
        Label124.Text = "Note: Selected encoder not included in standard FFmpeg builds."
        Label124.Visible = False
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(Label21)
        Panel14.Controls.Add(UiComboBoxSpecificEncoder)
        Panel14.Dock = DockStyle.Top
        Panel14.Location = New Point(0, 134)
        Panel14.Name = "Panel14"
        Panel14.Padding = New Padding(21, 10, 20, 0)
        Panel14.Size = New Size(899, 40)
        Panel14.TabIndex = 14
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Fill
        Label21.Font = New Font("Segoe UI", 10F)
        Label21.ForeColor = Color.Gray
        Label21.Location = New Point(196, 10)
        Label21.Name = "Label21"
        Label21.Padding = New Padding(10, 0, 0, 0)
        Label21.Size = New Size(683, 30)
        Label21.TabIndex = 95
        Label21.Text = "lib = CPU   nvenc = NVIDIA   qsv = Intel   amf = AMD"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxSpecificEncoder
        ' 
        UiComboBoxSpecificEncoder.DataSource = Nothing
        UiComboBoxSpecificEncoder.Dock = DockStyle.Left
        UiComboBoxSpecificEncoder.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxSpecificEncoder.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSpecificEncoder.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSpecificEncoder.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSpecificEncoder.Font = New Font("Segoe UI", 10F)
        UiComboBoxSpecificEncoder.ForeColor = Color.Silver
        UiComboBoxSpecificEncoder.ForeDisableColor = Color.Silver
        UiComboBoxSpecificEncoder.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSpecificEncoder.ItemForeColor = Color.Silver
        UiComboBoxSpecificEncoder.ItemHeight = 30
        UiComboBoxSpecificEncoder.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxSpecificEncoder.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSpecificEncoder.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSpecificEncoder.ItemSelectForeColor = Color.Silver
        UiComboBoxSpecificEncoder.Location = New Point(21, 10)
        UiComboBoxSpecificEncoder.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxSpecificEncoder.MaxDropDownItems = 17
        UiComboBoxSpecificEncoder.MinimumSize = New Size(63, 0)
        UiComboBoxSpecificEncoder.Name = "UiComboBoxSpecificEncoder"
        UiComboBoxSpecificEncoder.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxSpecificEncoder.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxSpecificEncoder.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSpecificEncoder.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSpecificEncoder.ScrollBarHandleWidth = 20
        UiComboBoxSpecificEncoder.Size = New Size(175, 30)
        UiComboBoxSpecificEncoder.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxSpecificEncoder.SymbolSize = 24
        UiComboBoxSpecificEncoder.TabIndex = 94
        UiComboBoxSpecificEncoder.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxSpecificEncoder.Watermark = "Specific Encoder -c:v"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Top
        Label19.Font = New Font("Segoe UI", 10F)
        Label19.ForeColor = Color.Gray
        Label19.Location = New Point(0, 104)
        Label19.Name = "Label19"
        Label19.Padding = New Padding(16, 10, 0, 0)
        Label19.Size = New Size(375, 30)
        Label19.TabIndex = 13
        Label19.Text = "Categories above are for selection helper, this is the actual encoder name."
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(UiComboBoxEncoderCategory)
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 64)
        Panel13.Name = "Panel13"
        Panel13.Padding = New Padding(21, 10, 20, 0)
        Panel13.Size = New Size(899, 40)
        Panel13.TabIndex = 11
        ' 
        ' UiComboBoxEncoderCategory
        ' 
        UiComboBoxEncoderCategory.DataSource = Nothing
        UiComboBoxEncoderCategory.Dock = DockStyle.Left
        UiComboBoxEncoderCategory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxEncoderCategory.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderCategory.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderCategory.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderCategory.Font = New Font("Segoe UI", 10F)
        UiComboBoxEncoderCategory.ForeColor = Color.Silver
        UiComboBoxEncoderCategory.ForeDisableColor = Color.Silver
        UiComboBoxEncoderCategory.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxEncoderCategory.ItemForeColor = Color.Silver
        UiComboBoxEncoderCategory.ItemHeight = 30
        UiComboBoxEncoderCategory.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxEncoderCategory.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxEncoderCategory.Items.AddRange(New Object() {"", "Copy Stream", "H.266/VVC", "AV1", "H.265/HEVC", "H.264/AVC", "From Apple", "From Google", "FFV1", "Other Modern Encoders", "Legacy Encoders", "Disable", "Custom Item"})
        UiComboBoxEncoderCategory.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderCategory.ItemSelectForeColor = Color.Silver
        UiComboBoxEncoderCategory.Location = New Point(21, 10)
        UiComboBoxEncoderCategory.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxEncoderCategory.MaxDropDownItems = 17
        UiComboBoxEncoderCategory.MinimumSize = New Size(63, 0)
        UiComboBoxEncoderCategory.Name = "UiComboBoxEncoderCategory"
        UiComboBoxEncoderCategory.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxEncoderCategory.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxEncoderCategory.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderCategory.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxEncoderCategory.ScrollBarHandleWidth = 20
        UiComboBoxEncoderCategory.Size = New Size(175, 30)
        UiComboBoxEncoderCategory.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxEncoderCategory.SymbolSize = 24
        UiComboBoxEncoderCategory.TabIndex = 91
        UiComboBoxEncoderCategory.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxEncoderCategory.Watermark = "Select Category"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Top
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.ForeColor = Color.Gray
        Label16.Location = New Point(0, 34)
        Label16.Name = "Label16"
        Label16.Padding = New Padding(16, 10, 0, 0)
        Label16.Size = New Size(361, 30)
        Label16.TabIndex = 10
        Label16.Text = "Select category first, then specific encoder. Use config file to add custom."
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Dock = DockStyle.Top
        Label20.Font = New Font("Segoe UI", 13F)
        Label20.Location = New Point(0, 0)
        Label20.Name = "Label20"
        Label20.Padding = New Padding(16, 10, 0, 0)
        Label20.Size = New Size(116, 34)
        Label20.TabIndex = 12
        Label20.Text = "Video Encoder"
        ' 
        ' TabPageVideoParametersFrame
        ' 
        TabPageVideoParametersFrame.AutoScroll = True
        TabPageVideoParametersFrame.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoParametersFrame.Controls.Add(Panel96)
        TabPageVideoParametersFrame.Controls.Add(Label68)
        TabPageVideoParametersFrame.Controls.Add(Label170)
        TabPageVideoParametersFrame.Controls.Add(Panel23)
        TabPageVideoParametersFrame.Controls.Add(Label37)
        TabPageVideoParametersFrame.Controls.Add(Label38)
        TabPageVideoParametersFrame.Controls.Add(Panel22)
        TabPageVideoParametersFrame.Controls.Add(Label33)
        TabPageVideoParametersFrame.Controls.Add(Label34)
        TabPageVideoParametersFrame.Controls.Add(Panel21)
        TabPageVideoParametersFrame.Controls.Add(Label31)
        TabPageVideoParametersFrame.Controls.Add(Panel20)
        TabPageVideoParametersFrame.Controls.Add(Label28)
        TabPageVideoParametersFrame.Controls.Add(Label29)
        TabPageVideoParametersFrame.Location = New Point(201, 0)
        TabPageVideoParametersFrame.Name = "TabPageVideoParametersFrame"
        TabPageVideoParametersFrame.Size = New Size(899, 650)
        TabPageVideoParametersFrame.TabIndex = 4
        TabPageVideoParametersFrame.Tag = "TabPage.VideoParametersFrame"
        TabPageVideoParametersFrame.Text = "Video Parameters | Frame"
        ' 
        ' Panel96
        ' 
        Panel96.Controls.Add(UiButtonBurnSubtitles)
        Panel96.Dock = DockStyle.Top
        Panel96.Location = New Point(0, 456)
        Panel96.Name = "Panel96"
        Panel96.Padding = New Padding(21, 10, 20, 0)
        Panel96.Size = New Size(899, 40)
        Panel96.TabIndex = 25
        ' 
        ' UiButtonBurnSubtitles
        ' 
        UiButtonBurnSubtitles.Dock = DockStyle.Left
        UiButtonBurnSubtitles.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonBurnSubtitles.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonBurnSubtitles.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonBurnSubtitles.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonBurnSubtitles.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonBurnSubtitles.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonBurnSubtitles.Font = New Font("Segoe UI", 10F)
        UiButtonBurnSubtitles.ForeColor = Color.Silver
        UiButtonBurnSubtitles.ForeDisableColor = Color.Silver
        UiButtonBurnSubtitles.ForeHoverColor = Color.Silver
        UiButtonBurnSubtitles.ForePressColor = Color.Silver
        UiButtonBurnSubtitles.ForeSelectedColor = Color.Silver
        UiButtonBurnSubtitles.Location = New Point(21, 10)
        UiButtonBurnSubtitles.MinimumSize = New Size(1, 1)
        UiButtonBurnSubtitles.Name = "UiButtonBurnSubtitles"
        UiButtonBurnSubtitles.Radius = 30
        UiButtonBurnSubtitles.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonBurnSubtitles.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonBurnSubtitles.RectHoverColor = Color.DarkGray
        UiButtonBurnSubtitles.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonBurnSubtitles.RectSelectedColor = Color.DarkGray
        UiButtonBurnSubtitles.Size = New Size(175, 30)
        UiButtonBurnSubtitles.TabIndex = 84
        UiButtonBurnSubtitles.Text = "Burn Subtitles Window"
        UiButtonBurnSubtitles.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label68
        ' 
        Label68.AutoSize = True
        Label68.Dock = DockStyle.Top
        Label68.Font = New Font("Segoe UI", 10F)
        Label68.ForeColor = Color.Gray
        Label68.Location = New Point(0, 431)
        Label68.Name = "Label68"
        Label68.Padding = New Padding(16, 5, 0, 0)
        Label68.Size = New Size(165, 25)
        Label68.TabIndex = 26
        Label68.Text = "More Video Effects Coming Soon"
        ' 
        ' Label170
        ' 
        Label170.AutoSize = True
        Label170.Dock = DockStyle.Top
        Label170.Font = New Font("Segoe UI", 13F)
        Label170.Location = New Point(0, 387)
        Label170.Name = "Label170"
        Label170.Padding = New Padding(16, 20, 0, 0)
        Label170.Size = New Size(62, 44)
        Label170.TabIndex = 23
        Label170.Text = "More"
        ' 
        ' Panel23
        ' 
        Panel23.Controls.Add(UiButtonOpenSuperResolutionParametersWindow)
        Panel23.Controls.Add(Label82)
        Panel23.Controls.Add(UiButtonOpenMotionBlurParametersWindow)
        Panel23.Controls.Add(Label145)
        Panel23.Controls.Add(UiButtonOpenFrameInterpolationParametersWindow)
        Panel23.Dock = DockStyle.Top
        Panel23.Location = New Point(0, 347)
        Panel23.Name = "Panel23"
        Panel23.Padding = New Padding(21, 10, 20, 0)
        Panel23.Size = New Size(899, 40)
        Panel23.TabIndex = 22
        ' 
        ' UiButtonOpenSuperResolutionParametersWindow
        ' 
        UiButtonOpenSuperResolutionParametersWindow.Dock = DockStyle.Left
        UiButtonOpenSuperResolutionParametersWindow.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenSuperResolutionParametersWindow.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenSuperResolutionParametersWindow.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonOpenSuperResolutionParametersWindow.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenSuperResolutionParametersWindow.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonOpenSuperResolutionParametersWindow.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonOpenSuperResolutionParametersWindow.Font = New Font("Segoe UI", 10F)
        UiButtonOpenSuperResolutionParametersWindow.ForeColor = Color.Silver
        UiButtonOpenSuperResolutionParametersWindow.ForeDisableColor = Color.Silver
        UiButtonOpenSuperResolutionParametersWindow.ForeHoverColor = Color.Silver
        UiButtonOpenSuperResolutionParametersWindow.ForePressColor = Color.Silver
        UiButtonOpenSuperResolutionParametersWindow.ForeSelectedColor = Color.Silver
        UiButtonOpenSuperResolutionParametersWindow.Location = New Point(391, 10)
        UiButtonOpenSuperResolutionParametersWindow.MinimumSize = New Size(1, 1)
        UiButtonOpenSuperResolutionParametersWindow.Name = "UiButtonOpenSuperResolutionParametersWindow"
        UiButtonOpenSuperResolutionParametersWindow.Radius = 30
        UiButtonOpenSuperResolutionParametersWindow.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenSuperResolutionParametersWindow.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenSuperResolutionParametersWindow.RectHoverColor = Color.DarkGray
        UiButtonOpenSuperResolutionParametersWindow.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonOpenSuperResolutionParametersWindow.RectSelectedColor = Color.DarkGray
        UiButtonOpenSuperResolutionParametersWindow.Size = New Size(175, 30)
        UiButtonOpenSuperResolutionParametersWindow.TabIndex = 88
        UiButtonOpenSuperResolutionParametersWindow.Text = "Super Resolution Window"
        UiButtonOpenSuperResolutionParametersWindow.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label82
        ' 
        Label82.Dock = DockStyle.Left
        Label82.Location = New Point(381, 10)
        Label82.Name = "Label82"
        Label82.Size = New Size(10, 30)
        Label82.TabIndex = 87
        Label82.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonOpenMotionBlurParametersWindow
        ' 
        UiButtonOpenMotionBlurParametersWindow.Dock = DockStyle.Left
        UiButtonOpenMotionBlurParametersWindow.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenMotionBlurParametersWindow.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenMotionBlurParametersWindow.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonOpenMotionBlurParametersWindow.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenMotionBlurParametersWindow.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonOpenMotionBlurParametersWindow.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonOpenMotionBlurParametersWindow.Font = New Font("Segoe UI", 10F)
        UiButtonOpenMotionBlurParametersWindow.ForeColor = Color.Silver
        UiButtonOpenMotionBlurParametersWindow.ForeDisableColor = Color.Silver
        UiButtonOpenMotionBlurParametersWindow.ForeHoverColor = Color.Silver
        UiButtonOpenMotionBlurParametersWindow.ForePressColor = Color.Silver
        UiButtonOpenMotionBlurParametersWindow.ForeSelectedColor = Color.Silver
        UiButtonOpenMotionBlurParametersWindow.Location = New Point(206, 10)
        UiButtonOpenMotionBlurParametersWindow.MinimumSize = New Size(1, 1)
        UiButtonOpenMotionBlurParametersWindow.Name = "UiButtonOpenMotionBlurParametersWindow"
        UiButtonOpenMotionBlurParametersWindow.Radius = 30
        UiButtonOpenMotionBlurParametersWindow.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenMotionBlurParametersWindow.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenMotionBlurParametersWindow.RectHoverColor = Color.DarkGray
        UiButtonOpenMotionBlurParametersWindow.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonOpenMotionBlurParametersWindow.RectSelectedColor = Color.DarkGray
        UiButtonOpenMotionBlurParametersWindow.Size = New Size(175, 30)
        UiButtonOpenMotionBlurParametersWindow.TabIndex = 86
        UiButtonOpenMotionBlurParametersWindow.Text = "Frame Blending Window"
        UiButtonOpenMotionBlurParametersWindow.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label145
        ' 
        Label145.Dock = DockStyle.Left
        Label145.Location = New Point(196, 10)
        Label145.Name = "Label145"
        Label145.Size = New Size(10, 30)
        Label145.TabIndex = 85
        Label145.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButtonOpenFrameInterpolationParametersWindow
        ' 
        UiButtonOpenFrameInterpolationParametersWindow.Dock = DockStyle.Left
        UiButtonOpenFrameInterpolationParametersWindow.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFrameInterpolationParametersWindow.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFrameInterpolationParametersWindow.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonOpenFrameInterpolationParametersWindow.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFrameInterpolationParametersWindow.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonOpenFrameInterpolationParametersWindow.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonOpenFrameInterpolationParametersWindow.Font = New Font("Segoe UI", 10F)
        UiButtonOpenFrameInterpolationParametersWindow.ForeColor = Color.Silver
        UiButtonOpenFrameInterpolationParametersWindow.ForeDisableColor = Color.Silver
        UiButtonOpenFrameInterpolationParametersWindow.ForeHoverColor = Color.Silver
        UiButtonOpenFrameInterpolationParametersWindow.ForePressColor = Color.Silver
        UiButtonOpenFrameInterpolationParametersWindow.ForeSelectedColor = Color.Silver
        UiButtonOpenFrameInterpolationParametersWindow.Location = New Point(21, 10)
        UiButtonOpenFrameInterpolationParametersWindow.MinimumSize = New Size(1, 1)
        UiButtonOpenFrameInterpolationParametersWindow.Name = "UiButtonOpenFrameInterpolationParametersWindow"
        UiButtonOpenFrameInterpolationParametersWindow.Radius = 30
        UiButtonOpenFrameInterpolationParametersWindow.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFrameInterpolationParametersWindow.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonOpenFrameInterpolationParametersWindow.RectHoverColor = Color.DarkGray
        UiButtonOpenFrameInterpolationParametersWindow.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonOpenFrameInterpolationParametersWindow.RectSelectedColor = Color.DarkGray
        UiButtonOpenFrameInterpolationParametersWindow.Size = New Size(175, 30)
        UiButtonOpenFrameInterpolationParametersWindow.TabIndex = 84
        UiButtonOpenFrameInterpolationParametersWindow.Text = "Frame Interpolation Window"
        UiButtonOpenFrameInterpolationParametersWindow.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Dock = DockStyle.Top
        Label37.Font = New Font("Segoe UI", 10F)
        Label37.ForeColor = Color.Gray
        Label37.Location = New Point(0, 322)
        Label37.Name = "Label37"
        Label37.Padding = New Padding(16, 5, 0, 0)
        Label37.Size = New Size(249, 25)
        Label37.TabIndex = 21
        Label37.Text = "Mediocre quality, suggested for temporary use only"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Dock = DockStyle.Top
        Label38.Font = New Font("Segoe UI", 13F)
        Label38.Location = New Point(0, 278)
        Label38.Name = "Label38"
        Label38.Padding = New Padding(16, 20, 0, 0)
        Label38.Size = New Size(186, 44)
        Label38.TabIndex = 20
        Label38.Text = "Interpolation && Blending && Super Resolution"
        ' 
        ' Panel22
        ' 
        Panel22.Controls.Add(Label39)
        Panel22.Controls.Add(UiTextBoxFrameMaxChangeRatio)
        Panel22.Controls.Add(Label36)
        Panel22.Controls.Add(UiComboBoxFrameRate)
        Panel22.Dock = DockStyle.Top
        Panel22.Location = New Point(0, 238)
        Panel22.Name = "Panel22"
        Panel22.Padding = New Padding(21, 10, 20, 0)
        Panel22.Size = New Size(899, 40)
        Panel22.TabIndex = 19
        ' 
        ' Label39
        ' 
        Label39.Dock = DockStyle.Fill
        Label39.Font = New Font("Segoe UI", 10F)
        Label39.ForeColor = Color.Gray
        Label39.Location = New Point(481, 10)
        Label39.Name = "Label39"
        Label39.Padding = New Padding(10, 0, 0, 0)
        Label39.Size = New Size(398, 30)
        Label39.TabIndex = 93
        Label39.Text = "0~1, 0.01 = 1%, min 0.01"
        Label39.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxFrameMaxChangeRatio
        ' 
        UiTextBoxFrameMaxChangeRatio.Dock = DockStyle.Left
        UiTextBoxFrameMaxChangeRatio.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.Font = New Font("Segoe UI", 10F)
        UiTextBoxFrameMaxChangeRatio.ForeColor = Color.Silver
        UiTextBoxFrameMaxChangeRatio.ForeDisableColor = Color.Silver
        UiTextBoxFrameMaxChangeRatio.ForeReadOnlyColor = Color.Silver
        UiTextBoxFrameMaxChangeRatio.Location = New Point(396, 10)
        UiTextBoxFrameMaxChangeRatio.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxFrameMaxChangeRatio.MinimumSize = New Size(1, 16)
        UiTextBoxFrameMaxChangeRatio.Name = "UiTextBoxFrameMaxChangeRatio"
        UiTextBoxFrameMaxChangeRatio.Padding = New Padding(5)
        UiTextBoxFrameMaxChangeRatio.Radius = 30
        UiTextBoxFrameMaxChangeRatio.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFrameMaxChangeRatio.ShowText = False
        UiTextBoxFrameMaxChangeRatio.Size = New Size(85, 30)
        UiTextBoxFrameMaxChangeRatio.TabIndex = 92
        UiTextBoxFrameMaxChangeRatio.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxFrameMaxChangeRatio.Watermark = "0.?"
        ' 
        ' Label36
        ' 
        Label36.Dock = DockStyle.Left
        Label36.Font = New Font("Segoe UI", 10F)
        Label36.ForeColor = Color.Gray
        Label36.Location = New Point(196, 10)
        Label36.Name = "Label36"
        Label36.Size = New Size(200, 30)
        Label36.TabIndex = 91
        Label36.Text = "Decimate if change below:"
        Label36.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiComboBoxFrameRate
        ' 
        UiComboBoxFrameRate.DataSource = Nothing
        UiComboBoxFrameRate.Dock = DockStyle.Left
        UiComboBoxFrameRate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameRate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameRate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameRate.Font = New Font("Segoe UI", 10F)
        UiComboBoxFrameRate.ForeColor = Color.Silver
        UiComboBoxFrameRate.ForeDisableColor = Color.Silver
        UiComboBoxFrameRate.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxFrameRate.ItemForeColor = Color.Silver
        UiComboBoxFrameRate.ItemHeight = 30
        UiComboBoxFrameRate.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxFrameRate.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxFrameRate.Items.AddRange(New Object() {"23.976", "24", "25", "29.97", "30", "50", "59.94", "60", "120"})
        UiComboBoxFrameRate.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameRate.ItemSelectForeColor = Color.Silver
        UiComboBoxFrameRate.Location = New Point(21, 10)
        UiComboBoxFrameRate.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxFrameRate.MaxDropDownItems = 17
        UiComboBoxFrameRate.MinimumSize = New Size(63, 0)
        UiComboBoxFrameRate.Name = "UiComboBoxFrameRate"
        UiComboBoxFrameRate.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxFrameRate.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxFrameRate.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameRate.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxFrameRate.ScrollBarHandleWidth = 20
        UiComboBoxFrameRate.Size = New Size(175, 30)
        UiComboBoxFrameRate.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxFrameRate.SymbolSize = 24
        UiComboBoxFrameRate.TabIndex = 68
        UiComboBoxFrameRate.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxFrameRate.Watermark = " -r"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Dock = DockStyle.Top
        Label33.Font = New Font("Segoe UI", 10F)
        Label33.ForeColor = Color.Gray
        Label33.Location = New Point(0, 213)
        Label33.Name = "Label33"
        Label33.Padding = New Padding(16, 5, 0, 0)
        Label33.Size = New Size(515, 25)
        Label33.TabIndex = 18
        Label33.Text = "Specify Frame Rate (Fixed); Decimation (Variable); Do not use decimation if using external subtitles!" & vbCrLf
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Dock = DockStyle.Top
        Label34.Font = New Font("Segoe UI", 13F)
        Label34.Location = New Point(0, 169)
        Label34.Name = "Label34"
        Label34.Padding = New Padding(16, 20, 0, 0)
        Label34.Size = New Size(62, 44)
        Label34.TabIndex = 17
        Label34.Text = "Frame Rate"
        ' 
        ' Panel21
        ' 
        Panel21.Controls.Add(UiTextBoxCropFilterParameters)
        Panel21.Controls.Add(Label137)
        Panel21.Controls.Add(UiButtonCropWindow)
        Panel21.Dock = DockStyle.Top
        Panel21.Location = New Point(0, 129)
        Panel21.Name = "Panel21"
        Panel21.Padding = New Padding(21, 10, 20, 0)
        Panel21.Size = New Size(899, 40)
        Panel21.TabIndex = 16
        ' 
        ' UiTextBoxCropFilterParameters
        ' 
        UiTextBoxCropFilterParameters.Dock = DockStyle.Left
        UiTextBoxCropFilterParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.Font = New Font("Segoe UI", 10F)
        UiTextBoxCropFilterParameters.ForeColor = Color.Silver
        UiTextBoxCropFilterParameters.ForeDisableColor = Color.Silver
        UiTextBoxCropFilterParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxCropFilterParameters.Location = New Point(206, 10)
        UiTextBoxCropFilterParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCropFilterParameters.MinimumSize = New Size(1, 16)
        UiTextBoxCropFilterParameters.Name = "UiTextBoxCropFilterParameters"
        UiTextBoxCropFilterParameters.Padding = New Padding(5)
        UiTextBoxCropFilterParameters.Radius = 30
        UiTextBoxCropFilterParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCropFilterParameters.ShowText = False
        UiTextBoxCropFilterParameters.Size = New Size(175, 30)
        UiTextBoxCropFilterParameters.TabIndex = 81
        UiTextBoxCropFilterParameters.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxCropFilterParameters.Watermark = "-crop"
        ' 
        ' Label137
        ' 
        Label137.Dock = DockStyle.Left
        Label137.ForeColor = Color.Gray
        Label137.Location = New Point(196, 10)
        Label137.Name = "Label137"
        Label137.Padding = New Padding(10, 0, 0, 0)
        Label137.Size = New Size(10, 30)
        Label137.TabIndex = 82
        Label137.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButtonCropWindow
        ' 
        UiButtonCropWindow.Dock = DockStyle.Left
        UiButtonCropWindow.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCropWindow.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCropWindow.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonCropWindow.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCropWindow.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonCropWindow.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonCropWindow.Font = New Font("Segoe UI", 10F)
        UiButtonCropWindow.ForeColor = Color.Silver
        UiButtonCropWindow.ForeDisableColor = Color.Silver
        UiButtonCropWindow.ForeHoverColor = Color.Silver
        UiButtonCropWindow.ForePressColor = Color.Silver
        UiButtonCropWindow.ForeSelectedColor = Color.Silver
        UiButtonCropWindow.Location = New Point(21, 10)
        UiButtonCropWindow.MinimumSize = New Size(1, 1)
        UiButtonCropWindow.Name = "UiButtonCropWindow"
        UiButtonCropWindow.Radius = 30
        UiButtonCropWindow.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCropWindow.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonCropWindow.RectHoverColor = Color.DarkGray
        UiButtonCropWindow.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonCropWindow.RectSelectedColor = Color.DarkGray
        UiButtonCropWindow.Size = New Size(175, 30)
        UiButtonCropWindow.TabIndex = 83
        UiButtonCropWindow.Text = "Crop Window"
        UiButtonCropWindow.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Dock = DockStyle.Top
        Label31.Font = New Font("Segoe UI", 10F)
        Label31.ForeColor = Color.Gray
        Label31.Location = New Point(0, 99)
        Label31.Name = "Label31"
        Label31.Padding = New Padding(16, 10, 0, 0)
        Label31.Size = New Size(403, 30)
        Label31.TabIndex = 15
        Label31.Text = "Crop can be used with auto-calculated resolution; cropping happens before scaling."
        ' 
        ' Panel20
        ' 
        Panel20.Controls.Add(UiTextBoxResolutionAutoHeight)
        Panel20.Controls.Add(Label35)
        Panel20.Controls.Add(UiTextBoxResolutionAutoWidth)
        Panel20.Controls.Add(Label30)
        Panel20.Controls.Add(UiComboBoxResolution)
        Panel20.Dock = DockStyle.Top
        Panel20.Location = New Point(0, 59)
        Panel20.Name = "Panel20"
        Panel20.Padding = New Padding(21, 10, 20, 0)
        Panel20.Size = New Size(899, 40)
        Panel20.TabIndex = 13
        ' 
        ' UiTextBoxResolutionAutoHeight
        ' 
        UiTextBoxResolutionAutoHeight.Dock = DockStyle.Left
        UiTextBoxResolutionAutoHeight.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.Font = New Font("Segoe UI", 10F)
        UiTextBoxResolutionAutoHeight.ForeColor = Color.Silver
        UiTextBoxResolutionAutoHeight.ForeDisableColor = Color.Silver
        UiTextBoxResolutionAutoHeight.ForeReadOnlyColor = Color.Silver
        UiTextBoxResolutionAutoHeight.Location = New Point(481, 10)
        UiTextBoxResolutionAutoHeight.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxResolutionAutoHeight.MinimumSize = New Size(1, 16)
        UiTextBoxResolutionAutoHeight.Name = "UiTextBoxResolutionAutoHeight"
        UiTextBoxResolutionAutoHeight.Padding = New Padding(5)
        UiTextBoxResolutionAutoHeight.Radius = 30
        UiTextBoxResolutionAutoHeight.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoHeight.ShowText = False
        UiTextBoxResolutionAutoHeight.Size = New Size(81, 30)
        UiTextBoxResolutionAutoHeight.TabIndex = 94
        UiTextBoxResolutionAutoHeight.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxResolutionAutoHeight.Watermark = "Height"
        ' 
        ' Label35
        ' 
        Label35.Dock = DockStyle.Left
        Label35.Location = New Point(472, 10)
        Label35.Name = "Label35"
        Label35.Size = New Size(9, 30)
        Label35.TabIndex = 93
        Label35.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UiTextBoxResolutionAutoWidth
        ' 
        UiTextBoxResolutionAutoWidth.Dock = DockStyle.Left
        UiTextBoxResolutionAutoWidth.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.Font = New Font("Segoe UI", 10F)
        UiTextBoxResolutionAutoWidth.ForeColor = Color.Silver
        UiTextBoxResolutionAutoWidth.ForeDisableColor = Color.Silver
        UiTextBoxResolutionAutoWidth.ForeReadOnlyColor = Color.Silver
        UiTextBoxResolutionAutoWidth.Location = New Point(391, 10)
        UiTextBoxResolutionAutoWidth.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxResolutionAutoWidth.MinimumSize = New Size(1, 16)
        UiTextBoxResolutionAutoWidth.Name = "UiTextBoxResolutionAutoWidth"
        UiTextBoxResolutionAutoWidth.Padding = New Padding(5)
        UiTextBoxResolutionAutoWidth.Radius = 30
        UiTextBoxResolutionAutoWidth.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxResolutionAutoWidth.ShowText = False
        UiTextBoxResolutionAutoWidth.Size = New Size(81, 30)
        UiTextBoxResolutionAutoWidth.TabIndex = 92
        UiTextBoxResolutionAutoWidth.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxResolutionAutoWidth.Watermark = "Width"
        ' 
        ' Label30
        ' 
        Label30.Dock = DockStyle.Left
        Label30.Font = New Font("Segoe UI", 10F)
        Label30.ForeColor = Color.Gray
        Label30.Location = New Point(196, 10)
        Label30.Name = "Label30"
        Label30.Size = New Size(195, 30)
        Label30.TabIndex = 90
        Label30.Text = "Auto-calculate if one is given:"
        Label30.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiComboBoxResolution
        ' 
        UiComboBoxResolution.DataSource = Nothing
        UiComboBoxResolution.Dock = DockStyle.Left
        UiComboBoxResolution.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxResolution.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxResolution.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxResolution.Font = New Font("Segoe UI", 10F)
        UiComboBoxResolution.ForeColor = Color.Silver
        UiComboBoxResolution.ForeDisableColor = Color.Silver
        UiComboBoxResolution.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxResolution.ItemForeColor = Color.Silver
        UiComboBoxResolution.ItemHeight = 30
        UiComboBoxResolution.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxResolution.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxResolution.Items.AddRange(New Object() {"1280x720", "1600x900", "1920x1080", "2560x1440", "3840x2160", "7680x4320"})
        UiComboBoxResolution.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxResolution.ItemSelectForeColor = Color.Silver
        UiComboBoxResolution.Location = New Point(21, 10)
        UiComboBoxResolution.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxResolution.MaxDropDownItems = 17
        UiComboBoxResolution.MinimumSize = New Size(63, 0)
        UiComboBoxResolution.Name = "UiComboBoxResolution"
        UiComboBoxResolution.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxResolution.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxResolution.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxResolution.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxResolution.ScrollBarHandleWidth = 20
        UiComboBoxResolution.Size = New Size(175, 30)
        UiComboBoxResolution.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxResolution.SymbolSize = 24
        UiComboBoxResolution.TabIndex = 91
        UiComboBoxResolution.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxResolution.Watermark = "-s"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Dock = DockStyle.Top
        Label28.Font = New Font("Segoe UI", 10F)
        Label28.ForeColor = Color.Gray
        Label28.Location = New Point(0, 34)
        Label28.Name = "Label28"
        Label28.Padding = New Padding(16, 5, 0, 0)
        Label28.Size = New Size(459, 25)
        Label28.TabIndex = 12
        Label28.Text = "Specify Width and Height. Auto-calculate recommended. Processed in filter."
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Dock = DockStyle.Top
        Label29.Font = New Font("Segoe UI", 13F)
        Label29.Location = New Point(0, 0)
        Label29.Name = "Label29"
        Label29.Padding = New Padding(16, 10, 0, 0)
        Label29.Size = New Size(80, 34)
        Label29.TabIndex = 11
        Label29.Text = "Resolution"
        ' 
        ' TabPageVideoParametersQuality
        ' 
        TabPageVideoParametersQuality.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoParametersQuality.Controls.Add(FlowLayoutPanel1)
        TabPageVideoParametersQuality.Controls.Add(Panel26)
        TabPageVideoParametersQuality.Controls.Add(Label49)
        TabPageVideoParametersQuality.Controls.Add(Label54)
        TabPageVideoParametersQuality.Controls.Add(Panel25)
        TabPageVideoParametersQuality.Controls.Add(Panel30)
        TabPageVideoParametersQuality.Controls.Add(Label44)
        TabPageVideoParametersQuality.Controls.Add(Label45)
        TabPageVideoParametersQuality.Controls.Add(Panel24)
        TabPageVideoParametersQuality.Controls.Add(Label40)
        TabPageVideoParametersQuality.Controls.Add(Label41)
        TabPageVideoParametersQuality.Location = New Point(201, 0)
        TabPageVideoParametersQuality.Name = "TabPageVideoParametersQuality"
        TabPageVideoParametersQuality.Size = New Size(899, 650)
        TabPageVideoParametersQuality.TabIndex = 5
        TabPageVideoParametersQuality.Tag = "TabPage.VideoParametersQuality"
        TabPageVideoParametersQuality.Text = "Video Parameters | Quality"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 382)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(21, 20, 20, 20)
        FlowLayoutPanel1.Size = New Size(899, 268)
        FlowLayoutPanel1.TabIndex = 25
        ' 
        ' Panel26
        ' 
        Panel26.Controls.Add(Label56)
        Panel26.Controls.Add(UiButtonClearAllAdvancedQualityControl)
        Panel26.Controls.Add(Label18)
        Panel26.Controls.Add(UiButtonAddAdvancedQualityControlEmpty)
        Panel26.Controls.Add(Label55)
        Panel26.Controls.Add(UiButtonAddAdvancedQualityControlPreset)
        Panel26.Dock = DockStyle.Top
        Panel26.Location = New Point(0, 342)
        Panel26.Name = "Panel26"
        Panel26.Padding = New Padding(21, 10, 20, 0)
        Panel26.Size = New Size(899, 40)
        Panel26.TabIndex = 24
        ' 
        ' Label56
        ' 
        Label56.Dock = DockStyle.Fill
        Label56.Font = New Font("Segoe UI", 10F)
        Label56.ForeColor = Color.Gray
        Label56.Location = New Point(431, 10)
        Label56.Name = "Label56"
        Label56.Padding = New Padding(10, 0, 0, 0)
        Label56.Size = New Size(448, 30)
        Label56.TabIndex = 97
        Label56.Text = "Use F3 and F4 to reorder quickly"
        Label56.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButtonClearAllAdvancedQualityControl
        ' 
        UiButtonClearAllAdvancedQualityControl.Dock = DockStyle.Left
        UiButtonClearAllAdvancedQualityControl.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonClearAllAdvancedQualityControl.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonClearAllAdvancedQualityControl.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonClearAllAdvancedQualityControl.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonClearAllAdvancedQualityControl.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonClearAllAdvancedQualityControl.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonClearAllAdvancedQualityControl.Font = New Font("Segoe UI", 10F)
        UiButtonClearAllAdvancedQualityControl.ForeColor = Color.Silver
        UiButtonClearAllAdvancedQualityControl.ForeDisableColor = Color.Silver
        UiButtonClearAllAdvancedQualityControl.ForeHoverColor = Color.Silver
        UiButtonClearAllAdvancedQualityControl.ForePressColor = Color.Silver
        UiButtonClearAllAdvancedQualityControl.ForeSelectedColor = Color.Silver
        UiButtonClearAllAdvancedQualityControl.Location = New Point(301, 10)
        UiButtonClearAllAdvancedQualityControl.MinimumSize = New Size(1, 1)
        UiButtonClearAllAdvancedQualityControl.Name = "UiButtonClearAllAdvancedQualityControl"
        UiButtonClearAllAdvancedQualityControl.Radius = 30
        UiButtonClearAllAdvancedQualityControl.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonClearAllAdvancedQualityControl.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonClearAllAdvancedQualityControl.RectHoverColor = Color.DarkGray
        UiButtonClearAllAdvancedQualityControl.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonClearAllAdvancedQualityControl.RectSelectedColor = Color.DarkGray
        UiButtonClearAllAdvancedQualityControl.Size = New Size(130, 30)
        UiButtonClearAllAdvancedQualityControl.TabIndex = 96
        UiButtonClearAllAdvancedQualityControl.Text = "Clear All"
        UiButtonClearAllAdvancedQualityControl.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Location = New Point(291, 10)
        Label18.Name = "Label18"
        Label18.Size = New Size(10, 30)
        Label18.TabIndex = 92
        ' 
        ' UiButtonAddAdvancedQualityControlEmpty
        ' 
        UiButtonAddAdvancedQualityControlEmpty.Dock = DockStyle.Left
        UiButtonAddAdvancedQualityControlEmpty.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlEmpty.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlEmpty.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddAdvancedQualityControlEmpty.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlEmpty.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddAdvancedQualityControlEmpty.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddAdvancedQualityControlEmpty.Font = New Font("Segoe UI", 10F)
        UiButtonAddAdvancedQualityControlEmpty.ForeColor = Color.Silver
        UiButtonAddAdvancedQualityControlEmpty.ForeDisableColor = Color.Silver
        UiButtonAddAdvancedQualityControlEmpty.ForeHoverColor = Color.Silver
        UiButtonAddAdvancedQualityControlEmpty.ForePressColor = Color.Silver
        UiButtonAddAdvancedQualityControlEmpty.ForeSelectedColor = Color.Silver
        UiButtonAddAdvancedQualityControlEmpty.Location = New Point(161, 10)
        UiButtonAddAdvancedQualityControlEmpty.MinimumSize = New Size(1, 1)
        UiButtonAddAdvancedQualityControlEmpty.Name = "UiButtonAddAdvancedQualityControlEmpty"
        UiButtonAddAdvancedQualityControlEmpty.Radius = 30
        UiButtonAddAdvancedQualityControlEmpty.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlEmpty.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlEmpty.RectHoverColor = Color.DarkGray
        UiButtonAddAdvancedQualityControlEmpty.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddAdvancedQualityControlEmpty.RectSelectedColor = Color.DarkGray
        UiButtonAddAdvancedQualityControlEmpty.Size = New Size(130, 30)
        UiButtonAddAdvancedQualityControlEmpty.TabIndex = 95
        UiButtonAddAdvancedQualityControlEmpty.Text = "Add Empty Item"
        UiButtonAddAdvancedQualityControlEmpty.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label55
        ' 
        Label55.Dock = DockStyle.Left
        Label55.Location = New Point(151, 10)
        Label55.Name = "Label55"
        Label55.Size = New Size(10, 30)
        Label55.TabIndex = 94
        ' 
        ' UiButtonAddAdvancedQualityControlPreset
        ' 
        UiButtonAddAdvancedQualityControlPreset.Dock = DockStyle.Left
        UiButtonAddAdvancedQualityControlPreset.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlPreset.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlPreset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonAddAdvancedQualityControlPreset.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlPreset.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonAddAdvancedQualityControlPreset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonAddAdvancedQualityControlPreset.Font = New Font("Segoe UI", 10F)
        UiButtonAddAdvancedQualityControlPreset.ForeColor = Color.Silver
        UiButtonAddAdvancedQualityControlPreset.ForeDisableColor = Color.Silver
        UiButtonAddAdvancedQualityControlPreset.ForeHoverColor = Color.Silver
        UiButtonAddAdvancedQualityControlPreset.ForePressColor = Color.Silver
        UiButtonAddAdvancedQualityControlPreset.ForeSelectedColor = Color.Silver
        UiButtonAddAdvancedQualityControlPreset.Location = New Point(21, 10)
        UiButtonAddAdvancedQualityControlPreset.MinimumSize = New Size(1, 1)
        UiButtonAddAdvancedQualityControlPreset.Name = "UiButtonAddAdvancedQualityControlPreset"
        UiButtonAddAdvancedQualityControlPreset.Radius = 30
        UiButtonAddAdvancedQualityControlPreset.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlPreset.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonAddAdvancedQualityControlPreset.RectHoverColor = Color.DarkGray
        UiButtonAddAdvancedQualityControlPreset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonAddAdvancedQualityControlPreset.RectSelectedColor = Color.DarkGray
        UiButtonAddAdvancedQualityControlPreset.Size = New Size(130, 30)
        UiButtonAddAdvancedQualityControlPreset.TabIndex = 84
        UiButtonAddAdvancedQualityControlPreset.Text = "Add Preset Item"
        UiButtonAddAdvancedQualityControlPreset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Dock = DockStyle.Top
        Label49.Font = New Font("Segoe UI", 10F)
        Label49.ForeColor = Color.Gray
        Label49.Location = New Point(0, 317)
        Label49.Name = "Label49"
        Label49.Padding = New Padding(16, 5, 0, 0)
        Label49.Size = New Size(445, 25)
        Label49.TabIndex = 23
        Label49.Text = "Add preset or empty item then edit parameters; Internal encoder params go in Custom Parameters."
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Dock = DockStyle.Top
        Label54.Font = New Font("Segoe UI", 13F)
        Label54.Location = New Point(0, 273)
        Label54.Name = "Label54"
        Label54.Padding = New Padding(16, 20, 0, 0)
        Label54.Size = New Size(134, 44)
        Label54.TabIndex = 22
        Label54.Text = "Advanced Quality Control"
        ' 
        ' Panel25
        ' 
        Panel25.Controls.Add(UiTextBoxBitrateBufferSize)
        Panel25.Controls.Add(Label46)
        Panel25.Controls.Add(UiTextBoxMaxBitrate)
        Panel25.Controls.Add(Label47)
        Panel25.Controls.Add(UiTextBoxMinBitrate)
        Panel25.Controls.Add(Label48)
        Panel25.Controls.Add(UiTextBoxBaseBitrate)
        Panel25.Dock = DockStyle.Top
        Panel25.Location = New Point(0, 243)
        Panel25.Name = "Panel25"
        Panel25.Padding = New Padding(21, 0, 20, 0)
        Panel25.Size = New Size(899, 30)
        Panel25.TabIndex = 20
        ' 
        ' UiTextBoxBitrateBufferSize
        ' 
        UiTextBoxBitrateBufferSize.Dock = DockStyle.Left
        UiTextBoxBitrateBufferSize.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.Font = New Font("Segoe UI", 10F)
        UiTextBoxBitrateBufferSize.ForeColor = Color.Silver
        UiTextBoxBitrateBufferSize.ForeDisableColor = Color.Silver
        UiTextBoxBitrateBufferSize.ForeReadOnlyColor = Color.Silver
        UiTextBoxBitrateBufferSize.Location = New Point(441, 0)
        UiTextBoxBitrateBufferSize.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxBitrateBufferSize.MinimumSize = New Size(1, 16)
        UiTextBoxBitrateBufferSize.Name = "UiTextBoxBitrateBufferSize"
        UiTextBoxBitrateBufferSize.Padding = New Padding(5)
        UiTextBoxBitrateBufferSize.Radius = 30
        UiTextBoxBitrateBufferSize.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBitrateBufferSize.ShowText = False
        UiTextBoxBitrateBufferSize.Size = New Size(130, 30)
        UiTextBoxBitrateBufferSize.TabIndex = 93
        UiTextBoxBitrateBufferSize.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxBitrateBufferSize.Watermark = "-bufsize"
        UiTextBoxBitrateBufferSize.WatermarkActiveColor = Color.DimGray
        UiTextBoxBitrateBufferSize.WatermarkColor = Color.DimGray
        ' 
        ' Label46
        ' 
        Label46.Dock = DockStyle.Left
        Label46.Location = New Point(431, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(10, 30)
        Label46.TabIndex = 92
        ' 
        ' UiTextBoxMaxBitrate
        ' 
        UiTextBoxMaxBitrate.Dock = DockStyle.Left
        UiTextBoxMaxBitrate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.Font = New Font("Segoe UI", 10F)
        UiTextBoxMaxBitrate.ForeColor = Color.Silver
        UiTextBoxMaxBitrate.ForeDisableColor = Color.Silver
        UiTextBoxMaxBitrate.ForeReadOnlyColor = Color.Silver
        UiTextBoxMaxBitrate.Location = New Point(301, 0)
        UiTextBoxMaxBitrate.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxMaxBitrate.MinimumSize = New Size(1, 16)
        UiTextBoxMaxBitrate.Name = "UiTextBoxMaxBitrate"
        UiTextBoxMaxBitrate.Padding = New Padding(5)
        UiTextBoxMaxBitrate.Radius = 30
        UiTextBoxMaxBitrate.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMaxBitrate.ShowText = False
        UiTextBoxMaxBitrate.Size = New Size(130, 30)
        UiTextBoxMaxBitrate.TabIndex = 91
        UiTextBoxMaxBitrate.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxMaxBitrate.Watermark = "-maxrate"
        UiTextBoxMaxBitrate.WatermarkActiveColor = Color.DimGray
        UiTextBoxMaxBitrate.WatermarkColor = Color.DimGray
        ' 
        ' Label47
        ' 
        Label47.Dock = DockStyle.Left
        Label47.Location = New Point(291, 0)
        Label47.Name = "Label47"
        Label47.Size = New Size(10, 30)
        Label47.TabIndex = 90
        ' 
        ' UiTextBoxMinBitrate
        ' 
        UiTextBoxMinBitrate.Dock = DockStyle.Left
        UiTextBoxMinBitrate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.Font = New Font("Segoe UI", 10F)
        UiTextBoxMinBitrate.ForeColor = Color.Silver
        UiTextBoxMinBitrate.ForeDisableColor = Color.Silver
        UiTextBoxMinBitrate.ForeReadOnlyColor = Color.Silver
        UiTextBoxMinBitrate.Location = New Point(161, 0)
        UiTextBoxMinBitrate.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxMinBitrate.MinimumSize = New Size(1, 16)
        UiTextBoxMinBitrate.Name = "UiTextBoxMinBitrate"
        UiTextBoxMinBitrate.Padding = New Padding(5)
        UiTextBoxMinBitrate.Radius = 30
        UiTextBoxMinBitrate.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxMinBitrate.ShowText = False
        UiTextBoxMinBitrate.Size = New Size(130, 30)
        UiTextBoxMinBitrate.TabIndex = 89
        UiTextBoxMinBitrate.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxMinBitrate.Watermark = "-minrate"
        UiTextBoxMinBitrate.WatermarkActiveColor = Color.DimGray
        UiTextBoxMinBitrate.WatermarkColor = Color.DimGray
        ' 
        ' Label48
        ' 
        Label48.Dock = DockStyle.Left
        Label48.Location = New Point(151, 0)
        Label48.Name = "Label48"
        Label48.Size = New Size(10, 30)
        Label48.TabIndex = 88
        ' 
        ' UiTextBoxBaseBitrate
        ' 
        UiTextBoxBaseBitrate.Dock = DockStyle.Left
        UiTextBoxBaseBitrate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.Font = New Font("Segoe UI", 10F)
        UiTextBoxBaseBitrate.ForeColor = Color.Silver
        UiTextBoxBaseBitrate.ForeDisableColor = Color.Silver
        UiTextBoxBaseBitrate.ForeReadOnlyColor = Color.Silver
        UiTextBoxBaseBitrate.Location = New Point(21, 0)
        UiTextBoxBaseBitrate.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxBaseBitrate.MinimumSize = New Size(1, 16)
        UiTextBoxBaseBitrate.Name = "UiTextBoxBaseBitrate"
        UiTextBoxBaseBitrate.Padding = New Padding(5)
        UiTextBoxBaseBitrate.Radius = 30
        UiTextBoxBaseBitrate.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxBaseBitrate.ShowText = False
        UiTextBoxBaseBitrate.Size = New Size(130, 30)
        UiTextBoxBaseBitrate.TabIndex = 87
        UiTextBoxBaseBitrate.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxBaseBitrate.Watermark = "-b:v"
        UiTextBoxBaseBitrate.WatermarkActiveColor = Color.DimGray
        UiTextBoxBaseBitrate.WatermarkColor = Color.DimGray
        ' 
        ' Panel30
        ' 
        Panel30.Controls.Add(Label50)
        Panel30.Controls.Add(Label51)
        Panel30.Controls.Add(Label52)
        Panel30.Controls.Add(Label53)
        Panel30.Dock = DockStyle.Top
        Panel30.Location = New Point(0, 208)
        Panel30.Name = "Panel30"
        Panel30.Padding = New Padding(17, 0, 10, 0)
        Panel30.Size = New Size(899, 35)
        Panel30.TabIndex = 21
        ' 
        ' Label50
        ' 
        Label50.Dock = DockStyle.Left
        Label50.Font = New Font("Segoe UI", 9.75F)
        Label50.Location = New Point(437, 0)
        Label50.Name = "Label50"
        Label50.Size = New Size(100, 35)
        Label50.TabIndex = 82
        Label50.Text = "Buffer"
        Label50.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label51
        ' 
        Label51.Dock = DockStyle.Left
        Label51.Font = New Font("Segoe UI", 9.75F)
        Label51.Location = New Point(297, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(140, 35)
        Label51.TabIndex = 81
        Label51.Text = "Max Bitrate"
        Label51.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label52
        ' 
        Label52.Dock = DockStyle.Left
        Label52.Font = New Font("Segoe UI", 9.75F)
        Label52.Location = New Point(157, 0)
        Label52.Name = "Label52"
        Label52.Size = New Size(140, 35)
        Label52.TabIndex = 80
        Label52.Text = "Min Bitrate"
        Label52.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label53
        ' 
        Label53.Dock = DockStyle.Left
        Label53.Font = New Font("Segoe UI", 9.75F)
        Label53.Location = New Point(17, 0)
        Label53.Name = "Label53"
        Label53.Size = New Size(140, 35)
        Label53.TabIndex = 78
        Label53.Text = "Base Bitrate"
        Label53.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Dock = DockStyle.Top
        Label44.Font = New Font("Segoe UI", 10F)
        Label44.ForeColor = Color.Gray
        Label44.Location = New Point(0, 163)
        Label44.Name = "Label44"
        Label44.Padding = New Padding(16, 5, 0, 0)
        Label44.Size = New Size(445, 45)
        Label44.TabIndex = 19
        Label44.Text = "Traditional transcoding sets bitrate directly; usually not for compression work." & vbCrLf & "Remember units (e.g., 5000k, 5m); Base Bitrate conflicts with Global Quality Control."
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Dock = DockStyle.Top
        Label45.Font = New Font("Segoe UI", 13F)
        Label45.Location = New Point(0, 119)
        Label45.Name = "Label45"
        Label45.Padding = New Padding(16, 20, 0, 0)
        Label45.Size = New Size(80, 44)
        Label45.TabIndex = 18
        Label45.Text = "Bitrate"
        ' 
        ' Panel24
        ' 
        Panel24.Controls.Add(UiTextBoxGlobalQualityControlValue)
        Panel24.Controls.Add(Label42)
        Panel24.Controls.Add(UiComboBoxGlobalQualityControlParameters)
        Panel24.Controls.Add(Label43)
        Panel24.Controls.Add(UiComboBoxGlobalQualityControlMethod)
        Panel24.Dock = DockStyle.Top
        Panel24.Location = New Point(0, 79)
        Panel24.Name = "Panel24"
        Panel24.Padding = New Padding(21, 10, 20, 0)
        Panel24.Size = New Size(899, 40)
        Panel24.TabIndex = 17
        ' 
        ' UiTextBoxGlobalQualityControlValue
        ' 
        UiTextBoxGlobalQualityControlValue.Dock = DockStyle.Left
        UiTextBoxGlobalQualityControlValue.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.Font = New Font("Segoe UI", 10F)
        UiTextBoxGlobalQualityControlValue.ForeColor = Color.Silver
        UiTextBoxGlobalQualityControlValue.ForeDisableColor = Color.Silver
        UiTextBoxGlobalQualityControlValue.ForeReadOnlyColor = Color.Silver
        UiTextBoxGlobalQualityControlValue.Location = New Point(471, 10)
        UiTextBoxGlobalQualityControlValue.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxGlobalQualityControlValue.MinimumSize = New Size(1, 16)
        UiTextBoxGlobalQualityControlValue.Name = "UiTextBoxGlobalQualityControlValue"
        UiTextBoxGlobalQualityControlValue.Padding = New Padding(5)
        UiTextBoxGlobalQualityControlValue.Radius = 30
        UiTextBoxGlobalQualityControlValue.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxGlobalQualityControlValue.ShowText = False
        UiTextBoxGlobalQualityControlValue.Size = New Size(100, 30)
        UiTextBoxGlobalQualityControlValue.TabIndex = 92
        UiTextBoxGlobalQualityControlValue.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxGlobalQualityControlValue.Watermark = ""
        UiTextBoxGlobalQualityControlValue.WatermarkActiveColor = Color.DimGray
        UiTextBoxGlobalQualityControlValue.WatermarkColor = Color.DimGray
        ' 
        ' Label42
        ' 
        Label42.Dock = DockStyle.Left
        Label42.Location = New Point(461, 10)
        Label42.Name = "Label42"
        Label42.Size = New Size(10, 30)
        Label42.TabIndex = 91
        ' 
        ' UiComboBoxGlobalQualityControlParameters
        ' 
        UiComboBoxGlobalQualityControlParameters.DataSource = Nothing
        UiComboBoxGlobalQualityControlParameters.Dock = DockStyle.Left
        UiComboBoxGlobalQualityControlParameters.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxGlobalQualityControlParameters.DropDownWidth = 130
        UiComboBoxGlobalQualityControlParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlParameters.Font = New Font("Segoe UI", 10F)
        UiComboBoxGlobalQualityControlParameters.ForeColor = Color.Silver
        UiComboBoxGlobalQualityControlParameters.ForeDisableColor = Color.Silver
        UiComboBoxGlobalQualityControlParameters.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlParameters.ItemForeColor = Color.Silver
        UiComboBoxGlobalQualityControlParameters.ItemHeight = 30
        UiComboBoxGlobalQualityControlParameters.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxGlobalQualityControlParameters.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxGlobalQualityControlParameters.Items.AddRange(New Object() {"", "-crf", "-cq", "-qp", "-global_quality"})
        UiComboBoxGlobalQualityControlParameters.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlParameters.ItemSelectForeColor = Color.Silver
        UiComboBoxGlobalQualityControlParameters.Location = New Point(301, 10)
        UiComboBoxGlobalQualityControlParameters.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxGlobalQualityControlParameters.MaxDropDownItems = 17
        UiComboBoxGlobalQualityControlParameters.MinimumSize = New Size(63, 0)
        UiComboBoxGlobalQualityControlParameters.Name = "UiComboBoxGlobalQualityControlParameters"
        UiComboBoxGlobalQualityControlParameters.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxGlobalQualityControlParameters.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxGlobalQualityControlParameters.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlParameters.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlParameters.ScrollBarHandleWidth = 20
        UiComboBoxGlobalQualityControlParameters.Size = New Size(160, 30)
        UiComboBoxGlobalQualityControlParameters.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxGlobalQualityControlParameters.SymbolSize = 24
        UiComboBoxGlobalQualityControlParameters.TabIndex = 90
        UiComboBoxGlobalQualityControlParameters.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxGlobalQualityControlParameters.Watermark = "Quality Parameters"
        ' 
        ' Label43
        ' 
        Label43.Dock = DockStyle.Left
        Label43.Location = New Point(291, 10)
        Label43.Name = "Label43"
        Label43.Size = New Size(10, 30)
        Label43.TabIndex = 93
        ' 
        ' UiComboBoxGlobalQualityControlMethod
        ' 
        UiComboBoxGlobalQualityControlMethod.DataSource = Nothing
        UiComboBoxGlobalQualityControlMethod.Dock = DockStyle.Left
        UiComboBoxGlobalQualityControlMethod.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxGlobalQualityControlMethod.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlMethod.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlMethod.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlMethod.Font = New Font("Segoe UI", 10F)
        UiComboBoxGlobalQualityControlMethod.ForeColor = Color.Silver
        UiComboBoxGlobalQualityControlMethod.ForeDisableColor = Color.Silver
        UiComboBoxGlobalQualityControlMethod.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxGlobalQualityControlMethod.ItemForeColor = Color.Silver
        UiComboBoxGlobalQualityControlMethod.ItemHeight = 30
        UiComboBoxGlobalQualityControlMethod.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxGlobalQualityControlMethod.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxGlobalQualityControlMethod.Items.AddRange(New Object() {"", "Constant Quality CRF - Softwares Preference", "Variable Bitrate VBR - Hardware Acceleration Preference", "Variable Bitrate VBR HQ - Hardware Acceleration Only", "Constant Quantization CQP - Research & Specific Scenes", "Constant Bitrate CBR - Rarely Used"})
        UiComboBoxGlobalQualityControlMethod.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlMethod.ItemSelectForeColor = Color.Silver
        UiComboBoxGlobalQualityControlMethod.Location = New Point(21, 10)
        UiComboBoxGlobalQualityControlMethod.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxGlobalQualityControlMethod.MaxDropDownItems = 17
        UiComboBoxGlobalQualityControlMethod.MinimumSize = New Size(63, 0)
        UiComboBoxGlobalQualityControlMethod.Name = "UiComboBoxGlobalQualityControlMethod"
        UiComboBoxGlobalQualityControlMethod.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxGlobalQualityControlMethod.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxGlobalQualityControlMethod.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlMethod.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxGlobalQualityControlMethod.ScrollBarHandleWidth = 20
        UiComboBoxGlobalQualityControlMethod.Size = New Size(270, 30)
        UiComboBoxGlobalQualityControlMethod.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxGlobalQualityControlMethod.SymbolSize = 24
        UiComboBoxGlobalQualityControlMethod.TabIndex = 67
        UiComboBoxGlobalQualityControlMethod.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxGlobalQualityControlMethod.Watermark = "Control Method -rc"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Dock = DockStyle.Top
        Label40.Font = New Font("Segoe UI", 10F)
        Label40.ForeColor = Color.Gray
        Label40.Location = New Point(0, 34)
        Label40.Name = "Label40"
        Label40.Padding = New Padding(16, 5, 0, 0)
        Label40.Size = New Size(591, 45)
        Label40.TabIndex = 14
        Label40.Text = "Software encoding prefers crf, Nvidia cards prefer cq; Intel cards prefer global_quality; AMD cards prefer advanced control qp_i, qp_p." & vbCrLf & "If encoder doesn't support any rc, setting Quality Parameters and Value directly is fine; qp is generic but not as good as others."
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Dock = DockStyle.Top
        Label41.Font = New Font("Segoe UI", 13F)
        Label41.Location = New Point(0, 0)
        Label41.Name = "Label41"
        Label41.Padding = New Padding(16, 10, 0, 0)
        Label41.Size = New Size(170, 34)
        Label41.TabIndex = 13
        Label41.Text = "Global Quality Control Method"
        ' 
        ' TabPageVideoParametersColorManagement
        ' 
        TabPageVideoParametersColorManagement.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoParametersColorManagement.Controls.Add(Panel40)
        TabPageVideoParametersColorManagement.Controls.Add(Panel27)
        TabPageVideoParametersColorManagement.Controls.Add(Label57)
        TabPageVideoParametersColorManagement.Controls.Add(Label58)
        TabPageVideoParametersColorManagement.Controls.Add(Panel85)
        TabPageVideoParametersColorManagement.Location = New Point(201, 0)
        TabPageVideoParametersColorManagement.Name = "TabPageVideoParametersColorManagement"
        TabPageVideoParametersColorManagement.Size = New Size(899, 650)
        TabPageVideoParametersColorManagement.TabIndex = 6
        TabPageVideoParametersColorManagement.Tag = "TabPage.VideoParametersColorManagement"
        TabPageVideoParametersColorManagement.Text = "Video Parameters | Color Management"
        ' 
        ' Panel40
        ' 
        Panel40.Controls.Add(Panel33)
        Panel40.Controls.Add(Label143)
        Panel40.Controls.Add(Panel90)
        Panel40.Controls.Add(Panel32)
        Panel40.Controls.Add(Panel31)
        Panel40.Controls.Add(Panel29)
        Panel40.Controls.Add(Panel28)
        Panel40.Controls.Add(Label81)
        Panel40.Controls.Add(Panel41)
        Panel40.Controls.Add(Label80)
        Panel40.Controls.Add(Label60)
        Panel40.Dock = DockStyle.Fill
        Panel40.Location = New Point(0, 99)
        Panel40.Name = "Panel40"
        Panel40.Size = New Size(699, 551)
        Panel40.TabIndex = 35
        ' 
        ' Panel33
        ' 
        Panel33.Controls.Add(Label61)
        Panel33.Controls.Add(UiComboBoxColorManagementProcessMethod)
        Panel33.Dock = DockStyle.Top
        Panel33.Location = New Point(0, 369)
        Panel33.Name = "Panel33"
        Panel33.Padding = New Padding(21, 10, 20, 0)
        Panel33.Size = New Size(699, 40)
        Panel33.TabIndex = 86
        ' 
        ' Label61
        ' 
        Label61.Dock = DockStyle.Fill
        Label61.Font = New Font("Segoe UI", 10F)
        Label61.ForeColor = Color.Gray
        Label61.Location = New Point(221, 10)
        Label61.Name = "Label61"
        Label61.Padding = New Padding(10, 0, 0, 0)
        Label61.Size = New Size(458, 30)
        Label61.TabIndex = 96
        Label61.Text = "For standard conversion operations, select 'Write Metadata and Convert'."
        Label61.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxColorManagementProcessMethod
        ' 
        UiComboBoxColorManagementProcessMethod.DataSource = Nothing
        UiComboBoxColorManagementProcessMethod.Dock = DockStyle.Left
        UiComboBoxColorManagementProcessMethod.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxColorManagementProcessMethod.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorManagementProcessMethod.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorManagementProcessMethod.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorManagementProcessMethod.Font = New Font("Segoe UI", 10F)
        UiComboBoxColorManagementProcessMethod.ForeColor = Color.Silver
        UiComboBoxColorManagementProcessMethod.ForeDisableColor = Color.Silver
        UiComboBoxColorManagementProcessMethod.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorManagementProcessMethod.ItemForeColor = Color.Silver
        UiComboBoxColorManagementProcessMethod.ItemHeight = 30
        UiComboBoxColorManagementProcessMethod.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxColorManagementProcessMethod.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorManagementProcessMethod.Items.AddRange(New Object() {"", "Write Metadata and Convert", "Write Metadata Only", "Convert Only"})
        UiComboBoxColorManagementProcessMethod.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorManagementProcessMethod.ItemSelectForeColor = Color.Silver
        UiComboBoxColorManagementProcessMethod.Location = New Point(21, 10)
        UiComboBoxColorManagementProcessMethod.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxColorManagementProcessMethod.MinimumSize = New Size(63, 0)
        UiComboBoxColorManagementProcessMethod.Name = "UiComboBoxColorManagementProcessMethod"
        UiComboBoxColorManagementProcessMethod.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxColorManagementProcessMethod.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxColorManagementProcessMethod.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorManagementProcessMethod.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorManagementProcessMethod.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorManagementProcessMethod.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxColorManagementProcessMethod.ScrollBarHandleWidth = 20
        UiComboBoxColorManagementProcessMethod.ScrollBarStyleInherited = False
        UiComboBoxColorManagementProcessMethod.Size = New Size(200, 30)
        UiComboBoxColorManagementProcessMethod.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxColorManagementProcessMethod.SymbolSize = 24
        UiComboBoxColorManagementProcessMethod.TabIndex = 95
        UiComboBoxColorManagementProcessMethod.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxColorManagementProcessMethod.Watermark = "Process Method"
        ' 
        ' Label143
        ' 
        Label143.AutoSize = True
        Label143.Dock = DockStyle.Top
        Label143.Font = New Font("Segoe UI", 10F)
        Label143.ForeColor = Color.Gray
        Label143.Location = New Point(0, 339)
        Label143.Name = "Label143"
        Label143.Padding = New Padding(16, 10, 0, 0)
        Label143.Size = New Size(221, 30)
        Label143.TabIndex = 88
        Label143.Text = "Must set process method to use filter."
        ' 
        ' Panel90
        ' 
        Panel90.Controls.Add(Label59)
        Panel90.Controls.Add(UiComboBoxToneMappingAlgorithm)
        Panel90.Dock = DockStyle.Top
        Panel90.Location = New Point(0, 299)
        Panel90.Name = "Panel90"
        Panel90.Padding = New Padding(21, 10, 20, 0)
        Panel90.Size = New Size(699, 40)
        Panel90.TabIndex = 87
        ' 
        ' Label59
        ' 
        Label59.Dock = DockStyle.Fill
        Label59.Font = New Font("Segoe UI", 10F)
        Label59.ForeColor = Color.Gray
        Label59.Location = New Point(221, 10)
        Label59.Name = "Label59"
        Label59.Padding = New Padding(10, 0, 0, 0)
        Label59.Size = New Size(458, 30)
        Label59.TabIndex = 96
        Label59.Text = "[Optional] Tone Mapping Algorithm (libplacebo only)"
        Label59.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxToneMappingAlgorithm
        ' 
        UiComboBoxToneMappingAlgorithm.DataSource = Nothing
        UiComboBoxToneMappingAlgorithm.Dock = DockStyle.Left
        UiComboBoxToneMappingAlgorithm.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxToneMappingAlgorithm.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxToneMappingAlgorithm.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxToneMappingAlgorithm.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxToneMappingAlgorithm.Font = New Font("Segoe UI", 10F)
        UiComboBoxToneMappingAlgorithm.ForeColor = Color.Silver
        UiComboBoxToneMappingAlgorithm.ForeDisableColor = Color.Silver
        UiComboBoxToneMappingAlgorithm.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxToneMappingAlgorithm.ItemForeColor = Color.Silver
        UiComboBoxToneMappingAlgorithm.ItemHeight = 30
        UiComboBoxToneMappingAlgorithm.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxToneMappingAlgorithm.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxToneMappingAlgorithm.Items.AddRange(New Object() {"", "auto", "clip", "st2094-40", "st2094-10", "bt.2390", "bt.2446a", "spline", "reinhard", "mobius", "hable", "gamma", "linear"})
        UiComboBoxToneMappingAlgorithm.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxToneMappingAlgorithm.ItemSelectForeColor = Color.Silver
        UiComboBoxToneMappingAlgorithm.Location = New Point(21, 10)
        UiComboBoxToneMappingAlgorithm.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxToneMappingAlgorithm.MaxDropDownItems = 6
        UiComboBoxToneMappingAlgorithm.MinimumSize = New Size(63, 0)
        UiComboBoxToneMappingAlgorithm.Name = "UiComboBoxToneMappingAlgorithm"
        UiComboBoxToneMappingAlgorithm.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxToneMappingAlgorithm.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxToneMappingAlgorithm.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxToneMappingAlgorithm.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxToneMappingAlgorithm.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxToneMappingAlgorithm.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxToneMappingAlgorithm.ScrollBarHandleWidth = 20
        UiComboBoxToneMappingAlgorithm.ScrollBarStyleInherited = False
        UiComboBoxToneMappingAlgorithm.Size = New Size(200, 30)
        UiComboBoxToneMappingAlgorithm.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxToneMappingAlgorithm.SymbolSize = 24
        UiComboBoxToneMappingAlgorithm.TabIndex = 95
        UiComboBoxToneMappingAlgorithm.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxToneMappingAlgorithm.Watermark = "tonemapping"
        ' 
        ' Panel32
        ' 
        Panel32.Controls.Add(Label65)
        Panel32.Controls.Add(UiComboBoxColorRange)
        Panel32.Dock = DockStyle.Top
        Panel32.Location = New Point(0, 259)
        Panel32.Name = "Panel32"
        Panel32.Padding = New Padding(21, 10, 20, 0)
        Panel32.Size = New Size(699, 40)
        Panel32.TabIndex = 85
        ' 
        ' Label65
        ' 
        Label65.Dock = DockStyle.Fill
        Label65.Font = New Font("Segoe UI", 10F)
        Label65.ForeColor = Color.Gray
        Label65.Location = New Point(221, 10)
        Label65.Name = "Label65"
        Label65.Padding = New Padding(10, 0, 0, 0)
        Label65.Size = New Size(458, 30)
        Label65.TabIndex = 95
        Label65.Text = "Color Range: Most videos are actually limited range, not full range."
        Label65.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxColorRange
        ' 
        UiComboBoxColorRange.DataSource = Nothing
        UiComboBoxColorRange.Dock = DockStyle.Left
        UiComboBoxColorRange.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxColorRange.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorRange.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiComboBoxColorRange.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorRange.FilterIgnoreCase = True
        UiComboBoxColorRange.Font = New Font("Segoe UI", 10F)
        UiComboBoxColorRange.ForeColor = Color.Silver
        UiComboBoxColorRange.ForeDisableColor = Color.Silver
        UiComboBoxColorRange.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorRange.ItemForeColor = Color.Silver
        UiComboBoxColorRange.ItemHeight = 30
        UiComboBoxColorRange.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxColorRange.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorRange.Items.AddRange(New Object() {"", "TV Limited 16~235", "PC Full Range 0~255"})
        UiComboBoxColorRange.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorRange.ItemSelectForeColor = Color.Silver
        UiComboBoxColorRange.Location = New Point(21, 10)
        UiComboBoxColorRange.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxColorRange.MaxDropDownItems = 10
        UiComboBoxColorRange.MinimumSize = New Size(63, 0)
        UiComboBoxColorRange.Name = "UiComboBoxColorRange"
        UiComboBoxColorRange.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxColorRange.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxColorRange.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorRange.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorRange.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorRange.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxColorRange.ScrollBarHandleWidth = 20
        UiComboBoxColorRange.ScrollBarStyleInherited = False
        UiComboBoxColorRange.Size = New Size(200, 30)
        UiComboBoxColorRange.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxColorRange.SymbolSize = 24
        UiComboBoxColorRange.TabIndex = 94
        UiComboBoxColorRange.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxColorRange.TrimFilter = True
        UiComboBoxColorRange.Watermark = "color_range"
        ' 
        ' Panel31
        ' 
        Panel31.Controls.Add(Label64)
        Panel31.Controls.Add(UiComboBoxTransferCharacteristics)
        Panel31.Dock = DockStyle.Top
        Panel31.Location = New Point(0, 219)
        Panel31.Name = "Panel31"
        Panel31.Padding = New Padding(21, 10, 20, 0)
        Panel31.Size = New Size(699, 40)
        Panel31.TabIndex = 84
        ' 
        ' Label64
        ' 
        Label64.Dock = DockStyle.Fill
        Label64.Font = New Font("Segoe UI", 10F)
        Label64.ForeColor = Color.Gray
        Label64.Location = New Point(221, 10)
        Label64.Name = "Label64"
        Label64.Padding = New Padding(10, 0, 0, 0)
        Label64.Size = New Size(458, 30)
        Label64.TabIndex = 94
        Label64.Text = "Transfer Characteristics: Describes the non-linear relationship between numerical value and actual brightness."
        Label64.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxTransferCharacteristics
        ' 
        UiComboBoxTransferCharacteristics.DataSource = Nothing
        UiComboBoxTransferCharacteristics.Dock = DockStyle.Left
        UiComboBoxTransferCharacteristics.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxTransferCharacteristics.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxTransferCharacteristics.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiComboBoxTransferCharacteristics.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxTransferCharacteristics.FilterIgnoreCase = True
        UiComboBoxTransferCharacteristics.Font = New Font("Segoe UI", 10F)
        UiComboBoxTransferCharacteristics.ForeColor = Color.Silver
        UiComboBoxTransferCharacteristics.ForeDisableColor = Color.Silver
        UiComboBoxTransferCharacteristics.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxTransferCharacteristics.ItemForeColor = Color.Silver
        UiComboBoxTransferCharacteristics.ItemHeight = 30
        UiComboBoxTransferCharacteristics.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxTransferCharacteristics.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxTransferCharacteristics.Items.AddRange(New Object() {"", "auto", "bt709", "bt2020-10", "bt2020-12", "smpte2084", "bt470m", "bt470bg", "log", "log_sqrt", "linear", "bt1361e", "iec61966-2-1", "iec61966-2-4", "smpte170m", "smpte240m", "gamma22", "gamma28", "arib-std-b67"})
        UiComboBoxTransferCharacteristics.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxTransferCharacteristics.ItemSelectForeColor = Color.Silver
        UiComboBoxTransferCharacteristics.Location = New Point(21, 10)
        UiComboBoxTransferCharacteristics.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxTransferCharacteristics.MaxDropDownItems = 10
        UiComboBoxTransferCharacteristics.MinimumSize = New Size(63, 0)
        UiComboBoxTransferCharacteristics.Name = "UiComboBoxTransferCharacteristics"
        UiComboBoxTransferCharacteristics.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxTransferCharacteristics.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxTransferCharacteristics.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxTransferCharacteristics.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxTransferCharacteristics.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxTransferCharacteristics.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxTransferCharacteristics.ScrollBarHandleWidth = 20
        UiComboBoxTransferCharacteristics.ScrollBarStyleInherited = False
        UiComboBoxTransferCharacteristics.Size = New Size(200, 30)
        UiComboBoxTransferCharacteristics.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxTransferCharacteristics.SymbolSize = 24
        UiComboBoxTransferCharacteristics.TabIndex = 90
        UiComboBoxTransferCharacteristics.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxTransferCharacteristics.TrimFilter = True
        UiComboBoxTransferCharacteristics.Watermark = "color_trc"
        ' 
        ' Panel29
        ' 
        Panel29.Controls.Add(Label63)
        Panel29.Controls.Add(UiComboBoxColorPrimaries)
        Panel29.Dock = DockStyle.Top
        Panel29.Location = New Point(0, 179)
        Panel29.Name = "Panel29"
        Panel29.Padding = New Padding(21, 10, 20, 0)
        Panel29.Size = New Size(699, 40)
        Panel29.TabIndex = 83
        ' 
        ' Label63
        ' 
        Label63.Dock = DockStyle.Fill
        Label63.Font = New Font("Segoe UI", 10F)
        Label63.ForeColor = Color.Gray
        Label63.Location = New Point(221, 10)
        Label63.Name = "Label63"
        Label63.Padding = New Padding(10, 0, 0, 0)
        Label63.Size = New Size(458, 30)
        Label63.TabIndex = 93
        Label63.Text = "Color Primaries: Specifies which color standard to use."
        Label63.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxColorPrimaries
        ' 
        UiComboBoxColorPrimaries.DataSource = Nothing
        UiComboBoxColorPrimaries.Dock = DockStyle.Left
        UiComboBoxColorPrimaries.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxColorPrimaries.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorPrimaries.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiComboBoxColorPrimaries.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorPrimaries.FilterIgnoreCase = True
        UiComboBoxColorPrimaries.Font = New Font("Segoe UI", 10F)
        UiComboBoxColorPrimaries.ForeColor = Color.Silver
        UiComboBoxColorPrimaries.ForeDisableColor = Color.Silver
        UiComboBoxColorPrimaries.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorPrimaries.ItemForeColor = Color.Silver
        UiComboBoxColorPrimaries.ItemHeight = 30
        UiComboBoxColorPrimaries.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxColorPrimaries.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorPrimaries.Items.AddRange(New Object() {"", "auto", "bt709", "bt2020", "smpte428", "smpte431", "smpte432", "film", "bt470m", "bt470bg", "smpte170m", "smpte240m", "jedec-p22", "ebu3213"})
        UiComboBoxColorPrimaries.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorPrimaries.ItemSelectForeColor = Color.Silver
        UiComboBoxColorPrimaries.Location = New Point(21, 10)
        UiComboBoxColorPrimaries.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxColorPrimaries.MaxDropDownItems = 10
        UiComboBoxColorPrimaries.MinimumSize = New Size(63, 0)
        UiComboBoxColorPrimaries.Name = "UiComboBoxColorPrimaries"
        UiComboBoxColorPrimaries.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxColorPrimaries.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxColorPrimaries.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorPrimaries.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorPrimaries.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorPrimaries.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxColorPrimaries.ScrollBarHandleWidth = 20
        UiComboBoxColorPrimaries.ScrollBarStyleInherited = False
        UiComboBoxColorPrimaries.Size = New Size(200, 30)
        UiComboBoxColorPrimaries.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxColorPrimaries.SymbolSize = 24
        UiComboBoxColorPrimaries.TabIndex = 92
        UiComboBoxColorPrimaries.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxColorPrimaries.Watermark = "color_primaries"
        ' 
        ' Panel28
        ' 
        Panel28.Controls.Add(Label62)
        Panel28.Controls.Add(UiComboBoxMatrixCoefficients)
        Panel28.Dock = DockStyle.Top
        Panel28.Location = New Point(0, 139)
        Panel28.Name = "Panel28"
        Panel28.Padding = New Padding(21, 10, 20, 0)
        Panel28.Size = New Size(699, 40)
        Panel28.TabIndex = 81
        ' 
        ' Label62
        ' 
        Label62.Dock = DockStyle.Fill
        Label62.Font = New Font("Segoe UI", 10F)
        Label62.ForeColor = Color.Gray
        Label62.Location = New Point(221, 10)
        Label62.Name = "Label62"
        Label62.Padding = New Padding(10, 0, 0, 0)
        Label62.Size = New Size(458, 30)
        Label62.TabIndex = 89
        Label62.Text = "Matrix Coefficients / Color Format: Determines how luma and chroma are distributed."
        Label62.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxMatrixCoefficients
        ' 
        UiComboBoxMatrixCoefficients.DataSource = Nothing
        UiComboBoxMatrixCoefficients.Dock = DockStyle.Left
        UiComboBoxMatrixCoefficients.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMatrixCoefficients.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMatrixCoefficients.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMatrixCoefficients.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMatrixCoefficients.Font = New Font("Segoe UI", 10F)
        UiComboBoxMatrixCoefficients.ForeColor = Color.Silver
        UiComboBoxMatrixCoefficients.ForeDisableColor = Color.Silver
        UiComboBoxMatrixCoefficients.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMatrixCoefficients.ItemForeColor = Color.Silver
        UiComboBoxMatrixCoefficients.ItemHeight = 30
        UiComboBoxMatrixCoefficients.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMatrixCoefficients.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMatrixCoefficients.Items.AddRange(New Object() {"", "auto", "bt709", "bt2020nc", "bt2020c", "rgb", "gbr", "bt470bg", "smpte170m", "smpte240m", "fcc", "ictcp", "ycgco", "xyz"})
        UiComboBoxMatrixCoefficients.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMatrixCoefficients.ItemSelectForeColor = Color.Silver
        UiComboBoxMatrixCoefficients.Location = New Point(21, 10)
        UiComboBoxMatrixCoefficients.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMatrixCoefficients.MaxDropDownItems = 10
        UiComboBoxMatrixCoefficients.MinimumSize = New Size(63, 0)
        UiComboBoxMatrixCoefficients.Name = "UiComboBoxMatrixCoefficients"
        UiComboBoxMatrixCoefficients.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMatrixCoefficients.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMatrixCoefficients.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMatrixCoefficients.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMatrixCoefficients.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMatrixCoefficients.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxMatrixCoefficients.ScrollBarHandleWidth = 20
        UiComboBoxMatrixCoefficients.ScrollBarStyleInherited = False
        UiComboBoxMatrixCoefficients.Size = New Size(200, 30)
        UiComboBoxMatrixCoefficients.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMatrixCoefficients.SymbolSize = 24
        UiComboBoxMatrixCoefficients.TabIndex = 88
        UiComboBoxMatrixCoefficients.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMatrixCoefficients.Watermark = "colorspace"
        ' 
        ' Label81
        ' 
        Label81.AutoSize = True
        Label81.Dock = DockStyle.Top
        Label81.Font = New Font("Segoe UI", 10F)
        Label81.ForeColor = Color.Gray
        Label81.Location = New Point(0, 109)
        Label81.Name = "Label81"
        Label81.Padding = New Padding(16, 10, 0, 0)
        Label81.Size = New Size(347, 30)
        Label81.TabIndex = 22
        Label81.Text = "Although not all settings are forced, filters may have their own logic."
        ' 
        ' Panel41
        ' 
        Panel41.Controls.Add(Label147)
        Panel41.Controls.Add(UiComboBoxColorSpaceFilterSelect)
        Panel41.Dock = DockStyle.Top
        Panel41.Location = New Point(0, 69)
        Panel41.Name = "Panel41"
        Panel41.Padding = New Padding(21, 10, 20, 0)
        Panel41.Size = New Size(699, 40)
        Panel41.TabIndex = 21
        ' 
        ' Label147
        ' 
        Label147.Dock = DockStyle.Fill
        Label147.Font = New Font("Segoe UI", 10F)
        Label147.ForeColor = Color.Gray
        Label147.Location = New Point(221, 10)
        Label147.Name = "Label147"
        Label147.Padding = New Padding(10, 0, 0, 0)
        Label147.Size = New Size(458, 30)
        Label147.TabIndex = 90
        Label147.Text = "First select the filter used for color conversion."
        Label147.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxColorSpaceFilterSelect
        ' 
        UiComboBoxColorSpaceFilterSelect.DataSource = Nothing
        UiComboBoxColorSpaceFilterSelect.Dock = DockStyle.Left
        UiComboBoxColorSpaceFilterSelect.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxColorSpaceFilterSelect.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorSpaceFilterSelect.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorSpaceFilterSelect.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorSpaceFilterSelect.Font = New Font("Segoe UI", 10F)
        UiComboBoxColorSpaceFilterSelect.ForeColor = Color.Silver
        UiComboBoxColorSpaceFilterSelect.ForeDisableColor = Color.Silver
        UiComboBoxColorSpaceFilterSelect.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxColorSpaceFilterSelect.ItemForeColor = Color.Silver
        UiComboBoxColorSpaceFilterSelect.ItemHeight = 30
        UiComboBoxColorSpaceFilterSelect.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxColorSpaceFilterSelect.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorSpaceFilterSelect.Items.AddRange(New Object() {"", "zscale", "libplacebo"})
        UiComboBoxColorSpaceFilterSelect.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorSpaceFilterSelect.ItemSelectForeColor = Color.Silver
        UiComboBoxColorSpaceFilterSelect.Location = New Point(21, 10)
        UiComboBoxColorSpaceFilterSelect.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxColorSpaceFilterSelect.MinimumSize = New Size(63, 0)
        UiComboBoxColorSpaceFilterSelect.Name = "UiComboBoxColorSpaceFilterSelect"
        UiComboBoxColorSpaceFilterSelect.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxColorSpaceFilterSelect.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxColorSpaceFilterSelect.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorSpaceFilterSelect.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxColorSpaceFilterSelect.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxColorSpaceFilterSelect.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxColorSpaceFilterSelect.ScrollBarHandleWidth = 20
        UiComboBoxColorSpaceFilterSelect.ScrollBarStyleInherited = False
        UiComboBoxColorSpaceFilterSelect.Size = New Size(200, 30)
        UiComboBoxColorSpaceFilterSelect.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxColorSpaceFilterSelect.SymbolSize = 24
        UiComboBoxColorSpaceFilterSelect.TabIndex = 88
        UiComboBoxColorSpaceFilterSelect.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxColorSpaceFilterSelect.Watermark = "Select Filter"
        ' 
        ' Label80
        ' 
        Label80.AutoSize = True
        Label80.Dock = DockStyle.Top
        Label80.Font = New Font("Segoe UI", 10F)
        Label80.ForeColor = Color.Gray
        Label80.Location = New Point(0, 44)
        Label80.Name = "Label80"
        Label80.Padding = New Padding(16, 5, 0, 0)
        Label80.Size = New Size(351, 25)
        Label80.TabIndex = 20
        Label80.Text = "zscale (CPU); libplacebo (GPU) recommended for Dolby Vision conversion."
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Dock = DockStyle.Top
        Label60.Font = New Font("Segoe UI", 13F)
        Label60.Location = New Point(0, 0)
        Label60.Name = "Label60"
        Label60.Padding = New Padding(16, 20, 0, 0)
        Label60.Size = New Size(98, 44)
        Label60.TabIndex = 19
        Label60.Text = "Color Space"
        ' 
        ' Panel27
        ' 
        Panel27.Controls.Add(UiComboBoxPixelFormat)
        Panel27.Dock = DockStyle.Top
        Panel27.Location = New Point(0, 59)
        Panel27.Name = "Panel27"
        Panel27.Padding = New Padding(21, 10, 20, 0)
        Panel27.Size = New Size(699, 40)
        Panel27.TabIndex = 17
        ' 
        ' UiComboBoxPixelFormat
        ' 
        UiComboBoxPixelFormat.DataSource = Nothing
        UiComboBoxPixelFormat.Dock = DockStyle.Left
        UiComboBoxPixelFormat.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxPixelFormat.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiComboBoxPixelFormat.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxPixelFormat.FilterIgnoreCase = True
        UiComboBoxPixelFormat.Font = New Font("Segoe UI", 10F)
        UiComboBoxPixelFormat.ForeColor = Color.Silver
        UiComboBoxPixelFormat.ForeDisableColor = Color.Silver
        UiComboBoxPixelFormat.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxPixelFormat.ItemForeColor = Color.Silver
        UiComboBoxPixelFormat.ItemHeight = 30
        UiComboBoxPixelFormat.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxPixelFormat.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxPixelFormat.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxPixelFormat.ItemSelectForeColor = Color.Silver
        UiComboBoxPixelFormat.Location = New Point(21, 10)
        UiComboBoxPixelFormat.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxPixelFormat.MaxDropDownItems = 15
        UiComboBoxPixelFormat.MinimumSize = New Size(63, 0)
        UiComboBoxPixelFormat.Name = "UiComboBoxPixelFormat"
        UiComboBoxPixelFormat.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxPixelFormat.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxPixelFormat.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxPixelFormat.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxPixelFormat.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxPixelFormat.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiComboBoxPixelFormat.ScrollBarHandleWidth = 20
        UiComboBoxPixelFormat.ScrollBarStyleInherited = False
        UiComboBoxPixelFormat.Size = New Size(200, 30)
        UiComboBoxPixelFormat.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxPixelFormat.SymbolSize = 24
        UiComboBoxPixelFormat.TabIndex = 77
        UiComboBoxPixelFormat.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxPixelFormat.TrimFilter = True
        UiComboBoxPixelFormat.Watermark = "-pix_fmt"
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Dock = DockStyle.Top
        Label57.Font = New Font("Segoe UI", 10F)
        Label57.ForeColor = Color.Gray
        Label57.Location = New Point(0, 34)
        Label57.Name = "Label57"
        Label57.Padding = New Padding(16, 5, 0, 0)
        Label57.Size = New Size(445, 25)
        Label57.TabIndex = 16
        Label57.Text = "Specify how pixels are stored; dropdown follows selected encoder, or type manually."
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Dock = DockStyle.Top
        Label58.Font = New Font("Segoe UI", 13F)
        Label58.Location = New Point(0, 0)
        Label58.Name = "Label58"
        Label58.Padding = New Padding(16, 10, 0, 0)
        Label58.Size = New Size(98, 34)
        Label58.TabIndex = 15
        Label58.Text = "Pixel Format"
        ' 
        ' Panel85
        ' 
        Panel85.Controls.Add(Panel89)
        Panel85.Controls.Add(Label156)
        Panel85.Controls.Add(Panel88)
        Panel85.Controls.Add(Label130)
        Panel85.Controls.Add(Panel87)
        Panel85.Controls.Add(Label78)
        Panel85.Controls.Add(Panel86)
        Panel85.Controls.Add(Label83)
        Panel85.Controls.Add(Label160)
        Panel85.Controls.Add(Label79)
        Panel85.Dock = DockStyle.Right
        Panel85.Location = New Point(699, 0)
        Panel85.Name = "Panel85"
        Panel85.Size = New Size(200, 650)
        Panel85.TabIndex = 34
        ' 
        ' Panel89
        ' 
        Panel89.Controls.Add(UiTextBoxSimpleColorGamma)
        Panel89.Dock = DockStyle.Top
        Panel89.Location = New Point(0, 309)
        Panel89.Name = "Panel89"
        Panel89.Padding = New Padding(21, 0, 20, 0)
        Panel89.Size = New Size(200, 30)
        Panel89.TabIndex = 85
        ' 
        ' UiTextBoxSimpleColorGamma
        ' 
        UiTextBoxSimpleColorGamma.Dock = DockStyle.Fill
        UiTextBoxSimpleColorGamma.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.Font = New Font("Segoe UI", 10F)
        UiTextBoxSimpleColorGamma.ForeColor = Color.Silver
        UiTextBoxSimpleColorGamma.ForeDisableColor = Color.Silver
        UiTextBoxSimpleColorGamma.ForeReadOnlyColor = Color.Silver
        UiTextBoxSimpleColorGamma.Location = New Point(21, 0)
        UiTextBoxSimpleColorGamma.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSimpleColorGamma.MinimumSize = New Size(1, 16)
        UiTextBoxSimpleColorGamma.Name = "UiTextBoxSimpleColorGamma"
        UiTextBoxSimpleColorGamma.Padding = New Padding(5)
        UiTextBoxSimpleColorGamma.Radius = 30
        UiTextBoxSimpleColorGamma.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorGamma.ShowText = False
        UiTextBoxSimpleColorGamma.Size = New Size(159, 30)
        UiTextBoxSimpleColorGamma.TabIndex = 97
        UiTextBoxSimpleColorGamma.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSimpleColorGamma.Watermark = "0.1~10.0, Default 1"
        ' 
        ' Label156
        ' 
        Label156.AutoSize = True
        Label156.Dock = DockStyle.Top
        Label156.Font = New Font("Segoe UI", 9.75F)
        Label156.Location = New Point(0, 274)
        Label156.Name = "Label156"
        Label156.Padding = New Padding(16, 10, 0, 6)
        Label156.Size = New Size(101, 35)
        Label156.TabIndex = 84
        Label156.Text = "Gamma"
        Label156.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel88
        ' 
        Panel88.Controls.Add(UiTextBoxSimpleColorSaturation)
        Panel88.Dock = DockStyle.Top
        Panel88.Location = New Point(0, 244)
        Panel88.Name = "Panel88"
        Panel88.Padding = New Padding(21, 0, 20, 0)
        Panel88.Size = New Size(200, 30)
        Panel88.TabIndex = 83
        ' 
        ' UiTextBoxSimpleColorSaturation
        ' 
        UiTextBoxSimpleColorSaturation.Dock = DockStyle.Fill
        UiTextBoxSimpleColorSaturation.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.Font = New Font("Segoe UI", 10F)
        UiTextBoxSimpleColorSaturation.ForeColor = Color.Silver
        UiTextBoxSimpleColorSaturation.ForeDisableColor = Color.Silver
        UiTextBoxSimpleColorSaturation.ForeReadOnlyColor = Color.Silver
        UiTextBoxSimpleColorSaturation.Location = New Point(21, 0)
        UiTextBoxSimpleColorSaturation.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSimpleColorSaturation.MinimumSize = New Size(1, 16)
        UiTextBoxSimpleColorSaturation.Name = "UiTextBoxSimpleColorSaturation"
        UiTextBoxSimpleColorSaturation.Padding = New Padding(5)
        UiTextBoxSimpleColorSaturation.Radius = 30
        UiTextBoxSimpleColorSaturation.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorSaturation.ShowText = False
        UiTextBoxSimpleColorSaturation.Size = New Size(159, 30)
        UiTextBoxSimpleColorSaturation.TabIndex = 95
        UiTextBoxSimpleColorSaturation.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSimpleColorSaturation.Watermark = "0.0~3.0, Default 1"
        ' 
        ' Label130
        ' 
        Label130.AutoSize = True
        Label130.Dock = DockStyle.Top
        Label130.Font = New Font("Segoe UI", 9.75F)
        Label130.Location = New Point(0, 209)
        Label130.Name = "Label130"
        Label130.Padding = New Padding(16, 10, 0, 6)
        Label130.Size = New Size(130, 35)
        Label130.TabIndex = 82
        Label130.Text = "Saturation"
        Label130.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel87
        ' 
        Panel87.Controls.Add(UiTextBoxSimpleColorContrast)
        Panel87.Dock = DockStyle.Top
        Panel87.Location = New Point(0, 179)
        Panel87.Name = "Panel87"
        Panel87.Padding = New Padding(21, 0, 20, 0)
        Panel87.Size = New Size(200, 30)
        Panel87.TabIndex = 81
        ' 
        ' UiTextBoxSimpleColorContrast
        ' 
        UiTextBoxSimpleColorContrast.Dock = DockStyle.Fill
        UiTextBoxSimpleColorContrast.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.Font = New Font("Segoe UI", 10F)
        UiTextBoxSimpleColorContrast.ForeColor = Color.Silver
        UiTextBoxSimpleColorContrast.ForeDisableColor = Color.Silver
        UiTextBoxSimpleColorContrast.ForeReadOnlyColor = Color.Silver
        UiTextBoxSimpleColorContrast.Location = New Point(21, 0)
        UiTextBoxSimpleColorContrast.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSimpleColorContrast.MinimumSize = New Size(1, 16)
        UiTextBoxSimpleColorContrast.Name = "UiTextBoxSimpleColorContrast"
        UiTextBoxSimpleColorContrast.Padding = New Padding(5)
        UiTextBoxSimpleColorContrast.Radius = 30
        UiTextBoxSimpleColorContrast.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorContrast.ShowText = False
        UiTextBoxSimpleColorContrast.Size = New Size(159, 30)
        UiTextBoxSimpleColorContrast.TabIndex = 93
        UiTextBoxSimpleColorContrast.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSimpleColorContrast.Watermark = "0.0~2.0, Default 1"
        ' 
        ' Label78
        ' 
        Label78.AutoSize = True
        Label78.Dock = DockStyle.Top
        Label78.Font = New Font("Segoe UI", 9.75F)
        Label78.Location = New Point(0, 144)
        Label78.Name = "Label78"
        Label78.Padding = New Padding(16, 10, 0, 6)
        Label78.Size = New Size(119, 35)
        Label78.TabIndex = 80
        Label78.Text = "Contrast"
        Label78.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel86
        ' 
        Panel86.Controls.Add(UiTextBoxSimpleColorBrightness)
        Panel86.Dock = DockStyle.Top
        Panel86.Location = New Point(0, 114)
        Panel86.Name = "Panel86"
        Panel86.Padding = New Padding(21, 0, 20, 0)
        Panel86.Size = New Size(200, 30)
        Panel86.TabIndex = 35
        ' 
        ' UiTextBoxSimpleColorBrightness
        ' 
        UiTextBoxSimpleColorBrightness.Dock = DockStyle.Fill
        UiTextBoxSimpleColorBrightness.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.Font = New Font("Segoe UI", 10F)
        UiTextBoxSimpleColorBrightness.ForeColor = Color.Silver
        UiTextBoxSimpleColorBrightness.ForeDisableColor = Color.Silver
        UiTextBoxSimpleColorBrightness.ForeReadOnlyColor = Color.Silver
        UiTextBoxSimpleColorBrightness.Location = New Point(21, 0)
        UiTextBoxSimpleColorBrightness.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSimpleColorBrightness.MinimumSize = New Size(1, 16)
        UiTextBoxSimpleColorBrightness.Name = "UiTextBoxSimpleColorBrightness"
        UiTextBoxSimpleColorBrightness.Padding = New Padding(5)
        UiTextBoxSimpleColorBrightness.Radius = 30
        UiTextBoxSimpleColorBrightness.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSimpleColorBrightness.ShowText = False
        UiTextBoxSimpleColorBrightness.Size = New Size(159, 30)
        UiTextBoxSimpleColorBrightness.TabIndex = 92
        UiTextBoxSimpleColorBrightness.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSimpleColorBrightness.Watermark = "-1.0~1.0, Default 0"
        ' 
        ' Label83
        ' 
        Label83.AutoSize = True
        Label83.Dock = DockStyle.Top
        Label83.Font = New Font("Segoe UI", 9.75F)
        Label83.Location = New Point(0, 79)
        Label83.Name = "Label83"
        Label83.Padding = New Padding(16, 10, 0, 6)
        Label83.Size = New Size(119, 35)
        Label83.TabIndex = 79
        Label83.Text = "Brightness"
        Label83.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label160
        ' 
        Label160.AutoSize = True
        Label160.Dock = DockStyle.Top
        Label160.Font = New Font("Segoe UI", 10F)
        Label160.ForeColor = Color.Gray
        Label160.Location = New Point(0, 34)
        Label160.Name = "Label160"
        Label160.Padding = New Padding(16, 5, 0, 0)
        Label160.Size = New Size(151, 45)
        Label160.TabIndex = 86
        Label160.Text = "For advanced color grading use DaVinci Resolve" & vbCrLf & "You don't need to set everything here"
        ' 
        ' Label79
        ' 
        Label79.AutoSize = True
        Label79.Dock = DockStyle.Top
        Label79.Font = New Font("Segoe UI", 13F)
        Label79.Location = New Point(0, 0)
        Label79.Name = "Label79"
        Label79.Padding = New Padding(16, 10, 0, 0)
        Label79.Size = New Size(98, 34)
        Label79.TabIndex = 31
        Label79.Text = "Simple Color Grading"
        ' 
        ' TabPageVideoParametersCommonFilters
        ' 
        TabPageVideoParametersCommonFilters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoParametersCommonFilters.Controls.Add(Panel39)
        TabPageVideoParametersCommonFilters.Controls.Add(Label77)
        TabPageVideoParametersCommonFilters.Controls.Add(Panel38)
        TabPageVideoParametersCommonFilters.Controls.Add(Label75)
        TabPageVideoParametersCommonFilters.Controls.Add(Panel37)
        TabPageVideoParametersCommonFilters.Controls.Add(Label72)
        TabPageVideoParametersCommonFilters.Controls.Add(Label73)
        TabPageVideoParametersCommonFilters.Controls.Add(Panel36)
        TabPageVideoParametersCommonFilters.Controls.Add(Panel35)
        TabPageVideoParametersCommonFilters.Controls.Add(Panel34)
        TabPageVideoParametersCommonFilters.Controls.Add(Label66)
        TabPageVideoParametersCommonFilters.Controls.Add(Label67)
        TabPageVideoParametersCommonFilters.Location = New Point(201, 0)
        TabPageVideoParametersCommonFilters.Name = "TabPageVideoParametersCommonFilters"
        TabPageVideoParametersCommonFilters.Size = New Size(899, 650)
        TabPageVideoParametersCommonFilters.TabIndex = 7
        TabPageVideoParametersCommonFilters.Tag = "TabPage.VideoParametersCommonFilters"
        TabPageVideoParametersCommonFilters.Text = "Video Parameters | Common Filters"
        ' 
        ' Panel39
        ' 
        Panel39.Controls.Add(UiComboBoxMirrorFlip)
        Panel39.Controls.Add(Label92)
        Panel39.Controls.Add(UiComboBoxAngleRotate)
        Panel39.Dock = DockStyle.Top
        Panel39.Location = New Point(0, 421)
        Panel39.Name = "Panel39"
        Panel39.Padding = New Padding(21, 10, 20, 0)
        Panel39.Size = New Size(899, 40)
        Panel39.TabIndex = 41
        ' 
        ' UiComboBoxMirrorFlip
        ' 
        UiComboBoxMirrorFlip.DataSource = Nothing
        UiComboBoxMirrorFlip.Dock = DockStyle.Left
        UiComboBoxMirrorFlip.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMirrorFlip.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMirrorFlip.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMirrorFlip.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMirrorFlip.Font = New Font("Segoe UI", 10F)
        UiComboBoxMirrorFlip.ForeColor = Color.Silver
        UiComboBoxMirrorFlip.ForeDisableColor = Color.Silver
        UiComboBoxMirrorFlip.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMirrorFlip.ItemForeColor = Color.Silver
        UiComboBoxMirrorFlip.ItemHeight = 30
        UiComboBoxMirrorFlip.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMirrorFlip.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMirrorFlip.Items.AddRange(New Object() {"", "Horizontal Mirror", "Vertical Mirror"})
        UiComboBoxMirrorFlip.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMirrorFlip.ItemSelectForeColor = Color.Silver
        UiComboBoxMirrorFlip.Location = New Point(201, 10)
        UiComboBoxMirrorFlip.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMirrorFlip.MaxDropDownItems = 17
        UiComboBoxMirrorFlip.MinimumSize = New Size(63, 0)
        UiComboBoxMirrorFlip.Name = "UiComboBoxMirrorFlip"
        UiComboBoxMirrorFlip.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMirrorFlip.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMirrorFlip.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMirrorFlip.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMirrorFlip.ScrollBarHandleWidth = 20
        UiComboBoxMirrorFlip.Size = New Size(150, 30)
        UiComboBoxMirrorFlip.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMirrorFlip.SymbolSize = 24
        UiComboBoxMirrorFlip.TabIndex = 93
        UiComboBoxMirrorFlip.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMirrorFlip.Watermark = "Mirror Flip"
        ' 
        ' Label92
        ' 
        Label92.Dock = DockStyle.Left
        Label92.Location = New Point(191, 10)
        Label92.Name = "Label92"
        Label92.Size = New Size(10, 30)
        Label92.TabIndex = 92
        ' 
        ' UiComboBoxAngleRotate
        ' 
        UiComboBoxAngleRotate.DataSource = Nothing
        UiComboBoxAngleRotate.Dock = DockStyle.Left
        UiComboBoxAngleRotate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAngleRotate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAngleRotate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAngleRotate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAngleRotate.Font = New Font("Segoe UI", 10F)
        UiComboBoxAngleRotate.ForeColor = Color.Silver
        UiComboBoxAngleRotate.ForeDisableColor = Color.Silver
        UiComboBoxAngleRotate.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAngleRotate.ItemForeColor = Color.Silver
        UiComboBoxAngleRotate.ItemHeight = 30
        UiComboBoxAngleRotate.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAngleRotate.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAngleRotate.Items.AddRange(New Object() {"", "Clockwise 90°", "Clockwise 180°", "Clockwise 270°", "Counter-Clockwise 90°", "Counter-Clockwise 180°", "Counter-Clockwise 270°"})
        UiComboBoxAngleRotate.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAngleRotate.ItemSelectForeColor = Color.Silver
        UiComboBoxAngleRotate.Location = New Point(21, 10)
        UiComboBoxAngleRotate.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAngleRotate.MaxDropDownItems = 17
        UiComboBoxAngleRotate.MinimumSize = New Size(63, 0)
        UiComboBoxAngleRotate.Name = "UiComboBoxAngleRotate"
        UiComboBoxAngleRotate.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAngleRotate.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAngleRotate.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAngleRotate.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAngleRotate.ScrollBarHandleWidth = 20
        UiComboBoxAngleRotate.Size = New Size(170, 30)
        UiComboBoxAngleRotate.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAngleRotate.SymbolSize = 24
        UiComboBoxAngleRotate.TabIndex = 91
        UiComboBoxAngleRotate.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAngleRotate.Watermark = "Angle Flip"
        ' 
        ' Label77
        ' 
        Label77.AutoSize = True
        Label77.Dock = DockStyle.Top
        Label77.Font = New Font("Segoe UI", 13F)
        Label77.Location = New Point(0, 377)
        Label77.Name = "Label77"
        Label77.Padding = New Padding(16, 20, 0, 0)
        Label77.Size = New Size(98, 44)
        Label77.TabIndex = 39
        Label77.Text = "Picture Flip"
        ' 
        ' Panel38
        ' 
        Panel38.Controls.Add(UiComboBoxInterlacedProgressiveProcMethod)
        Panel38.Dock = DockStyle.Top
        Panel38.Location = New Point(0, 337)
        Panel38.Name = "Panel38"
        Panel38.Padding = New Padding(21, 10, 20, 0)
        Panel38.Size = New Size(899, 40)
        Panel38.TabIndex = 38
        ' 
        ' UiComboBoxInterlacedProgressiveProcMethod
        ' 
        UiComboBoxInterlacedProgressiveProcMethod.DataSource = Nothing
        UiComboBoxInterlacedProgressiveProcMethod.Dock = DockStyle.Left
        UiComboBoxInterlacedProgressiveProcMethod.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxInterlacedProgressiveProcMethod.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxInterlacedProgressiveProcMethod.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxInterlacedProgressiveProcMethod.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxInterlacedProgressiveProcMethod.Font = New Font("Segoe UI", 10F)
        UiComboBoxInterlacedProgressiveProcMethod.ForeColor = Color.Silver
        UiComboBoxInterlacedProgressiveProcMethod.ForeDisableColor = Color.Silver
        UiComboBoxInterlacedProgressiveProcMethod.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxInterlacedProgressiveProcMethod.ItemForeColor = Color.Silver
        UiComboBoxInterlacedProgressiveProcMethod.ItemHeight = 30
        UiComboBoxInterlacedProgressiveProcMethod.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxInterlacedProgressiveProcMethod.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxInterlacedProgressiveProcMethod.Items.AddRange(New Object() {"", "Deinterlace - yadif single frame + Auto field order + spatial check", "Deinterlace - yadif single frame + Top field first + spatial check", "Deinterlace - yadif single frame + Bottom field first + spatial check", "Interlace - tinterlace Top field first", "Interlace - tinterlace Bottom field first", "NTSC Standard IVTC Film 3:2 pulldown to Progressive", "NTSC Pure Interlaced Non-Film to Progressive", "NTSC Auto Detect pulldown mode to 25fps", "PAL Standard Deinterlace", "PAL Standard Deinterlace Double Framerate", "PAL High Quality Deinterlace", "PAL High Quality Deinterlace Double Framerate"})
        UiComboBoxInterlacedProgressiveProcMethod.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxInterlacedProgressiveProcMethod.ItemSelectForeColor = Color.Silver
        UiComboBoxInterlacedProgressiveProcMethod.Location = New Point(21, 10)
        UiComboBoxInterlacedProgressiveProcMethod.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxInterlacedProgressiveProcMethod.MaxDropDownItems = 17
        UiComboBoxInterlacedProgressiveProcMethod.MinimumSize = New Size(63, 0)
        UiComboBoxInterlacedProgressiveProcMethod.Name = "UiComboBoxInterlacedProgressiveProcMethod"
        UiComboBoxInterlacedProgressiveProcMethod.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxInterlacedProgressiveProcMethod.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxInterlacedProgressiveProcMethod.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxInterlacedProgressiveProcMethod.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxInterlacedProgressiveProcMethod.ScrollBarHandleWidth = 20
        UiComboBoxInterlacedProgressiveProcMethod.Size = New Size(330, 30)
        UiComboBoxInterlacedProgressiveProcMethod.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxInterlacedProgressiveProcMethod.SymbolSize = 24
        UiComboBoxInterlacedProgressiveProcMethod.TabIndex = 67
        UiComboBoxInterlacedProgressiveProcMethod.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxInterlacedProgressiveProcMethod.Watermark = "Select Operation"
        ' 
        ' Label75
        ' 
        Label75.AutoSize = True
        Label75.Dock = DockStyle.Top
        Label75.Font = New Font("Segoe UI", 13F)
        Label75.Location = New Point(0, 293)
        Label75.Name = "Label75"
        Label75.Padding = New Padding(16, 20, 0, 0)
        Label75.Size = New Size(98, 44)
        Label75.TabIndex = 36
        Label75.Text = "Scan Type"
        ' 
        ' Panel37
        ' 
        Panel37.Controls.Add(Label87)
        Panel37.Controls.Add(UiTextBoxSharpenStrength)
        Panel37.Controls.Add(Label118)
        Panel37.Controls.Add(UiTextBoxSharpenVerticalSize)
        Panel37.Controls.Add(Label117)
        Panel37.Controls.Add(UiTextBoxSharpenHorizontalSize)
        Panel37.Dock = DockStyle.Top
        Panel37.Location = New Point(0, 253)
        Panel37.Name = "Panel37"
        Panel37.Padding = New Padding(21, 10, 20, 0)
        Panel37.Size = New Size(899, 40)
        Panel37.TabIndex = 35
        ' 
        ' Label87
        ' 
        Label87.Dock = DockStyle.Left
        Label87.Font = New Font("Segoe UI", 9.75F)
        Label87.ForeColor = Color.DarkGray
        Label87.Location = New Point(401, 10)
        Label87.Name = "Label87"
        Label87.Padding = New Padding(5, 0, 0, 0)
        Label87.Size = New Size(100, 30)
        Label87.TabIndex = 103
        Label87.Text = "Sharpen Strength"
        Label87.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSharpenStrength
        ' 
        UiTextBoxSharpenStrength.Dock = DockStyle.Left
        UiTextBoxSharpenStrength.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.Font = New Font("Segoe UI", 10F)
        UiTextBoxSharpenStrength.ForeColor = Color.Silver
        UiTextBoxSharpenStrength.ForeDisableColor = Color.Silver
        UiTextBoxSharpenStrength.ForeReadOnlyColor = Color.Silver
        UiTextBoxSharpenStrength.Location = New Point(341, 10)
        UiTextBoxSharpenStrength.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSharpenStrength.MinimumSize = New Size(1, 16)
        UiTextBoxSharpenStrength.Name = "UiTextBoxSharpenStrength"
        UiTextBoxSharpenStrength.Padding = New Padding(5)
        UiTextBoxSharpenStrength.Radius = 30
        UiTextBoxSharpenStrength.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenStrength.ShowText = False
        UiTextBoxSharpenStrength.Size = New Size(60, 30)
        UiTextBoxSharpenStrength.TabIndex = 102
        UiTextBoxSharpenStrength.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSharpenStrength.Watermark = ""
        ' 
        ' Label118
        ' 
        Label118.Dock = DockStyle.Left
        Label118.Font = New Font("Segoe UI", 9.75F)
        Label118.ForeColor = Color.DarkGray
        Label118.Location = New Point(241, 10)
        Label118.Name = "Label118"
        Label118.Padding = New Padding(5, 0, 0, 0)
        Label118.Size = New Size(100, 30)
        Label118.TabIndex = 105
        Label118.Text = "Vertical Size"
        Label118.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSharpenVerticalSize
        ' 
        UiTextBoxSharpenVerticalSize.Dock = DockStyle.Left
        UiTextBoxSharpenVerticalSize.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.Font = New Font("Segoe UI", 10F)
        UiTextBoxSharpenVerticalSize.ForeColor = Color.Silver
        UiTextBoxSharpenVerticalSize.ForeDisableColor = Color.Silver
        UiTextBoxSharpenVerticalSize.ForeReadOnlyColor = Color.Silver
        UiTextBoxSharpenVerticalSize.Location = New Point(181, 10)
        UiTextBoxSharpenVerticalSize.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSharpenVerticalSize.MinimumSize = New Size(1, 16)
        UiTextBoxSharpenVerticalSize.Name = "UiTextBoxSharpenVerticalSize"
        UiTextBoxSharpenVerticalSize.Padding = New Padding(5)
        UiTextBoxSharpenVerticalSize.Radius = 30
        UiTextBoxSharpenVerticalSize.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenVerticalSize.ShowText = False
        UiTextBoxSharpenVerticalSize.Size = New Size(60, 30)
        UiTextBoxSharpenVerticalSize.TabIndex = 101
        UiTextBoxSharpenVerticalSize.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSharpenVerticalSize.Watermark = ""
        ' 
        ' Label117
        ' 
        Label117.Dock = DockStyle.Left
        Label117.Font = New Font("Segoe UI", 9.75F)
        Label117.ForeColor = Color.DarkGray
        Label117.Location = New Point(81, 10)
        Label117.Name = "Label117"
        Label117.Padding = New Padding(5, 0, 0, 0)
        Label117.Size = New Size(100, 30)
        Label117.TabIndex = 104
        Label117.Text = "Horizontal Size"
        Label117.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxSharpenHorizontalSize
        ' 
        UiTextBoxSharpenHorizontalSize.Dock = DockStyle.Left
        UiTextBoxSharpenHorizontalSize.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.Font = New Font("Segoe UI", 10F)
        UiTextBoxSharpenHorizontalSize.ForeColor = Color.Silver
        UiTextBoxSharpenHorizontalSize.ForeDisableColor = Color.Silver
        UiTextBoxSharpenHorizontalSize.ForeReadOnlyColor = Color.Silver
        UiTextBoxSharpenHorizontalSize.Location = New Point(21, 10)
        UiTextBoxSharpenHorizontalSize.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxSharpenHorizontalSize.MinimumSize = New Size(1, 16)
        UiTextBoxSharpenHorizontalSize.Name = "UiTextBoxSharpenHorizontalSize"
        UiTextBoxSharpenHorizontalSize.Padding = New Padding(5)
        UiTextBoxSharpenHorizontalSize.Radius = 30
        UiTextBoxSharpenHorizontalSize.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxSharpenHorizontalSize.ShowText = False
        UiTextBoxSharpenHorizontalSize.Size = New Size(60, 30)
        UiTextBoxSharpenHorizontalSize.TabIndex = 100
        UiTextBoxSharpenHorizontalSize.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxSharpenHorizontalSize.Watermark = ""
        ' 
        ' Label72
        ' 
        Label72.AutoSize = True
        Label72.Dock = DockStyle.Top
        Label72.Font = New Font("Segoe UI", 10F)
        Label72.ForeColor = Color.Gray
        Label72.Location = New Point(0, 228)
        Label72.Name = "Label72"
        Label72.Padding = New Padding(16, 5, 0, 0)
        Label72.Size = New Size(393, 25)
        Label72.TabIndex = 34
        Label72.Text = "Emphasize object edges to increase clarity; Recommended Value: Size 3 Strength 1" & vbCrLf
        ' 
        ' Label73
        ' 
        Label73.AutoSize = True
        Label73.Dock = DockStyle.Top
        Label73.Font = New Font("Segoe UI", 13F)
        Label73.Location = New Point(0, 184)
        Label73.Name = "Label73"
        Label73.Padding = New Padding(16, 20, 0, 0)
        Label73.Size = New Size(62, 44)
        Label73.TabIndex = 33
        Label73.Text = "Sharpen"
        ' 
        ' Panel36
        ' 
        Panel36.Controls.Add(UiTextBoxDenoiseParameter4)
        Panel36.Controls.Add(Label69)
        Panel36.Controls.Add(UiTextBoxDenoiseParameter3)
        Panel36.Controls.Add(Label70)
        Panel36.Controls.Add(UiTextBoxDenoiseParameter2)
        Panel36.Controls.Add(Label71)
        Panel36.Controls.Add(UiTextBoxDenoiseParameter1)
        Panel36.Dock = DockStyle.Top
        Panel36.Location = New Point(0, 154)
        Panel36.Name = "Panel36"
        Panel36.Padding = New Padding(21, 0, 20, 0)
        Panel36.Size = New Size(899, 30)
        Panel36.TabIndex = 32
        Panel36.Visible = False
        ' 
        ' UiTextBoxDenoiseParameter4
        ' 
        UiTextBoxDenoiseParameter4.Dock = DockStyle.Left
        UiTextBoxDenoiseParameter4.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.Font = New Font("Segoe UI", 10F)
        UiTextBoxDenoiseParameter4.ForeColor = Color.Silver
        UiTextBoxDenoiseParameter4.ForeDisableColor = Color.Silver
        UiTextBoxDenoiseParameter4.ForeReadOnlyColor = Color.Silver
        UiTextBoxDenoiseParameter4.Location = New Point(501, 0)
        UiTextBoxDenoiseParameter4.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxDenoiseParameter4.MinimumSize = New Size(1, 16)
        UiTextBoxDenoiseParameter4.Name = "UiTextBoxDenoiseParameter4"
        UiTextBoxDenoiseParameter4.Padding = New Padding(5)
        UiTextBoxDenoiseParameter4.Radius = 30
        UiTextBoxDenoiseParameter4.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter4.ShowText = False
        UiTextBoxDenoiseParameter4.Size = New Size(150, 30)
        UiTextBoxDenoiseParameter4.TabIndex = 100
        UiTextBoxDenoiseParameter4.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxDenoiseParameter4.Watermark = "Parameters4"
        ' 
        ' Label69
        ' 
        Label69.Dock = DockStyle.Left
        Label69.Location = New Point(491, 0)
        Label69.Name = "Label69"
        Label69.Size = New Size(10, 30)
        Label69.TabIndex = 103
        ' 
        ' UiTextBoxDenoiseParameter3
        ' 
        UiTextBoxDenoiseParameter3.Dock = DockStyle.Left
        UiTextBoxDenoiseParameter3.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.Font = New Font("Segoe UI", 10F)
        UiTextBoxDenoiseParameter3.ForeColor = Color.Silver
        UiTextBoxDenoiseParameter3.ForeDisableColor = Color.Silver
        UiTextBoxDenoiseParameter3.ForeReadOnlyColor = Color.Silver
        UiTextBoxDenoiseParameter3.Location = New Point(341, 0)
        UiTextBoxDenoiseParameter3.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxDenoiseParameter3.MinimumSize = New Size(1, 16)
        UiTextBoxDenoiseParameter3.Name = "UiTextBoxDenoiseParameter3"
        UiTextBoxDenoiseParameter3.Padding = New Padding(5)
        UiTextBoxDenoiseParameter3.Radius = 30
        UiTextBoxDenoiseParameter3.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter3.ShowText = False
        UiTextBoxDenoiseParameter3.Size = New Size(150, 30)
        UiTextBoxDenoiseParameter3.TabIndex = 99
        UiTextBoxDenoiseParameter3.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxDenoiseParameter3.Watermark = "Parameters3"
        ' 
        ' Label70
        ' 
        Label70.Dock = DockStyle.Left
        Label70.Location = New Point(331, 0)
        Label70.Name = "Label70"
        Label70.Size = New Size(10, 30)
        Label70.TabIndex = 102
        ' 
        ' UiTextBoxDenoiseParameter2
        ' 
        UiTextBoxDenoiseParameter2.Dock = DockStyle.Left
        UiTextBoxDenoiseParameter2.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.Font = New Font("Segoe UI", 10F)
        UiTextBoxDenoiseParameter2.ForeColor = Color.Silver
        UiTextBoxDenoiseParameter2.ForeDisableColor = Color.Silver
        UiTextBoxDenoiseParameter2.ForeReadOnlyColor = Color.Silver
        UiTextBoxDenoiseParameter2.Location = New Point(181, 0)
        UiTextBoxDenoiseParameter2.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxDenoiseParameter2.MinimumSize = New Size(1, 16)
        UiTextBoxDenoiseParameter2.Name = "UiTextBoxDenoiseParameter2"
        UiTextBoxDenoiseParameter2.Padding = New Padding(5)
        UiTextBoxDenoiseParameter2.Radius = 30
        UiTextBoxDenoiseParameter2.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter2.ShowText = False
        UiTextBoxDenoiseParameter2.Size = New Size(150, 30)
        UiTextBoxDenoiseParameter2.TabIndex = 98
        UiTextBoxDenoiseParameter2.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxDenoiseParameter2.Watermark = "Parameters2"
        ' 
        ' Label71
        ' 
        Label71.Dock = DockStyle.Left
        Label71.Location = New Point(171, 0)
        Label71.Name = "Label71"
        Label71.Size = New Size(10, 30)
        Label71.TabIndex = 101
        ' 
        ' UiTextBoxDenoiseParameter1
        ' 
        UiTextBoxDenoiseParameter1.Dock = DockStyle.Left
        UiTextBoxDenoiseParameter1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.Font = New Font("Segoe UI", 10F)
        UiTextBoxDenoiseParameter1.ForeColor = Color.Silver
        UiTextBoxDenoiseParameter1.ForeDisableColor = Color.Silver
        UiTextBoxDenoiseParameter1.ForeReadOnlyColor = Color.Silver
        UiTextBoxDenoiseParameter1.Location = New Point(21, 0)
        UiTextBoxDenoiseParameter1.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxDenoiseParameter1.MinimumSize = New Size(1, 16)
        UiTextBoxDenoiseParameter1.Name = "UiTextBoxDenoiseParameter1"
        UiTextBoxDenoiseParameter1.Padding = New Padding(5)
        UiTextBoxDenoiseParameter1.Radius = 30
        UiTextBoxDenoiseParameter1.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxDenoiseParameter1.ShowText = False
        UiTextBoxDenoiseParameter1.Size = New Size(150, 30)
        UiTextBoxDenoiseParameter1.TabIndex = 97
        UiTextBoxDenoiseParameter1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxDenoiseParameter1.Watermark = "Parameters1"
        ' 
        ' Panel35
        ' 
        Panel35.Controls.Add(LabelDenoiseParameters4)
        Panel35.Controls.Add(LabelDenoiseParameters3)
        Panel35.Controls.Add(LabelDenoiseParameters2)
        Panel35.Controls.Add(LabelDenoiseParameters1)
        Panel35.Dock = DockStyle.Top
        Panel35.Location = New Point(0, 99)
        Panel35.Name = "Panel35"
        Panel35.Padding = New Padding(17, 0, 10, 0)
        Panel35.Size = New Size(899, 55)
        Panel35.TabIndex = 31
        Panel35.Visible = False
        ' 
        ' LabelDenoiseParameters4
        ' 
        LabelDenoiseParameters4.Dock = DockStyle.Left
        LabelDenoiseParameters4.Font = New Font("Segoe UI", 9.75F)
        LabelDenoiseParameters4.Location = New Point(501, 0)
        LabelDenoiseParameters4.Name = "LabelDenoiseParameters4"
        LabelDenoiseParameters4.Size = New Size(150, 55)
        LabelDenoiseParameters4.TabIndex = 82
        LabelDenoiseParameters4.Text = "Parameters4" & vbCrLf & "name"
        LabelDenoiseParameters4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelDenoiseParameters3
        ' 
        LabelDenoiseParameters3.Dock = DockStyle.Left
        LabelDenoiseParameters3.Font = New Font("Segoe UI", 9.75F)
        LabelDenoiseParameters3.Location = New Point(341, 0)
        LabelDenoiseParameters3.Name = "LabelDenoiseParameters3"
        LabelDenoiseParameters3.Size = New Size(160, 55)
        LabelDenoiseParameters3.TabIndex = 81
        LabelDenoiseParameters3.Text = "Parameters3" & vbCrLf & "name"
        LabelDenoiseParameters3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelDenoiseParameters2
        ' 
        LabelDenoiseParameters2.Dock = DockStyle.Left
        LabelDenoiseParameters2.Font = New Font("Segoe UI", 9.75F)
        LabelDenoiseParameters2.Location = New Point(181, 0)
        LabelDenoiseParameters2.Name = "LabelDenoiseParameters2"
        LabelDenoiseParameters2.Size = New Size(160, 55)
        LabelDenoiseParameters2.TabIndex = 80
        LabelDenoiseParameters2.Text = "Parameters2" & vbCrLf & "name"
        LabelDenoiseParameters2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelDenoiseParameters1
        ' 
        LabelDenoiseParameters1.Dock = DockStyle.Left
        LabelDenoiseParameters1.Font = New Font("Segoe UI", 9.75F)
        LabelDenoiseParameters1.Location = New Point(17, 0)
        LabelDenoiseParameters1.Name = "LabelDenoiseParameters1"
        LabelDenoiseParameters1.Size = New Size(164, 55)
        LabelDenoiseParameters1.TabIndex = 78
        LabelDenoiseParameters1.Text = "Parameters1" & vbCrLf & "name"
        LabelDenoiseParameters1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel34
        ' 
        Panel34.Controls.Add(UiComboBoxDenoiseMethod)
        Panel34.Dock = DockStyle.Top
        Panel34.Location = New Point(0, 59)
        Panel34.Name = "Panel34"
        Panel34.Padding = New Padding(21, 10, 20, 0)
        Panel34.Size = New Size(899, 40)
        Panel34.TabIndex = 19
        ' 
        ' UiComboBoxDenoiseMethod
        ' 
        UiComboBoxDenoiseMethod.DataSource = Nothing
        UiComboBoxDenoiseMethod.Dock = DockStyle.Left
        UiComboBoxDenoiseMethod.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxDenoiseMethod.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDenoiseMethod.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDenoiseMethod.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDenoiseMethod.Font = New Font("Segoe UI", 10F)
        UiComboBoxDenoiseMethod.ForeColor = Color.Silver
        UiComboBoxDenoiseMethod.ForeDisableColor = Color.Silver
        UiComboBoxDenoiseMethod.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxDenoiseMethod.ItemForeColor = Color.Silver
        UiComboBoxDenoiseMethod.ItemHeight = 30
        UiComboBoxDenoiseMethod.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxDenoiseMethod.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxDenoiseMethod.Items.AddRange(New Object() {"", "hqdn3d - Spatiotemporal Denoise, suitable for common noise", "nlmeans - Advanced Denoise, better quality but slower", "atadenoise - Lightweight Temporal Denoise", "bm3d - High Quality Denoise, suitable for critical noise"})
        UiComboBoxDenoiseMethod.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDenoiseMethod.ItemSelectForeColor = Color.Silver
        UiComboBoxDenoiseMethod.Location = New Point(21, 10)
        UiComboBoxDenoiseMethod.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxDenoiseMethod.MaxDropDownItems = 17
        UiComboBoxDenoiseMethod.MinimumSize = New Size(63, 0)
        UiComboBoxDenoiseMethod.Name = "UiComboBoxDenoiseMethod"
        UiComboBoxDenoiseMethod.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxDenoiseMethod.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxDenoiseMethod.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDenoiseMethod.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxDenoiseMethod.ScrollBarHandleWidth = 20
        UiComboBoxDenoiseMethod.Size = New Size(330, 30)
        UiComboBoxDenoiseMethod.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxDenoiseMethod.SymbolSize = 24
        UiComboBoxDenoiseMethod.TabIndex = 67
        UiComboBoxDenoiseMethod.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxDenoiseMethod.Watermark = "Select Denoise Method"
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Dock = DockStyle.Top
        Label66.Font = New Font("Segoe UI", 10F)
        Label66.ForeColor = Color.Gray
        Label66.Location = New Point(0, 34)
        Label66.Name = "Label66"
        Label66.Padding = New Padding(16, 5, 0, 0)
        Label66.Size = New Size(333, 25)
        Label66.TabIndex = 18
        Label66.Text = "Remove noise from the picture; Watermark text is NOT the default value!"
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Dock = DockStyle.Top
        Label67.Font = New Font("Segoe UI", 13F)
        Label67.Location = New Point(0, 0)
        Label67.Name = "Label67"
        Label67.Padding = New Padding(16, 10, 0, 0)
        Label67.Size = New Size(62, 34)
        Label67.TabIndex = 17
        Label67.Text = "Denoise"
        ' 
        ' TabPageVideoFrameServer
        ' 
        TabPageVideoFrameServer.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageVideoFrameServer.Controls.Add(Label189)
        TabPageVideoFrameServer.Controls.Add(Panel94)
        TabPageVideoFrameServer.Controls.Add(Panel95)
        TabPageVideoFrameServer.Controls.Add(Label188)
        TabPageVideoFrameServer.Controls.Add(Label186)
        TabPageVideoFrameServer.Controls.Add(Panel49)
        TabPageVideoFrameServer.Controls.Add(Panel48)
        TabPageVideoFrameServer.Controls.Add(Label187)
        TabPageVideoFrameServer.Controls.Add(Label185)
        TabPageVideoFrameServer.Controls.Add(Label183)
        TabPageVideoFrameServer.Controls.Add(Label182)
        TabPageVideoFrameServer.Location = New Point(201, 0)
        TabPageVideoFrameServer.Name = "TabPageVideoFrameServer"
        TabPageVideoFrameServer.Size = New Size(899, 650)
        TabPageVideoFrameServer.TabIndex = 14
        TabPageVideoFrameServer.Tag = "TabPage.VideoFrameServer"
        TabPageVideoFrameServer.Text = "Video Parameters | Frame Server"
        ' 
        ' Label189
        ' 
        Label189.AutoSize = True
        Label189.Dock = DockStyle.Bottom
        Label189.Font = New Font("Segoe UI", 10F)
        Label189.ForeColor = Color.Gray
        Label189.Location = New Point(0, 594)
        Label189.Name = "Label189"
        Label189.Padding = New Padding(16, 0, 0, 16)
        Label189.Size = New Size(422, 56)
        Label189.TabIndex = 119
        Label189.Text = "Do not forget to put relevant dlls with ffmpeg." & vbCrLf & "3FUI requires write permission for the input file location; be careful if accessing remotely."
        ' 
        ' Panel94
        ' 
        Panel94.Controls.Add(UiComboBoxSelectVpyFile)
        Panel94.Dock = DockStyle.Top
        Panel94.Location = New Point(0, 437)
        Panel94.Name = "Panel94"
        Panel94.Padding = New Padding(20, 10, 20, 0)
        Panel94.Size = New Size(899, 40)
        Panel94.TabIndex = 118
        ' 
        ' UiComboBoxSelectVpyFile
        ' 
        UiComboBoxSelectVpyFile.AllowDrop = True
        UiComboBoxSelectVpyFile.DataSource = Nothing
        UiComboBoxSelectVpyFile.Dock = DockStyle.Fill
        UiComboBoxSelectVpyFile.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxSelectVpyFile.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxSelectVpyFile.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxSelectVpyFile.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectVpyFile.Font = New Font("Segoe UI", 10F)
        UiComboBoxSelectVpyFile.ForeColor = Color.Silver
        UiComboBoxSelectVpyFile.ForeDisableColor = Color.Silver
        UiComboBoxSelectVpyFile.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectVpyFile.ItemForeColor = Color.Silver
        UiComboBoxSelectVpyFile.ItemHeight = 30
        UiComboBoxSelectVpyFile.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxSelectVpyFile.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectVpyFile.Items.AddRange(New Object() {"  Browse ..."})
        UiComboBoxSelectVpyFile.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSelectVpyFile.ItemSelectForeColor = Color.Silver
        UiComboBoxSelectVpyFile.Location = New Point(20, 10)
        UiComboBoxSelectVpyFile.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxSelectVpyFile.MaxDropDownItems = 17
        UiComboBoxSelectVpyFile.MinimumSize = New Size(63, 0)
        UiComboBoxSelectVpyFile.Name = "UiComboBoxSelectVpyFile"
        UiComboBoxSelectVpyFile.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxSelectVpyFile.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxSelectVpyFile.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectVpyFile.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectVpyFile.ScrollBarBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectVpyFile.ScrollBarColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSelectVpyFile.ScrollBarHandleWidth = 20
        UiComboBoxSelectVpyFile.ScrollBarStyleInherited = False
        UiComboBoxSelectVpyFile.Size = New Size(859, 30)
        UiComboBoxSelectVpyFile.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxSelectVpyFile.SymbolSize = 24
        UiComboBoxSelectVpyFile.TabIndex = 94
        UiComboBoxSelectVpyFile.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxSelectVpyFile.Watermark = "Select .vpy/.py File"
        ' 
        ' Panel95
        ' 
        Panel95.Controls.Add(UiCheckBoxUseVapourSynth)
        Panel95.Dock = DockStyle.Top
        Panel95.Location = New Point(0, 397)
        Panel95.Name = "Panel95"
        Panel95.Padding = New Padding(18, 10, 20, 0)
        Panel95.Size = New Size(899, 40)
        Panel95.TabIndex = 116
        ' 
        ' UiCheckBoxUseVapourSynth
        ' 
        UiCheckBoxUseVapourSynth.CheckBoxColor = Color.Silver
        UiCheckBoxUseVapourSynth.CheckBoxSize = 20
        UiCheckBoxUseVapourSynth.Dock = DockStyle.Left
        UiCheckBoxUseVapourSynth.Font = New Font("Segoe UI", 10F)
        UiCheckBoxUseVapourSynth.ForeColor = Color.DarkGray
        UiCheckBoxUseVapourSynth.Location = New Point(18, 10)
        UiCheckBoxUseVapourSynth.MinimumSize = New Size(1, 1)
        UiCheckBoxUseVapourSynth.Name = "UiCheckBoxUseVapourSynth"
        UiCheckBoxUseVapourSynth.Size = New Size(200, 30)
        UiCheckBoxUseVapourSynth.TabIndex = 98
        UiCheckBoxUseVapourSynth.Text = "Use VapourSynth"
        ' 
        ' Label188
        ' 
        Label188.AutoSize = True
        Label188.Dock = DockStyle.Top
        Label188.Font = New Font("Segoe UI", 10F)
        Label188.ForeColor = Color.Gray
        Label188.Location = New Point(0, 352)
        Label188.Name = "Label188"
        Label188.Padding = New Padding(16, 5, 0, 0)
        Label188.Size = New Size(473, 45)
        Label188.TabIndex = 117
        Label188.Text = "Use <FilePath> in .vpy/.py script to represent input file path." & vbCrLf & "Create 'VapourSynth' folder and place .vpy/.py files there for quick selection." & vbCrLf
        ' 
        ' Label186
        ' 
        Label186.AutoSize = True
        Label186.Dock = DockStyle.Top
        Label186.Font = New Font("Segoe UI", 13F)
        Label186.Location = New Point(0, 308)
        Label186.Name = "Label186"
        Label186.Padding = New Padding(16, 20, 0, 0)
        Label186.Size = New Size(138, 44)
        Label186.TabIndex = 112
        Label186.Text = "VapourSynth"
        ' 
        ' Panel49
        ' 
        Panel49.Controls.Add(UiComboBoxSelectAvsFile)
        Panel49.Dock = DockStyle.Top
        Panel49.Location = New Point(0, 268)
        Panel49.Name = "Panel49"
        Panel49.Padding = New Padding(20, 10, 20, 0)
        Panel49.Size = New Size(899, 40)
        Panel49.TabIndex = 115
        ' 
        ' UiComboBoxSelectAvsFile
        ' 
        UiComboBoxSelectAvsFile.AllowDrop = True
        UiComboBoxSelectAvsFile.DataSource = Nothing
        UiComboBoxSelectAvsFile.Dock = DockStyle.Fill
        UiComboBoxSelectAvsFile.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxSelectAvsFile.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxSelectAvsFile.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiComboBoxSelectAvsFile.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectAvsFile.Font = New Font("Segoe UI", 10F)
        UiComboBoxSelectAvsFile.ForeColor = Color.Silver
        UiComboBoxSelectAvsFile.ForeDisableColor = Color.Silver
        UiComboBoxSelectAvsFile.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectAvsFile.ItemForeColor = Color.Silver
        UiComboBoxSelectAvsFile.ItemHeight = 30
        UiComboBoxSelectAvsFile.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxSelectAvsFile.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectAvsFile.Items.AddRange(New Object() {"  Browse ..."})
        UiComboBoxSelectAvsFile.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSelectAvsFile.ItemSelectForeColor = Color.Silver
        UiComboBoxSelectAvsFile.Location = New Point(20, 10)
        UiComboBoxSelectAvsFile.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxSelectAvsFile.MaxDropDownItems = 17
        UiComboBoxSelectAvsFile.MinimumSize = New Size(63, 0)
        UiComboBoxSelectAvsFile.Name = "UiComboBoxSelectAvsFile"
        UiComboBoxSelectAvsFile.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxSelectAvsFile.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxSelectAvsFile.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectAvsFile.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSelectAvsFile.ScrollBarBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSelectAvsFile.ScrollBarColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSelectAvsFile.ScrollBarHandleWidth = 20
        UiComboBoxSelectAvsFile.ScrollBarStyleInherited = False
        UiComboBoxSelectAvsFile.Size = New Size(859, 30)
        UiComboBoxSelectAvsFile.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxSelectAvsFile.SymbolSize = 24
        UiComboBoxSelectAvsFile.TabIndex = 94
        UiComboBoxSelectAvsFile.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxSelectAvsFile.Watermark = "Select .avs File"
        ' 
        ' Panel48
        ' 
        Panel48.Controls.Add(UiCheckBoxUseAviSynth)
        Panel48.Dock = DockStyle.Top
        Panel48.Location = New Point(0, 228)
        Panel48.Name = "Panel48"
        Panel48.Padding = New Padding(18, 10, 20, 0)
        Panel48.Size = New Size(899, 40)
        Panel48.TabIndex = 113
        ' 
        ' UiCheckBoxUseAviSynth
        ' 
        UiCheckBoxUseAviSynth.CheckBoxColor = Color.Silver
        UiCheckBoxUseAviSynth.CheckBoxSize = 20
        UiCheckBoxUseAviSynth.Dock = DockStyle.Left
        UiCheckBoxUseAviSynth.Font = New Font("Segoe UI", 10F)
        UiCheckBoxUseAviSynth.ForeColor = Color.DarkGray
        UiCheckBoxUseAviSynth.Location = New Point(18, 10)
        UiCheckBoxUseAviSynth.MinimumSize = New Size(1, 1)
        UiCheckBoxUseAviSynth.Name = "UiCheckBoxUseAviSynth"
        UiCheckBoxUseAviSynth.Size = New Size(200, 30)
        UiCheckBoxUseAviSynth.TabIndex = 98
        UiCheckBoxUseAviSynth.Text = "Use AviSynth"
        ' 
        ' Label187
        ' 
        Label187.AutoSize = True
        Label187.Dock = DockStyle.Top
        Label187.Font = New Font("Segoe UI", 10F)
        Label187.ForeColor = Color.Gray
        Label187.Location = New Point(0, 183)
        Label187.Name = "Label187"
        Label187.Padding = New Padding(16, 5, 0, 0)
        Label187.Size = New Size(418, 45)
        Label187.TabIndex = 114
        Label187.Text = "Use <FilePath> in .avs script to represent input file path." & vbCrLf & "Create 'AviSynth' folder and place .avs files there for quick selection." & vbCrLf
        ' 
        ' Label185
        ' 
        Label185.AutoSize = True
        Label185.Dock = DockStyle.Top
        Label185.Font = New Font("Segoe UI", 13F)
        Label185.Location = New Point(0, 139)
        Label185.Name = "Label185"
        Label185.Padding = New Padding(16, 20, 0, 0)
        Label185.Size = New Size(102, 44)
        Label185.TabIndex = 111
        Label185.Text = "AviSynth"
        ' 
        ' Label183
        ' 
        Label183.AutoSize = True
        Label183.Dock = DockStyle.Top
        Label183.Font = New Font("Segoe UI", 10F)
        Label183.ForeColor = Color.Gray
        Label183.Location = New Point(0, 34)
        Label183.Name = "Label183"
        Label183.Padding = New Padding(16, 5, 0, 0)
        Label183.Size = New Size(585, 105)
        Label183.TabIndex = 19
        Label183.Text = "Video Frame Server, also known as Video Script Processing Framework or Preprocessing Software." & vbCrLf & "Aims to preprocess video frames (or audio) and pass them directly to the encoder." & vbCrLf & "Commonly used by release groups to improve quality, repair content, etc." & vbCrLf & "3FUI facilitates these tools by replacing input files and script templates." & vbCrLf & "This is advanced content; if you are a beginner, you don't need to consider this."
        ' 
        ' Label182
        ' 
        Label182.AutoSize = True
        Label182.Dock = DockStyle.Top
        Label182.Font = New Font("Segoe UI", 13F)
        Label182.Location = New Point(0, 0)
        Label182.Name = "Label182"
        Label182.Padding = New Padding(16, 10, 0, 0)
        Label182.Size = New Size(98, 34)
        Label182.TabIndex = 18
        Label182.Text = "What is this?"
        ' 
        ' TabPageAudioParameters
        ' 
        TabPageAudioParameters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageAudioParameters.Controls.Add(Panel93)
        TabPageAudioParameters.Controls.Add(Panel92)
        TabPageAudioParameters.Controls.Add(Label179)
        TabPageAudioParameters.Controls.Add(Label90)
        TabPageAudioParameters.Controls.Add(Panel46)
        TabPageAudioParameters.Controls.Add(Label89)
        TabPageAudioParameters.Controls.Add(Panel45)
        TabPageAudioParameters.Controls.Add(Label86)
        TabPageAudioParameters.Controls.Add(Panel44)
        TabPageAudioParameters.Controls.Add(Panel43)
        TabPageAudioParameters.Controls.Add(Label88)
        TabPageAudioParameters.Controls.Add(Panel42)
        TabPageAudioParameters.Controls.Add(Label85)
        TabPageAudioParameters.Location = New Point(201, 0)
        TabPageAudioParameters.Name = "TabPageAudioParameters"
        TabPageAudioParameters.Size = New Size(899, 650)
        TabPageAudioParameters.TabIndex = 8
        TabPageAudioParameters.Tag = "TabPage.AudioParameters"
        TabPageAudioParameters.Text = "Audio Parameters"
        ' 
        ' Panel93
        ' 
        Panel93.Controls.Add(UiTextBoxLoudnessNormalizationPeakValueLevel)
        Panel93.Controls.Add(Label178)
        Panel93.Controls.Add(UiTextBoxLoudnessNormalizationDynamicRange)
        Panel93.Controls.Add(Label173)
        Panel93.Controls.Add(UiTextBoxLoudnessNormalizationTargetLoudness)
        Panel93.Dock = DockStyle.Top
        Panel93.Location = New Point(0, 510)
        Panel93.Name = "Panel93"
        Panel93.Padding = New Padding(21, 0, 20, 0)
        Panel93.Size = New Size(899, 30)
        Panel93.TabIndex = 28
        ' 
        ' UiTextBoxLoudnessNormalizationPeakValueLevel
        ' 
        UiTextBoxLoudnessNormalizationPeakValueLevel.Dock = DockStyle.Left
        UiTextBoxLoudnessNormalizationPeakValueLevel.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.Font = New Font("Segoe UI", 10F)
        UiTextBoxLoudnessNormalizationPeakValueLevel.ForeColor = Color.Silver
        UiTextBoxLoudnessNormalizationPeakValueLevel.ForeDisableColor = Color.Silver
        UiTextBoxLoudnessNormalizationPeakValueLevel.ForeReadOnlyColor = Color.Silver
        UiTextBoxLoudnessNormalizationPeakValueLevel.Location = New Point(261, 0)
        UiTextBoxLoudnessNormalizationPeakValueLevel.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxLoudnessNormalizationPeakValueLevel.MinimumSize = New Size(1, 16)
        UiTextBoxLoudnessNormalizationPeakValueLevel.Name = "UiTextBoxLoudnessNormalizationPeakValueLevel"
        UiTextBoxLoudnessNormalizationPeakValueLevel.Padding = New Padding(5)
        UiTextBoxLoudnessNormalizationPeakValueLevel.Radius = 30
        UiTextBoxLoudnessNormalizationPeakValueLevel.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationPeakValueLevel.ShowText = False
        UiTextBoxLoudnessNormalizationPeakValueLevel.Size = New Size(120, 30)
        UiTextBoxLoudnessNormalizationPeakValueLevel.TabIndex = 106
        UiTextBoxLoudnessNormalizationPeakValueLevel.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxLoudnessNormalizationPeakValueLevel.Watermark = "dBTP"
        ' 
        ' Label178
        ' 
        Label178.Dock = DockStyle.Left
        Label178.Location = New Point(251, 0)
        Label178.Name = "Label178"
        Label178.Size = New Size(10, 30)
        Label178.TabIndex = 105
        ' 
        ' UiTextBoxLoudnessNormalizationDynamicRange
        ' 
        UiTextBoxLoudnessNormalizationDynamicRange.Dock = DockStyle.Left
        UiTextBoxLoudnessNormalizationDynamicRange.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.Font = New Font("Segoe UI", 10F)
        UiTextBoxLoudnessNormalizationDynamicRange.ForeColor = Color.Silver
        UiTextBoxLoudnessNormalizationDynamicRange.ForeDisableColor = Color.Silver
        UiTextBoxLoudnessNormalizationDynamicRange.ForeReadOnlyColor = Color.Silver
        UiTextBoxLoudnessNormalizationDynamicRange.Location = New Point(141, 0)
        UiTextBoxLoudnessNormalizationDynamicRange.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxLoudnessNormalizationDynamicRange.MinimumSize = New Size(1, 16)
        UiTextBoxLoudnessNormalizationDynamicRange.Name = "UiTextBoxLoudnessNormalizationDynamicRange"
        UiTextBoxLoudnessNormalizationDynamicRange.Padding = New Padding(5)
        UiTextBoxLoudnessNormalizationDynamicRange.Radius = 30
        UiTextBoxLoudnessNormalizationDynamicRange.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationDynamicRange.ShowText = False
        UiTextBoxLoudnessNormalizationDynamicRange.Size = New Size(110, 30)
        UiTextBoxLoudnessNormalizationDynamicRange.TabIndex = 104
        UiTextBoxLoudnessNormalizationDynamicRange.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxLoudnessNormalizationDynamicRange.Watermark = "LU"
        ' 
        ' Label173
        ' 
        Label173.Dock = DockStyle.Left
        Label173.Location = New Point(131, 0)
        Label173.Name = "Label173"
        Label173.Size = New Size(10, 30)
        Label173.TabIndex = 103
        ' 
        ' UiTextBoxLoudnessNormalizationTargetLoudness
        ' 
        UiTextBoxLoudnessNormalizationTargetLoudness.Dock = DockStyle.Left
        UiTextBoxLoudnessNormalizationTargetLoudness.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.Font = New Font("Segoe UI", 10F)
        UiTextBoxLoudnessNormalizationTargetLoudness.ForeColor = Color.Silver
        UiTextBoxLoudnessNormalizationTargetLoudness.ForeDisableColor = Color.Silver
        UiTextBoxLoudnessNormalizationTargetLoudness.ForeReadOnlyColor = Color.Silver
        UiTextBoxLoudnessNormalizationTargetLoudness.Location = New Point(21, 0)
        UiTextBoxLoudnessNormalizationTargetLoudness.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxLoudnessNormalizationTargetLoudness.MinimumSize = New Size(1, 16)
        UiTextBoxLoudnessNormalizationTargetLoudness.Name = "UiTextBoxLoudnessNormalizationTargetLoudness"
        UiTextBoxLoudnessNormalizationTargetLoudness.Padding = New Padding(5)
        UiTextBoxLoudnessNormalizationTargetLoudness.Radius = 30
        UiTextBoxLoudnessNormalizationTargetLoudness.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxLoudnessNormalizationTargetLoudness.ShowText = False
        UiTextBoxLoudnessNormalizationTargetLoudness.Size = New Size(110, 30)
        UiTextBoxLoudnessNormalizationTargetLoudness.TabIndex = 95
        UiTextBoxLoudnessNormalizationTargetLoudness.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxLoudnessNormalizationTargetLoudness.Watermark = "LUFS"
        ' 
        ' Panel92
        ' 
        Panel92.Controls.Add(Label174)
        Panel92.Controls.Add(Label176)
        Panel92.Controls.Add(Label177)
        Panel92.Dock = DockStyle.Top
        Panel92.Location = New Point(0, 475)
        Panel92.Name = "Panel92"
        Panel92.Padding = New Padding(17, 0, 10, 0)
        Panel92.Size = New Size(899, 35)
        Panel92.TabIndex = 27
        ' 
        ' Label174
        ' 
        Label174.Dock = DockStyle.Left
        Label174.Font = New Font("Segoe UI", 9.75F)
        Label174.Location = New Point(257, 0)
        Label174.Name = "Label174"
        Label174.Size = New Size(120, 35)
        Label174.TabIndex = 81
        Label174.Text = "Peak Level"
        Label174.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label176
        ' 
        Label176.Dock = DockStyle.Left
        Label176.Font = New Font("Segoe UI", 9.75F)
        Label176.Location = New Point(137, 0)
        Label176.Name = "Label176"
        Label176.Size = New Size(120, 35)
        Label176.TabIndex = 80
        Label176.Text = "Dynamic Range"
        Label176.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label177
        ' 
        Label177.Dock = DockStyle.Left
        Label177.Font = New Font("Segoe UI", 9.75F)
        Label177.Location = New Point(17, 0)
        Label177.Name = "Label177"
        Label177.Size = New Size(120, 35)
        Label177.TabIndex = 78
        Label177.Text = "Target Loudness"
        Label177.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label179
        ' 
        Label179.AutoSize = True
        Label179.Dock = DockStyle.Top
        Label179.Font = New Font("Segoe UI", 10F)
        Label179.ForeColor = Color.Gray
        Label179.Location = New Point(0, 410)
        Label179.Name = "Label179"
        Label179.Padding = New Padding(16, 5, 0, 0)
        Label179.Size = New Size(537, 65)
        Label179.TabIndex = 29
        Label179.Text = "Target Loudness: CN Broadcast -24, Int'l Standard -23. Higher value means louder, not recommened > -16." & vbCrLf & "Dynamic Range: Not recommended > 20, usually 1~10." & vbCrLf & "Peak Level: CN Broadcast -2, Int'l Standard -1 (Should not exceed)." & vbCrLf
        ' 
        ' Label90
        ' 
        Label90.AutoSize = True
        Label90.Dock = DockStyle.Top
        Label90.Font = New Font("Segoe UI", 13F)
        Label90.Location = New Point(0, 366)
        Label90.Name = "Label90"
        Label90.Padding = New Padding(16, 20, 0, 0)
        Label90.Size = New Size(116, 44)
        Label90.TabIndex = 23
        Label90.Text = "Loudness Normalization"
        ' 
        ' Panel46
        ' 
        Panel46.Controls.Add(UiComboBoxSampleRate)
        Panel46.Dock = DockStyle.Top
        Panel46.Location = New Point(0, 326)
        Panel46.Name = "Panel46"
        Panel46.Padding = New Padding(21, 10, 20, 0)
        Panel46.Size = New Size(899, 40)
        Panel46.TabIndex = 22
        ' 
        ' UiComboBoxSampleRate
        ' 
        UiComboBoxSampleRate.DataSource = Nothing
        UiComboBoxSampleRate.Dock = DockStyle.Left
        UiComboBoxSampleRate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSampleRate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSampleRate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSampleRate.Font = New Font("Segoe UI", 10F)
        UiComboBoxSampleRate.ForeColor = Color.Silver
        UiComboBoxSampleRate.ForeDisableColor = Color.Silver
        UiComboBoxSampleRate.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxSampleRate.ItemForeColor = Color.Silver
        UiComboBoxSampleRate.ItemHeight = 30
        UiComboBoxSampleRate.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxSampleRate.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxSampleRate.Items.AddRange(New Object() {"", "192000", "96000", "48000", "44100", "32000", "24000", "22050", "16000", "11025", "8000"})
        UiComboBoxSampleRate.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSampleRate.ItemSelectForeColor = Color.Silver
        UiComboBoxSampleRate.Location = New Point(21, 10)
        UiComboBoxSampleRate.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxSampleRate.MaxDropDownItems = 17
        UiComboBoxSampleRate.MinimumSize = New Size(63, 0)
        UiComboBoxSampleRate.Name = "UiComboBoxSampleRate"
        UiComboBoxSampleRate.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxSampleRate.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxSampleRate.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSampleRate.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxSampleRate.ScrollBarHandleWidth = 20
        UiComboBoxSampleRate.Size = New Size(200, 30)
        UiComboBoxSampleRate.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxSampleRate.SymbolSize = 24
        UiComboBoxSampleRate.TabIndex = 68
        UiComboBoxSampleRate.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxSampleRate.Watermark = "Select Sample Rate"
        ' 
        ' Label89
        ' 
        Label89.AutoSize = True
        Label89.Dock = DockStyle.Top
        Label89.Font = New Font("Segoe UI", 13F)
        Label89.Location = New Point(0, 282)
        Label89.Name = "Label89"
        Label89.Padding = New Padding(16, 20, 0, 0)
        Label89.Size = New Size(80, 44)
        Label89.TabIndex = 21
        Label89.Text = "Sample Rate"
        ' 
        ' Panel45
        ' 
        Panel45.Controls.Add(UiComboBoxChannelLayout)
        Panel45.Dock = DockStyle.Top
        Panel45.Location = New Point(0, 242)
        Panel45.Name = "Panel45"
        Panel45.Padding = New Padding(21, 10, 20, 0)
        Panel45.Size = New Size(899, 40)
        Panel45.TabIndex = 32
        ' 
        ' UiComboBoxChannelLayout
        ' 
        UiComboBoxChannelLayout.DataSource = Nothing
        UiComboBoxChannelLayout.Dock = DockStyle.Left
        UiComboBoxChannelLayout.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxChannelLayout.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChannelLayout.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChannelLayout.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChannelLayout.Font = New Font("Segoe UI", 10F)
        UiComboBoxChannelLayout.ForeColor = Color.Silver
        UiComboBoxChannelLayout.ForeDisableColor = Color.Silver
        UiComboBoxChannelLayout.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChannelLayout.ItemForeColor = Color.Silver
        UiComboBoxChannelLayout.ItemHeight = 30
        UiComboBoxChannelLayout.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxChannelLayout.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxChannelLayout.Items.AddRange(New Object() {"", "mono", "stereo", "2.1", "4.0", "5.0", "5.1", "6.1", "7.1", "hexagonal", "octagonal"})
        UiComboBoxChannelLayout.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChannelLayout.ItemSelectForeColor = Color.Silver
        UiComboBoxChannelLayout.Location = New Point(21, 10)
        UiComboBoxChannelLayout.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxChannelLayout.MaxDropDownItems = 17
        UiComboBoxChannelLayout.MinimumSize = New Size(63, 0)
        UiComboBoxChannelLayout.Name = "UiComboBoxChannelLayout"
        UiComboBoxChannelLayout.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxChannelLayout.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxChannelLayout.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChannelLayout.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChannelLayout.ScrollBarHandleWidth = 20
        UiComboBoxChannelLayout.Size = New Size(200, 30)
        UiComboBoxChannelLayout.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxChannelLayout.SymbolSize = 24
        UiComboBoxChannelLayout.TabIndex = 68
        UiComboBoxChannelLayout.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxChannelLayout.Watermark = "Select Channel Layout"
        ' 
        ' Label86
        ' 
        Label86.AutoSize = True
        Label86.Dock = DockStyle.Top
        Label86.Font = New Font("Segoe UI", 13F)
        Label86.Location = New Point(0, 198)
        Label86.Name = "Label86"
        Label86.Padding = New Padding(16, 20, 0, 0)
        Label86.Size = New Size(98, 44)
        Label86.TabIndex = 31
        Label86.Text = "Channel Layout"
        ' 
        ' Panel44
        ' 
        Panel44.Controls.Add(Label134)
        Panel44.Controls.Add(UiTextBoxAudioQualityValue)
        Panel44.Controls.Add(Label84)
        Panel44.Controls.Add(UiComboBoxAudioQualityParameters)
        Panel44.Dock = DockStyle.Top
        Panel44.Location = New Point(0, 158)
        Panel44.Name = "Panel44"
        Panel44.Padding = New Padding(21, 10, 20, 0)
        Panel44.Size = New Size(899, 40)
        Panel44.TabIndex = 18
        ' 
        ' Label134
        ' 
        Label134.Dock = DockStyle.Fill
        Label134.Font = New Font("Segoe UI", 10F)
        Label134.ForeColor = Color.Gray
        Label134.Location = New Point(331, 10)
        Label134.Name = "Label134"
        Label134.Padding = New Padding(10, 0, 0, 0)
        Label134.Size = New Size(548, 30)
        Label134.TabIndex = 105
        Label134.Text = "Quality Mode: Do not set Bitrate. Check value range for each encoder."
        Label134.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTextBoxAudioQualityValue
        ' 
        UiTextBoxAudioQualityValue.Dock = DockStyle.Left
        UiTextBoxAudioQualityValue.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.Font = New Font("Segoe UI", 10F)
        UiTextBoxAudioQualityValue.ForeColor = Color.Silver
        UiTextBoxAudioQualityValue.ForeDisableColor = Color.Silver
        UiTextBoxAudioQualityValue.ForeReadOnlyColor = Color.Silver
        UiTextBoxAudioQualityValue.Location = New Point(231, 10)
        UiTextBoxAudioQualityValue.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxAudioQualityValue.MinimumSize = New Size(1, 16)
        UiTextBoxAudioQualityValue.Name = "UiTextBoxAudioQualityValue"
        UiTextBoxAudioQualityValue.Padding = New Padding(5)
        UiTextBoxAudioQualityValue.Radius = 30
        UiTextBoxAudioQualityValue.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxAudioQualityValue.ShowText = False
        UiTextBoxAudioQualityValue.Size = New Size(100, 30)
        UiTextBoxAudioQualityValue.TabIndex = 103
        UiTextBoxAudioQualityValue.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxAudioQualityValue.Watermark = "Quality Value"
        UiTextBoxAudioQualityValue.WatermarkActiveColor = Color.DimGray
        UiTextBoxAudioQualityValue.WatermarkColor = Color.DimGray
        ' 
        ' Label84
        ' 
        Label84.Dock = DockStyle.Left
        Label84.Location = New Point(221, 10)
        Label84.Name = "Label84"
        Label84.Size = New Size(10, 30)
        Label84.TabIndex = 102
        ' 
        ' UiComboBoxAudioQualityParameters
        ' 
        UiComboBoxAudioQualityParameters.DataSource = Nothing
        UiComboBoxAudioQualityParameters.Dock = DockStyle.Left
        UiComboBoxAudioQualityParameters.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAudioQualityParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioQualityParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioQualityParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioQualityParameters.Font = New Font("Segoe UI", 10F)
        UiComboBoxAudioQualityParameters.ForeColor = Color.Silver
        UiComboBoxAudioQualityParameters.ForeDisableColor = Color.Silver
        UiComboBoxAudioQualityParameters.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioQualityParameters.ItemForeColor = Color.Silver
        UiComboBoxAudioQualityParameters.ItemHeight = 30
        UiComboBoxAudioQualityParameters.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAudioQualityParameters.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAudioQualityParameters.Items.AddRange(New Object() {"", "-q:a", "-vbr", "-compression_level"})
        UiComboBoxAudioQualityParameters.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioQualityParameters.ItemSelectForeColor = Color.Silver
        UiComboBoxAudioQualityParameters.Location = New Point(21, 10)
        UiComboBoxAudioQualityParameters.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAudioQualityParameters.MaxDropDownItems = 17
        UiComboBoxAudioQualityParameters.MinimumSize = New Size(63, 0)
        UiComboBoxAudioQualityParameters.Name = "UiComboBoxAudioQualityParameters"
        UiComboBoxAudioQualityParameters.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAudioQualityParameters.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAudioQualityParameters.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioQualityParameters.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioQualityParameters.ScrollBarHandleWidth = 20
        UiComboBoxAudioQualityParameters.Size = New Size(200, 30)
        UiComboBoxAudioQualityParameters.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAudioQualityParameters.SymbolSize = 24
        UiComboBoxAudioQualityParameters.TabIndex = 104
        UiComboBoxAudioQualityParameters.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAudioQualityParameters.Watermark = "Select Quality Parameters"
        ' 
        ' Panel43
        ' 
        Panel43.Controls.Add(Label131)
        Panel43.Controls.Add(UiComboBoxAudioBitrate)
        Panel43.Dock = DockStyle.Top
        Panel43.Location = New Point(0, 118)
        Panel43.Name = "Panel43"
        Panel43.Padding = New Padding(21, 10, 20, 0)
        Panel43.Size = New Size(899, 40)
        Panel43.TabIndex = 17
        ' 
        ' Label131
        ' 
        Label131.Dock = DockStyle.Fill
        Label131.Font = New Font("Segoe UI", 10F)
        Label131.ForeColor = Color.Gray
        Label131.Location = New Point(221, 10)
        Label131.Name = "Label131"
        Label131.Padding = New Padding(10, 0, 0, 0)
        Label131.Size = New Size(658, 30)
        Label131.TabIndex = 96
        Label131.Text = "Constant Bitrate (CBR), just enter bitrate."
        Label131.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxAudioBitrate
        ' 
        UiComboBoxAudioBitrate.DataSource = Nothing
        UiComboBoxAudioBitrate.Dock = DockStyle.Left
        UiComboBoxAudioBitrate.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioBitrate.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioBitrate.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioBitrate.Font = New Font("Segoe UI", 10F)
        UiComboBoxAudioBitrate.ForeColor = Color.Silver
        UiComboBoxAudioBitrate.ForeDisableColor = Color.Silver
        UiComboBoxAudioBitrate.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioBitrate.ItemForeColor = Color.Silver
        UiComboBoxAudioBitrate.ItemHeight = 30
        UiComboBoxAudioBitrate.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAudioBitrate.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAudioBitrate.Items.AddRange(New Object() {"", "96k", "128k", "192k", "256k", "320k", "384k", "448k", "512k", "640k", "1411k"})
        UiComboBoxAudioBitrate.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioBitrate.ItemSelectForeColor = Color.Silver
        UiComboBoxAudioBitrate.Location = New Point(21, 10)
        UiComboBoxAudioBitrate.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAudioBitrate.MaxDropDownItems = 17
        UiComboBoxAudioBitrate.MinimumSize = New Size(63, 0)
        UiComboBoxAudioBitrate.Name = "UiComboBoxAudioBitrate"
        UiComboBoxAudioBitrate.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAudioBitrate.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAudioBitrate.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioBitrate.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioBitrate.ScrollBarHandleWidth = 20
        UiComboBoxAudioBitrate.Size = New Size(200, 30)
        UiComboBoxAudioBitrate.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAudioBitrate.SymbolSize = 24
        UiComboBoxAudioBitrate.TabIndex = 75
        UiComboBoxAudioBitrate.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAudioBitrate.Watermark = "Select/Enter Bitrate"
        ' 
        ' Label88
        ' 
        Label88.AutoSize = True
        Label88.Dock = DockStyle.Top
        Label88.Font = New Font("Segoe UI", 13F)
        Label88.Location = New Point(0, 74)
        Label88.Name = "Label88"
        Label88.Padding = New Padding(16, 20, 0, 0)
        Label88.Size = New Size(134, 44)
        Label88.TabIndex = 15
        Label88.Text = "Bitrate & Quality"
        ' 
        ' Panel42
        ' 
        Panel42.Controls.Add(Label25)
        Panel42.Controls.Add(UiComboBoxAudioEncoder)
        Panel42.Dock = DockStyle.Top
        Panel42.Location = New Point(0, 34)
        Panel42.Name = "Panel42"
        Panel42.Padding = New Padding(21, 10, 20, 0)
        Panel42.Size = New Size(899, 40)
        Panel42.TabIndex = 14
        ' 
        ' Label25
        ' 
        Label25.Dock = DockStyle.Fill
        Label25.Font = New Font("Segoe UI", 10F)
        Label25.ForeColor = Color.IndianRed
        Label25.Location = New Point(221, 10)
        Label25.Name = "Label25"
        Label25.Padding = New Padding(10, 0, 0, 0)
        Label25.Size = New Size(658, 30)
        Label25.TabIndex = 97
        Label25.Text = "Note: The selected encoder is not included in the main FFmpeg distribution."
        Label25.TextAlign = ContentAlignment.MiddleLeft
        Label25.Visible = False
        ' 
        ' UiComboBoxAudioEncoder
        ' 
        UiComboBoxAudioEncoder.DataSource = Nothing
        UiComboBoxAudioEncoder.Dock = DockStyle.Left
        UiComboBoxAudioEncoder.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAudioEncoder.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioEncoder.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioEncoder.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioEncoder.Font = New Font("Segoe UI", 10F)
        UiComboBoxAudioEncoder.ForeColor = Color.Silver
        UiComboBoxAudioEncoder.ForeDisableColor = Color.Silver
        UiComboBoxAudioEncoder.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAudioEncoder.ItemForeColor = Color.Silver
        UiComboBoxAudioEncoder.ItemHeight = 30
        UiComboBoxAudioEncoder.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAudioEncoder.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAudioEncoder.Items.AddRange(New Object() {"", "Copy Stream", "Disable", "AAC", "FDK AAC", "FDK AAC HE", "FDK AAC HE v2", "LAME MP3", "Opus", "FLAC", "ALAC", "WAV 16bit", "WAV 24bit", "WAV 32bit", "WAV 64bit", "ATSC A/52A (AC3)", "ATSC A/52B (EAC3)", "DTS Coherent Acoustics", "TrueHD", "True Audio", "Vorbis (ogg)", "RealAudio 1.0 (14.4K)", "WavPack", "LAME MP2", "AMR-NB", "AMR-WB"})
        UiComboBoxAudioEncoder.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioEncoder.ItemSelectForeColor = Color.Silver
        UiComboBoxAudioEncoder.Location = New Point(21, 10)
        UiComboBoxAudioEncoder.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAudioEncoder.MaxDropDownItems = 15
        UiComboBoxAudioEncoder.MinimumSize = New Size(63, 0)
        UiComboBoxAudioEncoder.Name = "UiComboBoxAudioEncoder"
        UiComboBoxAudioEncoder.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAudioEncoder.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAudioEncoder.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioEncoder.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAudioEncoder.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAudioEncoder.ScrollBarColor = SystemColors.WindowFrame
        UiComboBoxAudioEncoder.ScrollBarHandleWidth = 20
        UiComboBoxAudioEncoder.ScrollBarStyleInherited = False
        UiComboBoxAudioEncoder.Size = New Size(200, 30)
        UiComboBoxAudioEncoder.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAudioEncoder.SymbolSize = 24
        UiComboBoxAudioEncoder.TabIndex = 74
        UiComboBoxAudioEncoder.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAudioEncoder.Watermark = "Select Audio Encoder"
        ' 
        ' Label85
        ' 
        Label85.AutoSize = True
        Label85.Dock = DockStyle.Top
        Label85.Font = New Font("Segoe UI", 13F)
        Label85.Location = New Point(0, 0)
        Label85.Name = "Label85"
        Label85.Padding = New Padding(16, 10, 0, 0)
        Label85.Size = New Size(116, 34)
        Label85.TabIndex = 12
        Label85.Text = "Audio Encoder"
        ' 
        ' TabPageImageParameters
        ' 
        TabPageImageParameters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageImageParameters.Controls.Add(Label94)
        TabPageImageParameters.Controls.Add(Label135)
        TabPageImageParameters.Controls.Add(Label15)
        TabPageImageParameters.Controls.Add(Label154)
        TabPageImageParameters.Controls.Add(Label91)
        TabPageImageParameters.Controls.Add(Label93)
        TabPageImageParameters.Controls.Add(Label161)
        TabPageImageParameters.Controls.Add(Label162)
        TabPageImageParameters.Controls.Add(Panel67)
        TabPageImageParameters.Controls.Add(Label121)
        TabPageImageParameters.Controls.Add(Label120)
        TabPageImageParameters.Location = New Point(201, 0)
        TabPageImageParameters.Name = "TabPageImageParameters"
        TabPageImageParameters.Size = New Size(899, 650)
        TabPageImageParameters.TabIndex = 11
        TabPageImageParameters.Tag = "TabPage.ImageParameters"
        TabPageImageParameters.Text = "Image Parameters"
        ' 
        ' Label94
        ' 
        Label94.AutoSize = True
        Label94.Dock = DockStyle.Bottom
        Label94.Font = New Font("Segoe UI", 13F)
        Label94.Location = New Point(0, 238)
        Label94.Name = "Label94"
        Label94.Padding = New Padding(16, 0, 0, 10)
        Label94.Size = New Size(156, 34)
        Label94.TabIndex = 26
        Label94.Text = "About WebP Animated Images"
        ' 
        ' Label135
        ' 
        Label135.AutoSize = True
        Label135.Dock = DockStyle.Bottom
        Label135.Font = New Font("Segoe UI", 10F)
        Label135.ForeColor = Color.Gray
        Label135.Location = New Point(0, 272)
        Label135.Name = "Label135"
        Label135.Padding = New Padding(16, 0, 0, 20)
        Label135.Size = New Size(375, 60)
        Label135.TabIndex = 27
        Label135.Text = "ffmpeg can encode webp animated images, but CANNOT decode them." & vbCrLf & "This is a long-standing issue with no progress, so please be aware."
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Bottom
        Label15.Font = New Font("Segoe UI", 13F)
        Label15.Location = New Point(0, 332)
        Label15.Name = "Label15"
        Label15.Padding = New Padding(16, 0, 0, 10)
        Label15.Size = New Size(192, 34)
        Label15.TabIndex = 20
        Label15.Text = "Encode avif Ultra-High Compression Image"
        ' 
        ' Label154
        ' 
        Label154.AutoSize = True
        Label154.Dock = DockStyle.Bottom
        Label154.Font = New Font("Segoe UI", 10F)
        Label154.ForeColor = Color.Gray
        Label154.Location = New Point(0, 366)
        Label154.Name = "Label154"
        Label154.Padding = New Padding(16, 0, 0, 20)
        Label154.Size = New Size(645, 100)
        Label154.TabIndex = 21
        Label154.Text = resources.GetString("Label154.Text")
        ' 
        ' Label91
        ' 
        Label91.AutoSize = True
        Label91.Dock = DockStyle.Bottom
        Label91.Font = New Font("Segoe UI", 13F)
        Label91.Location = New Point(0, 466)
        Label91.Name = "Label91"
        Label91.Padding = New Padding(16, 0, 0, 10)
        Label91.Size = New Size(189, 34)
        Label91.TabIndex = 24
        Label91.Text = "Encode vvc Ultra-High Compression Image"
        ' 
        ' Label93
        ' 
        Label93.AutoSize = True
        Label93.Dock = DockStyle.Bottom
        Label93.Font = New Font("Segoe UI", 10F)
        Label93.ForeColor = Color.Gray
        Label93.Location = New Point(0, 500)
        Label93.Name = "Label93"
        Label93.Padding = New Padding(16, 0, 0, 20)
        Label93.Size = New Size(507, 80)
        Label93.TabIndex = 25
        Label93.Text = "H.266/VVC's libvvenc can directly output to .vvc files like avif, and artifacts are acceptable." & vbCrLf & "However, almost no mainstream software can open it currently; you may only be able to view it via ffplay." & vbCrLf & "For Quality, use 'qp'; it does not support 'crf'."
        ' 
        ' Label161
        ' 
        Label161.AutoSize = True
        Label161.Dock = DockStyle.Bottom
        Label161.Font = New Font("Segoe UI", 13F)
        Label161.Location = New Point(0, 580)
        Label161.Name = "Label161"
        Label161.Padding = New Padding(16, 0, 0, 10)
        Label161.Size = New Size(238, 34)
        Label161.TabIndex = 22
        Label161.Text = "ffmpeg does not support heic / heif"
        ' 
        ' Label162
        ' 
        Label162.AutoSize = True
        Label162.Dock = DockStyle.Bottom
        Label162.Font = New Font("Segoe UI", 10F)
        Label162.ForeColor = Color.Gray
        Label162.Location = New Point(0, 614)
        Label162.Name = "Label162"
        Label162.Padding = New Padding(16, 0, 0, 16)
        Label162.Size = New Size(375, 36)
        Label162.TabIndex = 23
        Label162.Text = "If you want to encode this format, please find other software or develop this requirement separately."
        ' 
        ' Panel67
        ' 
        Panel67.Controls.Add(UiTextBoxImageEncoderQuality)
        Panel67.Controls.Add(Label122)
        Panel67.Controls.Add(UiComboBoxImageEncoder)
        Panel67.Dock = DockStyle.Top
        Panel67.Location = New Point(0, 59)
        Panel67.Name = "Panel67"
        Panel67.Padding = New Padding(21, 10, 20, 0)
        Panel67.Size = New Size(899, 40)
        Panel67.TabIndex = 16
        ' 
        ' UiTextBoxImageEncoderQuality
        ' 
        UiTextBoxImageEncoderQuality.Dock = DockStyle.Left
        UiTextBoxImageEncoderQuality.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.Font = New Font("Segoe UI", 10F)
        UiTextBoxImageEncoderQuality.ForeColor = Color.Silver
        UiTextBoxImageEncoderQuality.ForeDisableColor = Color.Silver
        UiTextBoxImageEncoderQuality.ForeReadOnlyColor = Color.Silver
        UiTextBoxImageEncoderQuality.Location = New Point(331, 10)
        UiTextBoxImageEncoderQuality.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxImageEncoderQuality.MinimumSize = New Size(1, 16)
        UiTextBoxImageEncoderQuality.Name = "UiTextBoxImageEncoderQuality"
        UiTextBoxImageEncoderQuality.Padding = New Padding(5)
        UiTextBoxImageEncoderQuality.Radius = 30
        UiTextBoxImageEncoderQuality.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxImageEncoderQuality.ShowText = False
        UiTextBoxImageEncoderQuality.Size = New Size(100, 30)
        UiTextBoxImageEncoderQuality.TabIndex = 77
        UiTextBoxImageEncoderQuality.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxImageEncoderQuality.Watermark = "Quality Value"
        ' 
        ' Label122
        ' 
        Label122.Dock = DockStyle.Left
        Label122.Location = New Point(321, 10)
        Label122.Name = "Label122"
        Label122.Size = New Size(10, 30)
        Label122.TabIndex = 76
        ' 
        ' UiComboBoxImageEncoder
        ' 
        UiComboBoxImageEncoder.DataSource = Nothing
        UiComboBoxImageEncoder.Dock = DockStyle.Left
        UiComboBoxImageEncoder.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxImageEncoder.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxImageEncoder.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxImageEncoder.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxImageEncoder.Font = New Font("Segoe UI", 10F)
        UiComboBoxImageEncoder.ForeColor = Color.Silver
        UiComboBoxImageEncoder.ForeDisableColor = Color.Silver
        UiComboBoxImageEncoder.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxImageEncoder.ItemForeColor = Color.Silver
        UiComboBoxImageEncoder.ItemHeight = 30
        UiComboBoxImageEncoder.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxImageEncoder.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxImageEncoder.Items.AddRange(New Object() {"", "PNG | 1 Fastest ~ Slowest 9", "APNG Animated | 1 Fastest ~ Slowest 9", "JPEG\JPG | 1 Clear ~ Blur 31", "WEBP | 0 Blur ~ Clear 100", "WEBP Animated", "GIF Animated | Write 1 to enable palette generation", "BMP", "OpenJPEG | 0.0 Lossy ~ Lossless 1.0", "JPEG-LS", "SVT JPEG XS", "HDR (Radiance RGBE format)", "TIFF", "DPX", "OpenEXR"})
        UiComboBoxImageEncoder.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxImageEncoder.ItemSelectForeColor = Color.Silver
        UiComboBoxImageEncoder.Location = New Point(21, 10)
        UiComboBoxImageEncoder.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxImageEncoder.MaxDropDownItems = 17
        UiComboBoxImageEncoder.MinimumSize = New Size(63, 0)
        UiComboBoxImageEncoder.Name = "UiComboBoxImageEncoder"
        UiComboBoxImageEncoder.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxImageEncoder.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxImageEncoder.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxImageEncoder.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxImageEncoder.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxImageEncoder.ScrollBarColor = SystemColors.WindowFrame
        UiComboBoxImageEncoder.ScrollBarHandleWidth = 20
        UiComboBoxImageEncoder.ScrollBarStyleInherited = False
        UiComboBoxImageEncoder.Size = New Size(300, 30)
        UiComboBoxImageEncoder.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxImageEncoder.SymbolSize = 24
        UiComboBoxImageEncoder.TabIndex = 78
        UiComboBoxImageEncoder.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxImageEncoder.Watermark = "Select Encoder Name"
        ' 
        ' Label121
        ' 
        Label121.AutoSize = True
        Label121.Dock = DockStyle.Top
        Label121.Font = New Font("Segoe UI", 10F)
        Label121.ForeColor = Color.Gray
        Label121.Location = New Point(0, 34)
        Label121.Name = "Label121"
        Label121.Padding = New Padding(16, 5, 0, 0)
        Label121.Size = New Size(361, 25)
        Label121.TabIndex = 19
        Label121.Text = "Image Parameters are effectively Video Parameters, just placed here for classification."
        ' 
        ' Label120
        ' 
        Label120.AutoSize = True
        Label120.Dock = DockStyle.Top
        Label120.Font = New Font("Segoe UI", 13F)
        Label120.Location = New Point(0, 0)
        Label120.Name = "Label120"
        Label120.Padding = New Padding(16, 10, 0, 0)
        Label120.Size = New Size(116, 34)
        Label120.TabIndex = 15
        Label120.Text = "Image Encoder"
        ' 
        ' TabPageCustomParameters
        ' 
        TabPageCustomParameters.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageCustomParameters.Controls.Add(Panel50)
        TabPageCustomParameters.Location = New Point(201, 0)
        TabPageCustomParameters.Name = "TabPageCustomParameters"
        TabPageCustomParameters.Size = New Size(899, 650)
        TabPageCustomParameters.TabIndex = 9
        TabPageCustomParameters.Tag = "TabPage.CustomParameters"
        TabPageCustomParameters.Text = "Custom Parameters"
        ' 
        ' Panel50
        ' 
        Panel50.Controls.Add(UiTabControl1)
        Panel50.Dock = DockStyle.Fill
        Panel50.Location = New Point(0, 0)
        Panel50.Name = "Panel50"
        Panel50.Padding = New Padding(20, 0, 20, 20)
        Panel50.Size = New Size(899, 650)
        Panel50.TabIndex = 0
        ' 
        ' UiTabControl1
        ' 
        UiTabControl1.Controls.Add(TabPage1)
        UiTabControl1.Controls.Add(TabPage2)
        UiTabControl1.Controls.Add(TabPage3)
        UiTabControl1.Controls.Add(TabPage4)
        UiTabControl1.Controls.Add(TabPage5)
        UiTabControl1.Dock = DockStyle.Fill
        UiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControl1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.Font = New Font("Segoe UI", 10F)
        UiTabControl1.ItemSize = New Size(150, 50)
        UiTabControl1.Location = New Point(20, 0)
        UiTabControl1.MainPage = ""
        UiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControl1.Name = "UiTabControl1"
        UiTabControl1.SelectedIndex = 0
        UiTabControl1.Size = New Size(859, 630)
        UiTabControl1.SizeMode = TabSizeMode.Fixed
        UiTabControl1.TabBackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.TabIndex = 0
        UiTabControl1.TabSelectedColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.TabSelectedForeColor = Color.CornflowerBlue
        UiTabControl1.TabSelectedHighColor = Color.CornflowerBlue
        UiTabControl1.TabUnSelectedForeColor = Color.Silver
        UiTabControl1.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage1.Controls.Add(Panel51)
        TabPage1.Controls.Add(Label98)
        TabPage1.Controls.Add(Label97)
        TabPage1.Location = New Point(0, 50)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(859, 580)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Custom Parameters Help"
        ' 
        ' Panel51
        ' 
        Panel51.BorderStyle = BorderStyle.FixedSingle
        Panel51.Controls.Add(TextBox1)
        Panel51.Dock = DockStyle.Fill
        Panel51.Location = New Point(0, 114)
        Panel51.Name = "Panel51"
        Panel51.Padding = New Padding(20)
        Panel51.Size = New Size(859, 466)
        Panel51.TabIndex = 37
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 10.5F)
        TextBox1.ForeColor = Color.DarkGray
        TextBox1.Location = New Point(20, 20)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(817, 424)
        TextBox1.TabIndex = 79
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label98
        ' 
        Label98.AutoSize = True
        Label98.Dock = DockStyle.Top
        Label98.Font = New Font("Segoe UI", 13F)
        Label98.Location = New Point(0, 60)
        Label98.Name = "Label98"
        Label98.Padding = New Padding(0, 20, 0, 10)
        Label98.Size = New Size(100, 54)
        Label98.TabIndex = 36
        Label98.Text = "Wildcard Strings"
        ' 
        ' Label97
        ' 
        Label97.AutoSize = True
        Label97.Dock = DockStyle.Top
        Label97.Font = New Font("Segoe UI", 10F)
        Label97.ForeColor = Color.Gray
        Label97.Location = New Point(0, 0)
        Label97.Name = "Label97"
        Label97.Padding = New Padding(1, 20, 0, 0)
        Label97.Size = New Size(332, 60)
        Label97.TabIndex = 35
        Label97.Text = "Providing maximum freedom for specialized fields and advanced users." & vbCrLf & "Note: All line breaks will be ignored!"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage2.Controls.Add(Panel52)
        TabPage2.Controls.Add(Label99)
        TabPage2.Controls.Add(Panel53)
        TabPage2.Controls.Add(Label119)
        TabPage2.Controls.Add(Panel65)
        TabPage2.Controls.Add(Label138)
        TabPage2.Controls.Add(Label96)
        TabPage2.Location = New Point(0, 40)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(200, 60)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Filter Parameters"
        ' 
        ' Panel52
        ' 
        Panel52.Controls.Add(UiTextBoxCustomVideoFilter)
        Panel52.Dock = DockStyle.Fill
        Panel52.Location = New Point(0, 104)
        Panel52.Name = "Panel52"
        Panel52.Padding = New Padding(4, 0, 4, 0)
        Panel52.Size = New Size(200, 0)
        Panel52.TabIndex = 38
        ' 
        ' UiTextBoxCustomVideoFilter
        ' 
        UiTextBoxCustomVideoFilter.Dock = DockStyle.Fill
        UiTextBoxCustomVideoFilter.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.Font = New Font("Segoe UI", 11F)
        UiTextBoxCustomVideoFilter.ForeColor = Color.Silver
        UiTextBoxCustomVideoFilter.ForeDisableColor = Color.Silver
        UiTextBoxCustomVideoFilter.ForeReadOnlyColor = Color.Silver
        UiTextBoxCustomVideoFilter.Location = New Point(4, 0)
        UiTextBoxCustomVideoFilter.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCustomVideoFilter.MinimumSize = New Size(1, 16)
        UiTextBoxCustomVideoFilter.Multiline = True
        UiTextBoxCustomVideoFilter.Name = "UiTextBoxCustomVideoFilter"
        UiTextBoxCustomVideoFilter.Padding = New Padding(5)
        UiTextBoxCustomVideoFilter.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoFilter.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxCustomVideoFilter.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxCustomVideoFilter.ScrollBarStyleInherited = False
        UiTextBoxCustomVideoFilter.ShowText = False
        UiTextBoxCustomVideoFilter.Size = New Size(192, 16)
        UiTextBoxCustomVideoFilter.TabIndex = 95
        UiTextBoxCustomVideoFilter.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxCustomVideoFilter.Watermark = "Parameters here will be appended to -vf. Separate filters with commas. Image parameters also use this."
        ' 
        ' Label99
        ' 
        Label99.AutoSize = True
        Label99.Dock = DockStyle.Bottom
        Label99.Font = New Font("Segoe UI", 13F)
        Label99.Location = New Point(0, -208)
        Label99.Name = "Label99"
        Label99.Padding = New Padding(0, 20, 0, 10)
        Label99.Size = New Size(82, 54)
        Label99.TabIndex = 39
        Label99.Text = "Audio Filter"
        ' 
        ' Panel53
        ' 
        Panel53.Controls.Add(UiTextBoxCustomAudioFilter)
        Panel53.Dock = DockStyle.Bottom
        Panel53.Location = New Point(0, -154)
        Panel53.Name = "Panel53"
        Panel53.Padding = New Padding(4, 0, 4, 0)
        Panel53.Size = New Size(200, 80)
        Panel53.TabIndex = 40
        ' 
        ' UiTextBoxCustomAudioFilter
        ' 
        UiTextBoxCustomAudioFilter.Dock = DockStyle.Fill
        UiTextBoxCustomAudioFilter.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.Font = New Font("Segoe UI", 11F)
        UiTextBoxCustomAudioFilter.ForeColor = Color.Silver
        UiTextBoxCustomAudioFilter.ForeDisableColor = Color.Silver
        UiTextBoxCustomAudioFilter.ForeReadOnlyColor = Color.Silver
        UiTextBoxCustomAudioFilter.Location = New Point(4, 0)
        UiTextBoxCustomAudioFilter.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCustomAudioFilter.MinimumSize = New Size(1, 16)
        UiTextBoxCustomAudioFilter.Multiline = True
        UiTextBoxCustomAudioFilter.Name = "UiTextBoxCustomAudioFilter"
        UiTextBoxCustomAudioFilter.Padding = New Padding(5)
        UiTextBoxCustomAudioFilter.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioFilter.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxCustomAudioFilter.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxCustomAudioFilter.ScrollBarStyleInherited = False
        UiTextBoxCustomAudioFilter.ShowText = False
        UiTextBoxCustomAudioFilter.Size = New Size(192, 80)
        UiTextBoxCustomAudioFilter.TabIndex = 95
        UiTextBoxCustomAudioFilter.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxCustomAudioFilter.Watermark = "Parameters here will be appended to -af. Separate filters with commas."
        ' 
        ' Label119
        ' 
        Label119.AutoSize = True
        Label119.Dock = DockStyle.Bottom
        Label119.Font = New Font("Segoe UI", 13F)
        Label119.Location = New Point(0, -74)
        Label119.Name = "Label119"
        Label119.Padding = New Padding(0, 20, 0, 10)
        Label119.Size = New Size(131, 54)
        Label119.TabIndex = 41
        Label119.Text = "filter_complex"
        ' 
        ' Panel65
        ' 
        Panel65.Controls.Add(UiTextBoxfilter_complex)
        Panel65.Dock = DockStyle.Bottom
        Panel65.Location = New Point(0, -20)
        Panel65.Name = "Panel65"
        Panel65.Padding = New Padding(4, 0, 4, 0)
        Panel65.Size = New Size(200, 80)
        Panel65.TabIndex = 42
        ' 
        ' UiTextBoxfilter_complex
        ' 
        UiTextBoxfilter_complex.Dock = DockStyle.Fill
        UiTextBoxfilter_complex.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.Font = New Font("Segoe UI", 11F)
        UiTextBoxfilter_complex.ForeColor = Color.Silver
        UiTextBoxfilter_complex.ForeDisableColor = Color.Silver
        UiTextBoxfilter_complex.ForeReadOnlyColor = Color.Silver
        UiTextBoxfilter_complex.Location = New Point(4, 0)
        UiTextBoxfilter_complex.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxfilter_complex.MinimumSize = New Size(1, 16)
        UiTextBoxfilter_complex.Multiline = True
        UiTextBoxfilter_complex.Name = "UiTextBoxfilter_complex"
        UiTextBoxfilter_complex.Padding = New Padding(5)
        UiTextBoxfilter_complex.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxfilter_complex.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxfilter_complex.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxfilter_complex.ScrollBarStyleInherited = False
        UiTextBoxfilter_complex.ShowText = False
        UiTextBoxfilter_complex.Size = New Size(192, 80)
        UiTextBoxfilter_complex.TabIndex = 95
        UiTextBoxfilter_complex.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxfilter_complex.Watermark = "Parameters here will be used as -filter_complex. Separate filters with commas. 3FUI itself does not use this."
        ' 
        ' Label138
        ' 
        Label138.AutoSize = True
        Label138.Dock = DockStyle.Top
        Label138.Font = New Font("Segoe UI", 10F)
        Label138.ForeColor = Color.Gray
        Label138.Location = New Point(0, 54)
        Label138.Name = "Label138"
        Label138.Padding = New Padding(0, 0, 0, 10)
        Label138.Size = New Size(524, 50)
        Label138.TabIndex = 43
        Label138.Text = "When writing paths in filters, ffmpeg mistakes the colon in drive letters for a separator." & vbCrLf & "Solution: Add a backslash before the colon, and change backslashes to double backslashes."
        ' 
        ' Label96
        ' 
        Label96.AutoSize = True
        Label96.Dock = DockStyle.Top
        Label96.Font = New Font("Segoe UI", 13F)
        Label96.Location = New Point(0, 0)
        Label96.Name = "Label96"
        Label96.Padding = New Padding(0, 20, 0, 10)
        Label96.Size = New Size(82, 54)
        Label96.TabIndex = 37
        Label96.Text = "Video Filter"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage3.Controls.Add(Panel54)
        TabPage3.Controls.Add(Label100)
        TabPage3.Controls.Add(Label101)
        TabPage3.Controls.Add(Panel55)
        TabPage3.Location = New Point(0, 40)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(200, 60)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Stream Custom Parameters"
        ' 
        ' Panel54
        ' 
        Panel54.Controls.Add(UiTextBoxCustomVideoParameters)
        Panel54.Dock = DockStyle.Fill
        Panel54.Location = New Point(0, 54)
        Panel54.Name = "Panel54"
        Panel54.Padding = New Padding(4, 0, 4, 0)
        Panel54.Size = New Size(200, 0)
        Panel54.TabIndex = 42
        ' 
        ' UiTextBoxCustomVideoParameters
        ' 
        UiTextBoxCustomVideoParameters.Dock = DockStyle.Fill
        UiTextBoxCustomVideoParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxCustomVideoParameters.ForeColor = Color.Silver
        UiTextBoxCustomVideoParameters.ForeDisableColor = Color.Silver
        UiTextBoxCustomVideoParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxCustomVideoParameters.Location = New Point(4, 0)
        UiTextBoxCustomVideoParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCustomVideoParameters.MinimumSize = New Size(1, 16)
        UiTextBoxCustomVideoParameters.Multiline = True
        UiTextBoxCustomVideoParameters.Name = "UiTextBoxCustomVideoParameters"
        UiTextBoxCustomVideoParameters.Padding = New Padding(5)
        UiTextBoxCustomVideoParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomVideoParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxCustomVideoParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxCustomVideoParameters.ScrollBarStyleInherited = False
        UiTextBoxCustomVideoParameters.ShowText = False
        UiTextBoxCustomVideoParameters.Size = New Size(192, 16)
        UiTextBoxCustomVideoParameters.TabIndex = 95
        UiTextBoxCustomVideoParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxCustomVideoParameters.Watermark = "Parameters here will be appended to the end of all Video Parameters (before Audio Params). Image Parameters also use this."
        ' 
        ' Label100
        ' 
        Label100.AutoSize = True
        Label100.Dock = DockStyle.Bottom
        Label100.Font = New Font("Segoe UI", 13F)
        Label100.Location = New Point(0, -194)
        Label100.Name = "Label100"
        Label100.Padding = New Padding(0, 20, 0, 10)
        Label100.Size = New Size(82, 54)
        Label100.TabIndex = 43
        Label100.Text = "Audio Parameters"
        ' 
        ' Label101
        ' 
        Label101.AutoSize = True
        Label101.Dock = DockStyle.Top
        Label101.Font = New Font("Segoe UI", 13F)
        Label101.Location = New Point(0, 0)
        Label101.Name = "Label101"
        Label101.Padding = New Padding(0, 20, 0, 10)
        Label101.Size = New Size(82, 54)
        Label101.TabIndex = 41
        Label101.Text = "Video Parameters"
        ' 
        ' Panel55
        ' 
        Panel55.Controls.Add(UiTextBoxCustomAudioParameters)
        Panel55.Dock = DockStyle.Bottom
        Panel55.Location = New Point(0, -140)
        Panel55.Name = "Panel55"
        Panel55.Padding = New Padding(4, 0, 4, 0)
        Panel55.Size = New Size(200, 200)
        Panel55.TabIndex = 44
        ' 
        ' UiTextBoxCustomAudioParameters
        ' 
        UiTextBoxCustomAudioParameters.Dock = DockStyle.Fill
        UiTextBoxCustomAudioParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxCustomAudioParameters.ForeColor = Color.Silver
        UiTextBoxCustomAudioParameters.ForeDisableColor = Color.Silver
        UiTextBoxCustomAudioParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxCustomAudioParameters.Location = New Point(4, 0)
        UiTextBoxCustomAudioParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCustomAudioParameters.MinimumSize = New Size(1, 16)
        UiTextBoxCustomAudioParameters.Multiline = True
        UiTextBoxCustomAudioParameters.Name = "UiTextBoxCustomAudioParameters"
        UiTextBoxCustomAudioParameters.Padding = New Padding(5)
        UiTextBoxCustomAudioParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomAudioParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxCustomAudioParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxCustomAudioParameters.ScrollBarStyleInherited = False
        UiTextBoxCustomAudioParameters.ShowText = False
        UiTextBoxCustomAudioParameters.Size = New Size(192, 200)
        UiTextBoxCustomAudioParameters.TabIndex = 95
        UiTextBoxCustomAudioParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxCustomAudioParameters.Watermark = "Parameters here will be appended to the end of all Audio Parameters"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage4.Controls.Add(Panel59)
        TabPage4.Controls.Add(Label105)
        TabPage4.Controls.Add(Panel58)
        TabPage4.Controls.Add(Label104)
        TabPage4.Controls.Add(Panel57)
        TabPage4.Controls.Add(Label103)
        TabPage4.Controls.Add(Panel56)
        TabPage4.Controls.Add(Label102)
        TabPage4.Location = New Point(0, 40)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(200, 60)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Insert Parameters"
        ' 
        ' Panel59
        ' 
        Panel59.Controls.Add(UiTextBoxFinalParameters)
        Panel59.Dock = DockStyle.Top
        Panel59.Location = New Point(0, 441)
        Panel59.Name = "Panel59"
        Panel59.Padding = New Padding(4, 0, 4, 0)
        Panel59.Size = New Size(200, 75)
        Panel59.TabIndex = 49
        ' 
        ' UiTextBoxFinalParameters
        ' 
        UiTextBoxFinalParameters.Dock = DockStyle.Fill
        UiTextBoxFinalParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxFinalParameters.ForeColor = Color.Silver
        UiTextBoxFinalParameters.ForeDisableColor = Color.Silver
        UiTextBoxFinalParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxFinalParameters.Location = New Point(4, 0)
        UiTextBoxFinalParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxFinalParameters.MinimumSize = New Size(1, 16)
        UiTextBoxFinalParameters.Multiline = True
        UiTextBoxFinalParameters.Name = "UiTextBoxFinalParameters"
        UiTextBoxFinalParameters.Padding = New Padding(5)
        UiTextBoxFinalParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxFinalParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxFinalParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxFinalParameters.ScrollBarStyleInherited = False
        UiTextBoxFinalParameters.ShowText = False
        UiTextBoxFinalParameters.Size = New Size(192, 75)
        UiTextBoxFinalParameters.TabIndex = 95
        UiTextBoxFinalParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxFinalParameters.Watermark = "Parameters here will be appended after all parameters (at the very end, after Output File)."
        ' 
        ' Label105
        ' 
        Label105.AutoSize = True
        Label105.Dock = DockStyle.Top
        Label105.Font = New Font("Segoe UI", 13F)
        Label105.Location = New Point(0, 387)
        Label105.Name = "Label105"
        Label105.Padding = New Padding(0, 20, 0, 10)
        Label105.Size = New Size(82, 54)
        Label105.TabIndex = 48
        Label105.Text = "Final Parameters"
        ' 
        ' Panel58
        ' 
        Panel58.Controls.Add(UiTextBoxPostParameters)
        Panel58.Dock = DockStyle.Top
        Panel58.Location = New Point(0, 312)
        Panel58.Name = "Panel58"
        Panel58.Padding = New Padding(4, 0, 4, 0)
        Panel58.Size = New Size(200, 75)
        Panel58.TabIndex = 47
        ' 
        ' UiTextBoxPostParameters
        ' 
        UiTextBoxPostParameters.Dock = DockStyle.Fill
        UiTextBoxPostParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxPostParameters.ForeColor = Color.Silver
        UiTextBoxPostParameters.ForeDisableColor = Color.Silver
        UiTextBoxPostParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxPostParameters.Location = New Point(4, 0)
        UiTextBoxPostParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxPostParameters.MinimumSize = New Size(1, 16)
        UiTextBoxPostParameters.Multiline = True
        UiTextBoxPostParameters.Name = "UiTextBoxPostParameters"
        UiTextBoxPostParameters.Padding = New Padding(5)
        UiTextBoxPostParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPostParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxPostParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxPostParameters.ScrollBarStyleInherited = False
        UiTextBoxPostParameters.ShowText = False
        UiTextBoxPostParameters.Size = New Size(192, 75)
        UiTextBoxPostParameters.TabIndex = 95
        UiTextBoxPostParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxPostParameters.Watermark = "Parameters here will be appended after all previous parameters, but before Output File."
        ' 
        ' Label104
        ' 
        Label104.AutoSize = True
        Label104.Dock = DockStyle.Top
        Label104.Font = New Font("Segoe UI", 13F)
        Label104.Location = New Point(0, 258)
        Label104.Name = "Label104"
        Label104.Padding = New Padding(0, 20, 0, 10)
        Label104.Size = New Size(82, 54)
        Label104.TabIndex = 46
        Label104.Text = "Parameters (After)"
        ' 
        ' Panel57
        ' 
        Panel57.Controls.Add(UiTextBoxPreParameters)
        Panel57.Dock = DockStyle.Top
        Panel57.Location = New Point(0, 183)
        Panel57.Name = "Panel57"
        Panel57.Padding = New Padding(4, 0, 4, 0)
        Panel57.Size = New Size(200, 75)
        Panel57.TabIndex = 45
        ' 
        ' UiTextBoxPreParameters
        ' 
        UiTextBoxPreParameters.Dock = DockStyle.Fill
        UiTextBoxPreParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxPreParameters.ForeColor = Color.Silver
        UiTextBoxPreParameters.ForeDisableColor = Color.Silver
        UiTextBoxPreParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxPreParameters.Location = New Point(4, 0)
        UiTextBoxPreParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxPreParameters.MinimumSize = New Size(1, 16)
        UiTextBoxPreParameters.Multiline = True
        UiTextBoxPreParameters.Name = "UiTextBoxPreParameters"
        UiTextBoxPreParameters.Padding = New Padding(5)
        UiTextBoxPreParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxPreParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxPreParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxPreParameters.ScrollBarStyleInherited = False
        UiTextBoxPreParameters.ShowText = False
        UiTextBoxPreParameters.Size = New Size(192, 75)
        UiTextBoxPreParameters.TabIndex = 95
        UiTextBoxPreParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxPreParameters.Watermark = "Parameters here will be appended after the main Input File (for importing more files)."
        ' 
        ' Label103
        ' 
        Label103.AutoSize = True
        Label103.Dock = DockStyle.Top
        Label103.Font = New Font("Segoe UI", 13F)
        Label103.Location = New Point(0, 129)
        Label103.Name = "Label103"
        Label103.Padding = New Padding(0, 20, 0, 10)
        Label103.Size = New Size(82, 54)
        Label103.TabIndex = 44
        Label103.Text = "Parameters (Before)"
        ' 
        ' Panel56
        ' 
        Panel56.Controls.Add(UiTextBoxStartParameters)
        Panel56.Dock = DockStyle.Top
        Panel56.Location = New Point(0, 54)
        Panel56.Name = "Panel56"
        Panel56.Padding = New Padding(4, 0, 4, 0)
        Panel56.Size = New Size(200, 75)
        Panel56.TabIndex = 43
        ' 
        ' UiTextBoxStartParameters
        ' 
        UiTextBoxStartParameters.Dock = DockStyle.Fill
        UiTextBoxStartParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxStartParameters.ForeColor = Color.Silver
        UiTextBoxStartParameters.ForeDisableColor = Color.Silver
        UiTextBoxStartParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxStartParameters.Location = New Point(4, 0)
        UiTextBoxStartParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxStartParameters.MinimumSize = New Size(1, 16)
        UiTextBoxStartParameters.Multiline = True
        UiTextBoxStartParameters.Name = "UiTextBoxStartParameters"
        UiTextBoxStartParameters.Padding = New Padding(5)
        UiTextBoxStartParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxStartParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxStartParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxStartParameters.ScrollBarStyleInherited = False
        UiTextBoxStartParameters.ShowText = False
        UiTextBoxStartParameters.Size = New Size(192, 75)
        UiTextBoxStartParameters.TabIndex = 95
        UiTextBoxStartParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxStartParameters.Watermark = "Parameters here will be appended before Input File (after ffmpeg, before -i)."
        ' 
        ' Label102
        ' 
        Label102.AutoSize = True
        Label102.Dock = DockStyle.Top
        Label102.Font = New Font("Segoe UI", 13F)
        Label102.Location = New Point(0, 0)
        Label102.Name = "Label102"
        Label102.Padding = New Padding(0, 20, 0, 10)
        Label102.Size = New Size(82, 54)
        Label102.TabIndex = 42
        Label102.Text = "Initial Parameters"
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage5.Controls.Add(Panel60)
        TabPage5.Controls.Add(Label106)
        TabPage5.Location = New Point(0, 40)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(200, 60)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Fully Manual"
        ' 
        ' Panel60
        ' 
        Panel60.Controls.Add(UiTextBoxCustomFullParameters)
        Panel60.Dock = DockStyle.Fill
        Panel60.Location = New Point(0, 90)
        Panel60.Name = "Panel60"
        Panel60.Padding = New Padding(4, 0, 4, 0)
        Panel60.Size = New Size(200, 0)
        Panel60.TabIndex = 44
        ' 
        ' UiTextBoxCustomFullParameters
        ' 
        UiTextBoxCustomFullParameters.Dock = DockStyle.Fill
        UiTextBoxCustomFullParameters.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.Font = New Font("Segoe UI", 11F)
        UiTextBoxCustomFullParameters.ForeColor = Color.Silver
        UiTextBoxCustomFullParameters.ForeDisableColor = Color.Silver
        UiTextBoxCustomFullParameters.ForeReadOnlyColor = Color.Silver
        UiTextBoxCustomFullParameters.Location = New Point(4, 0)
        UiTextBoxCustomFullParameters.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxCustomFullParameters.MinimumSize = New Size(1, 16)
        UiTextBoxCustomFullParameters.Multiline = True
        UiTextBoxCustomFullParameters.Name = "UiTextBoxCustomFullParameters"
        UiTextBoxCustomFullParameters.Padding = New Padding(5, 10, 5, 5)
        UiTextBoxCustomFullParameters.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxCustomFullParameters.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiTextBoxCustomFullParameters.ScrollBarColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        UiTextBoxCustomFullParameters.ScrollBarStyleInherited = False
        UiTextBoxCustomFullParameters.ShowText = False
        UiTextBoxCustomFullParameters.Size = New Size(192, 16)
        UiTextBoxCustomFullParameters.TabIndex = 95
        UiTextBoxCustomFullParameters.TextAlignment = ContentAlignment.TopLeft
        UiTextBoxCustomFullParameters.Watermark = ""
        ' 
        ' Label106
        ' 
        Label106.AutoSize = True
        Label106.Dock = DockStyle.Top
        Label106.Font = New Font("Segoe UI", 10F)
        Label106.ForeColor = Color.DarkGray
        Label106.Location = New Point(0, 0)
        Label106.Name = "Label106"
        Label106.Padding = New Padding(0, 10, 0, 20)
        Label106.Size = New Size(601, 90)
        Label106.TabIndex = 43
        Label106.Text = "When using Fully Manual, ALL other parameters will be IGNORED." & vbCrLf & "Do NOT include 'ffmpeg' at the beginning; only provide arguments." & vbCrLf & "Use <InputFile> for Input File and <OutputFile> for Output File. Quotes are NOT automatically added. Case sensitive."
        ' 
        ' TabPageClipInterval
        ' 
        TabPageClipInterval.AutoScroll = True
        TabPageClipInterval.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageClipInterval.Controls.Add(Label181)
        TabPageClipInterval.Controls.Add(Panel75)
        TabPageClipInterval.Controls.Add(Label151)
        TabPageClipInterval.Controls.Add(Label150)
        TabPageClipInterval.Controls.Add(Panel76)
        TabPageClipInterval.Controls.Add(Label115)
        TabPageClipInterval.Controls.Add(Label152)
        TabPageClipInterval.Controls.Add(Panel66)
        TabPageClipInterval.Controls.Add(Label109)
        TabPageClipInterval.Controls.Add(Label146)
        TabPageClipInterval.Location = New Point(201, 0)
        TabPageClipInterval.Name = "TabPageClipInterval"
        TabPageClipInterval.Size = New Size(899, 650)
        TabPageClipInterval.TabIndex = 13
        TabPageClipInterval.Tag = "TabPage.ClipInterval"
        TabPageClipInterval.Text = "Clip Interval"
        ' 
        ' Label181
        ' 
        Label181.AutoSize = True
        Label181.Dock = DockStyle.Bottom
        Label181.Font = New Font("Segoe UI", 10F)
        Label181.ForeColor = Color.Gray
        Label181.Location = New Point(0, 594)
        Label181.Name = "Label181"
        Label181.Padding = New Padding(16, 0, 0, 16)
        Label181.Size = New Size(389, 56)
        Label181.TabIndex = 117
        Label181.Text = "Head-Tail Clipping mode has been attempted but no method works in a single pass." & vbCrLf & "Unless a feasible single-pass method is found, please do not request this requirement again."
        ' 
        ' Panel75
        ' 
        Panel75.Controls.Add(UiComboBoxClipForwardDecodingDurationSeconds)
        Panel75.Dock = DockStyle.Top
        Panel75.Location = New Point(0, 317)
        Panel75.Name = "Panel75"
        Panel75.Padding = New Padding(21, 10, 20, 0)
        Panel75.Size = New Size(899, 40)
        Panel75.TabIndex = 108
        ' 
        ' UiComboBoxClipForwardDecodingDurationSeconds
        ' 
        UiComboBoxClipForwardDecodingDurationSeconds.DataSource = Nothing
        UiComboBoxClipForwardDecodingDurationSeconds.Dock = DockStyle.Left
        UiComboBoxClipForwardDecodingDurationSeconds.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipForwardDecodingDurationSeconds.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipForwardDecodingDurationSeconds.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipForwardDecodingDurationSeconds.Font = New Font("Segoe UI", 10F)
        UiComboBoxClipForwardDecodingDurationSeconds.ForeColor = Color.Silver
        UiComboBoxClipForwardDecodingDurationSeconds.ForeDisableColor = Color.Silver
        UiComboBoxClipForwardDecodingDurationSeconds.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipForwardDecodingDurationSeconds.ItemForeColor = Color.Silver
        UiComboBoxClipForwardDecodingDurationSeconds.ItemHeight = 30
        UiComboBoxClipForwardDecodingDurationSeconds.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxClipForwardDecodingDurationSeconds.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxClipForwardDecodingDurationSeconds.Items.AddRange(New Object() {"", "10", "20", "30", "60", "120", "240", "360", "600"})
        UiComboBoxClipForwardDecodingDurationSeconds.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipForwardDecodingDurationSeconds.ItemSelectForeColor = Color.Silver
        UiComboBoxClipForwardDecodingDurationSeconds.Location = New Point(21, 10)
        UiComboBoxClipForwardDecodingDurationSeconds.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxClipForwardDecodingDurationSeconds.MaxDropDownItems = 17
        UiComboBoxClipForwardDecodingDurationSeconds.MinimumSize = New Size(63, 0)
        UiComboBoxClipForwardDecodingDurationSeconds.Name = "UiComboBoxClipForwardDecodingDurationSeconds"
        UiComboBoxClipForwardDecodingDurationSeconds.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxClipForwardDecodingDurationSeconds.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxClipForwardDecodingDurationSeconds.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipForwardDecodingDurationSeconds.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipForwardDecodingDurationSeconds.ScrollBarHandleWidth = 20
        UiComboBoxClipForwardDecodingDurationSeconds.Size = New Size(150, 30)
        UiComboBoxClipForwardDecodingDurationSeconds.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxClipForwardDecodingDurationSeconds.SymbolSize = 24
        UiComboBoxClipForwardDecodingDurationSeconds.TabIndex = 103
        UiComboBoxClipForwardDecodingDurationSeconds.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxClipForwardDecodingDurationSeconds.Watermark = "Forward Decoding Duration"
        ' 
        ' Label151
        ' 
        Label151.AutoSize = True
        Label151.Dock = DockStyle.Top
        Label151.Font = New Font("Segoe UI", 10F)
        Label151.ForeColor = Color.Gray
        Label151.Location = New Point(0, 272)
        Label151.Name = "Label151"
        Label151.Padding = New Padding(16, 5, 0, 0)
        Label151.Size = New Size(187, 45)
        Label151.TabIndex = 114
        Label151.Text = "Only for Precise Cut (Fast Response)." & vbCrLf & "Integers only, unit: seconds!"
        ' 
        ' Label150
        ' 
        Label150.AutoSize = True
        Label150.Dock = DockStyle.Top
        Label150.Font = New Font("Segoe UI", 13F)
        Label150.Location = New Point(0, 228)
        Label150.Name = "Label150"
        Label150.Padding = New Padding(16, 20, 0, 0)
        Label150.Size = New Size(98, 44)
        Label150.TabIndex = 113
        Label150.Text = "Forward Decoding"
        ' 
        ' Panel76
        ' 
        Panel76.Controls.Add(UiTextBoxQuickClipOutPoint)
        Panel76.Controls.Add(Label116)
        Panel76.Controls.Add(UiTextBoxQuickClipInPoint)
        Panel76.Dock = DockStyle.Top
        Panel76.Location = New Point(0, 188)
        Panel76.Name = "Panel76"
        Panel76.Padding = New Padding(21, 10, 20, 0)
        Panel76.Size = New Size(899, 40)
        Panel76.TabIndex = 111
        ' 
        ' UiTextBoxQuickClipOutPoint
        ' 
        UiTextBoxQuickClipOutPoint.Dock = DockStyle.Left
        UiTextBoxQuickClipOutPoint.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.Font = New Font("Segoe UI", 10F)
        UiTextBoxQuickClipOutPoint.ForeColor = Color.Silver
        UiTextBoxQuickClipOutPoint.ForeDisableColor = Color.Silver
        UiTextBoxQuickClipOutPoint.ForeReadOnlyColor = Color.Silver
        UiTextBoxQuickClipOutPoint.Location = New Point(181, 10)
        UiTextBoxQuickClipOutPoint.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxQuickClipOutPoint.MinimumSize = New Size(1, 16)
        UiTextBoxQuickClipOutPoint.Name = "UiTextBoxQuickClipOutPoint"
        UiTextBoxQuickClipOutPoint.Padding = New Padding(5)
        UiTextBoxQuickClipOutPoint.Radius = 30
        UiTextBoxQuickClipOutPoint.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipOutPoint.ShowText = False
        UiTextBoxQuickClipOutPoint.Size = New Size(150, 30)
        UiTextBoxQuickClipOutPoint.TabIndex = 83
        UiTextBoxQuickClipOutPoint.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxQuickClipOutPoint.Watermark = "Out Point -to"
        ' 
        ' Label116
        ' 
        Label116.Dock = DockStyle.Left
        Label116.Location = New Point(171, 10)
        Label116.Name = "Label116"
        Label116.Size = New Size(10, 30)
        Label116.TabIndex = 82
        ' 
        ' UiTextBoxQuickClipInPoint
        ' 
        UiTextBoxQuickClipInPoint.Dock = DockStyle.Left
        UiTextBoxQuickClipInPoint.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.Font = New Font("Segoe UI", 10F)
        UiTextBoxQuickClipInPoint.ForeColor = Color.Silver
        UiTextBoxQuickClipInPoint.ForeDisableColor = Color.Silver
        UiTextBoxQuickClipInPoint.ForeReadOnlyColor = Color.Silver
        UiTextBoxQuickClipInPoint.Location = New Point(21, 10)
        UiTextBoxQuickClipInPoint.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxQuickClipInPoint.MinimumSize = New Size(1, 16)
        UiTextBoxQuickClipInPoint.Name = "UiTextBoxQuickClipInPoint"
        UiTextBoxQuickClipInPoint.Padding = New Padding(5)
        UiTextBoxQuickClipInPoint.Radius = 30
        UiTextBoxQuickClipInPoint.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxQuickClipInPoint.ShowText = False
        UiTextBoxQuickClipInPoint.Size = New Size(150, 30)
        UiTextBoxQuickClipInPoint.TabIndex = 81
        UiTextBoxQuickClipInPoint.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxQuickClipInPoint.Watermark = "In Point -ss"
        ' 
        ' Label115
        ' 
        Label115.AutoSize = True
        Label115.Dock = DockStyle.Top
        Label115.Font = New Font("Segoe UI", 10F)
        Label115.ForeColor = Color.Gray
        Label115.Location = New Point(0, 143)
        Label115.Name = "Label115"
        Label115.Padding = New Padding(16, 5, 0, 0)
        Label115.Size = New Size(397, 45)
        Label115.TabIndex = 112
        Label115.Text = "Time Format: HH:MM:SS.ms" & vbCrLf & "You can write only one to specify from time to end OR from start to time."
        ' 
        ' Label152
        ' 
        Label152.AutoSize = True
        Label152.Dock = DockStyle.Top
        Label152.Font = New Font("Segoe UI", 13F)
        Label152.Location = New Point(0, 99)
        Label152.Name = "Label152"
        Label152.Padding = New Padding(16, 20, 0, 0)
        Label152.Size = New Size(116, 44)
        Label152.TabIndex = 110
        Label152.Text = "In Point & Out Point"
        ' 
        ' Panel66
        ' 
        Panel66.Controls.Add(UiComboBoxClipMethod)
        Panel66.Dock = DockStyle.Top
        Panel66.Location = New Point(0, 59)
        Panel66.Name = "Panel66"
        Panel66.Padding = New Padding(21, 10, 20, 0)
        Panel66.Size = New Size(899, 40)
        Panel66.TabIndex = 106
        ' 
        ' UiComboBoxClipMethod
        ' 
        UiComboBoxClipMethod.DataSource = Nothing
        UiComboBoxClipMethod.Dock = DockStyle.Left
        UiComboBoxClipMethod.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxClipMethod.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipMethod.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipMethod.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipMethod.Font = New Font("Segoe UI", 10F)
        UiComboBoxClipMethod.ForeColor = Color.Silver
        UiComboBoxClipMethod.ForeDisableColor = Color.Silver
        UiComboBoxClipMethod.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxClipMethod.ItemForeColor = Color.Silver
        UiComboBoxClipMethod.ItemHeight = 30
        UiComboBoxClipMethod.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxClipMethod.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxClipMethod.Items.AddRange(New Object() {"", "Rough Cut (Immediate Response)", "Precise Cut (Decode from Start)", "Precise Cut (Fast Response)", "Trim Filter"})
        UiComboBoxClipMethod.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipMethod.ItemSelectForeColor = Color.Silver
        UiComboBoxClipMethod.Location = New Point(21, 10)
        UiComboBoxClipMethod.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxClipMethod.MaxDropDownItems = 17
        UiComboBoxClipMethod.MinimumSize = New Size(63, 0)
        UiComboBoxClipMethod.Name = "UiComboBoxClipMethod"
        UiComboBoxClipMethod.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxClipMethod.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxClipMethod.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipMethod.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxClipMethod.ScrollBarHandleWidth = 20
        UiComboBoxClipMethod.Size = New Size(310, 30)
        UiComboBoxClipMethod.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxClipMethod.SymbolSize = 24
        UiComboBoxClipMethod.TabIndex = 103
        UiComboBoxClipMethod.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxClipMethod.Watermark = "Method"
        ' 
        ' Label109
        ' 
        Label109.AutoSize = True
        Label109.Dock = DockStyle.Top
        Label109.Font = New Font("Segoe UI", 10F)
        Label109.ForeColor = Color.Gray
        Label109.Location = New Point(0, 34)
        Label109.Name = "Label109"
        Label109.Padding = New Padding(16, 5, 0, 0)
        Label109.Size = New Size(179, 25)
        Label109.TabIndex = 105
        Label109.Text = "View notices in Tooltip board"
        ' 
        ' Label146
        ' 
        Label146.AutoSize = True
        Label146.Dock = DockStyle.Top
        Label146.Font = New Font("Segoe UI", 13F)
        Label146.Location = New Point(0, 0)
        Label146.Name = "Label146"
        Label146.Padding = New Padding(16, 10, 0, 0)
        Label146.Size = New Size(98, 34)
        Label146.TabIndex = 109
        Label146.Text = "Clip Mode"
        ' 
        ' TabPageStreamControl
        ' 
        TabPageStreamControl.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageStreamControl.Controls.Add(Label32)
        TabPageStreamControl.Controls.Add(Panel64)
        TabPageStreamControl.Controls.Add(Label111)
        TabPageStreamControl.Controls.Add(Label165)
        TabPageStreamControl.Controls.Add(Panel91)
        TabPageStreamControl.Controls.Add(Label164)
        TabPageStreamControl.Controls.Add(Panel97)
        TabPageStreamControl.Controls.Add(Panel47)
        TabPageStreamControl.Controls.Add(Panel63)
        TabPageStreamControl.Controls.Add(Label112)
        TabPageStreamControl.Controls.Add(Panel61)
        TabPageStreamControl.Controls.Add(Label113)
        TabPageStreamControl.Controls.Add(Panel62)
        TabPageStreamControl.Controls.Add(Label114)
        TabPageStreamControl.Location = New Point(201, 0)
        TabPageStreamControl.Name = "TabPageStreamControl"
        TabPageStreamControl.Size = New Size(899, 650)
        TabPageStreamControl.TabIndex = 10
        TabPageStreamControl.Tag = "TabPage.StreamControl"
        TabPageStreamControl.Text = "Stream Control"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Dock = DockStyle.Bottom
        Label32.Font = New Font("Segoe UI", 9F)
        Label32.ForeColor = Color.Gray
        Label32.Location = New Point(0, 549)
        Label32.Name = "Label32"
        Label32.Padding = New Padding(16, 0, 0, 16)
        Label32.Size = New Size(540, 101)
        Label32.TabIndex = 118
        Label32.Text = "ffmpeg's -map parameter has high priority; when used, other stream types must also use -map, otherwise ffmpeg may discard them." & vbCrLf & "Default logic preserves only one video and one audio stream." & vbCrLf & "You must specify a stream to use 'Preserve Other Streams', otherwise unexpected issues may occur." & vbCrLf & "When specifying streams AND preserving others, some parameters may be incompatible." & vbCrLf & "Be careful with multi-track media; try to use filters for other requirements."
        ' 
        ' Panel64
        ' 
        Panel64.Controls.Add(Label108)
        Panel64.Controls.Add(UiComboBoxAttachmentOption)
        Panel64.Controls.Add(Label163)
        Panel64.Controls.Add(UiComboBoxChapterOption)
        Panel64.Controls.Add(Label148)
        Panel64.Controls.Add(UiComboBoxMetadataOption)
        Panel64.Dock = DockStyle.Top
        Panel64.Location = New Point(0, 454)
        Panel64.Name = "Panel64"
        Panel64.Padding = New Padding(21, 10, 20, 0)
        Panel64.Size = New Size(899, 40)
        Panel64.TabIndex = 22
        ' 
        ' Label108
        ' 
        Label108.Dock = DockStyle.Fill
        Label108.Font = New Font("Segoe UI", 10F)
        Label108.ForeColor = Color.Gray
        Label108.Location = New Point(491, 10)
        Label108.Name = "Label108"
        Label108.Padding = New Padding(10, 0, 0, 0)
        Label108.Size = New Size(388, 30)
        Label108.TabIndex = 106
        Label108.Text = "These functions only apply to the file of the first '-i'"
        Label108.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiComboBoxAttachmentOption
        ' 
        UiComboBoxAttachmentOption.DataSource = Nothing
        UiComboBoxAttachmentOption.Dock = DockStyle.Left
        UiComboBoxAttachmentOption.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAttachmentOption.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAttachmentOption.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAttachmentOption.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAttachmentOption.Font = New Font("Segoe UI", 10F)
        UiComboBoxAttachmentOption.ForeColor = Color.Silver
        UiComboBoxAttachmentOption.ForeDisableColor = Color.Silver
        UiComboBoxAttachmentOption.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAttachmentOption.ItemForeColor = Color.Silver
        UiComboBoxAttachmentOption.ItemHeight = 30
        UiComboBoxAttachmentOption.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAttachmentOption.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAttachmentOption.Items.AddRange(New Object() {"", "Preserve Attachment"})
        UiComboBoxAttachmentOption.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAttachmentOption.ItemSelectForeColor = Color.Silver
        UiComboBoxAttachmentOption.Location = New Point(341, 10)
        UiComboBoxAttachmentOption.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAttachmentOption.MaxDropDownItems = 17
        UiComboBoxAttachmentOption.MinimumSize = New Size(63, 0)
        UiComboBoxAttachmentOption.Name = "UiComboBoxAttachmentOption"
        UiComboBoxAttachmentOption.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAttachmentOption.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAttachmentOption.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAttachmentOption.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAttachmentOption.ScrollBarHandleWidth = 20
        UiComboBoxAttachmentOption.Size = New Size(150, 30)
        UiComboBoxAttachmentOption.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAttachmentOption.SymbolSize = 24
        UiComboBoxAttachmentOption.TabIndex = 104
        UiComboBoxAttachmentOption.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAttachmentOption.Watermark = "Attachment Options"
        ' 
        ' Label163
        ' 
        Label163.Dock = DockStyle.Left
        Label163.Location = New Point(331, 10)
        Label163.Name = "Label163"
        Label163.Size = New Size(10, 30)
        Label163.TabIndex = 105
        ' 
        ' UiComboBoxChapterOption
        ' 
        UiComboBoxChapterOption.DataSource = Nothing
        UiComboBoxChapterOption.Dock = DockStyle.Left
        UiComboBoxChapterOption.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxChapterOption.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChapterOption.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChapterOption.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChapterOption.Font = New Font("Segoe UI", 10F)
        UiComboBoxChapterOption.ForeColor = Color.Silver
        UiComboBoxChapterOption.ForeDisableColor = Color.Silver
        UiComboBoxChapterOption.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxChapterOption.ItemForeColor = Color.Silver
        UiComboBoxChapterOption.ItemHeight = 30
        UiComboBoxChapterOption.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxChapterOption.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxChapterOption.Items.AddRange(New Object() {"", "Preserve Chapter", "Clear Chapter"})
        UiComboBoxChapterOption.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChapterOption.ItemSelectForeColor = Color.Silver
        UiComboBoxChapterOption.Location = New Point(181, 10)
        UiComboBoxChapterOption.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxChapterOption.MaxDropDownItems = 17
        UiComboBoxChapterOption.MinimumSize = New Size(63, 0)
        UiComboBoxChapterOption.Name = "UiComboBoxChapterOption"
        UiComboBoxChapterOption.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxChapterOption.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxChapterOption.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChapterOption.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxChapterOption.ScrollBarHandleWidth = 20
        UiComboBoxChapterOption.Size = New Size(150, 30)
        UiComboBoxChapterOption.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxChapterOption.SymbolSize = 24
        UiComboBoxChapterOption.TabIndex = 102
        UiComboBoxChapterOption.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxChapterOption.Watermark = "Chapter Options"
        ' 
        ' Label148
        ' 
        Label148.Dock = DockStyle.Left
        Label148.Location = New Point(171, 10)
        Label148.Name = "Label148"
        Label148.Size = New Size(10, 30)
        Label148.TabIndex = 103
        ' 
        ' UiComboBoxMetadataOption
        ' 
        UiComboBoxMetadataOption.DataSource = Nothing
        UiComboBoxMetadataOption.Dock = DockStyle.Left
        UiComboBoxMetadataOption.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxMetadataOption.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMetadataOption.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMetadataOption.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMetadataOption.Font = New Font("Segoe UI", 10F)
        UiComboBoxMetadataOption.ForeColor = Color.Silver
        UiComboBoxMetadataOption.ForeDisableColor = Color.Silver
        UiComboBoxMetadataOption.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxMetadataOption.ItemForeColor = Color.Silver
        UiComboBoxMetadataOption.ItemHeight = 30
        UiComboBoxMetadataOption.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxMetadataOption.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxMetadataOption.Items.AddRange(New Object() {"", "Preserve Metadata", "Clear Metadata", "Preserve More Metadata"})
        UiComboBoxMetadataOption.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMetadataOption.ItemSelectForeColor = Color.Silver
        UiComboBoxMetadataOption.Location = New Point(21, 10)
        UiComboBoxMetadataOption.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxMetadataOption.MaxDropDownItems = 17
        UiComboBoxMetadataOption.MinimumSize = New Size(63, 0)
        UiComboBoxMetadataOption.Name = "UiComboBoxMetadataOption"
        UiComboBoxMetadataOption.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxMetadataOption.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxMetadataOption.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMetadataOption.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxMetadataOption.ScrollBarHandleWidth = 20
        UiComboBoxMetadataOption.Size = New Size(150, 30)
        UiComboBoxMetadataOption.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxMetadataOption.SymbolSize = 24
        UiComboBoxMetadataOption.TabIndex = 101
        UiComboBoxMetadataOption.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxMetadataOption.Watermark = "Metadata Options"
        ' 
        ' Label111
        ' 
        Label111.AutoSize = True
        Label111.Dock = DockStyle.Top
        Label111.Font = New Font("Segoe UI", 11F)
        Label111.Location = New Point(0, 419)
        Label111.Name = "Label111"
        Label111.Padding = New Padding(16, 15, 0, 0)
        Label111.Size = New Size(172, 35)
        Label111.TabIndex = 26
        Label111.Text = "Metadata && Chapter && Attachment"
        ' 
        ' Label165
        ' 
        Label165.AutoSize = True
        Label165.Dock = DockStyle.Top
        Label165.Font = New Font("Segoe UI", 9F)
        Label165.ForeColor = Color.Gray
        Label165.Location = New Point(0, 380)
        Label165.Name = "Label165"
        Label165.Padding = New Padding(16, 5, 0, 0)
        Label165.Size = New Size(359, 39)
        Label165.TabIndex = 115
        Label165.Text = "These functions force use of '-map' because they cannot be handled otherwise." & vbCrLf & "As stated below, use '-map' for other stream types."
        ' 
        ' Panel91
        ' 
        Panel91.Controls.Add(Label110)
        Panel91.Controls.Add(UiCheckBoxAutoMuxSubtitleToMovtext)
        Panel91.Controls.Add(UiCheckBoxAutoMuxSSA)
        Panel91.Controls.Add(UiCheckBoxAutoMuxASS)
        Panel91.Controls.Add(UiCheckBoxAutoMuxSRT)
        Panel91.Dock = DockStyle.Top
        Panel91.Location = New Point(0, 340)
        Panel91.Name = "Panel91"
        Panel91.Padding = New Padding(18, 10, 20, 0)
        Panel91.Size = New Size(899, 40)
        Panel91.TabIndex = 103
        ' 
        ' Label110
        ' 
        Label110.Dock = DockStyle.Fill
        Label110.Font = New Font("Segoe UI", 10F)
        Label110.ForeColor = Color.Gray
        Label110.Location = New Point(441, 10)
        Label110.Name = "Label110"
        Label110.Size = New Size(438, 30)
        Label110.TabIndex = 107
        Label110.Text = "mp4 only supports mov_text subtitles"
        Label110.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiCheckBoxAutoMuxSubtitleToMovtext
        ' 
        UiCheckBoxAutoMuxSubtitleToMovtext.CheckBoxColor = Color.Silver
        UiCheckBoxAutoMuxSubtitleToMovtext.CheckBoxSize = 20
        UiCheckBoxAutoMuxSubtitleToMovtext.Dock = DockStyle.Left
        UiCheckBoxAutoMuxSubtitleToMovtext.Font = New Font("Segoe UI", 10F)
        UiCheckBoxAutoMuxSubtitleToMovtext.ForeColor = Color.DarkGray
        UiCheckBoxAutoMuxSubtitleToMovtext.Location = New Point(258, 10)
        UiCheckBoxAutoMuxSubtitleToMovtext.MinimumSize = New Size(1, 1)
        UiCheckBoxAutoMuxSubtitleToMovtext.Name = "UiCheckBoxAutoMuxSubtitleToMovtext"
        UiCheckBoxAutoMuxSubtitleToMovtext.Size = New Size(183, 30)
        UiCheckBoxAutoMuxSubtitleToMovtext.TabIndex = 102
        UiCheckBoxAutoMuxSubtitleToMovtext.Text = "Convert to mov_text"
        ' 
        ' UiCheckBoxAutoMuxSSA
        ' 
        UiCheckBoxAutoMuxSSA.CheckBoxColor = Color.Silver
        UiCheckBoxAutoMuxSSA.CheckBoxSize = 20
        UiCheckBoxAutoMuxSSA.Dock = DockStyle.Left
        UiCheckBoxAutoMuxSSA.Font = New Font("Segoe UI", 10F)
        UiCheckBoxAutoMuxSSA.ForeColor = Color.DarkGray
        UiCheckBoxAutoMuxSSA.Location = New Point(178, 10)
        UiCheckBoxAutoMuxSSA.MinimumSize = New Size(1, 1)
        UiCheckBoxAutoMuxSSA.Name = "UiCheckBoxAutoMuxSSA"
        UiCheckBoxAutoMuxSSA.Size = New Size(80, 30)
        UiCheckBoxAutoMuxSSA.TabIndex = 101
        UiCheckBoxAutoMuxSSA.Text = "SSA"
        ' 
        ' UiCheckBoxAutoMuxASS
        ' 
        UiCheckBoxAutoMuxASS.CheckBoxColor = Color.Silver
        UiCheckBoxAutoMuxASS.CheckBoxSize = 20
        UiCheckBoxAutoMuxASS.Dock = DockStyle.Left
        UiCheckBoxAutoMuxASS.Font = New Font("Segoe UI", 10F)
        UiCheckBoxAutoMuxASS.ForeColor = Color.DarkGray
        UiCheckBoxAutoMuxASS.Location = New Point(98, 10)
        UiCheckBoxAutoMuxASS.MinimumSize = New Size(1, 1)
        UiCheckBoxAutoMuxASS.Name = "UiCheckBoxAutoMuxASS"
        UiCheckBoxAutoMuxASS.Size = New Size(80, 30)
        UiCheckBoxAutoMuxASS.TabIndex = 100
        UiCheckBoxAutoMuxASS.Text = "ASS"
        ' 
        ' UiCheckBoxAutoMuxSRT
        ' 
        UiCheckBoxAutoMuxSRT.CheckBoxColor = Color.Silver
        UiCheckBoxAutoMuxSRT.CheckBoxSize = 20
        UiCheckBoxAutoMuxSRT.Dock = DockStyle.Left
        UiCheckBoxAutoMuxSRT.Font = New Font("Segoe UI", 10F)
        UiCheckBoxAutoMuxSRT.ForeColor = Color.DarkGray
        UiCheckBoxAutoMuxSRT.Location = New Point(18, 10)
        UiCheckBoxAutoMuxSRT.MinimumSize = New Size(1, 1)
        UiCheckBoxAutoMuxSRT.Name = "UiCheckBoxAutoMuxSRT"
        UiCheckBoxAutoMuxSRT.Size = New Size(80, 30)
        UiCheckBoxAutoMuxSRT.TabIndex = 98
        UiCheckBoxAutoMuxSRT.Text = "SRT"
        ' 
        ' Label164
        ' 
        Label164.AutoSize = True
        Label164.Dock = DockStyle.Top
        Label164.Font = New Font("Segoe UI", 11F)
        Label164.Location = New Point(0, 305)
        Label164.Name = "Label164"
        Label164.Padding = New Padding(16, 15, 0, 0)
        Label164.Size = New Size(115, 35)
        Label164.TabIndex = 102
        Label164.Text = "Auto-mux Subtitles"
        ' 
        ' Panel97
        ' 
        Panel97.Controls.Add(Label107)
        Panel97.Controls.Add(UiButtonVisualStreamSelector)
        Panel97.Dock = DockStyle.Top
        Panel97.Location = New Point(0, 265)
        Panel97.Name = "Panel97"
        Panel97.Padding = New Padding(21, 10, 20, 0)
        Panel97.Size = New Size(899, 40)
        Panel97.TabIndex = 120
        ' 
        ' Label107
        ' 
        Label107.Dock = DockStyle.Fill
        Label107.Font = New Font("Segoe UI", 10F)
        Label107.ForeColor = Color.Gray
        Label107.Location = New Point(221, 10)
        Label107.Name = "Label107"
        Label107.Padding = New Padding(10, 0, 0, 0)
        Label107.Size = New Size(658, 30)
        Label107.TabIndex = 101
        Label107.Text = "Recommend using the Visual Stream Selector to quickly fill the three text boxes above."
        Label107.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButtonVisualStreamSelector
        ' 
        UiButtonVisualStreamSelector.Dock = DockStyle.Left
        UiButtonVisualStreamSelector.FillColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonVisualStreamSelector.FillColor2 = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonVisualStreamSelector.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonVisualStreamSelector.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonVisualStreamSelector.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonVisualStreamSelector.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonVisualStreamSelector.Font = New Font("Segoe UI", 10F)
        UiButtonVisualStreamSelector.ForeColor = Color.Silver
        UiButtonVisualStreamSelector.ForeDisableColor = Color.Silver
        UiButtonVisualStreamSelector.ForeHoverColor = Color.Silver
        UiButtonVisualStreamSelector.ForePressColor = Color.Silver
        UiButtonVisualStreamSelector.ForeSelectedColor = Color.Silver
        UiButtonVisualStreamSelector.Location = New Point(21, 10)
        UiButtonVisualStreamSelector.MinimumSize = New Size(1, 1)
        UiButtonVisualStreamSelector.Name = "UiButtonVisualStreamSelector"
        UiButtonVisualStreamSelector.Radius = 30
        UiButtonVisualStreamSelector.RectColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonVisualStreamSelector.RectDisableColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButtonVisualStreamSelector.RectHoverColor = Color.DarkGray
        UiButtonVisualStreamSelector.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonVisualStreamSelector.RectSelectedColor = Color.DarkGray
        UiButtonVisualStreamSelector.Size = New Size(200, 30)
        UiButtonVisualStreamSelector.TabIndex = 84
        UiButtonVisualStreamSelector.Text = "Visual Stream Selector"
        UiButtonVisualStreamSelector.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Panel47
        ' 
        Panel47.Controls.Add(UiCheckBoxPreserveOtherSubtitleStreams)
        Panel47.Controls.Add(Label184)
        Panel47.Dock = DockStyle.Top
        Panel47.Location = New Point(0, 225)
        Panel47.Name = "Panel47"
        Panel47.Padding = New Padding(21, 10, 20, 0)
        Panel47.Size = New Size(899, 40)
        Panel47.TabIndex = 116
        ' 
        ' UiCheckBoxPreserveOtherSubtitleStreams
        ' 
        UiCheckBoxPreserveOtherSubtitleStreams.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveOtherSubtitleStreams.CheckBoxSize = 20
        UiCheckBoxPreserveOtherSubtitleStreams.Dock = DockStyle.Left
        UiCheckBoxPreserveOtherSubtitleStreams.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveOtherSubtitleStreams.ForeColor = Color.DarkGray
        UiCheckBoxPreserveOtherSubtitleStreams.Location = New Point(231, 10)
        UiCheckBoxPreserveOtherSubtitleStreams.MinimumSize = New Size(1, 1)
        UiCheckBoxPreserveOtherSubtitleStreams.Name = "UiCheckBoxPreserveOtherSubtitleStreams"
        UiCheckBoxPreserveOtherSubtitleStreams.Size = New Size(210, 30)
        UiCheckBoxPreserveOtherSubtitleStreams.TabIndex = 110
        UiCheckBoxPreserveOtherSubtitleStreams.Text = "Then Preserve Other Subtitle Streams"
        ' 
        ' Label184
        ' 
        Label184.Dock = DockStyle.Left
        Label184.Location = New Point(21, 10)
        Label184.Name = "Label184"
        Label184.Size = New Size(210, 30)
        Label184.TabIndex = 109
        ' 
        ' Panel63
        ' 
        Panel63.Controls.Add(Label166)
        Panel63.Controls.Add(Label169)
        Panel63.Controls.Add(UiComboBoxWhichEmbeddedSubtitlesOperation)
        Panel63.Controls.Add(Label168)
        Panel63.Controls.Add(UiTextBoxWhichEmbeddedSubtitles)
        Panel63.Dock = DockStyle.Top
        Panel63.Location = New Point(0, 185)
        Panel63.Name = "Panel63"
        Panel63.Padding = New Padding(21, 10, 20, 0)
        Panel63.Size = New Size(899, 40)
        Panel63.TabIndex = 21
        ' 
        ' Label166
        ' 
        Label166.Dock = DockStyle.Fill
        Label166.Font = New Font("Segoe UI", 10F)
        Label166.ForeColor = Color.Gray
        Label166.Location = New Point(441, 10)
        Label166.Name = "Label166"
        Label166.Size = New Size(438, 30)
        Label166.TabIndex = 111
        Label166.Text = "FileIndex:s:StreamIndex; 0:s means all subtitle streams of the first file"
        Label166.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label169
        ' 
        Label169.Dock = DockStyle.Left
        Label169.Location = New Point(394, 10)
        Label169.Name = "Label169"
        Label169.Size = New Size(47, 30)
        Label169.TabIndex = 112
        ' 
        ' UiComboBoxWhichEmbeddedSubtitlesOperation
        ' 
        UiComboBoxWhichEmbeddedSubtitlesOperation.DataSource = Nothing
        UiComboBoxWhichEmbeddedSubtitlesOperation.Dock = DockStyle.Left
        UiComboBoxWhichEmbeddedSubtitlesOperation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxWhichEmbeddedSubtitlesOperation.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxWhichEmbeddedSubtitlesOperation.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxWhichEmbeddedSubtitlesOperation.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxWhichEmbeddedSubtitlesOperation.Font = New Font("Segoe UI", 10F)
        UiComboBoxWhichEmbeddedSubtitlesOperation.ForeColor = Color.Silver
        UiComboBoxWhichEmbeddedSubtitlesOperation.ForeDisableColor = Color.Silver
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemForeColor = Color.Silver
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemHeight = 30
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxWhichEmbeddedSubtitlesOperation.Items.AddRange(New Object() {"", "Copy Stream", "Convert to mov_text", "Convert to srt", "Convert to ass", "Convert to ssa"})
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxWhichEmbeddedSubtitlesOperation.ItemSelectForeColor = Color.Silver
        UiComboBoxWhichEmbeddedSubtitlesOperation.Location = New Point(234, 10)
        UiComboBoxWhichEmbeddedSubtitlesOperation.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxWhichEmbeddedSubtitlesOperation.MaxDropDownItems = 17
        UiComboBoxWhichEmbeddedSubtitlesOperation.MinimumSize = New Size(63, 0)
        UiComboBoxWhichEmbeddedSubtitlesOperation.Name = "UiComboBoxWhichEmbeddedSubtitlesOperation"
        UiComboBoxWhichEmbeddedSubtitlesOperation.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxWhichEmbeddedSubtitlesOperation.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxWhichEmbeddedSubtitlesOperation.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxWhichEmbeddedSubtitlesOperation.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxWhichEmbeddedSubtitlesOperation.ScrollBarHandleWidth = 20
        UiComboBoxWhichEmbeddedSubtitlesOperation.Size = New Size(160, 30)
        UiComboBoxWhichEmbeddedSubtitlesOperation.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxWhichEmbeddedSubtitlesOperation.SymbolSize = 24
        UiComboBoxWhichEmbeddedSubtitlesOperation.TabIndex = 110
        UiComboBoxWhichEmbeddedSubtitlesOperation.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxWhichEmbeddedSubtitlesOperation.Watermark = "Operation"
        ' 
        ' Label168
        ' 
        Label168.Dock = DockStyle.Left
        Label168.Location = New Point(221, 10)
        Label168.Name = "Label168"
        Label168.Size = New Size(13, 30)
        Label168.TabIndex = 109
        ' 
        ' UiTextBoxWhichEmbeddedSubtitles
        ' 
        UiTextBoxWhichEmbeddedSubtitles.Dock = DockStyle.Left
        UiTextBoxWhichEmbeddedSubtitles.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.Font = New Font("Segoe UI", 10F)
        UiTextBoxWhichEmbeddedSubtitles.ForeColor = Color.Silver
        UiTextBoxWhichEmbeddedSubtitles.ForeDisableColor = Color.Silver
        UiTextBoxWhichEmbeddedSubtitles.ForeReadOnlyColor = Color.Silver
        UiTextBoxWhichEmbeddedSubtitles.Location = New Point(21, 10)
        UiTextBoxWhichEmbeddedSubtitles.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxWhichEmbeddedSubtitles.MinimumSize = New Size(1, 16)
        UiTextBoxWhichEmbeddedSubtitles.Name = "UiTextBoxWhichEmbeddedSubtitles"
        UiTextBoxWhichEmbeddedSubtitles.Padding = New Padding(5)
        UiTextBoxWhichEmbeddedSubtitles.Radius = 30
        UiTextBoxWhichEmbeddedSubtitles.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxWhichEmbeddedSubtitles.ShowText = False
        UiTextBoxWhichEmbeddedSubtitles.Size = New Size(200, 30)
        UiTextBoxWhichEmbeddedSubtitles.TabIndex = 108
        UiTextBoxWhichEmbeddedSubtitles.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxWhichEmbeddedSubtitles.Watermark = "Separate multiple with commas"
        ' 
        ' Label112
        ' 
        Label112.AutoSize = True
        Label112.Dock = DockStyle.Top
        Label112.Font = New Font("Segoe UI", 11F)
        Label112.Location = New Point(0, 150)
        Label112.Name = "Label112"
        Label112.Padding = New Padding(16, 15, 0, 0)
        Label112.Size = New Size(211, 35)
        Label112.TabIndex = 25
        Label112.Text = "Which File and Stream to use for Subtitles (s)"
        ' 
        ' Panel61
        ' 
        Panel61.Controls.Add(Label140)
        Panel61.Controls.Add(UiCheckBoxPreserveOtherAudioStreams)
        Panel61.Controls.Add(Label133)
        Panel61.Controls.Add(UiTextBoxApplyAudioParametersToStreams)
        Panel61.Dock = DockStyle.Top
        Panel61.Location = New Point(0, 110)
        Panel61.Name = "Panel61"
        Panel61.Padding = New Padding(21, 10, 20, 0)
        Panel61.Size = New Size(899, 40)
        Panel61.TabIndex = 20
        ' 
        ' Label140
        ' 
        Label140.Dock = DockStyle.Fill
        Label140.Font = New Font("Segoe UI", 10F)
        Label140.ForeColor = Color.Gray
        Label140.Location = New Point(441, 10)
        Label140.Name = "Label140"
        Label140.Size = New Size(438, 30)
        Label140.TabIndex = 100
        Label140.Text = "FileIndex:a:StreamIndex; 0:a means all audio streams of the first file"
        Label140.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiCheckBoxPreserveOtherAudioStreams
        ' 
        UiCheckBoxPreserveOtherAudioStreams.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveOtherAudioStreams.CheckBoxSize = 20
        UiCheckBoxPreserveOtherAudioStreams.Dock = DockStyle.Left
        UiCheckBoxPreserveOtherAudioStreams.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveOtherAudioStreams.ForeColor = Color.DarkGray
        UiCheckBoxPreserveOtherAudioStreams.Location = New Point(231, 10)
        UiCheckBoxPreserveOtherAudioStreams.MinimumSize = New Size(1, 1)
        UiCheckBoxPreserveOtherAudioStreams.Name = "UiCheckBoxPreserveOtherAudioStreams"
        UiCheckBoxPreserveOtherAudioStreams.Size = New Size(210, 30)
        UiCheckBoxPreserveOtherAudioStreams.TabIndex = 98
        UiCheckBoxPreserveOtherAudioStreams.Text = "Then Preserve Other Audio Streams"
        ' 
        ' Label133
        ' 
        Label133.Dock = DockStyle.Left
        Label133.Location = New Point(221, 10)
        Label133.Name = "Label133"
        Label133.Size = New Size(10, 30)
        Label133.TabIndex = 97
        ' 
        ' UiTextBoxApplyAudioParametersToStreams
        ' 
        UiTextBoxApplyAudioParametersToStreams.Dock = DockStyle.Left
        UiTextBoxApplyAudioParametersToStreams.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.Font = New Font("Segoe UI", 10F)
        UiTextBoxApplyAudioParametersToStreams.ForeColor = Color.Silver
        UiTextBoxApplyAudioParametersToStreams.ForeDisableColor = Color.Silver
        UiTextBoxApplyAudioParametersToStreams.ForeReadOnlyColor = Color.Silver
        UiTextBoxApplyAudioParametersToStreams.Location = New Point(21, 10)
        UiTextBoxApplyAudioParametersToStreams.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxApplyAudioParametersToStreams.MinimumSize = New Size(1, 16)
        UiTextBoxApplyAudioParametersToStreams.Name = "UiTextBoxApplyAudioParametersToStreams"
        UiTextBoxApplyAudioParametersToStreams.Padding = New Padding(5)
        UiTextBoxApplyAudioParametersToStreams.Radius = 30
        UiTextBoxApplyAudioParametersToStreams.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyAudioParametersToStreams.ShowText = False
        UiTextBoxApplyAudioParametersToStreams.Size = New Size(200, 30)
        UiTextBoxApplyAudioParametersToStreams.TabIndex = 96
        UiTextBoxApplyAudioParametersToStreams.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxApplyAudioParametersToStreams.Watermark = "Separate multiple with commas"
        ' 
        ' Label113
        ' 
        Label113.AutoSize = True
        Label113.Dock = DockStyle.Top
        Label113.Font = New Font("Segoe UI", 11F)
        Label113.Location = New Point(0, 75)
        Label113.Name = "Label113"
        Label113.Padding = New Padding(16, 15, 0, 0)
        Label113.Size = New Size(257, 35)
        Label113.TabIndex = 24
        Label113.Text = "Which File and Stream to apply Audio Parameters to (a)"
        ' 
        ' Panel62
        ' 
        Panel62.Controls.Add(Label139)
        Panel62.Controls.Add(UiCheckBoxPreserveOtherVideoStreams)
        Panel62.Controls.Add(Label132)
        Panel62.Controls.Add(UiTextBoxApplyVideoParametersToStreams)
        Panel62.Dock = DockStyle.Top
        Panel62.Location = New Point(0, 35)
        Panel62.Name = "Panel62"
        Panel62.Padding = New Padding(21, 10, 20, 0)
        Panel62.Size = New Size(899, 40)
        Panel62.TabIndex = 19
        ' 
        ' Label139
        ' 
        Label139.Dock = DockStyle.Fill
        Label139.Font = New Font("Segoe UI", 10F)
        Label139.ForeColor = Color.Gray
        Label139.Location = New Point(441, 10)
        Label139.Name = "Label139"
        Label139.Size = New Size(438, 30)
        Label139.TabIndex = 99
        Label139.Text = "FileIndex:v:StreamIndex; 0:v means all video streams of the first file"
        Label139.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiCheckBoxPreserveOtherVideoStreams
        ' 
        UiCheckBoxPreserveOtherVideoStreams.CheckBoxColor = Color.Silver
        UiCheckBoxPreserveOtherVideoStreams.CheckBoxSize = 20
        UiCheckBoxPreserveOtherVideoStreams.Dock = DockStyle.Left
        UiCheckBoxPreserveOtherVideoStreams.Font = New Font("Segoe UI", 10F)
        UiCheckBoxPreserveOtherVideoStreams.ForeColor = Color.DarkGray
        UiCheckBoxPreserveOtherVideoStreams.Location = New Point(231, 10)
        UiCheckBoxPreserveOtherVideoStreams.MinimumSize = New Size(1, 1)
        UiCheckBoxPreserveOtherVideoStreams.Name = "UiCheckBoxPreserveOtherVideoStreams"
        UiCheckBoxPreserveOtherVideoStreams.Size = New Size(210, 30)
        UiCheckBoxPreserveOtherVideoStreams.TabIndex = 98
        UiCheckBoxPreserveOtherVideoStreams.Text = "Then Preserve Other Video Streams"
        ' 
        ' Label132
        ' 
        Label132.Dock = DockStyle.Left
        Label132.Location = New Point(221, 10)
        Label132.Name = "Label132"
        Label132.Size = New Size(10, 30)
        Label132.TabIndex = 97
        ' 
        ' UiTextBoxApplyVideoParametersToStreams
        ' 
        UiTextBoxApplyVideoParametersToStreams.Dock = DockStyle.Left
        UiTextBoxApplyVideoParametersToStreams.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.Font = New Font("Segoe UI", 10F)
        UiTextBoxApplyVideoParametersToStreams.ForeColor = Color.Silver
        UiTextBoxApplyVideoParametersToStreams.ForeDisableColor = Color.Silver
        UiTextBoxApplyVideoParametersToStreams.ForeReadOnlyColor = Color.Silver
        UiTextBoxApplyVideoParametersToStreams.Location = New Point(21, 10)
        UiTextBoxApplyVideoParametersToStreams.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxApplyVideoParametersToStreams.MinimumSize = New Size(1, 16)
        UiTextBoxApplyVideoParametersToStreams.Name = "UiTextBoxApplyVideoParametersToStreams"
        UiTextBoxApplyVideoParametersToStreams.Padding = New Padding(5)
        UiTextBoxApplyVideoParametersToStreams.Radius = 30
        UiTextBoxApplyVideoParametersToStreams.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.RectReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBoxApplyVideoParametersToStreams.ShowText = False
        UiTextBoxApplyVideoParametersToStreams.Size = New Size(200, 30)
        UiTextBoxApplyVideoParametersToStreams.TabIndex = 96
        UiTextBoxApplyVideoParametersToStreams.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxApplyVideoParametersToStreams.Watermark = "Separate multiple with commas"
        ' 
        ' Label114
        ' 
        Label114.AutoSize = True
        Label114.Dock = DockStyle.Top
        Label114.Font = New Font("Segoe UI", 11F)
        Label114.Location = New Point(0, 0)
        Label114.Name = "Label114"
        Label114.Padding = New Padding(16, 15, 0, 0)
        Label114.Size = New Size(257, 35)
        Label114.TabIndex = 23
        Label114.Text = "Which File and Stream to apply Video Parameters to (v)"
        ' 
        ' TabPagePresetManagement
        ' 
        TabPagePresetManagement.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPagePresetManagement.Controls.Add(Panel77)
        TabPagePresetManagement.Controls.Add(Panel69)
        TabPagePresetManagement.Controls.Add(Panel68)
        TabPagePresetManagement.Controls.Add(Label123)
        TabPagePresetManagement.Location = New Point(201, 0)
        TabPagePresetManagement.Name = "TabPagePresetManagement"
        TabPagePresetManagement.Size = New Size(899, 650)
        TabPagePresetManagement.TabIndex = 12
        TabPagePresetManagement.Tag = "TabPage.SchemeManagement"
        TabPagePresetManagement.Text = "Preset Management"
        ' 
        ' Panel77
        ' 
        Panel77.Controls.Add(Panel84)
        Panel77.Controls.Add(Label158)
        Panel77.Controls.Add(Panel83)
        Panel77.Controls.Add(Label157)
        Panel77.Controls.Add(Panel82)
        Panel77.Dock = DockStyle.Fill
        Panel77.Location = New Point(0, 111)
        Panel77.Name = "Panel77"
        Panel77.Padding = New Padding(20, 10, 20, 20)
        Panel77.Size = New Size(899, 454)
        Panel77.TabIndex = 34
        ' 
        ' Panel84
        ' 
        Panel84.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel84.Controls.Add(RichTextBox4)
        Panel84.Dock = DockStyle.Fill
        Panel84.Location = New Point(600, 10)
        Panel84.Name = "Panel84"
        Panel84.Padding = New Padding(10)
        Panel84.Size = New Size(279, 424)
        Panel84.TabIndex = 113
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        RichTextBox4.BorderStyle = BorderStyle.None
        RichTextBox4.DetectUrls = False
        RichTextBox4.Dock = DockStyle.Fill
        RichTextBox4.Font = New Font("Segoe UI", 10F)
        RichTextBox4.ForeColor = Color.DarkGray
        RichTextBox4.Location = New Point(10, 10)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.ReadOnly = True
        RichTextBox4.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox4.Size = New Size(259, 404)
        RichTextBox4.TabIndex = 11
        RichTextBox4.Text = ""
        ' 
        ' Label158
        ' 
        Label158.Dock = DockStyle.Left
        Label158.Location = New Point(590, 10)
        Label158.Name = "Label158"
        Label158.Size = New Size(10, 424)
        Label158.TabIndex = 114
        ' 
        ' Panel83
        ' 
        Panel83.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel83.Controls.Add(RichTextBox3)
        Panel83.Dock = DockStyle.Left
        Panel83.Location = New Point(310, 10)
        Panel83.Name = "Panel83"
        Panel83.Padding = New Padding(10)
        Panel83.Size = New Size(280, 424)
        Panel83.TabIndex = 37
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        RichTextBox3.BorderStyle = BorderStyle.None
        RichTextBox3.DetectUrls = False
        RichTextBox3.Dock = DockStyle.Fill
        RichTextBox3.Font = New Font("Segoe UI", 10F)
        RichTextBox3.ForeColor = Color.DarkGray
        RichTextBox3.Location = New Point(10, 10)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.ReadOnly = True
        RichTextBox3.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBox3.Size = New Size(260, 404)
        RichTextBox3.TabIndex = 11
        RichTextBox3.Text = ""
        ' 
        ' Label157
        ' 
        Label157.Dock = DockStyle.Left
        Label157.Location = New Point(300, 10)
        Label157.Name = "Label157"
        Label157.Size = New Size(10, 424)
        Label157.TabIndex = 112
        ' 
        ' Panel82
        ' 
        Panel82.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel82.Controls.Add(ListView2)
        Panel82.Dock = DockStyle.Left
        Panel82.Location = New Point(20, 10)
        Panel82.Name = "Panel82"
        Panel82.Padding = New Padding(10, 10, 0, 10)
        Panel82.Size = New Size(280, 424)
        Panel82.TabIndex = 7
        ' 
        ' ListView2
        ' 
        ListView2.AllowDrop = True
        ListView2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        ListView2.BorderStyle = BorderStyle.None
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView2.Dock = DockStyle.Fill
        ListView2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView2.ForeColor = Color.Silver
        ListView2.FullRowSelect = True
        ListView2.HeaderStyle = ColumnHeaderStyle.None
        ListView2.LabelEdit = True
        ListView2.Location = New Point(10, 10)
        ListView2.Name = "ListView2"
        ListView2.OwnerDraw = True
        ListView2.ShowItemToolTips = True
        ListView2.Size = New Size(270, 404)
        ListView2.TabIndex = 0
        ListView2.TabStop = False
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' Panel69
        ' 
        Panel69.Controls.Add(UiTextBoxAutoLoadPresetFilePath)
        Panel69.Controls.Add(UiButtonSelectLoadSpecificPresetFile)
        Panel69.Controls.Add(Label175)
        Panel69.Controls.Add(UiComboBoxAutoLoadPresetOption)
        Panel69.Controls.Add(Label142)
        Panel69.Dock = DockStyle.Bottom
        Panel69.Location = New Point(0, 565)
        Panel69.Name = "Panel69"
        Panel69.Padding = New Padding(21, 0, 20, 20)
        Panel69.Size = New Size(899, 85)
        Panel69.TabIndex = 32
        ' 
        ' UiTextBoxAutoLoadPresetFilePath
        ' 
        UiTextBoxAutoLoadPresetFilePath.Dock = DockStyle.Fill
        UiTextBoxAutoLoadPresetFilePath.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAutoLoadPresetFilePath.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAutoLoadPresetFilePath.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAutoLoadPresetFilePath.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBoxAutoLoadPresetFilePath.Font = New Font("Segoe UI", 10F)
        UiTextBoxAutoLoadPresetFilePath.ForeColor = Color.DarkGray
        UiTextBoxAutoLoadPresetFilePath.ForeDisableColor = Color.DarkGray
        UiTextBoxAutoLoadPresetFilePath.ForeReadOnlyColor = Color.DarkGray
        UiTextBoxAutoLoadPresetFilePath.Location = New Point(321, 30)
        UiTextBoxAutoLoadPresetFilePath.Margin = New Padding(4, 5, 4, 5)
        UiTextBoxAutoLoadPresetFilePath.MinimumSize = New Size(1, 16)
        UiTextBoxAutoLoadPresetFilePath.Name = "UiTextBoxAutoLoadPresetFilePath"
        UiTextBoxAutoLoadPresetFilePath.Padding = New Padding(10, 5, 5, 5)
        UiTextBoxAutoLoadPresetFilePath.Radius = 0
        UiTextBoxAutoLoadPresetFilePath.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiTextBoxAutoLoadPresetFilePath.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAutoLoadPresetFilePath.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAutoLoadPresetFilePath.RectReadOnlyColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAutoLoadPresetFilePath.RectSides = ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        UiTextBoxAutoLoadPresetFilePath.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBoxAutoLoadPresetFilePath.ScrollBarColor = Color.DimGray
        UiTextBoxAutoLoadPresetFilePath.ScrollBarStyleInherited = False
        UiTextBoxAutoLoadPresetFilePath.ShowText = False
        UiTextBoxAutoLoadPresetFilePath.Size = New Size(558, 35)
        UiTextBoxAutoLoadPresetFilePath.TabIndex = 108
        UiTextBoxAutoLoadPresetFilePath.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBoxAutoLoadPresetFilePath.Watermark = "Load specified preset file"
        UiTextBoxAutoLoadPresetFilePath.WatermarkActiveColor = Color.DimGray
        UiTextBoxAutoLoadPresetFilePath.WatermarkColor = Color.DimGray
        ' 
        ' UiButtonSelectLoadSpecificPresetFile
        ' 
        UiButtonSelectLoadSpecificPresetFile.Dock = DockStyle.Left
        UiButtonSelectLoadSpecificPresetFile.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectLoadSpecificPresetFile.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectLoadSpecificPresetFile.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSelectLoadSpecificPresetFile.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectLoadSpecificPresetFile.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectLoadSpecificPresetFile.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSelectLoadSpecificPresetFile.Font = New Font("Segoe UI", 10F)
        UiButtonSelectLoadSpecificPresetFile.ForeColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.ForeDisableColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.ForeHoverColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.ForePressColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.ForeSelectedColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.Location = New Point(241, 30)
        UiButtonSelectLoadSpecificPresetFile.MinimumSize = New Size(1, 1)
        UiButtonSelectLoadSpecificPresetFile.Name = "UiButtonSelectLoadSpecificPresetFile"
        UiButtonSelectLoadSpecificPresetFile.Radius = 0
        UiButtonSelectLoadSpecificPresetFile.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonSelectLoadSpecificPresetFile.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonSelectLoadSpecificPresetFile.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonSelectLoadSpecificPresetFile.RectHoverColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonSelectLoadSpecificPresetFile.RectSelectedColor = Color.CornflowerBlue
        UiButtonSelectLoadSpecificPresetFile.Size = New Size(80, 35)
        UiButtonSelectLoadSpecificPresetFile.TabIndex = 109
        UiButtonSelectLoadSpecificPresetFile.Text = "Select"
        UiButtonSelectLoadSpecificPresetFile.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label175
        ' 
        Label175.Dock = DockStyle.Left
        Label175.Location = New Point(231, 30)
        Label175.Name = "Label175"
        Label175.Size = New Size(10, 35)
        Label175.TabIndex = 107
        ' 
        ' UiComboBoxAutoLoadPresetOption
        ' 
        UiComboBoxAutoLoadPresetOption.DataSource = Nothing
        UiComboBoxAutoLoadPresetOption.Dock = DockStyle.Left
        UiComboBoxAutoLoadPresetOption.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBoxAutoLoadPresetOption.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoLoadPresetOption.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoLoadPresetOption.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoLoadPresetOption.Font = New Font("Segoe UI", 10F)
        UiComboBoxAutoLoadPresetOption.ForeColor = Color.Silver
        UiComboBoxAutoLoadPresetOption.ForeDisableColor = Color.Silver
        UiComboBoxAutoLoadPresetOption.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBoxAutoLoadPresetOption.ItemForeColor = Color.Silver
        UiComboBoxAutoLoadPresetOption.ItemHeight = 30
        UiComboBoxAutoLoadPresetOption.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBoxAutoLoadPresetOption.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBoxAutoLoadPresetOption.Items.AddRange(New Object() {"No Auto Load", "Auto Load Last Preset File", "Auto Load Specified Preset File", "Auto Load Last All Changes"})
        UiComboBoxAutoLoadPresetOption.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoLoadPresetOption.ItemSelectForeColor = Color.Silver
        UiComboBoxAutoLoadPresetOption.Location = New Point(21, 30)
        UiComboBoxAutoLoadPresetOption.Margin = New Padding(4, 5, 4, 5)
        UiComboBoxAutoLoadPresetOption.MaxDropDownItems = 17
        UiComboBoxAutoLoadPresetOption.MinimumSize = New Size(63, 0)
        UiComboBoxAutoLoadPresetOption.Name = "UiComboBoxAutoLoadPresetOption"
        UiComboBoxAutoLoadPresetOption.Padding = New Padding(0, 0, 30, 2)
        UiComboBoxAutoLoadPresetOption.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBoxAutoLoadPresetOption.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoLoadPresetOption.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBoxAutoLoadPresetOption.ScrollBarHandleWidth = 20
        UiComboBoxAutoLoadPresetOption.Size = New Size(210, 35)
        UiComboBoxAutoLoadPresetOption.Style = Sunny.UI.UIStyle.Custom
        UiComboBoxAutoLoadPresetOption.SymbolSize = 24
        UiComboBoxAutoLoadPresetOption.TabIndex = 106
        UiComboBoxAutoLoadPresetOption.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBoxAutoLoadPresetOption.Watermark = "Auto Load Preset"
        ' 
        ' Label142
        ' 
        Label142.Dock = DockStyle.Top
        Label142.Font = New Font("Segoe UI", 10F)
        Label142.ForeColor = Color.Gray
        Label142.Location = New Point(21, 0)
        Label142.Name = "Label142"
        Label142.Size = New Size(858, 30)
        Label142.TabIndex = 110
        Label142.Text = "Auto Load Explanation: Due to technical limitations, Auto Load only works when switching to Parameters Panel after Start."
        Label142.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel68
        ' 
        Panel68.Controls.Add(UiCheckBoxExtraSaveInfo)
        Panel68.Controls.Add(Label126)
        Panel68.Controls.Add(UiButtonResetParametersPanel)
        Panel68.Controls.Add(Label125)
        Panel68.Controls.Add(UiButtonImportPreset)
        Panel68.Controls.Add(Label149)
        Panel68.Controls.Add(UiButtonExportPreset)
        Panel68.Controls.Add(Label95)
        Panel68.Controls.Add(UiButtonReadPreset)
        Panel68.Controls.Add(Label129)
        Panel68.Controls.Add(UiButtonSavePreset)
        Panel68.Controls.Add(Label159)
        Panel68.Controls.Add(UiButtonRefreshPresetList)
        Panel68.Dock = DockStyle.Top
        Panel68.Location = New Point(0, 66)
        Panel68.Name = "Panel68"
        Panel68.Padding = New Padding(21, 10, 0, 0)
        Panel68.Size = New Size(899, 45)
        Panel68.TabIndex = 31
        ' 
        ' UiCheckBoxExtraSaveInfo
        ' 
        UiCheckBoxExtraSaveInfo.CheckBoxColor = Color.Silver
        UiCheckBoxExtraSaveInfo.CheckBoxSize = 20
        UiCheckBoxExtraSaveInfo.Dock = DockStyle.Fill
        UiCheckBoxExtraSaveInfo.Font = New Font("Segoe UI", 10F)
        UiCheckBoxExtraSaveInfo.ForeColor = Color.Silver
        UiCheckBoxExtraSaveInfo.Location = New Point(551, 10)
        UiCheckBoxExtraSaveInfo.MinimumSize = New Size(1, 1)
        UiCheckBoxExtraSaveInfo.Name = "UiCheckBoxExtraSaveInfo"
        UiCheckBoxExtraSaveInfo.Size = New Size(348, 35)
        UiCheckBoxExtraSaveInfo.TabIndex = 106
        UiCheckBoxExtraSaveInfo.Text = "Save Extra Output Location"
        ' 
        ' Label126
        ' 
        Label126.Dock = DockStyle.Left
        Label126.Location = New Point(541, 10)
        Label126.Name = "Label126"
        Label126.Size = New Size(10, 35)
        Label126.TabIndex = 111
        ' 
        ' UiButtonResetParametersPanel
        ' 
        UiButtonResetParametersPanel.Dock = DockStyle.Left
        UiButtonResetParametersPanel.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetParametersPanel.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetParametersPanel.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonResetParametersPanel.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonResetParametersPanel.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonResetParametersPanel.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonResetParametersPanel.Font = New Font("Segoe UI", 10F)
        UiButtonResetParametersPanel.ForeColor = Color.IndianRed
        UiButtonResetParametersPanel.ForeDisableColor = Color.IndianRed
        UiButtonResetParametersPanel.ForeHoverColor = Color.IndianRed
        UiButtonResetParametersPanel.ForePressColor = Color.IndianRed
        UiButtonResetParametersPanel.ForeSelectedColor = Color.IndianRed
        UiButtonResetParametersPanel.Location = New Point(421, 10)
        UiButtonResetParametersPanel.MinimumSize = New Size(1, 1)
        UiButtonResetParametersPanel.Name = "UiButtonResetParametersPanel"
        UiButtonResetParametersPanel.Radius = 0
        UiButtonResetParametersPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonResetParametersPanel.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonResetParametersPanel.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonResetParametersPanel.RectHoverColor = Color.IndianRed
        UiButtonResetParametersPanel.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonResetParametersPanel.RectSelectedColor = Color.IndianRed
        UiButtonResetParametersPanel.Size = New Size(120, 35)
        UiButtonResetParametersPanel.TabIndex = 104
        UiButtonResetParametersPanel.Text = "Reset Panel Settings"
        UiButtonResetParametersPanel.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label125
        ' 
        Label125.Dock = DockStyle.Left
        Label125.Location = New Point(411, 10)
        Label125.Name = "Label125"
        Label125.Size = New Size(10, 35)
        Label125.TabIndex = 103
        ' 
        ' UiButtonImportPreset
        ' 
        UiButtonImportPreset.Dock = DockStyle.Left
        UiButtonImportPreset.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonImportPreset.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonImportPreset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonImportPreset.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonImportPreset.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonImportPreset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonImportPreset.Font = New Font("Segoe UI", 10F)
        UiButtonImportPreset.ForeColor = Color.Goldenrod
        UiButtonImportPreset.ForeDisableColor = Color.Goldenrod
        UiButtonImportPreset.ForeHoverColor = Color.Goldenrod
        UiButtonImportPreset.ForePressColor = Color.Goldenrod
        UiButtonImportPreset.ForeSelectedColor = Color.Goldenrod
        UiButtonImportPreset.Location = New Point(341, 10)
        UiButtonImportPreset.MinimumSize = New Size(1, 1)
        UiButtonImportPreset.Name = "UiButtonImportPreset"
        UiButtonImportPreset.Radius = 0
        UiButtonImportPreset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonImportPreset.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonImportPreset.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonImportPreset.RectHoverColor = Color.Goldenrod
        UiButtonImportPreset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonImportPreset.RectSelectedColor = Color.Goldenrod
        UiButtonImportPreset.Size = New Size(70, 35)
        UiButtonImportPreset.TabIndex = 102
        UiButtonImportPreset.Text = "Import"
        UiButtonImportPreset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label149
        ' 
        Label149.Dock = DockStyle.Left
        Label149.Location = New Point(331, 10)
        Label149.Name = "Label149"
        Label149.Size = New Size(10, 35)
        Label149.TabIndex = 114
        ' 
        ' UiButtonExportPreset
        ' 
        UiButtonExportPreset.Dock = DockStyle.Left
        UiButtonExportPreset.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonExportPreset.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonExportPreset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonExportPreset.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonExportPreset.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonExportPreset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonExportPreset.Font = New Font("Segoe UI", 10F)
        UiButtonExportPreset.ForeColor = Color.YellowGreen
        UiButtonExportPreset.ForeDisableColor = Color.YellowGreen
        UiButtonExportPreset.ForeHoverColor = Color.YellowGreen
        UiButtonExportPreset.ForePressColor = Color.YellowGreen
        UiButtonExportPreset.ForeSelectedColor = Color.YellowGreen
        UiButtonExportPreset.Location = New Point(261, 10)
        UiButtonExportPreset.MinimumSize = New Size(1, 1)
        UiButtonExportPreset.Name = "UiButtonExportPreset"
        UiButtonExportPreset.Radius = 0
        UiButtonExportPreset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonExportPreset.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonExportPreset.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonExportPreset.RectHoverColor = Color.YellowGreen
        UiButtonExportPreset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonExportPreset.RectSelectedColor = Color.YellowGreen
        UiButtonExportPreset.Size = New Size(70, 35)
        UiButtonExportPreset.TabIndex = 100
        UiButtonExportPreset.Text = "Export"
        UiButtonExportPreset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label95
        ' 
        Label95.Dock = DockStyle.Left
        Label95.Location = New Point(251, 10)
        Label95.Name = "Label95"
        Label95.Size = New Size(10, 35)
        Label95.TabIndex = 109
        ' 
        ' UiButtonReadPreset
        ' 
        UiButtonReadPreset.Dock = DockStyle.Left
        UiButtonReadPreset.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonReadPreset.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonReadPreset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonReadPreset.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonReadPreset.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonReadPreset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonReadPreset.Font = New Font("Segoe UI", 10F)
        UiButtonReadPreset.ForeColor = Color.Goldenrod
        UiButtonReadPreset.ForeDisableColor = Color.Goldenrod
        UiButtonReadPreset.ForeHoverColor = Color.Goldenrod
        UiButtonReadPreset.ForePressColor = Color.Goldenrod
        UiButtonReadPreset.ForeSelectedColor = Color.Goldenrod
        UiButtonReadPreset.Location = New Point(181, 10)
        UiButtonReadPreset.MinimumSize = New Size(1, 1)
        UiButtonReadPreset.Name = "UiButtonReadPreset"
        UiButtonReadPreset.Radius = 0
        UiButtonReadPreset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonReadPreset.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonReadPreset.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonReadPreset.RectHoverColor = Color.Goldenrod
        UiButtonReadPreset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonReadPreset.RectSelectedColor = Color.Goldenrod
        UiButtonReadPreset.Size = New Size(70, 35)
        UiButtonReadPreset.TabIndex = 108
        UiButtonReadPreset.Text = "Read"
        UiButtonReadPreset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label129
        ' 
        Label129.Dock = DockStyle.Left
        Label129.Location = New Point(171, 10)
        Label129.Name = "Label129"
        Label129.Size = New Size(10, 35)
        Label129.TabIndex = 112
        ' 
        ' UiButtonSavePreset
        ' 
        UiButtonSavePreset.Dock = DockStyle.Left
        UiButtonSavePreset.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSavePreset.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSavePreset.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonSavePreset.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSavePreset.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSavePreset.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonSavePreset.Font = New Font("Segoe UI", 10F)
        UiButtonSavePreset.ForeColor = Color.YellowGreen
        UiButtonSavePreset.ForeDisableColor = Color.YellowGreen
        UiButtonSavePreset.ForeHoverColor = Color.YellowGreen
        UiButtonSavePreset.ForePressColor = Color.YellowGreen
        UiButtonSavePreset.ForeSelectedColor = Color.YellowGreen
        UiButtonSavePreset.Location = New Point(101, 10)
        UiButtonSavePreset.MinimumSize = New Size(1, 1)
        UiButtonSavePreset.Name = "UiButtonSavePreset"
        UiButtonSavePreset.Radius = 0
        UiButtonSavePreset.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonSavePreset.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonSavePreset.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonSavePreset.RectHoverColor = Color.YellowGreen
        UiButtonSavePreset.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonSavePreset.RectSelectedColor = Color.YellowGreen
        UiButtonSavePreset.Size = New Size(70, 35)
        UiButtonSavePreset.TabIndex = 107
        UiButtonSavePreset.Text = "Save"
        UiButtonSavePreset.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label159
        ' 
        Label159.Dock = DockStyle.Left
        Label159.Location = New Point(91, 10)
        Label159.Name = "Label159"
        Label159.Size = New Size(10, 35)
        Label159.TabIndex = 116
        ' 
        ' UiButtonRefreshPresetList
        ' 
        UiButtonRefreshPresetList.Dock = DockStyle.Left
        UiButtonRefreshPresetList.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRefreshPresetList.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRefreshPresetList.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButtonRefreshPresetList.FillHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRefreshPresetList.FillPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRefreshPresetList.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButtonRefreshPresetList.Font = New Font("Segoe UI", 10F)
        UiButtonRefreshPresetList.ForeColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.ForeDisableColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.ForeHoverColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.ForePressColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.ForeSelectedColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.Location = New Point(21, 10)
        UiButtonRefreshPresetList.MinimumSize = New Size(1, 1)
        UiButtonRefreshPresetList.Name = "UiButtonRefreshPresetList"
        UiButtonRefreshPresetList.Radius = 0
        UiButtonRefreshPresetList.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButtonRefreshPresetList.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButtonRefreshPresetList.RectDisableColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        UiButtonRefreshPresetList.RectHoverColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.RectPressColor = Color.FromArgb(CByte(64), CByte(148), CByte(64))
        UiButtonRefreshPresetList.RectSelectedColor = Color.CornflowerBlue
        UiButtonRefreshPresetList.Size = New Size(70, 35)
        UiButtonRefreshPresetList.TabIndex = 115
        UiButtonRefreshPresetList.Text = "Refresh"
        UiButtonRefreshPresetList.TipsFont = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' Label123
        ' 
        Label123.AutoSize = True
        Label123.Dock = DockStyle.Top
        Label123.Font = New Font("Segoe UI", 10F)
        Label123.ForeColor = Color.Gray
        Label123.Location = New Point(0, 0)
        Label123.Name = "Label123"
        Label123.Padding = New Padding(16, 6, 0, 0)
        Label123.Size = New Size(690, 66)
        Label123.TabIndex = 30
        Label123.Text = "Cross-version compatibility NOT guaranteed. Settings from different versions may not restore correctly." & vbCrLf & "Select item to Operate; Double-Click to Quick Read; Select again to Rename." & vbCrLf & "Saving while selected OVERWRITES the file; Deselect to Create New. Delete files manually in 'Preset' folder."
        ' 
        ' GeneralParametersPage
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(UiTabControlMenu1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Silver
        Name = "GeneralParametersPage"
        Size = New Size(1100, 650)
        UiTabControlMenu1.ResumeLayout(False)
        TabPageParametersOverview.ResumeLayout(False)
        Panel74.ResumeLayout(False)
        Panel81.ResumeLayout(False)
        Panel70.ResumeLayout(False)
        Panel72.ResumeLayout(False)
        Panel73.ResumeLayout(False)
        TabPageOutputFileSettings.ResumeLayout(False)
        TabPageOutputFileSettings.PerformLayout()
        Panel71.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel80.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel79.ResumeLayout(False)
        TabPageDecodingSettings.ResumeLayout(False)
        TabPageDecodingSettings.PerformLayout()
        Panel78.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        TabPageVideoParametersEncoder.ResumeLayout(False)
        TabPageVideoParametersEncoder.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel18.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel16.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        TabPageVideoParametersFrame.ResumeLayout(False)
        TabPageVideoParametersFrame.PerformLayout()
        Panel96.ResumeLayout(False)
        Panel23.ResumeLayout(False)
        Panel22.ResumeLayout(False)
        Panel21.ResumeLayout(False)
        Panel20.ResumeLayout(False)
        TabPageVideoParametersQuality.ResumeLayout(False)
        TabPageVideoParametersQuality.PerformLayout()
        Panel26.ResumeLayout(False)
        Panel25.ResumeLayout(False)
        Panel30.ResumeLayout(False)
        Panel24.ResumeLayout(False)
        TabPageVideoParametersColorManagement.ResumeLayout(False)
        TabPageVideoParametersColorManagement.PerformLayout()
        Panel40.ResumeLayout(False)
        Panel40.PerformLayout()
        Panel33.ResumeLayout(False)
        Panel90.ResumeLayout(False)
        Panel32.ResumeLayout(False)
        Panel31.ResumeLayout(False)
        Panel29.ResumeLayout(False)
        Panel28.ResumeLayout(False)
        Panel41.ResumeLayout(False)
        Panel27.ResumeLayout(False)
        Panel85.ResumeLayout(False)
        Panel85.PerformLayout()
        Panel89.ResumeLayout(False)
        Panel88.ResumeLayout(False)
        Panel87.ResumeLayout(False)
        Panel86.ResumeLayout(False)
        TabPageVideoParametersCommonFilters.ResumeLayout(False)
        TabPageVideoParametersCommonFilters.PerformLayout()
        Panel39.ResumeLayout(False)
        Panel38.ResumeLayout(False)
        Panel37.ResumeLayout(False)
        Panel36.ResumeLayout(False)
        Panel35.ResumeLayout(False)
        Panel34.ResumeLayout(False)
        TabPageVideoFrameServer.ResumeLayout(False)
        TabPageVideoFrameServer.PerformLayout()
        Panel94.ResumeLayout(False)
        Panel95.ResumeLayout(False)
        Panel49.ResumeLayout(False)
        Panel48.ResumeLayout(False)
        TabPageAudioParameters.ResumeLayout(False)
        TabPageAudioParameters.PerformLayout()
        Panel93.ResumeLayout(False)
        Panel92.ResumeLayout(False)
        Panel46.ResumeLayout(False)
        Panel45.ResumeLayout(False)
        Panel44.ResumeLayout(False)
        Panel43.ResumeLayout(False)
        Panel42.ResumeLayout(False)
        TabPageImageParameters.ResumeLayout(False)
        TabPageImageParameters.PerformLayout()
        Panel67.ResumeLayout(False)
        TabPageCustomParameters.ResumeLayout(False)
        Panel50.ResumeLayout(False)
        UiTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel51.ResumeLayout(False)
        Panel51.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel52.ResumeLayout(False)
        Panel53.ResumeLayout(False)
        Panel65.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        Panel54.ResumeLayout(False)
        Panel55.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        Panel59.ResumeLayout(False)
        Panel58.ResumeLayout(False)
        Panel57.ResumeLayout(False)
        Panel56.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        Panel60.ResumeLayout(False)
        TabPageClipInterval.ResumeLayout(False)
        TabPageClipInterval.PerformLayout()
        Panel75.ResumeLayout(False)
        Panel76.ResumeLayout(False)
        Panel66.ResumeLayout(False)
        TabPageStreamControl.ResumeLayout(False)
        TabPageStreamControl.PerformLayout()
        Panel64.ResumeLayout(False)
        Panel91.ResumeLayout(False)
        Panel97.ResumeLayout(False)
        Panel47.ResumeLayout(False)
        Panel63.ResumeLayout(False)
        Panel61.ResumeLayout(False)
        Panel62.ResumeLayout(False)
        TabPagePresetManagement.ResumeLayout(False)
        TabPagePresetManagement.PerformLayout()
        Panel77.ResumeLayout(False)
        Panel84.ResumeLayout(False)
        Panel83.ResumeLayout(False)
        Panel82.ResumeLayout(False)
        Panel69.ResumeLayout(False)
        Panel68.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents UiTabControlMenu1 As Sunny.UI.UITabControlMenu
    Friend WithEvents TabPageParametersOverview As TabPage
    Friend WithEvents TabPageOutputFileSettings As TabPage
    Friend WithEvents TabPageDecodingSettings As TabPage
    Friend WithEvents TabPageVideoParametersEncoder As TabPage
    Friend WithEvents TabPageVideoParametersFrame As TabPage
    Friend WithEvents TabPageVideoParametersQuality As TabPage
    Friend WithEvents TabPageVideoParametersColorManagement As TabPage
    Friend WithEvents TabPageVideoParametersCommonFilters As TabPage
    Friend WithEvents TabPageAudioParameters As TabPage
    Friend WithEvents TabPageCustomParameters As TabPage
    Friend WithEvents TabPageStreamControl As TabPage
    Friend WithEvents TabPageImageParameters As TabPage
    Friend WithEvents TabPagePresetManagement As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiSwitchUseAutoNaming As Sunny.UI.UISwitch
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiSwitchDoNotUseOutputFileParameters As Sunny.UI.UISwitch
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UiTextBoxPrefixText As Sunny.UI.UITextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents UiTextBoxReplacementText As Sunny.UI.UITextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UiTextBoxSuffixText As Sunny.UI.UITextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents UiComboBoxAutoNamingOption As Sunny.UI.UIComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents UiComboBoxDecodingDecoder As Sunny.UI.UIComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents UiTextBoxCPUDecodingThreadCount As Sunny.UI.UITextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents UiComboBoxDecodingDataFormat As Sunny.UI.UIComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents UiComboBoxHardwareAccelerationDecodingParamName As Sunny.UI.UIComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents UiComboBoxEncoderCategory As Sunny.UI.UIComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents UiComboBoxSpecificEncoder As Sunny.UI.UIComboBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents UiComboBoxEncoderPreset As Sunny.UI.UIComboBox
    Friend WithEvents UiComboBoxProfileFile As Sunny.UI.UIComboBox
    Friend WithEvents UiComboBoxSceneTune As Sunny.UI.UIComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents UiTextBoxthreads As Sunny.UI.UITextBox
    Friend WithEvents Label171 As Label
    Friend WithEvents UiTextBoxgpu As Sunny.UI.UITextBox
    Friend WithEvents Label167 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents UiComboBoxResolution As Sunny.UI.UIComboBox
    Friend WithEvents UiTextBoxResolutionAutoHeight As Sunny.UI.UITextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents UiTextBoxResolutionAutoWidth As Sunny.UI.UITextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents UiButtonCropWindow As Sunny.UI.UIButton
    Friend WithEvents Label137 As Label
    Friend WithEvents UiTextBoxCropFilterParameters As Sunny.UI.UITextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents UiComboBoxFrameRate As Sunny.UI.UIComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents UiTextBoxFrameMaxChangeRatio As Sunny.UI.UITextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents UiButtonOpenMotionBlurParametersWindow As Sunny.UI.UIButton
    Friend WithEvents Label145 As Label
    Friend WithEvents UiButtonOpenFrameInterpolationParametersWindow As Sunny.UI.UIButton
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents UiComboBoxGlobalQualityControlMethod As Sunny.UI.UIComboBox
    Friend WithEvents UiTextBoxGlobalQualityControlValue As Sunny.UI.UITextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents UiComboBoxGlobalQualityControlParameters As Sunny.UI.UIComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents UiTextBoxBitrateBufferSize As Sunny.UI.UITextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents UiTextBoxMaxBitrate As Sunny.UI.UITextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents UiTextBoxMinBitrate As Sunny.UI.UITextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents UiTextBoxBaseBitrate As Sunny.UI.UITextBox
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents UiButtonAddAdvancedQualityControlPreset As Sunny.UI.UIButton
    Friend WithEvents Label55 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UiButtonAddAdvancedQualityControlEmpty As Sunny.UI.UIButton
    Friend WithEvents UiButtonClearAllAdvancedQualityControl As Sunny.UI.UIButton
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Panel27 As Panel
    Friend WithEvents UiComboBoxPixelFormat As Sunny.UI.UIComboBox
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Panel34 As Panel
    Friend WithEvents UiComboBoxDenoiseMethod As Sunny.UI.UIComboBox
    Friend WithEvents Panel35 As Panel
    Friend WithEvents LabelDenoiseParameters4 As Label
    Friend WithEvents LabelDenoiseParameters3 As Label
    Friend WithEvents LabelDenoiseParameters2 As Label
    Friend WithEvents LabelDenoiseParameters1 As Label
    Friend WithEvents Panel36 As Panel
    Friend WithEvents UiTextBoxDenoiseParameter4 As Sunny.UI.UITextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents UiTextBoxDenoiseParameter3 As Sunny.UI.UITextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents UiTextBoxDenoiseParameter2 As Sunny.UI.UITextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents UiTextBoxDenoiseParameter1 As Sunny.UI.UITextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Label75 As Label
    Friend WithEvents UiTextBoxSharpenStrength As Sunny.UI.UITextBox
    Friend WithEvents Label118 As Label
    Friend WithEvents UiTextBoxSharpenVerticalSize As Sunny.UI.UITextBox
    Friend WithEvents Label117 As Label
    Friend WithEvents UiTextBoxSharpenHorizontalSize As Sunny.UI.UITextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Label77 As Label
    Friend WithEvents UiComboBoxInterlacedProgressiveProcMethod As Sunny.UI.UIComboBox
    Friend WithEvents UiComboBoxMirrorFlip As Sunny.UI.UIComboBox
    Friend WithEvents Label92 As Label
    Friend WithEvents UiComboBoxAngleRotate As Sunny.UI.UIComboBox
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Label85 As Label
    Friend WithEvents UiComboBoxAudioEncoder As Sunny.UI.UIComboBox
    Friend WithEvents Label88 As Label
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Label84 As Label
    Friend WithEvents UiTextBoxAudioQualityValue As Sunny.UI.UITextBox
    Friend WithEvents UiComboBoxAudioBitrate As Sunny.UI.UIComboBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Panel46 As Panel
    Friend WithEvents Label89 As Label
    Friend WithEvents UiComboBoxSampleRate As Sunny.UI.UIComboBox
    Friend WithEvents UiComboBoxAudioQualityParameters As Sunny.UI.UIComboBox
    Friend WithEvents Panel50 As Panel
    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label97 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label98 As Label
    Friend WithEvents Panel51 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label96 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Panel53 As Panel
    Friend WithEvents UiTextBoxCustomAudioFilter As Sunny.UI.UITextBox
    Friend WithEvents Panel54 As Panel
    Friend WithEvents UiTextBoxCustomVideoParameters As Sunny.UI.UITextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Panel55 As Panel
    Friend WithEvents UiTextBoxCustomAudioParameters As Sunny.UI.UITextBox
    Friend WithEvents Panel59 As Panel
    Friend WithEvents UiTextBoxFinalParameters As Sunny.UI.UITextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents Panel58 As Panel
    Friend WithEvents UiTextBoxPostParameters As Sunny.UI.UITextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents Panel57 As Panel
    Friend WithEvents UiTextBoxPreParameters As Sunny.UI.UITextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents Panel56 As Panel
    Friend WithEvents UiTextBoxStartParameters As Sunny.UI.UITextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents Panel60 As Panel
    Friend WithEvents UiTextBoxCustomFullParameters As Sunny.UI.UITextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents Panel52 As Panel
    Friend WithEvents UiTextBoxCustomVideoFilter As Sunny.UI.UITextBox
    Friend WithEvents Panel64 As Panel
    Friend WithEvents UiComboBoxAttachmentOption As Sunny.UI.UIComboBox
    Friend WithEvents Label163 As Label
    Friend WithEvents UiComboBoxChapterOption As Sunny.UI.UIComboBox
    Friend WithEvents Label148 As Label
    Friend WithEvents UiComboBoxMetadataOption As Sunny.UI.UIComboBox
    Friend WithEvents Panel63 As Panel
    Friend WithEvents Panel61 As Panel
    Friend WithEvents Label140 As Label
    Friend WithEvents UiCheckBoxPreserveOtherAudioStreams As Sunny.UI.UICheckBox
    Friend WithEvents Label133 As Label
    Friend WithEvents UiTextBoxApplyAudioParametersToStreams As Sunny.UI.UITextBox
    Friend WithEvents Panel62 As Panel
    Friend WithEvents Label139 As Label
    Friend WithEvents UiCheckBoxPreserveOtherVideoStreams As Sunny.UI.UICheckBox
    Friend WithEvents Label132 As Label
    Friend WithEvents UiTextBoxApplyVideoParametersToStreams As Sunny.UI.UITextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents Panel65 As Panel
    Friend WithEvents UiTextBoxfilter_complex As Sunny.UI.UITextBox
    Friend WithEvents Panel67 As Panel
    Friend WithEvents Label121 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents UiTextBoxImageEncoderQuality As Sunny.UI.UITextBox
    Friend WithEvents Label122 As Label
    Friend WithEvents UiComboBoxImageEncoder As Sunny.UI.UIComboBox
    Friend WithEvents Label123 As Label
    Friend WithEvents Panel68 As Panel
    Friend WithEvents Panel69 As Panel
    Friend WithEvents UiCheckBoxExtraSaveInfo As Sunny.UI.UICheckBox
    Friend WithEvents UiButtonResetParametersPanel As Sunny.UI.UIButton
    Friend WithEvents Label125 As Label
    Friend WithEvents UiButtonImportPreset As Sunny.UI.UIButton
    Friend WithEvents UiButtonExportPreset As Sunny.UI.UIButton
    Friend WithEvents UiTextBoxAutoLoadPresetFilePath As Sunny.UI.UITextBox
    Friend WithEvents UiButtonSelectLoadSpecificPresetFile As Sunny.UI.UIButton
    Friend WithEvents Label175 As Label
    Friend WithEvents UiComboBoxAutoLoadPresetOption As Sunny.UI.UIComboBox
    Friend WithEvents Label134 As Label
    Friend WithEvents Label131 As Label
    Friend WithEvents Panel72 As Panel
    Friend WithEvents Panel73 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents TabPageClipInterval As TabPage
    Friend WithEvents Panel76 As Panel
    Friend WithEvents Label152 As Label
    Friend WithEvents Panel75 As Panel
    Friend WithEvents UiComboBoxClipForwardDecodingDurationSeconds As Sunny.UI.UIComboBox
    Friend WithEvents Panel66 As Panel
    Friend WithEvents UiComboBoxClipMethod As Sunny.UI.UIComboBox
    Friend WithEvents Label146 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label150 As Label
    Friend WithEvents UiTextBoxQuickClipOutPoint As Sunny.UI.UITextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents UiTextBoxQuickClipInPoint As Sunny.UI.UITextBox
    Friend WithEvents Label115 As Label
    Friend WithEvents Label151 As Label
    Friend WithEvents Panel78 As Panel
    Friend WithEvents UiTextBoxHardwareAccelerationDecodingParameters As Sunny.UI.UITextBox
    Friend WithEvents Panel79 As Panel
    Friend WithEvents Label155 As Label
    Friend WithEvents Panel80 As Panel
    Friend WithEvents UiTextBoxOutputContainer As Sunny.UI.UITextBox
    Friend WithEvents UiButtonSelectContainer As Sunny.UI.UIButton
    Friend WithEvents Label141 As Label
    Friend WithEvents UiComboBoxOutputDirectory As Sunny.UI.UIComboBox
    Friend WithEvents Panel74 As Panel
    Friend WithEvents Panel81 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel70 As Panel
    Friend WithEvents UiButtonCopyRealTimeCommand As Sunny.UI.UIButton
    Friend WithEvents Label142 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents UiButtonReadPreset As Sunny.UI.UIButton
    Friend WithEvents UiButtonSavePreset As Sunny.UI.UIButton
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents Panel71 As Panel
    Friend WithEvents UiCheckBoxPreserveAccessTime As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBoxPreserveModificationTime As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBoxPreserveCreationTime As Sunny.UI.UICheckBox
    Friend WithEvents Label128 As Label
    Friend WithEvents Panel77 As Panel
    Friend WithEvents Label149 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents Panel82 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Panel84 As Panel
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label158 As Label
    Friend WithEvents Panel83 As Panel
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label157 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label159 As Label
    Friend WithEvents UiButtonRefreshPresetList As Sunny.UI.UIButton
    Friend WithEvents Panel85 As Panel
    Friend WithEvents Panel89 As Panel
    Friend WithEvents Label156 As Label
    Friend WithEvents Panel88 As Panel
    Friend WithEvents Label130 As Label
    Friend WithEvents Panel87 As Panel
    Friend WithEvents Label78 As Label
    Friend WithEvents Panel86 As Panel
    Friend WithEvents UiTextBoxSimpleColorBrightness As Sunny.UI.UITextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Label81 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents UiComboBoxColorSpaceFilterSelect As Sunny.UI.UIComboBox
    Friend WithEvents Label80 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents UiTextBoxSimpleColorGamma As Sunny.UI.UITextBox
    Friend WithEvents UiTextBoxSimpleColorSaturation As Sunny.UI.UITextBox
    Friend WithEvents UiTextBoxSimpleColorContrast As Sunny.UI.UITextBox
    Friend WithEvents Label160 As Label
    Friend WithEvents Panel90 As Panel
    Friend WithEvents Label59 As Label
    Friend WithEvents UiComboBoxToneMappingAlgorithm As Sunny.UI.UIComboBox
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Label61 As Label
    Friend WithEvents UiComboBoxColorManagementProcessMethod As Sunny.UI.UIComboBox
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Label65 As Label
    Friend WithEvents UiComboBoxColorRange As Sunny.UI.UIComboBox
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents UiComboBoxTransferCharacteristics As Sunny.UI.UIComboBox
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents UiComboBoxColorPrimaries As Sunny.UI.UIComboBox
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Label62 As Label
    Friend WithEvents UiComboBoxMatrixCoefficients As Sunny.UI.UIComboBox
    Friend WithEvents UiButtonOpenSuperResolutionParametersWindow As Sunny.UI.UIButton
    Friend WithEvents Label82 As Label
    Friend WithEvents Label161 As Label
    Friend WithEvents Label162 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label154 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Panel91 As Panel
    Friend WithEvents UiCheckBoxAutoMuxSRT As Sunny.UI.UICheckBox
    Friend WithEvents Label164 As Label
    Friend WithEvents UiCheckBoxAutoMuxSSA As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBoxAutoMuxASS As Sunny.UI.UICheckBox
    Friend WithEvents Label110 As Label
    Friend WithEvents UiCheckBoxAutoMuxSubtitleToMovtext As Sunny.UI.UICheckBox
    Friend WithEvents Label147 As Label
    Friend WithEvents Label165 As Label
    Friend WithEvents UiComboBoxWhichEmbeddedSubtitlesOperation As Sunny.UI.UIComboBox
    Friend WithEvents Label168 As Label
    Friend WithEvents UiTextBoxWhichEmbeddedSubtitles As Sunny.UI.UITextBox
    Friend WithEvents Label166 As Label
    Friend WithEvents Label169 As Label
    Friend WithEvents Label170 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Panel93 As Panel
    Friend WithEvents UiTextBoxLoudnessNormalizationDynamicRange As Sunny.UI.UITextBox
    Friend WithEvents Label173 As Label
    Friend WithEvents UiTextBoxLoudnessNormalizationTargetLoudness As Sunny.UI.UITextBox
    Friend WithEvents Panel92 As Panel
    Friend WithEvents Label174 As Label
    Friend WithEvents Label176 As Label
    Friend WithEvents Label177 As Label
    Friend WithEvents Label179 As Label
    Friend WithEvents UiTextBoxLoudnessNormalizationPeakValueLevel As Sunny.UI.UITextBox
    Friend WithEvents Label178 As Label
    Friend WithEvents Panel45 As Panel
    Friend WithEvents UiComboBoxChannelLayout As Sunny.UI.UIComboBox
    Friend WithEvents Label86 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label135 As Label
    Friend WithEvents Label181 As Label
    Friend WithEvents Panel47 As Panel
    Friend WithEvents UiCheckBoxPreserveOtherSubtitleStreams As Sunny.UI.UICheckBox
    Friend WithEvents Label184 As Label
    Friend WithEvents TabPageVideoFrameServer As TabPage
    Friend WithEvents Label183 As Label
    Friend WithEvents Label182 As Label
    Friend WithEvents Label185 As Label
    Friend WithEvents Label186 As Label
    Friend WithEvents Panel48 As Panel
    Friend WithEvents UiCheckBoxUseAviSynth As Sunny.UI.UICheckBox
    Friend WithEvents Panel49 As Panel
    Friend WithEvents UiComboBoxSelectAvsFile As Sunny.UI.UIComboBox
    Friend WithEvents Label187 As Label
    Friend WithEvents Panel94 As Panel
    Friend WithEvents UiComboBoxSelectVpyFile As Sunny.UI.UIComboBox
    Friend WithEvents Panel95 As Panel
    Friend WithEvents UiCheckBoxUseVapourSynth As Sunny.UI.UICheckBox
    Friend WithEvents Label188 As Label
    Friend WithEvents Label189 As Label
    Friend WithEvents Panel96 As Panel
    Friend WithEvents UiButtonBurnSubtitles As Sunny.UI.UIButton
    Friend WithEvents Label68 As Label
    Friend WithEvents Label143 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel97 As Panel
    Friend WithEvents UiButtonVisualStreamSelector As Sunny.UI.UIButton
    Friend WithEvents Label107 As Label

End Class

















