Module _15_1sus
    Structure TClient
        Dim code As String
        Dim nom As String
        Dim adresse As String
    End Structure

    Structure TCommande
        Dim numéro As Integer
        Dim dateC As String
        Dim montant As Double
        Dim codeClient As String
    End Structure

    ' Affiche les détails d'un client
    Sub AfficherUnClient(ByVal pUnClient As TClient)
        Console.WriteLine("Code client : " & pUnClient.code)
        Console.WriteLine("Nom : " & pUnClient.nom)
        Console.WriteLine("Adresse : " & pUnClient.adresse)
    End Sub

    ' Retourne le client correspondant au numéro de commande donné
    Function ClientPourUneCommande(ByVal pNuméroCommande As Integer, ByVal pTabCommandes() As TCommande, ByVal pTabClients() As TClient) As TClient
        For Each commande As TCommande In pTabCommandes
            If commande.numéro = pNuméroCommande Then
                For Each client As TClient In pTabClients
                    If client.code = commande.codeClient Then
                        Return client
                    End If
                Next
            End If
        Next
        ' Retourne un client vide si non trouvé
        Return New TClient With {.code = "X"}
    End Function

    ' Retourne le montant total commandé par un client donné
    Function MontantCommandé(ByVal pCodeClient As String, ByVal pTabCommandes() As TCommande) As Double
        Dim total As Double = 0
        For Each commande As TCommande In pTabCommandes
            If commande.codeClient = pCodeClient Then
                total += commande.montant
            End If
        Next
        Return total
    End Function

    Sub Main()
        ' Initialisation des données
        Dim codeclient As String
        Dim chois As Integer
        ' Définition des clients et commandes directement
        Dim lesClients() As TClient = {
            New TClient With {.code = "C01", .nom = "NomC01", .adresse = "AdresseC01"},
            New TClient With {.code = "C02", .nom = "NomC02", .adresse = "AdresseC02"},
            New TClient With {.code = "C03", .nom = "NomC03", .adresse = "AdresseC03"}
        }

        Dim lesCommandes() As TCommande = {
            New TCommande With {.numéro = 1, .dateC = "01-01-01", .montant = 100, .codeClient = "C02"},
            New TCommande With {.numéro = 2, .dateC = "02-01-02", .montant = 200, .codeClient = "C01"},
            New TCommande With {.numéro = 3, .dateC = "02-01-03", .montant = 300, .codeClient = "C02"}
        }

        ' Affichage du menu
        Do
            Console.WriteLine("1. Montant total des commandes passées par un client (code client)")
            Console.WriteLine("2. Détails d'un client pour une commande (n° de commande)")
            Console.WriteLine("3. Quitter")
            Console.Write("Choix ? ")
            chois = Convert.ToInt32(Console.ReadLine())

            Select Case chois
                Case 1
                    ' 1. Montant total des commandes passées par un client
                    Console.Write("Code client ? ")
                    codeclient = Console.ReadLine()
                    Dim montant As Double = MontantCommandé(codeclient, lesCommandes)
                    Console.WriteLine("Montant commandé : " & montant)
                    Console.WriteLine(". . . Rappel Menu . . .")

                Case 2
                    ' 2. Détails d'un client pour une commande
                    Console.Write("Numéro commande ? ")
                    Dim numCommande As Integer = Convert.ToInt32(Console.ReadLine())
                    Dim client As TClient = ClientPourUneCommande(numCommande, lesCommandes, lesClients)

                    If client.code = "X" Then
                        Console.WriteLine("Client ou commande non trouvé(e)")
                    Else
                        AfficherUnClient(client)
                    End If
                    Console.WriteLine(". . . Rappel Menu . . .")

                Case 3
                    ' 3. Quitter
                    Console.WriteLine("Au revoir")
                    Exit Do

                Case Else
                    Console.WriteLine("Choix invalide, réessayez.")
            End Select
        Loop
    End Sub
End Module
