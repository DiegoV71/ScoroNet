using System;
using ScoroNet.Core;
using Newtonsoft.Json;
using ScoroNet.Models;
using ScoroNet.Models.User;

namespace Sample
{
    class MyUser : SCUserInfo
    {
        [JsonProperty("test")]
        public string Test { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var appKey = "f6c5e17878fd473ea98b32fac3cb2eda";
            var clientKey = "b0d725adde704dcb87cb39fc7e5ea9b2";
            var accessKey = "a19b04edd00347f2b0ce4a07c55fb8b6";
            var service = ScoroCode.Init(appKey, clientKey, accessKey);
            var login = service.Auth.Login<MyUser>("test@mail.ru", "kekus228");

            if (!login)
                Console.WriteLine("Register error: {0}", login.ErrorMessage);
            else Console.WriteLine("Login success : {0}", login.User.UserInfo.UserName);

            Console.ReadKey();
        }
    }
}
