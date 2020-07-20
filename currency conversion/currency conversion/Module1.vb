Module Module1
    Dim Choice As String
    Dim Pounds As Decimal
    Dim Euros As Decimal
    Dim Yen As Decimal
    Sub Main()
        Console.WriteLine("Do you want Euros or Yen?")
        Choice = Console.ReadLine

        If Choice = "Euros" Then
            Console.Write("Enter the number of Pounds you wish to convert to Euros £")
            Pounds = Console.ReadLine
            Euros = Pounds * 1.2
            Console.WriteLine("You would receive " & Euros & " Euros")
            Console.ReadLine()
        End If

        If Choice = "Yen" Then
            Console.Write("Enter the number of Pounds you wish to convert to Yen £")
            Pounds = Console.ReadLine
            Yen = Pounds * 124.6
            Console.WriteLine("You would receive " & Yen & " Yen")
            Console.ReadLine()
        End If





    End Sub

End Module
