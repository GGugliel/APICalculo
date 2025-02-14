using System.Runtime.Serialization;

namespace APICalculo.Model
{
    /// <summary>
    /// Response Auth
    /// </summary>
    public class ResponseCreateJWT : ResponseErrors
    {
        /// <summary>
        /// encryptkey
        /// </summary>
        public string? EncryptJWT { get; set; }
   }

}