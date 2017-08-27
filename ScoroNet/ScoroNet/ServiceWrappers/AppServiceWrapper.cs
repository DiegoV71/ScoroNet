using ScoroNet.Core;
using ScoroNet.Helpers;
using ScoroNet.Services;
using System.Net;

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
            catch (WebException ex)
            {
                return (SCAppResponse)RequestExceptionHelper.FillRequestError(ex);
            }
        }
    }
}
