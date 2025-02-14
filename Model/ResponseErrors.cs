using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using APICalculo.Interfaces;

namespace APICalculo.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ResponseErrors 
    {

        /// <summary>
        /// lista de mensagens de erros funcionais e técnicos
        /// </summary>
        /// <value>lista de mensagens de erros funcionais e técnicos</value>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ResponseErrorsInner? Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Errors {\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string? ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }

}