using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.SDK.Models
{
    public class SCAppSettings
    {
        public bool EmailViriffied { get; set; }
        public int SessionTimeout { get; set; }
        public string AndroidApiKey { get; set; }
        public string GCMSenderID { get; set; }
        public SCMailTemplates MailTemplates { get; set; }
        public object SMTP { get; set; }
    }
}
