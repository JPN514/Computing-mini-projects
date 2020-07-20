Module Module1
    Dim age As Integer

    Sub Main()
        Console.WriteLine("Enter your age")
        age = Console.ReadLine

        If age < 0 Or age > 120 Then
            Console.WriteLine("Invalid age")
        ElseIf age < 18 Then
            Console.WriteLine("You are a child")
        ElseIf age >= 18 And age < 65 Then
        Console.WriteLine("You are an adult")
        ElseIf age >= 65 Then
        Console.WriteLine("You are a senior")
        End If


        Console.ReadLine()

    End Sub

End Module
