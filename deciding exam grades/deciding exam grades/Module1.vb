Module Module1

    Sub Main()

        Dim Mark As Integer

        Console.WriteLine("Enter an exam mark from 0 to 100")
        Mark = Console.ReadLine
        If Mark < 0 Or Mark > 100 Then
            Console.WriteLine("Invalid mark")

        ElseIf Mark >= 60 Then
            Console.WriteLine("Merit")
        ElseIf Mark >= 40 Then
            Console.WriteLine("Pass")
        ElseIf Mark >= 80 Then
            Console.WriteLine("Distinction")
        Else
            Console.WriteLine("A mark of " & Mark & " is a fail")

        End If



        Console.ReadLine()

    End Sub

End Module
