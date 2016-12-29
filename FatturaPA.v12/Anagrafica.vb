Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Anagrafica
    ''' <summary>
    ''' Ditta, denominazione o ragione sociale (ditta, impresa, società, ente), da valorizzare solo se non sono valorizzati gli elementi
    ''' "Nome" e "Cognome"
    ''' </summary>
    Public Denominazione As String
    ''' <summary>
    ''' Nome della persona fisica. Da valorizzare insieme all'elemento informativo "Cognome" e solo se non è valorizzato
    ''' l'elemento informativo "Denominazione"
    ''' </summary>
    Public Nome As String
    ''' <summary>
    ''' Cognome della persona fisica. Da valorizzare insieme all'elemento informativo "Nome" e solo se non è valorizzato
    ''' l'elemento informativo "Denominazione"
    ''' </summary>
    Public Cognome As String
    ''' <summary>
    ''' Titolo onorifico 
    ''' </summary>
    Public Titolo As String
    ''' <summary>
    ''' Numero del Codice EORI (Economic Operator Registration and Identification) in base al Regolamento (CE) n. 312 del 16 aprile 2009. In vigore dal 1 luglio 2009
    ''' </summary>
    Public CodEORI As String
End Class
