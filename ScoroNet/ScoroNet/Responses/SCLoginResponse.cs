using Newtonsoft.Json;
using ScoroNet.Core;
using ScoroNet.Models;

namespace ScoroNet.Responses
{
    public class SCLoginResponse<T> : SCResponse 
        where T : SCBaseUser
    {
        [JsonProperty("result")]
        public SCUser<T> User { get; set; }
    }
}
