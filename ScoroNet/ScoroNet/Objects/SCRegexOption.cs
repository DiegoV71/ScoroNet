using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoroNet.Objects
{
    public class SCRegexOption
    {
        string options = string.Empty;

        public static SCRegexOption New()
        {
            return new SCRegexOption();
        }

        public static string None => string.Empty;

        private SCRegexOption()
        { }

        public string Options => options;

        public SCRegexOption SetRegexCaseInsenssitive()
        {
            return AddOptions("i");
        }

        public SCRegexOption SetMatchAnchorsOnEveryLine()
        {
            return AddOptions("m");
        }

        public SCRegexOption SetIgnoreWhitespacesInPattern()
        {
            return AddOptions("x");
        }

        public SCRegexOption SeAllowDotCharacterInPatten()
        {
            return AddOptions("s");
        }        

        SCRegexOption AddOptions(string option)
        {
            if (!options.Contains(option))
                options += option;
            return this;
        }
    }
}
