Module Module1
    Dim Answer As Integer
    Dim Column
    Dim Bit As Integer


    Sub Main()

        Answer = 0
        Column = 8

        Do

            Console.Write("Enter bit value: ")
            Bit = Console.ReadLine

            Answer = Answer + (Column * Bit)
            Column = Column / 2

        Loop Until Column < 1

        Console.Write("Decimal value is: ")
        Console.WriteLine(Answer)
        Console.ReadLine()

    End Sub

End Module
