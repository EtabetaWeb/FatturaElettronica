Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiRitenuta
    ''' <summary>
    ''' Tipologia della ritenuta
    ''' Rif. file dati 2.1.1.5
    ''' </summary>
    Public TipoRitenuta As String
    ''' <summary>
    ''' Importo della ritenuta
    ''' </summary>
    Public ImportoRitenuta As String
    ''' <summary>
    ''' Aliquota (%) della ritenuta
    ''' </summary>
    Public AliquotaRitenuta As String
    ''' <summary>
    ''' Causale del pagamento (quella del modello 770)
    ''' Rif. file dati 2.1.1.5.4
    ''' </summary>
    Public CausalePagamento As String
End Class
