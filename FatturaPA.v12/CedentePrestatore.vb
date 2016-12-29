Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class CedentePrestatore
    ''' <summary>
    ''' Il set dati anagrafici viene utilizzato per tutte le anagrafiche presenti
    ''' </summary>
    Public DatiAnagrafici As DatiAnagrafici
    Public Sede As Sede
    Public StabileOrganizzazione As StabileOrganizzazione
    'I campi indicati di seguito devono essere obbligatoriamente valorizzati nei soli casi  in cui il cedente/prestatore è un soggetto non residente ed effettua la transazione  oggetto del documento tramite l’organizzazione residente sul territorio nazionale. Si  riferiscono alla stabile organizzazione in Italia.  
    'stessi  campi previsti per l’elemento Sede del CedentePrestatore
    Public IscrizioneREA As IscrizioneREA
    'Questi campi devono essere obbligatoriamente valorizzati nei casi di società  soggette al vincolo dell’iscrizione nel registro delle imprese ai sensi dell'art. 2250  del codice civile. 
    Public Contatti As Contatti
    ''' <summary>
    ''' Codice identificativo del cedente / prestatore ai fini amministrativo-contabili
    ''' </summary>
    Public RiferimentoAmministrazione As String
End Class