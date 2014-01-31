using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace unpointzerosharp
{
    internal class Player
    {
        internal enum ClientStatus
        {
            CONNECTED,
            IN_GAME,
        }

        private TcpClient tcpClient;
        private Thread thread;
        private string ip;
        private ClientStatus status;

        internal Player(TcpClient TcpClient)
        {
            tcpClient = TcpClient;
            ip = tcpClient.Client.RemoteEndPoint.ToString();
            status = ClientStatus.CONNECTED;
        }

        internal string Ip
        {
            get { return ip; }
        }

        internal ClientStatus Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
