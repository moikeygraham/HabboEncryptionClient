using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.IO;
using FlashCrypto.Habbo.Utils;

namespace FlashCrypto
{
    public partial class wndMain : Form
    {
        /* Delegate declarations */
        public delegate void _TextToControl(string text);
        public delegate void _BoolToControl(bool val);
        public delegate void _IntToControl(int val);
        public delegate void _HaxMovie();

        /* Delegate function declarations */
        public _BoolToControl SetServerConnected;
        public _BoolToControl SetClientConnected;
        public _BoolToControl SetCryptoState;

        public _TextToControl SetHabboID;
        public _TextToControl SetSSOTicket;
        public _TextToControl SetFlashVersion;

        public _TextToControl AddToServer;
        public _TextToControl AddToClient;

        public _IntToControl SetKbIn;
        public _IntToControl SetKbOut;

        public _HaxMovie SendToken;
        public _HaxMovie SendServerKey;
        public _HaxMovie SendClientKey;

        public wndMain()
        {
            InitializeComponent();

            #region Delegate thread-safe function initialization

            this.SetServerConnected = new _BoolToControl(this.ServerConnected);
            this.SetClientConnected = new _BoolToControl(this.ClientConnected);
            this.SetCryptoState = new _BoolToControl(this.CryptoActive);

            this.SetHabboID = new _TextToControl(this.HabboID);
            this.SetSSOTicket = new _TextToControl(this.SSOTicket);
            this.SetFlashVersion = new _TextToControl(this.FlashVersion);

            this.AddToServer = new _TextToControl(this.ServerPackets);
            this.AddToClient = new _TextToControl(this.ClientPackets);

            this.SetKbIn = new _IntToControl(this.KbIn);
            this.SetKbOut = new _IntToControl(this.KbOut);

            this.SendToken = new _HaxMovie(this.sendTokenToHax);
            this.SendServerKey = new _HaxMovie(this.sendServerKeyToHax);
            this.SendClientKey = new _HaxMovie(this.sendClientKeyToHax);

            LemonEnvironment.mainWnd = this;

            #endregion

            #region SWF hax trickery

            byte[] haxSwf = Properties.Resources.HaxSwf_protected;

            MemoryStream stm = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stm);
            writer.Write(8 + haxSwf.Length);
            writer.Write(0x55665566);
            writer.Write(haxSwf.Length);
            writer.Write(haxSwf);
            stm.Seek(0, SeekOrigin.Begin);
            this.haxMovie.OcxState = new AxHost.State(stm, 1, false, null);
            writer.Close();
            stm.Close();

            #endregion
        }

        #region Thread-safe form control functions

        private void KbIn(int val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetKbIn, val);
                }
                else
                {
                    this.lblIn.Text = val.ToString() + " k/b";
                }
            }
            catch { }
        }

        private void KbOut(int val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetKbOut, val);
                }
                else
                {
                    this.lblOut.Text = val.ToString() + " k/b";
                }
            }
            catch { }
        }

        private void ServerConnected(bool val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetServerConnected, val);
                }
                else
                {
                    // Logic
                    if (val)
                    {
                        this.lblServerConnected.Text = "connected";
                        this.lblServerConnected.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        this.lblServerConnected.Text = "disconnected";
                        this.lblServerConnected.ForeColor = Color.DarkRed;
                    }
                }
            }
            catch { }
        }

        private void ClientConnected(bool val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetClientConnected, val);
                }
                else
                {
                    // Logic
                    if (val)
                    {
                        this.lblClientConnected.Text = "connected";
                        this.lblClientConnected.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        this.lblClientConnected.Text = "disconnected";
                        this.lblClientConnected.ForeColor = Color.DarkRed;
                    }
                }
            }
            catch { }
        }

        private void CryptoActive(bool val)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetCryptoState, val);
                }
                else
                {
                    // Logic
                    if (val)
                    {
                        this.lblCrypto.Text = "on";
                    }
                    else
                    {
                        this.lblCrypto.Text = "off";
                    }
                }
            }
            catch { }
        }

        private void HabboID(string data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetHabboID, data);
                }
                else
                {
                    this.txtID.Text = data;
                }
            }
            catch { }
        }

        private void SSOTicket(string data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetSSOTicket, data);
                }
                else
                {
                    this.txtSSO.Text = data;
                }
            }
            catch { }
        }

        private void FlashVersion(string data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SetFlashVersion, data);
                }
                else
                {
                    this.txtSWFVersion.Text = data;
                }
            }
            catch { }
        }

        private void ServerPackets(string data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(AddToServer, data);
                }
                else
                {
                    this.txtServer.AppendText(data + "\r\n\r\n");
                }
            }
            catch { }
        }

        private void ClientPackets(string data)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(AddToClient, data);
                }
                else
                {
                    this.txtClient.AppendText(data + "\r\n\r\n");
                }
            }
            catch { }
        }

        #endregion

        #region Crypto SWF communication

        public void sendTokenToHax()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SendToken);
                }
                else
                {
                    //"<invoke name=\"addText\" returntype=\"xml\"><arguments><string>" + outTxt.Text + "</string></arguments></invoke>"
                    this.haxMovie.CallFunction("<invoke name=\"dataToken\" returntype=\"xml\"><arguments><string>" + LemonEnvironment.hotel + "#" + LemonEnvironment.token + "#" + LemonEnvironment.bannerDir + "</string></arguments></invoke>");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void sendServerKeyToHax()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SendServerKey);
                }
                else
                {
                    //"<invoke name=\"addText\" returntype=\"xml\"><arguments><string>" + outTxt.Text + "</string></arguments></invoke>"
                    this.haxMovie.CallFunction("<invoke name=\"serverKey\" returntype=\"xml\"><arguments><string>" + LemonEnvironment.serverKey + "</string></arguments></invoke>");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void sendClientKeyToHax()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(SendClientKey);
                }
                else
                {
                    //"<invoke name=\"addText\" returntype=\"xml\"><arguments><string>" + outTxt.Text + "</string></arguments></invoke>"
                    this.haxMovie.CallFunction("<invoke name=\"clientKey\" returntype=\"xml\"><arguments><string>" + LemonEnvironment.clientKey + "</string></arguments></invoke>");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void haxMovie_FlashCall(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEvent e)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(e.request);

                XmlAttributeCollection attributes = document.FirstChild.Attributes;
                String command = attributes.Item(0).InnerText;
                XmlNodeList param = document.GetElementsByTagName("arguments");

                switch (command)
                {
                    case "toSend":
                        // To send encryption keys!
                        LemonEnvironment.encPublicKey = param[0].FirstChild.InnerText;
                        Debug.WriteLine("encPublicKey == " + LemonEnvironment.encPublicKey);

                        LemonEnvironment.decPublicKey = param[0].ChildNodes[1].InnerText;
                        Debug.WriteLine("decPublicKey == " + LemonEnvironment.decPublicKey);
                        break;

                    case "encKey":
                        // Encryption (encipher) shared key
                        LemonEnvironment.sharedKeyEnc = param[0].FirstChild.InnerText;
                        Debug.WriteLine("sharedKeyEnc == " + LemonEnvironment.encPublicKey);
                        break;

                    case "decKey":
                        // Encryption (decipher) shared key
                        LemonEnvironment.sharedKeyDec = param[0].FirstChild.InnerText;
                        Debug.WriteLine("sharedKeyDec == " + LemonEnvironment.encPublicKey);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        #endregion

        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stayOnTopToolStripMenuItem.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LemonEnvironment.proxy.IsAttatched)
                LemonEnvironment.proxy.detatch();

            Environment.Exit(0);
        }

        private void wndMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdSendServer_Click(object sender, EventArgs e)
        {
            LemonEnvironment.tcp.GetMainConnection.Server.Send("@" + MikeUtils.encodeB64(this.txtSend.Text) + this.txtSend.Text);
        }

        private void cmdSendClient_Click(object sender, EventArgs e)
        {
            LemonEnvironment.tcp.GetMainConnection.Send(this.txtSend.Text);
        }

        private void cmdEncoders_Click(object sender, EventArgs e)
        {
            if (LemonEnvironment.encodersWnd == null)
            {
                LemonEnvironment.encodersWnd = new wndEncoders();
            }

            LemonEnvironment.encodersWnd.Show();
        }

        private void cmdDonate_Click(object sender, EventArgs e)
        {
            Process browser = new Process();
            browser.StartInfo.UseShellExecute = true;
            browser.StartInfo.FileName = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=NVVWHXRDUZ9LC";
            browser.Start();
        }

        private void cmdClientClear_Click(object sender, EventArgs e)
        {
            this.txtClient.Text = "";
        }

        private void cmdServerClear_Click(object sender, EventArgs e)
        {
            this.txtServer.Text = "";
        }

        private void wndMain_Load(object sender, EventArgs e)
        {

        }

        private void diagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new wndDiagnostics().Show();
        }
    }
}
