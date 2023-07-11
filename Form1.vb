Public Class Form1
    Public a, b, c As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 12
        b = 7
        MsgBox("a=" & a & "b=" & b & "c=" & c)
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = 8
        b = 14
        c = 9
    End Sub
End Class
