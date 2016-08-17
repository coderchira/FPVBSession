Public Class Dog ' child class/ dervied class / sub class
    Inherits Animal ' base class/ generic class / parent class

    Private _breed As String

    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Overrides Sub Walk()
        Console.WriteLine("This is the Dog Walking which has a different behavior")
    End Sub
End Class
