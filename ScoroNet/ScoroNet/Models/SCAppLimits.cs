using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
{
    public class SCAppLimits
    {
        public int RPS { get; set; }
        public float Store { get; set; }
        public int PushValue { get; set; }
        public int PushUsed { get; set; }
        public int Developers { get; set; }
        public int WS { get; set; }
        public int ScroptTimeout { get; set; }
    }
}
