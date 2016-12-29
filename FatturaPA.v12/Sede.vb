Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class Sede
    ''' <summary>
    ''' Indirizzo della sede del cedente o prestatore (nome della via, piazza etc.) 
    ''' </summary>
    Public Indirizzo As String
    ''' <summary>
    ''' Numero civico riferito all'indirizzo (non indicare se già presente nell'elemento informativo indirizzo)
    ''' </summary>
    Public NumeroCivico As String
    ''' <summary>
    ''' Codice Avviamento Postale 
    ''' </summary>
    Public CAP As String
    ''' <summary>
    ''' Comune relativo alla sede del cedente / prestatore
    ''' </summary>
    Public Comune As String
    ''' <summary>
    ''' Sigla della provincia di appartenenza del comune indicato nell'elemento informativo "Comune".
    ''' Da valorizzare se l'elemento informativo "Nazione" è uguale a IT
    ''' </summary>
    Public Provincia As String
    ''' <summary>
    ''' Codice della nazione espresso secondo lo standard ISO 3166-1 alpha-2 code 
    ''' </summary>
    Public Nazione As String
End Class
