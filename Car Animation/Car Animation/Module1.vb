Imports System.Threading


Module Module1

    Dim num As Integer = 0

    Sub Main()

        
        Console.ForegroundColor = ConsoleColor.White

        Do Until num = 70
            num = num + 1
            Console.Clear()
            Console.WriteLine(Space(num) & "***")
            Console.WriteLine(Space(num) & " ******")
            Console.WriteLine(Space(num) & " ******")
            Console.Write(Space(num) & " ** **")
            Thread.Sleep(75)

            If num = 70 Then
                Do Until num = 0
                    num = num - 1
                    Console.Clear()
                    Console.WriteLine(Space(num) & "***")
                    Console.WriteLine(Space(num) & " ******")
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write(Space(num) & " *")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("*****")
                    Console.Write(Space(num) & " ** **")
                    Thread.Sleep(100)
                Loop
            End If

        Loop

       


    End Sub

End Module
