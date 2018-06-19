namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class HostedNetworkData : ParameterEnum<string>
    {
        private HostedNetworkData(string value) : base(value) { }

        public static readonly HostedNetworkData Key = new HostedNetworkData("key");
    }
}
