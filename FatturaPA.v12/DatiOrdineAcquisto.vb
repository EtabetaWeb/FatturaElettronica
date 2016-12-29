Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiOrdineAcquisto
    ''' <summary>
    ''' Linea di dettaglio della fattura a cui si fa riferimento (se il riferimento è all'intera fattura, non viene valorizzato) (vedi elemento informativo 2.2.1.1)
    ''' </summary>
    Public RiferimentoNumeroLinea As String
    ''' <summary>
    ''' Numero del documento
    ''' </summary>
    Public IdDocumento As String
    ''' <summary>
    ''' Data del documento (secondo il formato ISO 8601:2004, con la seguente precisione: YYYY-MM-DD.)
    ''' </summary>
    Public Data As String
    ''' <summary>
    ''' Identificativo della singola voce all'interno del documento (ad esempio, nel caso di ordine di acquisto, è il numero della linea dell'ordine di acquisto, oppure, nel caso di contratto, è il numero della linea del contratto, etc.)
    ''' </summary>
    Public NumItem As String
    ''' <summary>
    ''' Codice della commessa o della convenzione
    ''' </summary>
    Public CodiceCommessaConvenzione As String
    ''' <summary>
    ''' Rappresenta il codice gestito dal CIPE che caratterizza ogni progetto di investimento pubblico (Codice Unitario Progetto)
    ''' </summary>
    Public CodiceCUP As String
    ''' <summary>
    ''' Rappresenta il Codice Identificativo della Gara
    ''' </summary>
    Public CodiceCIG As String
End Class