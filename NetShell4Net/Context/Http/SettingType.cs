using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class SettingType : ParameterEnum<string>
    {
        private SettingType(string value) : base(value) { }

        public static readonly SettingType SSLThrottle = new SettingType("sslthrottle");
    }
}
