Imports System.Net
Imports System.IO

Public Class Form1
    Dim pathup As String
    Dim filename As String
    Dim extension As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub
    Sub UpdateProgressBar(ByVal sender As Object, ByVal e As UploadProgressChangedEventArgs)
        PerplexProgressBar1.Value = e.ProgressPercentage
        If PerplexProgressBar1.Value = 100 Then
            MsgBox("Upload finis")
        End If
    End Sub



    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim client As New System.Net.WebClient()

        AddHandler client.UploadProgressChanged, AddressOf UpdateProgressBar

        With client
            Dim Separation As String = "|"
            Dim Elements As String() = Split(System.IO.File.ReadAllText(Application.StartupPath & "upload.config"), Separation)
            Dim user As String = Elements(1)
            Dim mdp As String = Elements(2)
            Dim hote As String = Elements(0)
            Dim repertftp As String = Elements(3)
            .Credentials = New NetworkCredential(user, mdp)

            .UploadFileAsync(New Uri("ftp://" & hote & repertftp & filename), pathup)
        End With

    End Sub
    Private Sub Form1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop


        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        filename = System.IO.Path.GetFileName(files(0))
        extension = System.IO.Path.GetExtension(files(0))

        If extension = ".swf" Then
            PictureBox1.Image = My.Resources.swf
        End If
        If File.Exists(Application.StartupPath & "upload.config") Then
            For Each path In files
                pathup = path
            Next
            Label1.Text = filename
            Label2.Text = pathup

            BackgroundWorker1.RunWorkerAsync()
        Else
            MsgBox("veuillez faire votre configurations!")
        End If
      
    End Sub
    Private Sub Form1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub PerplexProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerplexProgressBar1.Click

    End Sub

    Private Sub RadialBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PerplexControlBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sw As New StreamWriter(Application.StartupPath & "upload.config")
        sw.WriteLine(TextBox1.Text & "|" & TextBox2.Text & "|" & TextBox3.Text & "|" & TextBox4.Text & "|")
        sw.Close()
        MsgBox("Enregistrez!")
    End Sub
End Class