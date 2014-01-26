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
            connected,
            inGame,
        }

        private Socket socket;
        private Thread thread;
        private string ip;
        private ClientStatus status;

        internal Player(Socket Sock, Thread Thread)
        {
            socket = Sock;
            thread = Thread;
            //ip = ???

            status = ClientStatus.connected;
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
