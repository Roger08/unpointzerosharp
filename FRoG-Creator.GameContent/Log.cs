using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public static class Log
    {
        protected static List<string> messages = new List<string>();

        public static List<string> Messages
        {
            get { return messages; }
            set { messages = value; }
        }
    }
}
