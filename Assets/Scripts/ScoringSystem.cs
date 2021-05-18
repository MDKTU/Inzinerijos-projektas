using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public AudioSource collectSound;
    public ScoreManagment scoreManagment;


    private void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        scoreManagment.addition();
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
