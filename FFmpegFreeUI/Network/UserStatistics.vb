Public Class UserStatistics

    Public Shared Sub ReportActive()
        Try
            If Not My.Computer.Network.IsAvailable Then Exit Sub
            If Not UserSettings.Instance.ParticipateInUserStatistics Then Exit Sub
            If UserSettings.Instance.LastActiveReportDate.Day = Now.Day Then Exit Sub

            Dim BGW As New ComponentModel.BackgroundWorker
            AddHandler BGW.DoWork,
               Async Sub(sender As Object, e As ComponentModel.DoWorkEventArgs)
                   Try
                       Using httpClient As New Net.Http.HttpClient() With {.Timeout = TimeSpan.FromSeconds(10)}
                           httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("hajimimanbo")
                           Dim response As Net.Http.HttpResponseMessage = Await httpClient.GetAsync("http://bs.frostlynx.work:14536/api/ping")
                           If response.IsSuccessStatusCode Then
                               Dim result As String = Await response.Content.ReadAsStringAsync()
                               Select Case result
                                   Case "1145141919810", "OK"
                                       UserSettings.Instance.LastActiveReportDate = Now
                                       Debug.Print("OKKK")
                                   Case Else : Debug.Print(result)
                               End Select
                           Else
                               Debug.Print(response.ToString)
                           End If
                       End Using
                   Catch ex As Exception
                   End Try
               End Sub

            BGW.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub
End Class




