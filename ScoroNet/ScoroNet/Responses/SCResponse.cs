using Newtonsoft.Json;

namespace ScoroNet.Core
{
    public class SCResponse
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("errCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("errMsg")]
        public string ErrorMessage { get; set; }

        public static implicit operator bool(SCResponse response) => !response.Error;
    }
}
