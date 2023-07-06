using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatingTest : MonoBehaviour
{

    // public GameObject ball;
    public GameObject[] ball;
    
    // Start is called before the first frame update
    void Start()
    {
        // our ball prefab should be attached to the ball public var in Unity editor
        // and our ball will appear at the same position with cube because our script is attached to it
        // Box Colider should be Off for Cube and for the ball Prefab we have to add Rigidbody in this case
        //Instantiate(ball, transform.position, Quaternion.identity); // Quaternion.identity = we don't want any rotation
    
        //Invoke("RandomBall", 5f); // after 5s running the game RandomBall function will be called
    
        InvokeRepeating("RandomBall", 2f, 1f); // after 2s running the game this piece of code will start executing and function will be called after each 1 sec
    }

    // Update is called once per frame
    void Update()
    {
        // If we click left button of mouse our ball will appear
        if ( Input.GetMouseButtonDown (0)) { // 0 = left button of mouse
            
            // int randomNumber = Random.Range(0, ball.Length); // 0, 3
            // Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

            print("Mouse is Clicked");
            CancelInvoke("RandomBall"); // stop calling function when we click left mouse button
        }
    }

    void RandomBall()
    {
        int randomNumber = Random.Range(0, ball.Length); // 0, 3
            
        Instantiate(ball[randomNumber], transform.position, Quaternion.identity);
    }
}
