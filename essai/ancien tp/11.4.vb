Module ex11_4
    Sub main()
        Dim nbligne As Integer
        Dim somme As Integer
        Do
            Do
                Console.WriteLine("combien de lignes pour votre triangle ? (>=0)/-1")
                nbligne = Console.ReadLine()
                If nbligne < -1 Then
                    Console.WriteLine("Erreur. > 0")
                End If
            Loop While nbligne = -1
            For i = nbligne To nbligne
                somme = somme + i
                Console.WriteLine(somme + "*")
            Next
        Loop Until nbligne = -1
        Console.ReadLine()
    End Sub
End Module
