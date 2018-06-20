namespace Monicais.NetShell4Net.Context.Wlan
{
    public sealed class Wlan : AbstractCommand
    {
        public Wlan(ICommand parent) : base("wlan", parent) { }

        public bool AddFilter(out string outputs,
                              FilterPermission filterPermission = null,
                              string ssid = null,
                              FilterNetworkType networktype = null)
        {
            return Execute("add filter"
                         + ParameterUtil.Optional(nameof(filterPermission), filterPermission)
                         + ParameterUtil.Optional(nameof(ssid), ssid, true)
                         + ParameterUtil.Optional(nameof(networktype), networktype),
                           out outputs);
        }

        public bool AddProfile(out string outputs,
                               string filename,
                               string @interface = null,
                               ProfileUser profileUser = null)
        {
            return Execute("add profile"
                         + ParameterUtil.Required(nameof(filename), filename, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(profileUser), profileUser),
                           out outputs);
        }

        public bool Connect(out string outputs,
                            string name,
                            string ssid = null,
                            string @interface = null)
        {
            return Execute("connect"
                         + ParameterUtil.Required(nameof(name), name, true)
                         + ParameterUtil.Optional(nameof(ssid), ssid, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool DeleteFilter(out string outputs,
                                 FilterPermission filterPermission = null,
                                 string ssid = null,
                                 FilterNetworkType networktype = null)
        {
            return Execute("delete filter"
                         + ParameterUtil.Optional(nameof(filterPermission), filterPermission)
                         + ParameterUtil.Optional(nameof(ssid), ssid, true)
                         + ParameterUtil.Optional(nameof(networktype), networktype),
                           out outputs);
        }

        public bool DeleteProfile(out string outputs,
                                  string filename,
                                  string @interface = null)
        {
            return Execute("delete profile"
                         + ParameterUtil.Required(nameof(filename), filename, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool Disconnect(out string outputs,
                               string @interface = null)
        {
            return Execute("disconnect"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool ExportHostedNetworkProfile(out string outputs)
        {
            return Execute("export hostednetworkprofile",
                           out outputs);
        }

        public bool ExportProfile(out string outputs,
                                  string name,
                                  string folder,
                                  string @interface = null,
                                  string key = null)
        {
            return Execute("export profile"
                         + ParameterUtil.Required(nameof(name), name, true)
                         + ParameterUtil.Required(nameof(folder), folder, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(key), key, true),
                           out outputs);
        }

        public bool IHVStartLogging(out string outputs)
        {
            return Execute("IHV startlogging",
                           out outputs);
        }

        public bool IHVStopLogging(out string outputs)
        {
            return Execute("IHV stoplogging",
                           out outputs);
        }

        public bool RefreshHostedNetwork(out string outputs,
                                         HostedNetworkData hostedNetworkData)
        {
            return Execute("refresh hostednetwork"
                         + ParameterUtil.Required(nameof(hostedNetworkData), hostedNetworkData),
                           out outputs);
        }

        public bool ReportIssues(out string outputs)
        {
            return Execute("reportissues", out outputs);
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

        public bool SetBlockedNetworks(out string outputs,
                                       bool display)
        {
            return Execute("set blockednetworks"
                         + ParameterUtil.Required(nameof(display), display, "show", "hide"),
                           out outputs);
        }

        public bool SetBlockPeriod(out string outputs,
                                   int value)
        {
            return Execute("set blockperiod"
                         + ParameterUtil.Required(nameof(value), value),
                           out outputs);
        }

        public bool SetCreateAllUserProfile(out string outputs,
                                            bool enabled)
        {
            return Execute("set createalluserprofile"
                         + ParameterUtil.Required(nameof(enabled), enabled, "yes", "no"),
                           out outputs);
        }

        public bool SetHostedNetwork(out string outputs,
                                     bool? mode = null,
                                     string ssid = null,
                                     string key = null,
                                     HostedNetworkKeyUsage hostedNetworkKeyUsage = null)
        {
            return Execute("set hostednetwork"
                         + ParameterUtil.Optional(nameof(mode), mode, "allow", "disallow")
                         + ParameterUtil.Optional(nameof(mode), ssid, true)
                         + ParameterUtil.Optional(nameof(mode), key)
                         + ParameterUtil.Optional(nameof(mode), hostedNetworkKeyUsage),
                           out outputs);
        }

        public bool SetProfileOrder(out string outputs,
                                    string name,
                                    string @interface,
                                    int priority)
        {
            return Execute("set profileorder"
                         + ParameterUtil.Required(nameof(name), name, true)
                         + ParameterUtil.Required(nameof(@interface), @interface, true)
                         + ParameterUtil.Required(nameof(priority), priority),
                           out outputs);
        }

        public bool SetProfileParameter(out string outputs,
                                        string name,
                                        string @interface = null,
                                        string SSIDname = null,
                                        ProfileConnectionType profileConnectionType = null,
                                        bool? autoSwitch = null,
                                        ProfileConnectionMode profileConnectionMode = null,
                                        bool? nonBroadCast = null,
                                        ProfileRandomization profileRandomization = null,
                                        ProfileAuthentication profileAuthentication = null,
                                        ProfileEncryption profileEncryption = null,
                                        ProfileKeyType profileKeyType = null,
                                        int? keyIndex = null,
                                        string keyMaterial = null,
                                        bool? PMKCacheMode = null,
                                        int? PMKCacheSize = null,
                                        int? PMKCacheTTL = null,
                                        bool? preAuthMode = null,
                                        int? preAuthThrottle = null,
                                        bool? FIPS = null,
                                        bool? useOneX = null,
                                        ProfileAuthMode profileAuthMode = null,
                                        ProfileSsoMode profileSsoMode = null,
                                        int? maxDelay = null,
                                        bool? allowDialog = null,
                                        bool? userVLAN = null,
                                        int? heldPeriod = null,
                                        int? AuthPeriod = null,
                                        int? StartPeriod = null,
                                        int? maxStart = null,
                                        int? maxAuthFailures = null,
                                        bool? cacheUserData = null,
                                        ProfileCost profileCost = null)
        {
            return Execute("set profileparameter"
                         + ParameterUtil.Required(nameof(name), name, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(SSIDname), SSIDname, true)
                         + ParameterUtil.Optional(nameof(profileConnectionType), profileConnectionType)
                         + ParameterUtil.Optional(nameof(autoSwitch), autoSwitch, "yes", "no")
                         + ParameterUtil.Optional(nameof(profileRandomization), profileRandomization)
                         + ParameterUtil.Optional(nameof(profileAuthentication), profileAuthentication)
                         + ParameterUtil.Optional(nameof(profileEncryption), profileEncryption)
                         + ParameterUtil.Optional(nameof(profileKeyType), profileKeyType)
                         + ParameterUtil.Optional(nameof(keyIndex), keyIndex)
                         + ParameterUtil.Optional(nameof(keyMaterial), keyMaterial, true)
                         + ParameterUtil.Optional(nameof(PMKCacheMode), PMKCacheMode, "yes", "no")
                         + ParameterUtil.Optional(nameof(PMKCacheSize), PMKCacheSize)
                         + ParameterUtil.Optional(nameof(PMKCacheTTL), PMKCacheTTL)
                         + ParameterUtil.Optional(nameof(preAuthMode), preAuthMode, "yes", "no")
                         + ParameterUtil.Optional(nameof(preAuthThrottle), preAuthThrottle)
                         + ParameterUtil.Optional(nameof(FIPS), FIPS, "yes", "no")
                         + ParameterUtil.Optional(nameof(useOneX), useOneX, "yes", "no")
                         + ParameterUtil.Optional(nameof(profileAuthMode), profileAuthMode)
                         + ParameterUtil.Optional(nameof(profileSsoMode), profileSsoMode)
                         + ParameterUtil.Optional(nameof(maxDelay), maxDelay)
                         + ParameterUtil.Optional(nameof(allowDialog), allowDialog, "yes", "no")
                         + ParameterUtil.Optional(nameof(userVLAN), userVLAN, "yes", "no")
                         + ParameterUtil.Optional(nameof(heldPeriod), heldPeriod)
                         + ParameterUtil.Optional(nameof(AuthPeriod), AuthPeriod)
                         + ParameterUtil.Optional(nameof(StartPeriod), StartPeriod)
                         + ParameterUtil.Optional(nameof(maxStart), maxStart)
                         + ParameterUtil.Optional(nameof(maxAuthFailures), maxAuthFailures)
                         + ParameterUtil.Optional(nameof(cacheUserData), cacheUserData, "yes", "no")
                         + ParameterUtil.Optional(nameof(profileCost), profileCost),
                           out outputs);
        }

        public bool SetProfileType(out string outputs,
                                   string name,
                                   ProfileType profiletype,
                                   string @interface = null)
        {
            return Execute("set profiletype"
                         + ParameterUtil.Required(nameof(name), name, true)
                         + ParameterUtil.Required(nameof(profiletype), profiletype)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool SetRandomization(out string outputs,
                                     bool enabled,
                                     string @interface)
        {
            return Execute("set randomization"
                         + ParameterUtil.Required(nameof(enabled), enabled, "yes", "no")
                         + ParameterUtil.Required(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool SetTracing(out string outputs,
                               TracingMode tracingMode)
        {
            return Execute("set tracing"
                         + ParameterUtil.Required(nameof(tracingMode), tracingMode),
                           out outputs);
        }

        public bool ShowAll(out string outputs)
        {
            return Execute("show all",
                           out outputs);
        }

        public bool ShowAllowExplicitCreds(out string outputs)
        {
            return Execute("show allowexplicitcreds",
                           out outputs);
        }

        public bool ShowAutoConfig(out string outputs)
        {
            return Execute("show autoconfig",
                           out outputs);
        }

        public bool ShowBlockedNetworks(out string outputs)
        {
            return Execute("show blockednetworks",
                           out outputs);
        }

        public bool ShowCreateAllUserProfile(out string outputs)
        {
            return Execute("show createalluserprofile",
                           out outputs);
        }

        public bool ShowDrivers(out string outputs,
                                string @interface = null)
        {
            return Execute("show drivers"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true),
                           out outputs);
        }

        public bool ShowFilters(out string outputs,
                                FilterPermission filterPermission)
        {
            return Execute("show filters"
                         + ParameterUtil.Required(nameof(filterPermission), filterPermission),
                           out outputs);
        }

        public bool ShowHostedNetwork(out string outputs,
                                      ShowHostedNetworkSetting showHostedNetworkSetting = null)
        {
            return Execute("show hostednetwork"
                         + ParameterUtil.Optional(nameof(showHostedNetworkSetting), showHostedNetworkSetting),
                           out outputs);
        }

        public bool ShowInterfaces(out string outputs)
        {
            return Execute("show interfaces",
                           out outputs);
        }

        public bool ShowNetworks(out string outputs,
                                 string @interface = null,
                                 NetworkMode mode = null)
        {
            return Execute("show networks"
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(mode), mode),
                           out outputs);
        }

        public bool ShowOnlyUseGPProfilesForAllowedNetworks(out string outputs)
        {
            return Execute("show onlyUseGPProfilesforAllowedNetworks",
                           out outputs);
        }

        public bool ShowProfile(out string outputs,
                                string name = null,
                                string @interface = null,
                                string key = null)
        {
            return Execute("show profile"
                         + ParameterUtil.Optional(nameof(name), name, true)
                         + ParameterUtil.Optional(nameof(@interface), @interface, true)
                         + ParameterUtil.Optional(nameof(key), key),
                           out outputs);
        }

        public bool ShowRandomization(out string outputs)
        {
            return Execute("show randomization",
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

        public bool ShowWirelessCapabilities(out string outputs)
        {
            return Execute("show wirelesscapabilities",
                           out outputs);
        }

        public bool ShowWlanReport(out string outputs,
                                   string duration = null,
                                   string log = null,
                                   string logger = null)
        {
            return Execute("show wlanreport"
                         + ParameterUtil.Optional(nameof(duration), duration, true)
                         + ParameterUtil.Optional(nameof(log), log, true)
                         + ParameterUtil.Optional(nameof(logger), logger, true),
                           out outputs);
        }

        public bool StartHostedNetwork(out string outputs)
        {
            return Execute("start hostednetwork",
                           out outputs);
        }

        public bool StopHostedNetwork(out string outputs)
        {
            return Execute("stop hostednetwork",
                           out outputs);
        }
    }
}
