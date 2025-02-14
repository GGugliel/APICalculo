using Newtonsoft.Json;

namespace APICalculo.Model
{

    /// <summary>
    /// 
    /// </summary>
    public class ResponseErrorsInner 
    {
        /// <summary>
        /// lista de mensagens de erros funcionais e técnicos
        /// </summary>
        /// <value>lista de mensagens de erros funcionais e técnicos</value>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? CodeError { get; set; }

        /// <summary>
        /// lista de mensagens de erros funcionais e técnicos
        /// </summary>
        /// <value>lista de mensagens de erros funcionais e técnicos</value>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Message { get; set; }

        /// <summary>
        /// lista de mensagens de erros funcionais e técnicos
        /// </summary>
        /// <value>lista de mensagens de erros funcionais e técnicos</value>
        [JsonProperty("pxObjClass", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? PxObjClass { get; set; }

    }
}
