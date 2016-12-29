Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

'Nei casi di documenti emessi da un soggetto diverso dal cedente/prestatore va valorizzato il campo seguente.
'Questi campi consentono l’inserimento della partita IVA per i soggetti residenti in Italia oppure dell’identificativo fiscale assegnato dall’autorità del proprio paese per i soggetti non residenti.
'Stessi campi di DatiAnagrafici
' 
' warning: In presenza di emittente e intermediario ?
' 

Public Class TerzoIntermediarioOSoggettoEmittente
    Public DatiAnagrafici As DatiAnagrafici
End Class