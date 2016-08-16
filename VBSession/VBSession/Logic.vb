Module Logic
    ' Define a function
    ' Signature of the function
    '   Name of the function
    '   No. of parameters
    '   Sequence of parameters
    '   Type of parameters
    '   Return type
    '   Security
    Function CalcAge(num As Integer, weight As Single, flag As Boolean) As Boolean
        ' Body
        'Conditional statements

        If num = 10 Then
            ' body of if/ do something
            Console.WriteLine("We are inside if, num = 10")
        ElseIf num > 10 Then
            Console.WriteLine("num i sgreater than 10")
        Else
            Console.WriteLine("Above conditions are false")
        End If

        'nested if
        If num = 10 Then
            If weight > 10 Then
            ElseIf weight < 10 Then

            ElseIf weight = 10 Then
            Else

            End If
        End If

        'Select
        Select Case num
            Case 10, 12, 15
                Console.WriteLine("Too young to to be served beer!")
            Case Is <= 20
                Console.WriteLine("Too young to to be served beer!")
            Case Is > 20
                Console.WriteLine("Serve beer!")
            Case Is > 50
                Console.WriteLine("Serve juice!")
            Case Else
        End Select

        'Loops
        For counter As Integer = 1 To 5 Step 1
            Console.WriteLine("Counter {0}", counter)
        Next

        For index As Integer = 1 To 10 Step 2
            Console.WriteLine("index {0}", index)
        Next

        For count = 5 To 1 Step -1
            Console.WriteLine("count {0}", count)
        Next
        Console.ReadLine()

        'While Loop
        While num > 10 And flag = True
            'Do Something
            num = num + 1
        End While

        'Do While
        Do
            'Do something atleast once
            num = num + 1
        Loop While num = 10

        'While True
        '    If True Then

        '    End If
        'End While

        'For index = 1 To 10
        '    If True Then

        '    End If
        'Next

        'If True Then
        '    For index = 1 To 10

        '    Next
        'End If

        ' For each
        Dim pColl As New Collection
        pColl.Add(12)
        pColl.Add(13)

        For Each item In pColl
            ' pColl.Remove(index)
            Console.WriteLine(item)
        Next
        Console.ReadLine()
        Return True
    End Function

    'Function Overloading
    Function CalcAge() As Boolean
        Return False
    End Function
End Module
