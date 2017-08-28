using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoroNet.Objects
{
    public class SCUpdateInfo
    {
        public Dictionary<string, Dictionary<string, object>> Tree { get; } = new Dictionary<string, Dictionary<string, object>>();

        public void AddNode(string field, string operation, object value)
        {
            if (!Tree.ContainsKey(operation))
                Tree.Add(field, new Dictionary<string, object>());

            if (!Tree[operation].ContainsKey(field))
            {
                Tree[operation].Add(field, value);
                return;
            }

            Tree[operation][field] = value;
        }
    }
}
