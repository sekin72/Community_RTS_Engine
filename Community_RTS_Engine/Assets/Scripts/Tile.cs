using Assets.Scripts.Game_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Tile
    {
        public GameAssets occupiedBy;
        private Player belongsTo;
        public int x, y;

        public bool compareTile(Tile targetTile)
        {
            return (x == targetTile.x && y == targetTile.y);
        }

        public double findDistance(Tile t1, Tile t2)
        {
            return Math.Sqrt((t1.x - t2.x) * (t1.x - t2.x) + (t1.y - t2.y) * (t1.y - t2.y));
        }

        public double findDistance(Tile t2)
        {
            return Math.Sqrt((x - t2.x) * (x - t2.x) + (y - t2.y) * (y - t2.y));
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    }

}
