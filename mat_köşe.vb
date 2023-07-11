Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '5*5 lik matrisisn köşegen toplamlarını bulalım
        Dim d, h, t, mat(5, 5) As Integer
        Randomize()
ev:     t = 0 : d = 0 : TextBox1.Clear() : h = h + 1
        For i = 1 To 5
            For j = 1 To 5
                mat(i, j) = Rnd() * 9
                TextBox1.Text = TextBox1.Text & mat(i, j) & " "
                If i = j Then d = d + mat(i, j)
                If i + j = 6 Then t = t + mat(i, j)
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        Button1.Text = " düzgün köşegen " & d & " ters köşegen=" & t
        If t <> d Then GoTo ev
        Me.Text = h & " . dönüşte bulundu"
    End Sub
End Class
