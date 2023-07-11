Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "ürün fiyatı"
        Label2.Text = "ürün adedi"
        Label3.Text = "tutar"
        RadioButton1.Text = "beyaz eşya"
        RadioButton2.Text = "gıda"
        RadioButton3.Text = "giyim"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 1.25
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 1.18
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 1.12

        End If
    End Sub
End Class
