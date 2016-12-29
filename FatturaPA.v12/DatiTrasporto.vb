Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class DatiTrasporto
    ''' <summary>
    ''' Blocco contenente i dati fiscali e anagrafici del vettore
    ''' </summary>
    Public DatiAnagraficiVettore As DatiAnagraficiVettore
    ''' <summary>
    ''' Mezzo utilizzato per il trasporto
    ''' </summary>
    Public MezzoTrasporto As String
    ''' <summary>
    ''' Causale del trasporto
    ''' </summary>
    Public CausaleTrasporto As String
    ''' <summary>
    ''' Numero dei colli trasportati
    ''' </summary>
    Public NumeroColli As String
    ''' <summary>
    ''' Descrizione (natura, qualità, aspetto …) relativa ai colli trasportati
    ''' </summary>
    Public Descrizione As String
    ''' <summary>
    ''' Unità di misura riferita al peso della merce
    ''' </summary>
    Public UnitaMisuraPeso As String
    ''' <summary>
    ''' Peso lordo della merce
    ''' </summary>
    Public PesoLordo As String
    ''' <summary>
    ''' Peso netto della merce
    ''' </summary>
    Public PesoNetto As String
    ''' <summary>
    ''' Data e ora del ritiro della merce (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataOraRitiro As String
    ''' <summary>
    ''' Data di inizio del trasporto (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataInizioTrasporto As String
    ''' <summary>
    ''' Codifica del termine di resa espresso secondo lo standard ICC-Camera di Commercio Internazionale (Incoterms)
    ''' </summary>
    Public TipoResa As String
    ''' <summary>
    ''' Dati dell'indirizzo di resa
    ''' </summary>
    Public IndirizzoResa As IndirizzoResa
    ''' <summary>
    ''' Data e ora della consegna della merce (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataOraConsegna As String
End Class
