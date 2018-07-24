using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace Assets.Scripts.Game_Objects
{
    class GathererBuilding : Building
    {
        //1 = GOLD, 2 = LUMBER, 3 = ROCK, 4 = MEATH
        public RawImage goldB;
        public RawImage rockB;
        public RawImage lumberB;
        public List<RawImage> consB;
        public Text Gold;
        public Text Lumber;
        public Text Rock;
        private int goldCount = 100;
        private int LumberCount = 100;
        private int RockCount = 100;
        private int test = 10;
        private Boolean g_mouse = false;
        private Boolean r_mouse = false;
        private Boolean l_mouse = false;
        private Boolean b_mouse = false;
        private List<RawImage> goldBuild = new List<RawImage>();
        private List<RawImage> rockBuild = new List<RawImage>();
        private List<RawImage> lumberBuild = new List<RawImage>();
        private List<RawImage> consBuild = new List<RawImage>();
        Ray ray;
        RaycastHit2D hit;
        private void Start()
        {
            InvokeRepeating("resourceIncrease", 2.0f, 1.0f);
            Gold.text = goldCount.ToString();
            Lumber.text = LumberCount.ToString();
            Rock.text = RockCount.ToString();
        }
        private void Update()
        {
            if (g_mouse)
            {
                goldBuild.ElementAt(goldBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            if (r_mouse)
            {
                rockBuild.ElementAt(rockBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            if (l_mouse)
            {
                lumberBuild.ElementAt(lumberBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            if (b_mouse)
            {
                consBuild.ElementAt(consBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log(EventSystem.current.currentSelectedGameObject.ToString());
                if (Input.GetMouseButtonDown(0) && g_mouse)
                {
                    goldBuild.ElementAt(goldBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    g_mouse = false;
                }
                if (Input.GetMouseButtonDown(0) && r_mouse)
                {
                    rockBuild.ElementAt(rockBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    r_mouse = false;
                }
                if (Input.GetMouseButtonDown(0) && l_mouse)
                {
                    lumberBuild.ElementAt(lumberBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    l_mouse = false;
                }
                if (Input.GetMouseButtonDown(0) && b_mouse)
                {
                    consBuild.ElementAt(consBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    b_mouse = false;
                }
            }

        }
        public void resourceIncrease()
        {
            goldCount+= 5 * goldBuild.Count;
            RockCount += 5 * rockBuild.Count;
            LumberCount += 5 * lumberBuild.Count;
            Gold.text = goldCount.ToString();
            Lumber.text = LumberCount.ToString();
            Rock.text = RockCount.ToString();
        }
        public void createGoldB()
        {
            if (LumberCount - 100 >= 0)
            {
                LumberCount -= 100;
                goldBuild.Add(Instantiate(goldB.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                goldBuild.ElementAt(goldBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                g_mouse = true;
            }
        }
        public void createRockB()
        {
            if (goldCount - 100 >= 0)
            {
                goldCount -= 100;
                rockBuild.Add(Instantiate(rockB.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                rockBuild.ElementAt(rockBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                r_mouse = true;
            }
        }
        public void createLumberB()
        {
            if (RockCount - 100 >= 0)
            {
                RockCount -= 100;
                lumberBuild.Add(Instantiate(lumberB.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                lumberBuild.ElementAt(lumberBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                l_mouse = true;
            }
        }
        public void createBuilding()
        {
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("1st"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(0).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("2nd"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(1).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("3rd"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(2).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("7ust"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(3).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("7alt"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(4).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("8ust"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(5).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("8alt"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(6).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("9ust"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(7).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
            if (EventSystem.current.currentSelectedGameObject.ToString().Contains("9alt"))
            {
                consBuild.Add(Instantiate(consB.ElementAt(8).GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
                consBuild.ElementAt(consBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
                b_mouse = true;
            }
        }
    }

}
