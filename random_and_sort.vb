Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, enk, enb, yb, yk As Byte
        Randomize()
bas:    ListBox1.Items.Clear()
        enb = 0 : enk = 100
        For a = 1 To 8
            b = Rnd() * 100
            If b > enb Then enb = b : yb = a 'en büyük bulunuyor
            If b < enk Then enk = b : yk = a 'en küçük bulunuyor
            ListBox1.Items.Add(b)


        Next
        If yk <> 1 Then GoTo bas
        If yb <> 8 Then GoTo bas
        Button1.Text = "en büyük=" & enb & "  en küçük=" & enk
    End Sub
End Class
