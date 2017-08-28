using Newtonsoft.Json;

namespace ScoroNet.Models.User
{
    public class SCUser<T> where T : SCUserInfo
    {
        [JsonProperty("sessionId")]
        public string SessionID { get; set; }

        [JsonProperty("user")]
        public T UserInfo { get; set; }
    }
}
