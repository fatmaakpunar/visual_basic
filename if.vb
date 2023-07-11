Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, k, t As Integer
        x = 10 : If x <> 10 Then k = 10 Else k = 8
        t = t + 1 : k = 3 : x = 4
        GoTo son
        x = 8
son:    MsgBox(k - x)
     


    End Sub
End Class
