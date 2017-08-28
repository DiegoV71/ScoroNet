using Newtonsoft.Json;

namespace ScoroNet.Models.App
{
    public class SCAppStorage
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
