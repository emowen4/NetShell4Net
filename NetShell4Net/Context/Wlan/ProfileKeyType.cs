namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileKeyType : ParameterEnum<string>
    {
        private ProfileKeyType(string value) : base(value) { }

        public static readonly ProfileKeyType NetworkProfileKey = new ProfileKeyType("networkKey");

        public static readonly ProfileKeyType Passphrase = new ProfileKeyType("passphrase");
    }
}
