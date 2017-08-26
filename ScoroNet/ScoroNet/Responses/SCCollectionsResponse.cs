using Newtonsoft.Json;
using ScoroNet.Models;

namespace ScoroNet.Core
{
    public class SCCollectionsResponse : SCResponse
    {
        [JsonProperty("collections")]
        public SCCollections Collections { get; set; }
    }
}
