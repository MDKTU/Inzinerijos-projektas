using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{


    public ParticleSystem obstacleHit;
    public AudioSource obsticleHitSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obsticle")
        {
            obstacleHit.Play();
            obsticleHitSound.Play();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        obsticleHitSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
