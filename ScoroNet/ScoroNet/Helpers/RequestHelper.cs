using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;
using System.Linq;
using System.IO;

namespace ScoroNet.Helpers
{
    public static class RequestHelper
    {
        public static T Get<T>(string url, Dictionary<string, string> args)
        {
            var request = HttpWebRequest.CreateHttp(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Host = "api.scorocode.ru";

            var parameters = JsonConvert.SerializeObject(args);
            

            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(parameters.ToString());
            }

            var response = request.GetResponse();
            var json = string.Empty;

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
