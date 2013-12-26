Imports System.IO

Public Class config

    Private Sub PerplexButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerplexButton1.Click
        Dim sw As New StreamWriter("uploadup.config")
        sw.WriteLine("HOTE=" & TextBox1.Text & Environment.NewLine & "MDP=" & TextBox2.Text & Environment.NewLine & "USER=" & TextBox3.Text)
        sw.Close()
        MsgBox("Enregistrez!")
        lectconfig.LoadConfig()
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class