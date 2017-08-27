using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCMailTempleteItem
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
