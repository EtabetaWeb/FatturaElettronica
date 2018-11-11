Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

''' <summary>
''' [1.2] Blocco sempre obbligatorio contenente dati relativi al cedente / prestatore (fornitore)
''' </summary>
Public Class CedentePrestatore

    ''' <summary>
    ''' Blocco sempre obbligatorio contenente dati relativi al cedente / prestatore
    ''' </summary>
    Public DatiAnagrafici As DatiAnagrafici

    ''' <summary>
    ''' Blocco contenente i dati della sede del cedente / prestatore. Si tratta della sede legale per le società e del domicilio fiscale per le ditte individuali e i lavoratori autonomi
    ''' </summary>
    Public Sede As Sede

    ''' <summary>
    ''' Blocco da valorizzare nei casi di cedente / prestatore non residente, con stabile organizzazione in Italia
    ''' </summary>
    Public StabileOrganizzazione As StabileOrganizzazione

    ''' <summary>
    ''' Blocco da valorizzare nei casi di società iscritte nel registro delle imprese ai sensi dell'art. 2250 del codice civile.
    ''' </summary>
    Public IscrizioneREA As IscrizioneREA

    ''' <summary>
    ''' Dati relativi ai contatti del cedente / prestatore
    ''' </summary>
    Public Contatti As Contatti

    ''' <summary>
    ''' Codice identificativo del cedente / prestatore ai fini amministrativo-contabili
    ''' </summary>
    Public RiferimentoAmministrazione As String

End Class