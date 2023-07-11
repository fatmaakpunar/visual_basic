Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'dizilerde sıralama
        Dim a, b, c, d, f, g, h, tut As Integer
        Dim dizi(10) As Integer
        Randomize()
        '6 tane 1 ile 10 arasında sayı üretelim bunları sıralayalım
        ' küçükten büyüğe sırala
bas:    ListBox1.Items.Clear()

        For a = 1 To 6 ' to 10 olursa taşma olur çünkü başa yollarken dizi 0 lanmaz bi süre sonra sayıları tutamaz
            ' hale gelir sınırda 10 olduğundan taşma olur mesela sınır yani dizi(100) olsaydı taşma olmazdı
            dizi(a) = Rnd() * 9 + 1
            ListBox1.Items.Add(dizi(a))
        Next
        'karşılaştırma
        For b = 1 To 6
            For c = 1 To 6
                If dizi(b) < dizi(c) Then
                    tut = dizi(b)
                    dizi(b) = dizi(c)
                    dizi(c) = tut
                End If
            Next
        Next
        'yazdırma
        'eğer aynı veriler üretildiyse işlem başa dönsün ve tekrar üretsin
        ListBox1.Items.Add("kü. bü. sıralanmış")
        For d = 1 To 6
            If dizi(d) = dizi(d + 1) Then
                GoTo bas
            Else
                ListBox1.Items.Add(dizi(d))
            End If
            'MsgBox (dizi(d))
            'MsgBox (dizi(d+1))'içine +1 ekledik
            ' MsgBox(dizi(d) + 1) 'dışına +1 ekledik
        Next


    End Sub
End Class
