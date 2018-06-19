using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class CacheParamType : ParameterEnum<string>
    {
        private CacheParamType(string value) : base(value) { }

        public static readonly CacheParamType CacheRangeChunkSize = new CacheParamType("cacherangechunksize");

        public static readonly CacheParamType MaxCacheResponseSize = new CacheParamType("maxcacheresponsesize");
    }
}
