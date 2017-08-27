using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCAppStorage
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
