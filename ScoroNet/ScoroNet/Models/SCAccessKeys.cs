using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCAccessKeys
    {
        public string FileKey { get; set; }
        public string MasterKey { get; set; }
        public string MessageKey { get; set; }
        public string ScriptKey { get; set; }
        public string WebSocketKey { get; set; }
    }
}
