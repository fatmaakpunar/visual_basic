Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim veri, sayac, ort, k As Long
111:
        sayac = sayac + 1
        veri = Val(InputBox(sayac & " veri giriniz"))
        k = k + veri
        ListBox1.Items.Add(sayac & "veri= " & veri)
        If sayac < 5 Then GoTo 111
        ort = k / 5
        ListBox1.Items.Add("ortalama= " & ort)




    End Sub
End Class
