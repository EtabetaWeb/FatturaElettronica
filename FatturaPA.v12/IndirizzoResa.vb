Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class IndirizzoResa
    ''' <summary>
    ''' Indirizzo di resa (nome della via, piazza etc.)
    ''' </summary>
    Public Indirizzo As String
    ''' <summary>
    ''' Numero civico riferito all'indirizzo di resa (non indicare se già presente nell'elemento informativo Indirizzo)
    ''' </summary>
    Public NumeroCivico As String
    ''' <summary>
    ''' Codice Avviamento Postale dell'indirizzo di resa
    ''' </summary>
    Public CAP As String
    ''' <summary>
    ''' Comune ove ha sede l'indirizzo di resa
    ''' </summary>
    Public Comune As String
    ''' <summary>
    ''' Sigla della provincia di appartenenza del comune indicato nell'elemento informativo 2.1.9.12.4 "Comune"
    ''' </summary>
    Public Provincia As String
    ''' <summary>
    ''' Codice della nazione espresso secondo lo standard ISO 3166-1 alpha-2 code
    ''' </summary>
    Public Nazione As String
End Class
