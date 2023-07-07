using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ( Input.GetKeyDown(KeyCode.Space) ) // when you just pressed button
        {
            print("Space Button is Pressed First Time");
        }

        if ( Input.GetKeyUp(KeyCode.Space) ) // when you Released button
        {
            print("Space Button is Released");
        }

        if ( Input.GetKey(KeyCode.Space) ) // when you push and holding button
        {
            print("Space Button is Held Down");
        }
        */

        /*
        if ( Input.GetKeyDown(KeyCode.Space) ) // when you just pressed button
        {
            print("Space Button is Pressed First Time");
            
            GetComponent<Renderer>().material.color = Color.green;
        }

        if ( Input.GetKeyUp(KeyCode.Space) ) // when you Released button
        {
            print("Space Button is Released");

            GetComponent<Renderer>().material.color = Color.yellow;
        }

        if ( Input.GetKey(KeyCode.Space) ) // when you push and holding button
        {
            print("Space Button is Held Down");
        }
        */

        /*
        if ( Input.GetButtonDown("Jump") )
        {
            print("Space Button is Pressed First Time");
            
            GetComponent<Renderer>().material.color = Color.green;
        }
        */

        // Horizontal and Vertical values from Input Manager
        // Horizontal = left and right movement
        // Vertical = up and down movemnt
        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        print(xInput);

        // Input.GetAxisRaw();

        // move cube to left and right/ up and down
        transform.Translate(xInput, yInput, 0);


    }
}
