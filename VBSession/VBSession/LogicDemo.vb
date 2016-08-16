Module LogicDemo
    'Module level variable
    Dim number As Integer = 10
    ' Public myInt As Integer
    ' Logic Blocks
    '   Function
    '       return a data type/ value
    '   Subroutine
    '       do not return a value/types

    'Lifecycle of logic blocks
    '   Define
    '   Implement them
    '   Use them/ Call
    Function DoThis() As Boolean
        ' All my logic goes here / body
        number = 20
        Dim name As String = "Ruchira"
        Console.WriteLine("Inside Do This function")
        ' DoThisAsWell()
        Return True
    End Function

    Sub DoThisAsWell()
        'Your logic here/ body
        number = 30
        'name
        Console.WriteLine("Inside DothisAs Well Subroutine")
    End Sub
End Module
