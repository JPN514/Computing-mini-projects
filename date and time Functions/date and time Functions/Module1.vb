Module Module1
    Dim Day As String
    Dim birthday As String
    Dim birthdayDiff As Integer
    Dim dayName As String
    Dim lessonTime As String
    Dim endSeconds, end_min As Integer
    Dim endTime As String
    Dim count As Integer

    Sub Main()

        Console.WriteLine("The date and time is: " & Now)
        If TimeOfDay.Hour < 12 Then
            Console.WriteLine("Good morning")
        Else : Console.WriteLine("Good afternoon")
        End If

        Console.WriteLine("When is your next birthday?(dd/mm/yy)")
        birthday = Console.ReadLine
        birthdayDiff = DateDiff("d", Today, birthday)
        Console.WriteLine("It is " & birthdayDiff & " days till your birthday")
        dayName = WeekdayName(Weekday(birthday, 0))
        Console.WriteLine("Your birthday will be on a " & dayName)
        Console.WriteLine()

        Console.WriteLine("What time does the lesson end?(hh:mm:ss)")
        lessonTime = Console.ReadLine
        end_min = DateDiff("n", TimeOfDay, lessonTime)
        endSeconds = DateDiff("s", TimeOfDay, lessonTime)
        Console.WriteLine("The lesson ends in " & end_min & " minutes")
        Console.WriteLine("The lesson ends in " & endSeconds & " seconds")
        Console.WriteLine()

        endTime = DateAdd("s", 5, TimeOfDay)
        Do Until TimeOfDay > endTime
            count = count + 1
        Loop
        Console.WriteLine("5 seconds have passed")
        Console.WriteLine(count)

        Console.ReadLine()



    End Sub

End Module
