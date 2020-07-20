Module Module1
    Dim firstname, surname As String
    Dim age As Integer
    Dim shoesize As Decimal


    Sub Main()

        Console.WriteLine("Enter your first name")
        firstname = Console.ReadLine

        Do Until valid_text(firstname) = True
            Console.WriteLine("Invalid input, please re-enter your first name")
            firstname = Console.ReadLine
        Loop

        Console.WriteLine("Enter your surname")
        surname = Console.ReadLine

        Do Until valid_text(surname) = True
            Console.WriteLine("Invalid input, please re-enter your surname")
            surname = Console.ReadLine
        Loop

        Try
            Console.WriteLine("Enter your age")
            age = Console.ReadLine

            Do Until agecheck(age) = True
                Console.WriteLine("Invalid age")
                age = Console.ReadLine
            Loop
        Catch ex As Exception
            Console.WriteLine("Input was non-numeric")
            age = Console.ReadLine
        End Try


        Try
            Console.WriteLine("Enter your shoesize")
            shoesize = Console.ReadLine

            Do Until shoesizes(shoesize) = True
                Console.WriteLine("Invalid shoesize")
                shoesize = Console.ReadLine
            Loop
        Catch ex As Exception
            Console.WriteLine("Input was non-numeric")
            shoesize = Console.ReadLine
        End Try

        Console.ReadLine()


    End Sub

    Function valid_text(ByVal text As String) As Boolean
        'this function will check that the user has only entered 
        ' letters as input.
        ' a string variable is passed to the function,
        'it returns a Boolean value
        Dim index As Integer
        Dim length As Integer
        Dim pos As Integer
        Const alphabet As String = "abcdefghijklmnopqrstuvwxyz "
        text = LCase(text)
        length = Len(text)
        valid_text = True
        'initialise Ok to true.. assume it will be valid
        'Len is a function that determines how long text is 
        index = 0
        Do While (index < length And valid_text = True)
            'loop through each character in text one by one
            pos = InStr(alphabet, text(index))
            ' instr function returns the position of the text character 
            ' in the string alphabet.If it doesn't find it,returns 0 
            If pos <= 0 Then
                valid_text = False ' this character is invalid letter
            End If
            index = index + 1
        Loop     ' get next character in text string and validate this

    End Function

    Function agecheck(ByVal ages As Integer) As Boolean

        If ages < 0 Or ages > 120 Then
            agecheck = False
        Else : agecheck = True
        End If

    End Function

    Function shoesizes(ByVal shoe As Decimal) As Boolean

        If shoe < 0 Or shoe > 120 Then
            shoesizes = False
        Else : shoesizes = True
        End If

    End Function

End Module
