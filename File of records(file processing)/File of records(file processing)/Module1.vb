Module Module1
    Structure TownType
        <VBFixedString(20)> Dim Name As String
        <VBFixedString(15)> Dim County As String
        Dim Population, Area As Integer
    End Structure
    Dim towns As TownType
    Dim choice As Integer

    Sub Main()
        Console.WriteLine("Costal Towns")

        Console.WriteLine("Enter a number to choose an option:")
        Console.WriteLine("1 List all towns")
        Console.WriteLine("2 Enter new town")
        Console.WriteLine("3 Search by population")
        Console.WriteLine("6 Exit")
        Console.Write("Your choice: ")
        choice = Console.ReadLine
        Do Until choice = 6
            If choice = 1 Then
                Call readfile()
            End If
            If choice = 2 Then
                Call NewTown()
            End If
            If choice = 3 Then
                Call Search()
            End If
        Loop


        Console.ReadLine()
    End Sub

    Sub readfile()
        Dim filename As String
        filename = "towns.dat.dat"
        FileOpen(1, filename, OpenMode.Binary)
        Console.WriteLine()
        Console.WriteLine("Town" & Space(16) & "County" & Space(10) & "Pop." & Space(5) & "Area")
        Console.WriteLine()
        Do While Not EOF(1)
            FileGet(1, towns)
            Console.WriteLine(towns.Name & towns.County & " " & towns.Population & Space(4) & towns.Area)
        Loop

        FileClose(1)

        Console.ReadLine()
    End Sub

    Sub NewTown()
        Dim filename As String
        Dim answer As String
        filename = "towns.dat.dat"
        FileOpen(1, filename, OpenMode.Binary)
        Console.WriteLine()
        Do
            Console.WriteLine("Input town name")
            towns.Name = (Console.ReadLine)
            Console.WriteLine("Input the county")
            towns.County = (Console.ReadLine)
            Console.WriteLine("Input towns population")
            towns.Population = Console.ReadLine
            Console.WriteLine("Input towns area")
            towns.Area = Console.ReadLine
            FilePut(1, towns, LOF(1) + 1)
            Console.Write("Add another town? Y/N")
            answer = Console.ReadLine()
        Loop While answer = "Y" Or answer = "y"

        FileClose(1)

    End Sub

    Sub Search()
        Dim upper, lower As Integer
        Dim found As Boolean
        Dim filename As String
        filename = "towns.dat.dat"
        FileOpen(1, filename, OpenMode.Binary)
        Console.WriteLine()
        Console.WriteLine("What is the upper population limit?")
        upper = Console.ReadLine
        Console.WriteLine("What is the lower population limit?")
        lower = Console.ReadLine
        Console.WriteLine("Town" & Space(16) & "County" & Space(10) & "Pop." & Space(5) & "Area")
        Do While Not EOF(1)
            FileGet(1, towns)
            If towns.Population < upper And towns.Population > lower Then
                Console.WriteLine(towns.Name & " " & towns.County & " " & towns.Population & Space(4) & towns.Area)
                found = True
            End If
        Loop
        If found = False Then
            Console.WriteLine("No towns were found")
        End If

        FileClose(1)

    End Sub

    Sub Delete_records()
        Dim found As Boolean
        Dim filename As String
        Dim wanted As String


    End Sub
End Module
