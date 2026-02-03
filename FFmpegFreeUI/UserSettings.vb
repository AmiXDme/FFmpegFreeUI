Imports System.IO
Imports System.Text.Json
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class UserSettings
    Public Shared Property Instance As New UserSettingsStructure

    <Serializable>
    Public Class UserSettingsStructure
        Public Property Font As String = "Segoe UI"
        Public Property Language As String = "en"
        Public Property InterfaceFix_AddLeftSpaceToTab As Integer = 0
        Public Property InterfaceFix_UseTextRenderSizeToAdjustLabelSize As Integer = 0
        Public Property InterfaceFix_CalibrateListViewItemHeight As Integer = 0
        Public Property InterfaceFix_EncodingQueueColumnWidthLogic As Integer = 0
        Public Property SpecifyProcessorCores As String = ""
        Public Property AutoRunTasksCount As Integer = 0
        Public Property EncodingQueueRefreshRate As Integer = 2
        Public Property KeepSystemAwakeWhenTaskRunning As Integer = 0
        Public Property SoundAlertOption As Integer = 0
        Public Property AutoStartTaskOption As Integer = 0
        Public Property AutoResetParameterPanelPageSelection As Integer = 0
        Public Property ObfuscateTaskName As Integer = 0
        Public Property SwitchToPresetManagerWhenOpeningIndependentPanel As Integer = 0
        Public Property AutoDeleteOutputFileOnFailure As Integer = 0
        Public Property WorkingDirectory As String = ""
        Public Property AlternativeProcessFileName As String = ""
        Public Property OverrideParameterPassing As String = ""
        Public Property TranslationMode As Boolean = False
        Public Property AutoLoadPresetOption As AutoLoadPresetOptionEnum = AutoLoadPresetOptionEnum.NoAutoLoad
        Public Property AutoLoadPresetFilePath As String = ""
        Public Property LastPresetData As New PresetDataType
        Public Property ParticipateInUserStatistics As Boolean = True
        Public Property ListenPort As Boolean = False
        Public Property ListeningPort As String = ""

        Public Property LastActiveReportDate As Date
        Public Property CustomVideoEncoderList As New List(Of String)

        Public Property Personalization_AppIcon As String = ""
        Public Property Personalization_TaskCompleteSound As String = ""
        Public Property Personalization_TaskFailedSound As String = ""
        Public Property Personalization_StartPageTitle As String = ""
        Public Property Personalization_StartPageSubtitle As String = ""
        Public Property Personalization_WindowTitleBar As String = ""
        Public Property Personalization_StartPageBackgroundImage As String = ""
    End Class

    Enum AutoLoadPresetOptionEnum
        NoAutoLoad = 0
        AutoLoadLastPresetFile = 1
        AutoLoadSpecifiedPresetFile = 2
        AutoLoadLastAllChanges = 3
    End Enum

    Public Shared Sub SaveSettingsOnExit()
        Try
            Select Case Instance.AutoLoadPresetOption
                Case AutoLoadPresetOptionEnum.AutoLoadLastAllChanges
                    Instance.LastPresetData = New PresetDataType
                    PresetManager.SavePreset(Instance.LastPresetData, Form1.GeneralParametersPage)
                Case Else
                    Instance.LastPresetData = Nothing
            End Select

            Dim a = Path.Combine(Application.StartupPath, "Settings.json")
            WriteAllText(a, JsonSerializer.Serialize(Instance, JsonSO), False)
        Catch ex As Exception
            MsgBox($"Failed to save settings: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Shared Sub LoadSettingsOnStartup()
        Try
            Dim a = Path.Combine(Application.StartupPath, "Settings.json")
            If Not FileExists(a) Then
                If FontFamily.Families.Any(Function(f) f.Name = "Segoe UI") Then
                    Instance.Font = "Segoe UI"
                End If
                SaveSettingsOnExit()
            Else
                Instance = JsonSerializer.Deserialize(Of UserSettingsStructure)(ReadAllText(a))
            End If

            Form1.SettingsPage.UiComboBoxLanguageSelect.SelectedIndex = 1
            Instance.Language = "en"
            Module3_MultiLanguage.LoadMultiLanguage()
            Form1.SettingsPage.UiComboBoxFontName.Text = Instance.Font
            If Form1.SettingsPage.UiComboBoxFontName.Items.Contains("Segoe UI") Then Form1.SettingsPage.UiComboBoxFontName.Font = New Font("Segoe UI", Form1.SettingsPage.UiComboBoxFontName.Font.Size)
            SetControlFont(UserSettings.Instance.Font, Form1, {Form1.SettingsPage.UiComboBoxFontName}, True)
            EncodingQueueContextMenu.ResetFont()
            EncodingQueueManagementOptions.ResetFont()

            If UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab > 0 Then
                For Each page As TabPage In Form1.UiTabControlMenu1.TabPages
                    page.Text = Space(UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab) & page.Text
                Next
                For Each page As TabPage In Form1.GeneralParametersPage.UiTabControlMenu1.TabPages
                    page.Text = Space(UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab) & page.Text
                Next
                For Each page As TabPage In Form1.SettingsPage.UiTabControlMenu1.TabPages
                    page.Text = Space(UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab) & page.Text
                Next
            End If
            Form1.SettingsPage.UiComboBoxFix_AddLeftSpaceToTab.Text = Instance.InterfaceFix_AddLeftSpaceToTab
            Form1.SettingsPage.UiComboBoxFix_AdjustLabelSize.Text = Instance.InterfaceFix_UseTextRenderSizeToAdjustLabelSize
            Form1.SettingsPage.UiComboBoxFix_ListViewItemHeight.Text = Instance.InterfaceFix_CalibrateListViewItemHeight
            Form1.SettingsPage.UiComboBoxFix_EncodingQueueColumnWidthLogic.SelectedIndex = Instance.InterfaceFix_EncodingQueueColumnWidthLogic

            Form1.SettingsPage.UiTextBoxProcessorCores.Text = Instance.SpecifyProcessorCores
            Form1.SettingsPage.UiComboBoxAutoStartMaxTasks.SelectedIndex = Instance.AutoRunTasksCount
            Form1.SettingsPage.UiComboBoxEncodingQueueRefreshRate.SelectedIndex = Instance.EncodingQueueRefreshRate

            Form1.SettingsPage.UiComboBoxSystemStatusWithTasks.SelectedIndex = Instance.KeepSystemAwakeWhenTaskRunning
            Form1.SettingsPage.UiComboBoxTooltipSound.SelectedIndex = Instance.SoundAlertOption
            Form1.SettingsPage.UiComboBoxAutoStartTask.SelectedIndex = Instance.AutoStartTaskOption
            Form1.SettingsPage.UiComboBoxAutoResetParameterPanelPageSelection.SelectedIndex = Instance.AutoResetParameterPanelPageSelection
            Form1.SettingsPage.UiComboBoxObfuscateTaskName.SelectedIndex = Instance.ObfuscateTaskName
            Form1.SettingsPage.UiComboBoxIndependentParametersPanelAutoSwitchPage.SelectedIndex = Instance.SwitchToPresetManagerWhenOpeningIndependentPanel
            Form1.SettingsPage.UiComboBoxAutoDeleteOutputFileOnFailure.SelectedIndex = Instance.AutoDeleteOutputFileOnFailure

            Form1.SettingsPage.UiTextBoxFFmpegCustomWorkingDirectory.Text = Instance.WorkingDirectory
            Form1.SettingsPage.UiTextBoxAlternativeProcessFileName.Text = Instance.AlternativeProcessFileName
            Form1.SettingsPage.UiTextBoxOverrideParameterPassing.Text = Instance.OverrideParameterPassing
            Form1.SettingsPage.UiCheckBoxTranslationMode.Checked = Instance.TranslationMode

            Form1.SettingsPage.UiSwitchParticipateUserStatistics.Active = Instance.ParticipateInUserStatistics

            Form1.SettingsPage.UiSwitchPortListening.Active = Instance.ListenPort
            Form1.SettingsPage.UiTextBoxListeningPort.Text = Instance.ListeningPort

            Form1.GeneralParametersPage.UiComboBoxAutoLoadPresetOption.SelectedIndex = Instance.AutoLoadPresetOption
            Form1.GeneralParametersPage.UiTextBoxAutoLoadPresetFilePath.Text = Instance.AutoLoadPresetFilePath
            Select Case Form1.SettingsPage.UiComboBoxAutoStartMaxTasks.SelectedIndex
                Case 0 : MaxConcurrentTasksLimit = 1
                Case 1 : MaxConcurrentTasksLimit = 2
                Case 2 : MaxConcurrentTasksLimit = 3
                Case 3 : MaxConcurrentTasksLimit = 4
                Case 4 : MaxConcurrentTasksLimit = 5
                Case 5 : MaxConcurrentTasksLimit = 6
                Case 6 : MaxConcurrentTasksLimit = 7
                Case 7 : MaxConcurrentTasksLimit = 8
                Case 8 : MaxConcurrentTasksLimit = 9
                Case 9 : MaxConcurrentTasksLimit = 10
                Case Else : MaxConcurrentTasksLimit = 1
            End Select

            Form1.ImageList1.ImageSize = New Size(1, 30 * Form1.DPI + Instance.InterfaceFix_CalibrateListViewItemHeight * Form1.DPI)

            Select Case Instance.EncodingQueueRefreshRate
                Case 0 : Form1.TaskProgressUpdateTimer.Interval = 200
                Case 1 : Form1.TaskProgressUpdateTimer.Interval = 500
                Case 2 : Form1.TaskProgressUpdateTimer.Interval = 1000
                Case 3 : Form1.TaskProgressUpdateTimer.Interval = 1500
                Case 4 : Form1.TaskProgressUpdateTimer.Interval = 2000
            End Select

        Catch ex As Exception
        MsgBox($"Failed to load settings: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub


End Class














