Imports System.Net.Security

Module ex93
    Sub main()

        Dim nombrepremier As Double

        Do
            Console.WriteLine("combien de nombre premier a afficher")
            nombrepremier = Console.ReadLine()
        Loop Until nombrepremier > 0

        For i = 1 To nombrepremier
            Console.WriteLine(i * 2)
        Next
        Console.ReadLine()

    End Sub
End Module
