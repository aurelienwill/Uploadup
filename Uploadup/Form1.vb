Imports System.Net
Imports System.IO

Public Class Form1
    Dim pathup As String
    Dim filename As String
    Dim extension As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lectconfig.LoadConfig()
        Me.CenterToScreen()
        Me.AllowDrop = True
        Label1.Text = String.Empty
        Label2.Text = String.Empty
        If Not File.Exists("Uploadup.config") Then
            config.Show()
            config.TopMost = True
        End If
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
            Dim user As String = lectconfig.GetItem("USER")
            Dim mdp As String = lectconfig.GetItem("MDP")
            Dim hote As String = lectconfig.GetItem("HOTE")
            Dim repertftp As String = TextBox4.Text
            .Credentials = New NetworkCredential(user, mdp)
            MsgBox(filename)
            .UploadFileAsync(New Uri("ftp://" & hote & repertftp & filename), pathup)
        End With

    End Sub
    Private Sub Form1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        filename = System.IO.Path.GetFileName(files(0))
        TextBox1.Text = filename
        extension = System.IO.Path.GetExtension(files(0))
        If extension = ".swf" Then
            PictureBox1.Image = My.Resources.swf
        Else
            PictureBox1.Image = My.Resources.unknow
        End If
        If File.Exists("Uploadup.config") Then
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
    Private Sub PerplexButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerplexButton2.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "C:\Users\" & Environment.UserName & "\Desktop\"
        openFileDialog1.Filter = "All files (*.*)|*.*"
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.ShowDialog()
        TextBox1.Text = openFileDialog1.SafeFileName
        pathup = openFileDialog1.FileName
        Label1.Text = filename
        Label2.Text = pathup
        If extension = ".swf" Then
            PictureBox1.Image = My.Resources.swf
        Else
            PictureBox1.Image = My.Resources.unknow
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        filename = TextBox1.Text
    End Sub

    Private Sub PerplexButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerplexButton1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class