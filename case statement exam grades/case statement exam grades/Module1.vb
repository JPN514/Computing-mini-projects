Module Module1


    Dim grades As String



    Sub Main()

        Console.WriteLine("Enter your mark")
        grades = Console.ReadLine

        Select Case grades
            Case Is <= 100
                Console.WriteLine("A")
            Case Is >= 80
                Console.WriteLine("A")
            Case Is >= 70
                Console.WriteLine("B")
            Case Is >= 60
                Console.WriteLine("C")
            Case Is >= 50
                Console.WriteLine("D")
            Case Is >= 40
                Console.WriteLine("E")
            Case Is < 40
                Console.WriteLine("U")

                Console.Write(" Grade")

        End Select





        Console.ReadLine()


    End Sub

End Module
