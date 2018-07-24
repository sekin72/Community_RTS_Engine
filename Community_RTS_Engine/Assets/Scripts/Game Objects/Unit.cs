using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace Assets.Scripts.Game_Objects
{
    class Unit : OwnedAssets
    {
        private int walkSpeedX, walkSpeedY;
        public Tile currentTile;
        private Tile targetTile;
        public Image gathererC, traderC;
        private bool g_mouse = false;
        private bool t_mouse = false;
        private List<Image> gathererCreate = new List<Image>();
        private List<Image> traderCreate = new List<Image>();
        Ray ray;
        RaycastHit2D hit;
        void Update()
        {
            if (g_mouse)
            {
                gathererCreate.ElementAt(gathererCreate.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            if(t_mouse)
                traderCreate.ElementAt(gathererCreate.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log(EventSystem.current.currentSelectedGameObject.ToString());
                if (g_mouse)
                {
                    System.Random rnd = new System.Random();
                    int randTilex = rnd.Next(-100, 100);
                    gathererCreate.ElementAt(gathererCreate.Count - 1).transform.position = new Vector2(CommanderUIScript.gatBuild.ElementAt(0).transform.position.x+ randTilex, CommanderUIScript.gatBuild.ElementAt(0).transform.position.y + randTilex);
                    g_mouse = false;
                }
                if (t_mouse)
                {
                    System.Random rnd = new System.Random();
                    int randTilex = rnd.Next(-100, 100);
                    traderCreate.ElementAt(gathererCreate.Count - 1).transform.position = new Vector2(CommanderUIScript.tradBuild.ElementAt(0).transform.position.x + randTilex, CommanderUIScript.tradBuild.ElementAt(0).transform.position.y + randTilex);
                    t_mouse = false;
                }
            }
        

                if (targetTile != null)
                moveToTarget();
            //update new tile
            if(health<=0)
            {
                //destroy;
            }
        }


        public void move(Tile target)
        {
            targetTile = target;
            moveToTarget();
        }

        private void moveToTarget()
        {
            _5FootStep();

            if (targetTile.compareTile(currentTile))
                targetTile = null;

        }
        public void createGatherer()
        {
            gathererCreate.Add(Instantiate(gathererC, new Vector2(0, 0), Quaternion.identity) as Image);
            gathererCreate.ElementAt(gathererCreate.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
            g_mouse = true;
        }
        public void createTrader()
        {
            traderCreate.Add(Instantiate(traderC, new Vector2(0, 0), Quaternion.identity) as Image);
            traderCreate.ElementAt(traderCreate.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
            t_mouse = true;
        }
        private void _5FootStep()
        {
            if (targetTile.x < x)
            {
                x -= walkSpeedX;
            }
            else if (targetTile.x > x)
            {
                x += walkSpeedX;
            }

            if (targetTile.y < y)
            {
                y -= walkSpeedY;
            }
            else if (targetTile.y > y)
            {
                y += walkSpeedY;
            }
        }
    }
}
