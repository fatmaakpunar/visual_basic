Public Class Form1
    'sınavda böyle çıkar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "erkek"
        RadioButton2.Text = "kadın"
        RadioButton3.Text = "evli"
        RadioButton4.Text = "bekar"

    End Sub
    Dim a, b, c As Byte
    Dim cins, med As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 2
        If RadioButton1.Checked = True Then
            cins = "erkek"
        Else
            cins = "kadın"

        End If
        If RadioButton3.Checked = True Then
            med = "evli"
        Else
            med = "bekar"

        End If
        MsgBox("siz " & a & " " & med & " " & cins & "sınız")
    End Sub
End Class
