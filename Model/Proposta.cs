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
  public class Proposta {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// Gets or Sets InteresseSegurado
    /// </summary>
    [DataMember(Name="InteresseSegurado", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InteresseSegurado")]
    public InteresseSegurado? InteresseSegurado { get; set; }

    /// <summary>
    /// Gets or Sets Proponente
    /// </summary>
    [DataMember(Name="Proponente", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Proponente")]
    public Proponente? Proponente { get; set; }

    /// <summary>
    /// Gets or Sets Pagamento
    /// </summary>
    [DataMember(Name="Pagamento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Pagamento")]
    public Pagamento? Pagamento { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Proposta {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  InteresseSegurado: ").Append(InteresseSegurado).Append("\n");
      sb.Append("  Proponente: ").Append(Proponente).Append("\n");
      sb.Append("  Pagamento: ").Append(Pagamento).Append("\n");
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
