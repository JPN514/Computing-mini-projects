Module Module1
    Dim Choice As Integer
    Dim more As Boolean
    Sub Main()
        more = True
        Do
            Console.WriteLine("Press 1 to view results, 2 to add results or 3 to exit")
            Choice = Console.ReadLine
            Select Case (Choice)

                Case Is = 1
                    Call Display_Results()
                Case Is = 2
                    Call Add_Results()
                Case Is = 3
                    more = False
            End Select
        Loop Until more = False


        Console.ReadLine()

    End Sub

    Sub Display_Results()
        Dim filename, team1, team2 As String, goals1, goals2 As Integer
        filename = "results.csv"
        FileOpen(1, filename, OpenMode.Input)

        Do While Not EOF(1)
            Input(1, team1)
            Input(1, goals1)
            Input(1, team2)
            Input(1, goals2)
            Console.Write(team1)
            Console.WriteLine(": " & goals1)
            Console.Write("")
            Console.Write(team2)
            Console.WriteLine(": " & goals2)
            If goals1 > goals2 Then
                Console.WriteLine("Home win")
            ElseIf goals2 > goals1 Then
                Console.WriteLine("Away win")
            Else
                Console.WriteLine("Draw")
            End If
            Console.WriteLine("")
        Loop
        FileClose(1)

    End Sub

    Sub Add_Results()
        Dim more_results As Char
        Dim filename, team1, team2 As String, goals1, goals2 As Integer
        filename = "results.csv"
        FileOpen(1, filename, OpenMode.Append)
        Do
            Console.WriteLine("Enter home team")
            team1 = Console.ReadLine
            Console.WriteLine("Enter home goals")
            goals1 = Console.ReadLine
            Console.WriteLine("Enter away team")
            team2 = Console.ReadLine
            Console.WriteLine("Enter away goals")
            goals2 = Console.ReadLine
            WriteLine(1, team1, goals1, team2, goals2)
            Console.WriteLine("Do you wish to enter more results? (Y/N)")
            more_results = UCase(Console.ReadLine)
        Loop Until more_results = "N"
        FileClose(1)
    End Sub

End Module
