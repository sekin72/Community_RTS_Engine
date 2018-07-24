using Assets.Scripts;
using Assets.Scripts.Game_Objects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEditor;


public class CommanderUIScript : MonoBehaviour {

    public GameObject gathererPanel, traderPanel, soldierPanel;
    public RawImage gathererBImage, traderBImage, soldierBImage;
    public MapController mapController;
    private bool g_mouse = false;
    private bool t_mouse = false;
    private bool s_mouse = false;
    public static List<RawImage> gatBuild = new List<RawImage>();
    public static List<RawImage> tradBuild = new List<RawImage>();
    private List<RawImage> soldBuild = new List<RawImage>();
    Ray ray;
    RaycastHit2D hit;

    // Use this for initialization
    void Start ()
    {
        gathererPanel.gameObject.SetActive(false);
        traderPanel.gameObject.SetActive(false);
        soldierPanel.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (g_mouse)
            gatBuild.ElementAt(gatBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (t_mouse)
            tradBuild.ElementAt(tradBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (s_mouse)
            soldBuild.ElementAt(soldBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (Input.GetMouseButtonDown(0) && t_mouse)
        {
            tradBuild.ElementAt(tradBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            t_mouse = false;
        }
        if (Input.GetMouseButtonDown(0) && g_mouse)
        {
            gatBuild.ElementAt(gatBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            g_mouse = false;
        }
        if (Input.GetMouseButtonDown(0) && s_mouse)
        {
            soldBuild.ElementAt(soldBuild.Count - 1).transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            s_mouse = false;
        }
        /*
        GathererUnit temp = new GathererUnit(Map.Instance.getLocation((int)Input.mousePosition.x, (int)Input.mousePosition.y));
        Map.Instance.getLocation((int)Input.mousePosition.x, (int)Input.mousePosition.y).occupiedBy = temp;
        gathererBImage.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        t_mouse = false;*/
        if(gatBuild.Count>0)
            gathererPanel.gameObject.SetActive(true);
        if (soldBuild.Count > 0)
            soldierPanel.gameObject.SetActive(true);
        if (tradBuild.Count > 0)
            traderPanel.gameObject.SetActive(true);

    }

    public void gathererBuildingClickedToBuild()
    {
        gatBuild.Add(Instantiate(gathererBImage.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
        gatBuild.ElementAt(gatBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
        g_mouse = true;
    }
    public void soldierBuildingClickedToBuild()
    {
        soldBuild.Add(Instantiate(soldierBImage.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
        soldBuild.ElementAt(soldBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
        s_mouse = true;
    }
    public void traderBuildingClickedToBuild()
    {
        tradBuild.Add(Instantiate(traderBImage.GetComponent<RawImage>(), new Vector2(0, 0), Quaternion.identity) as RawImage);
        tradBuild.ElementAt(tradBuild.Count - 1).transform.SetParent(GameObject.Find("Panel").transform, false);
        t_mouse = true;
    }
}
