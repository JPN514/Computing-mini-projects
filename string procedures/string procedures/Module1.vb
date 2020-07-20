Module Module1
    Dim sentence, message As String

    Sub Main()
        'Console.WriteLine("Sentence Analysis")
        'Console.WriteLine()
        'Console.WriteLine("Enter a sentence, then press enter")
        'Console.WriteLine()
        'sentence = Console.ReadLine
        'Console.WriteLine()
        'wordcount(sentence)
        'vowelcount(sentence)

        Console.WriteLine("Enter a message")
        message = Console.ReadLine
        scramble(message)

        Console.ReadLine()

    End Sub
    Sub wordcount(ByVal input As String)
        Dim count As Integer
        Dim ch As Char
        Dim space As Integer

        input = LCase(input)
        count = Len(input)
        space = 0
        For count = 0 To Len(input) - 1
            ch = input(count)
            If ch = " " Then
                space = space + 1
            End If
        Next

        Console.WriteLine("Your sentence contains " & space + 1 & " words.")
    End Sub

    Sub vowelcount(ByVal input As String)
        Dim count As Integer
        Dim ch As Char
        Dim vowels As Integer

        input = LCase(input)
        count = Len(input)
        vowels = 0
        For count = 0 To Len(input) - 1
            ch = input(count)
            If ch = "a" Then
                vowels = vowels + 1
            ElseIf ch = "e" Then
                vowels = vowels + 1
            ElseIf ch = "i" Then
                vowels = vowels + 1
            ElseIf ch = "o" Then
                vowels = vowels + 1
            ElseIf ch = "u" Then
                vowels = vowels + 1
            End If
        Next

        Console.WriteLine("Your sentence contains " & vowels & " vowels.")
    End Sub

    Sub scramble(ByRef input As String)
        Dim count As Integer
        Dim ch As Char
        Dim ch2 As Char
        Dim word As String

        word = ""
        count = 1

        Do Until count >= Len(input)

            ch = Mid(input, count + 1, 1)
            ch2 = Mid(input, count, 1)

            word = word + ch + ch2
            count = count + 2
        Loop

        If Len(input) Mod 2 <> 0 Then
            word = word + Mid(input, Len(input), 1)
        End If

        input = word

        Console.WriteLine(input)
    End Sub

End Module
