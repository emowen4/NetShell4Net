namespace Monicais.NetShell4Net.Context.Lan
{
    public sealed class Lan : AbstractCommand
    {
        public Lan(ICommand parent) : base("lan", parent) { }

        public bool AddProfile(out string outputs,
                               string filename,
                               string @interface)
        {
            return Execute("add profile"
                         + ParameterUtil.Required(nameof(filename), filename, true)
                         + ParameterUtil.Required(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool DeleteProfile(out string outputs,
                                  string @interface)
        {
            return Execute("delete profile"
                         + ParameterUtil.Required(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool ExportProfile(out string outputs,
                                  string folder,
                                  string @interface = null)
        {
            return Execute("export profile"
                         + ParameterUtil.Required(nameof(folder), folder, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool Reconnect(out string outputs,
                              string @interface)
        {
            return Execute("reconnect"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool SetAllowExplicitCreds(out string outputs,
                                          bool allow)
        {
            return Execute("set allowexplicitcreds"
                         + ParameterUtil.Required(nameof(allow), allow, "yes", "no"),
                           out outputs);
        }

        public bool SetAutoConfig(out string outputs,
                                  bool enabled,
                                  string @interface)
        {
            return Execute("set allowexplicitcreds"
                         + ParameterUtil.Required(nameof(enabled), enabled, "yes", "no")
                         + ParameterUtil.Required(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool SetBlockPeriod(out string outputs,
                                   int value)
        {
            return Execute("set blockperiod"
                         + ParameterUtil.Required(nameof(value), value),
                           out outputs);
        }

        public bool SetEapUserData(out string outputs,
                                   string filename,
                                   bool allusers,
                                   string @interface)
        {
            return Execute("set eapuserdata"
                         + ParameterUtil.Required(nameof(filename), filename, true)
                         + ParameterUtil.Required(nameof(allusers), allusers, "yes", "no")
                         + ParameterUtil.Required(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool SetProfileParameter(out string outputs,
                                        string @interface = null,
                                        ProfileAuthMode autoMode = null,
                                        ProfileSsoMode ssoMode = null,
                                        int? maxDelay = null,
                                        bool? allowDialog = null,
                                        bool? userVLAN = null,
                                        bool? oneXEnabled = null,
                                        bool? oneXEnforced = null)
        {
            return Execute("set profileparameter"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(autoMode), autoMode)
                         + ParameterUtil.Optional(nameof(ssoMode), ssoMode)
                         + ParameterUtil.Optional(nameof(maxDelay), maxDelay)
                         + ParameterUtil.Optional(nameof(allowDialog), allowDialog, "yes", "no")
                         + ParameterUtil.Optional(nameof(userVLAN), userVLAN, "yes", "no")
                         + ParameterUtil.Optional(nameof(oneXEnabled), oneXEnabled, "yes", "no")
                         + ParameterUtil.Optional(nameof(oneXEnforced), oneXEnforced, "yes", "no"),
                           out outputs);
        }

        public bool SetTracing(out string outputs,
                               TracingMode mode)
        {
            return Execute("set tracing"
                         + ParameterUtil.Optional(nameof(mode), mode),
                           out outputs);
        }

        public bool ShowInterfaces(out string outputs)
        {
            return Execute("show interfaces",
                           out outputs);
        }

        public bool ShowProfiles(out string outputs,
                                 string @interface = null)
        {
            return Execute("show profiles"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool ShowSettings(out string outputs)
        {
            return Execute("show settings",
                           out outputs);
        }

        public bool ShowTracing(out string outputs)
        {
            return Execute("show tracing",
                           out outputs);
        }
    }
}
