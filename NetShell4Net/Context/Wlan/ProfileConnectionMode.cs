namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileConnectionMode : ParameterEnum<string>
    {
        private ProfileConnectionMode(string value) : base(value) { }

        public static readonly ProfileConnectionMode Auto = new ProfileConnectionMode("auto");

        public static readonly ProfileConnectionMode Manual = new ProfileConnectionMode("manual");
    }
}
