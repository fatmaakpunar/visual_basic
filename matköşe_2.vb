Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, f, t, d, mat(5, 5) As Integer
        Randomize()
g:      f = InputBox("düzgün köşegende aranan sayıyı giriniz")
        If f < 0 Or f > 9 Then MsgBox("hatalı giriş 0-9 arası girin") : GoTo g
        t = InputBox(f & "sayısı için adet girin")
12:     If t < 0 Or t > 5 Then MsgBox("hatalı giriş 0-5 arası girin") : GoTo 12
ev:     TextBox1.Clear() : c = 0 : d = d + 1
        For a = 1 To 5
            For b = 1 To 5
                mat(a, b) = Rnd() * 9
                TextBox1.Text = TextBox1.Text & mat(a, b) & " "
                If a = b Then
                    If f = mat(a, b) Then c = c + 1
                End If
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        If c <> t Then GoTo ev
        Me.Text = d & ". dönüş"
    End Sub
End Class
