using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    public class Resourcess : OwnedAssets
    {
        public enum Resource { Meat, Wheat, Rock, Metal, Gold };
        public Resource type;

        public Resourcess(Resource tip)
        {
            type = tip;
        }

        public Resourcess()
        {
        }
    }
}
