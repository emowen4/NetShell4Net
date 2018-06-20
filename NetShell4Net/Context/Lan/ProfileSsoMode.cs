namespace Monicais.NetShell4Net.Context.Lan
{
    public sealed class ProfileSsoMode : ParameterEnum<string>
    {
        private ProfileSsoMode(string value) : base(value) { }

        public static readonly ProfileSsoMode PreLogon = new ProfileSsoMode("preLogon");

        public static readonly ProfileSsoMode PostLogon = new ProfileSsoMode("postLogon");

        public static readonly ProfileSsoMode None = new ProfileSsoMode("none");
    }
}
