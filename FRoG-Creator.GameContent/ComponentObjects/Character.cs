using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Character : GameObject, IPlayableCharacter, INonPlayableCharacter
    {
        protected string name;

        public Character(string Name)
        {
            name = Name;
        }
    }
}
