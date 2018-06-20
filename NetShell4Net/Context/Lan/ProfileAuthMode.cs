namespace Monicais.NetShell4Net.Context.Lan
{
    public sealed class ProfileAuthMode : ParameterEnum<string>
    {
        private ProfileAuthMode(string value) : base(value) { }

        public static readonly ProfileAuthMode MachineOrUser = new ProfileAuthMode("machineOrUser");

        public static readonly ProfileAuthMode MachineOnly = new ProfileAuthMode("machineOnly");

        public static readonly ProfileAuthMode UserOnly = new ProfileAuthMode("userOnly");

        public static readonly ProfileAuthMode Guest = new ProfileAuthMode("guest");
    }
}
