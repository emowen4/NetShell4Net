using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class TimeoutType : ParameterEnum<string>
    {
        private TimeoutType(string value) : base(value) { }

        public static readonly TimeoutType IdleConnectionTimeout = new TimeoutType("idleconnectiontimeout");

        public static readonly TimeoutType HeaderWaitTimeout = new TimeoutType("headerwaittimeout");
    }
}
