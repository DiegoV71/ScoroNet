using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoroNet.Core;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var appKey = "f6c5e17878fd473ea98b32fac3cb2eda";
            var clientKey = "b0d725adde704dcb87cb39fc7e5ea9b2";
            var accessKey = "a19b04edd00347f2b0ce4a07c55fb8b6";
            var service = ScoroCode.Init(appKey, clientKey, accessKey);
            var info = service.App.GetAppInfo();

            Console.ReadKey();
        }
    }
}
