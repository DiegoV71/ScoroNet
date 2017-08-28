using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoroNet.Objects
{
    public class SCUpdate
    {
        SCUpdateInfo info = new SCUpdateInfo();

        public SCUpdate Set(string field, object value)
        {
            info.AddNode(field, "$set", value);
            return this;
        }

        public SCUpdate Push(string field, object value)
        {
            info.AddNode(field, "$push", value);
            return this;
        }

        public SCUpdate PopFirst(string field, object value)
        {
            info.AddNode(field, "$pop", (sbyte)ItemPosition.First);
            return this;
        }

        public SCUpdate PopLast(string field, object value)
        {
            info.AddNode(field, "$pop", (sbyte)ItemPosition.Last);
            return this;
        }

        public SCUpdate Pull(string field, object value)
        {
            info.AddNode(field, "$pull", value);
            return this;
        }

        public SCUpdate PullAll(string field, List<Object> value)
        {
            info.AddNode(field, "$pullAll", value);
            return this;
        }

        public SCUpdate AddToSet(string field, object value)
        {
            info.AddNode(field, "$addToSet", value);
            return this;
        }

        public SCUpdate Inc(string field, object value)
        {
            info.AddNode(field, "$inc", value);
            return this;
        }

        public SCUpdate SetCurrentDate(string field)
        {
            var dic = new Dictionary<string, string>()
            {
               ["$type"] = "date"
            };
            info.AddNode(field, "$currentDate", dic);
            return this;
        }

        public SCUpdate Mul(string field, object value)
        {
            info.AddNode(field, "$mul", value);
            return this;
        }

        public SCUpdate Min(string field, object value)
        {
            info.AddNode(field, "$min", value);
            return this;
        }

        public SCUpdate Max(string field, object value)
        {
            info.AddNode(field, "$max", value);
            return this;
        }

        public SCUpdateInfo Info => info;

        private enum ItemPosition : sbyte
        {
            First = -1,
            Last = 1
        }        
    }
}
