using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
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


        if ( Input.GetButtonDown("Jump") )
        {
            print("Space Button is Pressed First Time");
            
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
