Module Module1

    Dim radius, height As Integer
    Dim volume, surfaceArea As Decimal


    Sub Main()

        Console.WriteLine("Enter the radius of the cylinder")
        radius = Console.ReadLine
        Console.WriteLine("Enter the height of the cylinder")
        height = Console.ReadLine
        volume = Math.PI * radius * radius * height
        surfaceArea = 2 * Math.PI * radius * (radius + height)
        Console.WriteLine("The volume is: " & Format(volume, "00.0000"))
        Console.WriteLine("The surface area is: " & Format(surfaceArea, "00.0000"))
        Console.ReadLine()




    End Sub

End Module
