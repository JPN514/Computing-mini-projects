Module Module1
    Dim grid(10, 10) As Char   ' 2d array for game. Going to ignore elements indexed by 0
    Dim x, y As Integer
    Dim SubsSunkCount As Integer
    Dim subs As Integer
    Dim userX As Integer
    Dim userY As Integer
    Dim guesses As Integer
    Dim errorflag As Boolean


    Sub Main()
        setupGame()
        playgame()
        Console.ReadLine()
    End Sub

    Sub playgame()
        guesses = 0
        Do Until SubsSunkCount = 10 Or guesses = 40
            Console.Write("Subs sunk: " & SubsSunkCount)
            DisplayGrid()

            Do
                Console.WriteLine("Enter x coordinate")
                Try
                    userX = Console.ReadLine
                    If userX < 1 Or userX > 10 Then
                        errorflag = True
                        Console.WriteLine("Coordinates must be between 1 and 10")
                    Else : errorflag = False
                    End If
                Catch
                    Console.WriteLine("Invalid input")
                    errorflag = True
                End Try
            Loop Until errorflag = False

            Do
                Console.WriteLine("Enter y coordinate")
                Try
                    userY = Console.ReadLine
                    If userY < 1 Or userY > 10 Then
                        errorflag = True
                        Console.WriteLine("Coordinates must be between 1 and 10")
                    Else : errorflag = False
                    End If
                Catch
                    Console.WriteLine("Invalid input")
                    errorflag = True
                End Try
            Loop Until errorflag = False

            guesses = guesses + 1
            If grid(userX, userY) = "X" Then
                grid(userX, userY) = "O"
                Console.WriteLine("Hit")
                SubsSunkCount = SubsSunkCount + 1
            Else
                grid(userX, userY) = "/"
                Console.WriteLine("Miss")
            End If
        Loop
            DisplayGrid()
            Console.WriteLine("You won, ten subs were sunk")
    End Sub

    Sub DisplayGrid()
        'this code uses a single loop to display column numbers
        ' it also uses nested loops to display row numbers and then each element of the array 
        ' outer loop processes each row
        ' inner loop processes each column in that row. Unsunk subs are displayed as blanks

        Console.WriteLine()
        Console.Write(" ")
        For x = 1 To 10
            Console.Write(" " & x)
        Next
        Console.WriteLine()
        For y = 1 To 10
            Console.Write(y)
            For x = 1 To 10
                If grid(y, x) <> "X" Then
                    Console.Write(" " & grid(y, x))
                    If grid(y, x) = "O" Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If
                    Console.BackgroundColor = ConsoleColor.Black
                Else
                    Console.Write("  ") ' output blank instead of X
                End If
            Next
            Console.WriteLine()
            Console.WriteLine()
        Next
    End Sub

    Sub setupgame()
        ' this is very basic. It assigns X to 10 elements of the array
        ' better processing would be to randomly generate the subs positions
        'or allow another player to choose positions
        Dim x, y As Integer
        grid(1, 1) = "X"
        grid(2, 6) = "X"
        grid(8, 9) = "X"
        grid(5, 5) = "X"
        grid(3, 1) = "X"
        grid(4, 10) = "X"
        grid(7, 4) = "X"
        grid(1, 10) = "X"
        grid(6, 3) = "X"
        grid(8, 3) = "X"
        grid(9, 1) = "X"
        grid(3, 3) = "X"
        subs = 10
        DisplayGrid()

    End Sub
End Module

