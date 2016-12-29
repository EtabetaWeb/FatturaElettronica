Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class DatiTrasmissione
    Public IdTrasmittente As IdTrasmittente
    ''' <summary>
    ''' Numerazione attribuita dal soggetto che trasmette, secondo sue proprie regole 
    ''' Formato alfanumerico; lunghezza massima di 10 caratteri
    ''' </summary>
    Public ProgressivoInvio As String
    ''' <summary>
    ''' Contiene il codice identificativo del tipo di trasmissione che si sta effettuando e del relativo formato
    ''' Formato alfanumerico; lunghezza di 5 caratteri; i valori ammessi sono i seguenti: SDI10 Formato di Trasmissione SDI versione 1.0.
    ''' </summary>
    Public FormatoTrasmissione As String
    ''' <summary>
    ''' Identifica il soggetto al quale è destinata la fattura
    ''' nei casi di fattura destinata ad una Pubblica Amministrazione il suo valore, di 6 caratteri, deve corrispondere a quello presente nel campo Codice Ufficio riportato nella rubrica “Indice PA” (WWW.INDICEPA.GOV.IT)
    ''' nei casi di fattura destinata ad un soggetto diverso da Pubblica Amministrazione il suo valore, di 7 caratteri, deve essere uno dei codici che il Sistema di Interscambio attribuisce ai soggetti con canale accreditato in ricezione
    ''' nei casi di fattura destinata ad un soggetto diverso da Pubblica Amministrazione che riceve tramite PEC, l’elemento informativo deve essere valorizzato con la stringa ‘0000000’
    ''' </summary>
    Public CodiceDestinatario As String
    Public ContattiTrasmittente As ContattiTrasmittente
    ''' <summary>
    '''  Indirizzo PEC al quale inviare il documento. 
    '''  Da valorizzare SOLO nei casi In cui l'elemento 'CodiceDestinatario' vale '0000000'
    ''' </summary>
    Public PECDestinatario As String
End Class
