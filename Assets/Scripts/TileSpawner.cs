using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TileSpawner : MonoBehaviour
{
    public List<GameObject> tiles;
    private float offset = 150f; //length of three tiles
    GameObject player;
    PrefabSpawnManager spawnManager;



    // Start is called before the first frame update
    void Start()
    {
        // Sorting so unity doesnt get confused if order is messed up in "Tile Spawn Manager" tile spawner script
        if(tiles != null && tiles.Count > 0)
        {
            tiles = tiles.OrderBy(x => x.transform.position.z).ToList();
        }
    }

    public void MoveTile()
    {
        GameObject movedTile = tiles[0];
        tiles.Remove(movedTile);
        float newZCordinate = tiles[tiles.Count - 1].transform.position.z + offset;
        movedTile.transform.position = new Vector3(0, 0, newZCordinate);
        tiles.Add(movedTile);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
