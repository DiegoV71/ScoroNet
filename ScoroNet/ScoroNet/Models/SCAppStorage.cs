using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCAppStorage
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
