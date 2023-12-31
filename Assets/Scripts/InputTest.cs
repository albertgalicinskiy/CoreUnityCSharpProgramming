using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    // public float speed;

    public GameObject ball;

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

        /*
        // Horizontal and Vertical values from Input Manager
        // Horizontal = left and right movement
        // Vertical = up and down movemnt
        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        print(xInput);

        // Input.GetAxisRaw();

        // move cube to left and right/ up and down
        transform.Translate(xInput, yInput, 0);
        */


        //if ( Input.GetButtonDown("Fire1") ) // For all the buttons in keyboard and mouse
        //{
            //print("Left Click");
        //}

        // if ( Input.GetMouseButtonDown(0) ) // 0 = click left mouse button, 1 right mouse button, 2 wheel press
        // {
        //     // print("Left Click");

        //     //print(Input.mousePosition);
        //     print(Input.mousePosition.x + " " + Input.mousePosition.y);

        //     /// When we click left mouse button the ball will apear in that place
        //     Vector3 pos = Input.mousePosition;
        //     pos.z = 10f;

        //     pos = Camera.main.ScreenToWorldPoint(pos);

        //     Instantiate(ball, pos, Quaternion.identity);
        //     ///

        // }

        // if ( Input.GetMouseButtonDown(1) ) // 1 = click right mouse button
        // {
        //     print("Right Click");
        // }

        // if ( Input.GetMouseButtonDown(2) ) // 2 = click wheel on mouse
        // {
        //     print("Wheel Click");
        // }

    }


    // It works when we attach script to the object
    // that we want to destroy and on that object
    // any Collider(Box, Sphere it doesn't matter) should have
    void OnMouseDown() {
        Destroy(gameObject);
    }
}
