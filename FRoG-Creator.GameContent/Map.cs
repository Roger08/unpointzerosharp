using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FRoG_Creator.GameContent
{
    [Serializable()]
    public class Map
    {
        public const byte tilesGridWidth = 12;
        public const byte tilesGridHeight = 9;

        protected Tile[,] tilesGrid;

        public Map()
        {
            tilesGrid = new Tile[tilesGridWidth, tilesGridHeight];

            InitTiles();
        }

        private void InitTiles()
        {
            for (int j = 0; j < tilesGridHeight; j++)
            {
                for (int i = 0; i < tilesGridWidth; i++)
                {
                    Tile tile = new Tile();
                    tile.Layers = new List<string>();
                    tile.Layers.Add("field_full_0");
                    tilesGrid[i, j] = tile;
                }
            }

            tilesGrid[1, 1].Layers.Add("forest_full_0");

        }

        public Tile[,] TilesGrid
        {
            get { return tilesGrid; }
            set { tilesGrid = value; }
        }

    }
}
