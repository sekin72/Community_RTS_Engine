using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Map
    {
        public Tile[,] tileMap;
        public int numOfTiles, width, height;
        private string name;

        public Map (int w = 100, int h = 100)
        {
            width = w;
            height = h;
            tileMap = new Tile[width, height];

            for(int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tileMap[i, j] = new Tile(i, j);
                    numOfTiles++;
                }
            }
        }
        public bool LoadMap(string fileName)
        {
            // NYI
            return false;
        } 
        public Tile getLocation(int x, int y)
        {
            if ( x < 0 || x > width - 1 || y < 0 || y > height - 1)
            {
                return null;
            }
            else
            {
                return tileMap[x, y];
            }
        }
    }
}
