Module Module1

    Dim coachSeats As Integer
    Dim people As Integer
    Dim fullCoaches As Integer
    Dim lastCoach As Integer


    Sub Main()


        Console.WriteLine("Please enter the number of people attending the game")
        people = Console.ReadLine
        Console.WriteLine("Enter the capacity of each coach")
        coachSeats = Console.ReadLine

        fullCoaches = people \ coachSeats
        lastCoach = people Mod coachSeats

        Console.WriteLine("The number of full coaches is " & fullCoaches)


        If lastCoach = 0 Then
            Console.Write("All coaches will be full")
        Else : Console.WriteLine("The last coach will contain " & lastCoach & " passengers")
        End If


        Console.ReadLine()



    End Sub

End Module
