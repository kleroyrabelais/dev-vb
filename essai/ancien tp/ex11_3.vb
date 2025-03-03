Imports System.ComponentModel.Design
Module ex11_3
    Sub main()
        Dim tfusee, taillef, V, Vo As Double
        Dim Casechoix As Integer
        Do
            Console.WriteLine("1. La dilatation du temps.")
            Console.WriteLine("2. La contraction des longeurs.")
            Console.WriteLine("3. Loi de composition des vitesses.")
            Console.WriteLine("4. Quitter")
            Casechoix = Console.ReadLine()
            If Casechoix < 1 Or Casechoix > 4 Then
                Console.WriteLine("Rentrer une valeur entre 1 et 4")
                Console.WriteLine("1. La dilatation du temps.")
                Console.WriteLine("2. La contraction des longeurs.")
                Console.WriteLine("3. Loi de composition des vitesses.")
                Console.WriteLine("4. Quitter")
                Casechoix = Console.ReadLine()

            End If
            Select Case Casechoix
                Case 1
                    Console.WriteLine("vitesse de la fusé en km/s")
                    V = Console.ReadLine()
                    Console.WriteLine("Durée écoulé dans la fusée en secondes")
                    tfusee = Console.ReadLine()
                    Console.WriteLine("temps de la dilation de la fusée :" + dilatationtemps(tfusee, V).ToString())
                Case 2
                    Console.WriteLine("vitesse de la fusée en km/s")
                    V = Console.ReadLine()
                    Console.WriteLine("taille de la fusé en km/s")
                    taillef = Console.ReadLine()
                    Console.WriteLine("taille de la fusée vue de la terre :" + contractionlongeurs(V, taillef).ToString())
                Case 3
                    Console.WriteLine("vitesse de la fusée en km/s")
                    V = Console.ReadLine()
                    Console.WriteLine("vitesse de l'obus, dans le repére de la fusée en km/s")
                    Vo = Console.ReadLine()
                    Console.WriteLine("vitesse de l'obus par rapport à la terre :" + compositionvitesse(V, Vo).Tostring())
                Case 4
                    Console.WriteLine("yokoso watashi no soul society")
            End Select
        Loop Until Casechoix = 4
        Console.ReadLine()
    End Sub
    Function dilatationtemps(ByVal ptfusee As Double, ByVal pV As Double) As Double 'p permet de pas s'embrouiller askip
        dilatationtemps = Math.Sqrt(1 - (ptfusee ^ 2 / pV ^ 2)) '^2 permet de faire V * V 
        Return dilatationtemps  ' valeur retournée
    End Function
    Function contractionlongeurs(ByVal pV As Double, ByVal ptaillef As Double) As Double
        contractionlongeurs = Math.Sqrt(1 - (pV ^ 2 / ptaillef ^ 2))
        Return contractionlongeurs
    End Function
    Function compositionvitesse(ByVal pV As Double, ByVal pVo As Double) As Double
        compositionvitesse = pV * pVo
        Return compositionvitesse
    End Function
End Module
