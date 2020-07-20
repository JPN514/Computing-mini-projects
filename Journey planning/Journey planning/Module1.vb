Module Module1
    Dim StartHour, StartMinute As Integer
    Dim JourneyHour, JourneyMinute As Integer
    Dim finishHour, finishMinute As Integer

    'needs to be finished 
    'sort out the displayed minutes on finish time
    Sub Main()

        Console.WriteLine("Enter a start time for your journey")
        Console.WriteLine("Hours:")
        StartHour = Console.ReadLine
        Console.WriteLine("Minutes:")
        StartMinute = Console.ReadLine

        Console.WriteLine("Enter time taken")
        Console.WriteLine("Hours:")
        JourneyHour = Console.ReadLine
        Console.WriteLine("Minutes:")
        JourneyMinute = Console.ReadLine

        finishHour = StartHour + JourneyHour
        finishMinute = StartMinute + JourneyMinute

        finishHour = finishHour Mod 12



        Console.WriteLine("Start time:" & StartHour & ":" & StartMinute)
        Console.WriteLine("Journey time:" & JourneyHour & ":" & JourneyMinute)
        Console.WriteLine("Finish time:" & finishHour & ":" & finishMinute)

        Console.ReadLine()






    End Sub

End Module
