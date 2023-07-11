Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Byte
        Static d, s As Byte 'sınavda böyle bir şey yazmayın dedi hoca
        s = s + 1
        a = InputBox(s & ".veriyi gir")
        d = d + a
        ListBox1.Items.Add(a)
        Button1.Text = "girilen " & s & " adet sayı toplamı=" & d


    End Sub
End Class
