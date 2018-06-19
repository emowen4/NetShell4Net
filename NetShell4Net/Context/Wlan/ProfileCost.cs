namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileCost : ParameterEnum<string>
    {
        private ProfileCost(string value) : base(value) { }

        public static readonly ProfileCost Default = new ProfileCost("default");

        public static readonly ProfileCost Unrestricted = new ProfileCost("unrestricted");

        public static readonly ProfileCost Fixed = new ProfileCost("fixed");

        public static readonly ProfileCost Variable = new ProfileCost("variable");
    }
}
