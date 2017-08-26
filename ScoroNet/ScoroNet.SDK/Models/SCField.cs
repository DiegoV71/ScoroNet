namespace ScoroNet.SDK.Models
{
    public class SCField
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public bool System { get; set; }
        public bool ReadOnly { get; set; }
        public bool Required { get; set; }
    }
}
