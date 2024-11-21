Imports System.Reflection.Emit

Module ex_91
    Sub Main()
        Dim note As Double
        Dim moyenne As Double
        Dim compteur As Integer
        Dim ttnotes As Double
        Dim notesub10 As Integer
        Dim pourcentagesub10 As Integer
        Do


            Console.WriteLine("entre votre note -1 pour fin")

            note = Console.ReadLine()
            If note >= 10 Then
                notesub10 = notesub10 + 1
            End If
            compteur = compteur + 1
            ttnotes = ttnotes + note
            If note = -1 Then
                compteur = compteur - 1
                ttnotes = ttnotes + 1
            End If

        Loop Until note = -1
        pourcentagesub10 = (notesub10 * 100) / compteur
        moyenne = ttnotes / compteur
        Console.WriteLine("La moyenne est de " + moyenne.ToString())
        Console.WriteLine("Vous avez " + pourcentagesub10.ToString + "% de notes supértieure a 10")
        Console.ReadLine()
    End Sub
End Module
