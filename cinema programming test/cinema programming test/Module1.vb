Module Module1
    Dim userstatus As Char
    Dim adult As Integer = 7.0
    Dim studentprice As Decimal = 4.5
    Dim child As Integer = 3.0
    Dim senior As Integer = 6.0
    Dim student As Char
    Dim newcustomer As Char
    Dim people As Integer
    Dim ticketprice As Decimal
    Dim ticket_total As Decimal





    Sub Main()
        Console.WriteLine("Welcome to the cinema")
        Console.WriteLine("Adult = A, child = C and senior = S")

        people = 0
        Do Until newcustomer = "N" Or people > 5
            Console.WriteLine("What is your age group?")
            userstatus = Console.ReadLine
            people = people + 1

            If userstatus = "A" Then
                Console.WriteLine("Are you a student?(Y/N)")
                student = Console.ReadLine
                If student = "Y" Then
                    ticketprice = studentprice
                    Console.WriteLine("Ticket prices are: £" & ticketprice)
                Else
                    ticketprice = adult
                    Console.WriteLine("Ticket prices are: £" & ticketprice)
                End If
            ElseIf userstatus = "C" Then
                ticketprice = child
                Console.WriteLine("Ticket prices are: £" & ticketprice)
            ElseIf userstatus = "S" Then
                ticketprice = senior
                Console.WriteLine("Ticket prices are: £" & ticketprice)
            End If
            Console.WriteLine("Is there a new customer?Y/N")
            newcustomer = Console.ReadLine
            ticket_total = ticket_total + ticketprice
        Loop

        If newcustomer = "N" Then
            Console.WriteLine("Box office closed")
        ElseIf people > 5 Then
            Console.WriteLine("The cinema is full")
        End If
        Console.WriteLine("Total sales: £" & ticket_total)
        Console.WriteLine("There are " & people & " people in the cinema")

        Console.ReadLine()



    End Sub

End Module
