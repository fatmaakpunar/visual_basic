Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Byte
        a = InputBox("ortalamanızı girin")
        If a < 40 Then
            ListBox1.Items.Add(a & " =FF")
        ElseIf a < 56 Then
            ListBox1.Items.Add(a & " =CC")
        ElseIf a < 66 Then
            ListBox1.Items.Add(a & " =BC")
        ElseIf a < 73 Then
            ListBox1.Items.Add(a & " =BB")
        ElseIf a < 83 Then
            ListBox1.Items.Add(a & " =BA")
        Else
            ListBox1.Items.Add(a & " =AA")

        End If
    End Sub
End Class
