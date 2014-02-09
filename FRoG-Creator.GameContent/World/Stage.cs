using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FRoG_Creator.GameContent
{
    public class Stage
    {
        protected string name;
        protected List<Chunck> content;

        public Stage(string Name)
        {
            name = Name;
            content = new List<Chunck>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Chunck> Content
        {
            get { return content; }
            set { content = value; }
        }

        public void SaveChunck(Chunck chunck)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                xmlSerializer.Serialize(new StreamWriter(chunck.FileDirectory + chunck.FileName), chunck);
            }

            catch (Exception e)
            {
                Log.Messages.Add(e.Message);
            }
        }

        public void OpenChunck(Chunck chunck)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                chunck = xmlSerializer.Deserialize(new StreamReader(chunck.FileDirectory + chunck.FileName)) as Chunck;
            }

            catch (Exception e)
            {
                Log.Messages.Add(e.Message);
            }
        }

    }
}
