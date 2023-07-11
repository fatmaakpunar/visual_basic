Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Byte
        For a = 1 To 5 Step 2
            If a <> 2 Then GoTo son
            ListBox1.Items.Add(a)

        Next
        b = a
son:    Button1.Text = "b=" & b

    End Sub
End Class
