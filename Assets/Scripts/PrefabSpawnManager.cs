using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnManager : MonoBehaviour
{
    TileSpawner tileSpawner;
    PlotSpawner plotSpawner;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        tileSpawner = GetComponent<TileSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tileSpawner.tiles[0].transform.position.z + 200 < player.transform.position.z)
        {
            TileSpawnTriggered();
        }
    }

    public void TileSpawnTriggered()
    {
        tileSpawner.MoveTile();
        //plotSpawner.SpawnPlot();
        plotSpawner.MovePlot();
    }
}
