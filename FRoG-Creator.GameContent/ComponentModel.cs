using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public abstract class ComponentModel
    {

    }

    interface IPlayable
    {
        
    }

    interface IBeatable
    {
        protected int life;

        int Life
        {
            get { return life; }
            set { life = value; }
        }
    }
}
