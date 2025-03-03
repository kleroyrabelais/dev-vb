Module boucle_for
    Sub Main()
        Dim n, i, Somme As Integer
        Do
            Console.WriteLine("Saisir le nombre :")
            n = Console.ReadLine()
        Loop Until n > 0
        Somme = 0
        For i = 1 To n
            Somme = Somme + i
        Next
        Console.WriteLine("La somme vaut : " + Somme.ToString())
        Console.ReadLine()
    End Sub
End Module
