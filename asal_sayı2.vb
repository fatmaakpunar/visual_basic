Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        For i = 2 To 9000        '1 den 9000 ye kadar asal sayılar'
            For b = 2 To i - 1 'b=2 ile o anki i-1 arasındaki sayılar 
                If i Mod b = 0 Then 'i sayısı b ye bölünüyor mu?
                    a = 1 'bölünüyorsa a=1 yani asal değil 
                End If
            Next
            If a = 1 Then ' a=1 ise 
                a = 0 ' a yı sıfırlar ve döngüden çıkar
            Else
                ListBox1.Items.Add(i) ' a=1 değilse listboxa yazdırır 
            End If
        Next

    End Sub
End Class
