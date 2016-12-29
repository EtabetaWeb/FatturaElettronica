Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class DatiContratto
    'Dati relativi al contratto dal quale scaturisce la cessione/prestazione oggetto del documento fattura.
    '  Come DatiOrdineAcquisto

    Public RiferimentoNumeroLinea As String
    'numero della linea o delle linee di dettaglio della fattura alle quali si riferisce l’ordine di acquisto così come identificato dai tre campi successivi (IdDocumento, Data, NumItem); nel caso in cui l’ordine di acquisto si riferisce all’intera fattura, questo campo non deve essere valorizzato.
    'formato numerico;
    Public IdDocumento As String
    'numero dell’ ordine di acquisto associato alla fattura o alla  linea/linee di fattura indicate nel campo RiferimentoNumeroLinea.  
    'formato alfanumerico; lunghezza
    Public Data As String
    'data dell’ ordine di acquisto associato alla fattura o alla linea/linee di fattura indicate nel campo RiferimentoNumeroLinea (espressa secondo il formato ISO 8601:2004).
    'a data deve essere rappresentata secondo il formato ISO 8601:2004, con la seguente precisione: YYYY-MM-DD.
    Public NumItem As String
    'identificativo della singola voce (linea di ordine) all'interno dell’ordine di acquisto associata alla fattura o alla linea/linee di fattura indicate nel campo RiferimentoNumeroLinea.
    'formato alfanumerico; lunghezza massima di 20 caratter
    Public CodiceCommessaConvenzione As String
    'codice della commessa o della convenzione collegata alla fattura
    'formato alfanumerico; lunghezza massima di 100 caratteri
    Public CodiceCUP As String
    'codice gestito dal CIPE che caratterizza ogni progetto di investimento pubblico (Codice Unitario Progetto).
    'formato alfanumerico; lunghezza massima di 15 caratteri.
    Public CodiceCIG As String
    'Codice Identificativo della Gara
    'formato alfanumerico; lunghezza massima di 15 caratteri.
End Class
