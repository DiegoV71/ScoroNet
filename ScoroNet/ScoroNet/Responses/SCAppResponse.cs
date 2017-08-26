using Newtonsoft.Json;
using ScoroNet.Models;

namespace ScoroNet.Core
{
    public class SCAppResponse : SCResponse
    {
        [JsonProperty("app")]
        public SCAppInfo AppInfo { get; set; }
    }
}
