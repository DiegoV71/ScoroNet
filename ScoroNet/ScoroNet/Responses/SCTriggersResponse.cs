using Newtonsoft.Json;
using ScoroNet.Models;
using ScoroNet.Models.Collections;

namespace ScoroNet.Core
{
    public class SCTriggersResponse : SCResponse
    {
        [JsonProperty("triggers")]
        public SCField Triggers { get; set; }
    }
}
