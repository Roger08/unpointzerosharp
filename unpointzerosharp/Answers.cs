using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unpointzerosharp
{
    internal static class Answers
    {
        const char SEP = (char)0;
        internal enum AnswerMethods {
            Login,
            Register,
            NewCharacter,
        };

        public static void Login(byte index, string data)
        {
            string[] dataContent = data.Split(SEP);

            //if (dataContent[1]
        }

        public static void Register(byte index, string data)
        {
            //A faire
        }

        public static void NewCharacter(byte index, string data)
        {
            //A faire
        }
    }
}
