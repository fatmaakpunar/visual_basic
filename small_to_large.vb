Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '8 adet not üretelim her notun ismini girelim. nota göre küçükten büyüğe
        'sıralayalım isimlerde sıralanacak ve dizi işlemi 
        Dim a, b, c, f, tut As Integer
        Dim ad(10), ss, adtut As String
        Dim dizi(10) As Integer
        Randomize()
        ListBox1.Items.Clear()
        For a = 1 To 8
            dizi(a) = Rnd() * 100
            ad(a) = InputBox(a & " . adı girin")
            ListBox1.Items.Add(ad(a) & "=" & dizi(a))
        Next
        'karşılaştırmalı kısmı
        For b = 1 To 8
            For c = 1 To 8
                If dizi(b) < dizi(c) Then
                    'If ad(b) < ad(c) Then
                    tut = dizi(b) : adtut = ad(b)
                    dizi(b) = dizi(c) : ad(b) = ad(c)
                    dizi(c) = tut : ad(c) = adtut
                End If
            Next
        Next

        'yazdırma işlemi
        ListBox1.Items.Add("nota göre sıralanmış")
        For f = 1 To 8
            ListBox1.Items.Add(dizi(f) & "==" & ad(f))
        Next
    End Sub
End Class
