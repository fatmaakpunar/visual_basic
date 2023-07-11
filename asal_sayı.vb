Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "sayıyı giriniz"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asalmi As Boolean = True
        Dim say As UInt64 'en büyük tam sayı türü
        For say = 2 To TextBox1.Text / 2 'sayının yarısına kadar bölen araştırılıyor
            If TextBox1.Text Mod say = 0 Then 'eğer tam bölünüyorsa
                asalmi = False 'bölünüyorsa asal sayı değildir o yüzden false
                Exit For 'bakmaya gerek yok
            End If
        Next
        If asalmi = True Then ' demek ki yukarıdaki koşula hiç girmemiş
            MsgBox(TextBox1.Text & "asaldır")
        Else
            MsgBox(TextBox1.Text & " asal değildir" & " " & say & " bu sayıyı böler")
        End If


    End Sub
End Class
