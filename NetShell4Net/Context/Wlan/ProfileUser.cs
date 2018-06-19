namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileUser : ParameterEnum<string>
    {
        private ProfileUser(string value) : base(value) { }

        public static readonly ProfileUser All = new ProfileUser("all");

        public static readonly ProfileUser Current = new ProfileUser("current");
    }
}
