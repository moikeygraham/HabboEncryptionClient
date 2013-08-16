using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlashCrypto.Habbo.Tcp
{
    public class TcpServer : IDisposable
    {
        private TcpProxy clientInstance;
        private ServerDatagram datagram;

        private byte[] serverBuffer;
        private Socket sockServer;

        int throughPut = 0;
        int id = 0;

        #region Properties

        public TcpProxy Client
        {
            get
            {
                return this.clientInstance;
            }
        }

        #endregion

        public TcpServer(TcpProxy instance, int id)
        {
            this.id = id;
            this.clientInstance = instance;
            this.datagram = new ServerDatagram(ref instance);
        }

        public void Connect()
        {
            try
            {
                this.serverBuffer = new byte[1024];

                this.sockServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.sockServer.Connect(new IPEndPoint(IPAddress.Parse(Dns.GetHostAddresses(LemonEnvironment.props.InfoHost)[0].ToString()), LemonEnvironment.props.InfoPort));

                LemonEnvironment.mainWnd.SetServerConnected(true);

                this.startRecieve();
            }
            catch (Exception ex)
            {
                // D.c
                if (this.id == 0) { return; }
                Debug.WriteLine("Error -> " + ex.Data);
                this.Dispose();
            }
        }

        private void startRecieve()
        {
            if (this.sockServer != null)
            {
                try
                {
                    this.sockServer.BeginReceive(this.serverBuffer, 0, this.serverBuffer.Length, SocketFlags.None, new AsyncCallback(this.OnRecieve), null);
                }
                catch (Exception ex)
                {
                    // D.c
                    if (this.id == 0) { return; }
                    Debug.WriteLine("Error -> " + ex.Data);
                    this.Dispose();
                }
            }
        }

        private void OnRecieve(IAsyncResult asyn)
        {
            int rTx = 0;
            string data = null;

            try
            {
                rTx = this.sockServer.EndReceive(asyn);
            }
            catch (Exception ex)
            {
                if (this.id == 0) { return; }
                Debug.WriteLine("Error -> " + ex.Data);
                this.Dispose();
            }

            if (rTx < 1)
            {
                if (this.id == 0) { return; }
                this.Dispose();
                return; // dc
            }
            else
            {
                data = Encoding.UTF8.GetString(serverBuffer, 0, rTx);

                throughPut += (int)Math.Round((decimal)rTx / 1024 * 100000) / 100000;

                LemonEnvironment.mainWnd.SetKbIn(throughPut);

               this.datagram.runPackets(data);  // To work as normal packetlogger (no crypto), comment this line out

                //this.clientInstance.Send(data); // and un-comment this line

                this.startRecieve();
            }
        }

        #region Send Functions

        public void Send(string data)
        {
            if (!LemonEnvironment.mainWnd.chkClientPause.Checked)
                LemonEnvironment.mainWnd.AddToClient(data);

            if (LemonEnvironment.cryptoActive)
                data = LemonEnvironment.RC4E.encipher(data);

            this.Send(Encoding.UTF8.GetBytes(data));
        }

        public void Send(byte[] data)
        {
            try
            {
                this.sockServer.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(this.OnDataSent), null);
            }
            catch (Exception ex)
            {
                if (this.id == 0) { return; }
                Debug.WriteLine("Error -> " + ex);
                this.Dispose();
            }
        }

        private void OnDataSent(IAsyncResult asyn)
        {
            try
            {
                this.sockServer.EndSend(asyn);
            }
            catch (Exception ex)
            {
                if (this.id == 0) { return; }
                Debug.WriteLine("Error -> " + ex);
                this.Dispose();
            }
        }

        public void Dispose()
        {
            if (this.sockServer != null)
            {
                this.sockServer.Close();
                this.sockServer = null;

                // Notify a Disconnect.
                MessageBox.Show("Server disconnected!", "Disconnection!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        #endregion
    }
}
