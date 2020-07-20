Module Module1
    Dim lastname, firstname, fullname, UpperCase, reverse As String
    Dim length, count, n As Integer
    Dim initial, letter As Char
    Dim l As String
    Dim ch As Char





    Sub Main()

        'Console.WriteLine("Enter your first name")
        'firstname = Console.ReadLine
        'Console.WriteLine("Enter your last name")
        'lastname = Console.ReadLine
        'Console.WriteLine()

        'fullname = firstname + " " + lastname
        'length = Len(fullname)
        'Console.WriteLine(fullname)
        'Console.WriteLine(length)
        'Console.WriteLine()

        'initial = Mid(firstname, 1, 1)
        'Console.WriteLine(initial + " " + lastname)
        'Console.WriteLine()

        'UpperCase = UCase(fullname)
        'Console.WriteLine(UpperCase)
        'Console.WriteLine()

        'reverse = StrReverse(fullname)
        'Console.WriteLine(reverse)
        'Console.WriteLine()

        'count = 1
        'Console.WriteLine(Mid(fullname, count, 1))
        'Do Until count = length
        '    count = count + 1
        '    Console.WriteLine(Mid(fullname, count, 1))
        'Loop

        'Console.WriteLine()

        'For n = 0 To Len(fullname) - 1
        '    letter = fullname(n)
        '    Console.WriteLine(letter)
        'Next

        'Console.WriteLine()

        'fullname = capitalize(firstname, lastname)
        'Console.WriteLine(fullname)
        'Console.WriteLine()

        'fullname = initials(firstname, lastname)
        'Console.WriteLine(fullname)
        'Console.WriteLine()


       
       
        Console.WriteLine("please enter your fullname with all middle names")
        fullname = Console.ReadLine
        Console.WriteLine(initials(fullname))
        Console.ReadLine()


        Console.ReadLine()




    End Sub
    Function capitalize(ByVal firstname As String, ByVal lastname As String) As String

        capitalize = UCase(firstname(0)) + LCase(Mid(firstname, 2)) + " " + UCase(lastname(0)) + LCase(Mid(lastname, 2))
    End Function

    Function initials(ByVal fullname As String) As String
        'this function will extract the initials of each name in fullname and return them as capital letters
        ' with fullstops between each letter. 
        ' this function relies on tere being one space between each namen
        initials = fullname(0)      ' set initials to first letter of teh name .. first initial
        For cnt = 0 To Len(fullname) - 1 '          
            ch = fullname(cnt)
            If ch = " " Then   ' next letter will be initial of next name
                initials = initials + "." + fullname(cnt + 1)   'add the next letter in fullname string on to initials variable
            End If
        Next
        initials = UCase(initials)
    End Function


  
End Module
