using Newtonsoft.Json;
using ScoroNet.Models.Collections;

namespace ScoroNet.Core
{
    public class SCFieldResponse : SCResponse
    {
        [JsonProperty("field")]
        public SCField Field { get; set; }
    }
}
