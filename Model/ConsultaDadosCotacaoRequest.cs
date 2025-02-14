using System.Runtime.Serialization;

namespace APICalculo.Model
{

    /// <summary>
    /// GET - consulta Dados Cotacao
    /// </summary>
    [DataContract]
    public class ConsultaDadosCotacaoRequest
    {
        /// <summary>
        /// valor referente ao codigo origem do produto
        /// </summary>
        public string? CodigoOrigem { get; set; }

        /// <summary>
        /// valor referente ao codigo familia do produto
        /// </summary>
        public string? CodigoFamiliaProduto { get; set; }

        /// <summary>
        /// valor referente ao codigo do produto
        /// </summary>
        public string? CodigoProduto { get; set; }

    }

}