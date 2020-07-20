Module Module1
    Dim AgeRating As String
    Dim age As Integer
    Dim parent As Char


    Sub Main()
        Console.WriteLine("Welcome to the cinema")
        Console.WriteLine()
        Console.WriteLine("How old are you?")
        age = Console.ReadLine
        Console.WriteLine("What is the rating of the film you want to watch")
        AgeRating = Console.ReadLine


        If AgeRating = "U" Then
            Console.WriteLine("You can watch the film")
        ElseIf AgeRating = "PG" Then
            Console.WriteLine("You can watch the film")
        Else

            If AgeRating = "18" And age >= 18 Then
                Console.WriteLine("You can watch the film")
            ElseIf AgeRating = "18" And age < 18 Then
                Console.WriteLine("You cannot watch the film")

            ElseIf AgeRating = "15" And age >= 15 Then
                Console.WriteLine("You can watch the film")
            ElseIf AgeRating = "15" And age < 15 Then
                Console.WriteLine("You cannot watch the film")

            ElseIf AgeRating = "12A" And age < 12 Then
                Console.WriteLine("Are you with a parent?(Y/N)")
                parent = Console.ReadLine
                If parent = "Y" Then
                    Console.WriteLine("You can watch the film")
                Else
                    Console.WriteLine("You cannot watch the film")
                End If
            ElseIf AgeRating = "12A" And age >= 12 Then
                Console.WriteLine("You can watch the film")
            End If
        End If

        Console.ReadLine()

    End Sub

End Module
