using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{

    Rigidbody rb; // we have to add it 1st when we're gonna use physics

    public float speed;
    public float jumpForce;

    bool jump = false;

    float inputX, inputY;
    

    // we get access to Rigidbody that is attach in our Cube
    // best practice to do this inside of Awake() function
    void Awake()
    { 
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // velocity - this is a speed which is moves to x,y,z directions
        // rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        
        if ( Input.GetButtonDown("Jump") )
        {
            jump = true;
        }
    }

    void FixedUpdate() 
    {
        // Move object left/right/back/forward
        rb.velocity = new Vector3(inputX * speed, rb.velocity.y, inputY * speed);

        if ( jump ) // if ( jump == true )
        {
            Jump();

            jump = false; // should false otherwise it will be jumping all the time becasue value will be true
        }

    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }
}
