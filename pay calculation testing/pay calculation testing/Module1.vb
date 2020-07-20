Module Module1

    Dim totalpay As Single
    Dim hours As Decimal
    Dim overhours As Decimal
    Dim rateofpay As Integer
    Dim more As Char
    Sub Main()
        Do
            Try
                Call input()
                totalpay = 0

                If hours < 36 Then
                    Call calc_basicpay()
                Else
                    overhours = hours - 35
                    hours = 35
                    Call calc_basicpay()
                    Call calc_overtime()
                End If

                Console.WriteLine("Total pay = " & Format(totalpay, "currency"))
            Catch ex As Exception
                Console.WriteLine("Invalid input.")
            End Try

            Console.WriteLine("more input?  Y/N")
            more = Console.ReadLine
        Loop While more = "Y" Or more = "y"
        Console.ReadLine()
    End Sub
    Sub input()
        Console.WriteLine("please enter hours worked")
        hours = Console.ReadLine
        Do While hours < 1
            Console.WriteLine("Error, minimum hours worked is 1. Please re-enter")
            hours = Console.ReadLine
        Loop
        Do While hours > 48
            Console.WriteLine("Error: maximum hours worked is 48. Please reenter")
            hours = Console.ReadLine
        Loop
        Console.WriteLine("Please enter rate of pay")
        rateofpay = Console.ReadLine
    End Sub
    Sub calc_basicpay()
        Dim basicpay As Single
        ' calculate basic pay for first 35 hours worked
        ' pay = rateofpay x hoursworked
        basicpay = rateofpay * hours
        Console.WriteLine("Basic pay = " & Format(basicpay, "currency"))
        totalpay = totalpay + basicpay
    End Sub
    Sub calc_overtime()
        Dim overtime As Single
        ' calculate overtime for hours worked over 35 hours
        ' this is paid at 1.5 times basicpay.
        overtime = (rateofpay * 1.5) * overhours
        Console.WriteLine("overtime pay = " & Format(overtime, "currency"))
        totalpay = totalpay + overtime
    End Sub


End Module
