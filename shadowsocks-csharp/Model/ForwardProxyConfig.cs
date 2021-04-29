using System;

namespace Shadowsocks.Model
{
    [Serializable]
    public class ForwardProxyConfig
    {
        public const int PROXY_SOCKS5 = 0;
        public const int PROXY_HTTP = 1;

        public const int MaxProxyTimeoutSec = 10;
        private const int DefaultProxyTimeoutSec = 3;

        public bool useProxy;
        public int proxyType;
        public string proxyServer;
        public int proxyPort;
        public int proxyTimeout;
        public bool useAuth;
        public string authUser;
        public string authPwd;

        public string proxyIgnoreDomains;
        public string proxyIgnoreDomainsExtra;
        public string proxyIgnoreDomainsExtra1;
        public string proxyIgnoreDomainsExtra2;
        public string proxyIgnoreDomainsExtra3;
        public string proxyIgnoreDomainsExtra4;
        public string proxyIgnoreDomainsExtra5;

        public ForwardProxyConfig()
        {
            useProxy = false;
            proxyType = PROXY_SOCKS5;
            proxyServer = "";
            proxyPort = 0;
            proxyTimeout = DefaultProxyTimeoutSec;
            useAuth = false;
            authUser = "";
            authPwd = "";

            proxyIgnoreDomains = "";
            proxyIgnoreDomainsExtra = "";
            proxyIgnoreDomainsExtra1 = "";
            proxyIgnoreDomainsExtra2 = "";
            proxyIgnoreDomainsExtra3 = "";
            proxyIgnoreDomainsExtra4 = "";
            proxyIgnoreDomainsExtra5 = "";
        }

        public void CheckConfig()
        {
            if (proxyType < PROXY_SOCKS5 || proxyType > PROXY_HTTP)
            {
                proxyType = PROXY_SOCKS5;
            }
        }
    }
}
