using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
namespace Assets.Scripts.Game_Objects
{
    class GathererBuilding : Building
    {
        //1 = GOLD, 2 = LUMBER, 3 = ROCK, 4 = MEATH
        public Image goldB;
        public RawImage rockB;
        public RawImage lumberB;
        public Text Gold;
        public Text Lumber;
        public Text Rock;
        private int test = 10;
        private Boolean t_mouse = false;
        private List<Image> goldBuild = new List<Image>();
        private List<RawImage> rockBuild = new List<RawImage>();
        private List<RawImage> lumberBuild = new List<RawImage>();
        Ray ray;
        RaycastHit2D hit;
        private void Start()
        {/*
            InvokeRepeating("resourceIncrease", 2.0f, 1.0f);
            Gold.text = "10";
            Lumber.text = "10";
            Rock.text = "10";*/
        }
        private void Update()
        {
            if(t_mouse)
            goldBuild.ElementAt(goldBuild.Count-1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.GetMouseButtonDown(0) && t_mouse)
                {
                    goldBuild.ElementAt(goldBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                    t_mouse = false;
                }
            }

        }
        private void OnMouseDown()
        {
            
        }/*
        public void resourceIncrease()
        {
            test = test + 5;
            Gold.text = (test*goldBuild.Count).ToString();
            Lumber.text = test.ToString();
            Rock.text = test.ToString();
        }*/
        public void createGoldB()
        {
            Debug.Log("sa");
            goldBuild.Add(Instantiate(goldB, new Vector2(0, 0), Quaternion.identity) as Image);
            goldBuild.ElementAt(goldBuild.Count-1).transform.SetParent(GameObject.Find("Panel").transform, false);
            t_mouse = true;
        }
        public void createRockB()
        {
            rockBuild.Add(Instantiate(rockB, new Vector2(0, 0), Quaternion.identity) as RawImage);
            rockBuild.ElementAt(goldBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
            t_mouse = true;
        }
        public void createLumberB()
        {
            lumberBuild.Add(Instantiate(lumberB, new Vector2(0, 0), Quaternion.identity) as RawImage);
            lumberBuild.ElementAt(lumberBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
            t_mouse = true;
        }
    }

}
