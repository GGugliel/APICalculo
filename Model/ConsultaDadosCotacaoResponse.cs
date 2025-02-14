using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APICalculo.Model
{

    /// <summary>
    /// GET - consulta Dados Cotacao
    /// </summary>
    public class ConsultaDadosCotacaoResponse : ResponseErrors
    {

        [JsonProperty("ChaveProduto")]
        public string? ChaveProduto { get; set; }

        [JsonProperty("CodigoFamiliaProduto")]
        public string? CodigoFamiliaProduto { get; set; }

        [JsonProperty("CodigoLinhaNegocio")]
        public string? CodigoLinhaNegocio { get; set; }

        [JsonProperty("CodigoProduto")]
        public string? CodigoProduto { get; set; }

        [JsonProperty("CodigoProdutoComercial")]
        public string? CodigoProdutoComercial { get; set; }

        [JsonProperty("CodigoProdutoCorporativo")]
        public string? CodigoProdutoCorporativo { get; set; }

        [JsonProperty("CodigoRamoInterno")]
        public string? CodigoRamoInterno { get; set; }

        [JsonProperty("CodigoSubRamoInterno")]
        public string? CodigoSubRamoInterno { get; set; }

        [JsonProperty("DescricaoFamiliaProduto")]
        public string? DescricaoFamiliaProduto { get; set; }

        [JsonProperty("DescricaoLinhaNegocio")]
        public string? DescricaoLinhaNegocio { get; set; }

        [JsonProperty("NomeFantasiaProduto")]
        public string? NomeFantasiaProduto { get; set; }

        [JsonProperty("NomeProduto")]
        public string? NomeProduto { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("pzPageNameBase")]
        public string? PzPageNameBase { get; set; }

        [JsonProperty("pzPageNameHash")]
        public string? PzPageNameHash { get; set; }

        [JsonProperty("VersaoProduto")]
        public string? VersaoProduto { get; set; }

        [JsonProperty("CanalVendaLista")]
        public IList<CanalVendaLista> CanalVendaLista { get; set; }

        [JsonProperty("CaracteristicasGerais")]
        public CaracteristicasGerais CaracteristicasGerais { get; set; }

        [JsonProperty("CoberturaLista")]
        public IList<CoberturaLista> CoberturaLista { get; set; }

        [JsonProperty("CondicaoPagamentoLista")]
        public IList<CondicaoPagamentoLista> CondicaoPagamentoLista { get; set; }

        [JsonProperty("DocumentoSolicitadoLista")]
        public IList<object> DocumentoSolicitadoLista { get; set; }

        [JsonProperty("MotivoCancelamentoLista")]
        public IList<MotivoCancelamentoLista> MotivoCancelamentoLista { get; set; }

        [JsonProperty("PeriodicidadeVigenciaLista")]
        public IList<PeriodicidadeVigenciaLista> PeriodicidadeVigenciaLista { get; set; }

        [JsonProperty("PlanoLista")]
        public IList<object> PlanoLista { get; set; }

        [JsonProperty("ProcessoOrgaoReguladorLista")]
        public IList<ProcessoOrgaoReguladorListaResponse> ProcessoOrgaoReguladorLista { get; set; }

        [JsonProperty("pxDPParameters")]
        public PxDPParameters PxDPParameters { get; set; }

        [JsonProperty("pySourcePage")]
        public PySourcePage PySourcePage { get; set; }

        [JsonProperty("TipoParceiroNegocioLista")]
        public IList<TipoParceiroNegocioLista> TipoParceiroNegocioLista { get; set; }
    }



    public class CanalVendaLista
    {

        [JsonProperty("CodigoCanalVenda")]
        public string? CodigoCanalVenda { get; set; }

        [JsonProperty("DescricaoCanalVenda")]
        public string? DescricaoCanalVenda { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class Beneficiario
    {

        [JsonProperty("IndicativoObrigatorio")]
        public string? IndicativoObrigatorio { get; set; }

        [JsonProperty("IndicativoSolicitaBeneficiario")]
        public string? IndicativoSolicitaBeneficiario { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class GrupoRamoRegedor
    {

        [JsonProperty("NomeGrupoRamo")]
        public string? NomeGrupoRamo { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class ProcessoOrgaoReguladorLista
    {

        [JsonProperty("NumeroProcessoOrgaoRegulador")]
        public string? NumeroProcessoOrgaoRegulador { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("GrupoRamoRegedor")]
        public GrupoRamoRegedor GrupoRamoRegedor { get; set; }
    }

    public class CaracteristicasGerais
    {

        [JsonProperty("CodigoOrigemCobranca")]
        public string? CodigoOrigemCobranca { get; set; }

        [JsonProperty("CodigoRamoInterno")]
        public string? CodigoRamoInterno { get; set; }

        [JsonProperty("CodigoSubRamoInterno")]
        public string? CodigoSubRamoInterno { get; set; }

        [JsonProperty("IndicativoInspecaoNecessaria")]
        public string? IndicativoInspecaoNecessaria { get; set; }

        [JsonProperty("IndicativoPermiteInclusaoDocumentosAdicionais")]
        public string? IndicativoPermiteInclusaoDocumentosAdicionais { get; set; }

        [JsonProperty("IndicativoPermiteLMIUnico")]
        public string? IndicativoPermiteLMIUnico { get; set; }

        [JsonProperty("IndicativoPermiteMultiplosEstudos")]
        public string? IndicativoPermiteMultiplosEstudos { get; set; }

        [JsonProperty("IndicativoPermiteTrocarPlano")]
        public string? IndicativoPermiteTrocarPlano { get; set; }

        [JsonProperty("IndicativoPossuiReenquadramento")]
        public string? IndicativoPossuiReenquadramento { get; set; }

        [JsonProperty("IndicativoPropostaFisicaRetemRemuneracao")]
        public string? IndicativoPropostaFisicaRetemRemuneracao { get; set; }

        [JsonProperty("IndicativoRemuneracaoGrade")]
        public string? IndicativoRemuneracaoGrade { get; set; }

        [JsonProperty("IndicativoSolicitaAceiteDigital")]
        public string? IndicativoSolicitaAceiteDigital { get; set; }

        [JsonProperty("IndicativoSolicitaCodigoComercial")]
        public string? IndicativoSolicitaCodigoComercial { get; set; }

        [JsonProperty("IndicativoSolicitaEscolaridade")]
        public string? IndicativoSolicitaEscolaridade { get; set; }

        [JsonProperty("IndicativoSolicitaEsportesRadicais")]
        public string? IndicativoSolicitaEsportesRadicais { get; set; }

        [JsonProperty("IndicativoSolicitaInfoComplementaresPFPJ")]
        public string? IndicativoSolicitaInfoComplementaresPFPJ { get; set; }

        [JsonProperty("IndicativoSolicitaInformacoesDadosBancarios")]
        public string? IndicativoSolicitaInformacoesDadosBancarios { get; set; }

        [JsonProperty("IndicativoSolicitaPesoAltura")]
        public string? IndicativoSolicitaPesoAltura { get; set; }

        [JsonProperty("IndicativoSubmeteProdutoFATCA")]
        public string? IndicativoSubmeteProdutoFATCA { get; set; }

        [JsonProperty("NumDiasVencimentoPrimParcela")]
        public string? NumDiasVencimentoPrimParcela { get; set; }

        [JsonProperty("PrazoAceiteProposta")]
        public string? PrazoAceiteProposta { get; set; }

        [JsonProperty("PrazoExpiracaoCotacao")]
        public string? PrazoExpiracaoCotacao { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("TipoComportamento")]
        public string? TipoComportamento { get; set; }

        [JsonProperty("TipoInicioVigencia")]
        public string? TipoInicioVigencia { get; set; }

        [JsonProperty("TipoProponente")]
        public string? TipoProponente { get; set; }

        [JsonProperty("TipoVencimentoPrimParcela")]
        public string? TipoVencimentoPrimParcela { get; set; }

        [JsonProperty("ValorLimiteContratacao")]
        public string? ValorLimiteContratacao { get; set; }

        [JsonProperty("Beneficiario")]
        public Beneficiario Beneficiario { get; set; }

        [JsonProperty("ProcessoOrgaoReguladorLista")]
        public IList<ProcessoOrgaoReguladorLista> ProcessoOrgaoReguladorLista { get; set; }
    }

    public class CriterioRiscoLista
    {

        [JsonProperty("CodigoCriterio")]
        public string? CodigoCriterio { get; set; }

        [JsonProperty("DescricaoCriterio")]
        public string? DescricaoCriterio { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class FranquiaLista
    {

        [JsonProperty("CodTipoFranquia")]
        public string? CodTipoFranquia { get; set; }

        [JsonProperty("DescricaoAplicabilidade")]
        public string? DescricaoAplicabilidade { get; set; }

        [JsonProperty("DescricaoFormatoValor")]
        public string? DescricaoFormatoValor { get; set; }

        [JsonProperty("IndicativoValorEvento")]
        public string? IndicativoValorEvento { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("ValorAbsoluto")]
        public string? ValorAbsoluto { get; set; }
    }

    public class ObjetoSeguradoLista
    {

        [JsonProperty("DescricaoObjetoSegurado")]
        public string? DescricaoObjetoSegurado { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class PeriodoLista
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("Valor")]
        public string? Valor { get; set; }
    }

    public class PeriodoIndenitarioLista
    {

        [JsonProperty("Frequencia")]
        public string? Frequencia { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("PeriodoLista")]
        public IList<PeriodoLista> PeriodoLista { get; set; }
    }

    public class TipoInteresseSegurado
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("TipoInteresse")]
        public string? TipoInteresse { get; set; }
    }

    public class CoberturaLista
    {

        [JsonProperty("CodigoCobertura")]
        public string? CodigoCobertura { get; set; }

        [JsonProperty("IdadeCalculo")]
        public string? IdadeCalculo { get; set; }

        [JsonProperty("IndicativoExibeValorPremioCotacao")]
        public string? IndicativoExibeValorPremioCotacao { get; set; }

        [JsonProperty("IndicativoExigeValorRisco")]
        public string? IndicativoExigeValorRisco { get; set; }

        [JsonProperty("IndicativoSolicitaRelacaoBens")]
        public string? IndicativoSolicitaRelacaoBens { get; set; }

        [JsonProperty("IndicativoUsoExclusivoPlano")]
        public string? IndicativoUsoExclusivoPlano { get; set; }

        [JsonProperty("IndicativoVigenciaIgualApolice")]
        public string? IndicativoVigenciaIgualApolice { get; set; }

        [JsonProperty("NomeCobertura")]
        public string? NomeCobertura { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("TipoCapital")]
        public string? TipoCapital { get; set; }

        [JsonProperty("TipoCaracteristicaCobertura")]
        public string? TipoCaracteristicaCobertura { get; set; }

        [JsonProperty("TipoCobertura")]
        public string? TipoCobertura { get; set; }

        [JsonProperty("TipoContratacao")]
        public string? TipoContratacao { get; set; }

        [JsonProperty("UnidadeLaudoInspecao")]
        public string? UnidadeLaudoInspecao { get; set; }

        [JsonProperty("ValorLimiteMaximo")]
        public string? ValorLimiteMaximo { get; set; }

        [JsonProperty("ValorLimiteMaximoContratacao")]
        public string? ValorLimiteMaximoContratacao { get; set; }

        [JsonProperty("ValorLimiteMinimoContratacao")]
        public string? ValorLimiteMinimoContratacao { get; set; }

        [JsonProperty("CriterioRiscoLista")]
        public IList<CriterioRiscoLista> CriterioRiscoLista { get; set; }

        [JsonProperty("DependenciaLista")]
        public IList<object> DependenciaLista { get; set; }

        [JsonProperty("DescontosLista")]
        public IList<object> DescontosLista { get; set; }

        [JsonProperty("ExcludenteLista")]
        public IList<object> ExcludenteLista { get; set; }

        [JsonProperty("FranquiaLista")]
        public IList<FranquiaLista> FranquiaLista { get; set; }

        [JsonProperty("ObjetoSeguradoLista")]
        public IList<ObjetoSeguradoLista> ObjetoSeguradoLista { get; set; }

        [JsonProperty("PeriodoIndenitarioLista")]
        public IList<PeriodoIndenitarioLista> PeriodoIndenitarioLista { get; set; }

        [JsonProperty("QuestionarioLista")]
        public IList<object> QuestionarioLista { get; set; }

        [JsonProperty("RegiaoLista")]
        public IList<object> RegiaoLista { get; set; }

        [JsonProperty("TipoInteresseSegurado")]
        public TipoInteresseSegurado TipoInteresseSegurado { get; set; }
    }

    public class Banco
    {

        [JsonProperty("NomeBanco")]
        public string? NomeBanco { get; set; }

        [JsonProperty("NumeroBanco")]
        public string? NumeroBanco { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

    public class ConvenioPagamentoLista
    {

        [JsonProperty("CodigoConvenio")]
        public string? CodigoConvenio { get; set; }

        [JsonProperty("CodigoMeioPagamento")]
        public string? CodigoMeioPagamento { get; set; }

        [JsonProperty("CodigoOrigemCobranca")]
        public string? CodigoOrigemCobranca { get; set; }

        [JsonProperty("CodigoOrigemTransacaoCompra")]
        public string? CodigoOrigemTransacaoCompra { get; set; }

        [JsonProperty("CodigoUtilizacaoParcela")]
        public string? CodigoUtilizacaoParcela { get; set; }

        [JsonProperty("DataInicioVigenciaConvenio")]
        public DateTime DataInicioVigenciaConvenio { get; set; }

        [JsonProperty("IndicativoCartaoBradesco")]
        public string? IndicativoCartaoBradesco { get; set; }

        [JsonProperty("NomeMeioPagamento")]
        public string? NomeMeioPagamento { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("Banco")]
        public Banco Banco { get; set; }
    }

    public class DemaisPagamentos
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("ConvenioPagamentoLista")]
        public IList<ConvenioPagamentoLista> ConvenioPagamentoLista { get; set; }
    }

    public class PrimeiroPagamentoResponse
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("ConvenioPagamentoLista")]
        public IList<ConvenioPagamentoLista> ConvenioPagamentoLista { get; set; }
    }

    public class RestituicaoPagamentos
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("ConvenioPagamentoLista")]
        public IList<object> ConvenioPagamentoLista { get; set; }
    }

    public class CondicaoPagamentoLista
    {

        [JsonProperty("CodigoCanalVenda")]
        public string? CodigoCanalVenda { get; set; }

        [JsonProperty("CodigoFrequenciaPagamento")]
        public string? CodigoFrequenciaPagamento { get; set; }

        [JsonProperty("CodigoTipoContrato")]
        public string? CodigoTipoContrato { get; set; }

        [JsonProperty("CodigoTipoPagamento")]
        public string? CodigoTipoPagamento { get; set; }

        [JsonProperty("NomeCondicaoPagamento")]
        public string? NomeCondicaoPagamento { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("QuantidadeParcelas")]
        public string? QuantidadeParcelas { get; set; }

        [JsonProperty("TipoMovimento")]
        public string? TipoMovimento { get; set; }

        [JsonProperty("ValorAdicionalFracionamento")]
        public string? ValorAdicionalFracionamento { get; set; }

        [JsonProperty("DemaisPagamentos")]
        public DemaisPagamentos DemaisPagamentos { get; set; }

        [JsonProperty("PrimeiroPagamento")]
        public PrimeiroPagamento PrimeiroPagamento { get; set; }

        [JsonProperty("RestituicaoPagamentos")]
        public RestituicaoPagamentos RestituicaoPagamentos { get; set; }
    }

    public class MotivoCancelamentoLista
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("Valor")]
        public string? Valor { get; set; }
    }

    public class PeriodicidadeVigenciaLista
    {

        [JsonProperty("IndicativoPeriodicidadePadrao")]
        public string? IndicativoPeriodicidadePadrao { get; set; }

        [JsonProperty("IndicativoPeriodicidadeVitalicia")]
        public string? IndicativoPeriodicidadeVitalicia { get; set; }

        [JsonProperty("NomePeriodicidade")]
        public string? NomePeriodicidade { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("QuantidadePeriodicidade")]
        public string? QuantidadePeriodicidade { get; set; }

        [JsonProperty("UnidadePeriodicidade")]
        public string? UnidadePeriodicidade { get; set; }
    }

    public class ProcessoOrgaoReguladorListaResponse
    {

        [JsonProperty("IndicativoProcessoPrincipal")]
        public string? IndicativoProcessoPrincipal { get; set; }

        [JsonProperty("NumeroProcessoOrgaoRegulador")]
        public string? NumeroProcessoOrgaoRegulador { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("GrupoRamoRegedor")]
        public GrupoRamoRegedor GrupoRamoRegedor { get; set; }
    }

    public class PxDPParameters
    {

        [JsonProperty("pzInsKey")]
        public string? PzInsKey { get; set; }
    }

    public class PySourcePage
    {

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }

        [JsonProperty("pyConnectorType")]
        public string? PyConnectorType { get; set; }

        [JsonProperty("pySourceClass")]
        public string? PySourceClass { get; set; }

        [JsonProperty("pySourceIdentifier")]
        public string? PySourceIdentifier { get; set; }

        [JsonProperty("pySourceNumber")]
        public string? PySourceNumber { get; set; }

        [JsonProperty("pySourceType")]
        public string? PySourceType { get; set; }
    }

    public class TipoParceiroNegocioLista
    {

        [JsonProperty("CodigoParceiroNegocio")]
        public string? CodigoParceiroNegocio { get; set; }

        [JsonProperty("DescricaoParceiroNegocio")]
        public string? DescricaoParceiroNegocio { get; set; }

        [JsonProperty("pxObjClass")]
        public string? PxObjClass { get; set; }
    }

}