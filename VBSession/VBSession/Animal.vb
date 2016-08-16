Public Class Animal
    Private _name As String
    Private _breed As String
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

    Public ReadOnly Property Breed() As String
        Get
            Return _breed
        End Get

    End Property


    Public WriteOnly Property Age() As String

        Set(ByVal value As String)
            _age = value
        End Set
    End Property
End Class
