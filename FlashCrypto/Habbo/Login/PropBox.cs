using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashCrypto.Habbo.Login
{
    public class PropBox
    {
        private string _infoHost = null;
        private int _infoPort = 0;

        private string _dcr = null;
        private string _externalVars = null;

        private string _ssoTicket = null;

        public string InfoHost
        {
            get
            {
                return this._infoHost;
            }
            set
            {
                this._infoHost = value;
            }
        }

        public int InfoPort
        {
            get
            {
                return this._infoPort;
            }
            set
            {
                this._infoPort = value;
            }
        }

        public string FlashUrl
        {
            get
            {
                return this._dcr;
            }
            set
            {
                this._dcr = value;
            }
        }

        public string ExternalVars
        {
            get
            {
                return this._externalVars;
            }
            set
            {
                this._externalVars = value;
            }
        }

        public string SSOTicket
        {
            get
            {
                return this._ssoTicket;
            }
            set
            {
                this._ssoTicket = value;
            }
        }
    }
}
