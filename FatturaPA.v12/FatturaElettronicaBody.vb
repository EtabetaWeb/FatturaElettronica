Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class FatturaElettronicaBody
    ''' <summary>
    ''' 
    ''' </summary>
    Public DatiGenerali As DatiGenerali
    ''' <summary>
    ''' 
    ''' </summary>
    Public DatiBeniServizi As DatiBeniServizi
    ''' <summary>
    ''' Dati relativi ai veicoli di cui all'art. 38, comma 4 del dl 331 del 1993
    ''' </summary>
    Public DatiVeicoli As DatiVeicoli
    ''' <summary>
    ''' Blocco destinato a descrivere le modalità di pagamento per la cessione/prestazione rappresentata in fattura
    ''' </summary>
    Public DatiPagamento As DatiPagamento
    ''' <summary>
    ''' 
    ''' </summary>
    Public Allegati As Allegati
End Class