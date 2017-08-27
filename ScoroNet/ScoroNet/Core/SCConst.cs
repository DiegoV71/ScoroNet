namespace ScoroNet.Core
{
    static internal class SCConst
    {
        const string Protocol = "https://";
        const string Domain = "api.scorocode.ru/api/";
        const string ApiVesrion = "v1";

        static public string Host => $"{Protocol}{Domain}{ApiVesrion}";
    }
}
