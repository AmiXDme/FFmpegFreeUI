Imports System.Text.Json

Module Module3_MultiLanguage
    Public Property MultiLanguageDictionary As New Dictionary(Of String, String)

    Public Sub LoadMultiLanguage()
        Try
            ' Default to English from resources
            MultiLanguageDictionary = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(My.Resources.Resource1.Language_en, JsonSO)
        Catch ex As Exception
            ' Fallback or log error
        End Try
    End Sub

    Public Function Translate(key As String) As String
        If String.IsNullOrWhiteSpace(key) Then
            Return ""
        End If
        Dim value As String = Nothing
        If MultiLanguageDictionary.TryGetValue(key, value) Then
            Return value.Replace("<br>", vbCrLf)
        Else
            Return key
        End If
    End Function

End Module
