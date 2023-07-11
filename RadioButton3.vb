Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cins, med As String
        Dim ad, top As Integer
        ad = 4
        ad = top
        If RadioButton1.Checked = True Then
            cins = " erkek"

        ElseIf RadioButton2.Checked = True Then
            cins = "kadın"
            ad = 100

        End If
        If RadioButton3.Checked = True Then
            med = "evli"
        Else
            med = "bekar"
        End If
        ad = 77
        Button1.Text = ad & " " & "sözlü" & " " & cins & " " & med
    End Sub
End Class
