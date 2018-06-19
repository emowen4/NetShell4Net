namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileAuthentication : ParameterEnum<string>
    {
        private ProfileAuthentication(string value) : base(value) { }

        public static readonly ProfileAuthentication Open = new ProfileAuthentication("open");

        public static readonly ProfileAuthentication Shared = new ProfileAuthentication("shared");

        public static readonly ProfileAuthentication WPA = new ProfileAuthentication("WPA");

        public static readonly ProfileAuthentication WPA2 = new ProfileAuthentication("WPA2");

        public static readonly ProfileAuthentication WPAPSK = new ProfileAuthentication("WPAPSK");

        public static readonly ProfileAuthentication WPA2PSK = new ProfileAuthentication("WPA2PSK");
    }
}
