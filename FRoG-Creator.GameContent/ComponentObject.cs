using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class ComponentObject
    {
        protected float x;
        protected float y;
        protected string spriteUrl;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public string SpriteUrl
        {
            get { return spriteUrl; }
            set { spriteUrl = value; }
        }

    }
}
