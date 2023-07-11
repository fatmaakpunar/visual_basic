Module Module1

    Sub Main()
        Dim m(5, 5), i, j, k, t, y, p As Integer
        Randomize()
ev:     Console.Clear()
        For i = 1 To 5
            For j = 1 To 5
                m(i, j) = Rnd() * 9
                Console.Write(m(i, j) & " ")
            Next
            Console.Write(Chr(13) & Chr(10))

        Next
        If m(1, 1) <> m(5, 5) Then GoTo ev
        Console.ReadLine()
    End Sub

End Module
