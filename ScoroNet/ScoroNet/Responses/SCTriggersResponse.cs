using Newtonsoft.Json;
using ScoroNet.Models;

namespace ScoroNet.Core
{
    public class SCTriggersResponse : SCResponse
    {
        [JsonProperty("triggers")]
        public SCField Triggers { get; set; }
    }
}
