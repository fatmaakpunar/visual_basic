Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Long
        ListBox1.Items.Clear()
        b = InputBox("hangi sayıda duralım")
        Do
            a = a + 1
            ListBox1.Items.Add(a)
            If b = a Then Exit Do
        Loop


    End Sub
End Class
