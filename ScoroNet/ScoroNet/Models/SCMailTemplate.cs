using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCMailTempleteItem
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
