using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCACLInfo<T>
    {
        [JsonProperty("create")]
        public T Create { get; set; }

        [JsonProperty("read")]
        public T Read { get; set; }

        [JsonProperty("remove")]
        public T Remove { get; set; }

        [JsonProperty("update")]
        public T Update { get; set; }
    }
}
