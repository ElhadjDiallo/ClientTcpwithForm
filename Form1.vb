
Public Class Form1
    Private Shared clientssh As ConectCli
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Create a process to execute server.exe that can be found in debug folder 
        Dim cmd As Process = New Process()
        cmd.StartInfo.FileName = "server.exe"

        'comment this line if you don't want to hide the process for debugging
        cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        cmd.Start()
        'create a object of our ConectCli class
        clientssh = New ConectCli()


       
    End Sub

    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click
        'open a connection with the server
        clientssh.connect()
        'send the connection information to the server to reach the remote 
        clientssh.SendData(print, ip.Text, user.Text, password.Text)
        'if the server answer something with welcome then we now the server can reach the remote 
        If (print.Text.Contains("Welcome")) Then
            etat.Text = "Online"
            etat.ForeColor = System.Drawing.Color.Green
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'only when the connection is ok then with this function we can send a command with the flux throught the flux we have opened before
        clientssh.exchange(print, cmd.Text)
    End Sub

    Private Sub disconect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconect.Click
        'we send to the server who is in our localhost the message thant contains end the server will close the connection to the remote
        clientssh.exchange(print, "end")
        etat.ForeColor = System.Drawing.Color.Red

        print.Text = "> Disconnected"




    End Sub
End Class
