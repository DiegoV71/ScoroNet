using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoroNet.Objects
{
    public class SCQueryInfo
    {
        public Dictionary<string, object> Tree = new Dictionary<string, object>();

        public void AddNode(string field,  object value)
        {
            if (!Tree.ContainsKey(field))
            {
                Tree.Add(field, value);
                return;
            }
            Tree[field] = value;
        }
    }
}
