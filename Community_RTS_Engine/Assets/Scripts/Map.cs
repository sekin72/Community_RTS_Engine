using Assets.Scripts.Game_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Map
    {
        private Tile[][] tileMap;
        public Tile[,] tileMap;
        public int numOfTiles, width, height;
        private string name;
        public static Map Instance;

        public Tile findClosestTile(Tile myPlace)
        {
            Tile temp = tileMap.ElementAt(0);
            foreach(var tile in tileMap)
            {
                if(temp.findDistance(myPlace) < tile.findDistance(myPlace))
                {
                    temp = tile;
                }
            }
            return temp;
        }

        public Tile findClosestTileWithAsset(Tile myPlace, GameAssets item)
        {
            Tile temp = tileMap.ElementAt(0);
            foreach (var tile in tileMap)
            {
                if (temp.findDistance(myPlace) < tile.findDistance(myPlace) && temp.occupiedBy.GetType() == item.GetType())
                {
                    temp = tile;
                }
            }

            if(temp.occupiedBy ==item)
                return temp;

            return null;
        }

        public Map(int w = 100, int h = 100)
        {
            width = w;
            height = h;
            tileMap = new Tile[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tileMap[i, j] = new Tile(i, j);
                    numOfTiles++;
                }
            }

            Instance = this;
        }
        public bool LoadMap(string fileName)
        {
            // NYI
            return false;
        }

        public Tile getLocation(int x, int y)
        {
            if (x < 0 || x > width - 1 || y < 0 || y > height - 1)
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
