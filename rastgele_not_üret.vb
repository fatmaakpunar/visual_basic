Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z, t, i, etop, btop As Integer
        Dim cins As String
        Randomize()
        x = InputBox("kaç adet veri girilecek")
        For y = 1 To x
11:         cins = InputBox(y & ".cinsiyeti girin E ya da K şeklinde")
            If cins <> "E" And cins <> "K" Then MsgBox("lütfen E ya da K şeklinde  giriniz") : GoTo 11
            'If cins <> "K" Then MsgBox("lütfen E ya da K şeklinde  giriniz") : GoTo 11
            z = Rnd() * 100
            ListBox1.Items.Add(cins & "=" & z)
            If cins = "E" Then etop = etop + z
            If cins = "K" Then btop = btop + z
        Next
        If etop > btop Then
            MsgBox("erkek ogr not toplamı= " & etop & ">" & "bayan ogr not toplamı= " & btop)
        Else
            MsgBox("erkek ogr not toplamı= " & etop & "<" & "bayan ogr not toplamı= " & btop)
        End If
    End Sub
End Class
