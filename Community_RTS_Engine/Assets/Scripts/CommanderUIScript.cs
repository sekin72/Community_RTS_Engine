using Assets.Scripts;
using Assets.Scripts.Game_Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommanderUIScript : MonoBehaviour {

    public GameObject gathererPanel, traderPanel, soldierPanel;
    public RawImage gathererBImage, traderBImage, soldierBImage;
    public MapController mapController;
    private bool t_mouse = false;
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
        if (t_mouse)
            gathererBImage.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (Input.GetMouseButtonDown(0) && t_mouse)
        {
            GathererUnit temp = new GathererUnit(Map.Instance.getLocation((int)Input.mousePosition.x, (int)Input.mousePosition.y));
            Map.Instance.getLocation((int)Input.mousePosition.x, (int)Input.mousePosition.y).occupiedBy = temp;
            gathererBImage.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            t_mouse = false;
        }
    }

    public void gathererBuildingClickedToBuild()
    {
        gathererBImage = Instantiate(gathererBImage, new Vector2(0, 0), Quaternion.identity) as RawImage;
        gathererBImage.transform.SetParent(GameObject.Find("Panel").transform, false);

        
        t_mouse = true;
    }
}
