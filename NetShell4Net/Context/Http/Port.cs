using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class Port : ParameterEnum<string>
    {
        public Port(PortType type, string value) : base(value)
        {
            Type = type;
        }

        public PortType Type { get; }

        public string TypeName
        {
            get
            {
                switch (Type)
                {
                    case PortType.HostnamePort:
                        return "hostnameport";
                    case PortType.IPPort:
                        return "ipport";
                    case PortType.CCS:
                        return "ccs";
                    default:
                        return string.Empty;
                }
            }
        }

        public static Port HostnamePort(string hostnameport)
        {
            return new Port(PortType.HostnamePort, hostnameport);
        }

        public static Port IPPort(string ipport)
        {
            return new Port(PortType.IPPort, ipport);
        }

        public static Port CCS(string ccs)
        {
            return new Port(PortType.CCS, ccs);
        }
    }

    public enum PortType
    {
        HostnamePort,
        IPPort,
        CCS
    }
}
