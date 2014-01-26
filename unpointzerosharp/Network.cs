using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace unpointzerosharp
{
    public class Network
    {
        public const int PORT = 4000;

        private TcpListener tcpListener;
        private Thread listenThread;
        private Dictionary<byte, Action<byte, byte[]>> answerHandler;

        public Network()
        {
            InitializeAnswers();
            tcpListener = new TcpListener(IPAddress.Any, PORT);
            listenThread = new Thread(new ThreadStart(ListenClients));
            listenThread.Start();
        }

        private void ListenClients()
        {
            tcpListener.Start();

            while (true)
            {
                Console.WriteLine("En attente de connexion ...");
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(tcpClient);
            }
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

        private void ReadStream(NetworkStream networkStream, byte[] message)
        {
            int index = 0;
            index = networkStream.Read(message, index, 1);

            if (index == 0)
            {
                Console.WriteLine("Déconnexion d'un client ...");
            }
            else
            {
                if (Program.DEBUG)
                    Console.WriteLine("Réception d'un paquet \"" + (Answers.AnswerMethods)message[0] + "\".");
            }
        }

        private void InitializeAnswers()
        {
            answerHandler = new Dictionary<byte, Action<byte, byte[]>>();
            answerHandler.Add((byte)Answers.AnswerMethods.Login, Answers.Login);
            answerHandler.Add((byte)Answers.AnswerMethods.Register, Answers.Register);
            answerHandler.Add((byte)Answers.AnswerMethods.NewCharacter, Answers.NewCharacter);
        }

    }
}
