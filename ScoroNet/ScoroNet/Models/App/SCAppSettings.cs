using Newtonsoft.Json;

namespace ScoroNet.Models.App
{
    public class SCAppSettings
    {
        [JsonProperty("emailVirified")]
        public bool EmailVirified { get; set; }

        [JsonProperty("sessionTimeout")]
        public int SessionTimeout { get; set; }

        [JsonProperty("androidApiKey")]
        public string AndroidApiKey { get; set; }

        [JsonProperty("gcmSenderId")]
        public string GCMSenderID { get; set; }

        [JsonProperty("mailTemplates")]
        public SCMailTemplates MailTemplates { get; set; }

        [JsonProperty("smtp")]
        public object SMTP { get; set; }
    }
}
