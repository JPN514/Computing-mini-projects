Module Module1
    Dim hours, rate, pay As Decimal

    Sub Main()
        Input(hours, rate)
        Calculate(hours, rate, pay)
        Display(Format(pay, "0.00"))
    End Sub

    Sub Input(ByRef time As Decimal, ByRef hourlyrate As Decimal)
        Console.WriteLine("How many hours have you done?")
        time = Console.ReadLine
        Console.WriteLine("Enter your hourly rate")
        hourlyrate = Console.ReadLine
    End Sub

    Sub Calculate(ByVal time As Decimal, ByVal hourlyrate As Decimal, ByRef payment As Decimal)
        If time > 40 Then
            payment = 40 * hourlyrate + (time - 40) * 1.5 * hourlyrate
        Else
            payment = time * hourlyrate
        End If
    End Sub

    Sub Display(ByVal payment As Decimal)
        Console.WriteLine()
        Console.WriteLine("Your total pay is " & FormatCurrency(payment))
        Console.ReadLine()
    End Sub

End Module
