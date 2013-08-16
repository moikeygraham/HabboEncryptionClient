using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Fiddler;
using System.Net;
using System.Windows.Forms;

namespace FlashCrypto.Habbo.Proxy
{
    public class BannerProxy
    {
        public BannerProxy()
        {

        }

        public bool IsAttatched
        {
            get
            {
                if (FiddlerApplication.oProxy != null)
                {
                    return FiddlerApplication.oProxy.IsAttached;
                }
                else
                {
                    return false;
                }
            }
        }

        public void detatch()
        {
            if (IsAttatched)
            {
                FiddlerApplication.Shutdown();
            }
        }

        public void startup()
        {
            FiddlerApplication.AfterSessionComplete += delegate(Session http)
            {
                if (http.fullUrl.Contains("banner") && http.fullUrl.Contains("habbo"))
                {
                    // Download?
                    string token = http.fullUrl.Split('=')[1];

                    string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\banner.png";

                    http.SaveResponseBody(dir);
                    FiddlerApplication.Shutdown();

                    LemonEnvironment.proxiedBanner = true;
                }
            };

            FiddlerApplication.Prefs.SetBoolPref("fiddler.network.streaming.abortifclientaborts", true);
            FiddlerCoreStartupFlags oFlags = FiddlerCoreStartupFlags.Default;
            oFlags = (oFlags & ~FiddlerCoreStartupFlags.DecryptSSL);

            FiddlerApplication.Startup(12345, oFlags);
        }
    }
}
