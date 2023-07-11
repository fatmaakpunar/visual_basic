Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1 5*5 lik matris olsun matrisin içinde istediğimiz sayıdan istediğimiz miktarda
        '2 değişken bloğu
        '3 rastgele üretim
        '4 aranılan sayı
        '5 aaranılan sayının miktarı
        ' 6 bas sayaçları sıfırla
        ' 7 satır ve sütun için döngü oluştur
        '8 matrisi rastgele oluştur
        '9 oluşturulan matriste aranılan sayı var mı
        '10 aranılan sayı istenilen miktrda yok ise başa git
        '11  aranılan sayı istenilen miktrda var ise bamiktarı bulsun
        '12 ekrana yazdır
        Dim i, j, k, m, a, b, s, mat(5, 5) As Integer
        Randomize()
say:    a = InputBox("hangi sayıyı arayalım 0-9 arası")
        If a < 0 Or a > 9 Then MsgBox("hatalı sayı") : GoTo say
l:      b = InputBox(a & "  sayısından kaç adet aranıyor")
        If b < 0 Or b >= 10 Then MsgBox("hatalı miktar seçimi") : GoTo l
        ' matris oluşumu,
ev:     s = 0 : TextBox1.Clear()
        For i = 1 To 5
            For j = 1 To 5
                mat(i, j) = Rnd() * 9
                TextBox1.Text = TextBox1.Text & mat(i, j) & " "
            Next
            TextBox1.Text = TextBox1.Text & Chr(13) & Chr(10)
        Next
        'veri hesaplaması
        For k = 1 To 5
            For m = 1 To 5
                If a = mat(k, m) Then s = s + 1

            Next
            If s <> b Then GoTo ev
        Next
    End Sub
End Class
