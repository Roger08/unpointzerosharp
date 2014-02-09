﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public abstract class ComponentObject
    {
        protected byte x;
        protected byte y;

        public byte X
        {
            get { return x; }
            set { x = value; }
        }

        public byte Y
        {
            get { return y; }
            set { y = value; }
        }

    }
}
