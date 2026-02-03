
Public Class FormFrameBlending
    Private Sub FormFrameBlending_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormFrameBlending_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CalibrateUiComboBoxVisual(UiComboBoxBlendAlgorithm)
    End Sub

    Private Sub FormFrameBlending_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UiComboBoxBlendAlgorithm.Text = "" Then
            ResetAllOptions()
        End If
        e.Cancel = True
        Me.Hide()
        Form1.Focus()
    End Sub

    Sub ResetAllOptions()
        UiTextBoxTargetFrameRate.Text = ""
        UiComboBoxBlendAlgorithm.Text = ""
        UiTextBoxBlendRatio.Text = ""
    End Sub



End Class





