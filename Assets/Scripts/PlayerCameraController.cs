using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCameraController : MonoBehaviour
{
    private Transform player;

    private float xOffset = 0f;
    private float yOffset = 4f;
    private float zOffset = -10f; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Running").transform;   
    }

    // Update is called once per frame
    void LateUpdate() // (late)update to remove stuttering
    {
        transform.position = new Vector3(player.position.x + xOffset, player.position.y + yOffset, player.position.z + zOffset);
    }
}
