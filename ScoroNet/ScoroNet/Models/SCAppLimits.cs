using Newtonsoft.Json;

namespace ScoroNet.Models
{
    public class SCAppLimits
    {
        [JsonProperty("rps")]
        public int RPS { get; private set; }

        [JsonProperty("store")]
        public float Store { get; private set; }

        [JsonProperty("pushValue")]
        public int PushValue { get; private set; }

        [JsonProperty("pushUsed")]
        public int PushUsed { get; private set; }

        [JsonProperty("developers")]
        public int Developers { get; private set; }

        [JsonProperty("ws")]
        public int WS { get; private set; }

        [JsonProperty("scriptTimeout")]
        public int ScriptTimeout { get; private set; }
    }
}
