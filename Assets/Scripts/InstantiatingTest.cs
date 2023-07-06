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
    }

    // Update is called once per frame
    void Update()
    {
        // If we click left button of mouse our ball will appear
        if ( Input.GetMouseButtonDown (0)) { // 0 = left button of mouse
            
            int randomNumber = Random.Range(0, ball.Length); // 0, 3
            
            Instantiate(ball[randomNumber], transform.position, Quaternion.identity);
        }
    }
}
