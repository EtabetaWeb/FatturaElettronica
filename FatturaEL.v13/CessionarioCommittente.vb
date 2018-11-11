Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

''' <summary>
''' [1.4] Blocco sempre obbligatorio contenente dati relativi al cessionario / committente (cliente)
''' </summary>
Public Class CessionarioCommittente

    ''' <summary>
    ''' Blocco contenente i dati fiscali e anagrafici del cessionario/committente
    ''' </summary>
    Public DatiAnagrafici As DatiAnagrafici

    ''' <summary>
    ''' Blocco contenente i dati della sede del cessionario / committente (nel caso di somministrazione di servizi quali energia elettrica, gas … , i dati possono fare riferimento all'ubicazione dell'utenza, ex DM 370/2000)
    ''' </summary>
    Public Sede As Sede

    ''' <summary>
    ''' Blocco da valorizzare se e solo se l'elemento informativo 1.1.3 "FormatoTrasmissione" = "FPR12" (fattura tra privati), nel caso di cessionario/committente non residente e con stabile organizzazione in Italia
    ''' </summary>
    Public StabileOrganizzazione As StabileOrganizzazione

    ''' <summary>
    ''' Blocco da valorizzare se e solo se l'elemento informativo 1.1.3 "FormatoTrasmissione" = "FPR12" (fattura tra privati), nel caso di cessionario/committente che si avvale di rappresentante fiscale in Italia
    ''' </summary>
    Public RappresentanteFiscale As RappresentanteFiscale

End Class
