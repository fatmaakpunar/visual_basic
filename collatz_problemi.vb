Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "ilk sayıyı giriniz"
        Label2.Text = "adım sayısı"
        Label3.Text = "en büyük değer"
    End Sub
    'collatz problemi
    'girilen sayı tamsayı olacak 
    'eğer çift ise bir sonraki sayının yarısı bulunacak 
    'tek ise  3 katının 1 fazlası alınacak
    ' oluşan listede sayı 1 olana dek döndrülecek
    Dim sayi, sayac, enb, k, b As Long
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sayi = TextBox1.Text
        ListBox1.Items.Clear()
        sayac = 0
        enb = 0
        Do
            sayac = sayac + 1
            ListBox1.Items.Add(sayac & ".sayı = " & sayi)
            If (sayi / 2) = Int(sayi / 2) Then
                sayi = sayi / 2
            Else
                sayi = sayi * 3 + 1

            End If
            If sayi > enb Then enb = sayi
            If sayi = 1 Then ListBox1.Items.Add(sayac + 1 & ".sayı = " & 1) : Exit Do 'döngüden çıkmak için bunu yapabiliriz


        Loop 'While sayi <> 1  döngüden çıkış yapar
        Label4.Text = sayac + 1 ' adım sayısını yazar 
        Label5.Text = enb ' en büyük sayıyı bulur
   End Sub
End Class
