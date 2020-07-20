'Skeleton Program code for the AQA COMP1 Summer 2014 examination
'this code should be used in conjunction with the Preliminary Material
'written by the AQA COMP1 Programmer Team
'developed in the Visual Studio 2008 (Console Mode) programming environment (VB.NET)

Module module1

    Const NoOfRecentScores As Integer = 3

    Structure TCard
        Dim Suit As Integer
        Dim Rank As Integer
    End Structure

    Structure TRecentScore
        Dim Name As String
        Dim Score As Integer
    End Structure

    Sub Main()
        Dim Choice As Char
        Dim Deck(52) As TCard
        Dim temp_deck(52) As TCard
        Dim RecentScores(NoOfRecentScores) As TRecentScore
        Randomize()
        Do
            DisplayMenu()
            Choice = GetMenuChoice()
            Select Case Choice
                Case "1"
                    LoadDeck(Deck)
                    ShuffleDeck(Deck)
                    PlayGame(Deck, RecentScores)
                Case "2"
                    LoadDeck(Deck)
                    PlayGame(Deck, RecentScores)
                Case "3"
                    DisplayRecentScores(RecentScores)
                Case "4"
                    ResetRecentScores(RecentScores)
                Case "5"
                    SaveRecentScoresToFile(RecentScores)
                Case "6"
                    LoadRecentScoresFromFile(RecentScores)
                Case "7"
                    SortRecentScores(RecentScores)
                Case "8"
                    LoadDeck(Deck)
                    Cut_Cards(Deck, temp_deck)
                    PlayGame(Deck, RecentScores)
                Case "9"
                    LoadDeck(Deck)
                    Display_cards(Deck)
            End Select
        Loop Until Choice = "q"
    End Sub

    Function GetRank(ByVal RankNo As Integer) As String
        Dim Rank As String = ""
        Select Case RankNo
            Case 1 : Rank = "Ace"
            Case 2 : Rank = "Two"
            Case 3 : Rank = "Three"
            Case 4 : Rank = "Four"
            Case 5 : Rank = "Five"
            Case 6 : Rank = "Six"
            Case 7 : Rank = "Seven"
            Case 8 : Rank = "Eight"
            Case 9 : Rank = "Nine"
            Case 10 : Rank = "Ten"
            Case 11 : Rank = "Jack"
            Case 12 : Rank = "Queen"
            Case 13 : Rank = "King"
        End Select
        Return Rank
    End Function

    Function GetSuit(ByVal SuitNo As Integer) As String
        Dim Suit As String = ""
        Select Case SuitNo
            Case 1 : Suit = "Clubs"
            Case 2 : Suit = "Diamonds"
            Case 3 : Suit = "Hearts"
            Case 4 : Suit = "Spades"
        End Select
        Return Suit
    End Function

    Sub DisplayMenu()
        Console.WriteLine()
        Console.WriteLine("MAIN MENU")
        Console.WriteLine()
        Console.WriteLine("1.  Play game (with shuffle)")
        Console.WriteLine("2.  Play game (without shuffle)")
        Console.WriteLine("3.  Display recent scores")
        Console.WriteLine("4.  Reset recent scores")
        Console.WriteLine("5.  Save recent scores")
        Console.WriteLine("6.  Load recent scores")
        Console.WriteLine("7.  Sort recent scores")
        Console.WriteLine("8.  Playgame (with cards cut)")
        Console.WriteLine("9.  Display deck")
        Console.WriteLine()
        Console.Write("Select an option from the menu (or enter q to quit): ")
    End Sub

    Function GetMenuChoice() As Char
        Dim Choice As Char
        Dim errorflag As Boolean

        Do
            Choice = Console.ReadLine
            If (Choice < "1" Or Choice > "9") And LCase(Choice) <> "q" Then
                errorflag = True
                Console.WriteLine("Invalid choice. Please re-enter your choice")

            Else
                errorflag = False
            End If
        Loop Until errorflag = False
        Return Choice
    End Function

    Sub LoadDeck(ByRef Deck() As TCard)
        Dim Count As Integer
        FileOpen(1, "deck.txt", OpenMode.Input)
        Count = 1
        While Not EOF(1)
            Deck(Count).Suit = CInt(LineInput(1))
            Deck(Count).Rank = CInt(LineInput(1))
            Count = Count + 1
        End While
        FileClose(1)
    End Sub

    Sub ShuffleDeck(ByRef Deck() As TCard)
        Dim NoOfSwaps As Integer
        Dim Position1 As Integer
        Dim Position2 As Integer
        Dim SwapSpace As TCard
        Dim NoOfSwapsMadeSoFar As Integer
        NoOfSwaps = 1000
        For NoOfSwapsMadeSoFar = 1 To NoOfSwaps
            Position1 = Int(Rnd() * 52) + 1
            Position2 = Int(Rnd() * 52) + 1
            SwapSpace = Deck(Position1)
            Deck(Position1) = Deck(Position2)
            Deck(Position2) = SwapSpace
        Next
    End Sub

    Sub DisplayCard(ByVal ThisCard As TCard)
        Console.WriteLine()
        Console.WriteLine("Card is the " & GetRank(ThisCard.Rank) & " of " & GetSuit(ThisCard.Suit))
        Console.WriteLine()
    End Sub

    Sub GetCard(ByRef ThisCard As TCard, ByRef Deck() As TCard, ByVal NoOfCardsTurnedOver As Integer)
        Dim Count As Integer
        ThisCard = Deck(1)
        For Count = 1 To (51 - NoOfCardsTurnedOver)
            Deck(Count) = Deck(Count + 1)
        Next
        Deck(52 - NoOfCardsTurnedOver).Suit = 0
        Deck(52 - NoOfCardsTurnedOver).Rank = 0
    End Sub

    Function IsNextCardHigher(ByVal LastCard As TCard, ByVal NextCard As TCard) As Boolean
        Dim Higher As Boolean
        Higher = False

        If NextCard.Rank > LastCard.Rank Then
            Higher = True
        Else
            If NextCard.Rank = LastCard.Rank Then
                If NextCard.Suit > LastCard.Suit Then
                    Higher = True
                Else
                    Higher = False
                End If
            Else
                Higher = False
            End If
        End If

        Return Higher
    End Function

    Function GetPlayerName() As String
        Dim PlayerName As String = ""
        Console.WriteLine()
        Console.Write("Please enter your name: ")
        PlayerName = Console.ReadLine
        Do While Len(PlayerName) = 0
            PlayerName = Console.ReadLine
            Console.Write("Please enter your name: ")
        Loop

        Console.WriteLine()
        Return PlayerName
    End Function

    Function GetChoiceFromUser(ByVal Deck() As TCard) As Char
        Dim Choice As Char
        Console.Write("Do you think the next card will be higher than the last card (enter y or n)? ")
        Choice = Console.ReadLine
        If LCase(Choice) = "c" Then
            Display_cards()
        End If
        If LCase(Choice) <> "y" And LCase(Choice) <> "n" Then
            Do
                Console.WriteLine("Enter y or n")
                Choice = Console.ReadLine
            Loop Until UCase(Choice) = "Y" Or UCase(Choice) = "N"
        End If
        Return Choice
    End Function

    Sub DisplayEndOfGameMessage(ByVal Score As Integer)
        Console.WriteLine()
        Console.WriteLine("GAME OVER!")
        Console.WriteLine("Your score was " & Score)
        If Score = 51 Then
            Console.WriteLine("WOW!  You completed a perfect game.")
        End If
        Console.WriteLine()
    End Sub

    Sub DisplayCorrectGuessMessage(ByVal Score As Integer)
        Console.WriteLine()
        Console.WriteLine("Well done!  You guessed correctly.")
        Console.WriteLine("Your score is now " & Score & ".")
        Console.WriteLine()
    End Sub

    Sub ResetRecentScores(ByRef RecentScores() As TRecentScore)
        Dim Count As Integer
        For Count = 1 To NoOfRecentScores
            RecentScores(Count).Name = ""
            RecentScores(Count).Score = 0
        Next
    End Sub

    Sub DisplayRecentScores(ByVal RecentScores() As TRecentScore)
        Dim Count As Integer
        Console.WriteLine()
        Console.WriteLine("Recent scores:")
        Console.WriteLine()
        For Count = 1 To NoOfRecentScores
            Console.WriteLine(RecentScores(Count).Name & " got a score of " & RecentScores(Count).Score)
        Next
        Console.WriteLine()
        Console.WriteLine("Press the Enter key to return to the main menu")
        Console.WriteLine()
        Console.ReadLine()
    End Sub

    Sub UpdateRecentScores(ByRef RecentScores() As TRecentScore, ByVal Score As Integer)
        Dim PlayerName As String
        Dim Count As Integer
        Dim FoundSpace As Boolean
        Dim MatchName As Boolean
        PlayerName = GetPlayerName()
        FoundSpace = False
        Count = 1
        While Not FoundSpace And Count <= NoOfRecentScores


            If RecentScores(Count).Name = "" Or PlayerName = RecentScores(Count).Name Then
                FoundSpace = True
                If PlayerName = RecentScores(Count).Name Then
                    If Score > RecentScores(Count).Score Then
                        RecentScores(Count).Score = Score
                        MatchName = True
                    Else
                        MatchName = True
                    End If
                End If
            Else
                Count = Count + 1
            End If
        End While
        If Not FoundSpace And Not MatchName Then
            For Count = 1 To NoOfRecentScores - 1
                RecentScores(Count) = RecentScores(Count + 1)
            Next
            Count = NoOfRecentScores
        End If
        RecentScores(Count).Name = PlayerName
        RecentScores(Count).Score = Score
    End Sub

    Sub SaveRecentScoresToFile(ByRef recentscores() As TRecentScore)

        FileOpen(1, "recent_scores.csv", OpenMode.Output)
        For i = 1 To NoOfRecentScores
            WriteLine(1, recentscores(i).Name, recentscores(i).Score)
        Next

        FileClose(1)
    End Sub

    Sub LoadRecentScoresFromFile(ByRef recentscores() As TRecentScore)
        Dim playername As String
        Dim score As Integer
        FileOpen(1, "recent_scores.csv", OpenMode.Input)
        Do Until EOF(1)

            Input(1, playername)
            Input(1, score)
            For i = 1 To NoOfRecentScores
                recentscores(i).Name = playername
                recentscores(i).Score = score
            Next

            Console.WriteLine()
            Console.Write("Name: " & playername)
            Console.WriteLine(" Score: " & score)


        Loop
        FileClose(1)


    End Sub

    Sub SortRecentScores(ByRef recentscores() As TRecentScore)
        Dim temp As TRecentScore

        If recentscores(1).Score < recentscores(2).Score Then
            temp = recentscores(2)
            recentscores(2) = recentscores(1)
            recentscores(1) = temp
        End If

        If recentscores(2).Score < recentscores(3).Score Then
            temp = recentscores(3)
            recentscores(3) = recentscores(2)
            recentscores(2) = temp
        End If

        If recentscores(1).Score < recentscores(2).Score Then
            temp = recentscores(2)
            recentscores(2) = recentscores(1)
            recentscores(1) = temp
        End If

    End Sub

    Sub Cut_Cards(ByRef Deck() As TCard, ByRef temp_deck() As TCard)

        Dim swap As TCard


        For cnt = 1 To 26
            swap = Deck(cnt)
            temp_deck(cnt + 26) = swap
            temp_deck(cnt) = Deck(cnt + 26)
        Next

        Deck = temp_deck

    End Sub

    Sub Display_cards(ByVal Deck() As TCard)

        For cnt = 1 To 52
            Console.WriteLine(GetRank(Deck(cnt).Rank) & " of " & GetSuit(Deck(cnt).Suit))
        Next

    End Sub

    Sub PlayGame(ByVal Deck() As TCard, ByRef RecentScores() As TRecentScore)
        Dim NoOfCardsTurnedOver As Integer
        Dim GameOver As Boolean
        Dim NextCard As TCard
        Dim LastCard As TCard
        Dim Higher As Boolean
        Dim Choice As Char
        GameOver = False
        GetCard(LastCard, Deck, 0)
        DisplayCard(LastCard)
        NoOfCardsTurnedOver = 1
        While NoOfCardsTurnedOver < 52 And Not GameOver
            GetCard(NextCard, Deck, NoOfCardsTurnedOver)

            Choice = GetChoiceFromUser()

            DisplayCard(NextCard)
            NoOfCardsTurnedOver = NoOfCardsTurnedOver + 1
            Higher = IsNextCardHigher(LastCard, NextCard)
            If Higher And LCase(Choice) = "y" Or Not Higher And LCase(Choice) = "n" Then
                DisplayCorrectGuessMessage(NoOfCardsTurnedOver - 1)
                LastCard = NextCard
            Else
                GameOver = True
            End If
        End While
        If GameOver Then
            DisplayEndOfGameMessage(NoOfCardsTurnedOver - 2)
            UpdateRecentScores(RecentScores, NoOfCardsTurnedOver - 2)
        Else
            DisplayEndOfGameMessage(51)
            UpdateRecentScores(RecentScores, 51)
        End If
    End Sub

   
End Module

