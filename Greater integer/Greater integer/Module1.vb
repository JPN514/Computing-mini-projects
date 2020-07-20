Module Module1

    Dim number0, number1 As Integer


    Sub Main()
        Console.WriteLine("Please enter a number")
        number0 = Console.ReadLine
        Console.WriteLine("Please enter another number")
        number1 = Console.ReadLine
        
        If number0 > number1 Then
            Console.WriteLine(number0 & " is greater than " & number1)
        ElseIf number1 > number0 Then
            Console.WriteLine(number1 & " is greater than " & number0)
        ElseIf number0 = number1 Then
            Console.WriteLine("Both numbers are the same " & number0 & " is equal to " & number1)
        End If

        Console.ReadLine()



    End Sub

End Module
