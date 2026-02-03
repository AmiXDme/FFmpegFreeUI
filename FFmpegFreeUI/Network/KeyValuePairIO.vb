Imports System.IO

Public Class KeyValuePairIO
    Public Shared Function ReadKeyValuePairFileToDictionary(ByRef dictionaryObj As Dictionary(Of String, String), textFilePath As String) As String
        Try
            Using reader As New StringReader(FileIO.FileSystem.ReadAllText(textFilePath))
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim parts As String() = line.Split("="c)
                    Select Case parts.Length
                        Case 2
                            dictionaryObj(parts(0)) = parts(1)
                        Case > 2
                            Dim key As String = parts(0).Trim()
                            Dim value As String = String.Join("=", parts.Skip(1)).Trim()
                            dictionaryObj(key) = value
                    End Select
                    line = reader.ReadLine()
                End While
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function ReadKeyValuePairTextToDictionary(ByRef dictionaryObj As Dictionary(Of String, String), text As String) As String
        Try
            Using reader As New StringReader(text)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim parts As String() = line.Split("="c)
                    Select Case parts.Length
                        Case 2
                            dictionaryObj(parts(0)) = parts(1)
                        Case > 2
                            Dim key As String = parts(0).Trim()
                            Dim value As String = String.Join("=", parts.Skip(1)).Trim()
                            dictionaryObj(key) = value
                    End Select
                    line = reader.ReadLine()
                End While
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function ReadKeyValuePairFileToList(ByRef listObj As List(Of KeyValuePair(Of String, String)), textFilePath As String) As String
        Try
            Using reader As New StringReader(FileIO.FileSystem.ReadAllText(textFilePath))
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim parts As String() = line.Split("="c)
                    Select Case parts.Length
                        Case 2
                            listObj.Add(New KeyValuePair(Of String, String)(parts(0), parts(1)))
                        Case > 2
                            Dim key As String = parts(0).Trim()
                            Dim value As String = String.Join("=", parts.Skip(1)).Trim()
                            listObj.Add(New KeyValuePair(Of String, String)(key, value))
                    End Select
                    line = reader.ReadLine()
                End While
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function ReadKeyValuePairTextToList(ByRef listObj As List(Of KeyValuePair(Of String, String)), text As String) As String
        Try
            Using reader As New StringReader(text)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Dim parts As String() = line.Split("="c)
                    Select Case parts.Length
                        Case 2
                            listObj.Add(New KeyValuePair(Of String, String)(parts(0), parts(1)))
                        Case > 2
                            Dim key As String = parts(0).Trim()
                            Dim value As String = String.Join("=", parts.Skip(1)).Trim()
                            listObj.Add(New KeyValuePair(Of String, String)(key, value))
                    End Select
                    line = reader.ReadLine()
                End While
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Public Shared Function WriteDictionaryToKeyValuePairFile(ByRef dictionaryObj As Dictionary(Of String, String), textFilePath As String) As String
        Try
            Dim str1 As String = ""
            For Each key As String In dictionaryObj.Keys
                str1 &= key & "=" & dictionaryObj(key) & vbCrLf
            Next
            FileIO.FileSystem.WriteAllText(textFilePath, str1, False)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function WriteListToKeyValuePairFile(ByRef listObj As List(Of KeyValuePair(Of String, String)), textFilePath As String) As String
        Try
            Dim str1 As String = ""
            For Each kvp As KeyValuePair(Of String, String) In listObj
                str1 &= kvp.Key & "=" & kvp.Value & vbCrLf
            Next
            FileIO.FileSystem.WriteAllText(textFilePath, str1, False)
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
