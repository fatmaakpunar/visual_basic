Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'istenilen miktarda 0 -100 arası sayı üret 1. ve sonuncu sayı aynı olsun
        'içlerinden biri benim istediğim sayı olacak
        '2 adet 100 sayısı üretilsin 
        Dim a, b, c, d, sec, t, k, say As Integer
        Randomize()
10:     sec = InputBox("kaç adet sayı üretilecek")
        If sec > 100 Or sec < 4 Then MsgBox("4-100 arası sayı giriniz") : GoTo 10
11:     a = InputBox("hangi sayı listede yer alsın")
        If a > 100 Or a < 0 Then MsgBox("0-100 arası sayı giriniz") : GoTo 11
13:     ListBox1.Items.Clear() : say = say + 1 : k = 0 : t = 0
        For b = 1 To sec
            c = Rnd() * 100
            ListBox1.Items.Add(c)
            If b = 1 Then d = c 'birinci sayıyı bulmak için yapıldı
            If a = c Then t = 1
            If c = 100 Then k = k + 1
        Next
        If d <> c Then GoTo 13
        If t <> 1 Then GoTo 13 ' sıfıra eşit değilse istediğim sayıyı bulamamışım bunu kontrol eder 
        'If k <> 2 Then GoTo 13
        Button1.Text = say & ". dönüşte işlemeler gerçekleşti"

    End Sub
End Class
