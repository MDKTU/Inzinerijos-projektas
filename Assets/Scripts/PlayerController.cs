using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 45;
    public PrefabSpawnManager tileSpawnManager;
    public HealthManagment healthManagment;
    public Rigidbody rb;
    CharacterController characterController;
    public bool moveEnable;

    public float jumpHeight = 900f;
    public bool isGrounded;
    public float NumberJumps = 0f;
    public float MaxJumps = 1;


    // Start is called before the first frame update
    void Start()
    {
        moveEnable = true;
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        if (healthManagment.healthPoints > 0) {
            float xMovement = Input.GetAxis("Horizontal") * movementSpeed / 3; // x axis (side to side)
            float zMovement = movementSpeed; // z axis (forward)
            
            
            // fuck disgrace nes eina per obiektus nepaisant nieko nei collsions nei ka
            //transform.Translate(new Vector3(xMovement, 0, zMovement) * Time.deltaTime); // Movement execution
            
            Vector3 movement = new Vector3(xMovement, 0, zMovement);
            characterController.Move(movement * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(movement);

            if (NumberJumps > MaxJumps - 1)
            {
                isGrounded = false;
            }

            if (isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rb.AddForce(Vector3.up * jumpHeight);
                    NumberJumps += 1;
                }
            }

            //Boundaries for player. Clamping movement on x axis
            // initially, the temporary vector should equal the player's position
            Vector3 clampedPosition = transform.position;
            // Now we can manipulte it to clamp the x element
            //clampedPosition.x = Mathf.Clamp(clampedPosition.x, -24.5f, 24.5f);
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, -18.5f, 18.5f);
            // re-assigning the transform's position will clamp it
            transform.position = clampedPosition;
        }
        moveEnable = false;
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Tile Spawn Trigger")
            tileSpawnManager.TileSpawnTriggered();
    }
    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        NumberJumps = 0;
    }
    void OnCollisionExit(Collision other)
    {

    }

}
