Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Integer
        Randomize()
        ListBox1.Items.Clear()
        Do While a < 10
            a = a + 1
            b = Rnd() * 1
            If b = 0 Then
                ListBox1.Items.Add("erkek")
                c = c + 1
            Else
                d = d + 1
                ListBox1.Items.Add("kadın")
            End If
        Loop
        Button1.Text = "kadın sayısı=% " & (d / 10) * 100 & "erkek sayısı=% " & (c / 10) * 100
    End Sub
End Class
