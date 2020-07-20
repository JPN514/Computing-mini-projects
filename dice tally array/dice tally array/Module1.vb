Module Module1
    Dim tally(6) As Integer
    Dim Randomnum As Integer



    Sub Main()

        For cnt = 0 To 6
            tally(cnt) = 0
        Next


        For roll = 1 To 200
            Randomize()
            Randomnum = Math.Truncate(Rnd() * 6 + 1)
            tally(Randomnum) = tally(Randomnum) + 1
        Next


        For cnt = 1 To 6
            Console.WriteLine(cnt & "'s: " & tally(cnt))
        Next

        Console.ReadLine()
    End Sub

End Module
