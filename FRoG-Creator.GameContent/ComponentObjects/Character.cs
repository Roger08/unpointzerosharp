using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public enum Direction
    {
        BAS,
        DROITE,
        GAUCHE,
        HAUT,
    }

    public abstract class Character : ComponentObject
    {
        protected string name;
        protected int level;
        protected Direction direction;
        protected float speed;
        protected Dictionary<string, int> traits;
        protected Dictionary<string, int> specifications;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Dictionary<string, int> Traits
        {
            get { return traits; }
            set { traits = value; }
        }

        public Dictionary<string, int> Specifications
        {
            get { return specifications; }
            set { specifications = value; }
        }

        void Walk(Direction direction)
        {
            this.direction = direction;
            Animation.Animations.Add(new Animation(this, direction, this.speed, Animation.Type.WALK));
        }
    }
}
