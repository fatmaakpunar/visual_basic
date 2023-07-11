Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '25 adet cevap anahtarı hazırlanacak ama e şıkkından 10 tane ya da istenilen m,ktar olsun diğer şıklar rastgele dağılsın
        'kontrol et
        'değişkenleri tanıttık
        '1-4 arası sayı üretcez diyelim 1 2 3 3    2 1 3 1  4 4 1 1  randomize olmasaydı sürekli aynı sayı gelme olasılığı yükselirdi
        'döngüyü aç
        'sayı üret a,b,c,d,e  0,1,2,3,4  kontrol 2 100 e kadar üret
        'her üretilen sayı için harf ataması yap 
        '3="d"  için  if s=3 then listbox.ıtrms.add("d") yazabiliriz
        'e şıkkı kontrol edilir ve sayaç konur
        'döngü kapatılır
        'sonuç bastırılır
        Dim a, b, v, f, g, j, k, l, m As Integer
        Randomize()
        ListBox1.Items.Clear()
        m = InputBox("kaç adet e harfinden veri üretilecek")
bb:     ListBox1.Items.Clear() : k = 0 : f = f + 1
        For b = 1 To 25
            a = Rnd() * 4
            If a = 0 Then
                ListBox1.Items.Add(b & ". veri a")
            ElseIf a = 1 Then
                ListBox1.Items.Add(b & ". veri  b")
            ElseIf a = 2 Then
                ListBox1.Items.Add(b & ". veri  c")
            ElseIf a = 3 Then
                ListBox1.Items.Add(b & ". veri  d")
            ElseIf a = 4 Then
                ListBox1.Items.Add(b & ". veri  e")
                k = k + 1
            End If
        Next
        If m <> k Then GoTo bb
        Button1.Text = f & ".dönüş"
       End Sub
End Class
