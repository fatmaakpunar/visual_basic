Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, f As Integer
        Randomize()

        ListBox1.Items.Clear()
        Do While a < 10

            a = a + 1
            b = Rnd() * 100
            ListBox1.Items.Add(a & ".sayı=" & b)
        Loop
        Button1.Text = b * f
        'eklenecek yerler var 17 mart birinci derslerin sonuna doğru

    End Sub
End Class
