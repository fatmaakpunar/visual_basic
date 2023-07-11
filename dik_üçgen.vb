Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'dik üçgenin c^2 =a^2+b^2 işlemini sağlayan 1ile 99 arası kaç adet veri var
        Dim say As Integer
        ListBox1.Items.Add("c=  " & "a=  " & "b=  ")
        For a = 1 To 99
            For b = 1 To 99
                For c = 1 To 99
                    If (c ^ 2 = a ^ 2 + b ^ 2) And (a < b) Then



                        ListBox1.Items.Add(c & "   " & a & "    " & b)
                        ListBox1.Items.Add("-------------------")
                        ListBox1.Items.Add(c * c & "  " & a * a & "  " & b * b)
                        say = say + 1

                    End If

                Next c
            Next b

        Next a
        Button1.Text = "kurala uyan veri sayısı " & say
        'MsgBox ("c=" & c) c stepden dolayı 1 eklenir ve 100 çıkar.
    End Sub
End Class
