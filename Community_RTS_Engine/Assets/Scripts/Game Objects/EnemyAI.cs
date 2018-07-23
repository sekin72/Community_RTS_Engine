using Assets.Scripts.Game_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class EnemyAI : Player
    {
        public void WhatToDo()
        {
            foreach (var gatherer in Gatherers)
            {
                Resources temp = new Resources();
                Map.findClosestTileWithAsset(gatherer.currentTile, temp);
                temp = new Resources(Resources.Resource.Meat);
                Map.findClosestTileWithAsset(gatherer.currentTile, temp);
                temp = new Resources(Resources.Resource.Metal);
                Map.findClosestTileWithAsset(gatherer.currentTile, temp);
                temp = new Resources(Resources.Resource.Rock);
                Map.findClosestTileWithAsset(gatherer.currentTile, temp);
                temp = new Resources(Resources.Resource.Wheat);
                Map.findClosestTileWithAsset(gatherer.currentTile, temp);
            }

            foreach (var soldier in Soldiers)
            {

            }

            foreach (var trader in Traders)
            {

            }

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
