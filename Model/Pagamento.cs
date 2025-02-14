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
  public class Pagamento {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// informar a forma de pagamento do seguro
    /// </summary>
    /// <value>informar a forma de pagamento do seguro</value>
    [DataMember(Name="TipoPagamento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TipoPagamento")]
    public int? TipoPagamento { get; set; }

    /// <summary>
    /// Gets or Sets PrimeiroPagamento
    /// </summary>
    [DataMember(Name="PrimeiroPagamento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimeiroPagamento")]
    public PrimeiroPagamento? PrimeiroPagamento { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pagamento {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
      sb.Append("  PrimeiroPagamento: ").Append(PrimeiroPagamento).Append("\n");
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
