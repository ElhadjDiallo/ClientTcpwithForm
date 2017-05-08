Imports System.IO

Public Class ConectCli
    Dim client As Net.Sockets.TcpClient
    Private port As Int32 = 13214
    Private server As String = "127.0.0.1"
    Private stream As Net.Sockets.NetworkStream
    Dim sr As StreamReader
    Dim sw As StreamWriter
    Private Shared listeMessage As List(Of String)
    Public Sub New()
    End Sub

    Public Sub connect()
        Try
            client = New Net.Sockets.TcpClient(server, port)
            stream = client.GetStream()
            sr = New StreamReader(stream)
            sw = New StreamWriter(stream)

        Catch ex As Exception

            MessageBox.Show(ex.ToString())


        End Try
       


    End Sub

    Public Sub SendData(ByVal textbox As RichTextBox, ByVal ipadrress As String, ByVal user As String, ByVal mdp As String)
        textbox.Text = ""
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

            sw.WriteLine(data)
            sw.Flush()
            listeMessage.Add(">:" + data & vbNewLine)
            datareceive = sr.ReadLine()
            listeMessage.Add(datareceive)
            Dim s As String = ""
            For Each mes As String In listeMessage
                s += "" + mes & vbNewLine
            Next
            textbox.AppendText(s)
            textbox.ScrollToCaret()
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
