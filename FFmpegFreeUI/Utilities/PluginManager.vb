Imports System.IO
Imports System.Reflection
Imports System.Text.Json
Imports Sunny.UI
Public Class PluginManager

    Public Shared Property IsPersonalizationUnlocked As Boolean = False

    Public Shared Sub ReadPersonalizationUnlockerOnStartup()
        Dim a As String = Path.Combine(Application.StartupPath, "FFmpegFreeUISupporter.dll")
        If Not FileIO.FileSystem.FileExists(a) Then
            Form1.LoadCustomIcon(Nothing)
            Form1.SettingsPage.Panel1.Visible = True
            Form1.SettingsPage.Panel3.Visible = False
            Exit Sub
        End If
        Dim loadedAssembly As Assembly = Assembly.LoadFile(a)
        Dim type As Type = loadedAssembly.GetType(loadedAssembly.GetName.Name & ".Entry")
        Dim instance As Object = Activator.CreateInstance(type)
        Dim method As MethodInfo = type.GetMethod("Entry")
        method.Invoke(instance, Array.Empty(Of Object)())
        If IsPersonalizationUnlocked Then
            Form1.SettingsPage.Panel1.Visible = False
            Form1.SettingsPage.Panel3.Visible = True

            If FileIO.FileSystem.FileExists(UserSettings.Instance.Personalization_AppIcon) Then
                Form1.SettingsPage.Label9.Text = UserSettings.Instance.Personalization_AppIcon
                Form1.LoadCustomIcon(UserSettings.Instance.Personalization_AppIcon)
            Else
                Form1.SettingsPage.Label9.Text = ""
                Form1.LoadCustomIcon(Nothing)
                UserSettings.Instance.Personalization_AppIcon = ""
            End If


            If FileIO.FileSystem.FileExists(UserSettings.Instance.Personalization_TaskCompleteSound) Then
                Form1.SettingsPage.Label11.Text = UserSettings.Instance.Personalization_TaskCompleteSound
                Form1.LoadCustomTaskCompleteSound(UserSettings.Instance.Personalization_TaskCompleteSound)
            Else
                Form1.SettingsPage.Label11.Text = ""
                UserSettings.Instance.Personalization_TaskCompleteSound = ""
            End If

            If FileIO.FileSystem.FileExists(UserSettings.Instance.Personalization_TaskFailedSound) Then
                Form1.SettingsPage.Label10.Text = UserSettings.Instance.Personalization_TaskFailedSound
                Form1.LoadCustomTaskFailedSound(UserSettings.Instance.Personalization_TaskFailedSound)
            Else
                Form1.SettingsPage.Label10.Text = ""
                UserSettings.Instance.Personalization_TaskFailedSound = ""
            End If

            If UserSettings.Instance.Personalization_StartPageTitle <> "" Then
                Form1.SettingsPage.UiTextBox1.Text = UserSettings.Instance.Personalization_StartPageTitle
                Form1.StartPage.LabelMainTitle.Text = UserSettings.Instance.Personalization_StartPageTitle
            Else
                Form1.SettingsPage.UiTextBox1.Text = ""
            End If

            If UserSettings.Instance.Personalization_StartPageSubtitle <> "" Then
                Form1.SettingsPage.UiTextBox2.Text = UserSettings.Instance.Personalization_StartPageSubtitle
                Form1.StartPage.LabelSubtitle.Text = UserSettings.Instance.Personalization_StartPageSubtitle
            Else
                Form1.SettingsPage.UiTextBox2.Text = ""
            End If

            If UserSettings.Instance.Personalization_WindowTitleBar <> "" Then
                Form1.SettingsPage.UiTextBox3.Text = UserSettings.Instance.Personalization_WindowTitleBar
                Form1.Text = UserSettings.Instance.Personalization_WindowTitleBar
            Else
                Form1.SettingsPage.UiTextBox3.Text = ""
            End If

            If FileIO.FileSystem.FileExists(UserSettings.Instance.Personalization_StartPageBackgroundImage) Then
                Form1.SettingsPage.Label14.Text = UserSettings.Instance.Personalization_StartPageBackgroundImage
                Form1.StartPage.Panel5.BackgroundImage = LoadImageFromFile(UserSettings.Instance.Personalization_StartPageBackgroundImage)
            Else
                Form1.SettingsPage.Label14.Text = ""
                UserSettings.Instance.Personalization_StartPageBackgroundImage = ""
            End If

        Else
            Form1.LoadCustomIcon(Nothing)
            Form1.SettingsPage.Panel1.Visible = True
            Form1.SettingsPage.Panel3.Visible = False
        End If
    End Sub

    Public Shared Property CustomInterfaceLoadedByPlugin As New Dictionary(Of String, Control)

    Public Shared Sub LoadPluginsOnStartup()
        Dim pluginsFolderPath As String = Path.Combine(Application.StartupPath, "Plugin")
        If Not FileIO.FileSystem.DirectoryExists(pluginsFolderPath) Then Exit Sub

        For Each pluginFile In IO.Directory.GetFiles(pluginsFolderPath, "*.3fui.dll")
            Dim loadedAssembly = Assembly.LoadFrom(pluginFile)
            Dim entryType As Type = loadedAssembly.GetType(loadedAssembly.GetName.Name & ".Entry")

            If entryType Is Nothing Then
                MsgBox($"{pluginFile} does not contain Entry class, cannot load this plugin", MsgBoxStyle.Critical)
                Continue For
            End If

            Dim entryInstance As Object = Activator.CreateInstance(entryType)

            If entryType.GetMethod("SetHost_AddCustomWinformPanel") IsNot Nothing Then
                Dim myCallback As Action(Of String, Control) = AddressOf AddCustomWinformPanel
                entryType.GetMethod("SetHost_AddCustomWinformPanel").Invoke(entryInstance, New Object() {myCallback})
            End If
            If entryType.GetMethod("SetHost_AddCustomWpfPanel") IsNot Nothing Then
                Dim myCallback As Action(Of String, System.Windows.UIElement) = AddressOf AddCustomWpfPanel
                entryType.GetMethod("SetHost_AddCustomWpfPanel").Invoke(entryInstance, New Object() {myCallback})
            End If

            If entryType.GetMethod("SetHost_AddMissionToQueueWithArgs") IsNot Nothing Then
                Dim myCallback As Action(Of String, String, String, String) = AddressOf AddMissionToQueueWithArgs
                entryType.GetMethod("SetHost_AddMissionToQueueWithArgs").Invoke(entryInstance, New Object() {myCallback})
            End If

            If entryType.GetMethod("SetHost_AddMissionToQueueWith3fuiFile") IsNot Nothing Then
                Dim myCallback As Action(Of String, String, String, String) = AddressOf AddMissionToQueueWith3fuiFile
                entryType.GetMethod("SetHost_AddMissionToQueueWith3fuiFile").Invoke(entryInstance, New Object() {myCallback})
            End If

            If entryType.GetMethod("SetHost_MediaStreamVisualSelector") IsNot Nothing Then
                Dim myCallback As Action(Of String, Object, Object, Object, String, String, String, String) = AddressOf OpenMediaStreamVisualSelector
                entryType.GetMethod("SetHost_MediaStreamVisualSelector").Invoke(entryInstance, New Object() {myCallback})
            End If

            Dim entryMethod As MethodInfo = entryType.GetMethod("Entry")
            If entryMethod Is Nothing Then
                MsgBox($"{pluginFile} Entry method not found in Entry class (must be Shared/static), Initialize not executed", MsgBoxStyle.Exclamation)
                Continue For
            End If
            entryMethod.Invoke(Nothing, Nothing)
        Next

        RefreshCustomInterfaceNamesToComboBox()

    End Sub

    Public Shared Sub AddCustomWinformPanel(Name As String, C As Control)
        CustomInterfaceLoadedByPlugin(Name) = C
    End Sub
    Public Shared Sub AddCustomWpfPanel(Name As String, UIE As System.Windows.UIElement)
        Dim host As New Integration.ElementHost With {.Child = UIE}
        CustomInterfaceLoadedByPlugin(Name) = host
    End Sub

    Public Shared Sub AddMissionToQueueWithArgs(FFmpegArg As String, FileName As String, OutputPath As String, Optional InputPath As String = "")
        Dim m As New EncodingTask.SingleTask With {.CommandLine = FFmpegArg, .OutputFile = OutputPath}
        If InputPath <> "" Then m.InputFile = InputPath
        Dim i2 As New ListViewItem(FileName)
        i2.SubItems.AddRange("Pending", "", "", "", "", "", "")
        Form1.ListView1.Items.Add(i2)
        m.ListViewItem = i2
        EncodingTask.Queue.Add(m)
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True
    End Sub

    Public Shared Sub AddMissionToQueueWith3fuiFile(File_3FUI_JsonPath As String, FileName As String, OutputPath As String, Optional InputPath As String = "")
        If Not FileIO.FileSystem.FileExists(File_3FUI_JsonPath) Then
            MsgBox("Specified preset file does not exist", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim m As New EncodingTask.SingleTask With {.PresetData = JsonSerializer.Deserialize(Of PresetDataType)(File.ReadAllText(File_3FUI_JsonPath)), .OutputFile = OutputPath}
        If InputPath <> "" Then m.InputFile = InputPath
        Dim i2 As New ListViewItem(FileName)
        i2.SubItems.AddRange("Pending", "", "", "", "", "", "")
        Form1.ListView1.Items.Add(i2)
        m.ListViewItem = i2
        EncodingTask.Queue.Add(m)
        EncodingTask.CheckAndStartNewTaskTimer.Enabled = True
    End Sub

    Shared Sub RefreshCustomInterfaceNamesToComboBox()
        For Each item In CustomInterfaceLoadedByPlugin
            Form1.UiComboBox3.Items.Add(item.Key)
        Next
    End Sub

    Public Shared Sub OpenMediaStreamVisualSelector(FilePath As String,
                                  VideoStreamTargetObject As Object,
                                  AudioStreamTargetObject As Object,
                                  SubtitleStreamTargetObject As Object,
                                  InputFileIndex As String,
                                  VideoStreamSelected As String,
                                  AudioStreamSelected As String,
                                  SubtitleStreamSelected As String
                                  )
        ShowForm(New FormMediaStreamSelector(mediaFileToRead:=FilePath,
          videoStreamTargetObject:=VideoStreamTargetObject,
          audioStreamTargetObject:=AudioStreamTargetObject,
          subtitleStreamTargetObject:=SubtitleStreamTargetObject,
          fileIndex:=InputFileIndex,
          videoStreamsSelected:=VideoStreamSelected,
          audioStreamsSelected:=AudioStreamSelected,
          subtitleStreamsSelected:=SubtitleStreamSelected), Form1)
    End Sub



End Class







