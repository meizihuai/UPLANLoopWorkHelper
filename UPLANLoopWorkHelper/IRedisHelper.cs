using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLANLoopWorkHelper
{
    interface IRedisHelper
    {
        bool Set(string key, string value);
        bool Set(string key, object value);
        string Get(string key);
        T Get<T>(string key);
    }
}
