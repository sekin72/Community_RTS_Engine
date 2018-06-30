using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    class City : OwnedAssets
    {
        private bool checkAlive()
        {
            if (health <= 0)
                return false;
            return true;
        }
    }
}
