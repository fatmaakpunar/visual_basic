Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then 'metin kutusu boşsa
            MsgBox("basmayın denilmişti")
            Button1.BackColor = Color.Red 'buton kırmızı olur kişi butona bastıysa
        Else
            Button1.BackColor = Color.GreenYellow 'değilse yeşil olur

        End If
    End Sub
End Class
