Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'klavyeden girilen matris verilerinin toplamını bulma
        'değişkenleri tanıt dim m(5,5) as integer
        'hatırlatma matris olduğu için 2 boyut hatırlanmalı satır ve sütun
        ' satırı gir
        'sütunu gir
        ' m(sat,sut) m(k,j) =veri girişi
        'text kutusuna yerleştir
        'matris verilerini topla
        'sütunun döngüsünü kapat
        'text kutusuna yerleştir & satır atlat chr(13) & chr(10)
        'satır döngüsünü kapat
        'buton üzerine toplamı yazdır
        Dim m(5, 5), i, j, k, l, top As Integer
        top = 0
        TextBox1.Text = ""
        For k = 1 To 5 'satır
            For j = 1 To 5 'sütun
                m(k, j) = InputBox(k & ". satırın " & j & ". sütun verisini giriniz")
                top = top + m(k, j)
                TextBox1.Text = TextBox1.Text & m(k, j) & " "
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
            Button1.Text = "matris toplamı=" & " " & top
        Next
    End Sub
End Class
