Module Module1

    Sub Main()
        Call Output_CSV()
        Call Input_CSV()

    End Sub

    Sub Output_CSV()
        Dim filename, name, street, town As String
        Dim more As String
        filename = "csvfile.csv"
        FileOpen(1, filename, OpenMode.Append)
        Console.WriteLine("User to input names and addresses to be  written to a file")
        Do
            Console.WriteLine("input name")
            name = Console.ReadLine
            Console.WriteLine("input street")
            street = Console.ReadLine
            Console.WriteLine("input town")
            town = Console.ReadLine
            WriteLine(1, name, street, town)
            Console.WriteLine("More  data ? Y/N")
            more = Console.ReadLine
        Loop Until more = "N"

        FileClose(1)

    End Sub

    Sub Input_CSV()
        Dim filename, name, street, town As String
        filename = "csvfile.csv"
        FileOpen(1, filename, OpenMode.Input)

        Do While Not EOF(1)
            Input(1, name)
            Input(1, street)
            Input(1, town)
            Console.WriteLine(name)
            Console.WriteLine(street)
            Console.WriteLine(town)
        Loop
        FileClose(1)

    End Sub

End Module
