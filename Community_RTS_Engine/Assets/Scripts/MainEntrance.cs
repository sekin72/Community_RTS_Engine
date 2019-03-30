using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainEntrance : MonoBehaviour {



	// tryout for reviewable
    public static MainEntrance Instance;
    public string name;
	// Use this for initialization
	void Start () {
        Instance = this;
        name = "Kingdom";
	}
	
	// Update is called once per frame
	void Update () {
        switch (name)
        {
            case "Commander":
                SceneManager.LoadScene("CommanderPlayscene");
                return;
            case "Kingdom":
                SceneManager.LoadScene("KingdomBuilderPlay");
                return;
            case "Spells":
                SceneManager.LoadScene("Spells&Battefield");
                return;
            default:
                return;
        }
		
	}
}
