using Newtonsoft.Json;
using System;

namespace ScoroNet.Models.User
{
    public class SCUserInfo
    {
        [JsonProperty("_id")]
        public string ID { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("emailVerified")]
        public bool EMailVerified { get; set; }

        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("readACL")]
        public string[] ReadACL { get; set; }

        [JsonProperty("removeACL")]
        public string[] RemoveACL { get; set; }

        [JsonProperty("updateACL")]
        public string[] UpdateACL { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }
    }
}
