namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class HostedNetworkKeyUsage : ParameterEnum<string>
    {
        private HostedNetworkKeyUsage(string value) : base(value) { }

        public static readonly HostedNetworkKeyUsage Persistent = new HostedNetworkKeyUsage("persistent");

        public static readonly HostedNetworkKeyUsage Temporary = new HostedNetworkKeyUsage("temporary");
    }
}
