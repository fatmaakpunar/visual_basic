Module Module1

    Sub Main()
        Dim a(), N, i As Integer
        N = Val(InputBox("N değerini giriniz: "))
        ReDim a(N)
        Console.WriteLine("A dizisi")
        For i = 1 To N
            a(i) = Val(InputBox("A dizisinin " & i & ". elemanı"))
            Console.WriteLine(a(i) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("A dizisinin sıralı hali")
        Array.Sort(a)
        For i = 1 To N
            Console.WriteLine(a(i) & " ")
        Next
        Console.ReadLine()

    End Sub

End Module
