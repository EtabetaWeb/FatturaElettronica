Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiAnagrafici
    Public IdFiscaleIVA As IdFiscaleIVA
    ''' <summary>
    ''' Numero di Codice Fiscale
    ''' </summary>
    Public CodiceFiscale As String
    Public Anagrafica As Anagrafica
    ''' <summary>
    ''' Nome dell'albo professionale
    ''' </summary>
    Public AlboProfessionale As String
    ''' <summary>
    ''' Sigla della provincia di competenza dell'albo professionale 
    ''' </summary>
    Public ProvinciaAlbo As String
    ''' <summary>
    ''' Numero di iscrizione all'albo professionale
    ''' </summary>
    Public NumeroIscrizioneAlbo As String
    ''' <summary>
    ''' Data di iscrizione all'albo professionale (secondo il formato ISO 8601:2004) 
    ''' </summary>
    Public DataIscrizioneAlbo As String
    ''' <summary>
    ''' Regime fiscale (vedere tabella agenzia entrate per eventuali riferimenti)
    ''' </summary>
    Public RegimeFiscale As String
End Class
