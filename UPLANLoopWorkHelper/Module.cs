using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLANLoopWorkHelper
{
    class Module
    {
        public static readonly string DisplayPlatform_DPIndexInfo = "DisplayPlatform-DPIndexInfo";
        public static readonly string DisplayPlatform_DetailQuota = "DisplayPlatform-DetailQuota-{0}-{1}";
        public static IRedisHelper redisHelper = new OracleCacheHelper();
    }
}
