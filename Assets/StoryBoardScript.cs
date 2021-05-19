using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoryBoardScript : MonoBehaviour
{
    float timePassed = 0;
    GameObject sb1;
    GameObject sb2;
    GameObject sb3;
    GameObject sb4;
    // Start is called before the first frame update
    void Start()
    {
        sb1 = GameObject.Find("1sb");
        sb2 = GameObject.Find("2sb");
        sb3 = GameObject.Find("3sb");
        sb4 = GameObject.Find("4sb");
    }
    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 7) 
        {
            sb1.active = false;
        }
        if (timePassed > 16)
        {
            sb2.active = false;
        }
        if (timePassed > 25)
        {
            sb3.active = false;
        }
        if (timePassed > 29)
        {
            SceneManager.LoadScene("Scene 1");
        }
    }
}
