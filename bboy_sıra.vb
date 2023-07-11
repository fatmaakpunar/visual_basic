Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim say(10) As Integer
        Dim ortalama As Integer
        Dim toplam As Integer
        Dim orta As Integer
        Dim bboy, kboy As Integer
        Randomize()
        For i = 1 To 10
            say(i) = Rnd() * 140 + 100 '140 ile 100 metre arası boylar  araştırıldı
            ListBox1.Items.Add(say(i))
            toplam = toplam + say(i)


        Next
    End Sub
End Class
