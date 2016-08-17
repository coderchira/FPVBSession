Module Module1

    Sub Main()
        'Dim myCatObj1 As New Cat

        Dim mySound As ISound ' handl;e to the interface
        mySound = New Cat
        CType(mySound, Cat).Age = 2



        Dim animalObj As Animal 'Handle of the base class
        Dim dogObj As Dog

        dogObj = New Dog 'creating object of child class
        animalObj = dogObj ' handle of the base class that points to the object of child class

        CType(animalObj, Dog).Breed = "Boxer"

        Dim dogObj2 As Dog
        Dim animalObj2 As Animal

        animalObj2 = New Animal
        dogObj2 = animalObj2 ' generic to specific -- this is illegeal

        ' objects of a class
        ' instantiation of object of a class
        'Dim animalObj As New Animal
        'animalObj.Name = "Bruno"
        'Console.WriteLine(animalObj.Name())
        'animalObj.Age = "2"
        'Console.WriteLine(animalObj.Breed())

        ' Dim animalObj As New Animal
        ' animalObj.Walk()

        'Dim dogObj As New Dog
        'dogObj.Breed = "Golden Retriver"
        'dogObj.Walk()
        'Dim animalObj As Animal
        'animalObj = New Animal("new name of animal")

        'Dim animalObj1 As New Animal("new name of animal")

        'Dim catObj As New Cat
        ' catObj.Walk()

        ' animalObj.SetName("Bruno")
        ' Dim animalName As String = animalObj.GetName()
        'Console.WriteLine(animalName)
        Console.ReadLine()

        Exercise1.CollectionsExercise()
        Logic.CalcAge(10, 12.3, True)
        ' Logic.CalcAge()

        Dim rtrValue As Boolean = LogicDemo.DoThis()
        Console.WriteLine(rtrValue)
        'What is a Program?
        '   Set of instructions - to perform a particular task
        '   Data <--> Logic
        '   Data
        '       Variables
        '           Native Type / Value type
        '               Fixed in size
        '               Stored on stack (Memory management system)
        '               Faster to access
        '               Dispose on their own
        '           Object Type / Reference type
        '               Varying Size
        '               Stored on heap
        '               Slower to access
        '               Dispose them explicitly
        '       Constants

        'Lifecycle of variable
        ' Declare
        ' Assign/ Use
        ' Dispose
        Dim flag As Boolean ' 2 bytes
        Dim num As Integer ' 4 bytes
        Dim sng As Single ' 4 bytes
        Dim dbl As Double ' 8 bytes -- 8 digits
        Dim prec As Decimal ' 16 bytes -- scientific/ financial - 16 digits
        Dim name As String ' depending on the size you define

        flag = True
        num = 10
        sng = 1.2446
        dbl = 232.38264832
        prec = 1.23715371
        name = "Ruchira"

        Console.WriteLine("The value of name is " & name)
        Console.WriteLine("The value of name is {0} and the value of flag is {1}", name, flag)
        Console.ReadLine()

        Dim name2 As String = "Ruchira"

        'Integer operations
        Dim num1 As Integer = 20
        Dim num2 As Integer = 30
        'Dim num3 As Integer

        'Add
        Dim additionResult As Integer
        additionResult = num1 + num2
        'num3 = num1 + num2

        'Subtract
        Dim subtResult As Integer
        subtResult = num1 - num2
        ' num3 = num1 - num2

        'multiplication
        Dim prod As Integer
        prod = num1 * num2

        'Division
        Dim divResult As Integer
        divResult = num2 / num1

        Dim remainder As Integer
        Dim quotient As Integer
        quotient = Math.DivRem(num2, num1, remainder)

        ' String operations
        Dim text1 As String
        Dim text2 As String
        text1 = "This is the VB Day 1"
        text2 = "and we are confident of learning!"

        'Concatenation
        Dim text3 As String = text1 & " " & text2
        Console.WriteLine(text3)

        ' Position of a word
        Dim position As Integer
        ' position = InStr(text3.ToUpper(), "VB")
        position = InStr(text3.ToLower(), "vb")
        'position = InStrRev(text3, "VB")
        Console.WriteLine(position)

        'Left and Right portions of a string
        Dim leftPortion As String
        leftPortion = Left(text3, 10)
        Console.WriteLine(leftPortion)
        Dim rightPortion As String
        rightPortion = Right(text3, 5)
        Console.WriteLine(rightPortion)
        Console.ReadLine()

        'Data conversions
        Dim number2 As Integer = 10
        Dim numAsString As String
        numAsString = CStr(number2)
        numAsString = number2.ToString()
        'Console.WriteLine(number2)
        'Console.WriteLine(numAsString)
        'Console.ReadLine()

        Dim str2 As String = "40"
        Dim strAsNum As Integer
        strAsNum = CInt(str2)
        'Console.WriteLine(str2)

        Dim length As Integer
        length = text3.Length()
        'CDbl , CDec etc.

        'Object type variables
        Dim pColl As New Collection
        pColl.Add(20)
        pColl.Add("Ruchira")
        pColl.Add(40)
        pColl.Add(True)


        'Dim pColl2 As New Collection
        'pColl2.Add(pColl)

        Console.WriteLine("The items in collection are {0}, {1},{2},{3}", pColl.Item(1), pColl.Item(2), pColl.Item(3), pColl.Item(4))
        pColl.Remove(4)
        Console.WriteLine("The items in collection are {0}, {1},{2}", pColl.Item(1), pColl.Item(2), pColl.Item(3))
        Console.ReadLine()

        'Dispose
        pColl = Nothing
        ' Console.WriteLine("The items in collection are {0}, {1},{2}", pColl.Item(1), pColl.Item(2), pColl.Item(3))

        Dim strsub As String = text1.Substring(4)
        Dim splitStr() As String = text1.Split(" ")
    End Sub

End Module
