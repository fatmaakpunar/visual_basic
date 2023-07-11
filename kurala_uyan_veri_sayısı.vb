Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim say, c As Integer
        c = 20
        For c = 0 To 99
            ListBox1.Items.Add("-----------------")
            ListBox1.Items.Add(c * c)
            say = say + 1
            If c <> 2 Then GoTo son

        Next c
son:    Button1.Text = "kurala uyan veri sayısı" & say 'say=0
        MsgBox("c=" & c) REM c=

    End Sub
End Class
