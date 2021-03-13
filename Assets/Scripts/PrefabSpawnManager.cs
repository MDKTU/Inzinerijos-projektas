using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnManager : MonoBehaviour
{
    TileSpawner tileSpawner;
    PlotSpawner plotSpawner;

    // Start is called before the first frame update
    void Start()
    {
        tileSpawner = GetComponent<TileSpawner>();
        plotSpawner = GetComponent<PlotSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TileSpawnTriggered()
    {
        tileSpawner.MoveTile();
        plotSpawner.SpawnPlot();
    }
}
