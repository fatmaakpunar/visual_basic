Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'rastgele 5*5 matris için 0 ile 9 arası sayı üret ilk enbüyük matris
        'değerini satır ve sütun olarak bulun son eleman 0 olsun
        Dim m(5, 5), i, j, k, l, n, s, eb, t As Integer
        Randomize()
ev:     eb = 0 : s = 0 : t = 0 : TextBox1.Clear()
        For i = 1 To 5
            For j = 1 To 5
                m(i, j) = Rnd() * 9
                If m(i, j) > eb Then eb = m(i, j) : s = i : t = j
                TextBox1.Text = TextBox1.Text & " " & m(i, j)
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        If m(5, 5) <> 0 Then GoTo ev 'i vej for döngülerinden dolayı m(i,j) yazarsak 6,6 lık dizi olur o yüzden m(5,5) yazarız
        Button1.Text = "en büyük değer=" & eb & "satır=" & s & "sütun=" & t
    End Sub
End Class
