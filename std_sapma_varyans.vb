Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, n, d As Integer
        Dim ortalama, varyans, sapma As Single 'ondalıklı değer
        Dim toplam1, toplam2, x(100) As Single
        Randomize()
n101:   n = InputBox("kaç adet veri üretileck")
        If n > 100 Or n < 1 Then GoTo n101
ev:     ListBox1.Items.Clear()
        toplam1 = 0
        For i = 1 To n
            x(i) = CInt(Rnd() * 100)
            ListBox1.Items.Add(x(i))
            toplam1 = toplam1 + x(i)
            If x(i) = 100 Then d = 1
        Next
        If d <> 1 Then GoTo ev
        ortalama = toplam1 / (n - 1)
        Me.Text = "ortalama" & ortalama
        'her bir terimin ortalamadan olan farklarını bulalım 
        toplam2 = 0
        For j = 1 To n
            toplam2 = toplam2 + (x(j) - ortalama) ^ 2

        Next
        '****************************************
        varyans = toplam2 / (n - 1)
        sapma = (varyans) ^ 0.5
        Button1.Text = ("varyans=" & varyans & "   " & " s.sapma=" & sapma)

        If sapma > 40 Then GoTo ev

    End Sub
End Class
