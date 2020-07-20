Module Module1
    Dim F, C As Decimal

    Sub Main()
        Input(F)
        Calculate(F, C)
        Display(C)
    End Sub
    Sub Input(ByRef fahrenheit As Decimal)
        Console.WriteLine("Enter the temperature in fahrenheit")
        fahrenheit = Console.ReadLine
    End Sub

    Sub Calculate(ByVal fahrenheit As Decimal, ByRef Celsius As Decimal)
        Celsius = (fahrenheit - 32) * 5 / 9
    End Sub

    Sub Display(ByVal Celsius As Decimal)
        Console.WriteLine()
        Console.WriteLine("The temperature is " & Format(Celsius, "0.0") & " Celsius")
        Console.ReadLine()
    End Sub
End Module
