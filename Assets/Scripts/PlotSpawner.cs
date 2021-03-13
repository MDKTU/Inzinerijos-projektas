using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 5; // number of plots spawning after initializing
    private float plotSize = 150; // 
    private float xPositionLeft = -150f; // 
    private float xPositionRight = 150f; // 
    private float lastZPos = 150f; // 

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    public void SpawnPlot()
    {
        int rand = Random.Range(0, plots.Count);
        //GameObject plotLeft = plots[rand];
        //GameObject plotRight = plots[rand];

        float zPos = lastZPos + plotSize;

        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        //Instantiate(plotLeft, new Vector3(xPositionLeft, 0.025f, zPos), plotLeft.transform.rotation);
        //Instantiate(plotRight, new Vector3(xPositionRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));

        Instantiate(plotLeft, new Vector3(xPositionLeft, 0.025f, zPos), new Quaternion(0, 180, 0, 0));
        Instantiate(plotRight, new Vector3(xPositionRight, 0.025f, zPos), plotLeft.transform.rotation);

        lastZPos += plotSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
