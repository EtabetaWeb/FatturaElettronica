Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiDDT
    ''' <summary>
    ''' Numero del documento di trasporto
    ''' </summary>
    Public NumeroDDT As String
    ''' <summary>
    ''' Data del documento di trasporto (secondo il formato ISO 8601:2004)
    ''' </summary>
    Public DataDDT As String
    ''' <summary>
    ''' Linea di dettaglio della fattura cui si riferisce il DDT (non viene valorizzato se il riferimento è all'intera fattura) (vedi elemento informativo 2.2.1.1 "NumeroLinea")
    ''' </summary>
    Public RiferimentoNumeroLinea As String
End Class
