Module Module1

    Dim Days As Integer
    Dim Weeks As Integer
    Dim odd_days As Integer

    Sub Main()

        Console.WriteLine("Enter a number of days")
        Days = Console.ReadLine

        Weeks = Days \ 7
        odd_days = Days Mod 7

        If odd_days = 0 Then

            Console.WriteLine("Number of whole weeks: " & Weeks)

        ElseIf odd_days > 0 Then
            Console.WriteLine("Number of whole weeks: " & Weeks)
            Console.WriteLine("Number of extra days: " & odd_days)

        End If



        Console.ReadLine()





    End Sub

End Module
