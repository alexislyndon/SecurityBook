Imports System.IO
Module Session
    Public s_uid As Integer
    Public s_name As String
    Public s_uname As String
    Public s_gate As String


    Public Sub startsession(id As Integer, name As String, uname As String, gate As String)
        s_uid = id
        s_name = name
        s_uname = uname
        s_gate = gate
    End Sub


    Public Sub endsession()
        logger("Logged out")
        s_uid = Nothing
        s_name = Nothing
        s_uname = Nothing
        s_gate = Nothing
    End Sub

    Public Function getsessionid()
        Return s_uid
    End Function

    Public Sub logger(action As String)
        'Directory.GetCurrentDirectory()
        'Dim dataDirectory As String = String.Format("{0}\Logs\sblogs.txt", Environment.CurrentDirectory)
        Dim dataDirectory As String = String.Format("{0}\sblogs.txt", Directory.GetCurrentDirectory())

        Dim path As String = dataDirectory '"d:\sblogs.txt"

        ' This text is added only once to the file. 
        If Not File.Exists(path) Then
            'Using sw As StreamWriter = File.CreateText(path)
            Using sw As StreamWriter = File.AppendText(path)
                MsgBox("yawaaaaaaaaa")
                sw.WriteLine("##### Log file for Security Logbook #####")
            End Using
        End If
        Using sw As StreamWriter = File.AppendText(path)
            sw.Write(Date.Now)
            sw.Write(" | User: " & s_uname)
            sw.Write(" | Action: " & action)
            sw.Write(" | at Gate: " & s_gate)
            sw.WriteLine("--/")
        End Using
    End Sub


End Module
