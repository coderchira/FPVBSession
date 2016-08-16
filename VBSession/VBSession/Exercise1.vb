Module Exercise1
    ' Define 1 collection , which has 10 names
    ' Define another Collection which is empty
    ' In the second collection, copy/ move all items of collection 1 except for your name!

    Dim names As New Collection
    Dim coll2 As New Collection
    Sub CollectionsExercise()
        names.Add("Shivam")
        names.Add("prakhar")
        names.Add("harshavardhana")
        names.Add("abhishek")
        names.Add("rohith")
        names.Add("rohith")
        names.Add("deepti")
        names.Add("sai")
        names.Add("siva")
        names.Add("Ruchira")

        For Each item In names
            If item = "Ruchira" Then
                Continue For
            Else
                coll2.Add(item)
            End If
        Next
        For Each item In coll2
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub
End Module
