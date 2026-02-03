Imports System.Net.Http
Imports System.Text.Json

Public Class GitHubAPI
    Public Class Release

        Public Title As String = ""
        Public TagName As String = ""
        Public IsPrerelease As Boolean = False
        Public Description As String = ""
        Public ReleaseTime As String = ""
        Public AuthorName As String = ""
        Public Assets As New List(Of KeyValuePair(Of String, String))

        Public ErrorString As String = ""

        Public Async Function GetRepositoryReleaseInfoAsync(repository As String, Optional tag As String = "") As Task(Of String)
            Try
                ErrorString = ""
                Dim url As String = $"https://api.github.com/repos/{repository}/releases"
                If Not String.IsNullOrEmpty(tag) Then
                    url = $"https://api.github.com/repos/{repository}/releases/tags/{tag}"
                End If

                Dim content As String = ""
                Using client As New HttpClient()
                    client.DefaultRequestHeaders.Add("User-Agent", "github_api")
                    client.Timeout = TimeSpan.FromSeconds(10)
                    Dim response = Await client.GetAsync(url)
                    If response.IsSuccessStatusCode Then
                        content = Await response.Content.ReadAsStringAsync()
                    Else
                        ErrorString = Await response.Content.ReadAsStringAsync()
                        Return ErrorString
                    End If
                End Using

                ' Parse JSON
                Dim options As New JsonSerializerOptions With {
                    .PropertyNameCaseInsensitive = True
                }

                If String.IsNullOrEmpty(tag) Then
                    ' Get latest release
                    Dim releases = JsonSerializer.Deserialize(Of List(Of GitHubRelease))(content, options)
                    If releases Is Nothing OrElse releases.Count = 0 Then
                        ErrorString = "No release information found."
                        Return ErrorString
                    End If
                    Dim release = releases(0)
                    FillReleaseInfo(release)
                Else
                    ' Get specified tag release
                    Dim release = JsonSerializer.Deserialize(Of GitHubRelease)(content, options)
                    If release Is Nothing Then
                        ErrorString = "No release information found for specified tag."
                        Return ErrorString
                    End If
                    FillReleaseInfo(release)
                End If

                Return ""
            Catch ex As Exception
                ErrorString = ex.Message
                Return ErrorString
            End Try
        End Function

        Private Sub FillReleaseInfo(release As GitHubRelease)
            Title = If(release.Name, "")
            TagName = If(release.Tag_name, "")
            IsPrerelease = release.Prerelease
            Description = If(release.Body, "")
            ReleaseTime = If(release.Created_at, "")
            If ReleaseTime <> "" Then
                ReleaseTime = DateTime.Parse(ReleaseTime).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss")
            End If
            AuthorName = If(release.Author?.Login, "")
            Assets.Clear()
            If release.Assets IsNot Nothing Then
                For Each asset In release.Assets
                    If asset.Name IsNot Nothing AndAlso asset.Browser_download_url IsNot Nothing Then
                        Assets.Add(New KeyValuePair(Of String, String)(asset.Name, asset.Browser_download_url))
                    End If
                Next
            End If
        End Sub

        ' Internal classes for deserialization
        Private Class GitHubRelease
            Public Property Name As String
            Public Property Tag_name As String
            Public Property Prerelease As Boolean
            Public Property Body As String
            Public Property Created_at As String
            Public Property Author As GitHubAuthor
            Public Property Assets As List(Of GitHubAsset)
        End Class

        Private Class GitHubAuthor
            Public Property Login As String
        End Class

        Private Class GitHubAsset
            Public Property Name As String
            Public Property Browser_download_url As String
        End Class

    End Class
End Class
