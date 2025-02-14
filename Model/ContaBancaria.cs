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
  public class ContaBancaria {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// informar o número do Banco
    /// </summary>
    /// <value>informar o número do Banco</value>
    [DataMember(Name="NumeroBanco", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroBanco")]
    public int? NumeroBanco { get; set; }

    /// <summary>
    /// informar o número da agência
    /// </summary>
    /// <value>informar o número da agência</value>
    [DataMember(Name="NumeroAgencia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroAgencia")]
    public string? NumeroAgencia { get; set; }

    /// <summary>
    /// informar o número da conta bancária
    /// </summary>
    /// <value>informar o número da conta bancária</value>
    [DataMember(Name="NumeroContaBancaria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumeroContaBancaria")]
    public string? NumeroContaBancaria { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContaBancaria {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
      sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
      sb.Append("  NumeroContaBancaria: ").Append(NumeroContaBancaria).Append("\n");
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
