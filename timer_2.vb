Public Class Form1
    Dim a, b, c, d, f, g As Byte
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'rastgele üretilen 0-10 arası sayıların toplamı 50 ve üstü olduğunda işlem dursun bu işlemi kaçıncı dönüşte buluruz
        Randomize()
        Timer1.Interval = 800
        a = Rnd() * 10
        b = b + 1
        c = c + a
        ListBox1.Items.Add(a)
        If c >= 50 Then Timer1.Enabled = False
        Button1.Text = b & "adet sayı toplamı" & c

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
