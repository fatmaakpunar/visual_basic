Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 9
            For j = 0 To 9
                For k = 0 To 9
                    ListBox1.Items.Add(i & j & k)
                    TextBox3.Text = k
                    TextBox2.Text = j
                    TextBox1.Text = i
                    TextBox3.Refresh()
                    TextBox2.Refresh()
                    TextBox1.Refresh()
                    System.Threading.Thread.Sleep(10)


                Next
            Next
        Next
    End Sub
End Class
