Module Module1
    Dim money, food, trips, presents, moneyLeft, pounds As Decimal

    Sub Main()
        money = 500
        Console.WriteLine("Italian Holiday")
        Console.WriteLine("You have " & money & " Euros to spend")
        Console.ReadLine()
        Console.WriteLine("How much have you spent on food?")
        food = Console.ReadLine
        Console.WriteLine("How much have you spent on trips?")
        trips = Console.ReadLine
        Console.WriteLine("How much have you spent on presents?")
        presents = Console.ReadLine
        moneyLeft = money - food - trips - presents
        Console.WriteLine("You have " & moneyLeft & " Euros remaining")
        pounds = moneyLeft * 1.2
        Console.WriteLine("You have £" & pounds & " remaining")



        Console.ReadLine()


    End Sub

End Module
