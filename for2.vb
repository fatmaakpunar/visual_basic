Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Integer
        For a = 1 To 1 Step -2 'a=1
            ' If a <> 2 Then GoTo son
            ListBox1.Items.Add(a) 'a nın değerini listboxa yazdır listboxta 1 yazar

        Next
        b = a 'b=1
        c = d 'c=0 d=0
        b = a 'b=1 a=1
son:    Button1.Text = "c=" & c ' cyi butona yazdır butonda c=0 yazar
    End Sub
End Class
