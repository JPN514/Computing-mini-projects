Module Module1
    Dim rightAngles As String
    Dim equalSides As String
    Dim ParallelSides As String

    Sub Main()

        Console.WriteLine("4 equal sides? (Y/N)")
        equalSides = Console.ReadLine
        Console.WriteLine("4 right angles? (Y/N)")
        rightAngles = Console.ReadLine
        Console.WriteLine("How many sets of parellel sides? (<2 or 2)")
        ParallelSides = Console.ReadLine

        If equalSides = "Y" And rightAngles = "Y" And ParallelSides = "2" Then
            Console.WriteLine("It is a Square")
        ElseIf equalSides = "Y" And rightAngles = "Y" And ParallelSides = "<2" Then
            Console.WriteLine("Invalid response")
        ElseIf equalSides = "Y" And rightAngles = "N" And ParallelSides = "2" Then
            Console.WriteLine("It is a Rhombus")
        ElseIf equalSides = "Y" And rightAngles = "N" And ParallelSides = "<2" Then
            Console.WriteLine("It is an unidentfied quadrilateral")
        ElseIf equalSides = "N" And rightAngles = "Y" And ParallelSides = "2" Then
            Console.WriteLine("It is a Rectangle")
        ElseIf equalSides = "N" And rightAngles = "Y" And ParallelSides = "<2" Then
            Console.WriteLine("Invalid response")
        ElseIf equalSides = "N" And rightAngles = "N" And ParallelSides = "2" Then
            Console.WriteLine("It is a Parellelogram")
        ElseIf equalSides = "N" And rightAngles = "N" And ParallelSides = "<2" Then
            Console.WriteLine("It is a Trapezium")
        End If

        Console.ReadLine()


    End Sub

End Module
