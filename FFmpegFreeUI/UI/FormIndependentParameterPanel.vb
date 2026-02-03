Public Class FormIndependentParameterPanel

    Public ParametersPanel As GeneralParametersPage
    Public FileList As String()

    Private Sub FormIndependentParameterPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableWin32APIDarkMode(Me.Handle)
        ParametersPanel = New GeneralParametersPage
        Me.Panel3.Controls.Add(ParametersPanel)
        ParametersPanel.Dock = DockStyle.Fill
        ParametersPanel.BringToFront()
        If UserSettings.Instance.SwitchToPresetManagerWhenOpeningIndependentPanel = 1 Then
            ParametersPanel.UiTabControlMenu1.SelectedTab = ParametersPanel.TabPagePresetManagement
        End If
        If UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab > 0 Then
            For Each page As TabPage In ParametersPanel.UiTabControlMenu1.TabPages
                page.Text = Space(UserSettings.Instance.InterfaceFix_AddLeftSpaceToTab) & page.Text
            Next
        End If

    End Sub

    Private Sub FormIndependentParameterPanel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetControlFont(UserSettings.Instance.Font, Me,, True)
        Me.PanelTopVisualCorrectionArea_Level2TabPage.BackColor = ParametersPanel.UiTabControlMenu1.TabBackColor
        Me.PanelTopVisualCorrectionArea_Level2TabPage.Width = ParametersPanel.UiTabControlMenu1.ItemSize.Width

        If UserSettings.Instance.SwitchToPresetManagerWhenOpeningIndependentPanel = 1 Then
            ParametersPanel.UiTabControlMenu1.SelectedTab = ParametersPanel.TabPagePresetManagement
        End If

    End Sub

    Private Sub UiButtonConfirmAndAddTask_Click(sender As Object, e As EventArgs) Handles UiButtonConfirmAndAddTask.Click
        If UIControl_AddFile.AddToEncodingQueue(FileList, ParametersPanel) Then
            Me.Close()
        End If
    End Sub

End Class













