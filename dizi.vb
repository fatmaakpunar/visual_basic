Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '2  boyutlu diziler 
        Dim m(4, 4) As Integer
        Dim a, b, n, h, k, i, t As Integer
        Randomize()
        For k = 1 To 4
            For i = 1 To 4
                m(k, i) = Rnd() * 9
                TextBox1.Text = TextBox1.Text & m(k, i) & " "
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
    End Sub
End Class
