Public Class lectconfig
    Private Shared _Items As New Dictionary(Of String, String)
    Public Shared Function GetItem(ByVal Item As String) As String
        If _Items.ContainsKey(Item) Then Return _Items(Item)
        MsgBox("L'item " & Item & " est introuvable dans la configuration")
        Return ""
    End Function
    Public Shared Sub LoadConfig()
        Try
            Dim Reader As New IO.StreamReader("uploadup.config")
            While Not Reader.EndOfStream
                Dim Line As String = Reader.ReadLine
                If Not Line.Contains("=") Then Continue While
                Dim LigneInfos() As String = Line.Split("=".ToCharArray, 2)
                Dim Item As String = LigneInfos(0).ToUpper.Trim
                Dim Value As String = LigneInfos(1).Trim
                If Item = "" Then Continue While
                _Items.Add(Item, Value)
            End While
            Reader.Close()
        Catch ex As Exception
            MsgBox("Impossible de lire la configuration")
        End Try
    End Sub
End Class
