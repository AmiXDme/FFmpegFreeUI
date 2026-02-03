Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class UIControl_AddFile

    ' Extracted common validation logic
    Private Shared Function ValidateParameterPanel(parameterPanel As GeneralParametersPage, parentForm As Form) As Boolean
        If parameterPanel.UiTextBoxOutputContainer.Text = "" And Not parameterPanel.UiSwitchDoNotUseOutputFileParameters.Active And parameterPanel.UiTextBoxCustomFullParameters.Text = "" Then
            InAppDialog.ShowDialog(parentForm, "Output container not filled", $"No output container selected or filled!{vbCrLf & vbCrLf}If auto-load preset is set, please check the parameter page.", New Dictionary(Of String, Action) From {{"Understand", Nothing}}, InAppDialog.ThemeType.Error)
            Return False
        End If

        If parameterPanel.UiComboBoxOutputDirectory.SelectedIndex > 0 AndAlso Not FileIO.FileSystem.DirectoryExists(parameterPanel.UiComboBoxOutputDirectory.Text.Trim) Then
            InAppDialog.ShowDialog(parentForm, "Output location error", "Specified output directory does not exist!", New Dictionary(Of String, Action) From {{"Understand", Nothing}}, InAppDialog.ThemeType.Error)
            Return False
        End If

        If Not parameterPanel.IsInitialized Then
            InAppDialog.ShowDialog(parentForm, "Please switch to the parameter panel at least once after startup", "Parameter panel is not initialized; this is a limitation of the tab control's underlying mechanism.", New Dictionary(Of String, Action) From {{"Understand", Nothing}}, InAppDialog.ThemeType.Error)
            Return False
        End If

        Return True
    End Function

    ' Extracted logic to add a single task
    Private Shared Sub AddSingleTask(filePath As String, presetData As PresetDataType, outputDir As String, isTranslationMode As Boolean)
        Dim finalPath = If(isTranslationMode, ProcessPathForTranslationMode(filePath), filePath)
        Dim m As New EncodingTask.SingleTask With {.InputFile = finalPath, .PresetData = presetData}

        If outputDir <> Form1.GeneralParametersPage.UiComboBoxOutputDirectory.Items(0).Trim Then
            m.CustomOutputDirectory = outputDir
        End If

        Dim i2 As New ListViewItem(IO.Path.GetFileName(filePath))
        If UserSettings.Instance.ObfuscateTaskName = 1 Then i2.Text = ConfuseString_Meow(i2.Text)
        i2.SubItems.AddRange("Pending", "", "", "", "", "", "")
        Form1.ListView1.Items.Add(i2)
        m.ListViewItem = i2
        EncodingTask.Queue.Add(m)
    End Sub

    Public Shared Sub AddToEncodingQueue()
        If Not ValidateParameterPanel(Form1.GeneralParametersPage, Form1) Then Exit Sub

        Dim a As New PresetDataType
        PresetManager.SavePreset(a, Form1.GeneralParametersPage)
        Dim outputDir = Form1.GeneralParametersPage.UiComboBoxOutputDirectory.Text.Trim

        For Each item As ListViewItem In Form1.PrepareFilesPage.ListView1.Items
            AddSingleTask(item.Text, a, outputDir, False)
        Next

        Form1.PrepareFilesPage.ListView1.Items.Clear()
        Form1.UiTabControlMenu1.SelectedTab = Form1.TabPageEncodingQueue
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True
    End Sub

    Public Shared Function AddToEncodingQueue(draggedFiles As String(), parameterPanel As GeneralParametersPage) As Boolean
        If Not ValidateParameterPanel(parameterPanel, parameterPanel.ParentForm) Then Return False
        Dim a As New PresetDataType
        PresetManager.SavePreset(a, parameterPanel)
        Dim outputDir = parameterPanel.UiComboBoxOutputDirectory.Text.Trim
        For Each item In draggedFiles
            AddSingleTask(item, a, outputDir, UserSettings.Instance.TranslationMode)
        Next
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True
        Return True
    End Function

    Public Shared Sub ListView2_DragEnter(sender As Object, e As DragEventArgs)
        e.Effect = If(e.Data.GetDataPresent(DataFormats.FileDrop), DragDropEffects.Copy, DragDropEffects.None)
    End Sub

    Public Shared Sub ListView2_DragDrop(sender As Object, e As DragEventArgs)
        If Not e.Data.GetDataPresent(DataFormats.FileDrop) Then Exit Sub

        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        For Each b As String In files
            Dim path = If(UserSettings.Instance.TranslationMode, ProcessPathForTranslationMode(b), b)
            Form1.PrepareFilesPage.ListView1.Items.Add(New ListViewItem({path, Format(FileLen(path) / 1024 / 1024, "0") & " MB"}))
        Next
    End Sub

    Public Shared Sub AddFiles()
        Dim openFileDialog As New OpenFileDialog With {.Multiselect = True, .Filter = "All Files|*.*"}
        If openFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

        For Each filePath As String In openFileDialog.FileNames
            Dim path = If(UserSettings.Instance.TranslationMode, ProcessPathForTranslationMode(filePath), filePath)
            Form1.PrepareFilesPage.ListView1.Items.Add(New ListViewItem({path, Format(FileLen(path) / 1024 / 1024, "0") & " MB"}))
        Next
    End Sub

    Public Shared Sub AddAllFilesFromFolder()
        Dim dialog As New CommonOpenFileDialog With {.IsFolderPicker = True}
        If dialog.ShowDialog() <> CommonFileDialogResult.Ok Then Exit Sub

        For Each file As String In GetAllFilesFromFolder(dialog.FileName)
            Dim path = If(UserSettings.Instance.TranslationMode, ProcessPathForTranslationMode(file), file)
            Form1.PrepareFilesPage.ListView1.Items.Add(New ListViewItem({path, Format(FileLen(path) / 1024 / 1024, "0") & " MB"}))
        Next
    End Sub

    Shared Function GetAllFilesFromFolder(folderPath As String) As List(Of String)
        Dim fileList As New List(Of String)
        Try
            For Each file As IO.FileInfo In New IO.DirectoryInfo(folderPath).GetFiles("*", IO.SearchOption.AllDirectories)
                If (file.Attributes And (IO.FileAttributes.Hidden Or IO.FileAttributes.System)) = 0 Then
                    fileList.Add(file.FullName)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return fileList
    End Function

    Public Shared Sub BatchRemoveSelectedItems()
        For Each a As ListViewItem In Form1.PrepareFilesPage.ListView1.SelectedItems
            Form1.PrepareFilesPage.ListView1.Items.Remove(a)
        Next
    End Sub

    Public Shared Sub RemoveAllItems()
        Form1.PrepareFilesPage.ListView1.Items.Clear()
    End Sub

End Class









