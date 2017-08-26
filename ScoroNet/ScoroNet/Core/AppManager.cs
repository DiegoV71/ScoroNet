using ScoroNet.Models;
using ScoroNet.ServiceWrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoroNet.Core
{
    public class AppManager
    {
        SCAuthKey authKeys;

        public AppManager(SCAuthKey authKeys)
        {
            this.authKeys = authKeys;
        }

        public SCAppResponse GetAppInfo()
        {
            var wrapper = new AppServiceWrapper();
            return wrapper.TryGetAppInfo(authKeys);
        }
    }
}
