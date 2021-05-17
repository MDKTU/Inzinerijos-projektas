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
        tileSpawner.SpawnObstacles(2);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TileSpawnTriggered()
    {
        tileSpawner.MoveTile();
        tileSpawner.SpawnObstacles(0);
        plotSpawner.MovePlot();
    }

}
