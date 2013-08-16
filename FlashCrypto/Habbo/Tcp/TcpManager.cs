using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace FlashCrypto.Habbo.Tcp
{
    public class TcpManager
    {
        private List<TcpProxy> sockets;
        private Socket tmpSocket;

        private int sockID = 0;

        public TcpProxy GetMainConnection
        {
            get
            {
                return this.sockets[1];
            }
        }

        public void init()
        {
            sockets = new List<TcpProxy>();
            tmpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tmpSocket.Bind(new IPEndPoint(IPAddress.Loopback, LemonEnvironment.props.InfoPort));
            tmpSocket.Listen(3);

            startAccept();
        }

        private void startAccept()
        {
            tmpSocket.BeginAccept(new AsyncCallback(NewConnection), null);
        }

        private void NewConnection(IAsyncResult asyn)
        {
            Socket worker = null;

            try
            {
                worker = tmpSocket.EndAccept(asyn);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error -> " + ex.Data);
            }

            if (worker != null)
            {
                LemonEnvironment.mainWnd.SetClientConnected(true);

                sockets.Add(new TcpProxy(worker, sockID));
                this.sockID++;

                startAccept();
            }
        }
    }
}
