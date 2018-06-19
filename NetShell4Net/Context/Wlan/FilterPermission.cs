namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class FilterPermission : ParameterEnum<string>
    {
        private FilterPermission(string value) : base(value) { }

        public static readonly FilterPermission Allow = new FilterPermission("allow");

        public static readonly FilterPermission Block = new FilterPermission("block");

        public static readonly FilterPermission DenyAll = new FilterPermission("denyall");
    }
}
