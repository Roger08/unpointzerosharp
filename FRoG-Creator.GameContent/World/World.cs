using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class World
    {
        private List<Stage> stages;

        public World()
        {
            stages = new List<Stage>();
        }

        public List<Stage> Stages
        {
            get { return stages; }
            set { stages = value; }
        }

    }
}
