Module Module1

    Dim month(12) As String
    Dim average_temps(12) As Decimal
    Dim n As Integer

    Sub Main()

        setup()
        n = 1
        Do Until n > 12
            Console.WriteLine("Please enter the average temperature for " & month(n))
            average_temps(n) = Console.ReadLine
            n = n + 1
        Loop

        For cnt = 1 To 12
            Console.WriteLine("Month: " & month(cnt) & " ,  Average temperature: " & average_temps(cnt))
            Console.WriteLine()
        Next

        search()


        Console.ReadLine()
    End Sub

    Sub setup()
        month(1) = "January"
        month(2) = "February"
        month(3) = "March"
        month(4) = "April"
        month(5) = "May"
        month(6) = "June"
        month(7) = "July"
        month(8) = "August"
        month(9) = "September"
        month(10) = "October"
        month(11) = "November"
        month(12) = "December"
    End Sub

    Sub search()

        Dim found As Boolean

        found = False
        n = 1
        Do Until found = True Or n > UBound(average_temps)
            If average_temps(n) > 10 Then
                found = True
            Else : n = n + 1
            End If
        Loop

        If found = False Then
            Console.WriteLine("All average temperatures were below 10 or below")
        Else
            Console.WriteLine("First month with temperature over 10 is " & month(n) & " with: " & average_temps(n))
        End If

    End Sub
End Module
