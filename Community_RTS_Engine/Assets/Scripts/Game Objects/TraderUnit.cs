using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Game_Objects;

namespace Assets.Scripts.Game_Objects
{
    class TraderUnit : Unit
    {
        private Tile tradeTile;
        private int amount;
<<<<<<< HEAD
        private Resources asked;
=======
        private Resourcess asked;
>>>>>>> origin/Kaan
        private String currentTask = "want";

        public void attack(Tile target)
        {
            tradeTile = target;
            wantFromTarget();
        }

        public void Update()
        {
            if (tradeTile != null)
                if (currentTask == "want")
                    wantFromTarget();
                else
                    sellToTarget();
        }

<<<<<<< HEAD
        public void want(Tile target, Resources type, int askedAmount)
=======
        public void want(Tile target, Resourcess type, int askedAmount)
>>>>>>> origin/Kaan
        {
            tradeTile = target;
            asked = type;
            amount = askedAmount;
            currentTask = "want";
            wantFromTarget();
        }

<<<<<<< HEAD
        public void sell(Tile target, Resources type, int askedAmount)
=======
        public void sell(Tile target, Resourcess type, int askedAmount)
>>>>>>> origin/Kaan
        {
            tradeTile = target;
            asked = type;
            amount = askedAmount;
            currentTask = "sell";
            sellToTarget();
        }

        private void wantFromTarget()
        {
            if (currentTile.findDistance(tradeTile) < 1.5)
            {
                //1000den fazla mı
                //en az olanı mı
                //no more than 1/3
            }
            else
            {
                move(tradeTile);
            }
        }

        private void sellToTarget()
        {
            if (currentTile.findDistance(tradeTile) < 1.5)
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
                move(tradeTile);
            }
        }
    }
}
