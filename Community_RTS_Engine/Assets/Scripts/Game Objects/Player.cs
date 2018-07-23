using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Game_Objects
{
    class Player : GameAssets
    {
        public List<Tile> ownedTile;
        public List<GathererUnit> Gatherers;
        public List<SoldierUnit> Soldiers;
        public List<TraderUnit> Traders;
        public List<SoldierBuilding> SoldierBuilding;
        public List<GathererBuilding> GathererBuilding;
        public int occupiedTileAmount;


        public Player belongsTo;
        public int timeNeeded;
        public int resourceNeededWood, resourceNeededWheat, resourceNeededMeat, resourceNeededStone, resourceNeededGold;
        
    }
}
