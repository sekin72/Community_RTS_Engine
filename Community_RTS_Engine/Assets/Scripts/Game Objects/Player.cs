using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;

namespace Assets.Scripts.Game_Objects
{
    class Player : GameAssets
    {
<<<<<<< HEAD
        public List<Tile> ownedTile;
        public List<GathererUnit> Gatherers;
        public List<SoldierUnit> Soldiers;
        public List<TraderUnit> Traders;
        public List<SoldierBuilding> SoldierBuilding;
        public List<GathererBuilding> GathererBuilding;
        public int occupiedTileAmount;
=======
        public List<Tile> ownedTile = new List<Tile>();
        public List<GathererUnit> Gatherers = new List<GathererUnit>();
        public List<SoldierUnit> Soldiers = new List<SoldierUnit>();
        public List<TraderUnit> Traders = new List<TraderUnit>();
        public List<SoldierBuilding> SoldierBuilding = new List<SoldierBuilding>();
        public List<GathererBuilding> GathererBuilding = new List<GathererBuilding>();
        public int occupiedTileAmount;
        public List<RawImage> consB = new List<RawImage>();

        public int timeNeeded;
        public int resourceNeededWood, resourceNeededWheat, resourceNeededMeat, resourceNeededStone, resourceNeededGold;

        public Player()
        {/*
            Gatherers.Add(new GathererUnit(Map.Instance.tileMap[5, 5]));
            Gatherers.Add(new GathererUnit(Map.Instance.tileMap[5, 7]));
            Gatherers.Add(new GathererUnit(Map.Instance.tileMap[5, 9]));*/
        }
        public void Start()
        {
            
        }

        public bool checkAlive()
        {
            if (health <= 0)
                return false;
            return true;
        }

        public void Update()
        {
        }
>>>>>>> origin/Kaan


        public Player belongsTo;
        public int timeNeeded;
        public int resourceNeededWood, resourceNeededWheat, resourceNeededMeat, resourceNeededStone, resourceNeededGold;
        
    }
}
