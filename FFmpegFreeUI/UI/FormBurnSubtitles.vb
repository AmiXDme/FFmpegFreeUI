Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Sunny.UI
Public Class FormBurnSubtitles
    Private Sub FormBurnSubtitles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler UiCheckBoxSubtitleSourceUseExternalFile.Click, Sub()
                                                  If UiCheckBoxSubtitleSourceUseExternalFile.Checked Then
                                                      UiCheckBoxSubtitleSourceIsEmbeddedStream.Checked = False
                                                      UiTextBoxSpecifiedEmbeddedStream.Text = ""
                                                  Else
                                                      UiTextBoxSubtitleSourceExternalFileName.Text = ""
                                                      UiTextBoxSubtitleSourceSpecifiedFolder.Text = ""
                                                  End If
                                              End Sub
        AddHandler UiCheckBoxSubtitleSourceIsEmbeddedStream.Click, Sub()
                                                  If UiCheckBoxSubtitleSourceIsEmbeddedStream.Checked Then
                                                      UiCheckBoxSubtitleSourceUseExternalFile.Checked = False
                                                      UiTextBoxSubtitleSourceExternalFileName.Text = ""
                                                      UiTextBoxSubtitleSourceSpecifiedFolder.Text = ""
                                                  Else
                                                      UiTextBoxSpecifiedEmbeddedStream.Text = ""
                                                  End If
                                              End Sub
        AddHandler UiButtonSelectExternalSubtitleLocation.Click, Sub()
                                                 Dim dialog As New CommonOpenFileDialog With {.IsFolderPicker = True}
                                                 If dialog.ShowDialog() = CommonFileDialogResult.Ok Then
                                                     UiTextBoxSubtitleSourceSpecifiedFolder.Text = dialog.FileName
                                                 End If
                                             End Sub
        AddHandler UiButtonSelectFontFolder.Click, Sub()
                                              Dim dialog As New CommonOpenFileDialog With {.IsFolderPicker = True}
                                              If dialog.ShowDialog() = CommonFileDialogResult.Ok Then
                                                  UiTextBoxFontFolder.Text = dialog.FileName
                                              End If
                                          End Sub
        AddHandler LabelFontStylePreview.FontChanged, AddressOf UpdateBaseFontStyle
        AddHandler UiButtonClearBasicStyle.Click, Sub()
                                             LabelFontStylePreview.Enabled = False
                                             LabelFontStylePreview.Font = SystemFonts.DefaultFont
                                             UiButtonSelectBasicStyle.Text = "Select Basic Style"
                                         End Sub
        AddHandler UiButtonSelectBasicStyle.Click, Sub()
                                             Dim a As New FontDialog With {.Font = LabelFontStylePreview.Font, .ShowColor = False}
                                             If a.ShowDialog() = DialogResult.OK Then
                                                 LabelFontStylePreview.Enabled = True
                                                 LabelFontStylePreview.Font = a.Font
                                             End If
                                         End Sub
        AddHandler LabelPrimaryColor.BackColorChanged, AddressOf UpdateMainColorDisplay
        AddHandler UiTextBoxSettingsPrimaryColorAlpha.TextChanged, AddressOf UpdateMainColorDisplay
        AddHandler UiButtonClearPrimaryColor.Click, Sub() LabelPrimaryColor.BackColor = Color.Transparent
        AddHandler UiButtonSelectPrimaryColor.Click, Sub()
                                             Dim a As New ColorDialog With {.Color = LabelPrimaryColor.BackColor, .FullOpen = True, .AnyColor = True}
                                             If a.ShowDialog() = DialogResult.OK Then LabelPrimaryColor.BackColor = a.Color
                                         End Sub
        AddHandler LabelSecondaryColor.BackColorChanged, AddressOf UpdateSecondaryColorDisplay
        AddHandler UiTextBoxSettingsSecondaryColorAlpha.TextChanged, AddressOf UpdateSecondaryColorDisplay
        AddHandler UiButtonClearSecondaryColor.Click, Sub() LabelSecondaryColor.BackColor = Color.Transparent
        AddHandler UiButtonSelectSecondaryColor.Click, Sub()
                                             Dim a As New ColorDialog With {.Color = LabelSecondaryColor.BackColor, .FullOpen = True, .AnyColor = True}
                                             If a.ShowDialog() = DialogResult.OK Then LabelSecondaryColor.BackColor = a.Color
                                         End Sub
        AddHandler LabelOutlineColor.BackColorChanged, AddressOf UpdateOutlineColorDisplay
        AddHandler UiTextBoxSettingsOutlineColorAlpha.TextChanged, AddressOf UpdateOutlineColorDisplay
        AddHandler UiButtonClearOutlineColor.Click, Sub() LabelOutlineColor.BackColor = Color.Transparent
        AddHandler UiButtonSelectOutlineColor.Click, Sub()
                                             Dim a As New ColorDialog With {.Color = LabelOutlineColor.BackColor, .FullOpen = True, .AnyColor = True}
                                             If a.ShowDialog() = DialogResult.OK Then LabelOutlineColor.BackColor = a.Color
                                         End Sub
        AddHandler LabelBackgroundColor.BackColorChanged, AddressOf UpdateShadowBackgroundColorDisplay
        AddHandler UiTextBoxSettingsBackgroundColorAlpha.TextChanged, AddressOf UpdateShadowBackgroundColorDisplay
        AddHandler UiButtonClearBackgroundColor.Click, Sub() LabelBackgroundColor.BackColor = Color.Transparent
        AddHandler UiButtonSelectBackgroundColor.Click, Sub()
                                               Dim a As New ColorDialog With {.Color = LabelBackgroundColor.BackColor, .FullOpen = True, .AnyColor = True}
                                               If a.ShowDialog() = DialogResult.OK Then LabelBackgroundColor.BackColor = a.Color
                                           End Sub

        BindComboBoxMouseWheelEvent(UiComboBoxSelectFilter)
        BindComboBoxMouseWheelEvent(UiComboBoxPrioritySelect)
        BindComboBoxMouseWheelEvent(UiComboBoxThenSelect)
        BindComboBoxMouseWheelEvent(UiComboBoxFinallySelect)
        BindComboBoxMouseWheelEvent(UiComboBoxBorderType)
        BindComboBoxMouseWheelEvent(UiComboBoxAlignmentPosition)

        ResetAllOptions()
    End Sub

    Private Sub FormBurnSubtitles_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        UiTabControlMenu1.ItemSize = New Size(175 * Form1.DPI, 40 * Form1.DPI)
        PanelTopVisualCorrectionArea_Level1.Width = UiTabControlMenu1.ItemSize.Width + 1
        CalibrateUiComboBoxVisual(UiComboBoxSelectFilter)
        CalibrateUiComboBoxVisual(UiComboBoxPrioritySelect)
        CalibrateUiComboBoxVisual(UiComboBoxThenSelect)
        CalibrateUiComboBoxVisual(UiComboBoxFinallySelect)
        UiCheckBoxSubtitleSourceUseExternalFile.CheckBoxSize = 20 * Form1.DPI
        UiCheckBoxSubtitleSourceIsEmbeddedStream.CheckBoxSize = 20 * Form1.DPI
        CalibrateUiComboBoxVisual(UiComboBoxBorderType)
        CalibrateUiComboBoxVisual(UiComboBoxAlignmentPosition)

    End Sub
    Private Sub FormBurnSubtitles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UiComboBoxSelectFilter.SelectedIndex = 0 Then
            ResetAllOptions()
        End If
        e.Cancel = True
        Me.Hide()
        Form1.Focus()
    End Sub

    Sub AdjustUI()

    End Sub

    Sub ResetAllOptions()
        UiComboBoxSelectFilter.SelectedIndex = 0
        UiComboBoxPrioritySelect.Text = ""
        UiComboBoxThenSelect.Text = ""
        UiComboBoxFinallySelect.Text = ""
        UiCheckBoxSubtitleSourceUseExternalFile.Checked = False
        UiTextBoxSubtitleSourceExternalFileName.Text = ""
        UiTextBoxSubtitleSourceSpecifiedFolder.Text = ""
        UiCheckBoxSubtitleSourceIsEmbeddedStream.Checked = False
        UiTextBoxSpecifiedEmbeddedStream.Text = ""
        UiTextBoxFontFolder.Text = ""
        LabelFontStylePreview.Enabled = False
        LabelFontStylePreview.Font = SystemFonts.DefaultFont
        UiComboBoxBorderType.Text = ""
        UiTextBoxOutlineWidth.Text = ""
        UiTextBoxShadowDistance.Text = ""
        UiTextBoxSettingsPrimaryColorAlpha.Text = ""
        LabelPrimaryColor.BackColor = Color.Transparent
        LabelPrimaryColorValue.Text = ""
        UiTextBoxSettingsSecondaryColorAlpha.Text = ""
        LabelSecondaryColor.BackColor = Color.Transparent
        LabelSecondaryColorValue.Text = ""
        UiTextBoxSettingsOutlineColorAlpha.Text = ""
        LabelOutlineColor.BackColor = Color.Transparent
        LabelOutlineColorValue.Text = ""
        UiTextBoxSettingsBackgroundColorAlpha.Text = ""
        LabelBackgroundColor.BackColor = Color.Transparent
        LabelBackgroundColorValue.Text = ""
        UiComboBoxAlignmentPosition.Text = ""
        UiTextBoxVerticalMargin.Text = ""
        UiTextBoxLeftMargin.Text = ""
        UiTextBoxRightMargin.Text = ""
        UiTextBoxCharacterSpacing.Text = ""
        UiTextBoxLineSpacing.Text = ""
        UiTextBoxCustomStyle.Text = ""
        UiTextBoxCustomFilterParameters.Text = ""
    End Sub

    Sub UpdateBaseFontStyle()
        If Not LabelFontStylePreview.Enabled Then Exit Sub
        UiButtonSelectBasicStyle.Text = $"{LabelFontStylePreview.Font.Name}, {LabelFontStylePreview.Font.Size}, {LabelFontStylePreview.Font.Style}"
    End Sub
    Sub UpdateMainColorDisplay()
        If LabelPrimaryColor.BackColor = Color.Transparent Then
            LabelPrimaryColor.BorderStyle = BorderStyle.FixedSingle
            LabelPrimaryColorValue.Text = "Not set"
        Else
            LabelPrimaryColor.BorderStyle = BorderStyle.None
            LabelPrimaryColorValue.Text = ConvertHTMLColorToFFmpegFormat(LabelPrimaryColor.BackColor.ToHTML, UiTextBoxSettingsPrimaryColorAlpha.Text)
            LabelPrimaryColorValue.Text.Replace("&", "&&")
        End If
    End Sub
    Sub UpdateSecondaryColorDisplay()
        If LabelSecondaryColor.BackColor = Color.Transparent Then
            LabelSecondaryColor.BorderStyle = BorderStyle.FixedSingle
            LabelSecondaryColorValue.Text = "Not set"
        Else
            LabelSecondaryColor.BorderStyle = BorderStyle.None
            LabelSecondaryColorValue.Text = ConvertHTMLColorToFFmpegFormat(LabelSecondaryColor.BackColor.ToHTML, UiTextBoxSettingsSecondaryColorAlpha.Text)
            LabelSecondaryColorValue.Text.Replace("&", "&&")
        End If
    End Sub
    Sub UpdateOutlineColorDisplay()
        If LabelOutlineColor.BackColor = Color.Transparent Then
            LabelOutlineColor.BorderStyle = BorderStyle.FixedSingle
            LabelOutlineColorValue.Text = "Not set"
        Else
            LabelOutlineColor.BorderStyle = BorderStyle.None
            LabelOutlineColorValue.Text = ConvertHTMLColorToFFmpegFormat(LabelOutlineColor.BackColor.ToHTML, UiTextBoxSettingsOutlineColorAlpha.Text)
            LabelOutlineColorValue.Text.Replace("&", "&&")
        End If
    End Sub
    Sub UpdateShadowBackgroundColorDisplay()
        If LabelBackgroundColor.BackColor = Color.Transparent Then
            LabelBackgroundColor.BorderStyle = BorderStyle.FixedSingle
            LabelBackgroundColorValue.Text = "Not set"
        Else
            LabelBackgroundColor.BorderStyle = BorderStyle.None
            LabelBackgroundColorValue.Text = ConvertHTMLColorToFFmpegFormat(LabelBackgroundColor.BackColor.ToHTML, UiTextBoxSettingsBackgroundColorAlpha.Text)
            LabelBackgroundColorValue.Text.Replace("&", "&&")
        End If
    End Sub

End Class











