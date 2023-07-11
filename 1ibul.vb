Public Class Form1

    
    'globa kısmın formun her yerinde tanıtır
    Dim sayi, sayac, enbuyuk As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'değişkenleri tanıt
        'veri gir
        'en büyük veriyi ata
        'DÖNGÜYÜ AÇ
        'sayacı çalıştır
        'liste kutusuna sayıyı ekle
        'eğer sayı çift ise yarıya böl
        'eğer sayı çift ise sayı*3+1
        'sayacı çalıştır
        'en büyük sayıyı bul
        'döngü kapanması için 1 olma şartını koy
        'adımsayısını yazdır
        'en büyüğü yazdır 
        sayi = TextBox1.Text
        ListBox1.Items.Clear()
        enbuyuk = 0 : sayac = 0
        Do
            ListBox1.Items.Add(sayi)
            If sayi Mod 2 = 0 Then
                sayi = sayi / 2
            Else
                sayi = sayi * 3 + 1

            End If
            sayac = sayac + 1
            ListBox1.Items.Add(sayac & ".adım*******")
            If sayi > enbuyuk Then enbuyuk = sayi
        Loop While sayi <> 1
        ListBox1.Items.Add(1)
        Label3.Text = sayac + 1
        ListBox1.Items.Add(sayac + 1 & ".adım*******")
        Label5.Text = enbuyuk
    End Sub
End Class


