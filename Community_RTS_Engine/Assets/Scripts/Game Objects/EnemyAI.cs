﻿using Assets.Scripts.Game_Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class EnemyAI : Player
    {
        Player otherPlayer;

        private List<RawImage> consBuild = new List<RawImage>();

        public void WhatToDo()
        {
            switch(MainEntrance.Instance.name)
            {
                case "Commander":
                    soldierai();
                    gathererai();
                    return;
                case "Kingdom":
                    buildCastle();
                    return;
                case "Spells":
                    soldierai();
                    return;
                default:
                    return;
            }
        }

        void soldierai()
        {
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
        }
        void gathererai()
        {
            int sentTo = 0;

            foreach (var gatherer in Gatherers)
            {
                switch (sentTo)
                {
                    case (0):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resourcess(Resourcess.Resource.Meat));
                        sentTo++;
                        return;
                    case (1):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resourcess(Resourcess.Resource.Metal));
                        sentTo++;
                        return;
                    case (2):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resourcess(Resourcess.Resource.Rock));
                        sentTo++;
                        return;
                    case (3):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resourcess(Resourcess.Resource.Wheat));
                        sentTo++;
                        return;
                    case (4):
                        Map.Instance.findClosestTileWithAsset(gatherer.currentTile, new Resourcess(Resourcess.Resource.Gold));
                        sentTo = 0;
                        return;
                    default:
                        return;

                }
            }
        }
        void traderai()
        {
            //TODO
        }

        void buildCastle()
        {
            StartCoroutine(Buildaftertime());
        }

        IEnumerator Buildaftertime()
        {
            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(0).GetComponent<RawImage>(), new Vector2(100, -100), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(1).GetComponent<RawImage>(), new Vector2(300, -100), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(2).GetComponent<RawImage>(), new Vector2(500, -100), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(3).GetComponent<RawImage>(), new Vector2(700, -100), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(4).GetComponent<RawImage>(), new Vector2(900, -100), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(5).GetComponent<RawImage>(), new Vector2(500, -200), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(6).GetComponent<RawImage>(), new Vector2(100, 200), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(7).GetComponent<RawImage>(), new Vector2(100, 400), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);

            yield return new WaitForSeconds(5);
            consBuild.Add(Instantiate(consB.ElementAt(8).GetComponent<RawImage>(), new Vector2(300, 400), Quaternion.identity) as RawImage);
            consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
        }
        public void Update()
        {
            WhatToDo();
        }

    }
}
