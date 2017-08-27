using ScoroNet.Core;
using ScoroNet.Helpers;
using ScoroNet.Models;
using ScoroNet.Responses;
using System;
using System.Collections.Generic;

using static ScoroNet.Core.SCConst;

namespace ScoroNet.Services
{
    public class AuthService
    {
        /// <summary>
        /// FIX DOC OBJECT(!).
        /// </summary>
        [Obsolete("Fix DOC object!")]
        protected SCResponse Register<T>(SCAuthKey keys, string userName, string email, string password, T additionalInfo = default(T))
        {
            var url = Host + "/register";

            var values = new Dictionary<string, string>();
            values.Add("app", keys.AppKey);
            values.Add("cli", keys.ClientKey);
            values.Add("acc", keys.AccessKey);
            values.Add("username", userName);
            values.Add("email", email);
            values.Add("password", password);
            //values.Add("doc", "{}"); //fix

            return RequestHelper.Get<SCResponse>(url, values);
        }

        protected SCLoginResponse<T> Login<T>(SCAuthKey keys, string email, string password) where T : SCBaseUser
        {
            var url = Host + "/login";

            var values = new Dictionary<string, string>();
            values.Add("app", keys.AppKey);
            values.Add("cli", keys.ClientKey);
            values.Add("email", email);
            values.Add("password", password);

            return RequestHelper.Get<SCLoginResponse<T>>(url, values);
        }

        protected SCResponse Logout(SCAuthKey keys, string sessionId)
        {
            var url = Host + "/logout";

            var values = new Dictionary<string, string>();
            values.Add("app", keys.AppKey);
            values.Add("cli", keys.ClientKey);
            values.Add("sess", sessionId);

            return RequestHelper.Get<SCResponse>(url, values);
        }
    }
}
