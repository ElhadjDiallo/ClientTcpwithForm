Imports System.IO

Public Class ConectCli
    'specify that we want to use a TCP client and add information about port and server
    Dim client As Net.Sockets.TcpClient
    Private port As Int32 = 13214
    Private server As String = "127.0.0.1"
    'a stream that we can use to reach the server
    Private stream As Net.Sockets.NetworkStream
    Dim sr As StreamReader
    Dim sw As StreamWriter
    Private Shared listeMessage As List(Of String)
    Public Sub New()
    End Sub

    Public Sub connect()
        Try
            'we  connect the client to the server with the port we have specified before
            client = New Net.Sockets.TcpClient(server, port)
            stream = client.GetStream()
            'and create the stream for reading and writting 
            sr = New StreamReader(stream)
            sw = New StreamWriter(stream)

        Catch ex As Exception

            MessageBox.Show(ex.ToString())


        End Try



    End Sub

    Public Sub SendData(ByVal textbox As RichTextBox, ByVal ipadrress As String, ByVal user As String, ByVal mdp As String)
        textbox.Text = ""
        'this is the first the communication to send the server because we trying to reach a ssh client so 
        ' we give three information the ip address of the remote that we want to reach also login and password
        Dim datareceive As String
        For i As Integer = 0 To 2

            If i = 0 Then
                sw.WriteLine(ipadrress)
                sw.Flush()
            ElseIf i = 1 Then
                sw.WriteLine(user)
                sw.Flush()
            Else
                sw.WriteLine(mdp)
                sw.Flush()
            End If


        Next
        datareceive = sr.ReadLine()
        textbox.Focus()
        textbox.AppendText("" + datareceive & vbNewLine)
        textbox.ScrollToCaret()

        listeMessage = New List(Of String)




    End Sub
    Public Sub exchange(ByVal textbox As RichTextBox, ByVal message As String)
        Try
            Dim data As String = message
            Dim datareceive As String
            'send a command to the server when the connection is etablished before
            sw.WriteLine(data)
            sw.Flush()
            listeMessage.Add(">>" + data & vbNewLine)
            'and read the response that server has given us 
            datareceive = sr.ReadLine()
            listeMessage.Add(datareceive)
            Dim s As String = ""
            For Each mes As String In listeMessage
                s += "" + mes & vbNewLine
            Next
            textbox.AppendText(s)
            textbox.ScrollToCaret()
            'close the flux when the client decide to disconnect
            If (data.Equals("end")) Then

                textbox.Text = ">Disconnected"
                sr.Close()
                sw.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try






    End Sub

End Class
