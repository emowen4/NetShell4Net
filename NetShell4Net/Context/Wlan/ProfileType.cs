namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileType : ParameterEnum<string>
    {
        private ProfileType(string value) : base(value) { }

        public static readonly ProfileType All = new ProfileType("all");

        public static readonly ProfileType Current = new ProfileType("current");
    }
}
