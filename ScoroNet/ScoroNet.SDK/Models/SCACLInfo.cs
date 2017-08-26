using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.SDK.Models
{
    public class SCACLInfo
    {
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Remove { get; set; }
        public bool Update { get; set; }
    }
}
