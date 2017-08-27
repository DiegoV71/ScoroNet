namespace ScoroNet.Core
{
    public class ScoroCode
    {
        public readonly SCAuthKey AuthKey;

        AppManager appManager;
        AuthManager authManager;

        private ScoroCode(string appKey, string clientKey, string accessKey)
        {
            AuthKey = new SCAuthKey
            {
                AppKey = appKey,
                ClientKey = clientKey,
                AccessKey = accessKey
            };
        }

        public AuthManager Auth
        {
            get
            {
                authManager = authManager ?? new AuthManager(AuthKey);
                return authManager;
            }
        }
        public AppManager App
        {
            get
            {
                appManager = appManager ?? new AppManager(AuthKey);
                return appManager;
            }
        }

        public static ScoroCode Init(string appKey, string clientKey, string accessKey)
        {
            return new ScoroCode(appKey, clientKey, accessKey);
        }        
    }
}
