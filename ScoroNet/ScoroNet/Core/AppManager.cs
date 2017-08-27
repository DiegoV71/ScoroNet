using ScoroNet.ServiceWrappers;

namespace ScoroNet.Core
{
    public class AppManager
    {
        SCAuthKey authKeys;
        AppServiceWrapper wrapper = new AppServiceWrapper();

        public AppManager(SCAuthKey authKeys)
        {
            this.authKeys = authKeys;
        }

        public SCAppResponse GetAppInfo() => wrapper.TryGetAppInfo(authKeys);
    }
}
