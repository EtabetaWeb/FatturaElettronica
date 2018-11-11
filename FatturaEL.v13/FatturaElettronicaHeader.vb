Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

''' <summary>
''' [1] Il blocco ha molteplicità pari a 1, sia nel caso di fattura singola che nel caso di lotto di fatture
''' </summary>
Public Class FatturaElettronicaHeader

    ''' <summary>
    ''' [1.1] Blocco sempre obbligatorio contenente informazioni che identificano univocamente il soggetto che trasmette, il documento trasmesso, il formato in cui è stato trasmesso il documento, il soggetto destinatario
    ''' </summary>
    Public DatiTrasmissione As DatiTrasmissione

    ''' <summary>
    ''' [1.2] Blocco sempre obbligatorio contenente dati relativi al cedente / prestatore (fornitore)
    ''' </summary>
    Public CedentePrestatore As CedentePrestatore

    ''' <summary>
    ''' [1.3] Blocco da valorizzare nei casi in cui il cedente / prestatore si avvalga di un rappresentante fiscale in Italia.
    ''' </summary>
    Public RappresentanteFiscale As RappresentanteFiscale

    ''' <summary>
    ''' [1.4] Blocco sempre obbligatorio contenente dati relativi al cessionario / committente (cliente)
    ''' </summary>
    Public CessionarioCommittente As CessionarioCommittente

    ''' <summary>
    ''' [1.5] Dati relativi al soggetto terzo che emette fattura per conto del cedente / prestatore
    ''' </summary>
    Public TerzoIntermediarioOSoggettoEmittente As TerzoIntermediarioOSoggettoEmittente

    ''' <summary>
    ''' [1.6] Da valorizzare in tutti i casi in cui la fattura è emessa da un soggetto diverso dal cedente/prestatore; indica se la fattura è emessa dal cessionario/committente oppure da un terzo per conto del cedente/prestatore
    ''' </summary>
    Public SoggettoEmittente As String

End Class
