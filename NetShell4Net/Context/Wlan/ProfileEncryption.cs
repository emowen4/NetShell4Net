namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileEncryption : ParameterEnum<string>
    {
        private ProfileEncryption(string value) : base(value) { }

        public static readonly ProfileEncryption None = new ProfileEncryption("none");

        public static readonly ProfileEncryption WEP = new ProfileEncryption("WEP");

        public static readonly ProfileEncryption TKIP = new ProfileEncryption("TKIP");

        public static readonly ProfileEncryption AES = new ProfileEncryption("AES");
    }
}
