Module Module1

    Dim age As Integer


    Sub Main()

        Console.WriteLine("Enter your age")
        age = Console.ReadLine

        If age >= 65 Then
            Console.WriteLine("You are a senior")
        ElseIf age < 18 Then
            Console.WriteLine("You are a child")
        Else
            Console.WriteLine("You are an adult")
        End If

        Console.ReadLine()


    End Sub

End Module
