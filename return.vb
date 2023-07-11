Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, f, g As Integer
        Randomize()
        c = InputBox("hangi sayı bulunsun")
bas:    ListBox1.Items.Clear() : f = 0 : g = g + 1
        For a = 1 To 8
            b = Rnd() * 100
            If b = c Then
                f = f + 1 : ListBox1.Items.Add(b & "  " & f & ".sayı")
            Else
                ListBox1.Items.Add(b)

            End If
        Next
        If f <> 2 Then GoTo bas
        Button1.Text = g & ".dönüş"

    End Sub
End Class
