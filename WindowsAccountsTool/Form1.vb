Imports System.IO
Imports System.Security.Principal

Public Class Form1

    Dim identity = WindowsIdentity.GetCurrent()
    Dim principal = New WindowsPrincipal(identity)
    Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
    Private Sub ElevateMe()
        Dim proc As New ProcessStartInfo()
        proc.UseShellExecute = True
        proc.WorkingDirectory = Environment.CurrentDirectory
        proc.FileName = Application.ExecutablePath
        proc.Verb = "runas"
        Try
            Process.Start(proc)
        Catch
            Exit Sub
        End Try
        Application.Exit() ' Kill the old process
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (isElevated = False) Then
            MsgBox("Please allow to run as Admin")
        End If
        Dim cmd As String = "CMD.exe /C net user " & TextBox1.Text & " /ADD"
        Shell(cmd)
        cmd = "CMD.exe /C net user > result.txt"
        Shell(cmd)
        If (radioAdmin.Checked = True) Then
            Shell("Net localgroup administrators " & TextBox1.Text & " /add")
        ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Please enter username.")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If isElevated Then
        Else
            ElevateMe()
        End If

    End Sub

    Private Sub btnShowUsers_Click(sender As Object, e As EventArgs) Handles btnShowUsers.Click
        Dim read As System.IO.StreamReader
        Try
            read = File.OpenText("result.txt")
            RichTextBox1.Clear()
            Do Until read.EndOfStream
                RichTextBox1.Text += read.ReadLine & vbCrLf

            Loop
            read.Close()
        Catch ex As Exception
            MsgBox("Nothing to show")
        End Try


    End Sub
End Class
