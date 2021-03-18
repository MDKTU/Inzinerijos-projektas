using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player movement speed
    public float movementSpeed = 1000;
    public PrefabSpawnManager tileSpawnManager;
    bool onGround = false;
    public Rigidbody rb;

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

        //failed jump scrap from another dev(Paulius)
        //leaving just in case
        /*
        if((Input.GetKeyDown("w") && onGround == true)|| (Input.GetKeyDown("space") && onGround == true))
        {
            transform.Translate(new Vector3(xMovement, 5, zMovement) * Time.deltaTime);
            onGround = false;
        }
        */

        //Boundaries for player. Clamping movement on x axis
        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the x element
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -24.5f, 24.5f);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;



        if ((Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) & onGround == true) 
        {
            rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
            onGround = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //wtf there shoudnt ne someting like this (Paulius)
        //leaving just in case
        //tileSpawnManager.TileSpawnTriggered();
        onGround = true;
    }

}
