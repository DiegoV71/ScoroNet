using Newtonsoft.Json;
using ScoroNet.Models;
using ScoroNet.Models.Collections;

namespace ScoroNet.Core
{
    public class SCCollectionResponse : SCResponse
    {
        [JsonProperty("collection")]
        public SCCollectionItem Collection { get; set; }
    }
}
