using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    class GathererUnit : Unit
    {
        private int gatherSpeed;
        private Tile gatherTarget;

        public void Update()
        {
            if (gatherTarget != null)
                gatherResource();
            if (checkNeedForRun())
                run();
        }

        public void gather(Tile gTarget)
        {
            gatherTarget = gTarget;
            gatherResource();
        }

        private void gatherResource()
        {
            bool flagRes = false;

            if (gatherTarget.occupiedBy is Resources)
                flagRes = true;
            if (!flagRes)
                return ;

            if(currentTile.findDistance(gatherTarget) < 1.5)
            {
                //if(amount resource in tile <=0)
                //destroy resource in that tile
                //gatherTarget=null;
                //else
                {
                    //gatherTarget.occupiedBy.amount -= gatherSpeed;
                    //belongsTo.typeRes +=gatherSpeed;
                }
            }
            else
            {
                move(gatherTarget);
            }

        }
        private void run()
        {
            //move(belongsTo.city.tile);
        }

        private bool checkNeedForRun()
        {
            return false;
        }
    }
}
