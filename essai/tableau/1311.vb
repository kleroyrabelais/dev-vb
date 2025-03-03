Module _1311
    Sub main()
        Dim mois(11) As String
        Dim nombre As Integer
        mois(0) = "Janvier"
        mois(1) = "février"
        mois(2) = "mars"
        mois(3) = "avril"
        mois(4) = "mai"
        mois(5) = "juin"
        mois(6) = "juillet"
        mois(7) = "aout"
        mois(8) = "septembre"
        mois(9) = "octobre"
        mois(10) = "novembre"
        mois(11) = "décembre"
        Do
            Console.WriteLine("entre un nombre 1 pour janvier 12 pour décembre 13 pour quitter")
            nombre = Console.ReadLine()
            Console.WriteLine("ton mois est " + mois(nombre - 1))
        Loop Until nombre = 12
        Console.ReadLine()
    End Sub
End Module
