using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APICalculo.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CartaoCredito {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// informar a bandeira do cartão de crédito
    /// </summary>
    /// <value>informar a bandeira do cartão de crédito</value>
    [DataMember(Name="NomeAdministradoraCartaoCredito", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NomeAdministradoraCartaoCredito")]
    public string? NomeAdministradoraCartaoCredito { get; set; }

    /// <summary>
    /// informar o número do cartão de crédito
    /// </summary>
    /// <value>informar o número do cartão de crédito</value>
    [DataMember(Name="NumeroCartaoCreditoTexto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroCartaoCreditoTexto")]
    public string? NumeroCartaoCreditoTexto { get; set; }

    /// <summary>
    /// informar a data de validade do cartão de crédito
    /// </summary>
    /// <value>informar a data de validade do cartão de crédito</value>
    [DataMember(Name="ValidadeCartaoCredito", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValidadeCartaoCredito")]
    public string? ValidadeCartaoCredito { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartaoCredito {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  NomeAdministradoraCartaoCredito: ").Append(NomeAdministradoraCartaoCredito).Append("\n");
      sb.Append("  NumeroCartaoCreditoTexto: ").Append(NumeroCartaoCreditoTexto).Append("\n");
      sb.Append("  ValidadeCartaoCredito: ").Append(ValidadeCartaoCredito).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string? ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
