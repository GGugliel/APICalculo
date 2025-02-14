using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace APICalculo.Model
{
   [XmlRoot(ElementName = "consultarDadosParcelaBilhetesContratadoResponse", Namespace = "http://webservice.servicos.webservices.afnd.bradseg.com.br/")]
    public class ResponseConsultarDadosParcelaBilhetesContratado
    {
        [XmlElement(ElementName = "return")]
        public Return? Return { get; set; }
        [XmlAttribute(AttributeName = "NS1", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string? NS1 { get; set; }
    }


    [XmlRoot(ElementName = "registros")]
    public class Registros
    {
        [XmlElement(ElementName = "adicionalFracionamento")]
        public string AdicionalFracionamento { get; set; }
        [XmlElement(ElementName = "custoEmissao")]
        public string CustoEmissao { get; set; }
        [XmlElement(ElementName = "dataEnvioCobranca")]
        public string DataEnvioCobranca { get; set; }
        [XmlElement(ElementName = "dataPagCancParcela")]
        public string DataPagCancParcela { get; set; }
        [XmlElement(ElementName = "dataRetornoCobranca")]
        public string DataRetornoCobranca { get; set; }
        [XmlElement(ElementName = "dataVencimentoFatura")]
        public string DataVencimentoFatura { get; set; }
        [XmlElement(ElementName = "dataVencimentoParcela")]
        public string DataVencimentoParcela { get; set; }
        [XmlElement(ElementName = "dvTituloCobranca")]
        public string DvTituloCobranca { get; set; }
        [XmlElement(ElementName = "formaPgtoParcela")]
        public string FormaPgtoParcela { get; set; }
        [XmlElement(ElementName = "iof")]
        public string Iof { get; set; }
        [XmlElement(ElementName = "nuParcela")]
        public string NuParcela { get; set; }
        [XmlElement(ElementName = "numeroFatura")]
        public string NumeroFatura { get; set; }
        [XmlElement(ElementName = "numeroTituloCobranca")]
        public string NumeroTituloCobranca { get; set; }
        [XmlElement(ElementName = "premioTarifa")]
        public string PremioTarifa { get; set; }
        [XmlElement(ElementName = "premioTotal")]
        public string PremioTotal { get; set; }
        [XmlElement(ElementName = "situacaoParcela")]
        public string SituacaoParcela { get; set; }
    }

    [XmlRoot(ElementName = "return")]
    public class Return
    {
        [XmlElement(ElementName = "codigoErro")]
        public string CodigoErro { get; set; }
        [XmlElement(ElementName = "descricaoErro")]
        public string DescricaoErro { get; set; }
        [XmlElement(ElementName = "sqlCode")]
        public string SqlCode { get; set; }
        [XmlElement(ElementName = "registros")]
        public Registros Registros { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class BodyResponse
    {
        [XmlElement(ElementName = "consultarDadosParcelaBilhetesContratadoResponse", Namespace = "http://webservice.servicos.webservices.afnd.bradseg.com.br/")]
        public ResponseConsultarDadosParcelaBilhetesContratado? ConsultarDadosParcelaBilhetesContratadoResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeResponse
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public BodyResponse? Body { get; set; }
        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string? Soapenv { get; set; }
    }




}
