Module Module1
    Dim age As Integer
    Dim member As Integer

    Sub Main()

        Console.WriteLine("Enter your age")
        age = Console.ReadLine
        Console.WriteLine("Enter the amount of years you have been a member for")
        member = Console.ReadLine

        If age <= 18 And member >= 2 Then
            Console.WriteLine("Your membership will cost £40")
        ElseIf age <= 18 And member < 2 Then
            Console.WriteLine("Your membership will cost £60")

        ElseIf age >= 19 And age <= 49 And member >= 10 Then
            Console.WriteLine("Your membership will cost £90")
        ElseIf age >= 19 And age <= 49 And member < 10 Then
            Console.WriteLine("Your membership will cost £120")

        ElseIf age >= 50 And member >= 10 Then
            Console.WriteLine("Your membership will cost £50")
        ElseIf age >= 50 And member < 10 Then
            Console.WriteLine("Your membership will cost £80")

        End If




        Console.ReadLine()


    End Sub

End Module
