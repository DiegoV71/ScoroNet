using Newtonsoft.Json;
using ScoroNet.Models;
using ScoroNet.Models.App;

namespace ScoroNet.Core
{
    public class SCAppResponse : SCResponse
    {
        [JsonProperty("app")]
        public SCAppInfo AppInfo { get; private set; }
    }
}
