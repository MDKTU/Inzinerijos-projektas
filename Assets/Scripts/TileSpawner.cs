using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TileSpawner : MonoBehaviour
{
    public List<GameObject> tiles;
    private float offset = 270f; //length of three tiles

    public List<GameObject> obstaclePrefabs;

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


    public void SpawnObstacles(int x)
    {
        // Choose a random point to spawn the obstacle
        
        for(int i = x; i < tiles.Count; i++)
        {
            for(int j = 0; j < 18; j++)
            {
                Transform spawnPoint = tiles[i].transform.GetChild(j).transform;
                if (spawnPoint.childCount == 0)
                {
                    var obj = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Count)];
                    Instantiate(obj, spawnPoint.position, Quaternion.Euler(0,Random.Range(0f,360f),0), spawnPoint);

                }
                //Debug.Log(spawnPoint.name);
            }
        }
    }
}
