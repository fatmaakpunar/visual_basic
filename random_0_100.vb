Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '0 ile 100 arası rastgele üretilen sayıların tek olanlar bir kutuya çift olanlar bir kutuya aktarılsın
        Dim a, b, c, d, f, k As Byte
        d = 0 : f = 0 : ListBox1.Items.Clear() : ListBox2.Items.Clear()
        Randomize()
22:     a = InputBox("kaç adet veri üretilecek ")
        If a Mod 2 <> 0 Then
            k = k + 1

            MsgBox("girilen veri adedi çift olmalı")
            If k = 3 Then MsgBox("hakkın bitti") : End
            GoTo 22
        End If
11:     d = 0 : f = 0 : ListBox1.Items.Clear() : ListBox2.Items.Clear()

        For b = 1 To a
            c = Rnd() * 100
            'tek bulma işlemi

            'If c / 2 <> Int(c / 2) Then İNT KULLANILARAK YAPILAN İŞLEM
            If c Mod 2 <> 0 Then

                ListBox1.Items.Add(c)
                d = d + 1
            Else
                'çift sayılar
                ListBox2.Items.Add(c)
                f = f + 1

            End If
        Next
        Label1.Text = d : Label2.Text = f


    End Sub
End Class
