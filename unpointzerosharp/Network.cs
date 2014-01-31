using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace unpointzerosharp
{
    internal class Network
    {
        const int PORT = 4000;

        private TcpListener tcpListener;
        private Thread listenThread;
        private Dictionary<byte, Action<byte, byte[]>> answerHandler;
        private List<Player> players;

        internal Network()
        {
            InitializeAnswers();
            players = new List<Player>();
            tcpListener = new TcpListener(IPAddress.Any, PORT);
            listenThread = new Thread(new ThreadStart(ListenClients));
            listenThread.Start();
        }

        internal Dictionary<byte, Action<byte, byte[]>> AnswerHandler
        {
            get { return answerHandler; }
        }

        private void InitializeAnswers()
        {
            answerHandler = new Dictionary<byte, Action<byte, byte[]>>();
            answerHandler.Add((byte)Response.AnswerMethods.Login, Response.Login);
            answerHandler.Add((byte)Response.AnswerMethods.Register, Response.Register);
            answerHandler.Add((byte)Response.AnswerMethods.NewCharacter, Response.NewCharacter);
        }

        private void HandleClient(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            Console.WriteLine("Connexion acceptée ...");

            NetworkStream networkStream = tcpClient.GetStream();

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

        private void ListenClients()
        {
            tcpListener.Start();

            while (true)
            {
                Console.WriteLine("En attente de connexion ...");
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                players.Add(new Player(tcpClient));

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(tcpClient);
            }
        }

        private void ReadStream(NetworkStream networkStream, byte[] message)
        {
            if (networkStream.Read(message, 0, 1) != 0)
            {
                if (Program.DEBUG)
                {
                    Console.WriteLine("Réception d'un paquet \"" + (Response.AnswerMethods)message[0] + "\".");
                }

            }
            else
            {
                Console.WriteLine("Déconnexion d'un client ...");
            }
        }

    }
}
