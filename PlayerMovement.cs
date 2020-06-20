using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Rigidbody rb;
    public float forwardForceMovement = 1000f;
    public float sidewaysForceMovement = 1000f;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate () {
        // Add a forward force
        rb.AddForce(-forwardForceMovement * Time.deltaTime, 0, 0);

        // If the player is pressing the d or a keys
        
        if (Input.GetKey("d") || Input.GetKeyDown(KeyCode.RightArrow))	 {
            // Add a force to the right
            Debug.Log("Right arrow key was pressed.");
            rb.AddForce(0, 0, sidewaysForceMovement * Time.deltaTime);
        }

        if (Input.GetKey("a") || Input.GetKeyDown(KeyCode.LeftArrow)) {
            // Add a force to the left
            Debug.Log("Left arrow key was pressed.");
            rb.AddForce(0, 0, -sidewaysForceMovement * Time.deltaTime);
        }
    }
    
}
