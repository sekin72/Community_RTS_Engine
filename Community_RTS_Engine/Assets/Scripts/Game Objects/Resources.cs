using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    public class Resources : OwnedAssets
    {
        public enum Resource { Meat, Wheat, Rock, Metal, Gold };
        public Resource type;

        public Resources(Resource tip)
        {
            type = tip;
        }

        public Resources()
        {
        }
    }
}
