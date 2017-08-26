using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCClientKeys
    {
        [JsonProperty("android")]
        public string Android { get; set; }

        [JsonProperty("ios")]
        public string iOS { get; set; }

        [JsonProperty("javascript")]
        public string JavaScript { get; set; }

        [JsonProperty("winphone")]
        public string WinPhone { get; set; }
    }
}
