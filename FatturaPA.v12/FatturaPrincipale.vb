Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class FatturaPrincipale
    ''' <summary>
    ''' Numero della fattura relativa al trasporto di beni, da indicare sulle fatture emesse dagli autotrasportatori per certificare le operazioni accessorie
    ''' </summary>
    Public NumeroFatturaPrincipale As String
    ''' <summary>
    ''' Data della fattura di cui all'elemento informativo 2.1.10.1 "NumeroFatturaPrincipale" (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataFatturaPrincipale As String
End Class
