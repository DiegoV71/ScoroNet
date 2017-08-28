using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ScoroNet.Objects
{
    public class SCQuery
    {
        SCQueryInfo info = new SCQueryInfo();
        int skip = 0;
        int limit = 100;

        public SCQuery(string collectionName)
        {
            CollectionName = collectionName;
        }

        public string CollectionName { get; private set; }

        public SCQuery SetLimit(int limit)
        {
            if (limit < 0)
                return this;

            this.limit = limit;
            return this;
        }

        public SCQuery SetSkip(int skip)
        {
            if (skip < 0)
                return this;

            this.skip = skip;
            return this;
        }

        public SCQuery SetPage(int page)
        {
            if (page <= 0)
                return this;

            skip = (page - 1) * limit;
            return this;
        }

        public SCQuery EqualTo(string field, object value)
        {
            AddCondition(field, "$eq", value);
            return this;
        }

        public SCQuery NotEqualTo(string field, object value)
        {
            AddCondition(field, "$ne", value);
            return this;
        }

        public SCQuery ContainedIn(string field, List<object> value)
        {
            AddCondition(field, "$in", value);
            return this;
        }

        public SCQuery ContainsAll(string field, List<object> value)
        {
            AddCondition(field, "$all", value);
            return this;
        }

        public SCQuery NotContainedIn(string field, List<object> value)
        {
            AddCondition(field, "$nin", value);
            return this;
        }

        public SCQuery GreaterThan(string field, object value)
        {
            AddCondition(field, "$gt", value);
            return this;
        }

        public SCQuery GreaterThanOrEqualTo(string field, object value)
        {
            AddCondition(field, "$gte", value);
            return this;
        }

        public SCQuery LessThan(string field, object value)
        {
            AddCondition(field, "$lt", value);
            return this;
        }

        public SCQuery LessThanOrEqualTo(string field, object value)
        {
            AddCondition(field, "$lte", value);
            return this;
        }

        public SCQuery Exist(string field)
        {
            AddCondition(field, "$exists", true);
            return this;
        }

        public SCQuery DoesNotExist(string field)
        {
            AddCondition(field, "$exists", false);
            return this;
        }

        public SCQuery Contains(string field, string regex, SCRegexOption optionsSet)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("$regex", regex);
            dic.Add("$options", optionsSet.Options);
            info.AddNode(field, dic);
            return this;
        }

        public SCQuery StartWith(string field, string regex, SCRegexOption optionsSet = null)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("$regex", "^" + regex);
            if (optionsSet != null)
                dic.Add("$options", optionsSet.Options);
            info.AddNode(field, dic);
            return this;
        }

        public SCQuery EndWith(string field, string regex, SCRegexOption optionsSet = null)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("$regex", regex + "$");
            if (optionsSet != null)
                dic.Add("$options", optionsSet.Options);
            info.AddNode(field, dic);
            return this;
        }

        void AddCondition(string field, string operation, object value)
        {
            var condiction = new Dictionary<string, object>()
            {
                [operation] = value
            };

            info.AddNode(field, condiction);
        }

        public void Clear()
        {
            info.Tree.Clear();
        }
    }
}
