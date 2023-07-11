Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '4 tek 2 çift sayı üretilsin başlangıcı ve sonu çift olsun bu işlem kaçıncı dönüşte bulunur.
        Dim a, b, c, d, f, t As Byte
        Randomize()
11:     ListBox1.Items.Clear() : c = 0 : t = 0
        d = d + 1
        For a = 1 To 6
            b = Rnd() * 100
            If a = 1 Then f = b
            If b Mod 2 = 0 Then
                c = c + 1
                ListBox1.Items.Add(b & " cift")
            Else
                t = t + 1
                ListBox1.Items.Add(b & " tek")
            End If
        Next
        If f Mod 2 <> 0 Or b Mod 2 <> 0 Then GoTo 11
        If t <> 4 Or c <> 2 Then GoTo 11
        Button1.Text = d & " . dönüşte bulundu"
    End Sub
End Class
