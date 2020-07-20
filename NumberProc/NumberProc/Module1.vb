Module Module1
    Dim num1, num2, total, ave As Single

    Sub InputData(ByRef number1 As Single, ByRef number2 As Single)
        Console.Write("First number? ")
        number1 = Console.ReadLine
        Console.Write("Second number? ")
        number2 = Console.ReadLine
    End Sub

    Sub CalculateResults(ByRef sum As Single, ByVal number1 As Single, ByVal number2 As Single, ByRef average As Single)
        sum = number1 + number2
        average = sum / 2
    End Sub

    Sub OutputResults(ByVal sum As Single, ByVal average As Single)
        Console.WriteLine("Their sum is {0}", sum)
        Console.WriteLine("Thier average is {0}", average)
    End Sub

    Sub KeepConsoleWindowOpen()
        Console.ReadLine()
    End Sub
    Sub Main()

        InputData(num1, num2)
        CalculateResults(total, num1, num2, ave)
        OutputResults(total, ave)
        KeepConsoleWindowOpen()

    End Sub

End Module
