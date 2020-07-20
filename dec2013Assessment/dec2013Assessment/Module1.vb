Module Module1
    'this program should offer the user a choice of circel calculations
    ' User enters a choice
    '   a selection statement based on user choice calls the appropriate procedures.
    ' a loop ensures User can make choiaces until they enter X 
    Dim radius As Single
    Dim answer As Single    ' this is to store the answer to whatever calculation user chooses 
    Dim choice As Char
    Dim pi As Single = 3.142 ' users choice from menu


    Sub Main()




        Do
            displayMenu()
            Console.WriteLine()

            choice = Console.ReadLine()
            choice = UCase(choice)

            Select Case choice
                Case "A"

                    inputradius(radius)
                    CalcArea(radius, answer)
                    DisplayResult(choice, radius, answer)
                Case "C"

                    inputradius(radius)
                    answer = CalcCircum(radius)
                    DisplayResult(choice, radius, answer)
                Case "D"
                    inputradius(radius)
                    CalcDiameter(radius, answer)
                    DisplayResult(choice, radius, answer)
                Case "X"
                    Console.WriteLine("Thank you for using this program")
                Case Else
                    Console.WriteLine("Invalid Choice")
            End Select
        Loop Until choice = "X"

        Console.ReadLine()

    End Sub
    Sub inputradius(ByRef rad As Single)
        Dim errorflag As Boolean
        Console.WriteLine("Enter the radius")
        Do
            Try
                rad = Console.ReadLine
                If rad <= 0 Or rad > 100 Then
                    errorflag = True
                    Console.WriteLine("Radius must be between 0 and 100")
                Else : errorflag = False
                End If
            Catch ex As Exception
                Console.WriteLine("non-numeric radius, please re-enter")
                errorflag = True
            End Try
        Loop Until errorflag = False
    End Sub

    Sub CalcArea(ByVal rad As Single, ByRef area As Single)
        area = pi * rad * rad

    End Sub

    Function CalcCircum(ByVal rad As Single) As Single
        Dim circ As Single
        circ = 2 * pi * rad
        CalcCircum = circ
    End Function

    Sub CalcDiameter(ByVal rad As Single, ByRef d As Single)
        d = 2 * rad
    End Sub

    Sub DisplayResult(ByVal ch As Char, ByVal rad As Single, ByVal answer As Single)
        If choice = "A" Then
            Console.WriteLine("The radius was " & radius & " the area is " & answer)
        ElseIf choice = "C" Then
            Console.WriteLine("The radius was " & radius & " the circumference is " & answer)
        ElseIf choice = "D" Then
            Console.WriteLine("The radius was " & radius & " the diameter is " & answer)
         End If

    End Sub

    Sub displayMenu()
        ' dispalys Menu to User
        Console.WriteLine()
        Console.WriteLine("Circle Calculations")
        Console.WriteLine()
        Console.WriteLine("Enter A to calculate area")
        Console.WriteLine("Enter C to calculate circumference")
        Console.WriteLine("Enter D to calculate the diameter")
        Console.WriteLine("Enter X to exit")
    End Sub
End Module

