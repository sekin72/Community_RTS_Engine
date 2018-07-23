using Assets.Scripts.Game_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class EnemyAI : Player
    {
        Player otherPlayer;
        public void WhatToDo()
        {
            int sentTo = 0;

            foreach (var gatherer in Gatherers)
            {
                switch(sentTo)
                {
                    case (0):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resources(Resources.Resource.Meat)));
                        sentTo++;
                        return;
                    case (1):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resources(Resources.Resource.Metal));
                        sentTo++;
                        return;
                    case (2):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resources(Resources.Resource.Rock));
                        sentTo++;
                        return;
                    case (3):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resources(Resources.Resource.Wheat));
                        sentTo++;
                        return;
                    case (4):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resources(Resources.Resource.Gold));
                        sentTo =0;
                        return;
                    default:
                        return;

                }
            }

            if (Soldiers.Count > 20)
            {
                foreach (var soldier in Soldiers)
                {
                    foreach (var otherSoldier in otherPlayer.Soldiers)
                    {
                        soldier.attack(Map.Instance.findClosestTileWithAsset(soldier.currentTile, otherSoldier));
                    }
                }
            }

            /*
            foreach (var trader in Traders)
            {

            }
            */

            /*
             * foreach building
             * create units according to their amounts
             * 
             * create buildings
             * 
             * 
             */
        }

    }
}
