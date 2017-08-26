﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Models
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
        public SCCollections Schemas { get; set; }
        public SCAccessKeys AccessKeys { get; set; }
        public SCClientKeys ClientKeys { get; set; }       

        public SCACLInfo ACLPublic { get; set; }
        public SCAppSettings Settings { get; set; }
        public SCAppStorage Storage { get; set; }

        public string NPM { get; set; }
        public string StringID { get; set; }

        public bool ReadOnly { get; set; }
    }
}