Module Module1

    Dim number, total, max, min As Integer


    Sub Main()

        Console.WriteLine("Enter a number")
        number = Console.ReadLine
        max = number
        min = number

        Do Until number = -1
            total = total + number
            Console.WriteLine("Enter a number")
            number = Console.ReadLine

            If number > max Then
                max = number
            End If
            If number < min And number <> -1 Then
                min = number
            End If

        Loop

        Console.WriteLine()
        Console.WriteLine("Total: " & total)
        Console.Write("Highest value: " & max & " Lowest value: " & min)

        Console.ReadLine()



    End Sub

End Module
