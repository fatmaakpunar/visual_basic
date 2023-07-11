Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "1. buton"
        RadioButton2.Text = "2. buton"
        RadioButton3.Text = "3. buton"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then 'mutlaka end if veya yanına birşey ister önemli
            MsgBox("1. kutu işaretlendi")
        ElseIf RadioButton2.Checked = True Then
            MsgBox("2. kutu işaretlendi")
        ElseIf RadioButton3.Checked = True Then
            MsgBox("3. kutu işaretlendi")
        End If
    End Sub
End Class
