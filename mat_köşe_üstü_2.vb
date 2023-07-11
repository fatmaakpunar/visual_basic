Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m(5, 5), a, b, c, d, f, g, h, t As Integer
        Randomize()
        'kare matrisin köşe üstü veri aritmetik toplamını bulma
        t = 0 : TextBox1.Clear()
        ListBox1.Items.Add("köşegen üstü veriler")
        For a = 1 To 5
            For b = 1 To 5
                m(a, b) = Rnd() * 9
                TextBox1.Text = TextBox1.Text & m(a, b) & "  "
                If a < b Then t = t + m(a, b) : ListBox1.Items.Add(m(a, b))
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        Button1.Text = "düzgün köşegen üstü toplamı= " & t
    End Sub
End Class
