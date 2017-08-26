using System;
using System.Collections.Generic;
using System.Text;

namespace ScoroNet.SDK.Models
{
    class SCResponse<T>
    {
        
        public T Result { get; set; }
        public bool Error { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
