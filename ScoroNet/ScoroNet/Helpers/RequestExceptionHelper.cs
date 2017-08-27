using Newtonsoft.Json;
using ScoroNet.Core;
using System.IO;
using System.Net;

namespace ScoroNet.Helpers
{
    static class RequestExceptionHelper
    {
        public static SCResponse FillRequestError(WebException exception)
        {
            string json = string.Empty;

            using (var reader = new StreamReader(exception.Response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<SCResponse>(json);
        }
    }
}
