Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class CodiceArticolo
    ''' <summary>
    ''' Indica la tipologia di codice articolo (per esempio, TARIC, CPV, EAN, SSC, ...)
    ''' </summary>
    Public CodiceTipo As String
    ''' <summary>
    ''' Indica il valore del codice articolo corrispondente alla tipologia riportata nell'elemento informativo 2.2.1.3.1 "CodiceTipo"
    ''' </summary>
    Public CodiceValore As String
End Class
