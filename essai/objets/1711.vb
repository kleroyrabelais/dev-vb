Module TestCompteur
    Sub Main()
        Dim cA As New Compteur(10)
        Dim cB As New Compteur(50)
        Dim cC As New Compteur(0)
        cA.PlusUn()
        Console.WriteLine("Valeur après PlusUn : " + cA.GetValeur())

        cA.IncrementeDe(10)
        Console.WriteLine("Valeur après IncrementeDe(10) : " + cA.GetValeur())

        cA.DecrementeDe(5)
        Console.WriteLine("Valeur après DecrementeDe(5) : " + cA.GetValeur())

        cA.IncrementeDe(-10)
        Console.WriteLine("Valeur après IncrementeDe(-10) : " + cA.GetValeur())

        cA.Raz()
        Console.WriteLine("Valeur après Raz : " + cA.GetValeur())
        Console.ReadLine()
    End Sub
End Module
