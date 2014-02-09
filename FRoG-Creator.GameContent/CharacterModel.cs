using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public abstract class CharacterModel
    {
        protected string name;
        protected string spriteUrl;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SpriteUrl
        {
            get { return spriteUrl; }
            set { spriteUrl = value; }
        }
    }
}
