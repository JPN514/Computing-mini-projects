Module Module1

    Dim password As String
    Dim count As Integer

    Sub Main()




        Console.Write("Enter the password: ")
        password = Console.ReadLine

        count = 0


        Do Until count = 2 Or password = "secret"
            count = count + 1
            Console.WriteLine("Password incorrect. Please try again")
            Console.Write("Enter the password: ")
            password = Console.ReadLine
        Loop

        If password = "secret" Then
            Console.WriteLine("You are in!")
        Else
            Console.WriteLine("Locked out")
        End If
        Console.ReadLine()

    End Sub

End Module
