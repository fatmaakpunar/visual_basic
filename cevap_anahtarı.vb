Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '10 kişilik öğrenci grubu için cevap anahtarı oluşturulmuş soru  cevapları
        'rastgele üretilecektir toplamda 8 soru sorulmuş sorular a,b,c,d,,e şıklarıyla çoktan seçmeeli
        Dim cevap(10), soru(10) As String
        Dim a, b, c, d, f, g, h, k, l, m, n As Integer
        cevap(1) = "a" : cevap(2) = "c" : cevap(3) = "d" : cevap(4) = "b" : cevap(5) = "e"
        cevap(6) = "e" : cevap(7) = "a" : cevap(8) = "b"
        Randomize()
        For n = 1 To 10
            'bir kişinin 8 adet sorusu için işlem
            For i = 1 To 8
                m = Rnd() * 4
                If m = 0 Then soru(i) = "a"
                If m = 1 Then soru(i) = "b"
                If m = 2 Then soru(i) = "c"
                If m = 3 Then soru(i) = "d"
                If m = 4 Then soru(i) = "e"
            Next
            'cevaplar hazırlanıyor 
            ListBox1.Items.Add(n & ". kişi cevapları      cevap anahtarı")
            a = 0
            For j = 1 To 8
                ListBox1.Items.Add(j & ". sorunun cevap anahtarı" & soru(j) & "  " & cevap(j))
                If (soru(j) = cevap(j)) Then a = a + 1 : ListBox1.Items.Add("*********")

            Next
            ListBox1.Items.Add("______________________")
            ListBox1.Items.Add(n & ". kişinin cevabı =" & a)
            ListBox1.Items.Add("______________________")



        Next
    End Sub
End Class
