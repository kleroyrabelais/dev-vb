Module _15_2_1
    ' Définir la taille maximale du tableau
    Const MAX As Integer = 10
    Dim stock(MAX - 1) As String ' Tableau pour stocker les matériels
    Dim positionLibre As Integer = 0 ' Indice de la première position libre

    ' Fonction pour afficher le menu
    Sub AfficherMenu()
        Console.Clear()
        Console.WriteLine("Menu de gestion du stock:")
        Console.WriteLine("1. Ajouter un matériel dans le tableau.")
        Console.WriteLine("2. Supprimer un matériel (saisie index).")
        Console.WriteLine("3. Supprimer un matériel (saisie n° série).")
        Console.WriteLine("4. Lister tous les matériels.")
        Console.WriteLine("5. Quitter.")
        Console.Write("Veuillez choisir une option (1-5): ")
    End Sub

    ' Fonction pour ajouter un matériel
    Sub AjouterMateriel()
        If positionLibre < MAX Then
            Console.Write("Entrez le nom du matériel: ")
            stock(positionLibre) = Console.ReadLine()
            positionLibre += 1
            Console.WriteLine("Matériel ajouté avec succès.")
        Else
            Console.WriteLine("Le stock est plein, impossible d'ajouter un matériel.")
        End If
        Console.ReadKey()
    End Sub

    ' Fonction pour supprimer un matériel par index
    Sub SupprimerParIndex()
        Console.Write("Entrez l'index du matériel à supprimer (0 à " + (positionLibre - 1).ToString() + "): ")
        Dim index As Integer = Console.ReadLine()
        If index >= 0 And index < positionLibre Then
            For i As Integer = index To positionLibre - 2
                stock(i) = stock(i + 1) ' Décalage des éléments vers la gauche
            Next
            stock(positionLibre - 1) = Nothing ' Suppression de l'élément à la fin
            positionLibre -= 1
            Console.WriteLine("Matériel supprimé avec succès.")
        Else
            Console.WriteLine("Index invalide.")
        End If
        Console.ReadKey()
    End Sub

    ' Fonction pour supprimer un matériel par numéro de série
    Sub SupprimerParNumeroSerie()
        Console.Write("Entrez le numéro de série du matériel à supprimer: ")
        Dim numeroSerie As String = Console.ReadLine()
        Dim index As Integer = -1
        ' Recherche du matériel par numéro de série
        For i As Integer = 0 To positionLibre - 1
            If stock(i) = numeroSerie Then
                index = i
                Exit For
            End If
        Next
        If index <> -1 Then
            For i As Integer = index To positionLibre - 2
                stock(i) = stock(i + 1) ' Décalage des éléments vers la gauche
            Next
            stock(positionLibre - 1) = Nothing 'supression du dernier élément
            positionLibre -= 1
            Console.WriteLine("Matériel supprimé avec succès.")
        Else
            Console.WriteLine("Matériel non trouvé.")
        End If
        Console.ReadKey()
    End Sub

    ' Fonction pour lister tous les matériels
    Sub ListerMateriels()
        If positionLibre = 0 Then
            Console.WriteLine("Aucun matériel dans le stock.")
        Else
            Console.WriteLine("Liste des matériels:")
            For i As Integer = 0 To positionLibre - 1
                Console.WriteLine(i.ToString() + ". " + stock(i))
            Next
        End If
        Console.ReadKey()
    End Sub

    Sub Main()
        Dim choix As Integer
        Do
            AfficherMenu()
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    AjouterMateriel()
                Case 2
                    SupprimerParIndex()
                Case 3
                    SupprimerParNumeroSerie()
                Case 4
                    ListerMateriels()
                Case 5
                    Console.WriteLine("Au revoir!")
                Case Else
                    Console.WriteLine("Choix invalide.")
            End Select
        Loop While choix <> 5
    End Sub
End Module
