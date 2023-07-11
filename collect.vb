Public Class Form1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        TextBox3.Text = Val(TextBox1.Text) + TextBox2.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
