Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

''' <summary>
''' [1.1] Blocco sempre obbligatorio contenente informazioni che identificano univocamente il soggetto che trasmette, il documento trasmesso, il formato in cui è stato trasmesso il documento, il soggetto destinatario
''' </summary>
Public Class DatiTrasmissione

    ''' <summary>
    ''' E' l’identificativo univoco del soggetto trasmittente; per i soggetti residenti in Italia, siano essi persone fisiche o giuridiche, corrisponde al codice fiscale preceduto da IT; per i soggetti non residenti corrisponde al numero identificativo IVA (dove i primi due caratteri rappresentano il paese secondo lo standard ISO 3166-1 alpha-2 code, ed i restanti, fino ad un massimo di 28, il codice vero e proprio)
    ''' </summary>
    Public IdTrasmittente As IdTrasmittente

    ''' <summary>
    ''' Numerazione attribuita dal soggetto che trasmette, secondo sue proprie regole
    ''' </summary>
    Public ProgressivoInvio As String

    ''' <summary>
    ''' Contiene il codice identificativo del tipo di trasmissione che si sta effettuando e del relativo formato
    ''' </summary>
    Public FormatoTrasmissione As String

    ''' <summary>
    ''' Per le fatture verso la PA (1.1.3 "FormatoTrasmissione" = FPA12) contiene il codice, di 6 caratteri, dell'ufficio destinatario della fattura, definito dall'amministrazione di appartenenza come riportato nella rubrica “Indice PA”
    ''' Per le fatture verso privati (1.1.3 "FormatoTrasmissione"= FPR12) contiene il codice, di 7 caratteri, assegnato dal Sdi ai soggetti che hanno accreditato un canale; qualora il destinatario non abbia accreditato un canale presso SdI, l'elemento deve essere valorizzato con tutti zeri ('0000000')
    ''' Per le fatture emesse con riferimento a operazioni "transfrontaliere" l'elemento deve essere valorizzato con tutte "X" ('XXXXXXX') 
    ''' </summary>
    Public CodiceDestinatario As String

    ''' <summary>
    ''' Dati relativi ai contatti del trasmittente
    ''' </summary>
    Public ContattiTrasmittente As ContattiTrasmittente

    ''' <summary>
    ''' Indirizzo PEC al quale inviare il documento
    ''' </summary>
    Public PECDestinatario As String

End Class
