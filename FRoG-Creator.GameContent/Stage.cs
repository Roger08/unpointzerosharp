using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Stage
    {
        protected string name;

        public Stage(string Name)
        {
            name = Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
