Imports System.Net

Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ws As New WebClient
        Dim ip As String
        ip = ws.DownloadString("https://raw.githubusercontent.com/Ren0X1/VersionCheck/main/ipSanAndreas.txt")
        Shell("Explorer.exe " + ip)
    End Sub
    Dim brr As String = "2"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim foto2 As String = "https://raw.githubusercontent.com/Ren0X1/VersionCheck/main/2.png"
        Dim img2 As Image = GetImageFromURL(foto2)

        Dim foto1 As String = "https://raw.githubusercontent.com/Ren0X1/VersionCheck/main/1.png"
        Dim img As Image = GetImageFromURL(foto1)
        If brr = "2" Then
            PictureBox1.Image = img2
            brr = "1"
        Else
            PictureBox1.Image = img
            brr = "2"
        End If
    End Sub

    Private Sub gotoTS_Click(sender As Object, e As EventArgs) Handles gotoTS.Click
        Dim ws As New WebClient
        Dim ts3 As String
        ts3 = ws.DownloadString("https://raw.githubusercontent.com/Ren0X1/VersionCheck/main/ts3SanAndreas.txt")
        Shell("Explorer.exe " + ts3)
    End Sub

End Class
