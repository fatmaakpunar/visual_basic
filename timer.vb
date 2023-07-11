Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a, b, c, d As Integer
        Randomize()
        a = Rnd() * 10
        ListBox1.Items.Add(a)
        If a = 10 Then Timer1.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval=1000
    End Sub
End Class
