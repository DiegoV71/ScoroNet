using Newtonsoft.Json;
using ScoroNet.Models;

namespace ScoroNet.Core
{
    public class SCCollectionResponse : SCResponse
    {
        [JsonProperty("collection")]
        public SCCollectionItem Collection { get; set; }
    }
}
