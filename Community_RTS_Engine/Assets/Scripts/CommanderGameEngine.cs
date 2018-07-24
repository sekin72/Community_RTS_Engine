using Assets.Scripts;
using Assets.Scripts.Game_Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderGameEngine : MonoBehaviour {

    Player player = new Player();
    EnemyAI enemy;

	// Use this for initialization
	void Start () {
        enemy = new EnemyAI();
        enemy.Gatherers.Add(new GathererUnit(Map.Instance.tileMap[10, 9]));
        enemy.Gatherers.Add(new GathererUnit(Map.Instance.tileMap[10, 9]));
        enemy.Gatherers.Add(new GathererUnit(Map.Instance.tileMap[10, 9]));
    }
	
	// Update is called once per frame
	void Update ()
    {
        player.Update();
        enemy.Update();
        player.checkAlive();
        enemy.checkAlive();
    }
}
