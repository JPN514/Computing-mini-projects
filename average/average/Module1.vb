Module Module1

    Dim number1, number2, number3, sum, average As Decimal

    Sub Main()
        Console.Write("Enter first number ")
        number1 = Console.ReadLine
        Console.Write("Enter second number ")
        number2 = Console.ReadLine
        Console.Write("Enter third number ")
        number3 = Console.ReadLine
        sum = number1 + number2 + number3
        average = sum / 3
        Console.WriteLine("Their sum is " & sum)
        Console.WriteLine("Their average is " & average)
        Console.ReadLine()


    End Sub

End Module
