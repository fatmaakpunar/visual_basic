Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a(6, 6) As Byte
        Dim b, c, d, f, g, h As Byte
        Randomize()
        For b = 1 To 6
            For c = 1 To 6
                a(b, c) = Rnd() * 9
                d = d + a(b, c)
                TextBox1.Text = TextBox1.Text & a(b, c) & "  "
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        Timer1.Enabled = False
        Me.Text = "matris toplamı " & d
    End Sub
End Class
