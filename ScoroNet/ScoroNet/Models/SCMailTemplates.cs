using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCMailTemplates
    {
        [JsonProperty("forgot")]
        public SCMailTempleteItem Forgot { get; set; }

        [JsonProperty("reg")]
        public SCMailTempleteItem Reg { get; set; }
    }
}
