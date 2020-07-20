Module Module1

    Sub Main()

        ' this program will calculate a users mobile phone bill
        ' The user enters their userid, numberof texts and calls made
        ' the program calculates the cost of texts,cost of calls and then total cost
        Dim calls, txts As Integer
        Const txtrate As Decimal = 0.05  ' fixed value 5p per texts
        Const callrate As Decimal = 0.15 ' fixed value 15p per min for calls 
        Dim userid As String
        Dim callcost, txtcost, total As Decimal
        Console.WriteLine("Please enter your User Id")
        userid = Console.ReadLine
        Console.WriteLine("Please enter number of txts used ")
        txts = Console.ReadLine
        Console.WriteLine("Please enter minutes of calls made ")
        calls = Console.ReadLine
        callcost = calls * callrate
        txtcost = txts * txtrate
        Console.WriteLine("Bill for User " & userid)
        Console.WriteLine("Cost for calls " & callcost)
        Console.WriteLine("Cost for txts " & txtcost)
        total = callcost + txtcost
        Console.WriteLine("Total cost " & total)


        Console.ReadLine()


    End Sub

End Module

