using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent.World
{
    public class Map
    {
        public const byte SQUARE_SIZE = 32;

        private List<ComponentObject> mapContent;

        public Map()
        {
            mapContent = new List<ComponentObject>();
        }
    }

}
