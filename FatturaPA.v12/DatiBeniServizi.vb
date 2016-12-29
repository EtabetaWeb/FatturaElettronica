Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml.Serialization

<XmlRoot("DettaglioLinee")> _
Public Class DatiBeniServizi
    ''' <summary>
    ''' Blocco contenente le linee di dettaglio del documento (gli elementi informativi del blocco si ripetono per ogni riga di dettaglio).
    ''' </summary>
    <XmlElement("DettaglioLinee")>
    Public DettaglioLinee As List(Of DettaglioLinee)
    ''' <summary>
    ''' Blocco obbligatorio, gli elementi informativi che lo compongono riepilogano le informazioni di dettaglio, aggregandole per aliquota IVA distinta oppure per aliquota IVA nulla e "Natura" distinta oppure, a parità di questi elementi, per valore distinto di "Esigbilità"
    ''' </summary>
    <XmlElement("DatiRiepilogo")> _
    Public DatiRiepilogo As List(Of DatiRiepilogo)

    Sub New()
        DettaglioLinee = New List(Of DettaglioLinee)()
        DatiRiepilogo = New List(Of DatiRiepilogo)()
    End Sub
End Class