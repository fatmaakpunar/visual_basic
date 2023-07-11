Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Byte
basla:
        a = InputBox("SAYIYI GİR")
        If a = 0 Then GoTo basla

        If a Mod 2 = 0 Then
            ListBox1.Items.Add(a & " =çift")
        Else
            ListBox1.Items.Add(a & " =tek")

        End If
    End Sub
End Class
