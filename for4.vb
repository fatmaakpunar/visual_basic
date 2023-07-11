Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Byte
        For a = 1 To 5 'Step 3 yazarsak 1 den başlayıp sayıların üstüne 3 ekleyerek 5 e kadar gider button kodundan dolayı buttonada en son satırdaki sayıya 3 ekleyerek yazar.
            ListBox1.Items.Add(a)

        Next
        Button1.Text = a 'sonuna bunu eklersek gizli step 1 olduğu için buttonda 6 yazar.

    End Sub
End Class
