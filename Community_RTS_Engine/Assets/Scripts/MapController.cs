using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class MapController : MonoBehaviour
    {
        public Map current;
        public Sprite grass;
        public Sprite dirt;

        
        // Use this for initialization
        void Start()
        {
            current = new Map();
            for (int i = 0; i < current.width; i++)
            {
                for (int j = 0; j < current.height; j++)
                {
                    GameObject tileGameObject = new GameObject("Tile_" + i + "_" + j);
                    tileGameObject.transform.position = new Vector3(i, j);

                    SpriteRenderer tileSpriteRenderer = tileGameObject.AddComponent<SpriteRenderer>();
                    Tile t = current.getLocation(i, j);
                    if (t.type == Tile.TileType.grass)
                        tileSpriteRenderer.sprite = grass;
                    if (t.type == Tile.TileType.dirt)
                        tileSpriteRenderer.sprite = dirt;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

