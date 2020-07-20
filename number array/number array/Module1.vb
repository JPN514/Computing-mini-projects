Module Module1
    Dim num(9) As Integer
    Dim sum, average, above, below As Integer

    Sub Main()

        For cnt = 0 To 9
            Console.WriteLine("Please enter a integer number")
            num(cnt) = Console.ReadLine
            sum = sum + num(cnt)
        Next
        average = sum / 10
        Console.WriteLine()

        For cnt = 0 To 9
            If num(cnt) < average Then
                Console.WriteLine(num(cnt) & " Below average")
                below = below + 1
            ElseIf num(cnt) > average Then
                Console.WriteLine(num(cnt) & " Above average")
                above = above + 1
            Else
                Console.WriteLine(num(cnt) & " Average")
            End If
        Next

        Console.WriteLine(above & " numbers above average")
        Console.WriteLine(below & " numbers below average")

        Console.ReadLine()

    End Sub

End Module
