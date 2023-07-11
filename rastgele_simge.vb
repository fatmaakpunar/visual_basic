Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, d, f, s As Integer
        Dim c As String
        Randomize()

        REM Do While f <> 4
bas:

        f = 0

        s = s + 1
        ListBox1.Items.Add(s & ".dönüş*******")
        For a = 1 To 4
            b = Rnd() * 3
            '  If b = 0 Then ListBox1.Items.Add("*")
            ' If b = 1 Then ListBox1.Items.Add("+")
            'If b = 2 Then ListBox1.Items.Add("?") : f = f + 1
            'If b = 3 Then ListBox1.Items.Add("&")
            If b = 0 Then c = "*"
            If b = 1 Then c = "+"
            If b = 2 Then c = "?" : f = f + 1
            If b = 3 Then c = "&"
            ListBox1.Items.Add(c)

        Next
        REM   Loop
        If f <> 4 Then GoTo bas
        Button1.Text = s & ".dönüş"
    End Sub
End Class
