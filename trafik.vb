Public Class Form1

    'trafik akış
    Dim sayac As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        sayac = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sayac = sayac + 1
        If sayac > 45 Then sayac = 0
        Select Case sayac
            Case 0 To 20 : Button1.BackColor = Color.Red
                Button2.BackColor = Color.Empty
                Button3.BackColor = Color.Empty
                GroupBox1.Text = "DUR"
                Button1.Text = 20 - sayac
                Button2.Text = " "
                Button3.Text = " "
            Case 21 To 32 : Button2.BackColor = Color.Yellow
                Button1.BackColor = Color.Empty
                Button3.BackColor = Color.Empty
                GroupBox1.Text = "BEKLE"
                Button2.Text = 32 - sayac
                Button1.Text = " "
                Button3.Text = " "
            Case 33 To 50 : Button3.BackColor = Color.Green
                Button1.BackColor = Color.Empty
                Button2.BackColor = Color.Empty
                GroupBox1.Text = "GEÇ"
                Button3.Text = 50 - sayac
                Button1.Text = " "
                Button2.Text = " "
        End Select
    End Sub
End Class
