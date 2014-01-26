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
        private Socket socket;
        private Thread thread;
        string ip;
        byte status;

        private enum clientStatus
        { 
            connected,
            inGame,
        }

        internal Player(Socket Sock, Thread Thread)
        {
            socket = Sock;
            thread = Thread;

            status = (byte)clientStatus.connected;
        }
    }
}
