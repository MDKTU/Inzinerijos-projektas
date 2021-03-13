using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player movement speed
    public float movementSpeed = 1000;
    public PrefabSpawnManager tileSpawnManager;
    bool inAir = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * movementSpeed / 2; // x axis (side to side)
        //float zMovement = Input.GetAxis("Vertical") * movementSpeed;         // z axis (forward)
        float zMovement = movementSpeed;         // z axis (forward)
        transform.Translate(new Vector3(xMovement, 0, zMovement) * Time.deltaTime); // Movement execution
        //transform.Translate(new Vector3(xMovement, 0, zMovement) * Time.deltaTime); // Movement execution

        if((Input.GetKeyDown("w") && inAir == false)|| (Input.GetKeyDown("space") && inAir == false))
        {
            transform.Translate(new Vector3(xMovement, 1000, zMovement) * Time.deltaTime);
            inAir = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        tileSpawnManager.TileSpawnTriggered();
    }

}
