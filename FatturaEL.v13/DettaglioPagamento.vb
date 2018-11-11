Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DettaglioPagamento

    ''' <summary>
    ''' Beneficiario del pagamento (utilizzabile se si intende indicare un beneficiario diverso dal cedente/prestatore)
    ''' </summary>
    Public Beneficiario As String

    ''' <summary>
    ''' Modalità di pagamento
    ''' Rif. file dati 2.4.2.2
    ''' </summary>
    Public ModalitaPagamento As String

    ''' <summary>
    ''' Data dalla quale decorrono i termini di pagamento (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataRiferimentoTerminiPagamento As String

    ''' <summary>
    ''' Termini di pagamento espressi in giorni a partire dalla data di riferimento di cui all'elemento informativo precedente 2.4.2.3 "DataRiferimentoTerminiPagamento" (vale 0 per pagamenti a vista )
    ''' </summary>
    Public GiorniTerminiPagamento As String

    ''' <summary>
    ''' Data di scadenza del pagamento (secondo il formato ISO 8601:2004) da indicare nei casi in cui ha senso sulla bese delle condizioni di pagamento previste)
    ''' </summary>
    Public DataScadenzaPagamento As String

    ''' <summary>
    ''' Importo relativo al pagamento
    ''' </summary>
    Public ImportoPagamento As String

    ''' <summary>
    ''' Nei casi di modalità di pagamento in cui ha senso l'indicazione dell'ufficio postale
    ''' </summary>
    Public CodUfficioPostale As String

    ''' <summary>
    ''' Cognome del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    ''' </summary>
    Public CognomeQuietanzante As String

    ''' <summary>
    ''' Nome del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    ''' </summary>
    Public NomeQuietanzante As String

    ''' <summary>
    ''' Codice fiscale del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    ''' </summary>
    Public CFQuietanzante As String

    ''' <summary>
    ''' Titolo del quietanzante (nei casi di elemento informativo 2.4.2.2 <ModalitaPagamento> = MP04 )
    ''' </summary>
    Public TitoloQuietanzante As String

    ''' <summary>
    ''' Nome dell'Istituto Finanziario
    ''' </summary>
    Public IstitutoFinanziario As String

    ''' <summary>
    ''' International Bank Account Number (coordinata bancaria internazionale che consente di identificare, in maniera standard, il conto corrente del beneficiario )
    ''' </summary>
    Public IBAN As String

    ''' <summary>
    ''' Codice ABI
    ''' </summary>
    Public ABI As String

    ''' <summary>
    ''' Codice CAB
    ''' </summary>
    Public CAB As String

    ''' <summary>
    ''' Bank Identifier Code (codice che identifica la banca del beneficiario)
    ''' </summary>
    Public BIC As String

    ''' <summary>
    ''' Ammontare dello sconto per pagamento anticipato
    ''' </summary>
    Public ScontoPagamentoAnticipato As String

    ''' <summary>
    ''' Data limite stabilita per il pagamento anticipato (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataLimitePagamentoAnticipato As String

    ''' <summary>
    ''' Ammontare della penalità dovuta per pagamenti ritardati
    ''' </summary>
    Public PenalitaPagamentiRitardati As String

    ''' <summary>
    ''' Data di decorrenza della penale (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataDecorrenzaPenale As String

    ''' <summary>
    ''' Codice per la riconciliazione degli incassi da parte del cedente/prestatore
    ''' </summary>
    Public CodicePagamento As String

End Class
