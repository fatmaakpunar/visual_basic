Public Class Form1
    Dim sayı As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '153 sayısı 1^3+5^3+3^3=27+125+1=153
        For yuzler = 1 To 9
            For onlar = 0 To 9
                For birler = 0 To 9
                    sayı = 100 * yuzler + 10 * onlar + birler
                    If sayı = yuzler ^ 3 + onlar ^ 3 + birler ^ 3 Then
                        ListBox1.Items.Add(sayı)

                    End If

                Next
            Next

        Next
    End Sub
End Class
