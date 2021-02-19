using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    float verticalInput;

    public float horizontalMultiplier = 2;
    public float verticalMultiplier = 2;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        Vector3 verticalMove = transform.up * verticalInput * speed * Time.fixedDeltaTime * verticalMultiplier;
        rb.MovePosition(rb.position + forwardMove + verticalMove);




    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
}
