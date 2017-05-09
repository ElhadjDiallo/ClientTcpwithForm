<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.disconect = New System.Windows.Forms.Button
        Me.print = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ip = New System.Windows.Forms.TextBox
        Me.password = New System.Windows.Forms.TextBox
        Me.user = New System.Windows.Forms.TextBox
        Me.connect = New System.Windows.Forms.Button
        Me.cmd = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.etat = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.etat)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmd)
        Me.Panel1.Controls.Add(Me.connect)
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.ip)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.disconect)
        Me.Panel1.Controls.Add(Me.print)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 562)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(655, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(655, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ip Address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'disconect
        '
        Me.disconect.Location = New System.Drawing.Point(848, 22)
        Me.disconect.Name = "disconect"
        Me.disconect.Size = New System.Drawing.Size(121, 28)
        Me.disconect.TabIndex = 1
        Me.disconect.Text = "DISCONNECT"
        Me.disconect.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.BackColor = System.Drawing.SystemColors.HighlightText
        Me.print.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.Location = New System.Drawing.Point(3, 3)
        Me.print.Name = "print"
        Me.print.ReadOnly = True
        Me.print.Size = New System.Drawing.Size(641, 387)
        Me.print.TabIndex = 0
        Me.print.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(655, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ip
        '
        Me.ip.Location = New System.Drawing.Point(791, 368)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(150, 22)
        Me.ip.TabIndex = 6
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(791, 456)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(150, 22)
        Me.password.TabIndex = 7
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(791, 417)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(150, 22)
        Me.user.TabIndex = 8
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(824, 511)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(117, 29)
        Me.connect.TabIndex = 9
        Me.connect.Text = "Connect"
        Me.connect.UseVisualStyleBackColor = True
        '
        'cmd
        '
        Me.cmd.Location = New System.Drawing.Point(12, 466)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(411, 22)
        Me.cmd.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(470, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Sent"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'etat
        '
        Me.etat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etat.ForeColor = System.Drawing.Color.Red
        Me.etat.Location = New System.Drawing.Point(684, 22)
        Me.etat.Name = "etat"
        Me.etat.Size = New System.Drawing.Size(100, 23)
        Me.etat.TabIndex = 12
        Me.etat.Text = "offline"
        Me.etat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents disconect As System.Windows.Forms.Button
    Friend WithEvents print As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents connect As System.Windows.Forms.Button
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents ip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd As System.Windows.Forms.TextBox
    Friend WithEvents etat As System.Windows.Forms.Label

End Class
