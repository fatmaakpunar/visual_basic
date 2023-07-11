Public Class Form1

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a, b, c, d As Integer
        Dim f(10) As Integer
        Randomize()
ev:     ComboBox1.Items.Clear() : d = d + 1
        For i = 1 To 4
            f(i) = Rnd() * 100
            ComboBox1.Items.Add(f(i))
            'if i=1 then c=f(i)

        Next
        If f(4) <> 100 And f(1) <> 100 Then GoTo ev
        Button1.Text = d & ". dönüş " & f(4)
        'dönüş 300 den küçükse çalışsın
        If d >= 300 Then Timer1.Enabled = False
    End Sub
End Class
