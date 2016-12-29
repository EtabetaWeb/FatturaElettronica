Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class Allegati
    ''' <summary>
    ''' contiene il nome del documento allegato alla fattura elettronica
    ''' </summary>
    Public NomeAttachment As String
    ''' <summary>
    ''' algoritmo utilizzato per comprimere l’allegato.
    ''' </summary>
    Public AlgoritmoCompressione As String
    ''' <summary>
    ''' formato dell’allegato.
    ''' </summary>
    Public FormatoAttachment As String
    ''' <summary>
    ''' descrizione del documento allegato alla fattura elettronica.
    ''' </summary>
    Public DescrizioneAttachment As String
    ''' <summary>
    ''' contiene il documento allegato alla fattura elettronica.
    ''' </summary>
    Public Attachment As String
End Class