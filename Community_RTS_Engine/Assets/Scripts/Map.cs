using Assets.Scripts.Game_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Map
    {
        private List<Tile> tileMap;
        private int numOfTiles;


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
                if (temp.findDistance(myPlace) < tile.findDistance(myPlace) && temp.occupiedBy == item)
                {
                    temp = tile;
                }
            }

            if(temp.occupiedBy ==item)
                return temp;

            return null;
        }
    }
}
