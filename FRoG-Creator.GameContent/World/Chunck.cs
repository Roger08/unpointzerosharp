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
        protected string fileDirectory;

        public Chunck(byte StageIndex, byte XIndex, byte YIndex)
        {
            stageIndex = StageIndex;
            xIndex = XIndex;
            yIndex = YIndex;

            maps = new Map[2];

            fileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            fileName = "Chunck_S" + stageIndex.ToString() + "_X" + xIndex.ToString() + "_Y" + yIndex.ToString();
        }

        public byte StageIndex
        {
            get { return stageIndex; }
            set { stageIndex = value; }
        }

        public byte XIndex
        {
            get { return xIndex; }
            set { xIndex = value; }
        }

        public byte YIndex
        {
            get { return yIndex; }
            set { yIndex = value; }
        }

        public string FileDirectory
        {
            get { return fileDirectory; }
        }

        public string FileName
        {
            get { return fileName; }
        }

        public Map[] Maps
        {
            get { return maps; }
            set { maps = value; }
        }

    }
}
