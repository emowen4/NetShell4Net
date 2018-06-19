using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Monicais.NetShell4Net.Context.Http;
using Monicais.NetShell4Net.Context.Wlan;

namespace Monicais.NetShell4Net
{
    public class Netsh : AbstractCommand
    {
        public Netsh() : base("netsh", null)
        {
            Wlan = new Wlan(this);
            Http = new Http(this);
        }

        public Wlan Wlan { get; }

        public Http Http { get; }
    }
}
