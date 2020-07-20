Module Module1
    Dim word As String
    Dim score As Integer

    Sub Main()

        Console.WriteLine("Enter a word")
        word = Console.ReadLine

    End Sub

    Sub points(ByVal input As String, ByRef total As Integer)
        Dim count As Integer
        Dim ch As Char
        Do Until count = Len(input) - 1
           Select Ch
                Case "a", "e", "i", "o", "u", "l", "n", "r", "s", "t"
                    total = total + 1
                Case "d", "g"
                    total = total + 2
                Case "b", "c", "m", "p"
                    total = total + 3
            End Select
        Loop

    End Sub
End Module
