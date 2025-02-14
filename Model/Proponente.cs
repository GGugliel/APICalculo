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
  public class Proponente {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// informação se o cliente é pessoa física ou jurídica
    /// </summary>
    /// <value>informação se o cliente é pessoa física ou jurídica</value>
    [DataMember(Name="TipoPessoa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TipoPessoa")]
    public string? TipoPessoa { get; set; }

    /// <summary>
    /// informação do segmento da conta do cliente
    /// </summary>
    /// <value>informação do segmento da conta do cliente</value>
    [DataMember(Name="Segmento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Segmento")]
    public string? Segmento { get; set; }

    /// <summary>
    /// Nome do cliente
    /// </summary>
    /// <value>Nome do cliente</value>
    [DataMember(Name="NomePessoa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NomePessoa")]
    public string? NomePessoa { get; set; }

    /// <summary>
    /// Data de nascimento do cliente
    /// </summary>
    /// <value>Data de nascimento do cliente</value>
    [DataMember(Name="DataNascimento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DataNascimento")]
    public string? DataNascimento { get; set; }

    /// <summary>
    /// Gets or Sets TelefoneLista
    /// </summary>
    [DataMember(Name="TelefoneLista", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TelefoneLista")]
    public TelefoneLista? TelefoneLista { get; set; }

    /// <summary>
    /// Gets or Sets EmailLista
    /// </summary>
    [DataMember(Name="EmailLista", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailLista")]
    public EmailLista? EmailLista { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Proponente {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  TipoPessoa: ").Append(TipoPessoa).Append("\n");
      sb.Append("  Segmento: ").Append(Segmento).Append("\n");
      sb.Append("  NomePessoa: ").Append(NomePessoa).Append("\n");
      sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
      sb.Append("  TelefoneLista: ").Append(TelefoneLista).Append("\n");
      sb.Append("  EmailLista: ").Append(EmailLista).Append("\n");
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
