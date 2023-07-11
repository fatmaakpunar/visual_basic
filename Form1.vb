Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 8 adet sayı üret 
        'en büyük ve en küçük bulunsun aradaki fark 50 olsun
        ' değişkenleri tanıt
        'bas etiketi
        'tanımlama yap
        'döngüyü aç
        ' sayı üret
        'enb enk bulunsun
        'döngüyü kapat
        'farkı kontrol et 
        'doğru değilse başa git
        'yazdır
        Dim a, b, f As Integer
        Dim enk, enb, t As Integer
sec:    f = InputBox("en küçük ile en büyük arasındaki farkı girin 40 ile 100 arası")
        If f < 40 Or f > 100 Then GoTo sec
bas:    ListBox1.Items.Clear()
        enb = 0 : enk = 100
        t = t + 1
        ListBox1.Items.Add(t & ".dönüşte bulundu")
        For a = 1 To 8
            b = Rnd() * 100
            ListBox1.Items.Add(b)
            If b < enk Then enk = b
            If b > enb Then enb = b
        Next
        If (enb - enk <> f) Then GoTo bas
        ListBox1.Items.Add("enk= " & enk & " enb=" & enb)
    End Sub
End Class
