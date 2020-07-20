Module Module1
    'program to calculate area, circumference and volume of circles and cylinders with most precise and appropriate data types.
    Dim area As Double
    Dim circumference As Double
    Dim volume As Double
    Dim user_choice As Char
    Const PI As Double = 3.1415926
    Dim radius As Byte
    Dim height As Byte

    Sub Main()

        Console.WriteLine("  Circle calculations")
        Console.WriteLine("Enter A for cirlce area")
        Console.WriteLine("Enter C for circle circumference")
        Console.WriteLine("Enter V for cylinder volume")
        user_choice = Console.ReadLine
        Console.WriteLine("Enter the radius of the circle must be whole number up to 100")
        radius = Console.ReadLine

        If user_choice = "A" Then
            area = PI * radius * radius
            Console.WriteLine("The area is " & area)

        elseif user_choice = "C" Then
        circumference = 2 * PI * radius
        Console.WriteLine("The circumference is " & circumference)


        ElseIf user_choice = "V" Then
        Console.WriteLine("Enter the height of the cylinder must be whole number up to 100")
            height = Console.ReadLine
            volume = PI * radius * radius * height
            Console.WriteLine("The volume is " & volume)

        End If

        Console.ReadLine()


    End Sub

End Module
