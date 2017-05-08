
Public Class Form1
    Private Shared clientssh As ConectCli
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Dim cmd As Process = New Process()
        cmd.StartInfo.FileName = "server.exe"
        cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        cmd.Start()
        clientssh = New ConectCli()


       
    End Sub

    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click
        clientssh.connect()
        clientssh.SendData(print, ip.Text, user.Text, password.Text)
        If (print.Text.Contains("Welcome")) Then
            etat.Text = "Online"
            etat.ForeColor = System.Drawing.Color.Green
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clientssh.exchange(print,cmd.Text)
    End Sub

    Private Sub disconect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconect.Click
        clientssh.exchange(print, "end")
        etat.ForeColor = System.Drawing.Color.Red

        print.Text = "> Disconnected"




    End Sub
End Class
