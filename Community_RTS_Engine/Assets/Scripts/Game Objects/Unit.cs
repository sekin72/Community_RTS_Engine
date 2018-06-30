using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    class Unit : OwnedAssets
    {
        private int walkSpeedX, walkSpeedY;
        public Tile currentTile;
        private Tile targetTile;

        void Update()
        {
            if (targetTile != null)
                moveToTarget();
            //update new tile
            if(health<=0)
            {
                //destroy;
            }
        }


        public void move(Tile target)
        {
            targetTile = target;
            moveToTarget();
        }

        private void moveToTarget()
        {
            _5FootStep();

            if (targetTile.compareTile(currentTile))
                targetTile = null;

        }

        private void _5FootStep()
        {
            if (targetTile.x < x)
            {
                x -= walkSpeedX;
            }
            else if (targetTile.x > x)
            {
                x += walkSpeedX;
            }

            if (targetTile.y < y)
            {
                y -= walkSpeedY;
            }
            else if (targetTile.y > y)
            {
                y += walkSpeedY;
            }
        }
    }
}
