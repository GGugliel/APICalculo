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
  public class Content {
    /// <summary>
    /// CNPJ do cliente
    /// </summary>
    /// <value>CNPJ do cliente</value>
    [DataMember(Name="NumeroDocumentoPJ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroDocumentoPJ")]
    public string? NumeroDocumentoPJ { get; set; }

    /// <summary>
    /// Gets or Sets Proposta
    /// </summary>
    [DataMember(Name="Proposta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Proposta")]
    public Proposta? Proposta { get; set; }

    /// <summary>
    /// CPF do cliente
    /// </summary>
    /// <value>CPF do cliente</value>
    [DataMember(Name="NumeroDocumentoPF", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroDocumentoPF")]
    public string? NumeroDocumentoPF { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Content {\n");
      sb.Append("  NumeroDocumentoPJ: ").Append(NumeroDocumentoPJ).Append("\n");
      sb.Append("  Proposta: ").Append(Proposta).Append("\n");
      sb.Append("  NumeroDocumentoPF: ").Append(NumeroDocumentoPF).Append("\n");
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
