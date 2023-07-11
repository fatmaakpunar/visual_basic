Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Byte 'a=0
        For a = 1 To 5 Step 2 'a=1 oldu
            If a <> 2 Then Exit For 'a eşit değilse 2 ye döngüden çık a=1 olduğu için döngüden çıkar

            ListBox1.Items.Add(a)

        Next 'a=1
        b = a 'a=b den bde 1 oldu
son:    Button1.Text = "b=" & b 'b yi butona yazdır butonda b=1 yazar
    End Sub
End Class
