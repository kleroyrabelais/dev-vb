Module _1313
    Sub main()
        Dim nombre, binaire, octodécimale As Double

        Console.WriteLine("entre un nombre entre 0 et 255, 256 pour quitter")
        Select Case nombre
            Case 1
                nombre = Console.ReadLine
                Do
                    nombre = nombre / 2
                    Console.Write("1")
                Loop Until nombre < 1
            Case 2
                Console.ReadLine() 'essaye de faire un between 0 et 255 pour le 1 et case = 256 pour le 2
        End Select
    End Sub
End Module
