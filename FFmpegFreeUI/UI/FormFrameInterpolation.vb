Public Class FormFrameInterpolation
    Private Sub FormFrameInterpolation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormFrameInterpolation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CalibrateUiComboBoxVisual(UiComboBoxFrameInterpolationMode)
        CalibrateUiComboBoxVisual(UiComboBoxMotionEstimationMode)
        CalibrateUiComboBoxVisual(UiComboBoxMotionEstimationAlgorithm)
        CalibrateUiComboBoxVisual(UiComboBoxMotionCompensationMode)
        UiCheckBoxVariableBlockSizeMotionCompensation.CheckBoxSize = 20 * Form1.DPI
    End Sub

    Private Sub FormFrameInterpolation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UiTextBoxTargetFrameRate.Text = "" Or UiComboBoxFrameInterpolationMode.Text = "" Then
            ResetAllOptions()
        End If
        e.Cancel = True
        Me.Hide()
        Form1.Focus()
    End Sub

    Sub ResetAllOptions()
        UiTextBoxTargetFrameRate.Text = ""
        UiComboBoxFrameInterpolationMode.Text = ""
        UiComboBoxMotionEstimationMode.Text = ""
        UiComboBoxMotionEstimationAlgorithm.Text = ""
        UiComboBoxMotionCompensationMode.Text = ""
        UiCheckBoxVariableBlockSizeMotionCompensation.Checked = False
        UiTextBoxBlockSize.Text = ""
        UiTextBoxSearchRange.Text = ""
        UiTextBoxSceneChangeDetectionStrength.Text = ""
    End Sub



End Class






