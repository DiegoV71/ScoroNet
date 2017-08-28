using Newtonsoft.Json;
using ScoroNet.Models.Collections;

namespace ScoroNet.Models.App
{
    public class SCAppInfo
    {
        [JsonProperty("_id")]
        public string ID { get; private set; }

        [JsonProperty("appId")]
        public string AppID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("userId")]
        public string UserID { get; private set; }

        [JsonProperty("serverId")]
        public string ServerID { get; private set; }

        [JsonProperty("limits")]
        public SCAppLimits Limits { get; private set; }

        [JsonProperty("schemas")]
        public SCCollections Schemas { get; private set; }

        [JsonProperty("accessKeys")]
        public SCAccessKeys AccessKeys { get; private set; }

        [JsonProperty("clientKeys")]
        public SCClientKeys ClientKeys { get; private set; }

        [JsonProperty("ACLPublic")]
        public SCACLInfo<bool> ACLPublic { get; private set; }

        [JsonProperty("settings")]
        public SCAppSettings Settings { get; private set; }

        [JsonProperty("storage")]
        public SCAppStorage Storage { get; private set; }

        [JsonProperty("npm")]
        public string NPM { get; private set; }

        [JsonProperty("stringId")]
        public string StringID { get; private set; }

        [JsonProperty("reedonly")]
        public bool ReadOnly { get; private set; }
    }
}
