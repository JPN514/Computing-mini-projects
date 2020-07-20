Module Module1
    'shopping receipt task 2

    Dim user As String
    Dim item1 As Decimal
    Dim item2 As Decimal
    Dim subtotal As Decimal
    Const VAT As Decimal = 0.175
    Dim total As Decimal



    Sub Main()

        Console.WriteLine("What is your name?")
        user = Console.ReadLine
        Console.WriteLine("Enter the price of your 1st item")
        item1 = Console.ReadLine
        Console.WriteLine("Enter the price of your 2nd item")
        item2 = Console.ReadLine

        subtotal = item1 + item2
        total = subtotal + subtotal * VAT

        Console.WriteLine(user)
        Console.WriteLine("Item 1's price " & item1 & " Item2's price " & item2)
        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("Total: " & total)

        Console.ReadLine()



    End Sub

End Module
