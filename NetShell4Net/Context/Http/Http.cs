namespace Monicais.NetShell4Net.Context.Http
{
    public sealed class Http : AbstractCommand
    {
        public Http(ICommand parent) : base("http", parent) { }

        public bool AddCacheParam(out string outputs,
                                  CacheParamType type,
                                  ulong value)
        {
            return Execute("add cacheparam"
                         + ParameterUtil.Required(nameof(type), type)
                         + ParameterUtil.Required(nameof(value), value),
                           out outputs);
        }

        public bool AddIpListen(out string outputs,
                                string ipaddress)
        {
            return Execute("add iplisten"
                         + ParameterUtil.Required(nameof(ipaddress), ipaddress),
                           out outputs);
        }

        public bool AddSetting(out string outputs,
                               SettingType settingtype,
                               ulong value)
        {
            return Execute("add setting"
                         + ParameterUtil.Required(nameof(settingtype), settingtype)
                         + ParameterUtil.Required(nameof(value), value),
                           out outputs);
        }

        public bool AddSslCert(out string outputs,
                               Port port,
                               string appid,
                               string certhash = null,
                               string certstorename = null,
                               bool? verifyclientcertrevocation = null,
                               bool? verifyrevocationwithcachedclientcertonly = null,
                               bool? usagecheck = null,
                               uint? revocationfreshnesstime = null,
                               uint? urlretrievaltimeout = null,
                               string sslctlidentifier = null,
                               string sslctlstorename = null,
                               bool? dsmapperusage = null,
                               bool? clientcertnegotiation = null,
                               bool? reject = null,
                               bool? disablehttp2 = null,
                               bool? disablequic = null,
                               bool? disabletls13 = null,
                               bool? disableocspstapling = null)
        {
            return Execute("add sslcert"
                         + ParameterUtil.Required(port.TypeName, port)
                         + ParameterUtil.Required(nameof(appid), appid)
                         + ParameterUtil.Optional(nameof(certhash), certhash)
                         + ParameterUtil.Optional(nameof(certstorename), certstorename)
                         + ParameterUtil.Optional(nameof(verifyclientcertrevocation), verifyclientcertrevocation, "enable", "disable")
                         + ParameterUtil.Optional(nameof(verifyrevocationwithcachedclientcertonly),
                                                  verifyrevocationwithcachedclientcertonly,
                                                  "enable", "disable")
                         + ParameterUtil.Optional(nameof(usagecheck), usagecheck, "enable", "disable")
                         + ParameterUtil.Optional(nameof(revocationfreshnesstime), revocationfreshnesstime)
                         + ParameterUtil.Optional(nameof(urlretrievaltimeout), urlretrievaltimeout)
                         + ParameterUtil.Optional(nameof(sslctlidentifier), sslctlidentifier)
                         + ParameterUtil.Optional(nameof(sslctlstorename), sslctlstorename)
                         + ParameterUtil.Optional(nameof(dsmapperusage), dsmapperusage, "enable", "disable")
                         + ParameterUtil.Optional(nameof(clientcertnegotiation), clientcertnegotiation, "enable", "disable")
                         + ParameterUtil.Optional(nameof(reject), reject, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disablehttp2), disablehttp2, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disablequic), disablequic, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disabletls13), disabletls13, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disableocspstapling), disableocspstapling, "enable", "disable"),
                           out outputs);
        }

        public bool AddTimeout(out string outputs,
                               TimeoutType timeouttype,
                               ushort value)
        {
            return Execute("add timeout"
                         + ParameterUtil.Required(nameof(timeouttype), timeouttype)
                         + ParameterUtil.Required(nameof(value), value),
                           out outputs);
        }

        public bool AddUrlAcl(out string outputs,
                              string url,
                              string user = null,
                              bool? listen = null,
                              bool? @delegate = null,
                              string sddl = null)
        {
            return Execute("add urlacl"
                         + ParameterUtil.Required(nameof(url), url)
                         + ParameterUtil.Optional(nameof(user), user)
                         + ParameterUtil.Optional(nameof(listen), listen, "yes", "no")
                         + ParameterUtil.Optional(nameof(@delegate), @delegate, "yes", "no")
                         + ParameterUtil.Optional(nameof(sddl), sddl),
                           out outputs);
        }

        public bool DeleteCache(out string outputs,
                                string url,
                                bool? recursive = null)
        {
            return Execute("delete cache"
                         + ParameterUtil.Required(nameof(url), url)
                         + ParameterUtil.Optional(nameof(recursive), recursive, "yes", "no"),
                           out outputs);
        }

        public bool DeleteIpListen(out string outputs,
                                   string ipaddress)
        {
            return Execute("delete iplisten"
                         + ParameterUtil.Required(nameof(ipaddress), ipaddress),
                           out outputs);
        }

        public bool DeleteSetting(out string outputs,
                                  SettingType settingtype)
        {
            return Execute("delete setting"
                         + ParameterUtil.Required(nameof(settingtype), settingtype),
                           out outputs);
        }

        public bool DeleteSslCert(out string outputs,
                                  Port port)
        {
            return Execute("delete sslcert"
                         + ParameterUtil.Required(port.TypeName, port),
                           out outputs);
        }

        public bool DeleteTimeout(out string outputs,
                                  TimeoutType timeouttype)
        {
            return Execute("delete timeout"
                         + ParameterUtil.Required(nameof(timeouttype), timeouttype),
                           out outputs);
        }

        public bool DeleteUrlAcl(out string outputs,
                                 string url)
        {
            return Execute("delete urlacl"
                         + ParameterUtil.Required(nameof(url), url),
                           out outputs);
        }

        public bool FlushLogBuffer(out string outputs)
        {
            return Execute("flush logbuffer",
                           out outputs);
        }

        public bool ShowCacheParam(out string outputs)
        {
            return Execute("show cacheparam",
                           out outputs);
        }

        public bool ShowCacheState(out string outputs,
                                   string url = null)
        {
            return Execute("show cachestate"
                         + ParameterUtil.Optional(nameof(url), url),
                           out outputs);
        }

        public bool ShowIpListen(out string outputs)
        {
            return Execute("show iplisten",
                           out outputs);
        }

        public bool ShowServiceState(out string outputs,
                                     ServiceStateView view = null,
                                     bool? verbose = null)
        {
            return Execute("show servicestate"
                         + ParameterUtil.Optional(nameof(view), view, true)
                         + ParameterUtil.Optional(nameof(verbose), verbose, "yes", "no"),
                           out outputs);
        }

        public bool ShowSetting(out string outputs)
        {
            return Execute("show setting",
                           out outputs);
        }

        public bool ShowSslCert(out string outputs,
                                Port port)
        {
            return Execute("show sslcert"
                         + ParameterUtil.Required(port.TypeName, port),
                           out outputs);
        }

        public bool ShowTimeout(out string outputs)
        {
            return Execute("show timeout",
                           out outputs);
        }

        public bool ShowUrlAcl(out string outputs,
                               string url)
        {
            return Execute("show urlacl"
                         + ParameterUtil.Required(nameof(url), url),
                           out outputs);
        }

        public bool UpdateSslCert(out string outputs,
                                  Port port,
                                  string appid,
                                  string certhash = null,
                                  string certstorename = null,
                                  bool? verifyclientcertrevocation = null,
                                  bool? verifyrevocationwithcachedclientcertonly = null,
                                  bool? usagecheck = null,
                                  uint? revocationfreshnesstime = null,
                                  uint? urlretrievaltimeout = null,
                                  string sslctlidentifier = null,
                                  string sslctlstorename = null,
                                  bool? dsmapperusage = null,
                                  bool? clientcertnegotiation = null,
                                  bool? reject = null,
                                  bool? disablehttp2 = null,
                                  bool? disablequic = null,
                                  bool? disabletls13 = null,
                                  bool? disableocspstapling = null)
        {
            return Execute("update sslcert"
                         + ParameterUtil.Required(port.TypeName, port)
                         + ParameterUtil.Required(nameof(appid), appid)
                         + ParameterUtil.Optional(nameof(certhash), certhash)
                         + ParameterUtil.Optional(nameof(certstorename), certstorename)
                         + ParameterUtil.Optional(nameof(verifyclientcertrevocation), verifyclientcertrevocation, "enable", "disable")
                         + ParameterUtil.Optional(nameof(verifyrevocationwithcachedclientcertonly),
                                                  verifyrevocationwithcachedclientcertonly,
                                                  "enable", "disable")
                         + ParameterUtil.Optional(nameof(usagecheck), usagecheck, "enable", "disable")
                         + ParameterUtil.Optional(nameof(revocationfreshnesstime), revocationfreshnesstime)
                         + ParameterUtil.Optional(nameof(urlretrievaltimeout), urlretrievaltimeout)
                         + ParameterUtil.Optional(nameof(sslctlidentifier), sslctlidentifier)
                         + ParameterUtil.Optional(nameof(sslctlstorename), sslctlstorename)
                         + ParameterUtil.Optional(nameof(dsmapperusage), dsmapperusage, "enable", "disable")
                         + ParameterUtil.Optional(nameof(clientcertnegotiation), clientcertnegotiation, "enable", "disable")
                         + ParameterUtil.Optional(nameof(reject), reject, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disablehttp2), disablehttp2, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disablequic), disablequic, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disabletls13), disabletls13, "enable", "disable")
                         + ParameterUtil.Optional(nameof(disableocspstapling), disableocspstapling, "enable", "disable"),
                           out outputs);
        }
    }
}
