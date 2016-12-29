Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml.Serialization


Public Class DatiGeneraliDocumento
    ''' <summary>
    ''' Ttipologia di documento
    ''' Rif. file dati 2.1.1.1
    ''' </summary>
    Public TipoDocumento As String
    ''' <summary>
    ''' Codice (espresso secondo lo standard ISO 4217 alpha-3:2001) della valuta utilizzata per l'indicazione degli importi
    ''' </summary>
    Public Divisa As String
    ''' <summary>
    ''' Data del documento (secondo il formato ISO 8601:2004 con la seguente precisione: YYYY-MM-DD)
    ''' </summary>
    Public Data As String
    ''' <summary>
    ''' Numero della fattura (art. 21, comma 2, lettera b DPR 633/1972)
    ''' </summary>
    Public Numero As String
    ''' <summary>
    ''' Blocco dati relativi alla ritenuta
    ''' </summary>
    Public DatiRitenuta As DatiRitenuta
    ''' <summary>
    ''' Blocco dati relativi al bollo
    ''' </summary>
    Public DatiBollo As DatiBollo
    ''' <summary>
    ''' Blocco dati relativi alla cassa professionale di appartenenza
    ''' </summary>
    <XmlElement>
    Public DatiCassaPrevidenziale As List(Of DatiCassaPrevidenziale)
    ''' <summary>
    ''' Eventuale sconto o maggiorazione applicati sul totale documento (la molteplicità N del blocco consente di gestire la presenza di più sconti o più maggiorazioni a 'cascata')
    ''' </summary>
    <XmlElement>
    Public ScontoMaggiorazione As List(Of ScontoMaggiorazione)
    ''' <summary>
    ''' Importo totale del documento al netto dell'eventuale sconto e comprensivo di imposta a debito del cessionario/committente
    ''' </summary>
    Public ImportoTotaleDocumento As String
    ''' <summary>
    ''' Eventuale arrotondamento sul totale documento (ammette anche il segno negativo)
    ''' </summary>
    Public Arrotondamento As String
    ''' <summary>
    ''' Descrizione della causale del documento
    ''' </summary>
    Public Causale As String
    ''' <summary>
    ''' Indica se il documento è stato emesso secondo modalità e termini stabiliti con decreto ministeriale ai sensi dell'articolo 73 del DPR 633/72 (ciò consente al cedente/prestatore l'emissione nello stesso anno di più documenti aventi stesso numero)
    ''' </summary>
    Public Art73 As String
End Class