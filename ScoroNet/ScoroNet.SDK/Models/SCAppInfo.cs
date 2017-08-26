using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.SDK.Models
{
    public class SCAppInfo
    {
        public string ID { get; set; }
        public string AppID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public string ServerID { get; set; }
        public int MyProperty { get; set; }
        public SCAppLimits Limits { get; set; }

        // <---  Schemas

        public SCAccessKeys AccessKeys { get; set; }
        public SCClientKeys ClientKeys { get; set; }

        public bool ReadOnly { get; set; }
    }
}
