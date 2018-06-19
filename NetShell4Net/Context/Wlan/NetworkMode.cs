namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class NetworkMode : ParameterEnum<string>
    {
        private NetworkMode(string value) : base(value) { }

        public static readonly NetworkMode SSID = new NetworkMode("ssid");

        public static readonly NetworkMode BSSID = new NetworkMode("bssid");
    }
}
