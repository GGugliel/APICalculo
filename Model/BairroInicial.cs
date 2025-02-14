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
  public class BairroInicial {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// informação do complemento do endereço do risco
    /// </summary>
    /// <value>informação do complemento do endereço do risco</value>
    [DataMember(Name="NomeBairro", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NomeBairro")]
    public string? NomeBairro { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BairroInicial {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  NomeBairro: ").Append(NomeBairro).Append("\n");
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
