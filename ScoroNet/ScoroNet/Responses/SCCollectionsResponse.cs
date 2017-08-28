using Newtonsoft.Json;
using ScoroNet.Models;
using ScoroNet.Models.Collections;

namespace ScoroNet.Core
{
    public class SCCollectionsResponse : SCResponse
    {
        [JsonProperty("collections")]
        public SCCollections Collections { get; set; }
    }
}
