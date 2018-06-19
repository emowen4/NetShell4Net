using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class ServiceStateView : ParameterEnum<string>
    {
        private ServiceStateView(string value) : base(value) { }

        public static readonly ServiceStateView Session = new ServiceStateView("session");

        public static readonly ServiceStateView RequestQ = new ServiceStateView("requestq");
    }
}
