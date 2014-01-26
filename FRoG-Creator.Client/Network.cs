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

                byte[] message = new byte[4096];

                while (true)
                {
                    try
                    {
                        ReadStream(networkStream, message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erreur lors de la réception d'un paquet ... Erreur : " + e.Message);
                    }
                }
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

        private void ReadStream(NetworkStream networkStream, byte[] message)
        {
            int index = 0;
            index = networkStream.Read(message, index, 1);

            if (index != 0)
            {
                //A faire : Conversion de la queue du paquet en string et réception des paquets
            }
        }

    }
}
