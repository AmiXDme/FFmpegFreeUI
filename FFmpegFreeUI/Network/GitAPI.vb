Imports System.Net.Http
Imports System.Text.Json
Imports FFmpegFreeUI.GitAPI.GitApiObject

Public Class GitAPI

    Public Class GitApiObject

        Public Enum OpenSourcePlatform
            Gitee = 1
            GitHub = 2
        End Enum

        Public Shared Property CustomUserAgent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/138.0.0.0 Safari/537.36 Edg/138.0.0.0"
    End Class

    Public Class Release

        Public Property Title As String = ""
        Public Property VersionTag As String = ""
        Public Property IsPrerelease As Boolean = False
        Public Property Description As String = ""
        Public Property ReleaseTime As String = ""
        Public Property AuthorUsername As String = ""
        Public Property AuthorNickname As String = ""
        Public Property Assets As New List(Of KeyValuePair(Of String, String))
        Public Property ErrorString As String = ""

        Private Shared ReadOnly httpClient As New HttpClient() With {
            .Timeout = TimeSpan.FromSeconds(10)
        }

        Shared Sub New()
            httpClient.DefaultRequestHeaders.Add("User-Agent", GitApiObject.CustomUserAgent)
        End Sub

        ''' <summary>
        ''' Access the open source platform's web API and analyze the returned JSON to get various information.
        ''' </summary>
        ''' <returns>Returns an empty string if successful, otherwise returns an error description.</returns>
        Public Async Function GetRepositoryReleaseInfoAsync(targetPlatform As OpenSourcePlatform, repository As String, Optional specifiedTag As String = "") As Task(Of String)
            Try
                ErrorString = ""
                Dim apiUrl As String = GetApiUrl(targetPlatform, repository)

                Using response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)
                    If Not response.IsSuccessStatusCode Then
                        Dim errorContent = Await response.Content.ReadAsStringAsync()
                        ErrorString = $"Request failed: {errorContent}"
                        Return ErrorString
                    End If

                    Dim jsonContent = Await response.Content.ReadAsStringAsync()
                    Dim options As New JsonSerializerOptions With {
                        .PropertyNameCaseInsensitive = True
                    }

                    Dim releases = JsonSerializer.Deserialize(Of JsonElement())(jsonContent, options)

                    If releases.Length = 0 Then
                        ErrorString = "Server failed to return valid data."
                        Return ErrorString
                    End If

                    Dim latestRelease = releases(0)

                    Title = GetJsonStringValue(latestRelease, "name")
                    VersionTag = GetJsonStringValue(latestRelease, "tag_name")
                    IsPrerelease = GetJsonBooleanValue(latestRelease, "prerelease")
                    Description = GetJsonStringValue(latestRelease, "body")
                    ReleaseTime = GetJsonStringValue(latestRelease, "created_at")

                    Dim author As JsonElement
                    If latestRelease.TryGetProperty("author", author) Then
                        AuthorUsername = GetJsonStringValue(author, "login")
                        If targetPlatform = OpenSourcePlatform.Gitee Then
                            AuthorNickname = GetJsonStringValue(author, "name")
                        End If
                    End If

                    Assets.Clear()
                    Dim assetsProp As JsonElement
                    If latestRelease.TryGetProperty("assets", assetsProp) Then
                        For Each asset In assetsProp.EnumerateArray()
                            Dim fileName = GetJsonStringValue(asset, "name")
                            Dim downloadUrl = GetJsonStringValue(asset, "browser_download_url")
                            If Not String.IsNullOrEmpty(fileName) Then
                                Assets.Add(New KeyValuePair(Of String, String)(fileName, downloadUrl))
                            End If
                        Next
                    End If

                    Return ""
                End Using

            Catch ex As Exception
                ErrorString = ex.Message
                Return ErrorString
            End Try
        End Function

        Public Function GetRepositoryReleaseInfo(targetPlatform As OpenSourcePlatform, repository As String, Optional specifiedTag As String = "") As String
            Return GetRepositoryReleaseInfoAsync(targetPlatform, repository, specifiedTag).GetAwaiter().GetResult()
        End Function

        Private Shared Function GetApiUrl(targetPlatform As OpenSourcePlatform, repository As String) As String
            Select Case targetPlatform
                Case OpenSourcePlatform.Gitee
                    Return $"https://gitee.com/api/v5/repos/{repository}/releases/?direction=desc"
                Case OpenSourcePlatform.GitHub
                    Return $"https://api.github.com/repos/{repository}/releases"
                Case Else
                    Throw New ArgumentException("Unsupported platform type")
            End Select
        End Function

        Private Shared Function GetJsonStringValue(element As JsonElement, propertyName As String) As String
            Dim propertyValue As JsonElement
            If element.TryGetProperty(propertyName, propertyValue) AndAlso propertyValue.ValueKind = JsonValueKind.String Then
                Return propertyValue.GetString()
            End If
            Return ""
        End Function

        Private Shared Function GetJsonBooleanValue(element As JsonElement, propertyName As String) As Boolean
            Dim propertyValue As JsonElement
            If element.TryGetProperty(propertyName, propertyValue) AndAlso propertyValue.ValueKind <> JsonValueKind.Null Then
                Return propertyValue.GetBoolean()
            End If
            Return False
        End Function

    End Class

    Public Class TextFileString

        Public Property Content As String = ""
        Public Property ErrorString As String = ""

        Private Shared ReadOnly httpClient As New HttpClient() With {
            .Timeout = TimeSpan.FromSeconds(10)
        }

        Shared Sub New()
            httpClient.DefaultRequestHeaders.Add("User-Agent", GitApiObject.CustomUserAgent)
        End Sub

        ''' <summary>
        ''' Get raw text file content.
        ''' </summary>
        Public Async Function GetTextFileDataAsync(targetPlatform As OpenSourcePlatform, repoFullName As String, branch As String, path As String, Optional token As String = "", Optional identifyJsonError As Boolean = False) As Task(Of String)
            Try
                ErrorString = ""
                Dim fileUrl = GetFileUrl(targetPlatform, repoFullName, branch, path, token)

                Using response As HttpResponseMessage = Await httpClient.GetAsync(fileUrl)
                    If Not response.IsSuccessStatusCode Then
                        Dim errorContent = Await response.Content.ReadAsStringAsync()
                        ErrorString = $"Request failed: {errorContent}"
                        Return ErrorString
                    End If

                    Dim contentValue = Await response.Content.ReadAsStringAsync()

                    If identifyJsonError Then
                        Try
                            Dim options As New JsonSerializerOptions With {
                                .PropertyNameCaseInsensitive = True
                            }
                            Dim jsonElement = JsonSerializer.Deserialize(Of JsonElement)(contentValue, options)
                            Dim messageProperty As JsonElement

                            If jsonElement.TryGetProperty("message", messageProperty) Then
                                ErrorString = messageProperty.GetString()
                                Return ErrorString
                            End If
                        Catch
                            ' If not valid JSON, treat as plain text
                        End Try
                    End If

                    Content = contentValue
                    Return ""
                End Using

            Catch ex As Exception
                ErrorString = ex.Message
                Return ErrorString
            End Try
        End Function

        Public Function GetTextFileData(targetPlatform As OpenSourcePlatform, repoFullName As String, branch As String, path As String, Optional token As String = "", Optional identifyJsonError As Boolean = False) As String
            Return GetTextFileDataAsync(targetPlatform, repoFullName, branch, path, token, identifyJsonError).GetAwaiter().GetResult()
        End Function

        Private Shared Function GetFileUrl(targetPlatform As OpenSourcePlatform, repoFullName As String, branch As String, path As String, token As String) As String
            Dim baseUrl As String
            Select Case targetPlatform
                Case OpenSourcePlatform.Gitee
                    baseUrl = $"https://gitee.com/{repoFullName}/raw/{branch}/{path}"
                    If Not String.IsNullOrEmpty(token) Then
                        baseUrl &= $"?access_token={token}"
                    End If
                Case OpenSourcePlatform.GitHub
                    baseUrl = $"https://raw.githubusercontent.com/{repoFullName}/{branch}/{path}"
                    If Not String.IsNullOrEmpty(token) Then
                        baseUrl &= $"?token={token}"
                    End If
                Case Else
                    Throw New ArgumentException("Unsupported platform type")
            End Select
            Return baseUrl
        End Function

    End Class

    Public Class Tag

        Public Property TagList As New List(Of TagData)
        Public Property ErrorString As String = ""

        Public Structure TagData
            Public name As String
        End Structure

        Private Shared ReadOnly httpClient As New HttpClient() With {
            .Timeout = TimeSpan.FromSeconds(10)
        }

        Shared Sub New()
            httpClient.DefaultRequestHeaders.Add("User-Agent", GitApiObject.CustomUserAgent)
        End Sub

        Public Async Function GetRepositoryTagInfoAsync(targetPlatform As OpenSourcePlatform, repository As String) As Task(Of String)
            Try
                TagList.Clear()
                ErrorString = ""
                Dim apiUrl = GetTagApiUrl(targetPlatform, repository)

                Using response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)
                    If Not response.IsSuccessStatusCode Then
                        ErrorString = Await response.Content.ReadAsStringAsync()
                        Return ErrorString
                    End If

                    Dim jsonContent = Await response.Content.ReadAsStringAsync()
                    Dim options As New JsonSerializerOptions With {
                        .PropertyNameCaseInsensitive = True
                    }

                    Dim tags = JsonSerializer.Deserialize(Of JsonElement())(jsonContent, options)

                    For Each tag In tags
                        Dim tagDataObj As New TagData
                        With tagDataObj
                            .name = GetJsonStringValue(tag, "name")
                        End With
                        TagList.Add(tagDataObj)
                    Next

                    Return ""
                End Using

            Catch ex As Exception
                ErrorString = ex.Message
                Return ex.Message
            End Try
        End Function

        Public Function GetRepositoryTagInfo(targetPlatform As OpenSourcePlatform, repository As String) As String
            Return GetRepositoryTagInfoAsync(targetPlatform, repository).GetAwaiter().GetResult()
        End Function

        Private Shared Function GetTagApiUrl(targetPlatform As OpenSourcePlatform, repository As String) As String
            Select Case targetPlatform
                Case OpenSourcePlatform.Gitee
                    Return $"https://gitee.com/api/v5/repos/{repository}/tags"
                Case OpenSourcePlatform.GitHub
                    Return $"https://api.github.com/repos/{repository}/tags"
                Case Else
                    Throw New ArgumentException("Unsupported platform type")
            End Select
        End Function

        Private Shared Function GetJsonStringValue(element As JsonElement, propertyName As String) As String
            Dim propertyValue As JsonElement
            If element.TryGetProperty(propertyName, propertyValue) AndAlso propertyValue.ValueKind = JsonValueKind.String Then
                Return propertyValue.GetString()
            End If
            Return ""
        End Function

    End Class

    Public Class GitHubAllReleaseFile

        Public Property ReleaseDataList As New List(Of ReleaseData)

        Public Structure ReleaseData
            Public Assets As List(Of KeyValuePair(Of String, String))
            Public Title As String
            Public Description As String
            Public Tag As String
            Public IsDraft As Boolean
            Public IsPrerelease As Boolean
        End Structure

        Private Shared ReadOnly httpClient As New HttpClient() With {
            .Timeout = TimeSpan.FromSeconds(10)
        }

        Shared Sub New()
            httpClient.DefaultRequestHeaders.Add("User-Agent", GitApiObject.CustomUserAgent)
        End Sub

        Public Async Function GetAsync(repository As String) As Task(Of String)
            Try
                Dim apiUrl = $"https://api.github.com/repos/{repository}/releases"

                Using response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)
                    If Not response.IsSuccessStatusCode Then
                        Return Await response.Content.ReadAsStringAsync()
                    End If

                    Dim jsonContent = Await response.Content.ReadAsStringAsync()
                    Dim options As New JsonSerializerOptions With {
                        .PropertyNameCaseInsensitive = True
                    }

                    Dim releases = JsonSerializer.Deserialize(Of JsonElement())(jsonContent, options)

                    ReleaseDataList.Clear()
                    For Each release In releases
                        Dim releaseDataObj As New ReleaseData With {
                            .Title = GetJsonStringValue(release, "name"),
                            .Description = GetJsonStringValue(release, "body"),
                            .Tag = GetJsonStringValue(release, "tag_name"),
                            .IsDraft = GetJsonBooleanValue(release, "draft"),
                            .IsPrerelease = GetJsonBooleanValue(release, "prerelease"),
                            .Assets = New List(Of KeyValuePair(Of String, String))
                        }

                        Dim assetsProp As JsonElement
                        If release.TryGetProperty("assets", assetsProp) Then
                            For Each asset In assetsProp.EnumerateArray()
                                Dim fileName = GetJsonStringValue(asset, "name")
                                Dim downloadUrl = GetJsonStringValue(asset, "browser_download_url")
                                If Not String.IsNullOrEmpty(fileName) Then
                                    releaseDataObj.Assets.Add(New KeyValuePair(Of String, String)(fileName, downloadUrl))
                                End If
                            Next
                        End If

                        ReleaseDataList.Add(releaseDataObj)
                    Next

                    Return ""
                End Using

            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

        Public Function GetResult(repository As String) As String
            Return GetAsync(repository).GetAwaiter().GetResult()
        End Function

        Private Shared Function GetJsonStringValue(element As JsonElement, propertyName As String) As String
            Dim propertyValue As JsonElement
            If element.TryGetProperty(propertyName, propertyValue) AndAlso propertyValue.ValueKind = JsonValueKind.String Then
                Return propertyValue.GetString()
            End If
            Return ""
        End Function

        Private Shared Function GetJsonBooleanValue(element As JsonElement, propertyName As String) As Boolean
            Dim propertyValue As JsonElement
            If element.TryGetProperty(propertyName, propertyValue) AndAlso propertyValue.ValueKind <> JsonValueKind.Null Then
                Return propertyValue.GetBoolean()
            End If
            Return False
        End Function

    End Class

End Class
