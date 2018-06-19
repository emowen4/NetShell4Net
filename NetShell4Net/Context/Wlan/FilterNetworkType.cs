namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class FilterNetworkType : ParameterEnum<string>
    {
        private FilterNetworkType(string value) : base(value) { }

        public static readonly FilterNetworkType Adhoc = new FilterNetworkType("adhoc");

        public static readonly FilterNetworkType Infrastructure = new FilterNetworkType("infrastructure");
    }
}
