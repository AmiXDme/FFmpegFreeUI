Imports Sunny.UI

Public Class UIControl
    Public Shared Sub Initialize()
        Form1.Label1.Dock = DockStyle.Top

        BindDragControlMoveWindow(Form1.Panel2)

        Form1.SettingsPage.InitializeSettingsHandling()

        EncodingQueueContextMenu.Initialize()
        EncodingQueueManagementOptions.Initialize()

        SetRichTextBoxLineHeight(Form1.RichTextBox2, 300)

        Form1.TabPageStartPage.Controls.Add(Form1.StartPage)
        Form1.StartPage.AdjustUI()
        Form1.TabPagePrepareFiles.Controls.Add(Form1.PrepareFilesPage)
        Form1.Panel6.Controls.Add(Form1.GeneralParametersPage)
        BindingHintPanel.BindParameterPanelTooltip(Form1.GeneralParametersPage)
        Form1.TabPageMediaInfo.Controls.Add(Form1.MediaInfoPage)
        Form1.TabPagePlayer.Controls.Add(Form1.PlayerPage)
        Form1.TabPageMuxing.Controls.Add(Form1.MuxingPage)
        Form1.TabPageMerging.Controls.Add(Form1.MergingPage)
        Form1.TabPageSettings.Controls.Add(Form1.SettingsPage)
        Form1.TabPagePerformanceMonitoring.Controls.Add(Form1.PerformancePage)
        Form1.TabPageSupporters.Controls.Add(Form1.SupportersPage)

        Form1.Panel41.AutoSize = True

        AddHandler Form1.UiTabControlMenu1.SelectedIndexChanged, AddressOf CalibrateUI

        DarkListViewCustomDraw.BindListViewEvents(Form1.ListView1)

        AddHandler Form1.UiButtonStartTask.Click, AddressOf UIControl_EncodingQueue.StartTask
        AddHandler Form1.UiButtonPauseTask.Click, AddressOf UIControl_EncodingQueue.PauseTask
        AddHandler Form1.UiButtonResumeTask.Click, AddressOf UIControl_EncodingQueue.ResumeTask
        AddHandler Form1.UiButtonStopTask.Click, AddressOf UIControl_EncodingQueue.StopTask
        AddHandler Form1.UiButtonRemoveTask.Click, AddressOf UIControl_EncodingQueue.RemoveTask
        AddHandler Form1.UiButtonResetTask.Click, AddressOf UIControl_EncodingQueue.ResetTask
        AddHandler Form1.UiButtonLocateOutput.Click, AddressOf UIControl_EncodingQueue.LocateOutput
        AddHandler Form1.LinkLabelSendToFFmpeg.LinkClicked, Sub()
                                                               Dim msg As String = InputBox("Send message to FFmpeg process")
                                                               If msg <> "" Then EncodingTask.Queue(Form1.ListView1.SelectedItems(0).Index).SendMessage(msg)
                                                           End Sub
        Form1.UiComboBoxOutputDisplayType.SelectedIndex = 0
        AddHandler Form1.LinkLabelSwitchOutput.LinkClicked, Sub()
                                                            If Form1.PanelOutputPanel.Visible Then
                                                                Form1.PanelOutputPanel.Visible = False
                                                                Form1.IsOutputPanelOpened = False
                                                            Else
                                                                Form1.PanelOutputPanel.Visible = True
                                                                Form1.IsOutputPanelOpened = True
                                                                CalibrateOutputPanelWidth()
                                                            End If
                                                        End Sub
        AddHandler Form1.UiButtonCopyOutput.Click, Sub() Clipboard.SetText(Form1.RichTextBox2.Text)
        AddHandler Form1.UiComboBoxOutputDisplayType.SelectedIndexChanged, AddressOf EncodingTask.RefreshWhenSwitchingOutputType

        AddHandler Form1.SelectedItemRefreshInfoTimer.Tick, AddressOf EncodingTask.RefreshSelectedItemInfo
        AddHandler Form1.TaskProgressUpdateTimer.Tick, AddressOf EncodingTask.RefreshUIWithTimer
        AddHandler Form1.PerformanceStatsRefreshTimer.Tick, AddressOf PerformanceStats.RefreshToUI

        '==============================================

        Form1.IsInitialized = True
    End Sub

    Public Shared Sub CalibrateUI()
        Dim selectedTab As TabPage = Form1.UiTabControlMenu1.SelectedTab
        Form1.PerformanceStatsRefreshTimer.Enabled = False
        Select Case True
            Case selectedTab.IsEqual(Form1.TabPageStartPage)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.StartPage.Panel73.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

            Case selectedTab.IsEqual(Form1.TabPageEncodingQueue)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.Panel2.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

                CalibrateEncodingQueueColumnWidth()
                CalibrateOutputPanelWidth()
                Dim s1 As Integer = 0
                For Each c As UIButton In Form1.Panel2.Controls
                    SetButtonWidthBasedOnText(c)
                    s1 += c.Width
                Next
                SetButtonWidthBasedOnText(Form1.UiButtonTaskManagementMenu)
                Form1.Panel2.Padding = New Padding((Form1.Panel2.Width - s1) * 0.5, Form1.Panel2.Padding.Top, (Form1.Panel2.Width - s1) * 0.5, 0)
                CalibrateUiComboBoxVisual(Form1.UiComboBoxOutputDisplayType)
                Form1.UiCheckBoxForceScrollToBottom.CheckBoxSize = 20 * Form1.DPI

                Form1.Panel41.Height = Form1.Panel35.Height + Form1.Panel41.Padding.Top + Form1.Panel41.Padding.Bottom

            Case selectedTab.IsEqual(Form1.TabPagePrepareFiles)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.PrepareFilesPage.Panel3.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

                Form1.PrepareFilesPage.CalibrateUI()

            Case selectedTab.IsEqual(Form1.TabPageParameters)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.GeneralParametersPage.UiTabControlMenu1.TabBackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Left
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Width = Form1.GeneralParametersPage.UiTabControlMenu1.ItemSize.Width + 1

                If UserSettings.Instance.AutoResetParameterPanelPageSelection = 1 Then Form1.GeneralParametersPage.UiTabControlMenu1.SelectedTab = Form1.GeneralParametersPage.TabPageParametersOverview

            Case selectedTab.IsEqual(Form1.TabPagePlayer)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.PlayerPage.Panel1.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

            Case selectedTab.IsEqual(Form1.TabPageMediaInfo)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.MediaInfoPage.Panel9.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

                Form1.MediaInfoPage.AdjustUI()

            Case selectedTab.IsEqual(Form1.TabPageMuxing)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.MuxingPage.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill
                Form1.MuxingPage.CalibrateUI()

            Case selectedTab.IsEqual(Form1.TabPageMerging)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.MergingPage.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill
                Form1.MergingPage.CalibrateUI()

            Case selectedTab.IsEqual(Form1.TabPagePerformanceMonitoring)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.PerformancePage.Panel1.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

                Form1.PerformanceStatsRefreshTimer.Enabled = True

            Case selectedTab.IsEqual(Form1.TabPagePlugins)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.Panel22.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

            Case selectedTab.IsEqual(Form1.TabPageSettings)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.SettingsPage.UiTabControlMenu1.TabBackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Left
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Width = Form1.SettingsPage.UiTabControlMenu1.ItemSize.Width + 1

                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxFontName)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxAutoStartMaxTasks)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxSystemStatusWithTasks)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxTooltipSound)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxAutoStartTask)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxAutoResetParameterPanelPageSelection)
                CalibrateUiComboBoxVisual(Form1.SettingsPage.UiComboBoxObfuscateTaskName)
                Form1.SettingsPage.UiCheckBoxTranslationMode.CheckBoxSize = 20 * Form1.DPI

            Case selectedTab.IsEqual(Form1.TabPageSupporters)
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = Form1.SupportersPage.BackColor
                Form1.PanelTopVisualCorrectionArea_Level2TabPage.Dock = DockStyle.Fill

                Form1.SupportersPage.AdjustUI()
                Form1.SupportersPage.AdjustTopButtonsWidth()
        End Select
    End Sub

    Public Shared Sub CalibrateEncodingQueueColumnWidth()
        Select Case UserSettings.Instance.InterfaceFix_EncodingQueueColumnWidthLogic
            Case 0
                Form1.LabelStatus.Width = 80 * Form1.DPI
                Form1.LabelProgress.Width = 70 * Form1.DPI
                Form1.LabelSpeed.Width = 80 * Form1.DPI
                Form1.LabelOutputSize.Width = 150 * Form1.DPI
                Form1.LabelQuality.Width = 55 * Form1.DPI
                Form1.LabelBitrate.Width = 115 * Form1.DPI
                Form1.LabelEstimatedRemaining.Width = 200 * Form1.DPI
            Case 1
                Dim totalWidth As Integer = Form1.Panel1.Width
                Form1.LabelStatus.Width = totalWidth * 0.076
                Form1.LabelProgress.Width = totalWidth * 0.071
                Form1.LabelSpeed.Width = totalWidth * 0.076
                Form1.LabelOutputSize.Width = totalWidth * 0.143
                Form1.LabelQuality.Width = totalWidth * 0.053
                Form1.LabelBitrate.Width = totalWidth * 0.113
                Form1.LabelEstimatedRemaining.Width = totalWidth * 0.186
        End Select
        Form1.ListView1.Columns(0).Width = Form1.Panel15.Width - Form1.ListView1.Parent.Padding.Left - 5 * Form1.DPI
        Form1.ListView1.Columns(1).Width = Form1.LabelStatus.Width
        Form1.ListView1.Columns(2).Width = Form1.LabelProgress.Width
        Form1.ListView1.Columns(3).Width = Form1.LabelSpeed.Width
        Form1.ListView1.Columns(4).Width = Form1.LabelOutputSize.Width
        Form1.ListView1.Columns(5).Width = Form1.LabelQuality.Width
        Form1.ListView1.Columns(6).Width = Form1.LabelBitrate.Width
        Form1.ListView1.Columns(7).Width = Form1.LabelEstimatedRemaining.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI * 2
    End Sub

    Public Shared Sub CalibrateOutputPanelWidth()
        If Form1.PanelOutputPanel.Visible Then
            Form1.PanelOutputPanel.Width = Form1.PanelOutputPanel.Parent.Width * 0.5
        End If
    End Sub

End Class












