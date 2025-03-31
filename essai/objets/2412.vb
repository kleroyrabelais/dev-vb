Module _2412
    Dim unProduit As New Hashtable
    Sub main()
        Dim choix As Integer

        Do
            Console.WriteLine("1. Ajouter un produit au catalogue")
            Console.WriteLine("2. Augmenter le prix HT d'un produit")
            Console.WriteLine("3. Baisser le prix HT d'un produit")
            Console.WriteLine("4. Modifier le taux de TVA d'un produit")
            Console.WriteLine("5. Augmenter tous les produits du catalogue")
            Console.WriteLine("6. Supprimer un produit du catalogue")
            Console.WriteLine("7. Afficher toutes les informations sur tous les produits")
            Console.WriteLine("8. Afficher toutes les informations sur un produit")
            Console.WriteLine("9. Vider le catalogue")
            Console.WriteLine("10. Quitter")
            Console.Write("Choix ? ")
            choix = Integer.Parse(Console.ReadLine())

            Select Case choix
                Case 1
                    Console.WriteLine("saisir la designation du produit")
                    Console.WriteLine("saisir le prix HT")
                    Console.WriteLine("saisir le taux de TVA")
                    Console.WriteLine("saisir la référence du produit")
                    AjouterProduit()
                Case 2
                    Console.WriteLine("saisir prix HT (supérieur a celui de base)")
                    ModifierPrix()
                Case 3
                    Console.WriteLine("saisir prix HT (inférieure a celui de base)")
                    ModifierPrix()
                Case 4
                    Console.WriteLine("saisir la designation du produit")
                    Console.WriteLine("saisir pour modifier TVA")
                    ModifierTVA()
                Case 5
                    Console.WriteLine("saisir un nombre pour augmenter les prix de tant")
                    AugmenterTousLesPrix()
                Case 6
                    Console.WriteLine("saisir la designation du produit")
                    SupprimerProduit()
                Case 7
                    AfficherCatalogue()
                Case 8
                    Console.WriteLine("saisir la designation du produit")
                    AfficherProduit()
                Case 9
                    ViderCatalogue()
                Case Else
                    Console.WriteLine("Choix invalide !")
            End Select
        Loop Until choix = 10
    End Sub
End Module
