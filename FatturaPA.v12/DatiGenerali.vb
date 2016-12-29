Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml.Serialization

''' <summary>
''' Blocco sempre obbligatorio contenente i dati generali della fattura e quelli degli eventuali documenti correlati
''' </summary>
Public Class DatiGenerali
    ''' <summary>
    ''' Blocco sempre obbligatorio contenente i dati generali della fattura
    ''' </summary>
    Public DatiGeneraliDocumento As DatiGeneraliDocumento
    ''' <summary>
    ''' Blocco contenente le informazioni relative all'ordine di acquisto
    ''' </summary>
    <XmlElement>
    Public DatiOrdineAcquisto As List(Of DatiOrdineAcquisto)
    ''' <summary>
    ''' Blocco contenente le informazioni relative al contratto; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    ''' </summary>
    <XmlElement>
    Public DatiContratto As List(Of DatiContratto)
    ''' <summary>
    ''' Blocco contenente le informazioni relative alla convenzione; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    ''' </summary>
    <XmlElement>
    Public DatiConvenzione As List(Of DatiConvenzione)
    ''' <summary>
    ''' Blocco contenente le informazioni relative ai dati presenti sul sistema gestionale in uso presso la PA (Agenzie Fiscali) riguardanti la fase di ricezione; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    ''' </summary>
    <XmlElement>
    Public DatiRicezione As List(Of DatiRicezione)
    ''' <summary>
    ''' Blocco contenente le informazioni relative alle fatture precedentemente trasmesse e alle quali si collega il documento presente; riguarda i casi di invio di nota di credito e/o di fatture di conguaglio a fronte di precedenti fatture di acconto; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    ''' </summary>   
    <XmlElement>
    Public DatiFattureCollegate As List(Of DatiFattureCollegate)
    ''' <summary>
    ''' Blocco da valorizzare nei casi di fattura per stato di avanzamento
    ''' </summary>
    Public DatiSAL As List(Of DatiSAL)
    ''' <summary>
    ''' Blocco da valorizzare nei casi di fattura "differita" per indicare il documento con cui è stato consegnato il bene (gli elementi informativi del blocco possono essere ripetuti se la fattura fa riferimento a più consegne e quindi a più documenti di trasporto)
    ''' </summary>
    <XmlElement>
    Public DatiDDT As List(Of DatiDDT)
    ''' <summary>
    ''' Blocco valorizzabile nei casi di fattura "accompagnatoria" per inserire informazioni relative al trasporto
    ''' </summary>
    Public DatiTrasporto As DatiTrasporto
    ''' <summary>
    ''' Blocco da valorizzare nei casi di fatture per operazioni accessorie, emesse dagli 'autotrasportatori' per usufruire delle agevolazioni in materia di registrazione e pagamento dell' IVA
    ''' </summary>
    Public FatturaPrincipale As FatturaPrincipale
End Class
