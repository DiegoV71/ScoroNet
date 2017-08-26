using ScoroNet.Core;
using ScoroNet.Models;
using ScoroNet.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ScoroNet.ServiceWrappers
{
    public class AppServiceWrapper : AppService
    {
        public SCAppResponse TryGetAppInfo(SCAuthKey keys)
        {
            try
            {
                return GetAppInfo(keys);
            }
            catch (WebException e)
            {
                var stream = e.Response.GetResponseStream();
                var respons = string.Empty;
                using (var reader = new StreamReader(stream))
                {
                    respons = reader.ReadToEnd();
                }

                return null;
            }
            catch (Exception e)
            {

                return null;
            }
        }
    }
}
