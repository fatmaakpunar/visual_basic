Public Class Form1
    Dim cinsiyet, ask As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Strings.Trim(TextBox1.Text) <> "" And Strings.Trim(TextBox2.Text) <> "" And Strings.Trim(TextBox3.Text) <> "" Then


            If Strings.Trim(Strings.Len(TextBox3.Text)) <> 11 Then
                MsgBox("kimlik no uygun değil")
                Exit Sub
            End If
            ListBox1.Items.Add("adı soyadı:" + TextBox1.Text + " " + TextBox2.Text)
            ListBox1.Items.Add("kimlik no " + TextBox3.Text)
            If RadioButton1.Checked Then
                cinsiyet = " erkek"
            ElseIf RadioButton2.Checked Then
                cinsiyet = "kadın"

                ListBox1.Items.Add("cinsiyeti:" + cinsiyet)
            End If
            If RadioButton3.Checked Then
                ask = "yapmış"
            ElseIf RadioButton4.Checked Then
                ask = "muaf"
            Else
                ask = "tecilli"
            End If
            ListBox1.Items.Add("ask:" + ask)
        End If
        ListBox1.Items.Add("*************")
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "adı" : Label2.Text = "soyadı" : Label3.Text = "kimlik no"
        RadioButton1.Text = "erkek" : RadioButton2.Text = "kadın"
        RadioButton3.Text = "yapmış" : RadioButton4.Text = "muaf" : RadioButton5.Text = "tecilli"

    End Sub



    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        GroupBox2.Enabled = False 'askerlik durum kutusunu kapatıyoruz pasifize ettik
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        GroupBox2.Enabled = True 'erkek işlemi
    End Sub



End Class
