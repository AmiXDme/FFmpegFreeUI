Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class SettingsPage
    Private Sub SettingsPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        UiTabControlMenu1.ItemSize = New Size(200 * Form1.DPI, 40 * Form1.DPI)
        InitializeSPSettings()
        AdjustUI()
    End Sub

    Sub AdjustUI()
        CalibrateUiComboBoxVisual(UiComboBoxFontName)
        CalibrateUiComboBoxVisual(UiComboBoxLanguageSelect)
        CalibrateUiComboBoxVisual(UiComboBoxFix_AddLeftSpaceToTab)
        CalibrateUiComboBoxVisual(UiComboBoxFix_AdjustLabelSize)
        CalibrateUiComboBoxVisual(UiComboBoxFix_ListViewItemHeight)
        CalibrateUiComboBoxVisual(UiComboBoxFix_EncodingQueueColumnWidthLogic)
        CalibrateUiComboBoxVisual(UiComboBoxAutoStartMaxTasks)
        CalibrateUiComboBoxVisual(UiComboBoxEncodingQueueRefreshRate)
        CalibrateUiComboBoxVisual(UiComboBoxSystemStatusWithTasks)
        CalibrateUiComboBoxVisual(UiComboBoxTooltipSound)
        CalibrateUiComboBoxVisual(UiComboBoxAutoStartTask)
        CalibrateUiComboBoxVisual(UiComboBoxAutoResetParameterPanelPageSelection)
        CalibrateUiComboBoxVisual(UiComboBoxObfuscateTaskName)
        CalibrateUiComboBoxVisual(UiComboBoxIndependentParametersPanelAutoSwitchPage)
        CalibrateUiComboBoxVisual(UiComboBoxAutoDeleteOutputFileOnFailure)
        CalibrateUiComboBoxVisual(UiComboBoxAutoStartMaxTasks)
        UiCheckBoxTranslationMode.CheckBoxSize = 20 * Form1.DPI
    End Sub

    Public Sub InitializeSettingsHandling()
        Dim FontList As New List(Of String)
        For Each Font As FontFamily In FontFamily.Families
            FontList.Add(Font.Name)
        Next
        FontList.Sort()
        UiComboBoxFontName.Font = New Font(SystemFonts.DefaultFont.FontFamily.Name, 9.75)
        UiComboBoxFontName.Items.AddRange(FontList.ToArray)
        AddHandler UiButton4.Click, Sub()
                                        If UiComboBoxFontName.Text = "" Then Exit Sub
                                        SetControlFont(UiComboBoxFontName.Text, Form1, {UiComboBoxFontName})
                                        UserSettings.Instance.Font = UiComboBoxFontName.Text
                                        EncodingQueueContextMenu.ResetFont()
                                        EncodingQueueManagementOptions.ResetFont()
                                    End Sub
        AddHandler UiComboBoxFontName.TextChanged, Sub()
                                                   If UiComboBoxFontName.Text = "" Then Exit Sub
                                                   If Not UiComboBoxFontName.Items.Contains(UiComboBoxFontName.Text) Then Exit Sub
                                                   LabelFontPreviewText.Font = New Font(UiComboBoxFontName.Text, LabelFontPreviewText.Font.Size)
                                               End Sub
        AddHandler UiComboBoxLanguageSelect.SelectedIndexChanged, Sub()
                                                            Select Case UiComboBoxLanguageSelect.SelectedIndex
                                                                Case 0
                                                                    UserSettings.Instance.Language = "zh"
                                                                Case 1
                                                                    UserSettings.Instance.Language = "en"
                                                            End Select
                                                        End Sub
        AddHandler UiComboBoxFix_AddLeftSpaceToTab.SelectedIndexChanged, Sub()
                                                                      UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab = UiComboBoxFix_AddLeftSpaceToTab.Text
                                                                  End Sub
        AddHandler UiComboBoxFix_AdjustLabelSize.SelectedIndexChanged, Sub()
                                                                 UserSettings.Instance.InterfaceFix_UseTextRenderSizeToAdjustLabelSize = UiComboBoxFix_AdjustLabelSize.Text
                                                             End Sub
        AddHandler UiComboBoxFix_ListViewItemHeight.SelectedIndexChanged, Sub()
                                                                  UserSettings.Instance.InterfaceFix_CalibrateListViewItemHeight = UiComboBoxFix_ListViewItemHeight.Text
                                                                  Form1.ImageList1.ImageSize = New Size(1, 30 * Form1.DPI + UserSettings.Instance.InterfaceFix_CalibrateListViewItemHeight * Form1.DPI)
                                                              End Sub
        AddHandler UiComboBoxFix_EncodingQueueColumnWidthLogic.SelectedIndexChanged, Sub()
                                                                     UserSettings.Instance.InterfaceFix_EncodingQueueColumnWidthLogic = UiComboBoxFix_EncodingQueueColumnWidthLogic.SelectedIndex
                                                                 End Sub

        AddHandler UiTextBoxProcessorCores.TextChanged, Sub() UserSettings.Instance.SpecifyProcessorCores = UiTextBoxProcessorCores.Text
        AddHandler UiTextBoxQuickInputCPUCores.KeyPress, Sub(sender, e)
                                                    Select Case e.KeyChar
                                                        Case "0"c To "9"c, "~"c, ChrW(Keys.Back)
                                                        Case ChrW(Keys.Enter)
                                                            Dim input = UiTextBoxQuickInputCPUCores.Text.Trim
                                                            Dim result As New List(Of Integer)
                                                            Try
                                                                If input.Contains("~"c) Then
                                                                    Dim parts = input.Split("~"c)
                                                                    If parts.Length = 2 Then
                                                                        Dim startNum, endNum As Integer
                                                                        If Integer.TryParse(parts(0), startNum) AndAlso Integer.TryParse(parts(1), endNum) Then
                                                                            If startNum <= endNum Then
                                                                                For i = startNum To endNum
                                                                                    result.Add(i)
                                                                                Next
                                                                                UiTextBoxProcessorCores.Text = String.Join(",", result)
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            Catch ex As Exception
                                                                MsgBox(ex.Message, MsgBoxStyle.Critical)
                                                            End Try
                                                            e.Handled = True
                                                        Case Else
                                                            Exit Sub
                                                    End Select
                                                End Sub
        AddHandler UiComboBoxAutoStartMaxTasks.SelectedIndexChanged, Sub()
                                                                   UserSettings.Instance.AutoRunTasksCount = UiComboBoxAutoStartMaxTasks.SelectedIndex
                                                                   Select Case UiComboBoxAutoStartMaxTasks.SelectedIndex
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
                                                               End Sub
        AddHandler UiComboBoxEncodingQueueRefreshRate.SelectedIndexChanged, Sub()
                                                                UserSettings.Instance.EncodingQueueRefreshRate = UiComboBoxEncodingQueueRefreshRate.SelectedIndex
                                                                Select Case UserSettings.Instance.EncodingQueueRefreshRate
                                                                    Case 0 : Form1.TaskProgressUpdateTimer.Interval = 200
                                                                    Case 1 : Form1.TaskProgressUpdateTimer.Interval = 500
                                                                    Case 2 : Form1.TaskProgressUpdateTimer.Interval = 1000
                                                                    Case 3 : Form1.TaskProgressUpdateTimer.Interval = 1500
                                                                    Case 4 : Form1.TaskProgressUpdateTimer.Interval = 2000
                                                                End Select
                                                            End Sub
        AddHandler LinkLabel1.LinkClicked, Sub() Form1.TaskProgressUpdateTimer.Enabled = True

        AddHandler UiComboBoxSystemStatusWithTasks.SelectedIndexChanged, Sub()
                                                                 If UiComboBoxSystemStatusWithTasks.Text = "" Then Exit Sub
                                                                 If UiComboBoxSystemStatusWithTasks.SelectedIndex < 0 Then Exit Sub
                                                                 UserSettings.Instance.KeepSystemAwakeWhenTaskRunning = UiComboBoxSystemStatusWithTasks.SelectedIndex
                                                             End Sub
        AddHandler UiComboBoxTooltipSound.SelectedIndexChanged, Sub() UserSettings.Instance.SoundAlertOption = UiComboBoxTooltipSound.SelectedIndex
        AddHandler UiComboBoxAutoStartTask.SelectedIndexChanged, Sub() UserSettings.Instance.AutoStartTaskOption = UiComboBoxAutoStartTask.SelectedIndex
        AddHandler UiComboBoxAutoResetParameterPanelPageSelection.SelectedIndexChanged, Sub() UserSettings.Instance.AutoResetParameterPanelPageSelection = UiComboBoxAutoResetParameterPanelPageSelection.SelectedIndex
        AddHandler UiComboBoxObfuscateTaskName.SelectedIndexChanged, Sub() UserSettings.Instance.ObfuscateTaskName = UiComboBoxObfuscateTaskName.SelectedIndex
        AddHandler UiComboBoxIndependentParametersPanelAutoSwitchPage.SelectedIndexChanged, Sub() UserSettings.Instance.SwitchToPresetManagerWhenOpeningIndependentPanel = UiComboBoxIndependentParametersPanelAutoSwitchPage.SelectedIndex
        AddHandler UiComboBoxAutoDeleteOutputFileOnFailure.SelectedIndexChanged, Sub() UserSettings.Instance.AutoDeleteOutputFileOnFailure = UiComboBoxAutoDeleteOutputFileOnFailure.SelectedIndex

        AddHandler UiTextBoxFFmpegCustomWorkingDirectory.TextChanged, Sub() UserSettings.Instance.WorkingDirectory = UiTextBoxFFmpegCustomWorkingDirectory.Text
        AddHandler UiButton13.Click, Sub()
                                         Dim dialog As New CommonOpenFileDialog With {.IsFolderPicker = True}
                                         If dialog.ShowDialog() = CommonFileDialogResult.Ok Then UiTextBoxFFmpegCustomWorkingDirectory.Text = dialog.FileName
                                     End Sub
        AddHandler UiTextBoxAlternativeProcessFileName.TextChanged, Sub() UserSettings.Instance.AlternativeProcessFileName = UiTextBoxAlternativeProcessFileName.Text
        AddHandler UiTextBoxOverrideParameterPassing.TextChanged, Sub() UserSettings.Instance.OverrideParameterPassing = UiTextBoxOverrideParameterPassing.Text
        AddHandler UiCheckBoxTranslationMode.Click, Sub() UserSettings.Instance.TranslationMode = UiCheckBoxTranslationMode.Checked = True

        AddHandler UiSwitchPortListening.Click, Sub()
                                           Select Case UiSwitchPortListening.Active
                                               Case True : PortListening.StartClient()
                                               Case False : PortListening.StopClient()
                                           End Select
                                       End Sub
        AddHandler UiTextBoxListeningPort.TextChanged, Sub() UserSettings.Instance.ListeningPort = UiTextBoxListeningPort.Text
    End Sub

    Private Sub SettingsPage_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        UiTabControlMenu1.ItemSize = New Size(200 * Form1.DPI, 40 * Form1.DPI)
        AdjustUI()
    End Sub

    Public Sub InitializeSPSettings()
        AddHandler UiButtonGoToAfdian.Click, Sub() Process.Start(New ProcessStartInfo With {.FileName = "https://afdian.com/item/a98d04e8b98011f0a49952540025c377", .UseShellExecute = True})
        AddHandler UiButtonSettingsAppIcon.Click, Sub()
                                             Dim a As New OpenFileDialog With {.Filter = "Image|*.png;*.jpg;*.jpeg;*.bmp", .Multiselect = False}
                                             If a.ShowDialog() = DialogResult.OK Then
                                                 Label9.Text = a.FileName
                                                 UserSettings.Instance.Personalization_AppIcon = a.FileName
                                             End If
                                         End Sub
        AddHandler UiButtonSettingsTaskCompleteSound.Click, Sub()
                                               Dim a As New OpenFileDialog With {.Filter = "WAV|*.wav", .Multiselect = False}
                                               If a.ShowDialog() = DialogResult.OK Then
                                                   Label11.Text = a.FileName
                                                   UserSettings.Instance.Personalization_TaskCompleteSound = a.FileName
                                               End If
                                           End Sub
        AddHandler UiButtonSettingsTaskFailedSound.Click, Sub()
                                               Dim a As New OpenFileDialog With {.Filter = "WAV|*.wav", .Multiselect = False}
                                               If a.ShowDialog() = DialogResult.OK Then
                                                   Label10.Text = a.FileName
                                                   UserSettings.Instance.Personalization_TaskFailedSound = a.FileName
                                               End If
                                           End Sub
        AddHandler UiButtonStartPageTitle.Click, Sub() UserSettings.Instance.Personalization_StartPageTitle = UiTextBox1.Text
        AddHandler UiButtonStartPageSubtitle.Click, Sub() UserSettings.Instance.Personalization_StartPageSubtitle = UiTextBox2.Text
        AddHandler UiButtonSettingsWindowTitleBar.Click, Sub() UserSettings.Instance.Personalization_WindowTitleBar = UiTextBox3.Text
        AddHandler UiButtonStartPageBackgroundImage.Click, Sub()
                                             Dim a As New OpenFileDialog With {.Filter = "Image|*.png;*.jpg;*.jpeg;*.bmp", .Multiselect = False}
                                             If a.ShowDialog() = DialogResult.OK Then
                                                 Label14.Text = a.FileName
                                                 UserSettings.Instance.Personalization_StartPageBackgroundImage = a.FileName
                                             End If
                                         End Sub
        AddHandler UiSwitchParticipateUserStatistics.Click, Sub() UserSettings.Instance.ParticipateInUserStatistics = Form1.SettingsPage.UiSwitchParticipateUserStatistics.Active
    End Sub


End Class













