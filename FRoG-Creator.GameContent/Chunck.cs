using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Chunck
    {
        private Map[] maps;

        public Chunck()
        {
            maps = new Map[2];
        }

        public Map[] Maps
        {
            get { return maps; }
            set { maps = value; }
        }

    }
}
