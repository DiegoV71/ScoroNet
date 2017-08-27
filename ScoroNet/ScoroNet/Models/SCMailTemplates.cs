using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCMailTemplates
    {
        [JsonProperty("forgot")]
        public SCMailTempleteItem Forgot { get; set; }

        [JsonProperty("reg")]
        public SCMailTempleteItem Reg { get; set; }
    }
}
