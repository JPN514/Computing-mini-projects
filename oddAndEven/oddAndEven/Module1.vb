Module Module1

    Dim number As Integer

    Sub Main()
        Console.WriteLine("Enter a number")
        number = Console.ReadLine
        If number < 0 Then
            Console.WriteLine("Your number is invalid")


        ElseIf number Mod 2 = 0 Then
            Console.WriteLine("The number " & number & " is even")
        ElseIf number Mod 2 <> 0 Then
            Console.WriteLine("The number " & number & " is odd")
        End If

        Console.ReadLine()

    End Sub

End Module
