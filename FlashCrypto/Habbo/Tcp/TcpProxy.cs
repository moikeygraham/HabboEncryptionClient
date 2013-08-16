using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlashCrypto.Habbo.Tcp
{
    public class TcpProxy : IDisposable
    {
        private Socket sockClient;
        private byte[] clientBuffer;

        private ClientDatagram datagram;

        private TcpServer server;

        int throughPut = 0;
        int id = 0;

        #region Properties

        public TcpServer Server
        {
            get
            {
                return this.server;
            }
        }

        #endregion

        public TcpProxy(Socket worker, int id)
        {
            this.id = id;

            this.sockClient = worker;
            this.clientBuffer = new byte[1024];

            this.server = new TcpServer(this, id);
            this.server.Connect();

            this.datagram = new ClientDatagram(ref server);

            this.startRecieve();
        }

        private void startRecieve()
        {
            this.sockClient.BeginReceive(this.clientBuffer, 0, this.clientBuffer.Length, SocketFlags.None, new AsyncCallback(this.OnRecieve), null);
        }

        private void OnRecieve(IAsyncResult asyn)
        {
            int rTx = 0;
            string data = null;

            try
            {
                rTx = this.sockClient.EndReceive(asyn);
            }
            catch (Exception ex)
            {
                if (this.id == 0) { return; }

                Debug.WriteLine("Error -> " + ex.Data);
                this.Dispose();
            }

            if (rTx < 1)
            {
                // d/c
                if (this.id == 0) { return; }
                this.Dispose();
                return;
            }
            else
            {
                data = Encoding.UTF8.GetString(clientBuffer, 0, rTx);

                throughPut += (int)Math.Round((decimal)rTx / 1024 * 100000) / 100000;

                LemonEnvironment.mainWnd.SetKbOut(throughPut);

                this.datagram.runPackets(data);     // To work as normal packetlogger, comment this line out
                //this.server.Send(data);             // and uncomment this line

                this.startRecieve();
            }
        }

        #region Send functions

        public void Send(string data)
        {
            if (!LemonEnvironment.mainWnd.chkServerPause.Checked)
                LemonEnvironment.mainWnd.AddToServer(data);

            this.Send(Encoding.UTF8.GetBytes(data)); ;
        }

        public void Send(byte[] data)
        {
            try
            {
                this.sockClient.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(this.OnDataSent), null);
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
                this.sockClient.EndSend(asyn);
            }
            catch (Exception ex)
            {
                if (this.id == 0) { return; }
                Debug.WriteLine("Error -> " + ex);
                this.Dispose();
            }
        }

        #endregion

        public void Dispose()
        {
            if (this.sockClient != null)
            {
                this.sockClient.Close();
                this.sockClient = null;

                MessageBox.Show("Client disconnected!", "Disconnection!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (this.server != null)
            {
                this.server.Dispose();
                this.server = null;
            }
        }
    }
}
