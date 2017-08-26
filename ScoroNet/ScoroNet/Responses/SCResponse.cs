using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ScoroNet.Core
{
    public abstract class SCResponse
    {
        public bool Error { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
