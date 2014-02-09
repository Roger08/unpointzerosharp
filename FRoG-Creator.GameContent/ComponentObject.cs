using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public abstract class ComponentObject
    {
        protected abstract byte x;
        protected abstract byte y;

        public abstract byte X
        {
            get { return x; }
            set { x = value; }
        }

        public abstract byte Y
        {
            get { return y; }
            set { y = value; }
        }

    }
}
