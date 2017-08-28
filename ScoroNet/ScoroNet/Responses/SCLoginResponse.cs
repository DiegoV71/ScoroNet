using Newtonsoft.Json;
using ScoroNet.Core;
using ScoroNet.Models;
using ScoroNet.Models.User;

namespace ScoroNet.Core
{
    public class SCLoginResponse<T> : SCResponse 
        where T : SCUserInfo
    {
        [JsonProperty("result")]
        public SCUser<T> User { get; set; }
    }
}
