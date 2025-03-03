Module _1734
    Sub main()
        Dim choix As Integer
        Dim pile As New Pile
        Do
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-")
            Console.WriteLine("1. empiler")
            Console.WriteLine("2. depiler")
            Console.WriteLine("3. tester si la pile est vide")
            Console.WriteLine("4. nb d'élément dans la pile")
            Console.WriteLine("5. conetenu de la pile")
            Console.WriteLine("6. Quitter")
            Console.WriteLine("Votre choix ?")
            choix = Console.ReadLine()
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-")
            If choix < 1 Or choix > 6 Then
                Console.WriteLine("Choix incorrect entrer un nombre entre 1 et 6")
            End If
            Select Case choix
                Case 1
                    Console.WriteLine("Entrer l'élément à empiler")
                Case 2
                    Console.WriteLine("Valeur éxtraite de la pile")
                Case 3
                    Console.WriteLine("(test si la pile est vide)")
                Case 4
                    Console.WriteLine("nombre d'élément dans la pile")
                Case 5
                    Console.WriteLine("affiche les élément de la pile")
                Case 6
                    Exit Sub

            End Select
        Loop Until choix = 6
    End Sub
End Module
