using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private float offset = 270; //length of one plot (distance between triggers)
    
    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        if (plots != null && plots.Count > 0)
        {
            plots = plots.OrderBy(x => x.transform.position.z).ToList();
        }
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


}
