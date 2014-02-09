using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace FRoG_Creator.GameContent
{
    [Serializable()]
    public class Chunck
    {
        public const byte width = 15;
        public const byte height = 15;

        protected byte stageIndex;
        protected byte xIndex;
        protected byte yIndex;
        protected Map[] maps;
        protected string fileName;

        public Chunck(byte StageIndex, byte XIndex, byte YIndex)
        {
            stageIndex = StageIndex;
            xIndex = XIndex;
            yIndex = YIndex;

            maps = new Map[2];
            fileName = "Chunck_S" + stageIndex.ToString() + "_X" + xIndex.ToString() + "_Y" + yIndex.ToString();
        }

        public Map[] Maps
        {
            get { return maps; }
            set { maps = value; }
        }

        public void Save()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                
            }

            catch (Exception e)
            {
                Log.Messages.Add(e.Message);
            }
        }

    }
}
