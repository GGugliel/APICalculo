using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APICalculo.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RequestAuth
    {

        /// <summary>
        /// grant_type
        /// </summary>
        [JsonProperty("grant_type")]
        public string? GrantType { get; set; }

        /// <summary>
        /// scope
        /// </summary>
        [JsonProperty("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// client_secret
        /// </summary>
        [JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

       /// <summary>
        /// client_id
        /// </summary>
        [JsonProperty("client_id")]
        public string? ClientId { get; set; }

       /// <summary>
        /// token
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }        
    }

}