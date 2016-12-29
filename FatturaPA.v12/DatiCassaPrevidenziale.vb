Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiCassaPrevidenziale
    ''' <summary>
    ''' Tipologia cassa previdenziale di appartenenza
    ''' Rif. file dati 2.1.1.7.1
    ''' </summary>
    Public TipoCassa As String
    ''' <summary>
    ''' Aliquota (%) del contributo, se previsto, per la cassa di appartenenza
    ''' </summary>
    Public AlCassa As String
    ''' <summary>
    ''' Importo del contributo per la cassa di appartenenza
    ''' </summary>
    Public ImportoContributoCassa As String
    ''' <summary>
    ''' Importo sul quale applicare il contributo cassa previdenziale
    ''' </summary>
    Public ImponibileCassa As String
    ''' <summary>
    ''' Aliquota (%) IVA applicata
    ''' </summary>
    Public AliquotaIVA As String
    ''' <summary>
    ''' Indica se il contributo cassa è soggetto a ritenuta
    ''' </summary>
    Public Ritenuta As String
    ''' <summary>
    ''' Codice che esprime la natura della non imponibilità del contributo cassa. Se AliquotaIVA è valorizzato impostare a zero.
    ''' Rif. file dati 2.1.1.7.7
    ''' </summary>
    Public Natura As String
    ''' <summary>
    ''' Codice identificativo ai fini amministrativo-contabili
    ''' </summary>
    Public RiferimentoAmministrazione As String
End Class
