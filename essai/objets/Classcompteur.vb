Public Class Compteur
    Private valeur As Integer
    Public Sub New(ByVal nouvValeur As Integer)
        valeur = nouvValeur
    End Sub
    Public Function GetValeur() As Integer
        Return valeur
    End Function
    Public Sub PlusUn()
        valeur += 1
    End Sub
    Public Sub Raz()
        valeur = 0
    End Sub
    Public Sub IncrementeDe(ByVal pValeur As Integer)
        If pValeur > 0 Then
            valeur += pValeur
        End If
    End Sub
    Public Sub DecrementeDe(ByVal pValeur As Integer)
        If pValeur > 0 Then
            valeur -= pValeur
        End If
    End Sub
End Class