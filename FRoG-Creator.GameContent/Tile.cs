using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Tile
    {
        protected string label;
        protected List<string> layers;
        protected bool[] accessibility;
        protected byte speed;

        public Tile()
        {
            accessibility = new bool[4];

            for (int i = 0; i < 4; i++)
            {
                accessibility[i] = true;
            }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public List<string> Layers
        {
            get { return layers; }
            set { layers = value; }
        }

        public bool[] Accessibility
        {
            get { return accessibility; }
            set { accessibility = value; }
        }

        public byte Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
