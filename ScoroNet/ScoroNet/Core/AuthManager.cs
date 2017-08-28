using ScoroNet.Models;
using ScoroNet.Models.User;
using ScoroNet.Responses;
using ScoroNet.ServiceWrappers;

namespace ScoroNet.Core
{
    public class AuthManager
    {
        SCAuthKey authKeys;
        AuthServiceWrapper wrapper = new AuthServiceWrapper();

        public AuthManager(SCAuthKey authKeys)
        {
            this.authKeys = authKeys;
        }

        public SCLoginResponse<SCUserInfo> Login(string email, string password) =>
            Login<SCUserInfo>(email, password);

        public SCLoginResponse<T> Login<T>(string email, string password) where T : SCUserInfo =>
            wrapper.TryLogin<T>(authKeys, email, password);

        public SCResponse Register<T>(string userName, string email, string password, T additionalInfo = default(T)) => 
            wrapper.TryRegister(authKeys, userName, email, password, additionalInfo);

        public SCResponse Logout(string sessionId) => 
            wrapper.TryLogout(authKeys, sessionId);

        public SCResponse Logout<T>(SCUser<T> user) where T : SCUserInfo => 
            Logout(user.SessionID);
    }
}
