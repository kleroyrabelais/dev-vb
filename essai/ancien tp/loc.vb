Module cout_de_location
    Sub main()
        Dim locd As Integer = 35
        Dim loce As Integer = 30
        Dim loc As Integer
        Dim km As Double
        Dim diez As Double = 1.55
        Dim ess As Double = 1.89
        Dim res1 As Double
        Dim res2 As Double
        Console.WriteLine("Combien de jour de location")
        loc = Console.ReadLine()
        Console.WriteLine("combien de distance")
        km = Console.ReadLine()
        res1 = locd + (loc + (km * diez))
        res2 = loce + (loc + (km * ess))
        If res1 < res2 Then
            Console.WriteLine("Meilleur choix : diezel et prix : " + res1.ToString)
        ElseIf res2 < res1 Then
            Console.WriteLine("Meilleur choix : essence et prix : " + res2.ToString)
        ElseIf res1 = res2 Then
            Console.WriteLine("Pas de meilleur choix")
            Console.WriteLine("choisissez ce que vous voulez")
        End If
        Console.ReadLine()
    End Sub
End Module
