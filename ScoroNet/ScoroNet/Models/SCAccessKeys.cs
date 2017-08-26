using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCAccessKeys
    {
        [JsonProperty("fileKey")]
        public string FileKey { get; private set; }

        [JsonProperty("masterKey")]
        public string MasterKey { get; private set; }

        [JsonProperty("messageKey")]
        public string MessageKey { get; private set; }

        [JsonProperty("scriptKey")]
        public string ScriptKey { get; private set; }

        [JsonProperty("websocketKey")]
        public string WebSocketKey { get; private set; }
    }
}
