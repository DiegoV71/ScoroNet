using System;

namespace ScoroNet.Models
{
    public class SCCollectionItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public bool UseDocsACL { get; set; }
        public SCACLInfo<string[]> ACL { get; set; }
        public SCField[] Fields { get; set; }
        public bool System { get; set; }
        public bool Notify { get; set; }

        /// <summary>
        /// FIX ME.
        /// </summary>
        [Obsolete("FIX")]
        public object Indexes { get; set; }
    }
}
