using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using FlashCrypto.Habbo.Utils;
using System.Windows.Forms;
using System.Threading;

namespace FlashCrypto.Habbo.Tcp
{
    public class ServerDatagram
    {
        private TcpProxy client;
        bool skipSend = false;

        public ServerDatagram(ref TcpProxy parent)
        {
            this.client = parent;
        }

        public void runPackets(string data)
        {
            try
            {
                string header = data.Substring(0, 2);
                string body = data.Substring(2);

                switch (header)
                {
                    #region Crypto Initialization

                    case "DU":
                        // Token
                        LemonEnvironment.token = body.Substring(0, body.Length - 3);

                        // A pretty shitty workaround for the banner.png timestamp thing - but it works!
                        skipSend = true;
                        this.client.Send(data);

                        // Init our padding with specialized token
                        LemonEnvironment.padding1 = new Crypto.PaddingGenerator(
                            int.Parse(
                            LemonEnvironment.token.Substring(
                            LemonEnvironment.token.Length - 4),
                            System.Globalization.NumberStyles.HexNumber),
                            65536);

                        // One for each instance 8- )
                        LemonEnvironment.padding2 = new Crypto.PaddingGenerator(
                            int.Parse(
                            LemonEnvironment.token.Substring(
                            LemonEnvironment.token.Length - 4),
                            System.Globalization.NumberStyles.HexNumber),
                            65536);

                        break;

                    case "@A":
                        // Server key
                        LemonEnvironment.serverKey = body.Substring(0, body.Length - 1);

                        // We have server key so sent it my haxswf
                        while (LemonEnvironment.decPublicKey == null || LemonEnvironment.encPublicKey == null) ;
                        LemonEnvironment.mainWnd.SendServerKey();
                        Thread.Sleep(600);

                        // Use our own key
                        data = "@A" + LemonEnvironment.decPublicKey + (char)1;

                        // Trickery :-)
                        while (LemonEnvironment.sharedKeyEnc == null) ;
                        LemonEnvironment.RC4E = new Crypto.MikeCrypto(HexEncoding.GetBytes(LemonEnvironment.sharedKeyEnc), LemonEnvironment.padding1);
                        
                        LemonEnvironment.cryptoActive = true;
                        LemonEnvironment.mainWnd.SetCryptoState(true);

                        break;

                    #endregion

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Forward the packet on
            if (skipSend)
            {
                while (!LemonEnvironment.proxiedBanner) ;
                LemonEnvironment.mainWnd.SendToken();
                skipSend = false;
                Thread.Sleep(600);
            }
            else
            {
                this.client.Send(data);
            }
        }
    }
}
