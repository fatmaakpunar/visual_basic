Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Byte
        Dim f(10) As Byte
        Randomize()
ev:     ComboBox1.Items.Clear() : d = d + 1
        For i = 1 To 4
            f(i) = Rnd() * 100
            ComboBox1.Items.Add(f(i))
            'if i=1 then c=f(i) dizi olmasaydı böyle yapardık
        Next
        If f(4) <> 100 And f(1) <> 100 Then GoTo ev
        Button1.Text = d & ". dönüş " & f(4)
    End Sub
End Class
