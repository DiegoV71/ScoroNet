using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ScoroNet.Helpers
{
    static class RequestHelper
    {
        public static T Get<T>(string url, Dictionary<string, string> args)
        {
            var request = HttpWebRequest.CreateHttp(url);
            request.Method = "POST";
            request.ContentType = "application/json";

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
