namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileConnectionType : ParameterEnum<string>
    {
        private ProfileConnectionType(string value) : base(value) { }

        public static readonly ProfileConnectionType ESS = new ProfileConnectionType("ESS");

        public static readonly ProfileConnectionType IBSS = new ProfileConnectionType("IBSS");
    }
}
