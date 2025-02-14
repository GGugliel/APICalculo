using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace APICalculo.Model
{
    [XmlRoot(ElementName = "consultarDadosParcelaBilhetesContratado", Namespace = "http://webservice.servicos.webservices.afnd.bradseg.com.br/")]
    public class RequestConsultarDadosParcelaBilhetesContratado
    {
        [XmlElement(ElementName = "arg0")]
        public Arg0? Arg0 { get; set; }
        [XmlElement(ElementName = "arg1")]
        public string Arg1 { get; set; }
    }



    [XmlRoot(ElementName = "arg0")]
    public class Arg0
    {
        [XmlElement(ElementName = "identificadorAFND")]
        public string? IdentificadorAFND { get; set; }
        [XmlElement(ElementName = "versaoDocumento")]
        public string? VersaoDocumento { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class RequestBody
    {
        [XmlElement(ElementName = "consultarDadosParcelaBilhetesContratado", Namespace = "http://webservice.servicos.webservices.afnd.bradseg.com.br/")]
        public RequestConsultarDadosParcelaBilhetesContratado? ConsultarDadosParcelaBilhetesContratado { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeRequest
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public string? Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body? Body { get; set; }
        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string? Soapenv { get; set; }
        [XmlAttribute(AttributeName = "web", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string? Web { get; set; }
    }


}
