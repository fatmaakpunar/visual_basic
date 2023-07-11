Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(), n, i As Integer
        n = Val(InputBox("n değerini giriniz"))
        ReDim a(n)
        ListBox1.Items.Add("A dizisi")
        For i = 1 To n
            a(i) = Val(InputBox("A dizisinin" & i & ".elemanı"))
            ListBox1.Items.Add(a(i) & " ")

        Next
        ListBox1.Items.Add("a dizisinin sıralı hali")
        Array.Sort(a)
        For i = 1 To n
            ListBox1.Items.Add(a(i) & " ")
        Next
    End Sub
End Class
