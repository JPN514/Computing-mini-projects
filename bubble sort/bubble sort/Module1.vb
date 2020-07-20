Module Module1

    Sub Main()
        Dim nums() As Integer = {72, 86, 2, 50, 27, 12}
        Dim temp, cnt As Integer, swaps As Boolean

        Do
            swaps = False
            cnt = 0
            Do While cnt < 5
                If nums(cnt + 1) < nums(cnt) Then
                    temp = nums(cnt)
                    nums(cnt) = nums(cnt + 1)
                    nums(cnt + 1) = temp
                    swaps = True
                End If
                cnt = cnt + 1
            Loop
        Loop Until swaps = False


        For cnt = LBound(nums) To UBound(nums)
            Console.WriteLine(nums(cnt))
        Next

        Console.ReadLine()

    End Sub

End Module
