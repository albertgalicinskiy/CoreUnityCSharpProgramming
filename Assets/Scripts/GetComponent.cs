using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{

    // Rigidbody rb;

    PlayerHealth health;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<typeOfComponent>()
        // rb = GetComponent<Rigidbody>();
        // rb.useGravity = false;
        // rb.mass = 10;

        GetComponent<Renderer>().material.color = Color.red; // change color

        // health = GetComponent<PlayerHealth>(); // take access for PlayerHealth.cs script and then change properies
        // health.lives = 9;

        // GetComponents<>(); - use it if it needs to have access to the type of the samesa components, many Box Coliders for instance

        GetComponentInChildren<Rigidbody>().useGravity = true; // get access to child object and change something there
        GetComponentInParent<Rigidbody>().useGravity = true; // get access to parent object and change something there
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
