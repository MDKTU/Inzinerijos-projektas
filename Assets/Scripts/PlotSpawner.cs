using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    //keeping just in case
    //private int initAmount = 5; // number of plots spawning after initializing
    //private float plotSize = 150; // 
    //private float xPositionLeft = -150f; // 
    //private float xPositionRight = 150f; // 
    //private float lastZPos = 150f; // 


    private float offset = 150f; //length of three tiles

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        if (plots != null && plots.Count > 0)
        {
            plots = plots.OrderBy(x => x.transform.position.z).ToList();
        }

        
        //for (int i = 0; i < initAmount; i++)
        //{
        //    SpawnPlot();
        //}
    }
    public void MovePlot()
    {
        GameObject movedTile = plots[0];
        plots.Remove(movedTile);
        float newZCordinate = plots[plots.Count - 1].transform.position.z + offset;
        movedTile.transform.position = new Vector3(0, 0, newZCordinate);
        plots.Add(movedTile);
    }



    // Update is called once per frame
    void Update()
    {

    }

    ////keeping this just in case :/
    //public void SpawnPlot()
    //{
    //    int rand = Random.Range(0, plots.Count);
    //    //GameObject plotLeft = plots[rand];
    //    //GameObject plotRight = plots[rand];

    //    float zPos = lastZPos + plotSize;

    //    GameObject plotLeft = plots[Random.Range(0, plots.Count)];
    //    GameObject plotRight = plots[Random.Range(0, plots.Count)];

    //    //Instantiate(plotLeft, new Vector3(xPositionLeft, 0.025f, zPos), plotLeft.transform.rotation);
    //    //Instantiate(plotRight, new Vector3(xPositionRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));

    //    Instantiate(plotLeft, new Vector3(xPositionLeft, 0.025f, zPos), new Quaternion(0, 180, 0, 0));
    //    Instantiate(plotRight, new Vector3(xPositionRight, 0.025f, zPos), plotLeft.transform.rotation);

    //    lastZPos += plotSize;

    //    //if (plots != null && plots.Count > 0)
    //    //{
    //    //    plots = plots.OrderBy(x => x.transform.position.z).ToList();
    //    //}

    //}


}
