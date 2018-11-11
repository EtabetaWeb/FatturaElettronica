Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

''' <summary>
''' [2.5] Dati relativi ad eventuali allegati
''' </summary>
Public Class Allegati

    ''' <summary>
    ''' Nome dell'allegato
    ''' </summary>
    Public NomeAttachment As String

    ''' <summary>
    ''' Algoritmo usato per comprimere l'attachment (ad es.: ZIP, RAR, …)
    ''' </summary>
    Public AlgoritmoCompressione As String

    ''' <summary>
    ''' Formato dell'attachment (ad es: TXT, XML, DOC, PDF …….)
    ''' </summary>
    Public FormatoAttachment As String

    ''' <summary>
    ''' Descrizione del documento
    ''' </summary>
    Public DescrizioneAttachment As String

    ''' <summary>
    ''' Contiene il documento allegato alla fattura; il contenuto è demandato agli accordi tra PA e fornitore 
    ''' </summary>
    Public Attachment As String

End Class