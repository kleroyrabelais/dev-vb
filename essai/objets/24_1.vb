Imports System.Collections

Module GestionProduits

    ' Classe Produit en VB
    Public Class Produit
        Private designation As String
        Private prixHT As Double
        Private tauxTVA As Double

        ' Constructeur
        Public Sub New(pDesignation As String, pPrixHT As Double, pTauxTVA As Double)
            designation = pDesignation
            prixHT = pPrixHT
            tauxTVA = pTauxTVA
        End Sub

        ' Augmenter le prix HT
        Public Sub AugmenterPrix(pourcentage As Double)
            prixHT += prixHT * (pourcentage / 100)
        End Sub

        ' Baisser le prix HT
        Public Sub BaisserPrix(pourcentage As Double)
            prixHT -= prixHT * (pourcentage / 100)
        End Sub

        ' Obtenir le prix HT
        Public Function GetPrixHT() As Double
            Return prixHT
        End Function

        ' Obtenir la désignation
        Public Function GetDesignation() As String
            Return designation
        End Function

        ' Obtenir le taux de TVA
        Public Function GetTauxTVA() As Double
            Return tauxTVA
        End Function

        ' Modifier le taux de TVA
        Public Sub SetTauxTVA(nouvTauxTVA As Double)
            tauxTVA = nouvTauxTVA
        End Sub

        ' Calculer le prix TTC
        Public Function GetPrixTTC() As Double
            Return prixHT + (prixHT * tauxTVA / 100)
        End Function

        ' Affichage de l'objet sous forme de chaîne
        Public Overrides Function ToString() As String
            Return $"Désignation : {designation}{vbCrLf}Prix HT : {prixHT}{vbCrLf}Taux TVA : {tauxTVA}{vbCrLf}Prix TTC : {GetPrixTTC()}"
        End Function
    End Class

    ' Déclaration du catalogue comme Hashtable
    Dim catalogue As New Hashtable()

    Sub Main()
        Dim choix As Integer

        Do
            ' Affichage du menu
            Console.WriteLine("Menu :")
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

            ' Demander le choix de l'utilisateur
            Console.Write("Choix ? ")
            choix = Integer.Parse(Console.ReadLine())

            Select Case choix
                Case 1
                    ' Ajouter un produit
                    AjouterProduit()

                Case 2
                    ' Augmenter le prix HT d'un produit
                    AugmenterPrixProduit()

                Case 3
                    ' Baisser le prix HT d'un produit
                    BaisserPrixProduit()

                Case 4
                    ' Modifier le taux de TVA d'un produit
                    ModifierTVAProduit()

                Case 5
                    ' Augmenter tous les produits
                    AugmenterTousLesProduits()

                Case 6
                    ' Supprimer un produit
                    SupprimerProduit()

                Case 7
                    ' Afficher tous les produits
                    AfficherTousLesProduits()

                Case 8
                    ' Afficher un produit
                    AfficherProduit()

                Case 9
                    ' Vider le catalogue
                    ViderCatalogue()

                Case 10
                    ' Quitter
                    Console.WriteLine("Merci de votre visite!")
                    Exit Do

                Case Else
                    Console.WriteLine("Choix invalide, veuillez réessayer.")
            End Select

            ' Pause avant de revenir au menu
            Console.WriteLine(vbCrLf & "... Rappel Menu ...")
        Loop While choix <> 10
    End Sub

    ' Ajouter un produit
    Sub AjouterProduit()
        Console.Write("Saisir la désignation du produit: ")
        Dim designation = Console.ReadLine()

        Console.Write("Saisir le prix HT du produit: ")
        Dim prixHT = Double.Parse(Console.ReadLine())

        Console.Write("Saisir le taux de TVA du produit: ")
        Dim tauxTVA = Double.Parse(Console.ReadLine())

        Console.Write("Saisir la référence du produit: ")
        Dim reference = Console.ReadLine()

        Dim produit As New Produit(designation, prixHT, tauxTVA)
        catalogue.Add(reference, produit)

        Console.WriteLine("Produit ajouté avec succès!")
    End Sub

    ' Augmenter le prix HT d'un produit
    Sub AugmenterPrixProduit()
        Console.Write("Référence du produit: ")
        Dim reference = Console.ReadLine()

        If catalogue.ContainsKey(reference) Then
            Console.Write("Pourcentage d'augmentation ? ")
            Dim pourcentage = Double.Parse(Console.ReadLine())
            Dim produit As Produit = CType(catalogue(reference), Produit)
            produit.AugmenterPrix(pourcentage)
            Console.WriteLine("Prix HT du produit mis à jour!")
        Else
            Console.WriteLine("Produit non trouvé.")
        End If
    End Sub

    ' Baisser le prix HT d'un produit
    Sub BaisserPrixProduit()
        Console.Write("Référence du produit: ")
        Dim reference = Console.ReadLine()

        If catalogue.ContainsKey(reference) Then
            Console.Write("Pourcentage de baisse ? ")
            Dim pourcentage = Double.Parse(Console.ReadLine())
            Dim produit As Produit = CType(catalogue(reference), Produit)
            produit.BaisserPrix(pourcentage)
            Console.WriteLine("Prix HT du produit mis à jour!")
        Else
            Console.WriteLine("Produit non trouvé.")
        End If
    End Sub

    ' Modifier le taux de TVA d'un produit
    Sub ModifierTVAProduit()
        Console.Write("Référence du produit: ")
        Dim reference = Console.ReadLine()

        If catalogue.ContainsKey(reference) Then
            Console.Write("Nouveau taux de TVA: ")
            Dim tauxTVA = Double.Parse(Console.ReadLine())
            Dim produit As Produit = CType(catalogue(reference), Produit)
            produit.SetTauxTVA(tauxTVA)
            Console.WriteLine("Taux de TVA du produit mis à jour!")
        Else
            Console.WriteLine("Produit non trouvé.")
        End If
    End Sub

    ' Augmenter tous les produits du catalogue
    Sub AugmenterTousLesProduits()
        Console.Write("Pourcentage d'augmentation pour tous les produits ? ")
        Dim pourcentage = Double.Parse(Console.ReadLine())

        For Each key As DictionaryEntry In catalogue
            Dim produit As Produit = CType(key.Value, Produit)
            produit.AugmenterPrix(pourcentage)
        Next

        Console.WriteLine("Tous les produits ont été augmentés!")
    End Sub

    ' Supprimer un produit
    Sub SupprimerProduit()
        Console.Write("Référence du produit à supprimer: ")
        Dim reference = Console.ReadLine()

        If catalogue.ContainsKey(reference) Then
            catalogue.Remove(reference)
            Console.WriteLine("Produit supprimé avec succès!")
        Else
            Console.WriteLine("Produit non trouvé.")
        End If
    End Sub

    ' Afficher tous les produits
    Sub AfficherTousLesProduits()
        If catalogue.Count > 0 Then
            For Each key As DictionaryEntry In catalogue
                Dim produit As Produit = CType(key.Value, Produit)
                Console.WriteLine(produit.ToString())
            Next
        Else
            Console.WriteLine("Le catalogue est vide.")
        End If
    End Sub

    ' Afficher un produit
    Sub AfficherProduit()
        Console.Write("Référence du produit: ")
        Dim reference = Console.ReadLine()

        If catalogue.ContainsKey(reference) Then
            Dim produit As Produit = CType(catalogue(reference), Produit)
            Console.WriteLine(produit.ToString())
        Else
            Console.WriteLine("Produit non trouvé.")
        End If
    End Sub

    ' Vider le catalogue
    Sub ViderCatalogue()
        catalogue.Clear()
        Console.WriteLine("Catalogue vidé.")
    End Sub

End Module
