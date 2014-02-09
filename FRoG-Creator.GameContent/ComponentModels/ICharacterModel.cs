using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public interface ICharacterModel
    {
        public string Name { get; set; }
        public string SpriteUrl { get; set; }
    }
}
