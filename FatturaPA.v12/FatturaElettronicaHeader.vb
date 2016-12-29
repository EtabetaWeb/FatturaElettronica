Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class FatturaElettronicaHeader
    ''' <summary>
    ''' 
    ''' </summary>
    Public DatiTrasmissione As DatiTrasmissione
    Public CedentePrestatore As CedentePrestatore
    Public RappresentanteFiscale As RappresentanteFiscale
    Public CessionarioCommittente As CessionarioCommittente
    Public TerzoIntermediarioOSoggettoEmittente As TerzoIntermediarioOSoggettoEmittente
    ''' <summary>
    ''' Da valorizzare in tutti i casi in cui la fattura è emessa da un soggetto diverso dal cedente/prestatore; 
    ''' indica se la fattura è emessa dal cessionario/committente oppure da un terzo per conto del cedente/prestatore
    ''' </summary>
    Public SoggettoEmittente As String
End Class
