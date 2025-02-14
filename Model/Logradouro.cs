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
  public class Logradouro {
    /// <summary>
    /// informar pxObjClass, necessário envio para funcionamento da API
    /// </summary>
    /// <value>informar pxObjClass, necessário envio para funcionamento da API</value>
    [DataMember(Name="pxObjClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pxObjClass")]
    public string? PxObjClass { get; set; }

    /// <summary>
    /// Gets or Sets Localidade
    /// </summary>
    [DataMember(Name="Localidade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Localidade")]
    public Localidade? Localidade { get; set; }

    /// <summary>
    /// informação do número referente ao endereço do risco
    /// </summary>
    /// <value>informação do número referente ao endereço do risco</value>
    [DataMember(Name="Numero", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Numero")]
    public string? Numero { get; set; }

    /// <summary>
    /// Gets or Sets UnidadeFederacao
    /// </summary>
    [DataMember(Name="UnidadeFederacao", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UnidadeFederacao")]
    public UnidadeFederacao? UnidadeFederacao { get; set; }

    /// <summary>
    /// Gets or Sets TipoLogradouro
    /// </summary>
    [DataMember(Name="TipoLogradouro", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TipoLogradouro")]
    public TipoLogradouro? TipoLogradouro { get; set; }

    /// <summary>
    /// Informação do endereço do risco
    /// </summary>
    /// <value>Informação do endereço do risco</value>
    [DataMember(Name="NomeLogradouro", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NomeLogradouro")]
    public string? NomeLogradouro { get; set; }

    /// <summary>
    /// informação do complemento referente ao endereço do risco
    /// </summary>
    /// <value>informação do complemento referente ao endereço do risco</value>
    [DataMember(Name="Complemento", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Complemento")]
    public string? Complemento { get; set; }

    /// <summary>
    /// Gets or Sets Subdivisao
    /// </summary>
    [DataMember(Name="Subdivisao", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subdivisao")]
    public List<Subdivisao>? Subdivisao { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Logradouro {\n");
      sb.Append("  PxObjClass: ").Append(PxObjClass).Append("\n");
      sb.Append("  Localidade: ").Append(Localidade).Append("\n");
      sb.Append("  Numero: ").Append(Numero).Append("\n");
      sb.Append("  UnidadeFederacao: ").Append(UnidadeFederacao).Append("\n");
      sb.Append("  TipoLogradouro: ").Append(TipoLogradouro).Append("\n");
      sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
      sb.Append("  Complemento: ").Append(Complemento).Append("\n");
      sb.Append("  Subdivisao: ").Append(Subdivisao).Append("\n");
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
