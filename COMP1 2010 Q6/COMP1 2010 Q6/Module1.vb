Module Module1
    Dim NoOfGamesInMatch, NoOfGamesPlayed As Integer
    Dim PlayerOneScore, PlayerTwoScore As Integer
    Dim PlayerOneWinsGame As Char

    Sub Main()
        PlayerOneScore = 0
        PlayerTwoScore = 0

        Console.WriteLine("How many games?")
        NoOfGamesInMatch = Console.ReadLine

        For NoOfGamesPlayed = 1 To NoOfGamesInMatch
            Console.WriteLine("Did player one win the game? (Enter Y/N)")
            PlayerOneWinsGame = Console.ReadLine
            If PlayerOneWinsGame = "Y" Then
                PlayerOneScore = PlayerOneScore + 1
            Else
                PlayerTwoScore = PlayerTwoScore + 1
            End If
        Next

        Console.WriteLine("Player One Score: " & PlayerOneScore)
        Console.Write("Player Two Score: " & PlayerTwoScore)

        Console.ReadLine()

    End Sub

End Module
