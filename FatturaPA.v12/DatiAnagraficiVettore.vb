Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class DatiAnagraficiVettore
    ''' <summary>
    ''' Numero di identificazione fiscale ai fini IVA; i primi due caratteri rappresentano il paese ( IT, DE, ES …..) ed i restanti (fino ad un massimo di 28) il codice vero e proprio che, per i residenti in Italia, corrisponde al numero di partita IVA.
    ''' </summary>
    Public IdFiscaleIVA As IdFiscaleIVA
    ''' <summary>
    ''' Numero di Codice Fiscale
    ''' </summary>
    Public CodiceFiscale As String
    ''' <summary>
    ''' Dati anagrafici identificativi del vettore
    ''' </summary>
    Public Anagrafica As Anagrafica
    ''' <summary>
    ''' Numero identificativo della licenza di guida (es. numero patente)
    ''' </summary>
    Public NumeroLicenzaGuida As String
End Class
