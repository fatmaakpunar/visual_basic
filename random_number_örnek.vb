Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, eb, ek, ist As Integer
        eb = 0 : ek = 100
        Randomize()
        ist = InputBox("0-100 arası hangi sayı 8 sayı içinde yer alsın")
bas:    ListBox1.Items.Clear() : c = 0 : eb = 0 : ek = 100
        For a = 1 To 8
            b = Rnd() *100
            ListBox1.Items.Add(b)
            If ist = b Then c = 1 'istenilen sayı üretildiyse c 1 olarak alındı
            If b > eb Then eb = b : f = a
            If b < ek Then ek = b : d = a
        Next
        If c <> 1 Then GoTo bas ' c=1  değilse bas a döner çünkü istediğimiz sayı alınmamıştır
        Button1.Text = "ENB=" & eb & " YERİ=" & f & "  ENKÜÇÜK=" & ek & " YERİ=" & d






    End Sub
End Class
