Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, f, g, t, v(20) As Integer
        Randomize()
bas:    ListBox1.Items.Clear() : g = g + 1
        For a = 1 To 6
            v(a) = Rnd() * 5 + 1
            ListBox1.Items.Add(v(a))
            'karşılaştırma
            ListBox1.Items.Add("sıralı liste ")
        Next
        For b = 1 To 6
            For c = 1 To 6
                If v(b) < v(c) Then
                    t = v(b)
                    v(b) = v(c)
                    v(c) = t

                End If
            Next
        Next
        'yazdırma kısmı
        For f = 1 To 6
            If v(f) = v(f + 1) Then
                GoTo bas
            Else
                ListBox1.Items.Add(v(f))
            End If

        Next
        Button1.Text = "dönüş sayısı = " & g


    End Sub
End Class
