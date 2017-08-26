using ScoroNet.Models;
using ScoroNet.ServiceWrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.Core
{
    public class ScoroCode
    {
        public readonly SCAuthKey AuthKey;

        AppManager app;

        private ScoroCode(string appKey, string clientKey, string accessKey)
        {
            AuthKey = new SCAuthKey
            {
                AppKey = appKey,
                ClientKey = clientKey,
                AccessKey = accessKey
            };
        }

        public AppManager App => app ?? new AppManager(AuthKey);

        public static ScoroCode Init(string appKey, string clientKey, string accessKey)
        {
            return new ScoroCode(appKey, clientKey, accessKey);
        }        
    }
}
