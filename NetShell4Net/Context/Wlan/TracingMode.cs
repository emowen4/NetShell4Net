namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class TracingMode : ParameterEnum<string>
    {
        private TracingMode(string value) : base(value) { }

        public static readonly TracingMode Yes = new TracingMode("yes");

        public static readonly TracingMode No = new TracingMode("no");

        public static readonly TracingMode Persistent = new TracingMode("persistent");
    }
}
