using System;
using System.Collections.Generic;
using System.Text;
using ScoroNet.Models;

using static ScoroNet.Core.SCConst;
using ScoroNet.Core;
using System.Collections.Specialized;
using ScoroNet.Helpers;

namespace ScoroNet.Services
{
    public class AppService
    {
        protected SCAppResponse GetAppInfo(SCAuthKey keys)
        {
            var url = Host + "/app";

            var values = new Dictionary<string,string>();
            values.Add("app", keys.AppKey);
            values.Add("cli", keys.ClientKey);
            values.Add("acc", keys.AccessKey);

            return RequestHelper.Get<SCAppResponse>(url, values);
        }
    }
}
