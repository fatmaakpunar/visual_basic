Public Class Form1
    Dim ort, stdsapma As Double
    Dim toplam1, toplam2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.text)
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        toplam1 = 0
        For k = 0 To ListBox1.Items.Count - 1
            toplam1 = toplam1 + ListBox1.Items(k)


        Next
        ort = toplam1 / ListBox1.Items.Count
        MsgBox(ort)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        toplam2 = 0
        For k = 0 To ListBox1.Items.Count - 1
            toplam2 = toplam2 + (ListBox1.Items(k) - ort) ^ 2
        Next
        stdsapma = Math.Sqrt(toplam2 / (ListBox1.Items.Count - 1))
        MsgBox(stdsapma)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class
