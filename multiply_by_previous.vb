Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'değişkenleri tanıt
        'text kutusuna atama yap
        'döngüyü aç
        'döngü atama yaptığımız değişkene kadar gitsin
        'mAT FORMÜLÜ YAZ
        'DÖNGÜYÜ KAPAT
        'sonucu text kutusana aktar
        'faktör işlemi 

        Dim a, b, faktor As Double
        a = TextBox1.Text
        faktor = 1
        For b = 1 To a
            faktor = faktor * b

        Next
        TextBox2.Text = faktor



    End Sub
End Class
