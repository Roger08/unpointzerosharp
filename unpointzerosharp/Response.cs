using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace unpointzerosharp
{
    internal static class Response
    {
        const char SEP = (char)0;
        internal enum AnswerMethods {
            Login,
            Register,
            NewCharacter,
        };

        internal static void Login(byte index, byte[] data)
        {
            List<string> stringParams = new List<string>();

            int i = 1;
            while (data[i] > 0)
            {
                byte stringLength = data[i];
                i++;
                byte[] parameter = new byte[stringLength];
                Array.Copy(data, parameter, stringLength);
                stringParams.Add(ASCIIEncoding.UTF8.GetString(parameter));
                i += stringLength;
            }

            if (stringParams[0].Length >= 3 && stringParams[1].Length >= 5)
            {
                if (File.Exists("Comptes/" + stringParams[0].ToLower() + ".fcj"))
                {
                    //Gérer les comptes et les personnages avant de continuer
                }
                else
                {
                    //Gérer l'envoie de paquets avant de continuer
                }
            }
        }

        internal static void Register(byte index, byte[] data)
        {
            List<string> stringParams = new List<string>();

            int i = 1;
            while (data[i] > 0)
            {
                byte stringLength = data[i];
                i++;
                byte[] parameter = new byte[stringLength];
                Array.Copy(data, parameter, stringLength);
                stringParams.Add(ASCIIEncoding.UTF8.GetString(parameter));
                i += stringLength;
            }

            if (stringParams[0].Length >= 3 && stringParams[1].Length >= 5)
            {
                if (!File.Exists("Comptes/" + stringParams[0].ToLower() + ".fcj"))
                {
                    //Gérer les comptes et les personnages avant de continuer
                    Console.WriteLine("Création du compte \"" + stringParams[0] + "\" en cours");
                }
                else
                {
                    //Gérer l'envoie de paquets avant de continuer
                }
            }
        }

        internal static void NewCharacter(byte index, byte[] data)
        {
            List<string> stringParams = new List<string>();

            int i = 1;
            while (data[i] > 0)
            {
                byte stringLength = data[i];
                i++;
                byte[] parameter = new byte[stringLength];
                Array.Copy(data, parameter, stringLength);
                stringParams.Add(ASCIIEncoding.UTF8.GetString(parameter));
                i += stringLength;
            }

            if (stringParams[1].Length >= 3)
            {
                //Gérer les comptes et les personnages avant de continuer
            }
        }
    }
}
