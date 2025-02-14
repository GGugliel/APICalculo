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
  public class PrimeiroPagamento {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// Gets or Sets CartaoCredito
    /// </summary>
    [DataMember(Name="CartaoCredito", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CartaoCredito")]
    public CartaoCredito? CartaoCredito { get; set; }

    /// <summary>
    /// Gets or Sets ContaBancaria
    /// </summary>
    [DataMember(Name="ContaBancaria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContaBancaria")]
    public ContaBancaria? ContaBancaria { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrimeiroPagamento {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  CartaoCredito: ").Append(CartaoCredito).Append("\n");
      sb.Append("  ContaBancaria: ").Append(ContaBancaria).Append("\n");
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
