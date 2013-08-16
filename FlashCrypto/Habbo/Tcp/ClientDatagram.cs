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
    public class ClientDatagram
    {
        private TcpServer server;

        private string buffer = "";
        private bool checkedHeader = false;

        public ClientDatagram(ref TcpServer child)
        {
            this.server = child;
        }

        public void runPackets(string data)
        {
            string header = null;
            string body = null;

            int tMsgLength = 0;

            this.buffer += data;

            if (LemonEnvironment.cryptoActive)
            {
                // Wait for RC4D to init
                while (LemonEnvironment.RC4D == null) ;

                // logic
                while (buffer.Length >= 6)
                {
                    if (buffer.Length >= 6 && this.checkedHeader == false)
                    {
                        if (buffer.Substring(0, 3) == "@AQ") { return; }    // Cryptofix - once again really poor fix here

                        header = LemonEnvironment.RC4D.decipherHeader(buffer.Substring(0, 6));

                        this.buffer = this.buffer.Substring(6);
                        this.checkedHeader = true;

                        // check the length
                        int tByte1 = (int)header[2] & 63;
                        int tByte2 = (int)header[1] & 63;
                        int tByte3 = (int)header[0] & 63;

                        // final calculation of the length
                        tMsgLength = (tByte2 * 64) | tByte1;
                        tMsgLength = ((tByte3 * 64) * 64) | tMsgLength;
                    }

                    if (buffer.Length >= tMsgLength && checkedHeader == true)
                    {
                        body = LemonEnvironment.RC4D.decipherBody(buffer.Substring(0, tMsgLength));

                        this.buffer = this.buffer.Substring(tMsgLength);
                        this.checkedHeader = false;

                        tMsgLength = 0;

                        data = header + body;

                        header = "";
                        body = "";
                    }
                    else if (buffer.Length < tMsgLength && this.checkedHeader == true)
                    {
                        return;
                    }
                }
            }
            else
            {
                buffer = "";
            }

            protocol(data);
        }

        private void protocol(string data)
        {
            try
            {
                string header = data.Substring(1, 2);
                string body = data.Substring(2);

                switch (header)
                {
                    #region Crypto

                    case "AQ":
                    case "AP":
                        if (LemonEnvironment.cryptoActive) { return; }

                        // Client key
                        LemonEnvironment.clientKey = body.Substring(5);

                        // Make sure we have the keys from the haxswf - otherwise we'll get a null ref
                        while (LemonEnvironment.decPublicKey == null || LemonEnvironment.encPublicKey == null) ;
                        
                        // Send the client key
                        LemonEnvironment.mainWnd.SendClientKey();
                        Thread.Sleep(600);

                        // send our own key
                        data = "_R" + MikeUtils.encodeB64(LemonEnvironment.encPublicKey) + LemonEnvironment.encPublicKey;
                        data = "@" + MikeUtils.encodeB64(data) + data;

                        // Once again, make sure we've got a key to init decryption with 
                        // otherwise we'll get a null ref
                        while (LemonEnvironment.sharedKeyDec == null) ;
                        LemonEnvironment.RC4D = new Crypto.MikeCrypto(HexEncoding.GetBytes(LemonEnvironment.sharedKeyDec), LemonEnvironment.padding2);
                        
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

            server.Send(data);
        }
    }
}
