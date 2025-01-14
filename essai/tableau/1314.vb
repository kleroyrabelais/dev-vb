Module _1314
    Sub main()

        Dim montant As Double
        Dim trouve As Boolean = False

        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                           "LUF", "NLG", "GRD", "SIT", "ATS", "PTE", "CYP", "MTL", "SKK"}

        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                        40.33, 2.2, 340.75, 239.64, 13.76, 200.48, 0.58, 0.42, 30.12}


        Do
            Console.WriteLine("montant en euro ou 0")

        Loop Until montant > -1 Or montant = 0
        If montant = 0 Then
            Console.ReadLine()
        End If
        While trouve = False
            Console.WriteLine("code devise ?")

        End While
    End Sub
End Module
