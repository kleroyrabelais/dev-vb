Public Class Pile
    Private Const MAX As Integer = 100
    Private tabpile(MAX) As String
    Private posistionLibre As Integer
    Public Function Empiler(ByVal valeur As String) As Boolean
        If posistionLibre = MAX Then
            Return False
        End If
        tabpile(posistionLibre) = valeur
        posistionLibre += 1
        Return True
    End Function
    Public Function Depiler() As String
        If posistionLibre = 0 Then
            Return "Pile vide"
        End If
        posistionLibre -= 1
        Return tabpile(posistionLibre)
    End Function
    Public Function EstVide() As Boolean
        If posistionLibre = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function NbElement() As Integer
        Return posistionLibre
    End Function
    Public Function Tostring() As String
        Dim chaine As String = ""
        For i = 0 To posistionLibre - 1
            chaine = chaine & tabpile(i) & " "
        Next
        Return chaine
    End Function
End Class