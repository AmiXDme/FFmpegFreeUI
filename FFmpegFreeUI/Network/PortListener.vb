Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class PortListening
    Public Shared Property UdpClientInstance As UdpClient
    Public Shared Property ListeningTaskList As New List(Of Task)
    Public Shared Property CancellationTokenSourceInstance As CancellationTokenSource
    Public Shared Property IsRunning As Boolean = False
    Public Shared Property IsResponseReceived As Boolean = False
    Public Shared Property ResponseThreadCount As Integer = 1
    Private Shared ReadOnly LockObject As New Object()

    Public Shared Sub StartClient()
        IsRunning = True
        IsResponseReceived = False

        Dim p As String = UserSettings.Instance.ListeningPort
        If p = "10590" Then p = "10591"
        If p = "" Then p = "10591"

        Dim PortNumber As Integer = Integer.Parse(p)
        ' Bind to local port for listening
        UdpClientInstance = New UdpClient(PortNumber)
        UdpClientInstance.Client.ReceiveTimeout = 10000

        CancellationTokenSourceInstance = New CancellationTokenSource()

        For i As Integer = 1 To ResponseThreadCount
            Dim listeningTask As Task = Task.Run(AddressOf ListenForMessages, CancellationTokenSourceInstance.Token)
            ListeningTaskList.Add(listeningTask)
        Next
    End Sub

    Public Shared Sub ListenForMessages()
        While IsRunning AndAlso Not CancellationTokenSourceInstance.Token.IsCancellationRequested
            Try
                Dim RemoteEndPoint As IPEndPoint = Nothing
                Dim ReceivedBytes As Byte()
                If UdpClientInstance Is Nothing Then Exit While
                ReceivedBytes = UdpClientInstance.Receive(RemoteEndPoint)
                Dim DataText = Encoding.UTF8.GetString(ReceivedBytes)
                ExecuteOnUIThread(Sub() StartupArgsHandler.HandleReceivedArgs(DataText.Split(" "c).ToList()))
            Catch ex As SocketException When ex.SocketErrorCode = SocketError.TimedOut
                ' Timeout, continue loop
            Catch ex As ObjectDisposedException
                ' Client closed, exit loop
                Exit While
            Catch ex As Exception
                ' Other exceptions can be logged
            End Try
        End While
    End Sub

    Public Shared Async Sub StopClient()
        IsResponseReceived = False
        IsRunning = False

        CancellationTokenSourceInstance?.Cancel()
        UdpClientInstance?.Close()

        If ListeningTaskList.Count > 0 Then
            Await Task.WhenAll(ListeningTaskList)
        End If

        CancellationTokenSourceInstance?.Dispose()
        CancellationTokenSourceInstance = Nothing
        UdpClientInstance = Nothing
        ListeningTaskList.Clear()
    End Sub

    Public Shared Function GetLocalIPv4() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

    Public Shared Function GetLocalIPv6() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetworkV6 Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

End Class










