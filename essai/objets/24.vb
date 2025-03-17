Module _24
    Sub main()
        Dim prixHT, tauxTVA As Double
        Dim choi As Integer
        Dim designation, reference As String
        Do
            Console.WriteLine("1. Ajouter un produit au catalogue")
            Console.WriteLine("2. Augmenter le prix HT d'un produit")
            Console.WriteLine("3. Baisser le prix HT d'un produit")
            Console.WriteLine("4. Modifier le taux de TVA d'un produit")
            Console.WriteLine("5. Augmenter tous les produits du catalogue")
            Console.WriteLine("6. Supprimer un produit du catalogue")
            Console.WriteLine("7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)")
            Console.WriteLine("8. Afficher toutes les informations sur un produit (inc. Prix TTC)")
            Console.WriteLine("9. Vider le catalogue")
            Console.WriteLine("10. Quitter")
            choi = Console.ReadLine()
            Select Case choi
                Case 1
                    Console.WriteLine("Saisir la désignation du produit")
                    designation = Console.ReadLine()
                    Console.WriteLine("Saisir le prix HT du produit")
                    prixHT = Console.ReadLine()
                    Console.WriteLine("Saisir le taux de TVA du produit")
                    tauxTVA = Console.ReadLine()
                    Console.WriteLine("Saisir la référence du produit")
                Case 2
                    Console.WriteLine("2") 'prendre ref d'un produit et augmenter prix HT
                Case 3
                    Console.WriteLine("3") 'prendre ref d'un produit et baisser prix HT
                Case 4
                    Console.WriteLine("4") 'prendre ref d'un produit et +/- tauxTVA
                Case 5
                    Console.WriteLine("5") 'augmenter touts les prix HT de ...
                Case 6
                    Console.WriteLine("6") 'prendre ref et le suppr
                Case 7 'afficher toutes les info de chaque produit + prixTTC
                    Console.WriteLine("Référence du produit")
                    Console.WriteLine("Désignation du produit")
                    Console.WriteLine("Prix HT du produit")
                    Console.WriteLine("Taux de TVA du produit")
                    Console.WriteLine("Prix TTC du produit")
                Case 8
                    Console.WriteLine("8") 'prendre ref d'un produit et afficher tt info y compris prixTTC
                Case 9
                    Console.WriteLine("9")
                Case 10
                    Console.WriteLine("aurevoir")
                Case Else
                    Console.WriteLine("mauvais choix veuiller entre un chiffre entre 1 et 10, 10 étant pour quitter")
            End Select
        Loop Until choi = 10
        Console.ReadLine()
    End Sub
End Module
