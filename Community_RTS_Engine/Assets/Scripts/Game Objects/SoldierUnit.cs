using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    class SoldierUnit : Unit
    {
        private Tile attackTile;
        private int damage;

        public SoldierUnit()
        {

        }

        public void Update()
        {
            if (attackTile != null)
                attackToTarget();
        }

        public void attack(Tile target)
        {
            attackTile = target;
            attackToTarget();
        }

        private void attackToTarget()
        {
            if (currentTile.findDistance(attackTile) < 1.5)
            {
                //attackTile.occupiedBy.health -= damage;

                /*if (attackTile.occupiedBy.health <= 0)
                {
                    attackTarget=null;
                }
                */
            }
            else
            {
                move(attackTile);
            }
        }
    }

}
