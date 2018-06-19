namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ProfileRandomization : ParameterEnum<string>
    {
        private ProfileRandomization(string value) : base(value) { }

        public static readonly ProfileRandomization Yes = new ProfileRandomization("yes");

        public static readonly ProfileRandomization No = new ProfileRandomization("no");

        public static readonly ProfileRandomization Daily = new ProfileRandomization("daily");
    }
}
