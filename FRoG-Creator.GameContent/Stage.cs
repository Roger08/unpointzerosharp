using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Stage
    {
        public const byte WIDTH = 100;
        public const byte HEIGHT = 100;

        private Chunck[,] content;

        public Stage()
        {
            content = new Chunck[WIDTH, HEIGHT];
        }

    }
}
