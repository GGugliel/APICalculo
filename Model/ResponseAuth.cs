using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APICalculo.Model
{
    /// <summary>
    /// Response Auth
    /// </summary>
    public class ResponseAuth : ResponseErrors
    {
        /// <summary>
        /// token_type
        /// </summary>
        [JsonProperty("token_type")]
        public string? TokenTtype { get; set; }

        /// <summary>
        /// expires_in
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// consented_on
        /// </summary>
        [JsonProperty("consented_on", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ConsentedOn { get; set; }

        /// <summary>
        /// access_token
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? AccessToken { get; set; }

        /// <summary>
        /// refresh_token
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// encryptkey
        /// </summary>
        [JsonProperty("encryptkey", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? EncryptKey { get; set; }

        /// <summary>
        /// signkey
        /// </summary>
        [JsonProperty("signkey", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? SignKey { get; set; }
    }

}