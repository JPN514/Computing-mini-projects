Module Module1

    'suitable hotel task 1

    Dim hotelPrice As Decimal
    Dim hotelDistance As Decimal
    


    Sub Main()

        Console.WriteLine("Please enter the hotels price")
        hotelPrice = Console.ReadLine
        Console.WriteLine("Please enter the distance from the confernce centre in km")
        hotelDistance = Console.ReadLine

        If hotelPrice <= 40 And hotelDistance < 2 Then
            Console.WriteLine("This hotel is suitable")
        ElseIf hotelPrice > 40 And hotelDistance < 2 Then
            Console.WriteLine("The hotel is close enough but is too expensive")
        ElseIf hotelPrice <= 40 And hotelDistance >= 2 Then
            Console.WriteLine("The hotel has a suitable price but is too far away")
        ElseIf hotelPrice > 40 And hotelDistance >= 2 Then
            Console.WriteLine("The hotel is too expensive and too far away")
        End If

        Console.ReadLine()


    End Sub

End Module
