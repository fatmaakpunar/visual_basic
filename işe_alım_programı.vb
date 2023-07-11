Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'üniversite mezunu 25 yaş üstü , 50 puan ve üstünü alan ilk 4 kişi için işe alım programı
        Dim b As String
        Static say As Integer
        If RadioButton1.Checked = True Then
            MsgBox("üzgünüz uygun değilsiniz")
        ElseIf RadioButton2.Checked Then
            MsgBox("üzgünüz uygun değilsiniz")
            'istenilen tercih aşağıda
        ElseIf RadioButton3.Checked Then
            'yaş için
            If RadioButton4.Checked Then
                MsgBox("üzgünüz uygun değilsiniz")
            ElseIf RadioButton5.Checked Then
                If Val(TextBox1.Text) > 49 Then
                    MsgBox("seçildiniz")
                    say = say + 1 : Button1.Text = (say)
                    b = InputBox("ad ve soyad  girin")
                    ListBox1.Items.Add(say & ". kişi " & b & "  " & TextBox1.Text)
                    TextBox1.Text = ""
                Else
                    MsgBox("üzgünüz puan yeterli değil")
                    If say = 4 Then MsgBox("sınav kapasıitesi dolmuştur.") : End 'end koymassak başka türlü program kapanmaz
                End If
            End If
        End If
    End Sub
End Class
