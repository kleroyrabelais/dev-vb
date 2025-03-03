Module calc_salaire
    Sub Main()
        Dim thb As Integer = 39
        Dim ht As Integer
        Dim res As Double
        Dim th As Double
        Console.WriteLine("Nombre d'heure de travaille")
        ht = Console.ReadLine()
        If ht <= 39 Then
            Console.WriteLine("Vous ne travaillez pas asser !!")
            Console.WriteLine("Salaire hebdomadaire : 0")
            Console.WriteLine("Au boulot")
        ElseIf ht <= 47 Then
            Console.WriteLine("Taux horaires ?")
            th = Console.ReadLine()
            res = ht * (th * ((8 / 100) * 25))
            Console.WriteLine("Salaire hebdomadaire : " + res.ToString)
            Console.WriteLine("Bonne lancée")
        ElseIf ht > 47 Then
            Console.WriteLine("Taux horaires ?")
            th = Console.ReadLine()
            res = ht * (th * ((8 / 100) * 50))
            Console.WriteLine("Salaire hebdomadaire : " + res.ToString)
            Console.WriteLine("Employé du mois")
        End If
        Console.ReadLine()
    End Sub
End Module
