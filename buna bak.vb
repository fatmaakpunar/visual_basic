Public Class Form1
    Dim A, B, C As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = 12
        B = 7
        MsgBox("a=" & A & "b=" & B & "c=" & C)
        'MsgBox("a=", A & "b=", B)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = 8 : B = 14 : C = 9
    End Sub
End Class
