Module Module1
    Dim student(7) As String
    Dim index As Integer



    Sub Main()
        student(0) = "Fred"
        student(1) = "Jack"
        student(2) = "Chris"
        student(3) = "Ali"
        student(4) = "Harry"
        student(5) = "Bill"
        student(6) = "Zak"
        student(7) = "Phil"

        For index = 0 To 7
            Console.WriteLine(student(index))
        Next

        Console.ReadLine()

        For index = 7 To 0 Step -1
            Console.WriteLine(student(index))
        Next

        Console.ReadLine()

    End Sub

End Module
