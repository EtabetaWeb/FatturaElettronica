Namespace GeneraFatturaEL.v13.Defaults

    Public Class RootElement
        Public Shared ReadOnly Property Prefix As String
            Get
                Return "p"
            End Get
        End Property

        Public Shared ReadOnly Property LocalName As String
            Get
                Return "FatturaElettronica"
            End Get
        End Property

        Public Shared ReadOnly Property [NameSpace] As String
            Get
                Return "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"
            End Get
        End Property

        Public Shared ReadOnly Property ExtraAttributes As XmlAttributeString()
            Get
                Return New XmlAttributeString() {New XmlAttributeString With {
                .Prefix = "xmlns",
                .LocalName = "ds",
                .ns = Nothing,
                .value = "http://www.w3.org/2000/09/xmldsig#"
            }, New XmlAttributeString With {
                .Prefix = "xmlns",
                .LocalName = "xsi",
                .ns = Nothing,
                .value = "http://www.w3.org/2001/XMLSchema-instance"
            }, New XmlAttributeString With {
                .Prefix = "xsi",
                .LocalName = "schemaLocation",
                .ns = Nothing,
                .value = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2 fatturaordinaria_v1.2.xsd"
            }}
            End Get
        End Property

        Public Class XmlAttributeString
            Public Prefix As String
            Public LocalName As String
            Public ns As String
            Public value As String
        End Class
    End Class

End Namespace
