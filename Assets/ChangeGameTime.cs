using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameTime : MonoBehaviour
{
    [Range(0.1f,2)]
    public float modifiedScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
        modifiedScale += delta / 250;
        Time.timeScale = modifiedScale;
    }
}
