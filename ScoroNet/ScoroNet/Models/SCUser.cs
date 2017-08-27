using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCUser<T> where T : SCBaseUser
    {
        [JsonProperty("sessionId")]
        public string SessionID { get; set; }

        [JsonProperty("user")]
        public T User { get; set; }
    }
}
