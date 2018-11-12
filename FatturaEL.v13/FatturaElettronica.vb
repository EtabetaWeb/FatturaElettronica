Imports System.Xml.Serialization
Imports System.Xml

<Serializable>
Public Class FatturaElettronica
    <XmlAttribute("versione")>
    Public versione As String
    Public FatturaElettronicaHeader As FatturaElettronicaHeader
    Public FatturaElettronicaBody As FatturaElettronicaBody
End Class