Module Module1
    Dim total, peoplenum As Integer

    Sub Main()

        Do

            Console.WriteLine("Enter the number of people in the group")
            peoplenum = Console.ReadLine

            If total + peoplenum > 500 Then
                Console.WriteLine("Sorry not enough space")
            Else
                total = total + peoplenum
                Console.WriteLine("Spaces left: " & 500 - total)
            End If

        Loop Until total = 500

        Console.WriteLine("Disco is now full")
        Console.ReadLine()
    End Sub

End Module
