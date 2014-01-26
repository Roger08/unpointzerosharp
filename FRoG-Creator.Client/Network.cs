using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace FRoG_Creator.Client
{
    internal class Network
    {
        const int PORT = 4000;

        internal enum ConnectStatus
        {
            Connecting,
            Online,
            Offline,
        }

        private Dictionary<byte, Action<byte, byte[]>> answerHandler;
        private TcpClient tcpClient;
        private NetworkStream networkStream;


        ConnectStatus serverStatus = ConnectStatus.Connecting;

        internal Network()
        {
            try
            {
                tcpClient = new TcpClient("localhost", PORT);
                serverStatus = ConnectStatus.Online;
                networkStream = tcpClient.GetStream();
            }
            catch
            {
                serverStatus = ConnectStatus.Offline;
            }
        }

        internal Dictionary<byte, Action<byte, byte[]>> AnswerHandler
        {
            get { return answerHandler; }
        }

        internal NetworkStream NetworkStream
        {
            get { return networkStream; }
        }

        internal ConnectStatus ServerStatus
        {
            get { return serverStatus; }
        }

    }
}
