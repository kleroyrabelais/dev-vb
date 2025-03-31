Namespace Produit
    Class Produit
        Private designation As String
        Private prixHT As Double
        Private tauxTVA As Double

        Public Sub New(ByVal pDesignation As String, ByVal pPrixHT As Double, ByVal pTauxTVA As Double)
            designation = pDesignation
            prixHT = pPrixHT
            tauxTVA = pTauxTVA
        End Sub

        Public Sub AugmenterPrix(ByVal pourcentage As Double)
            prixHT = prixHT + pourcentage / 100.0R * prixHT
        End Sub

        Public Sub BaisserPrix(ByVal pourcentage As Double)
            prixHT = prixHT - pourcentage / 100.0R * prixHT
        End Sub

        Public Function GetPrixHT() As Double
            Return prixHT
        End Function

        Public Function GetDesignation() As String
            Return designation
        End Function

        Public Function GetTauxTVA() As Double
            Return tauxTVA
        End Function

        Public Sub SetTauxTVA(ByVal nouvTauxTVA As Double)
            tauxTVA = nouvTauxTVA
        End Sub

        Public Function GetPrixTTC() As Double
            Return prixHT + tauxTVA * prixHT / 100.0R
        End Function

        Public Overrides Function ToString() As String
            Return vbLf & "Désignation : " & designation & vbLf & "Prix HT : " & prixHT.ToString() & vbLf & "Taux TVA : " & tauxTVA.ToString() & vbLf & "Prix TTC : " & GetPrixTTC().ToString()
        End Function
    End Class
End Namespace