Imports VBSession

Public Class Cat
    Inherits Animal
    Implements ISound

    Sub New()
        Console.WriteLine("This is the cat claas's constructor")
    End Sub

    Public Property Sound As String Implements ISound.Sound
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub MakeSound() Implements ISound.MakeSound
        Console.WriteLine("Hurray! I can now have my own implementation of making sounds here! Meow!!")
    End Sub
End Class
