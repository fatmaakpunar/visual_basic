Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sayi1, sayi2, toplam, x As Long
        sayi1 = TextBox1.Text
        toplam = 0
        For x = 2 To sayi1 / 2
            If sayi1 Mod x = 0 Then toplam = toplam + x
        Next
        If toplam + 1 = sayi1 Then
            MsgBox("mükemmel sayı")
        Else
            sayi2 = sayi1
            Do
                toplam = 0
                sayi2 = sayi2 + 1
                For x = 2 To sayi2 / 2
                    If sayi2 Mod x = 0 Then toplam = toplam + x
                Next
            Loop Until toplam + 1 = sayi2
            MsgBox(sayi2)
        End If
    End Sub
End Class
