Imports VBSession

Public Class Animal
    Implements ISound

    Private _name As String
    Private _age As String

    'Function GetName() As String
    '    Return _name
    'End Function
    'Sub SetName(newName As String)
    '    _name = newName
    'End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)

            _name = value
        End Set
    End Property

    Public WriteOnly Property Age() As String

        Set(ByVal value As String)
            _age = value
        End Set
    End Property

    Public Property Sound As String Implements ISound.Sound
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Overridable Sub Walk()
        Console.WriteLine("This is the animal walking!")
    End Sub

    Sub New()
        'Own implementation
        _name = "New Animal"
        Console.WriteLine("This is the Animal class's constructor")
    End Sub

    Sub New(newname As String)
        _name = newname
        Console.WriteLine("This is the Animal class's parameterized constructor")
    End Sub

    Public Sub MakeSound() Implements ISound.MakeSound
        Throw New NotImplementedException()
    End Sub
End Class
