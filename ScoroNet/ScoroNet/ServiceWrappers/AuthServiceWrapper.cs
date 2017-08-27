using ScoroNet.Core;
using ScoroNet.Helpers;
using ScoroNet.Models;
using ScoroNet.Responses;
using ScoroNet.Services;
using System.Net;

namespace ScoroNet.ServiceWrappers
{
    public class AuthServiceWrapper : AuthService
    {
        public SCResponse TryRegister<T>(SCAuthKey keys, string userName, string email, string password, T additionalInfo = default(T))
        {
            try
            {
                return Register(keys, userName, email, password, additionalInfo);
            }
            catch (WebException ex)
            {
                return RequestExceptionHelper.FillRequestError(ex);
            }
        }

        public SCLoginResponse<T> TryLogin<T>(SCAuthKey keys, string email, string password) where T : SCBaseUser
        {
            try
            {
                return Login<T>(keys, email, password);
            }
            catch (WebException ex)
            {
                return (SCLoginResponse<T>)RequestExceptionHelper.FillRequestError(ex);
            }
        }

        public SCResponse TryLogout(SCAuthKey keys, string sessionId)
        {
            try
            {
                return Logout(keys, sessionId);
            }
            catch (WebException ex)
            {
                return RequestExceptionHelper.FillRequestError(ex);
            }
        }
    }
}
