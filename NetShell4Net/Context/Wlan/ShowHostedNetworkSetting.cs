namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class ShowHostedNetworkSetting : ParameterEnum<string>
    {
        private ShowHostedNetworkSetting(string value) : base(value) { }

        public static readonly ShowHostedNetworkSetting Security = new ShowHostedNetworkSetting("security");
    }
}
